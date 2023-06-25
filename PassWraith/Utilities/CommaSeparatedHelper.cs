using CsvHelper.Configuration;
using CsvHelper;
using PassWraith.Data.Entities;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System;
using PassWraith.Utilities;

public class CommaSeparatedHelper
{
    public static List<PasswordEntity> ToPasswordEntities(string csvFilePath)
    {
        List<PasswordEntity> passwordEntities = new List<PasswordEntity>();

        using (var reader = new StreamReader(csvFilePath))
        using (var csv = new CsvParser(reader, CultureInfo.InvariantCulture))
        {

            csv.Read();
            var headerRow = csv.Record;

            var nameIndex = Array.IndexOf(headerRow, "name");
            var urlIndex = Array.IndexOf(headerRow, "url");
            var usernameIndex = Array.IndexOf(headerRow, "username");
            var passwordIndex = Array.IndexOf(headerRow, "password");
            var noteIndex = Array.IndexOf(headerRow, "note");

            while (csv.Read())
            {
                var record = csv.Record;

                var passwordEntity = new PasswordEntity
                {
                    WebSiteName = nameIndex >= 0 ? record[nameIndex] : "http://dummy.com",
                    WebsiteSiteUrl = urlIndex >= 0 ? record[urlIndex] : null,
                    UserName = usernameIndex >= 0 ? record[usernameIndex] : string.Empty,
                    Password = passwordIndex >= 0 ? PasswordHelper.EncryptString(record[passwordIndex],
                    Constants.key) : string.Empty,
                    Notes = noteIndex >= 0 ? record[noteIndex] : string.Empty,
                    CredentialType = PasswordEntity.Type.Login
                };

                passwordEntities.Add(passwordEntity);
            }
        }

        return passwordEntities;
    }


}
