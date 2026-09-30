using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ECommerceAPI.Models
{
    public class Cartİtem
    {
        public int Id {get;set;}
        public string UserId {get;set;}=string.Empty;
        public int ProductId{get;set;}
        public Product? Product{get;set;}
        public int Quantity{get;set;}
        public DateTime CreateAt{get;set;}=DateTime.UtcNow;
    }
}