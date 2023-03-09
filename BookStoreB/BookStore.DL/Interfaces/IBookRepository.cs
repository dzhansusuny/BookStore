using BookStore.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DL.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAll();

        Book GetById(int id);

        void AddBook(Book book);

        void DeleteBook(int id);
    }
}
