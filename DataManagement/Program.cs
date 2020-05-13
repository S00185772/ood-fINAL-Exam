using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vitorBarbosa_S00185772;

namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneData db = new PhoneData();

            using (db)
            {
                Phone p1 = new Phone() {phoneId=0, phoneName = "Samsung S20", phonePrice = 500, OsName = "Android", OsImage = "/images/android.png", phoneImage = "/images/s20.jpg" };

                Phone p2 = new Phone() {phoneId=1, phoneName = "iPhone 11", phonePrice = 600, OsName = "Ios", OsImage = "/images/apple.png", phoneImage = "/images/iPhone11.png" };




                db.Phones.Add(p1);
                db.Phones.Add(p2) ;

                Console.WriteLine("Added Phone to db");


                db.SaveChanges();

                Console.WriteLine("Saved to Database");
            } 
        }
    }
}
