using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Models
{
    public class Account
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Pin { get; set; }
        public int Money { get; set; }
    }
}
