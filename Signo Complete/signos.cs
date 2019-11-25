using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signo_Complete
{
    class signos
    {
        private DateTime data;
        public string recebe
        {
            set
            {
                data = Convert.ToDateTime(value);
            }
        }
        public string diasemana
        {
            get
            {
                string frase = "O dia da semana em que nasceu é ";
                frase += data.ToString("dddd") + ".\n";
                return frase;
            }
        }
        private string idade
        {
            get
            {
                DateTime hoje = DateTime.Now;
                TimeSpan dif = hoje - data;
                DateTime idade = DateTime.MinValue + dif;
                string frase = "A sua idade é ";
                frase += (idade.Year - 1) + " anos, ";
                frase += (idade.Month - 1) + " meses e tem ";
                frase += (idade.Day - 1) + " dias.\n";
                return frase;
            }
        }
        private string signo
        {
            get
            {
                string s = "";
                int d = data.Month * 100 + data.Day;
                if (d < 121 | d > 1221) s = "Capricórnio";
                else if (d < 219) s = "Aquário";
                else if (d < 321) s = "Peixes";
                else if (d < 420) s = "Carneiro";
                else if (d < 521) s = "Touro";
                else if (d < 621) s = "Gémios";
                else if (d < 723) s = "Carangeujo";
                else if (d < 833) s = "Leão";
                else if (d < 923) s = "Balança";
                else if (d < 1022) s = "Escorpião";
                else if (d < 1122) s = "Sagitário";
                else if (d < 1222) s = "Sagitário";
                string frase = "O seu signo é ";
                frase += s + ".\n";
                return frase;
            }
        }
        public string envia
        {
            get
            {
                return diasemana + idade + signo;
            }
        }
    }
}
