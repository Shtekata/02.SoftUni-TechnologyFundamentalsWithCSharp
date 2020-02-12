using RescueRegister.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace RescueRegister.Controllers
{
    public class MountaineerController : Controller
    {
        private readonly RescueRegisterDbContext context;

        public MountaineerController(RescueRegisterDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            using (var db=new RescueRegisterDbContext())
            {
                var resque = db.Mountaineers.ToList();
                return this.View(resque);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {

            return this.View();
        }

        [HttpPost]
        public IActionResult Create(Mountaineer mountaineer)
        {
            using (var db=new RescueRegisterDbContext())
            {
                var newMoutaineer = new Mountaineer
                {
                    Name = mountaineer.Name,
                    Age=mountaineer.Age,
                    Gender=mountaineer.Gender,
                    LastSeenDate=mountaineer.LastSeenDate
                };
                db.Mountaineers.Add(newMoutaineer);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db=new RescueRegisterDbContext())
            {
                var mountaineerToEdit = db.Mountaineers.Find(id);
                return View(mountaineerToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Mountaineer mountaineer)
        {
            using (var db=new RescueRegisterDbContext())
            {
                db.Update(mountaineer);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db=new RescueRegisterDbContext())
            {
                var mountaineerToDelete = db.Mountaineers.Find(id);
                return View(mountaineerToDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Mountaineer mountaineer)
        {
            using (var db=new RescueRegisterDbContext())
            {
                db.Mountaineers.Remove(mountaineer);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}