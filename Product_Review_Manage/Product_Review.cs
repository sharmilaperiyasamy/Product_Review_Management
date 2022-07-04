using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review_Manage
{
    internal class Product_Review
    {
        public int productId { get; set; }
        public int userId { get; set; }
        public double rating { get; set; }
        public string review { get; set; }
        public bool isLike { get; set; }
    }
}
