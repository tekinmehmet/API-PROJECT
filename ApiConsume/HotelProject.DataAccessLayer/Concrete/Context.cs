using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        //burada yaptığımız işlem ekleyeceğimiz migration çin bağlantı kısmını ezmek ve istediğimiz bağlantıya gidip bizim için bizim vereceğimiz isimle bir veri tabanı oluşturmasını sağlamak.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MEHMETTEKIN\\MSSQL;initial catolog=ApiDb;integrated security=true");// burada dedikki dostum bağlantı adresinin adı şu initial catolog kısmında da veri tabanı adın bu doğrulama ile de gir dedik.
        }

        //şimdi de entitylerimizi eklemeliyiz ki db içindeki tablolarmız oluşsun

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
