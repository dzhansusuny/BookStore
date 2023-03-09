using BookStore.BL.Interfaces;
using BookStore.DL.Interfaces;
using BookStore.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Services
{
    public class BookService
    {
        public class BookService : IBookService
        {
            private readonly IBookRepository _bookRepository;

            public BookService(IBookRepository bookRepository)
            {
                _bookRepository = bookRepository;
            }

            public IEnumerable<Book> GetAll()
            {
                return _bookRepository.GetAll();
            }

            public Book GetById(int id)
            {
                return _bookRepository.GetById(id);
            }

            public void AddBook(Book book)
            {
                _bookRepository.AddBook(book);
            }

            public void DeleteBook(int id)
            {
                _bookRepository.DeleteBook(id);
            }
        }
    }
}