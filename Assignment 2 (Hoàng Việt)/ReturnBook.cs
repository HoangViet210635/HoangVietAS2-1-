using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2__Hoàng_Việt_
{
    internal class ReturnBook : BookLibrary
    {
        public string BookReturnerName { get; set; }
        public string ClientPhoneNumber { get; set; }
        public DateTime ReturnDate { get; set; }

        public ReturnBook()
        {

        }
        public void InputandOutputReturn()
        {
            Console.Write("Enter Returner's Quantity: ");
            int tmp = int.Parse(Console.ReadLine());
            for (int i = 0; i < tmp; i++)
            {
                ReturnBook returnBook = new ReturnBook();
                Console.Write("Name: ");
                returnBook.BookReturnerName = Console.ReadLine();
                Console.Write("Book's Name: ");
                returnBook.BookName = Console.ReadLine();
                Console.Write("Phone Number: ");
                returnBook.ClientPhoneNumber = Console.ReadLine();
                returnBook.ReturnDate = DateTime.Now;
                Console.WriteLine("RETURNED");
                Console.WriteLine($"Name: {returnBook.BookReturnerName} |  Phone Number: {returnBook.ClientPhoneNumber} |  Returned Book: {returnBook.BookName} at {returnBook.ReturnDate}");
            }
        }
    }
}

      

