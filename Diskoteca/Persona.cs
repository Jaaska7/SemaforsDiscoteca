using System;
using System.Collections.Generic;
using System.Windows.Threading;

namespace Llistes
{
    public class Persona
    {
        public Persona() { Nom = ""; Edat = 0; }
        public string Nom { get; set; }
        public int Edat { get; set; }
        public int TiempoRestante { get; set; }
    }
}
