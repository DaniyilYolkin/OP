using System;
namespace Lab6_13_2
{
    public class Data
    {
        public string Detail { get; set; }
        public int Quantity { get; set; }
        public string Distributor { get; set; }

        public Data(string detail="", int quantity=0, string distributor="")
        {
            Detail = detail;
            Quantity = quantity;
            Distributor = distributor;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Detail, Convert.ToString(Quantity), Distributor);
        }
    }
}
