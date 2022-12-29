using System;
using System.Security.Cryptography.X509Certificates;

namespace Assignment_2__Hoàng_Việt_
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int option;
            LibrarySystem CommandExecute = new LibrarySystem();
            BorrowBook borrowBook = new BorrowBook();
            ReturnBook returnBook = new ReturnBook();
            CommandExecute.ListOfBook();
            do
            {
                option = Menu_Operator.EnterUserChoice();
                switch (option)
                {
                    case 1:
                        CommandExecute.DisplaySearchBook();
                        break;
                    case 2:                        
                        CommandExecute.DisplayLibrary();
                        break;
                    case 3:
                        CommandExecute.AddBook();
                        break;
                    case 4:
                        Console.Write("Enter Book's Name: ");
                        string tmpDel = Console.ReadLine();
                        if (tmpDel != null)
                        {
                            CommandExecute.RemoveBook(tmpDel);
                        }
                        else
                        {
                            Console.WriteLine("ERROR !!! Please enter again!");
                        }
                        break;
                    case 5:
                        borrowBook.InputandOutputBorrow();
                        break;
                    case 6:
                        returnBook.InputandOutputReturn();
                        break;
                    case 7:
                        Console.WriteLine("EXIT.");
                        break;
                    default:
                        Console.WriteLine("ERROR !!! JUST TYPE FROM 1 --> 9. TRY AGAIN");
                        break;
                }

            } while (option != 7);

        }   
    }
}
