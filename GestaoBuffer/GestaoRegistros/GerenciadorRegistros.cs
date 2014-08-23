using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestaoRegistros
{
    public class GerenciadorRegistros
    {
        internal SGBDBuffer.Buffer bufferManager;

        public GerenciadorRegistros()
        {
            this.bufferManager = new SGBDBuffer.Buffer();
                        

        }
    }
}
