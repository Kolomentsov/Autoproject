using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automedon
{
    class Pages
    {
        private static MainPage main = new MainPage();
        private static Login login = new Login();
        private static Sign_Up sign_up = new Sign_Up();
        private static Dealers dealer = new Dealers();
        private static BMW bmw = new BMW();
        private static Hyundai hyundai = new Hyundai();
        private static Mercedes mersedes = new Mercedes();
        private static Toyota toyota = new Toyota();
        private static Contacts contacts = new Contacts();

        public static Login Login
        {
            get
            {
                return login;
            }
        }

        public static MainPage MainPage
        {
            get
            {
                return main;
            }
        }

        public static Sign_Up Sign_Up
        {
            get
            {
                return sign_up;
            }
        }

        public static Dealers Dealers
        {
            get
            {
                return dealer;
            }
        }

        public static BMW BMW
        {
            get
            {
                return bmw;
            }
        }

        public static Hyundai Hyundai
        {
            get
            {
                return hyundai;
            }
        }

        public static Mercedes Mersedes
        {
            get
            {
                return mersedes;
            }
        }

        public static Toyota Toyota
        {
            get
            {
                return toyota;
            }
        }

        public static Contacts Contacts
        {
            get
            {
                return contacts;
            }
        }





        public class Mark
        {
            public string Name { get; set; }
            public string Country { get; set; }

            public Mark()
            { }

            public Mark(string _name, string _country)
            {
                Name = _name;
                Country = _country;
            }
        }
    }
}