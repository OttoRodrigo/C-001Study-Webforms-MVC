using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjectOnis.Mdl
{
    public class PDJ : Personagem
    {
        public string jogador { get; set; }
        public string Inventario { get; set; }
        public int Ouro { get; set; }

        public PDJ(int pcod, string pnome, int pnivel, int pvida, int pca, int pfor, int pdes, int pcon,
                          int pint, int psab, int pcar, int psta, int praca, int pclas, string pjog, string pinv, int pour) :
            base (pcod, pnome, pnivel, pvida, pca, pfor, pdes, pcon,
                          pint, psab, pcar, psta, praca, pclas)
        {
            jogador = pjog;
            Inventario = pinv;
            Ouro = pour;
        }
        public PDJ() : base(0, "", 0, 0, 0, 0, 0, 0,
                                   0, 0, 0, 0, 0, 0)
        {
        }
    }
}
