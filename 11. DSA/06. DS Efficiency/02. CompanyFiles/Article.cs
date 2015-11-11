namespace _02.CompanyFiles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Article:IComparable<Article>
    {
        public Article(int barcode, string vendor, string title, decimal price)
        {
            this.BarCode = barcode;
            this.Vendor = vendor;
            this.Title = title;
            this.Price = price;
        }

        public int BarCode { get; set; }

        public string Vendor { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public int CompareTo(Article other)
        {
            return this.Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return string.Format("{0:10} {1:10} {2:10} {3:10}", BarCode.ToString(), Vendor, Title, Price.ToString());
        }
    }
}
