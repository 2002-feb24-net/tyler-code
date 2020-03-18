using System;
using System.Linq;

namespace EnityFrameWorkCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Querying
            using (var db = new BloggingContex())
            {
                var blogs = db.Blogs
                    .Where(b => b.Rating > 3)
                    .OrderBy(b => b.Url)
                    .ToList();
            }

            //Saving data
            using(var db = new BloggingContex())
            {
                var blog1 = new Blog { Url = "www.sample.com" };
                db.Blogs.Add(blog1);
                db.SaveChanges();

            }


        }
    }
}
