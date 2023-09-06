using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class resultados
    {
        #region Atributos
        static private int id_equipo1;
        static private int id_equipo2;
        static private string escudo1;
        static private string escudo2;
        static private string equipo1;
        static private string equipo2;
        static private int goles_equipo1;
        static private int goles_equipo2;

        public resultados()
        {
            
        }
        
        public string Escudo1 { get => escudo1; set => escudo1 = value; }
        public string Escudo2 { get => escudo2; set => escudo2 = value; }
        public string Equipo1 { get => equipo1; set => equipo1 = value; }
        public string Equipo2 { get => equipo2; set => equipo2 = value; }
        public int Goles_equipo1 { get => goles_equipo1; set => goles_equipo1 = value; }
        public int Goles_equipo2 { get => goles_equipo2; set => goles_equipo2 = value; }
        public int Id_equipo1 { get => id_equipo1; set => id_equipo1 = value; }
        public int Id_equipo2 { get => id_equipo2; set => id_equipo2 = value; }
        #endregion




    }
}
