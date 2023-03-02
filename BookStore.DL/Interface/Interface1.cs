using BookStore.Models.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DL.Interface
{
    public interface IAutorReposity
    {
        IEnumerable<Author> GettAll();
        Author GetById(int id);
        void AddAuthor(Author author);
        void DeleteAuthor(int id);
    }
}
