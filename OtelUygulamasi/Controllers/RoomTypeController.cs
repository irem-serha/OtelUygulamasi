using DataAccessLayer.Data;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace OtelUygulamasi.Controllers
{
    //
    public class RoomTypeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RoomTypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var RoomTypeList=_context.RoomTypes.ToList();
            return View(RoomTypeList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]  
        public IActionResult Create(RoomType gelen)
        {
            if (ModelState.IsValid)
            {
                _context.RoomTypes.Add(gelen);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
           
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            RoomType? duzelt = _context.RoomTypes.Where(u => u.RoomTypeId == id).FirstOrDefault();
            if (duzelt == null)
            {
                return NotFound();
            }
            return View(duzelt);   
        }
        [HttpPost]
        public IActionResult Edit(RoomType gelen)
        {
           if(ModelState.IsValid && gelen.RoomTypeId>0) 
            {
                _context.RoomTypes.Update(gelen);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            RoomType? silme = _context.RoomTypes.Where(u => u.RoomTypeId == id).FirstOrDefault();
            if (silme == null)
            {
                return NotFound();
            }
            return View(silme);
        }
        [HttpPost]
        public IActionResult Delete(RoomType gelen)
        {
            RoomType? silme = _context.RoomTypes.Where(u => u.RoomTypeId == gelen.RoomTypeId).FirstOrDefault();
            if (silme!=null)
            {
                _context.RoomTypes.Remove(silme);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
