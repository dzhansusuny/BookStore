using BookStore.DL.Inmemority_DB;
using BookStore.DL.Interface;
using BookStore.Models.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DL.Repository
{
    public class AuthorRepository : IAutorReposity
    {
        public void AddAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public void DeleteAuthor(int id)
        {
            throw new NotImplementedException();
        }

        
        
public Author GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> GettAll()
        {
            return DataStore.Authors;
        }
    }
}
