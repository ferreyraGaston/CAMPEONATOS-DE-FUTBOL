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
        private int id_equipo1;
        private int id_equipo2;
        private string escudo1;
        private string escudo2;
        private string equipo1;
        private string equipo2;
        private int goles_equipo1;
        private int goles_equipo2;
        public resultados()
        {
            
        }


        public resultados(int id_equipo1, int id_equipo2, string escudo1, string escudo2, string equipo1, string equipo2, int goles_equipo1, int goles_equipo2)
        {
            this.Id_equipo1 = id_equipo1;
            this.Id_equipo2 = id_equipo2;
            this.Escudo1 = escudo1;
            this.Escudo2 = escudo2;
            this.Equipo1 = equipo1;
            this.Equipo2 = equipo2;
            this.Goles_equipo1 = goles_equipo1;
            this.Goles_equipo2 = goles_equipo2;
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
