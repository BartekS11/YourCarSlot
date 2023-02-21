using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace YourCarSlot.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly IMapper _mapper;

        public VehicleController(IMapper mapper)
        {
            this._mapper = mapper;
        }

        // [HttpGet]
        // public async Task<List<ReservationRequestDto>> Get()
        // {
        //     var allReservationRequest = await _mediator.Send(new GetAllReservationRequestQuery());
        //     return allReservationRequest;
        // }

        // [HttpGet("{id}")]
        // public async Task<ReservationRequestDto> Get(Guid id)
        // {
        //     var reservationRequest = await _mediator.Send(new ReservationRequestQuery(id));
        //     return reservationRequest;
        // }

    }
}