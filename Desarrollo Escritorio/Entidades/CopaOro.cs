using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CopaOro
    {
        static private int idEquipo;
        static private int idZona;
        static private string equipo;
        static private int gol1;
        static private int gol2;
        static private int gol3;

        public CopaOro()
        {
        }

        public int pIdEquipoID { get => idEquipo; set => idEquipo = value; }
        public string Equipo { get => equipo; set => equipo = value; }

        public int IdZona { get => idZona; set => idZona = value; }
        public int Gol1 { get => gol1; set => gol1 = value; }
        public int Gol2 { get => gol2; set => gol2 = value; }
        public int Gol3 { get => gol3; set => gol3 = value; }
    }
}
