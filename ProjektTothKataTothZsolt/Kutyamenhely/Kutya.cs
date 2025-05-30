using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Kutyamenhely
{
    internal class Kutya
    {
        private int kor;
        private string nev;
        private bool szobatisztaE;
        private HashSet<string> tulajdonsagok;


        public Kutya(int kor, string nev, bool szobatiszta, string tulajdonsagok)
        {
            this.kor = kor;
            this.nev = nev;
            this.szobatisztaE = szobatiszta;
            this.tulajdonsagok = new HashSet<string>(tulajdonsagok.Split());
        }

        public Kutya(string valami)
        {
            string[] sor = valami.Split(';');
            this.kor = int.Parse(sor[0]);
            this.nev = sor[1];
            this.szobatisztaE = bool.Parse(sor[2]);
            this.tulajdonsagok = new HashSet<string>(sor[3].Split());
        }
        public string SzobatisztaE 
        {
            get
            {
                if (szobatisztaE)
                {
                    return "Szobatiszta";
                }
                else return "Nem szobatiszta";
            }
        }

        public bool IdosebbE(Kutya f)
        {
            if (this.kor < f.kor)
            {
                return false;
            }
            else return true;
        }

        public string Tulajdonsagok 
        {
            set
            {
                HashSet<string> tulajd = new HashSet<string> { "baratsagos", "huseges", "vedelmezo", "jatekos", "tanulekony" };
                if (!tulajd.Contains(value)) return; // garbage collector
                this.tulajdonsagok.Add(value);
            }
            get
            {
                string s = "";
                foreach (string item in tulajdonsagok)
                {
                    s += item + " ";
                }
                return s;
            }
        }

        public int Kor { get => kor; }

        public override string ToString()
        {
            return $"{nev}, {kor} eves, {SzobatisztaE}, {Tulajdonsagok}";
        }

        public string Ertek()
        {
            return $"(\"{nev}\", {kor}, \"{SzobatisztaE}\", \"{Tulajdonsagok}\")";
        }
    }
}
