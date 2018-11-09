using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Vacaciones
    {
        private int Dia;
        private int Mes;
        private int Anio;
        private int DiasAnio;
        private DateTime fFinal;

        public string dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime fecAlta { get; set; }
        public int DiasCalculado { get; set; }
        public int AnioCalculado { get; set; }
        public int DiasVacaciones { get; set; }

        public override string ToString()
        {
            return Apellido + ", " + Nombre;
        }

        private void calcularAntiguedad(DateTime fIni, DateTime fFin)
        {
            /*if (fFin.Year > 2100)
                fFin = DateTime.Now;*/
            int a = fFin.Year - fIni.Year;
            int m = fFin.Month - fIni.Month;
            int d = fFin.Day - fIni.Day + 1;
            int diasMes = this.cantDiasMes(fIni, fFin);

            if (fFin.Month < fIni.Month)
            {
                a = a - 1;
                if (fFin.Day < fIni.Day)
                {
                    m = m - 1; d = diasMes + d;
                }
            }

            if (fFin.Month == fIni.Month)
            {
                if (fFin.Day < fIni.Day)
                {
                    a = a - 1; m = m - 1; d = diasMes + d;
                }
            }

            if (fFin.Month > fIni.Month)
            {
                if (fFin.Day < fIni.Day)
                {
                    if (d == -1)
                        d = 0;
                    else
                    {
                        d = diasMes + d; m = m - 1;
                    }
                }
            }

            if (m < 0) m = 12 + m;

            //String sa = a > 9 ? a.ToString() : "0" + a.ToString();
            //String sm = m > 9 ? m.ToString() : "0" + m.ToString();
            //String sd = d > 9 ? d.ToString() : "0" + d.ToString();

            Dia = Convert.ToInt32(d);
            Mes = Convert.ToInt32(m);
            Anio = Convert.ToInt32(a);
            TimeSpan aux = fFin - fIni;
            DiasAnio = aux.Days;
        }

        private int cantDiasMes(DateTime fi, DateTime ff)
        {
            int cdFI = DateTime.DaysInMonth(fi.Year, fi.Month);
            int cdFf = DateTime.DaysInMonth(ff.Year, ff.Month);

            return cdFf == cdFI ? cdFI : 30;
        }

        public int calcularVacaciones(DateTime fIni, int year)
        {
            string fechaCierre = "31/12/" + year;
            fFinal=DateTime.Parse(fechaCierre);
            
            calcularAntiguedad(fIni, fFinal);

            int vacas = 0;
            //decimal dmes;

            if (Anio == 0 && Mes < 6)
            {
                if (DiasAnio / 7 >= 4 && DiasAnio / 7 <= 7) vacas = 1;
                else if (DiasAnio / 7 >= 8 && DiasAnio / 7 <= 11) vacas = 2;
                else if (DiasAnio / 7 >= 12 && DiasAnio / 7 <= 15) vacas = 3;
                else if (DiasAnio / 7 >= 16 && DiasAnio / 7 <= 19) vacas = 1;
                else if (DiasAnio / 7 >= 20) vacas = 5;

                //dmes = DiasAnio / 21;
                //vacas = (int)Math.Round(dmes);
            }

            else if (Anio <= 4) vacas = 14;
            else if (Anio >= 5 && Anio <= 9) vacas = 21;
            else if (Anio >= 10 && Anio <= 14) vacas = 28;
            else if (Anio >= 15 && Anio <= 19) vacas = 28;
            else if (Anio >= 20) vacas = 35;
            return vacas;
        }

    }
}
