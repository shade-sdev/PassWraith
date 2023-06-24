using PassWraith.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PassWraith.Data
{
    public class PassWraithContext : DbContext, IPassWraithContext
    {

        public PassWraithContext() : base(
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" +
              Environment.CurrentDirectory +
              @"\Passwraith.mdf;Integrated Security=False;MultipleActiveResultSets=True")
        {
        }


        public DbSet<PasswordEntity> passwords { get; set; }

        public int Save(PasswordEntity password)
        {
            passwords.Add(password);
            return SaveChanges();
        }

        public int Update(int id,PasswordEntity password)
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
    }
}
