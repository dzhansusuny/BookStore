using BookStore.DL.Inmemority_DB;
using BookStore.DL.Interface;
using BookStore.Models.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            return DataStore.Authors.FirstOrDefault(x => x.Id== id.)
        }

        public IEnumerable<Author> GettAll()
        {
            return DataStore.Authors;
        }
    }
}
