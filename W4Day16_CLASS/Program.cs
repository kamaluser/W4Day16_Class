using System;

namespace W4Day16_CLASS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1:Students

            /*Console.Write("Ad soyad daxil et: ");
            string fullname = Console.ReadLine();
            Console.Write("Dogum tarixi daxil et: ");
            DateTime birthDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Qrup nomresi:  ");
            int groupNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Point: ");
            int point = Convert.ToInt32(Console.ReadLine());

            
            if (!string.IsNullOrEmpty(fullname) && point != 0)
            {
                Student student = new Student(fullname, birthDate, groupNo, point);
                student.ShowInfo();
            }
            else
            {
                Console.WriteLine("Ad və xal dəyərləri boş ola bilməz.");
            }*/

            #endregion



            //Console.WriteLine("Nece eded product yaradilacaq?");
            //int count = Convert.ToInt32(Console.ReadLine());
            //Product[] products = new Product[count];
            //for (int i = 0; i < count; i++)
            //{
            //    Console.Write("Productu daxil edin: ");
            //    string productName = Console.ReadLine();
            //    products[i] = new Product(productName);
            //}
            //Console.WriteLine(AveragePrice(products));


            //Product[] products2 = new Product[3] { new Product ( "Koynek", 22.50 ), new Product ( "Mont", 79.90 ), new Product ( "Ayaqqabi", 64.99 ) };


            //Console.WriteLine("Nece eded product yaradilacaq?");
            //int count = Convert.ToInt32(Console.ReadLine());
            //Product[] products = new Product[count];
            //for (int i = 0; i < count; i++)
            //{
            //    Console.Write("Productu daxil edin: ");
            //    string productName = Console.ReadLine();
            //    products[i] = new Product(productName);
            //}
            //Console.WriteLine(products[0].AveragePrice(products));
            //products[0].MostExpensiveProduct(products2);

            #region Task2-Products
            Console.WriteLine("Nece eded product yaradilacaq?");
             int count = Convert.ToInt32(Console.ReadLine());
             Product[] products = new Product[count];
             for (int i = 0; i < count; i++)
             {
                 Console.Write("Productu daxil edin: ");
                 string productName = Console.ReadLine();
                 Console.WriteLine("Price daxil edin: ");
                 double productPrice = Convert.ToDouble(Console.ReadLine());
                 products[i] = new Product(productName,productPrice);
             }
            Console.WriteLine(products[].AveragePrice(products));

             Product[] products2 = new Product[3] { new Product("Koynek", 22.50), new Product("Mont", 79.90), new Product("Ayaqqabi", 64.99) };

             products[].MostExpensiveProduct(products2);
             products[].CheapestProduct(products2);

            #endregion

        }


    }
}
