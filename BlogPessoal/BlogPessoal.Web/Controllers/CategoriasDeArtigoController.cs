using BlogPessoal.Web.Data.Contexto;
using BlogPessoal.Web.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace BlogPessoal.Web.Controllers
{
    [Authorize]
    public class CategoriasDeArtigoController : Controller
    {
        private BlogPessoalContexto db = new BlogPessoalContexto();

        public ActionResult Index()
        {
            var lista = db.CategoriasDeArtigo
                .OrderBy(t => t.Nome)
                .ToList();
            return View(lista);
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
    }
}