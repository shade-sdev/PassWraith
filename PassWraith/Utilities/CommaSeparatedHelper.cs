using CsvHelper.Configuration;
using CsvHelper;
using PassWraith.Data.Entities;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using PassWraith.Data;
using PassWraith.Utilities;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System;

public class CommaSeparatedHelper
{

    private static readonly string VALID_WEBSITE_REGEX = @"^(http(s)?://)?([\w-]+.)+[\w-]+(/[\w- ;,./?%&=]*)?$";


    public static async Task ImportExcel(string filePath, IPassWraithContext _context, bool isForChrome)
    {
        await Task.Run(async () =>
        {
            List<PasswordEntity> passwordEntities = await ToPasswordEntitiesAsync(filePath, isForChrome);
            List<List<PasswordEntity>> batches = SplitIntoBatches(passwordEntities, 100);

            foreach (var batch in batches)
            {
                await Task.Run(() => ProcessExcelData(batch, _context, isForChrome));
            }

            MessageBox.Show("Processing completed!");
        });
    }

    public static void ExportExcel(IPassWraithContext _context)
    {
        List<PasswordEntity> passwordEntities = _context.passwords.ToList();
        using (var writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/PassCrypt" + DateTime.Now.ToString("yyyyMMddTHHmmss") + ".csv"))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            csv.WriteHeader<PasswordEntity>();
            csv.NextRecord();
            csv.WriteRecords(passwordEntities);
        }
        Notification.ShowNotification(ToolTipIcon.Info, 3000, "Export CSV", "Exported to your desktop");
    }

    public static async Task<List<PasswordEntity>> ToPasswordEntitiesAsync(string filePath, bool isForChrome)
    {
        var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HeaderValidated = null,
            MissingFieldFound = null
        };

        var passwordEntities = new ConcurrentBag<PasswordEntity>();

        using (var reader = new StreamReader(filePath))
        using (var csv = new CsvReader(reader, csvConfig))
        {
            var dynamicRecords = csv.GetRecords<dynamic>();

            var records = dynamicRecords.Select(record =>
            {
                var dictionary = (IDictionary<string, object>)record;
                var values = dictionary.Values.Select(x => x != null ? x.ToString() : null).ToArray();
                return values;
            }).ToList();

            await Task.Run(() =>
            {
                Parallel.ForEach(records, record =>
                {
                    if (isForChrome)
                    {
                        var passwordEntity = new PasswordEntity
                        {
                            WebSiteName = record[0],
                            WebsiteSiteUrl = record[1],
                            UserName = record[2],
                            Password = record[3],
                            Notes = record[4]
                        };
                        passwordEntities.Add(passwordEntity);
                    }
                    else
                    {
                        var passwordEntity = new PasswordEntity
                        {
                            UserName = record[1],
                            Password = record[2],
                            WebSiteName = record[3],
                            WebsiteSiteUrl = record[4],
                            WebSiteIconUrl = record[5],
                            CardNumber = record[6],
                            PIN = record[7],
                            CardExpiryDate = BuildDate(record[8]),
                            Notes = record[9],
                            IsFavourite = false,
                            IsDeleted = false,
                            CredentialType = (PasswordEntity.Type)Enum.Parse(typeof(PasswordEntity.Type), record[12]),
                            CreationDate = DateTime.Now

                        };
                        passwordEntities.Add(passwordEntity);
                    }

                });
            });
        }

        return passwordEntities.ToList();
    }

    private static void ProcessExcelData(List<PasswordEntity> passwordEntities, IPassWraithContext _context, bool isForChrome)
    {
        foreach (var entity in passwordEntities)
        {
            if (isForChrome)
            {
                _context.Save(new PasswordEntity
                {
                    WebSiteName = string.IsNullOrEmpty(entity.WebSiteName) ? "Dummy" : entity.WebSiteName,
                    WebsiteSiteUrl = BuildWebsiteUrl(entity.WebsiteSiteUrl),
                    UserName = string.IsNullOrEmpty(entity.UserName) ? "Dummy" : entity.UserName,
                    Notes = entity.Notes,
                    Password = string.IsNullOrEmpty(entity.Password) ? PasswordHelper.EncryptString("Dummy", PasswordHelper.GetKey()) : PasswordHelper.EncryptString(entity.Password, PasswordHelper.GetKey())
                });
            } else
            {
                _context.Save(new PasswordEntity
                {
                    WebSiteName = string.IsNullOrEmpty(entity.WebSiteName) ? "Dummy" : entity.WebSiteName,
                    WebsiteSiteUrl = BuildWebsiteUrl(entity.WebsiteSiteUrl),
                    UserName = string.IsNullOrEmpty(entity.UserName) ? "Dummy" : entity.UserName,
                    Password = entity.Password,
                    WebSiteIconUrl = string.IsNullOrEmpty(entity.WebSiteIconUrl) ? null : entity.WebSiteIconUrl,
                    CardNumber = entity.CardNumber,
                    PIN = entity.PIN,
                    CardExpiryDate = entity.CardExpiryDate,
                    Notes = entity.Notes,
                    IsFavourite = false,
                    IsDeleted = false,
                    CredentialType = entity.CredentialType,
                    CreationDate = entity.CreationDate
                });
            }
        }
    }

    private static List<List<T>> SplitIntoBatches<T>(List<T> source, int batchSize)
    {
        var batches = new List<List<T>>();
        var sourceQuery = source.AsQueryable();

        while (sourceQuery.Any())
        {
            var batch = sourceQuery.Take(batchSize).ToList();
            batches.Add(batch);
            sourceQuery = sourceQuery.Skip(batchSize);
        }

        return batches;
    }

    public static string BuildWebsiteUrl(string websiteUrl)
    {
        if (string.IsNullOrEmpty(websiteUrl) || !(new Regex(VALID_WEBSITE_REGEX).IsMatch(websiteUrl)))
        {
            return "http://dummy.com";
        }

        return websiteUrl;
    }

    public static DateTime? BuildDate(string date)
    {
        if ( string.IsNullOrEmpty(date))
        {
            return null;
        }
        try
        {
            return (DateTime?)DateTime.Parse(date);
        } catch (Exception ex)
        {
            return null;
        }
    }

}
