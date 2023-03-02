using FsCheck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.data
{
    public class Author: Person
    { 
        public int Id { get; set; }
        public string Name { get; set; }   
        public string Bio { get; set; } 

    }
}
