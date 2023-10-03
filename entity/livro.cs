using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apidotnet.entity
{
    public class livro
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string titulo { get; set; }
        public string autor { get; set; }
        public string editora { get; set; }
        public int npaginas { get; set; }
        public DateTime dtinserted { get; set; }
        public DateTime dtupdated { get; set; }
    }
}