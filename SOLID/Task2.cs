using System;

namespace SolidTask2
{
    class Email
    {
        public string Theme { get; set; }
        public string From { get; set; }
        public string To { get; set; }
    }

    interface ILogger
    {
        void Log(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    class Task2
    {
        private readonly ILogger _logger;

        public Task2(ILogger logger)
        {
            _logger = logger;
        }

        public void Send(Email email)
        {
            // ... sending ...
            _logger.Log($"Email from '{email.From}' to '{email.To}' was sent");
        }
    }




//    class Email
//    {
//        public String Theme { get; set; }
//        public String From { get; set; }
//        public String To { get; set; }
//    }
//    class EmailSender
//    {
//        public void Send(Email email)
//        {
//            // ... sending...
//            Console.WriteLine("Email from '" + email.From + "' to
//            '" + email.To + "' was send");
//        }
//
//}
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Email e1 = new Email()
//            {
//                From = "Me",
//                To = "Vasya",
//                Theme = "Who are you?"
//            };
//            Email e2 = new Email()
//            {
//                From = "Vasya",
//                To = "Me",
//                Theme = "vacuum cleaners!"
//            };
//            Email e3 = new Email()
//            {
//                From = "Kolya",
//                To =
//            "Vasya",
//                Theme = "No! Thanks!"
//            };
//            Email e4 = new Email()
//            {
//                From = "Vasya",
//                To = "Me",
//                Theme = "washing machines!"
//            };
//            Email e5 = new Email()
//            {
//                From = "Me",
//                To = "Vasya",
//                Theme = "Yes"
//            };
//            Email e6 = new Email()
//            {
//                From = "Vasya",
//                To =
//            "Petya",
//                Theme = "+2"
//            };
//            EmailSender es = new EmailSender();
//            es.Send(e1);
//            es.Send(e2);
//            es.Send(e3);
//            es.Send(e4);
//            es.Send(e5);
//            es.Send(e6);
//            Console.ReadKey();
//        }
//    }