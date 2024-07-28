using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET2
{
    internal class Groups
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public int Limit { get; set;}
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
