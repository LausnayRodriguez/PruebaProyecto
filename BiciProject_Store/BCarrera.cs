using System;
using System.Collections.Generic;
using System.Text;

namespace BiciProject_Store
{
    public class BCarrera : Bicicleta
    {
        public int Peso { get; set; }
        public BCarrera()
        {
            Peso = 0;
        }
    }
}
