using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {   
        public readonly BookRepository _bookRepository=null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }
      public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View(data);
        }

        public ViewResult GetBook(int id)
        {
            var data2 =_bookRepository.GetBookById(id);
            return View(data2);
        }

        public ViewResult SearchBook(/*string bookName, string authorName*/)
        {
           //var data1= _bookRepository.SearchBook(bookName,authorName);
            return View();
        }
    }
}