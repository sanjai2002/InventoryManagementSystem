using InventoryManagementSystem.Data;
using InventoryManagementSystem.DTO.Dealer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Dashboardontroller : ControllerBase
    {
        private readonly Appdbcontext _dbcontext;
        public Dashboardontroller(Appdbcontext dbContext)
        {
            _dbcontext = dbContext;
        }



        [HttpGet]
        public IActionResult GetBloodStockDetails(int id)
        {
            var Productcount = _dbcontext.Products.Where(x => x.Retailerid == id).Count();
            var NoStockProduct = _dbcontext.Products.Where(x => x.Retailerid == id).Where(x=>x.Stock==0).Count();

            DashboardDTO dashboardDTO = new DashboardDTO
            {
                Noofproducts=Productcount,
                nostockproducts=NoStockProduct,
            };
            return Ok(dashboardDTO);
        }

    }
}
