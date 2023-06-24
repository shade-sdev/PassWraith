using PassWraith.Data.Entities;
using System.Collections.Generic;
using System.Data.Entity;

namespace PassWraith.Data
{
    public  interface IPassWraithContext
    {
        DbSet<PasswordEntity> passwords { get; set; }
        // Define other DbSet properties and methods you need
        int Save(PasswordEntity password);
        int Update(int id, PasswordEntity password);
        PasswordEntity Get(int id);

        void SetFavourite(int id);

        List<PasswordEntity> GetAll();
    }
}
