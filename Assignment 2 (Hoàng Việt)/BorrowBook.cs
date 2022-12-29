using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2__Hoàng_Việt_
{
    internal class BorrowBook : BookLibrary
    {
        public string BookBorrowerName { get; set; }
        public string ClientPhoneNumber { get; set; }
        public DateTime BorrowDate { get; set; }
        public BorrowBook()
        {

        }
        public void InputandOutputBorrow ()
        {
            Console.Write("Enter Borrower's Quantity: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                BorrowBook borrow = new BorrowBook();
                Console.Write("Name: ");
                borrow.BookBorrowerName = Console.ReadLine();
                Console.Write("Book's Name: ");
                borrow.BookName = Console.ReadLine();
                Console.Write("Phone Number: ");
                borrow.ClientPhoneNumber = Console.ReadLine();
                borrow.BorrowDate = DateTime.Now;
                Console.WriteLine("BORROWED!");
                Console.WriteLine($"Name: {borrow.BookBorrowerName} | Phone Number: {borrow.ClientPhoneNumber} | Borowed Book: {borrow.BookName} at {borrow.BorrowDate}");
            }
        }
    }
}
