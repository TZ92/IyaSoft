using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IyaSoft.Data;
using IyaSoft.Domain.Entities;

namespace IyaSoft.Web.Controllers
{
    public class ProductsController : Controller
    {
        private IyaSoftContext db = new IyaSoftContext();

        // GET: Products
        public ActionResult Index(string search , double? price , DateTime? date)
        {
           

            if (search != null && price !=null)
            {
                return View(db.Products.Where(x =>
                                (x.Name.ToUpper().Contains(search.ToUpper())
                                || x.Description.ToUpper().Contains(search.ToUpper())
                                || x.Tag.ToUpper().Contains(search.ToUpper())


                                )
                                && (price >= x.Price)



                                )

                                );
            }

            if (search != null && date != null)
            {
                return View(db.Products.Where(x =>
                                (x.Name.ToUpper().Contains(search.ToUpper())
                                || x.Description.ToUpper().Contains(search.ToUpper())
                                || x.Tag.ToUpper().Contains(search.ToUpper())


                                )
                                && (date >= x.AvailableOn)
                                )

                                );
            }
            if (search != null && date != null && price !=null)
            {
                return View(db.Products.Where(x =>
                                (x.Name.ToUpper().Contains(search.ToUpper())
                                || x.Description.ToUpper().Contains(search.ToUpper())
                                || x.Tag.ToUpper().Contains(search.ToUpper())


                                )
                                && (price >= x.Price)
                                && (date >= x.AvailableOn)

                                )

                                );
            }

            if (search != null )
            {
                return View(db.Products.Where(x =>
                                (x.Name.ToUpper().Contains(search.ToUpper())
                                || x.Description.ToUpper().Contains(search.ToUpper())
                                || x.Tag.ToUpper().Contains(search.ToUpper())

                                )
                                )
                                );
            }

            return View(db.Products.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductId,Name,Description,Price,Quantity,Tag,AvailableOn")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductId,Name,Description,Price,Quantity,Tag,AvailableOn")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
