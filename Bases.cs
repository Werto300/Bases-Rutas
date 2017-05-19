using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bases_Rutas
{
    class Bases
    {
        private string _nombre;
        private int _minutos;

        public string nombre { get { return _nombre; } }
        public int minutos { get { return _minutos; } }

        public Bases siguiente { get; set; }
        public Bases anterior { get; set; }

        public Bases(string nombre, int minutos)
        {
            this._nombre = nombre;
            this._minutos = minutos;
        }

        public override string ToString()
        {
            return "Nombre: " + _nombre + ", Tiempo: " + _minutos + Environment.NewLine;
        }
    }
}
