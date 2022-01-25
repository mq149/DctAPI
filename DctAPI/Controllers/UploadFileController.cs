using DctApi.Shared.Models;
using DctAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DctAPI.Controllers {
    [Route("api/[Controller]")]
    [ApiController]
    public class UploadFileController : ControllerBase {
        private readonly IHopDongRepository _hopdongRepo;

        public UploadFileController(IHopDongRepository hopdongRepo) {
            this._hopdongRepo = hopdongRepo;
        }

        [HttpPost, DisableRequestSizeLimit]
        public async Task<IActionResult> UploadHopDongAsync([FromForm] IFormCollection form) {
            try {
                //var form = await Request.ReadFormAsync();
                var file = form.Files.First();
                var folderName = Path.Combine("Resources", "Contracts");
                if (!string.IsNullOrEmpty(form["userName"])) {
                    folderName = Path.Combine("Resources", "Contracts", form["userName"]);
                    Directory.CreateDirectory(folderName);
                }
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                if (file.Length > 0) {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    if (!string.IsNullOrEmpty(form["fileName"])) {
                        var fileExtension = Path.GetExtension(fileName);
                        fileName = form["fileName"] + fileExtension;
                    }
                    var fullPath = Path.Combine(pathToSave, fileName);
                    Console.WriteLine(fullPath);
                    var Url = Path.Combine(folderName, fileName);
                    Url = Url.Replace('\\', '/');
                    using (var stream = new FileStream(fullPath, FileMode.Create)) {
                        file.CopyTo(stream);
                    }
                    var hopdong = new HopDongEntity();
                    hopdong.Url = Url;
                    int? Id = await _hopdongRepo.Upsert(hopdong);
                    return Ok(new { Url, Id });
                }
                else {
                    return BadRequest();
                }
            }
            catch (Exception ex) {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }
    }
}
