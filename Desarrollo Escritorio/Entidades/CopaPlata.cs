using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CopaPlata
    {
        private static int idEquipo;
        private static int idZona;
        private static string equipo;
        private static int gol1;
        private static int gol2;
        private static int gol3;

        public CopaPlata()
        {
            // Constructor vacío, si es necesario realizar alguna inicialización adicional, puedes agregarlo aquí.
        }

        public int pIdEquipoID { get => idEquipo; set => idEquipo = value; }
        public string Equipo { get => equipo; set => equipo = value; }

        public int IdZona { get => idZona; set => idZona = value; }
        public int Gol1 { get => gol1; set => gol1 = value; }
        public int Gol2 { get => gol2; set => gol2 = value; }
        public int Gol3 { get => gol3; set => gol3 = value; }
    }
}
