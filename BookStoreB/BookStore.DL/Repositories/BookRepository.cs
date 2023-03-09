using BookStore.DL.InMemoryDb;
using BookStore.DL.Interfaces;
using BookStore.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DL.Repositories
{
    public class BookRepository
    {
        public class BookRepository : IBookRepository
        {
            public IEnumerable<Book> GetAll()
            {
                return DataStore.Book;
            }

            public Book GetById(int id)
            {
                return DataStore.Book
                    .FirstOrDefault(book => Book.Id == id);
            }

            public void AddBook(Book book)
            {
                DataStore.Book.Add(book);
            }

            public void DeleteBook(int id)
            {
                var book = GetById(id);
                if (book != null)
                {
                    DataStore.Book.Remove(book);
                }
            }
        }
    }
}
