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

        public Kutya Nemtudom(string valasztas)
        {
            Kutya s = kutyak[0];
            string veg = film != filmek[filmek.Count - 1] ? "," : ";";
            for (int i = 0; i < kutyak.Count; i++)
            {
                if (kutyak[i].Kor < s.Kor)
                {
                    s = kutyak[i];
                }
            }
        }
    }
}
