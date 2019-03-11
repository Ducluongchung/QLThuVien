namespace WebMVC.Data.Migrations
{
    using GenFu;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebMVC.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<WebMVC.Data.TestMVCDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(WebMVC.Data.TestMVCDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            DbContextSeed(context);
        }

        private void DbContextSeed(TestMVCDbContext context, int retry = 0)
        {
            int retryForAvaiability = retry;
            try
            {
                Sach(context);
                //ChuDe(context);
                //Sach(context);
                //NhaXuatBan(context);
              
            }
            catch (Exception ex)
            {
                if (retryForAvaiability < 10)
                {
                    retryForAvaiability++;

                    DbContextSeed(context, retryForAvaiability);
                }
            }
        }
        public void Sach(TestMVCDbContext context)
        {
            if (!context.NhanViens.Any())
            {
                A.Configure<Sach>()
                    .Fill(s => s.Name);
                var sach = A.ListOf<Sach>(50);
                context.Saches.AddRange(sach);
                context.SaveChanges();
                //context.Suppliers.Add(new Supplier()
                //{
                //    Name = "SamSung Viet Nam",
                //    CodeName = "SSVN",
                //    Email = "samsung.vietnam@gmail.com",
                //    Phone = "0971489926"
                //});
                //context.SaveChanges();

                //context.Suppliers.Add(new Supplier()
                //{
                //    Name = "LG Viet Nam",
                //    CodeName = "LGVN",
                //    Email = "LG.vietnam@gmail.com",
                //    Phone = "0971489926"
                //});
                //context.SaveChanges();
            }
        }
    }
}
