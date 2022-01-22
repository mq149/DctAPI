using DctApi.Shared.Enums;
using DctApi.Shared.Models;
using DctAPI.Models;

using DctAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

// M Quân: Ai làm CRUD đơn hàng thì cứ làm trên file này nha, tui làm phần xác nhận với huỷ đơn trước

namespace DctAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonHangController : ControllerBase
    {
        private readonly IDonHangRepository donHangRepo;
        private readonly IShipperRepository shipperRepo;
        private readonly IKhachHangRepository khachHangRepo;
        private readonly ICuaHangRepository cuahangRepo;
        private readonly IDiaChiRepository diachiRepo;
        private readonly ITrangThaiDonHangRepository trangthaidonhangRepo;
        private readonly IPhuongThucThanhToanRepository phuongThucThanhToanRepo;
        IChiTietDonHangRepository chiTietDonHangRepo;
        public DonHangController(IDonHangRepository donHangRepo,
            IShipperRepository shipperRepo,
            IKhachHangRepository khachHangRepo,
            ICuaHangRepository cuahangRepo,
            IDiaChiRepository diachiRepo,
            ITrangThaiDonHangRepository trangthaidonhangRepo,
            IPhuongThucThanhToanRepository phuongThucThanhToanRepo,
            IChiTietDonHangRepository chiTietDonHangRepo
            )
        {
            this.donHangRepo = donHangRepo;
            this.shipperRepo = shipperRepo;
            this.khachHangRepo = khachHangRepo;
            this.cuahangRepo = cuahangRepo;
            this.diachiRepo = diachiRepo;
            this.trangthaidonhangRepo = trangthaidonhangRepo;
            this.phuongThucThanhToanRepo = phuongThucThanhToanRepo;
            this.chiTietDonHangRepo = chiTietDonHangRepo;
        }

        // GET: api/<DonHangController>
        [HttpGet]
        public async Task<IEnumerable<DonHangEntity>> Get()
        {
            return await donHangRepo.GetAllDonHang();
            //return donHangRepo.GetAll();
        }

        // GET: api/<DonHangController>/ChoXacNhan
        [HttpGet("ChoXacNhan")]
        public IEnumerable<DonHangEntity> GetChoXacNhan()
        {
            return donHangRepo.GetChoXacNhan();
        }

        // GET api/<DonHangController>/5
        [HttpGet("{id}")]
        public async Task<DonHangEntity> Get(int id)
        {
            return await donHangRepo.GetDonHang(id);
        }

        // POST api/<DonHangController>
        [HttpPost]
        public async Task<ActionResult<DonHangEntity>> PostDonHang([FromBody] DonHangEntity dh)
        {
            var result = await donHangRepo.PostDonHang(dh);
            return result;
        }

        // PUT api/<DonHangController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DonHangController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // POST api/<DonHangController>/{id}/XacNhan/{shipperId}
        [HttpPost("{id}/ShipperXacNhan/{shipperId}")]
        public async Task<ActionResult<DonHangEntity>> ShipperXacNhanDonHang(int id, int shipperId)
        {
            var donHang = await donHangRepo.GetDonHang(id);
            var shipper = await shipperRepo.Find(shipperId);
            if (donHang != null && shipper != null)
            {
                if (donHang.TTDHId == (int)TrangThaiDonHang.CuaHangDaXacNhan
                    && shipper.KichHoat
                    && donHang.ShipperId == null)
                {
                    var _donHang = await donHangRepo.ShipperXacNhanDonHang(donHang, shipper);
                    if (_donHang != null)
                    {
                        return Ok(_donHang);
                    }
                }
            }
            return BadRequest("Yeu cau khong hop le");
        }

        // POST api/<DonHangController>/{id}/Huy/{shipperId}
        [HttpPost("{id}/ShipperHuy/{shipperId}")]
        public async Task<ActionResult<DonHangEntity>> ShipperHuyDonHang(int id, int shipperId)
        {
            var donHang = await donHangRepo.Find(id);
            var shipper = await shipperRepo.Find(shipperId);
            if (donHang != null && shipper != null)
            {
                if ((donHang.TTDHId == (int)TrangThaiDonHang.DangLayHang
                    || donHang.TTDHId == (int)TrangThaiDonHang.DangGiaoHang)
                    && shipper.Id == donHang.ShipperId)
                {
                    var _donHang = await donHangRepo.ShipperHuyDonHang(donHang);
                    if (_donHang != null)
                    {
                        return Ok(_donHang);
                    }
                }
            }
            return BadRequest("Yeu cau khong hop le");
        }

        [HttpPost("KhachHangDatHang")]
        public async Task<ActionResult<DonHangEntity>> KhachHangDatHang(DonHangEntity dh)
        {
            try
            {//kiểm trác khách hàng có tồn tại không
                var khachHang = await khachHangRepo.findIdKhachHang(dh.KhachHangId);
                if (khachHang < 0 )
                {
                    return BadRequest(1);
                }
                var cuahang = await cuahangRepo.Find(dh.CuaHangId);
                // kiểm tra cửa hàng có tồn tại không
                if (cuahang == null)
                {
                    return BadRequest(2);
                }
                if (dh.DiaChiGiaoId > 0)
                {
                    dh.DiaChiGiao = null;
                    if (await diachiRepo.Find(dh.DiaChiGiaoId) == null)
                    {
                        return BadRequest(3);
                    }
                }
                else
                {
                    dh.DiaChiGiaoId = await diachiRepo.TaoDiaChi(dh.DiaChiGiao);

                }
                dh.KhachHangId = khachHang;
                dh.TTDHId = 1;
                var listSP = dh.ListSanPham;
                //tạo danh sách sản phẩm null của đơn hàng sau khi đã gán vào listSP
                dh.ListSanPham = null;
                var PTTT = await phuongThucThanhToanRepo.Find(dh.PTTTId);
                //Tạo đơn hàng
                var result = await donHangRepo.PostDonHang(dh);

                if (result != null && listSP.Count != 0)
                {
                    for (int i = 0; i < listSP.Count; i++)
                    {
                        var temp = new ChiTietDonHangEntity();
                        temp.DonHangId = dh.Id;
                        temp.SanPhamId = listSP[i].Id;
                        temp.DonGia = listSP[i].GiaSP;
                        temp.SoLuong = listSP[i].SoLuong;

                        //khởi tạo chi tiết đơn hàng của từng sản phẩm
                        await chiTietDonHangRepo.TaoChiTietDonHang(temp);

                    }
                }
                else { return BadRequest(4); }


                return Ok(1);
            }
            catch (IndexOutOfRangeException e)
            {
                return BadRequest(e.Message);
            }


        }

        //GET DonHangByUser
        //[HttpGet("DonHangByUser")]
        //public async Task<List<DonHangEntity>> GetAllDonHang(int user)
        //{
        //    var donhangs = await donHangRepo.GetAllDonHangByUser(user);
        //    return donhangs;
        //}

        [HttpGet("DonHangDangXuLy")]
        //Trang thai # DaHuy + DaGiaoHang
        public async Task<List<DonHangEntity>> GetDonHangDangXuLy(int KH)
        {
            var donhangs = await donHangRepo.GetAllDonHangByUser(KH);
            List<DonHangEntity> dangxuly = new List<DonHangEntity>();
            foreach(var processing in donhangs)
            {
                if(processing.TTDHId !=(int)TrangThaiDonHang.DaGiaoHang && processing.TTDHId != (int)TrangThaiDonHang.DaHuy)
                {
                    dangxuly.Add(processing);
                }    
            }    
            return dangxuly;
        }

        //GET DonHangByUserById
        [HttpGet("DonHangKhachHang")]
        public async Task<List<DonHangEntity>> GetDonHangByUser(int KH)
        {
            var donhangs = await donHangRepo.GetAllDonHangByUser(KH);
            return donhangs;
        }

        //GET DonHangByUserByCuaHang
        [HttpGet("DonHangCuaHang")]
        public async Task<List<DonHangEntity>> GetDonHangByCuaHang(int CH)
        {
            var donhangs = await donHangRepo.GetAllDonHangByCuaHang(CH);
            return donhangs;
        }

        //GET DonHangByUserByShipper
        [HttpGet("DonHangShipper")]
        public async Task<List<DonHangEntity>> GetDonHangByShipper(int SP)
        {
            var donhangs = await donHangRepo.GetAllDonHangByShipper(SP);
            return donhangs;
        }
        [HttpPut("{id}/ShipperDangGiaoHang/{shipperId}")]
        public async Task<ActionResult<DonHangEntity>> ShipperDangGiaoHang(int id, int shipperId)
        {
            var donHang = await donHangRepo.GetDonHang(id);
            var shipper = await shipperRepo.Find(shipperId);
            if (donHang != null && shipper != null)
            {
                if (donHang.TTDHId == (int)TrangThaiDonHang.DangLayHang
                    && shipper.KichHoat
                    && donHang.ShipperId != null)
                {
                    await donHangRepo.ShipperDangGiaoHang(donHang, shipper);
                    return Ok();
                }
            }
            return BadRequest();
        }
        [HttpPut("{id}/ShipperGiaoThanhCong/{shipperId}")]
        public async Task<ActionResult<DonHangEntity>> ShipperDaGiaoHang(int id, int shipperId)
        {
            var donHang = await donHangRepo.GetDonHang(id);
            var shipper = await shipperRepo.Find(shipperId);
            if (donHang != null && shipper != null)
            {
                if (donHang.TTDHId == (int)TrangThaiDonHang.DangGiaoHang
                    && shipper.KichHoat
                    && donHang.ShipperId != null)
                {
                    var _donHang = await donHangRepo.ShipperGiaoThanhCong(donHang, shipper);
                    if (_donHang != null)
                    {
                        return Ok();
                    }
                }
            }
            return BadRequest();
        }
        [HttpGet("ThongTinShipper")]
        public async Task<ShipperEntity> LayThongTinShipper(int shipper)
        {
            var sp = await shipperRepo.Find(shipper);
            if(sp!=null)
            {
                return await shipperRepo.GetShipper(shipper);
            }
            return null;

        }
        [HttpGet("ThongTinCuaHang")]
        public async Task<CuaHangEntity> LayThongTinCuaHang(int cuahang)
        {
            var ch = await cuahangRepo.Find(cuahang);
            if (ch != null)
            {
                return await cuahangRepo.GetCuaHang(cuahang);
            }
            return null;

        }
    }
}
