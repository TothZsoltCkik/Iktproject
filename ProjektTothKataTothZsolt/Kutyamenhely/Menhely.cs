using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Kutyamenhely
{
    internal class Menhely
    {
        private List<Kutya> kutyak;

        public void FajlbolOlvas(string fajlnev)
        {
            StreamReader sr = new StreamReader(fajlnev);
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                Kutya f = new Kutya(s);
                kutyak.Add(f);
            }
            sr.Close();
        }



        public Kutya MinMax(string valasztas)
        {
            Kutya s = kutyak[0];
            for (int i = 0; i < kutyak.Count; i++)
            {
                if (valasztas == "max")
                {
                    if (kutyak[i].IdosebbE(s))
                    {
                        s = kutyak[i];
                    }
                }
                else if (valasztas == "min")
                {
                    if (!kutyak[i].IdosebbE(s))
                    {
                        s = kutyak[i];
                    }
                }
            }
            return s;
        }

        public void General(string fajlnev)
        {
            StreamWriter sw = new StreamWriter(fajlnev);
            sw.WriteLine("TRUNCATE menhely;");
            sw.WriteLine("INSERT INTO menhely(nev, kor, szobatisztaE, tulajdonsagok)");
            sw.WriteLine("VALUES");
            foreach (Kutya item in kutyak)
            {
                string veg = item != kutyak[kutyak.Count - 1] ? "," : ";";
                sw.WriteLine(item.Ertek() + veg);
            }
            sw.Close();
        }

    }
}
