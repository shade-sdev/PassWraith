using PassWraith.Data.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace PassWraith.Data
{
    public  interface IPassWraithContext
    {
        DbSet<PasswordEntity> passwords { get; set; }
        // Define other DbSet properties and methods you need
        int Save(PasswordEntity password);
        Task SaveAsync(PasswordEntity password);
        int Update(int id, PasswordEntity password);
        PasswordEntity Get(int id);
        List<PasswordEntity> GetPasswordEntities(int pageNumber, int pageSize);
        void SetFavourite(int id);
        void Delete(int id);
        void DeleteById(int id);
        void Restore(int id);
        List<PasswordEntity> Filter(FilterType filterType, string search, int pageNumber, int pageSize);
        List<PasswordEntity> GetAll();

        int Save(UserPasswordEntity user);

        bool IsUserRegistered();

        UserPasswordEntity Get();
    }
}
