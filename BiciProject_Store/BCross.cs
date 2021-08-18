using System;
using System.Collections.Generic;
using System.Text;

namespace BiciProject_Store
{
    class BCross : Bicicleta
    {
        public string Material { get; set; }
        public BCross()
        {
            Material = "Aluminio";
        }
    }
}
