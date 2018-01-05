using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDetail.Models
{
    public class ServiceItem
    {
        public int ServiceItemId { get; set; }
        public String ServiceItemCode { get; set; }
        public String ServiceItemName { get; set; }
        public decimal Rate { get; set; }
    }
}