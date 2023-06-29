using PassWraith.Data.Entities;
using PassWraith.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace PassWraith.Data
{
    public class PassWraithContext : DbContext, IPassWraithContext
    {
        public PassWraithContext() : base(GetConnectionString())
        {
            
        }

        private static string GetConnectionString()
        {
            var appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var mdfFilePath = Path.Combine(appDirectory, "Passwraith.mdf");

            var connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={mdfFilePath};Integrated Security=False;MultipleActiveResultSets=True";
            return connectionString;
        }

        public DbSet<PasswordEntity> passwords { get; set; }
        public DbSet<UserPasswordEntity> UserPasswords { get; set; }

        public int Save(PasswordEntity password)
        {
            passwords.Add(password);
            return SaveChanges();
        }

        public int Update(int id, PasswordEntity password)
        {
            var existingEntity = passwords.Find(id);
            if (existingEntity != null)
            {
                existingEntity.UserName = password.UserName;
                existingEntity.WebSiteName = password.WebSiteName;
                existingEntity.WebsiteSiteUrl = password.WebsiteSiteUrl;
                existingEntity.WebSiteIconUrl = password.WebSiteIconUrl;
                existingEntity.Password = password.Password;
                existingEntity.CredentialType = password.CredentialType;
                existingEntity.CardNumber = password.CardNumber;
                existingEntity.PIN = password.PIN;
                existingEntity.CardExpiryDate = password.CardExpiryDate;
                existingEntity.Notes = password.Notes;
                return SaveChanges();
            }
            return 0;
        }

        public List<PasswordEntity> GetAll()
        {
            return passwords.OrderBy(pass => pass.WebSiteName).ToList();
        }

        public List<PasswordEntity> Filter(FilterType filterType, string search, int pageNumber, int pageSize)
        {
            IQueryable<PasswordEntity> query = passwords.AsQueryable();

            switch (filterType)
            {
                case FilterType.FAV:
                    query = query.Where(password =>
                        (string.IsNullOrEmpty(search) || password.WebSiteName.ToLower().Contains(search) || password.UserName.ToLower().Contains(search))
                        && password.IsFavourite);
                    break;

                case FilterType.DEL:
                    query = query.Where(password =>
                        (string.IsNullOrEmpty(search) || password.WebSiteName.ToLower().Contains(search) || password.UserName.ToLower().Contains(search))
                        && password.IsDeleted);
                    break;

                case FilterType.ALL:
                default:
                    query = query.Where(password =>
                        string.IsNullOrEmpty(search) || password.WebSiteName.ToLower().Contains(search) || password.UserName.ToLower().Contains(search));
                    break;
            }

            return query
                .OrderBy(p => p.WebSiteName)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public List<PasswordEntity> GetPasswordEntities(int pageNumber, int pageSize)
        {
            var passwordEntities = passwords.OrderBy(p => p.WebSiteName)
                                            .Skip((pageNumber - 1) * pageSize)
                                            .Take(pageSize)
                                            .ToList();

            return passwordEntities;
        }

        public PasswordEntity Get(int id)
        {
            return passwords.Where(pass => pass.Id.Equals(id)).First();
        }

        public void SetFavourite(int id)
        {
            var existingEntity = passwords.Find(id);
            existingEntity.IsFavourite = !existingEntity.IsFavourite;
            SaveChanges();
        }

        public UserPasswordEntity Get()
        {
            return UserPasswords?.FirstOrDefault();
        }

        public bool IsUserRegistered()
        {
            return UserPasswords?.ToList().Count() == 1;
        }

        public int Save(UserPasswordEntity user)
        {
            if (UserPasswords.ToList().Count == 0)
            {
                UserPasswords?.Add(user);
                return SaveChanges();
            }

            return 0;
        }

        public async Task SaveAsync(PasswordEntity password)
        {
            passwords.Add(password);
            await SaveChangesAsync();
        }
    }
}