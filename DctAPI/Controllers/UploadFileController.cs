using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DctAPI.Controllers {
    [Route("api/[Controller]")]
    [ApiController]
    public class UploadFileController : ControllerBase {
        public static IWebHostEnvironment _env;
        public UploadFileController(IWebHostEnvironment env) {
            _env = env;
        }

        public class UpLoadFileAPI {
            public IFormFile files { get; set; }
        }

        [HttpPost]
        public async Task<string> PostFile([FromForm]UpLoadFileAPI objfile) {
            try {
                if (objfile.files.Length > 0) {
                    if (!Directory.Exists(_env.WebRootPath + "\\Upload\\")) {
                            Directory.CreateDirectory(_env.WebRootPath + "\\Upload\\");
                        }
                    using (FileStream fileStream = System.IO.File.Create(_env.WebRootPath + "\\Upload\\" + objfile.files.FileName)) {
                        objfile.files.CopyTo(fileStream);
                        fileStream.Flush();
                        return "\\Upload\\" + objfile.files.FileName;
                    }
                }
                else {
                    return "Upload File Failed!";
                }
            }
            catch(Exception ex) {
                return ex.Message.ToString();
            }
        }

        [HttpDelete]
        public async Task<string> DeleteFile(string fileName) {
            if(fileName.Length>0) {
                var path = Path.Combine(_env.WebRootPath + "\\Upload\\" + fileName);
                if(System.IO.File.Exists(path)) {
                    System.IO.File.Delete(path);
                    return "Delete success";
                }
                else {
                    return "Not found file";
                }
            }
            else {
                return "File Name is not empty";
            }
        }
    }
}
