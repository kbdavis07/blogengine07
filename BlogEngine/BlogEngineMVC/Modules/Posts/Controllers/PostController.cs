using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlogEngineMVC.Modules.Posts.DAL.EF;

namespace BlogEngineMVC.Modules.Posts.Controllers
{
    public class PostController : Controller
    {
        private PostContext db = new PostContext();

        // GET: Post
        public async Task<ActionResult> List()
        {
            return View(await db.be_Posts.ToListAsync());
        }

        // GET: Post/Index/be-seo
        [Route("{id=local-test}")]
        public async Task<ActionResult> Index(string id)
        {
            var PostId = db.be_Posts.Where(s => s.Slug == id).Select(p => p.PostRowID).SingleOrDefault();

            be_Post be_Post = await db.be_Posts.FindAsync(PostId);

            if (be_Post == null)
            {
                return HttpNotFound();
            }
            return View(be_Post);
        }



        // GET: Post/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            be_Post be_Post = await db.be_Posts.FindAsync(id);
            if (be_Post == null)
            {
                return HttpNotFound();
            }
            return View(be_Post);
        }

        // GET: Post/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Post/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "PostRowID,BlogID,PostID,Title,Description,PostContent,DateCreated,DateModified,Author,IsPublished,IsCommentEnabled,Raters,Rating,Slug,IsDeleted")] be_Post be_Post)
        {
            if (ModelState.IsValid)
            {
                db.be_Posts.Add(be_Post);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(be_Post);
        }

        // GET: Post/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            be_Post be_Post = await db.be_Posts.FindAsync(id);
            if (be_Post == null)
            {
                return HttpNotFound();
            }
            return View(be_Post);
        }

        // POST: Post/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "PostRowID,BlogID,PostID,Title,Description,PostContent,DateCreated,DateModified,Author,IsPublished,IsCommentEnabled,Raters,Rating,Slug,IsDeleted")] be_Post be_Post)
        {
            if (ModelState.IsValid)
            {
                db.Entry(be_Post).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(be_Post);
        }

        // GET: Post/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            be_Post be_Post = await db.be_Posts.FindAsync(id);
            if (be_Post == null)
            {
                return HttpNotFound();
            }
            return View(be_Post);
        }

        // POST: Post/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            be_Post be_Post = await db.be_Posts.FindAsync(id);
            db.be_Posts.Remove(be_Post);
            await db.SaveChangesAsync();
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
