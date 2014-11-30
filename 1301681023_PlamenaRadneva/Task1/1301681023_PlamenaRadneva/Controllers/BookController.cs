using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManager;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.Collections.Specialized;

namespace BookManager.Controller
{
    class BookController
    {
        public static List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();
            books = BookModel.GetAll();
            return books;
        }

        public static Book GetByTitle(string title)
        {
            Book book = new Book();
            book = BookModel.GetByTitle(title);
            return book;
        }

        public static bool Add(OrderedDictionary parameters)
        {
            int affectedRows = 0;
            affectedRows = BookModel.Add(parameters);
            if (affectedRows == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool Edit(OrderedDictionary parameters)
        {
            int affectedRows = 0;
            affectedRows = BookModel.Edit(parameters);
            if (affectedRows == 0)
            { 
                return false; 
            }
            else
            {
                return true;
            }
        }

        public static bool Delete(string id)
        {
            int affectedRows = 0;
            affectedRows = BookModel.Delete(id);
            if (affectedRows == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
