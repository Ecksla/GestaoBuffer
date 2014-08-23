using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestaoRegistros
{
    [Serializable]
    class Estado
    {
        public string CodEstado { get; set; }
        public string NomeEstado { get; set; }
        public string NomePais { get; set; }
        public int PK { get; set; }
    }
}
