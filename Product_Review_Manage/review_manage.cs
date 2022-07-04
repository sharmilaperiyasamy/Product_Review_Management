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
        //uc3 retreive all records from list who's rating are greater than 3 and product Id is 1 or 4 or 9
        public void rating_productId(List<Product_Review> product_Reviews)
        {
            var output = (from product in product_Reviews
                          where product.rating > 3 && (product.productId == 1 || product.productId == 4 || product.productId == 9)
                          select product);
            Console.WriteLine("Records having ratings > 3 and product id is 1 or 4 or 9.");
            foreach (var item in output)
            {
                Console.WriteLine("Product Id : " + item.productId + "\tUser Id : " + item.userId + "\tRating : " + item.rating + "\tReview : " + item.review + "\tisLike : " + item.isLike);
            }
        }
        //uc4 retreive count of review present for each product Id use group by LINQ operator
        public void retieve_count(List<Product_Review> product_Reviews)
        {
            var output = (product_Reviews.GroupBy(product => product.productId).Select(g => new { productId = g.Key, Count = g.Count() }));
            Console.WriteLine("Product Id \t|\tCount");
            foreach (var item in output)
            {
                Console.WriteLine("\t" + item.productId + "\t|\t" + item.Count);
            }
        }
    }
}
