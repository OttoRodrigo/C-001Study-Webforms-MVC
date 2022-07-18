using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjectOnis.Mdl
{
    public class Personagem
    {
        public int cod { get; set; }
        public string nome { get; set; }
        public int nivel { get; set; }
        public int vida { get; set; }
        [DisplayName("CA")]
        public int classeArmadura { get; set; }

        public int forca { get; set; }
        public int habilidade { get; set; }
        public int constituicao { get; set; }
        public int inteligencia { get; set; }
        public int sabedoria { get; set; }
        public int carisma { get; set; }

        public int status { get; set; } //ex envenenado-morto-desmaiado
        public int raca { get; set; }
        public int classe { get; set; }
        
        public Personagem(int pcod, string pnome, int pnivel, int pvida, int pca, int pfor, int pdes, int pcon,
                          int pint, int psab, int pcar, int psta, int praca, int pclas)
        {
            cod = pcod;
            nome = pnome;
            nivel = pnivel;
            vida = pvida;
            classeArmadura = pca;
            forca = pfor;
            habilidade = pdes;
            constituicao = pcon;
            inteligencia = pint;
            carisma = pcar;
            status = psta;
            raca = praca;
            classe = pclas;
        }


    }
}
