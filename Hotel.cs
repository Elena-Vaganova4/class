using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Hotel
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public double PhoneNumber { get; set; }
        public StarsRoom ServiceRoom { get; set; }
        public TypesRoom Room { get; set; }
        public List<string> addService { get; set; }
        static void Main(string[] args)
        {
        }
    }
    public class Service
    {
        public StarsRoom ServiceRoom { get; set; }
    }
    public enum StarsRoom
    {
        AllInclusive,
        Breakfasts,
        AllIsOf
    }
    public class Room
    {
        public TypesRoom Rooms { get; set; }
    }
    public enum TypesRoom
    {
        Family,
        Double,
        Single
    }
}
