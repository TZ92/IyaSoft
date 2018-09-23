using IyaSoft.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IyaSoft.Data
{
    public class IyaSoftContext : DbContext
    {
        public IyaSoftContext() : base ("DefaultConnection")
        {
            Database.SetInitializer<IyaSoftContext>(new IyaSoftContextInitializer());
        }


        public DbSet<Product> Products { get; set; }
        
    }
}
