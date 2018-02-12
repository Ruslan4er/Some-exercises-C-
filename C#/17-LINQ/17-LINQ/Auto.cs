using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_LINQ
{
    class Auto
    {
        private string _mark;
        private string _model;
        private int _year;
        private string _color;

        public Auto()
        {
            Mark = "BMW";
            Model = "X5";
            Year = 2013;
            Color = "Black";
        }

        public Auto(string mark, string model, int year, string color)
        {
            Mark = mark;
            Model = model;
            Year = year;
            Color = color;
        }
        public string Mark
        {
            get { return _mark; }
            set { _mark = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        
    }
}
