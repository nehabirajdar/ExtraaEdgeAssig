using ExtraaEdgeAssig.Models;
using ExtraaEdgeAssig.Services;
using Microsoft.AspNetCore.Mvc;


namespace ExtraaEdgeAssig.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileController : ControllerBase
    {
        private readonly IMobileService service;
        public MobileController(IMobileService ser)
        {
            service = ser;
        }

        [HttpGet]
        [Route("GetAllMobiles")]
        public IActionResult GetAllMobiles()
        {
            try
            {
                return new ObjectResult(service.GetAllMobiles());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex);
            }
        }

        // GET  api/Mobile/GetMobileById/1
        [HttpGet]
        [Route("GetMobileById/{id}")]
        public IActionResult GetMobileById(int id)
        {
            try
            {
                return new ObjectResult(service.GetMobileById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex);
            }
        }

        // POST api/<MobileController>
        [HttpPost]
        [Route("AddMobile")]
        public IActionResult AddMobile([FromBody] Mobile mob)
        {
            try
            {
                int res = service.AddMobile(mob);
                if (res == 1)
                {
                    return StatusCode(StatusCodes.Status201Created);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        // PUT api/<MObileController>/5
        [HttpPost]
        [Route("UpdateMobile")]
        public IActionResult UpdateMobile([FromBody] Mobile mob)
        {
            try
            {
                int res = service.UpdateMobile(mob);
                if (res == 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        // DELETE api/<MobileController>/5
        [HttpGet]
        [Route("DeleteMobile/{id}")]
        public IActionResult DeleteMobile(int id)
        {
            try
            {
                int res = service.DeleteMobile(id);
                if (res == 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

    }
}