using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace YourCarSlot.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParkingSlotController : ControllerBase
    {
        private readonly IMapper _mapper;

        public ParkingSlotController(IMapper mapper)
        {
            this._mapper = mapper;
        }
    }
}