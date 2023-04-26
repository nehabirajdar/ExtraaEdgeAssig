using ExtraaEdgeAssig.Models;
using ExtraaEdgeAssig.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExtraaEdgeAssig.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService service;
        public BrandController(IBrandService ser)
        {
            service = ser;
        }

        [HttpGet]
        [Route("GetAllBrands")]
        public IActionResult GetAllBrands()
        {
            try
            {
                return new ObjectResult(service.GetAllBrands());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex);
            }
        }

        // GET  api/Brand/GetBrandById/1
        [HttpGet]
        [Route("GetBrandById/{id}")]
        public IActionResult GetBrandById(int id)
        {
            try
            {
                return new ObjectResult(service.GetBrandById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex);
            }
        }

        // POST api/<BrandController>
        [HttpPost]
        [Route("AddBrand")]
        public IActionResult AddBrand([FromBody] Brand brand)
        {
            try
            {
                int res = service.AddBrand(brand);
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

        // PUT api/<BrandController>/5
        [HttpPost]
        [Route("UpdateBrand")]
        public IActionResult UpdateBrand([FromBody] Brand brand)
        {
            try
            {
                int res = service.UpdateBrand(brand);
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

        // DELETE api/<BrandController>/5
        [HttpGet]
        [Route("DeleteBrand/{id}")]
        public IActionResult DeleteBrand(int id)
        {
            try
            {
                int res = service.DeleteBrand(id);
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
