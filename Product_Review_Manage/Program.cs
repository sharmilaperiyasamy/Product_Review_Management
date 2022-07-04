using System;
using System.Collections.Generic;
using System.Data;

namespace Product_Review_Manage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Product Review Management--------");
            //uc1 to create Product review class and default data in list of ProductReview class

            List<Product_Review> product_Reviews = new List<Product_Review>()
            {
                new Product_Review() { productId = 1, userId = 1, rating = 4, review = "Average", isLike = true },
                new Product_Review() { productId = 2, userId = 2, rating = 3, review = "Bad", isLike = true },
                new Product_Review() { productId = 3, userId = 3, rating = 1, review = "Good", isLike = true },
                new Product_Review() { productId = 4, userId = 4, rating = 5, review = "Good", isLike = true },
                new Product_Review() { productId = 5, userId = 5, rating = 4, review = "very Bad", isLike = false },
                new Product_Review() { productId = 6, userId = 6, rating = 5, review = "Bad", isLike = false },
                new Product_Review() { productId = 7, userId = 7, rating = 5, review = "Good", isLike = true },
                new Product_Review() { productId = 8, userId = 8, rating = 2, review = "Average", isLike = true },
                new Product_Review() { productId = 9, userId = 9, rating = 2, review = "Good", isLike = true },
                new Product_Review() { productId = 10, userId = 10, rating = 2, review = "Average", isLike = true },
                new Product_Review() { productId = 11, userId = 12, rating = 3, review = "Bad", isLike = true },
                new Product_Review() { productId = 12, userId = 11, rating = 4, review = "Excellent", isLike = false },
                new Product_Review() { productId = 13, userId = 21, rating = 5, review = "Good", isLike = true },
                new Product_Review() { productId = 14, userId = 13, rating = 3, review = "Bad", isLike = true },
                new Product_Review() { productId = 15, userId = 15, rating = 2, review = "Nice", isLike = true },
                new Product_Review() { productId = 16, userId = 14, rating = 1, review = "Nice", isLike = false },
                new Product_Review() { productId = 17, userId = 17, rating = 3, review = "Good", isLike = true },
                new Product_Review() { productId = 18, userId = 16, rating = 4, review = "Excellent", isLike = true },
                new Product_Review() { productId = 19, userId = 18, rating = 5, review = "Nice", isLike = false },
                new Product_Review() { productId = 20, userId = 22, rating = 2, review = "Good", isLike = false },
                new Product_Review() { productId = 21, userId = 24, rating = 4, review = "Bad", isLike = true },
                new Product_Review() { productId = 22, userId = 19, rating = 3, review = "Nice", isLike = false },
                new Product_Review() { productId = 23, userId = 20, rating = 5, review = "Good", isLike = true },
                new Product_Review() { productId = 24, userId = 25, rating = 1, review = "Nice", isLike = true },
                new Product_Review() { productId = 25, userId = 23, rating = 4, review = "Bad", isLike = false },
            };
            Product_Review_Manage.review_manage review = new Product_Review_Manage.review_manage();
            Console.WriteLine("0.Exit\n1.View Reviews\n2.Top 3 High Rated Records\n3.Ratings greater than 3\n4.Count of Reviews for ProductId\n5.ProductId and Review\n6.skip 5 records\n7.Product Id and review using Select LINQ\n8.Records in DataTable\n9.Records who's isLike value is true\n10.Average Rating of all ProductId\n11.Review Nice\n12.Records for UserId 10\nEnter your Choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            while (choice != 0)
            {
                switch (choice)
                {
                    case 1:
                        review.get_review(product_Reviews);
                        break;
                    case 2:
                        review.top3HighRatings(product_Reviews);
                        break;
                    case 3:
                        review.rating_productId(product_Reviews);
                        break;
                    case 4:
                        review.retieve_count(product_Reviews);
                        break;
                    case 5:
                        review.productId_review(product_Reviews);
                        break;
                    case 6:
                        review.skipTop5Records(product_Reviews);
                        break;
                    case 7:
                        review.productId_reviewLINQ(product_Reviews);
                        break;
                    case 8:
                        review.createDataTable(product_Reviews);
                        break;
                    case 9:
                        DataTable dt = review.createDataTable(product_Reviews);
                        review.isLikeValueTrue(dt);
                        break;
                    case 10:
                        dt = review.createDataTable(product_Reviews);
                        review.averageRatingOfProductId(dt);
                        break;
                    default:
                        Console.WriteLine("Enter valid choice.");
                        break;
                }
                Console.WriteLine("0.Exit\n1.View Reviews\n2.Top 3 High Rated Records\n3.Ratings greater than 3\n4.Count of Reviews for ProductId\n5.ProductId and Review\n6.skip 5 records\n7.Product Id and review using Select LINQ\n8.Records in DataTable\n9.Records who's isLike value is true\n10.Average Rating of all ProductId\n11.Review Nice\n12.Records for UserId 10\nEnter your Choice:");
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}