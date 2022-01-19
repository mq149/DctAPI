using DctApi.Shared.Models;
using DctAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DctAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HinhAnhController : ControllerBase
    {
        private readonly IHinhAnhRepository hinhAnhRepo;
        private readonly IWebHostEnvironment hostEnvironment;

        public HinhAnhController(IHinhAnhRepository hinhAnhRepo, IWebHostEnvironment hostEnvironment)
        {
            this.hinhAnhRepo = hinhAnhRepo;
            this.hostEnvironment = hostEnvironment;
        }

        //// GET: api/<HinhAnhController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<HinhAnhController>/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<HinhAnhEntity>> Get(int id)
        //{
        //    var hinhAnh = await hinhAnhRepo.FindAsync(id);
        //    if (hinhAnh == null)
        //    {
        //        return NotFound();
        //    }
        //    return hinhAnh;
        //}

        //// POST api/<HinhAnhController>
        //[HttpPost]
        //public void Post([FromBody] HinhAnhEntity request)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        string wwwRootPath = hostEnvironment.WebRootPath;
        //        string fileName = Path.GetFileNameWithoutExtension(request.Anh.FileName);
        //        string extension = Path.GetExtension()
        //    }
        //}

        //// PUT api/<HinhAnhController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<HinhAnhController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
