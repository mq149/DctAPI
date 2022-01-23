using DctAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DctApi.Shared.Models;
using DctAPI.Repositories.Implements;
using Microsoft.AspNetCore.Identity;
using DctAPI.Models;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;
using DctApi.Shared.Enums;

namespace DctAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipperController : ControllerBase
    {
        private IShipperRepository shipperRepo;

        public ShipperController(IShipperRepository shipperRepo)
        {
            this.shipperRepo = shipperRepo;
        }

        // POST api/<ShipperController>/ThongTinCaNhan
        [HttpPost("ThongTinCaNhan")]
        public async Task<ActionResult<ShipperEntity>> Get([FromBody] UserBasicInfo user)
        {
            var shipperInfo = await shipperRepo.GetShipper(user.Id, user.SDT, user.Email);
            if (shipperInfo != null)
            {
                return Ok(shipperInfo);
            }
            return NotFound();
        }

    }
}
