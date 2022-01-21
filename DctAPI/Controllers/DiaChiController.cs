using DctApi.Shared.Models;
using DctAPI.Models;
using DctAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DctAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiaChiController : ControllerBase
    {
        private readonly IDiaChiRepository DiaChiRepo;
        private readonly IDonHangRepository DonHangRepo;
        private readonly IKhachHangRepository KhachHangRepo;

        public DiaChiController(IDiaChiRepository DiaChiRepo,IDonHangRepository DH, IKhachHangRepository KH)
        {
            this.DiaChiRepo = DiaChiRepo;
            this.DonHangRepo = DH;
            this.KhachHangRepo = KH;

        }
        // GET: api/<DiaChiController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DiaChiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        [HttpGet("getdiachidathang/{id}")]
        public async Task<List<DiaChiDatHangModel>>  GetDiaChiDatHang(int id)
        {
          
            List<DiaChiDatHangModel> listDiaChi = new List<DiaChiDatHangModel>();
 
            var khachHang = await KhachHangRepo.findIdKhachHang(id);
            if (khachHang < 1)
            {
                return null;

            }
            var donhang = await DonHangRepo.GetAllDonHangByUser(khachHang);
            if (donhang != null)
            {
                for (int i = 0; i < donhang.Count; i++)
                {
                    DiaChiDatHangModel diachiNhanHang = new DiaChiDatHangModel();
                    DiaChiEntity diaChi = await DiaChiRepo.Find(donhang[i].DiaChiGiaoId);
                    diachiNhanHang.Id = diaChi.Id;
                    diachiNhanHang.SDT = donhang[i].SDT;
                    diachiNhanHang.NguoiNhan = donhang[i].NguoiNhan;
                    diachiNhanHang.SoNhaTo = diaChi.SoNhaTo;
                    diachiNhanHang.Duong = diaChi.Duong;
                    diachiNhanHang.XaPhuong = diaChi.XaPhuong;
                    diachiNhanHang.QuanHuyen = diaChi.QuanHuyen;
                    diachiNhanHang.TinhTP = diaChi.TinhTP;
                
                        

        listDiaChi.Add(diachiNhanHang);
                }
                return listDiaChi;
            }
           
            return null;
        }
        // POST api/<DiaChiController>
        [HttpPost]
        public async Task<ActionResult<int>> Post([FromBody] DiaChiEntity dc)
        {
            return await DiaChiRepo.TaoDiaChi(dc);
        }

        // PUT api/<DiaChiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DiaChiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
