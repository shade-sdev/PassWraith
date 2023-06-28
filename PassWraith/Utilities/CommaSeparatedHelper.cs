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

public class CommaSeparatedHelper
{

    private static readonly string VALID_WEBSITE_REGEX = @"^(http(s)?://)?([\w-]+.)+[\w-]+(/[\w- ;,./?%&=]*)?$";

    public static async Task<List<PasswordEntity>> ToPasswordEntitiesAsync(string filePath)
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
                    var passwordEntity = new PasswordEntity
                    {
                        WebSiteName = record[0],
                        WebsiteSiteUrl = record[1],
                        UserName = record[2],
                        Password = record[3],
                        Notes = record[4]
                    };

                    passwordEntities.Add(passwordEntity);
                });
            });
        }

        return passwordEntities.ToList();
    }

    public static async void ImportExcel(string filePath, IPassWraithContext _context)
    {
        await Task.Run(async () =>
        {
            List<PasswordEntity> passwordEntities = await ToPasswordEntitiesAsync(filePath);
            List<List<PasswordEntity>> batches = SplitIntoBatches(passwordEntities, 100);

            foreach (var batch in batches)
            {
                await Task.Run(() => ProcessExcelData(batch, _context));
            }

            MessageBox.Show("Processing completed!");
        });
    }

    private static void ProcessExcelData(List<PasswordEntity> passwordEntities, IPassWraithContext _context)
    {
        foreach (var entity in passwordEntities)
        {
            _context.Save(new PasswordEntity
            {
                WebSiteName = string.IsNullOrEmpty(entity.WebSiteName) ? "Dummy" : entity.WebSiteName,
                WebsiteSiteUrl = BuildWebsiteUrl(entity.WebsiteSiteUrl),
                UserName = string.IsNullOrEmpty(entity.UserName) ? "Dummy" : entity.UserName,
                Notes = entity.Notes,
                Password = string.IsNullOrEmpty(entity.Password) ? PasswordHelper.EncryptString("Dummy", PasswordHelper.GetKey()) : PasswordHelper.EncryptString(entity.Password, PasswordHelper.GetKey())
            });
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

}
