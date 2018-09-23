using IyaSoft.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IyaSoft.Data
{
    public class IyaSoftContextInitializer : DropCreateDatabaseIfModelChanges<IyaSoftContext>
    {

        protected override void Seed(IyaSoftContext context)
        {
            var listProducts = new List<Product>{
                new Product{
                        Name ="Maillot Inter Milan 2018/19 Domicile" ,
                        Description ="Maillot de football 2018/19 Inter Milan Domicile Noir	",
                        Price =89,
                        Quantity =100 ,
                        Tag ="Nike, Inter, Milan, Foot, Football, 2018, 2019, Domicile, Noir",
                        AvailableOn = new DateTime(2018,09,20)
                        },
                new Product{
                        Name ="Maillot Inter Milan 2018/19 Exterieur" ,
                        Description ="Maillot de football 2018/19 Inter Milan Exterieur Blanc",
                        Price =89,
                        Quantity =50 ,
                        Tag ="Nike, Inter, Milan, Foot, Football, 2018, 2019, Exterieur, Blanc",
                        AvailableOn = new DateTime(2018,09,25)
                        }

            };

            context.Products.AddRange(listProducts);
            context.SaveChanges();
        }


    }
}
