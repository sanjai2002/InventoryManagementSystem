using InventoryManagementSystem.Data;
using InventoryManagementSystem.DTO.Customer;
using InventoryManagementSystem.DTO.Order;
using InventoryManagementSystem.DTO.Retailer;
using InventoryManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace InventoryManagementSystem.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly Appdbcontext _dbcontext;
        public CustomerController(Appdbcontext dbContext)
        {
            _dbcontext = dbContext;
        }



        [HttpPost]
        public ActionResult FindCustomer([FromBody] CustomerMobilenumber Mobilenumber)
        {
            var number = _dbcontext.Customer.Where(s => s.MobileNumber == Mobilenumber.MobileNumber).FirstOrDefault();
            if (number == null)
            {
                return Ok("Not the data");
            }
            else
            {
                return Ok(number);
            }
        }



        //Get customer
        [HttpPost]
        public ActionResult GetCustomerdetails([FromBody] GetRetailerid retailer)
        {
            var Customerdetails = _dbcontext.Customer.Include(c=>c.Retailer).Where(s => s.Retailerid == retailer.Retailerid);

            if (Customerdetails == null)
            {
                return Ok("Not the customer");
            }
            else
            {
                return Ok(Customerdetails);
            }
        }

    }
}
