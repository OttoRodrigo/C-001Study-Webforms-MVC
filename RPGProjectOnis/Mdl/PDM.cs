using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjectOnis.Mdl
{
    public class PDM : Personagem
    {
        public string tipo { get; set; }
        public string loot { get; set; }
        public int ouro { get; set; }

        public PDM(int pcod, string pnome, int pnivel, int pvida, int pca, int pfor, int pdes, int pcon,
                          int pint, int psab, int pcar, int psta, int praca, int pclas, string ptip, string ploot, int pour) :
            base (pcod, pnome, pnivel, pvida, pca, pfor, pdes, pcon,
                          pint, psab, pcar, psta, praca, pclas)
        {
            tipo = ptip;
            loot = ploot;
            ouro = pour;
        }
        public PDM() : base(0, "", 0, 0, 0, 0, 0, 0,
                                   0, 0, 0, 0, 0, 0)
        {
        }
    }
}
