using AutoMapper;
using Business.Services.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models.Guest;
using WebAPI.Models.Login;
using WebAPI.Token;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService guestService;
        private readonly IMapper mapper;

        //private readonly IJwtAuthenticationManager jwtAuthenticationManager;

        public GuestController(IGuestService guestService, IMapper mapper)
        {
            this.guestService = guestService;
            this.mapper = mapper;
            //this.jwtAuthenticationManager = jwtAuthenticationManager;
        }
        public async Task<IActionResult> GetGuest()
        {
            var guests = await guestService.GetDefault(x => x.IsActive == true);
            var guestModels = mapper.Map<List<GuestListModel>>(guests);

            var json = JsonConvert.SerializeObject(guestModels);
            return Ok(json);
        }

        
    }
}
