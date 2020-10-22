using BlogPessoal.Web.Data.Contexto;
using BlogPessoal.Web.Models.CategoriasDeArtigo;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace BlogPessoal.Web.Controllers
{
    public class CategoriasDeArtigoController : Controller
    {
        private BlogPessoalContexto db = new BlogPessoalContexto();

        public ActionResult Index()
        {
            var categorias = db.CategoriasDeArtigo
                .OrderBy(t => t.Nome)
                .ToList();
            return View(categorias);
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(CategoriaDeArtigo categoria)
        {
            if (ModelState.IsValid)
            {
                db.CategoriasDeArtigo.Add(categoria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoria);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var categoria = db.CategoriasDeArtigo.Find(id);
            if (categoria == null)
                return HttpNotFound();
            return View(categoria);
        }

        [HttpPost]
        public ActionResult Edit(CategoriaDeArtigo categoria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoria);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var categoria = db.CategoriasDeArtigo.Find(id);
            if (categoria == null)
                return HttpNotFound();
            return View(categoria);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var categoria = db.CategoriasDeArtigo.Find(id);
            db.CategoriasDeArtigo.Remove(categoria);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}