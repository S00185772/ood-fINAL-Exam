using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Converters;

namespace vitorBarbosa_S00185772
{
    public class Phone
    {
        public int phoneId { get; set; }

        public string phoneName { get; set; }


        public double phonePrice { get; set; }

        public string OsName { get; set; }

        public string OsImage { get; set; }

        public string phoneImage { get; set; }

        public double percent = 0.2;

        public double IncreasePrice()
        {
            double calc;

            calc = phonePrice * percent;

            phonePrice = phonePrice + calc;

            return phonePrice;
        }

        //public Phone(string phonename,double phoneprice,string osname,string osimage,string phoneimage)
        //{
        //    phoneName = phonename;
        //    phonePrice = phoneprice;
        //    OsName = osname;
        //    OsImage = osimage;
        //    phoneImage = phoneimage;



        //}
        public override string ToString()
        {
            return string.Format("{0}   {1}", OsImage, phoneName);
        }
    }
    public class PhoneData : DbContext
    {
        public PhoneData() : base("MyPhoneData") { }
        public DbSet<Phone> Phones { get; set; }

    }

}
