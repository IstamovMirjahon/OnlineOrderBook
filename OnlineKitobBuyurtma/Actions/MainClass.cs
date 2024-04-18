using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineKitobBuyurtma.Actions
{
    public class MainClass
    {
        // Assalomu alaykum
        List<Book> books = new List<Book>();
        List<(string, string, int, string, string, string)> myList = new List<(string, string, int, string, string, string)>();
        public MainClass()
        {
            books.Add(new Book() { Name = "O'tkan kunlar", Muallif = "Abdulla Oripov", Narxi = 50000});
            books.Add(new Book() { Name = "Shum bola", Muallif = "Xudoyberdi To'xtaboyev", Narxi = 30000});
            books.Add(new Book() { Name = "Hamsa", Muallif = "Alisher Navoiy", Narxi = 40000});
            books.Add(new Book() { Name = "4 ulus tarixi", Muallif = "Mirzo Ulug'bek", Narxi = 35000});
            books.Add(new Book() { Name = "Majnuntol", Muallif = "Asqar Muxtor", Narxi = 25000});
            books.Add(new Book() { Name = "Boy ota, kambag'al ota", Muallif = "Robert Kiosaki", Narxi = 55000});
            books.Add(new Book() { Name = "Diqqat", Muallif = "Kell Nyuport", Narxi = 60000});
        }
        public void EnterProcess()
        {
            Console.WriteLine("ONLINE KITOBGA BUYURTMA BERISH");
            Console.WriteLine();
            Console.WriteLine("1. Kitob buyurtma berish");
            Console.WriteLine("2. Kitob qo'shish");
            Console.WriteLine("3. Mening buyurtmalarim");
            Console.WriteLine();
            Console.Write("Tanlang: ");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Buyurtma();
            }
            else if (n == 2)
            {
                AddBook();
            }
            else
            {
                myOrder();
            }
        }
        public void Buyurtma()
        {
            Console.Clear();
            int i = 0;
            foreach(var book in books)
            {
                i++;
                Console.WriteLine($"{book.Name}");
            }
            Console.WriteLine();
            Console.Write("Buyurtma bermoqchi bo'lgan kitobingiz nomini kiriting: ");
            string BookName = Console.ReadLine();
            Console.Clear();
            if(books.Any(m => m.Name.ToLower() == BookName.ToLower()))
            {
                foreach (var book in books)
                {
                    if (book.Name.ToLower() == BookName.ToLower())
                    {
                        Console.WriteLine($"Kitob nomi: {book.Name}");
                        Console.WriteLine($"Kitob muallifi: {book.Muallif}");
                        Console.WriteLine($"Kitob narxi: {book.Narxi}");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("2. Buyurtma berish");
                Console.WriteLine("0. Bosh sahifaga qaytish");
                Console.WriteLine("1. Ortga qaytish");
                Console.Write("Tanlang: ");
                int n = int.Parse(Console.ReadLine());
                if (n == 2)
                {
                    Console.Clear();
                    Console.Write("Ism-familiyangizni kiriting: ");
                    string Name = Console.ReadLine();
                    Console.Write("Manzilingizni kiriting: ");
                    string Address = Console.ReadLine();
                    Console.Write("Telefon raqamingizni kiriting: ");
                    string PhoneNumber = Console.ReadLine();
                    foreach(var book in books)
                    {
                        if(BookName.ToLower() == book.Name.ToLower())
                        {
                            myList.Add((book.Name, book.Muallif, book.Narxi, Name, Address, PhoneNumber));
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("Buyurtma qabul qilindi");
                    Console.WriteLine();
                    Console.WriteLine("0. Bosh sahifaga qaytish");
                    Console.Write("Tanlang: ");
                    n = int.Parse(Console.ReadLine());
                    if (n == 0)
                    {
                        Console.Clear();
                        EnterProcess();
                    }
                }
                if (n == 0)
                {
                    Console.Clear();
                    EnterProcess();
                }
                else
                {
                    Buyurtma();
                }
            }
            else
            {
                Console.WriteLine("Bizda bunday kitob mavjud emas");
                Console.WriteLine();
                Console.WriteLine("0. Bosh sahifaga qaytish");
                Console.WriteLine("1. Ortga qaytish");
                Console.Write("Tanlang: ");
                int n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    Console.Clear();
                    EnterProcess();
                }
                else
                {
                    Buyurtma();
                }
            }
        }
        public void myOrder()
        {
            Console.Clear();
            foreach(var book in myList)
            {
                Console.WriteLine($"Kitob nomi: {book.Item1}");
                Console.WriteLine($"Kitob muallifi: {book.Item2}");
                Console.WriteLine($"Kitob narxi: {book.Item3}");
                Console.WriteLine($"Buyurtmachi ism-familiyasi: {book.Item4}");
                Console.WriteLine($"Buyurtmachi manzili: {book.Item5}");
                Console.WriteLine($"Buyurtmachi telefon raqami: {book.Item6}");
                Console.WriteLine();
            }
            Console.WriteLine("0. Bosh sahifaga qaytish");
            Console.Write("Tanlang: ");
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.Clear();
                EnterProcess();
            }
        }
        public void AddBook()
        {
            Console.Clear();
            Console.Write("Qo'shmoqchi bo'lgan kitobingiz nomini kiriting: ");
            string BookName = Console.ReadLine();
            Console.Write("Qo'shmoqchi bo'lgan kitobingiz muallifini kiriting: ");
            string BookMuallif = Console.ReadLine();
            Console.Write("Qo'shmoqchi bo'lgan kitobingiz narxini kiriting: ");
            int BookNarx = int.Parse(Console.ReadLine());
            if(!books.Any(m => m.Name.ToLower() == BookName.ToLower()) && !books.Any(m => m.Muallif.ToLower() == BookMuallif.ToLower()))
            {
                books.Add(new Book() { Name = BookName, Muallif = BookMuallif, Narxi = BookNarx });
                Console.Clear();
                Console.WriteLine("Kitob ro'yxatlar ichiga qo'shildi");
                Console.WriteLine();
                Console.WriteLine("0. Bosh sahifaga qaytish");
                Console.Write("Tanlang: ");
                int n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    Console.Clear();
                    EnterProcess();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Bu kitob bizda oldindan mavjud");
                Console.WriteLine();
                Console.WriteLine("0. Bosh sahifaga qaytish");
                Console.Write("Tanlang: ");
                int n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    Console.Clear();
                    EnterProcess();
                }
            }
        }
    }
}
