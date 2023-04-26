using ExtraaEdgeAssig.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ExtraaEdgeAssig.Repositories;
using ExtraaEdgeAssig.Services;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExtraaEdgeAssig.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private readonly IPurchaseService service;
        public PurchaseController(IPurchaseService ser)
        {
            service = ser;
        }

        [HttpGet]
        [Route("GetAllPurchases")]
        public IActionResult GetAllPurchases()
        {
            try
            {
                return new ObjectResult(service.GetAllPurchases());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex);
            }
        }

        // GET  api/Purchase/GetPurchaseById/1
        [HttpGet]
        [Route("GetPurchaseById/{id}")]
        public IActionResult GetPurchaseById(int id)
        {
            try
            {
                return new ObjectResult(service.GetPurchaseById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex);
            }
        }

        // POST api/<PurchaseController>
        [HttpPost]
        [Route("AddPurchase")]
        public IActionResult AddPurchase([FromBody] Purchase purchase)
        {
            try
            {
                int res = service.AddPurchase(purchase);
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

        // PUT api/<PurchaseController>/5
        [HttpPost]
        [Route("UpdatePurchase")]
        public IActionResult UpdatePurchase([FromBody] Purchase purchase)
        {
            try
            {
                int res = service.UpdatePurchase(purchase);
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

        // DELETE api/<PurchaseController>/5
        [HttpGet]
        [Route("DeletePurchase/{id}")]
        public IActionResult DeletePurchase(int id)
        {
            try
            {
                int res = service.DeletePurchase(id);
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
