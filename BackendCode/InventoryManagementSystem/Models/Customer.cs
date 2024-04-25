using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.Models
{
    public class Customer
    {

        public int CustomerID {  get; set; }

        public string? CustomerName { get; set; }    

        public long MobileNumber { get; set; }

        public int Creditpoints {  get; set; }

        //public ICollection<Order> Orders { get; }
        public int Retailerid { get; set; }
        public Retailer? Retailer { get; set; }



    }
}
