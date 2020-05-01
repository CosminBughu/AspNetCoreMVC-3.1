using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title,string authorName)
        {
            return DataSource().Where(x => x.Title.Contains (title) && x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>
            {
                new BookModel(){Id=1,Title="Mvc",Author="Cosmin", Description="This is the description for the Mvc book", Category="Programing", Language="English", TotalPages=350},
                new BookModel(){Id=2,Title="C#",Author="Mihai", Description="This is the description for the C# book" , Category="Programing", Language="English", TotalPages=120},
                new BookModel(){Id=3,Title="Java",Author="Cosmin Ionut", Description="This is the description for the Java book" , Category="Programing", Language="English", TotalPages=720},
                new BookModel(){Id=4,Title="Programing",Author="Ene", Description="This is the description for the Programing book" , Category="Programing", Language="Romana", TotalPages=200},
                new BookModel(){Id=5,Title="Vhdl",Author="Bianca", Description="This is the description for the Vhdl book" , Category="Programing", Language="Bevslkdvn", TotalPages=2},
                new BookModel(){Id=6,Title="Networking in Morcoveti",Author="Rumbun", Description="This is the description for the Morcoveti book" , Category="Programing", Language="BunyLang", TotalPages=10000},
            };
        }

    }
}
