using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automedon
{
    class Models
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string colour;

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        private int edin;

        public int Edin
        {
            get { return edin; }
            set { edin = value; }
        }


        public Models(string _name, string _colour, int _edin)
        {
            name = _name;
            colour = _colour;
            edin = _edin;

        }
        public string Show()
        {
            return string.Format("Модель: {0}" + ";" + " " + "Цвет: {1}" + ";" + " " + "В наличии: {2} шт.", name, colour, edin);
        }
    }
}