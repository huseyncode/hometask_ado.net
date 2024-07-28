using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET2
{
    internal class Assignments:BaseEntity
    {
        public string Content { get; set;}
        public int GroupId { get; set; }
        public Groups Group {  get; set; }

    }
}
