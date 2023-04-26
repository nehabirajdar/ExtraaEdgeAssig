using ExtraaEdgeAssig.Models;
using ExtraaEdgeAssig.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExtraaEdgeAssig.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService service;
        public CustomerController(ICustomerService ser)
        {
            service = ser;
        }

        [HttpGet]
        [Route("GetAllCustomers")]
        public IActionResult GetAllCustomers()
        {
            try
            {
                return new ObjectResult(service.GetAllCustomers());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex);
            }
        }

        // GET  api/Customer/GetCustomerById/1
        [HttpGet]
        [Route("GetCustomerById/{id}")]
        public IActionResult GetCustomerById(int id)
        {
            try
            {
                return new ObjectResult(service.GetCustomerById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex);
            }
        }

        // POST api/<CustomerController>
        [HttpPost]
        [Route("AddCustomer")]
        public IActionResult AddCustomer([FromBody] Customer customer)
        {
            try
            {
                int res = service.AddCustomer(customer);
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

        // PUT api/<CustomerController>/5
        [HttpPost]
        [Route("UpdateCustomer")]
        public IActionResult UpdateCustomer([FromBody] Customer customer)
        {
            try
            {
                int res = service.UpdateCustomer(customer);
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

        // DELETE api/<CustomerController>/5
        [HttpGet]
        [Route("DeleteCustomer/{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            try
            {
                int res = service.DeleteCustomer(id);
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

