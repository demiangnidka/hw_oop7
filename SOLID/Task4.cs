using System;
using System.Text;

namespace SolidTask4
{
    interface IPricedItem
    {
        void SetPrice(double price);
    }

    interface IDiscountable
    {
        void ApplyDiscount(string discount);
        void ApplyPromocode(string promocode);
    }

    interface IColorable
    {
        void SetColor(byte color);
    }

    interface ISizable
    {
        void SetSize(byte size);
    }

    class Book : IPricedItem, IDiscountable
    {
        public double Price { get; private set; }

        public void SetPrice(double price)
        {
            Price = price;
            Console.WriteLine($"Книга: встановлено ціну {price} грн.");
        }

        public void ApplyDiscount(string discount)
        {
            Console.WriteLine($"Книга: застосовано знижку {discount}.");
        }

        public void ApplyPromocode(string promocode)
        {
            Console.WriteLine($"Книга: застосовано промокод {promocode}.");
        }
    }

    class Outerwear : IPricedItem, IDiscountable, IColorable, ISizable
    {
        public double Price { get; private set; }
        public byte Color { get; private set; }
        public byte Size { get; private set; }

        public void SetPrice(double price)
        {
            Price = price;
            Console.WriteLine($"Верхній одяг: встановлено ціну {price} грн.");
        }

        public void ApplyDiscount(string discount)
        {
            Console.WriteLine($"Верхній одяг: застосовано знижку {discount}.");
        }

        public void ApplyPromocode(string promocode)
        {
            Console.WriteLine($"Верхній одяг: застосовано промокод {promocode}.");
        }

        public void SetColor(byte color)
        {
            Color = color;
            Console.WriteLine($"Верхній одяг: встановлено код кольору {color}.");
        }

        public void SetSize(byte size)
        {
            Size = size;
            Console.WriteLine($"Верхній одяг: встановлено розмір {size}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Book book = new Book();
            book.SetPrice(350);
            book.ApplyDiscount("10%");

            Console.WriteLine();

            Outerwear jacket = new Outerwear();
            jacket.SetPrice(2800);
            jacket.SetColor(2);
            jacket.SetSize(48);
            jacket.ApplyPromocode("WINTER2026");

            Console.ReadKey();
        }
    }
}

//interface IItem
//{
//    void ApplyDiscount(String discount);
//    void ApplyPromocode(String promocode);
//
//    void SetColor(byte color);
//    void SetSize(byte size);
//    void SetPrice(double price);
//}