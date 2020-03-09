using ScholarshipHub.Models;
using ScholarshipHub.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScholarshipHub.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CreateStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateStudent(Student student,HttpPostedFileBase ImageFile, HttpPostedFileBase CVFile)
        {
            UserRepository userRepo = new UserRepository();
            StudentRepository studentRepo = new StudentRepository();
            
            var user = new User()
            {
                Username = student.Username,
                Password = student.Password,
                Status = 1
            };
            var fileName = Path.GetFileNameWithoutExtension(CVFile.FileName);
            var fileExt = Path.GetExtension(CVFile.FileName);
            fileName = student.Username + "-" + fileName + fileExt;
            var fileUpdatePath = ConfigurationManager.AppSettings["FilesPath"];
            student.CVPath = fileUpdatePath + "\\" + fileName;
            CVFile.SaveAs(student.CVPath);
            student.CVPath = fileName;

            fileName = Path.GetFileNameWithoutExtension(ImageFile.FileName);
            fileExt = Path.GetExtension(ImageFile.FileName);
            fileName = student.Username + "-" + fileName + fileExt;
            fileUpdatePath = ConfigurationManager.AppSettings["ImagesPath"];
            student.ImagePath = fileUpdatePath + "\\" + fileName;
            ImageFile.SaveAs(student.ImagePath);
            student.ImagePath = fileName;

            studentRepo.Insert(student);
            userRepo.Insert(user);
            return RedirectToAction("Index", "Student");
        }

}
}