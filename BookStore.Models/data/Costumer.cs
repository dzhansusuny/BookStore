using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.data
{
    internal class costumer : Person
    {
        public int costumerId { get; set; }
        public string costumerName { get; set; }
        public string Phonenumber { get; set; } 

    }
}
