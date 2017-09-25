using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REST.Entity
{
    public class Address
    {
        public string IP { get; set; }

        public override string ToString()
        {
            return $"IP: {IP}";
        }
    }
}
