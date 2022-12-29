using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2__Hoàng_Việt_
{
    internal class BookLibrary
    {
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string BookCategory { get; set; }
        public int BookPublicationDate { get; set; }
        public int BookQuantity { get; set; }
        public int BookPrice { get; set; }
        public BookLibrary (string bookName, string bookAuthor, string bookCategory, int bookPublicationDate, int bookQuantity, int bookPrice)
        {
            BookName = bookName;
            BookAuthor = bookAuthor;
            BookCategory = bookCategory;
            BookPublicationDate = bookPublicationDate;
            BookQuantity = bookQuantity;
            BookPrice = bookPrice;
        }
        public BookLibrary()
        {

        }
        public string DisplayBookInformation()
        {
            return  BookName + " | Author: " + BookAuthor + " | Category: " + BookCategory + " | Publication Date: " + BookPublicationDate + " | Quantity: " + BookQuantity + " | Price: " + BookPrice;
        }
    }
}
