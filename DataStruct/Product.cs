using System;

namespace DataStruct
{
    class Product
    {
        String ProductID;
        int stock;
        double StarRating;

        public void SetValues(string id, int quanity, double rating)
        {
            //buesiness logic like "no product can have more 50 quanity
            // belongs in teh claases that represent tose enlties
            // not in input/output code

            if(quanity > 50)
            {
                System.Console.WriteLine("Error: too much quanity");
            }

            ProductID = id;
            stock = quanity;
            StarRating = rating;

        }

        public void SetDefault()
        {
            ProductID = "1";
            stock = 0;
            StarRating = 5;
        }

        public override String ToString()
        {
            return "product " + ProductID + ". " + stock + " in stock. " + StarRating + " star rating";
        }
    }
}