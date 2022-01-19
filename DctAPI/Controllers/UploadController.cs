using DctApi.Shared.Models;
using DctAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DctAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        private readonly IHinhAnhRepository hinhAnhRepo;

        public UploadController(IHinhAnhRepository hinhAnhRepo)
        {
            this.hinhAnhRepo = hinhAnhRepo;
        }

        [HttpPost, DisableRequestSizeLimit]
        public async Task<IActionResult> UploadAsync()
        {
            try
            {
                var form = await Request.ReadFormAsync();
                var file = form.Files.First();
                var folderName = Path.Combine("Resources", "Images");
                if (!string.IsNullOrEmpty(form["user"]))
                {
                    folderName = Path.Combine("Resources", "Images", "Users", form["user"]);
                    Directory.CreateDirectory(folderName);
                }
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    
                    var fullPath = Path.Combine(pathToSave, fileName);
                    Console.WriteLine(fullPath);
                    var dbPath = Path.Combine(folderName, fileName);
                    dbPath = dbPath.Replace('\\', '/');
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    var hinhAnh = new HinhAnhEntity();
                    hinhAnh.Ten = fileName;
                    hinhAnh.Url = dbPath;
                    int? id = await hinhAnhRepo.Upsert(hinhAnh);
                    return Ok(new { dbPath, id });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }
    }

}
