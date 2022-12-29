using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2__Hoàng_Việt_
{
    internal class Menu_Operator
    {
        public static int EnterUserChoice()
        {
            int Choice;
            Console.WriteLine("______________________________.");
            Console.WriteLine("        MENU SYSTEM           |");
            Console.WriteLine("______________________________|");
            Console.WriteLine("1. Search the book            |");
            Console.WriteLine("______________________________|");
            Console.WriteLine("2. Display the library        |");
            Console.WriteLine("______________________________|");
            Console.WriteLine("3. Update new book            |");
            Console.WriteLine("______________________________|");
            Console.WriteLine("4. Delete the book            |");
            Console.WriteLine("______________________________|");
            Console.WriteLine("5. Write the book borrower    |");
            Console.WriteLine("______________________________|");
            Console.WriteLine("6. Write the book returner    |");
            Console.WriteLine("______________________________|");
            Console.WriteLine("7. End the program            |");
            Console.WriteLine("______________________________|");
            Console.Write("Enter your choice: ");
            Choice = int.Parse(Console.ReadLine());
            return (Choice);
        }            
    }
}
