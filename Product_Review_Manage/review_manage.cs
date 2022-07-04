using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.
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
        //uc 5 retreive product id and review from the list for all records
        public void productId_review(List<Product_Review> product_Reviews)
        {
            var output = (from product in product_Reviews select new { productId = product.productId, review = product.review });
            Console.WriteLine("Product Id\t|\tReview");
            foreach (var item in output)
            {
                Console.WriteLine("\t" + item.productId + "\t|\t" + item.review);
            }
        }
        //uc6 skip top 5 records from the list and display the records
        public void skipTop5Records(List<Product_Review> product_Reviews)
        {
            var output = (from product in product_Reviews select product).Skip(5);
            Console.WriteLine("Records after skipping top 5.");
            foreach (var item in output)
            {
                Console.WriteLine("Product Id : " + item.productId + "\tUser Id : " + item.userId + "\tRating : " + item.rating + "\tReview : " + item.review + "\tisLike : " + item.isLike);
            }
        }
        //uc7 retreive product id and review from the list for all records using LINQ
        public void productId_reviewLINQ(List<Product_Review> product_Reviews)
        {
            var output = product_Reviews.Select(reviews => new { productId = reviews.productId, review = reviews.review });
            Console.WriteLine("Product Id\t|\tReview");
            foreach (var item in output)
            {
                Console.WriteLine("\t" + item.productId + "\t|\t" + item.review);
            }
        }
        //uc8 create datatable and add columns to the table 
        public DataTable createDataTable(List<Product_Review> product_Reviews)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductId", typeof(Int32));
            dt.Columns.Add("UserId", typeof(Int32));
            dt.Columns.Add("Rating", typeof(Int32));
            dt.Columns.Add("Review", typeof(String));
            dt.Columns.Add("isLike", typeof(bool));
            foreach (var item in product_Reviews)
            {
                dt.Rows.Add(item.productId, item.userId, item.rating, item.review, item.isLike);
            }
            Console.WriteLine("Records present in DataTable.");
            foreach (var item in dt.AsEnumerable())
            {
                Console.WriteLine("ProductId: " + item.Field<int>("ProductId") + "\tUserID: " + item.Field<int>("UserId") + "\tRating: " + item.Field<int>("Rating") + "\tReview: " + item.Field<string>("Review") + "\tisLike: " + item.Field<bool>("isLike"));
            }
            return dt;
        }
    }
}
