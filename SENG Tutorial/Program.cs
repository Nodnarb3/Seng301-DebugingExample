using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENG_Tutorial
{
    abstract class Shape
    {
        abstract public double Area();
    }

    class Rectangle : Shape
    {
        private double width;
        private double height;

        //public double Width {get; set;}
        //public double Height {get; set;}

        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        Rectangle(double w, double h, double a)
        {
            Console.WriteLine("Hello");

            //Can not do this
            //this(w, h);
        }

        public Rectangle(double w, double h) : this(w, h, w * h)
        {


            width = w;
            height = h;
        }

        //public float Area
        //{
        //    get
        //    {
        //        return width * height;
        //    }
        //}

        /*
         *  Or area is a variable with a getter, and the internal value of area is calculated only when the 
         *  width or height are set. 
         */

        public override double Area()
        {
            return width * height;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10d, 10d);

            Console.WriteLine(rect.Area());


            int l = Console.CursorLeft;
            int t = Console.CursorTop;
            Console.SetCursorPosition(10, 10);
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(l,t);

            rect.Height = 100d;
            rect.Width = 10d;

            Console.WriteLine(rect.Area());

            Console.ReadLine();



        }
    }
}
