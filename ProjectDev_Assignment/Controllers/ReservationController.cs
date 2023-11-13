using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectDev_Assignment.Services;
using ProjectDev_Assignment.Views;

namespace ProjectDev_Assignment.Controllers
{
    // In ReservationController.cs

    [ApiController]
    [Route("api/[controller]")]
    public class ReservationController : ControllerBase
    {
        private readonly ReservationService _reservationService;

        public ReservationController(ReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpPost("make")]
        public IActionResult MakeReservation([FromBody] Reservation details)
        {
            var reservation = _reservationService.MakeReservation(details);
            return Ok(reservation);
        }

        //[Authorize("Staff, Manager")]
        //[HttpPost("confirm/{id}")]
        //public IActionResult ConfirmReservation(int id)
        //{
        //    var success = _reservationService.ConfirmReservation(id);

        //    if (!success)
        //        return NotFound();

        //    return Ok();
        //}

        // Other actions for reservation management...
    }

}
