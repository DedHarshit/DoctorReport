using DoctorReport.Data;
using DoctorReport.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoctorReport.Controllers
{
    public class DoctorController : Controller
    {
        private readonly ApplicationDbContext _db;
        public DoctorController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Doctor>_ObjDonctor = _db.Doctors.ToList();
            return View(_ObjDonctor);
        }
    }
}
