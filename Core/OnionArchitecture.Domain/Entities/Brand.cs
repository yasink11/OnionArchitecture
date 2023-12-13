using OnionArchitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Domain.Entites
{
    public class Brand : EntityBase
    {
        public Brand()
        {
        }
        public Brand(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
