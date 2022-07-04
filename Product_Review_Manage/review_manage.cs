using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review_Manage
{
    internal class review_manage
    {
        //create variables for the list of product reviews class
        public void get_review(List<Product_Review> product_Reviews)
        {
            foreach (var item in product_Reviews)
            {
                Console.WriteLine("Product Id : " + item.productId + "\tUser Id : " + item.userId + "\tRating : " + item.rating + "\tReview : " + item.review + "\t\tisLike : " + item.isLike);
            }
        }
        //uc2 retrieve top 3 records from the list who's rating is high using LINQ
        public void top3HighRatings(List<Product_Review> product_Reviews)
        {
            var output = (from product in product_Reviews orderby product.rating descending select product).Take(3);
            Console.WriteLine("Top 3 records having high rating.");
            foreach (var item in output)
            {
                Console.WriteLine("Product Id : " + item.productId + "\tUser Id : " + item.userId + "\tRating : " + item.rating + "\tReview : " + item.review + "\tisLike : " + item.isLike);
            }
        }
    }
}
