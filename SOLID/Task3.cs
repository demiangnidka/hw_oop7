using System;
using System.Text;

namespace SolidTask3
{
    public interface IShape
    {
        int GetArea();
    }

    public class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int GetArea()
        {
            return Width * Height;
        }
    }

    public class Square : IShape
    {
        public int Side { get; set; }

        public int GetArea()
        {
            return Side * Side;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            IShape rect = new Rectangle { Width = 5, Height = 10 };
            IShape square = new Square { Side = 5 };

            Console.WriteLine($"Площа прямокутника (5x10): {rect.GetArea()}"); // Виведе 50
            Console.WriteLine($"Площа квадрата (5x5): {square.GetArea()}");     // Виведе 25

            Console.ReadKey();
        }
    }
}



//using System;
//class Rectangle
//{
//    public virtual int Width { get; set; }
//    public virtual int Height { get; set; }
//    public int GetRectangleArea()
//    {
//        return Width * Height;
//    }
//}
////квадрат наслідується від прямокутника!!!
//class Square : Rectangle
//{
//    public override int Width
//    {
//        get { return base.Width; }
//        set
//        {
//            base.Height = value;
//            base.Width = value;
//        }
//    }
//    public override int Height
//    {
//        get { return base.Height; }
//        set
//        {
//            base.Height = value;
//            base.Width = value;
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Rectangle rect = new Square();
//            rect.Width = 5;
//            rect.Height = 10;
//            Console.WriteLine(rect.GetRectangleArea());
//            Console.ReadKey();
//        }
//    }
//}