using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_Menu
{
    //public class Home
    //{
    //    public string menu1 { get; set; }
    //    public string menu2 { get; set; }
    //    public string[] menu3 { get; set; }
    //    public string menu4 { get; set; }


    //    public Home(string _menu, string _menu2, string[] _menu3, string _menu4)
    //    {
    //        menu1 = _menu;
    //        menu2 = _menu2;
    //        menu3 = _menu3;
    //        menu4 = _menu4;


    //    }
    //}
    //public class Menu
    //{
    //    public Double id { get; set; }
    //    public string? name { get; set; }
    //    public Double price { get; set; }
    //    public string? size { get; set; }
    //    public bool status { get; set; }
    //}
    ////public class Menu2
    ////{
    ////    public Double id { get; set; }
    ////    public String? name { get; set; }
    ////    public String? size { get; set; }
    ////    public Double price { get; set; }
    ////    public bool status1 { get; set; }
    ////}
    class Menu
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string size { get; set; }
        public bool status { get; set; }
    }

    class Login
    {
        public string username { get; set; }
        public string password { get; set; }
    }

    class Home
    {
        public string menu1 { get; set; }
        public string menu2 { get; set; }
        public string[] menu3 { get; set; }
        public string menu4 { get; set; }

        public Home(string m1, string m2, string[] m3, string m4)
        {
            menu1 = m1;
            menu2 = m2;
            menu3 = m3;
            menu4 = m4;
        }
    }





}
