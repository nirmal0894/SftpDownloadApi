using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SftpDownloadApi.Service;

namespace SftpDownloadApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SftpDownloadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetDownloadStatus()
        {
            var test = new SftpDownloadService();
            var response = test.DownloadFile();
            return null;
        }
    }
}
