using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDemo.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    //Ajax
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterList()
        {
            var jsonWriters = JsonConvert.SerializeObject(writers);
            return Json(jsonWriters);
        }
        //Ajax İle İd'ye göre yazar getirme.
        public IActionResult GetWriterByID(int writerid)
        {
            var findWriter = writers.FirstOrDefault(x => x.Id == writerid);
            var jsonWriters = JsonConvert.SerializeObject(findWriter);
            return Json(jsonWriters);
        }
        //Ajax İle Ekleme
        [HttpPost]
        public IActionResult AddWriter(WriterClass w)
        {
            writers.Add(w);
            var jsonWriters = JsonConvert.SerializeObject(w);
            return Json(jsonWriters);
        }
        //Ajax İle Silme
        public IActionResult DeleteWriter(int id)
        {
            var writer = writers.FirstOrDefault(x => x.Id == id);
            writers.Remove(writer);
            return Json(writer);
        }
        //Ajax İle Güncelleme
        public IActionResult UpdateWriter(WriterClass w)
        {
            var writer = writers.FirstOrDefault(x => x.Id == w.Id);
            writer.Name = w.Name;
            var jsonWriter = JsonConvert.SerializeObject(w);
            return Json(jsonWriter);
        }
        public static List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass
            {
                Id=1,
                Name="Ayşe"
            },
            new WriterClass
            {
                Id=2,
                Name="Enes"
            },
            new WriterClass
            {
                Id=3,
                Name="Buse"
            }
        };
    }
}