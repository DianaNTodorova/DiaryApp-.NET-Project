using DiaryAPP.Data;
using DiaryAPP.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiaryAPP.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DiaryEntriesController(ApplicationDbContext db)
        {  _db = db; 
        }
        public IActionResult Index()
        {
            List <DiaryEntry> objDiaryEntryList = _db.DiaryEntries.ToList();
            return View(objDiaryEntryList);
        }
      
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DiaryEntry obj)
        {
            _db.DiaryEntries.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
