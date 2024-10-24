using System;

namespace AreaRectangular
{
    class Rec
    {
        double length;
        double width;

        public void Details()
        {
            length = 3;
            width = 3.5;
        }

        public double Area()
        {
            return width * length;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", Area());
        }
    }

    class Execute
    {
        static void Main(string[] args)
        {
            Rec r1 = new Rec();
            r1.Details();
            r1.Display();
            Console.ReadLine(); // يبقي نافذة الكونسول مفتوحة
        }
    }
}
