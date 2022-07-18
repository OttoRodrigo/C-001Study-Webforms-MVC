using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjectOnis.Mdl
{
    public class Classes
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string proficiencias { get; set; }
        public string equipamentos { get; set; }
        public int iniVida { get; set; }
        public string vidaPorNivel { get; set; }
        public string pericias { get; set; }

        //Habilidades de Nivel
        public string HabNvl1_1 { get; set; }
        public string DescHabNvl1_1 { get; set; }
        public string HabNvl1_2 { get; set; }
        public string DescHabNvl1_2 { get; set; }
        public string HabNvl2 { get; set; }
        public string DescHabNvl2 { get; set; }
        public string HabNvl3Caminho { get; set; }
        public string DescHabNvl3Caminho { get; set; }
        public string HabNvl3_1 { get; set; }
        public string DescHabNvl3_1 { get; set; }
        public string HabNvl3_2 { get; set; }
        public string DescHabNvl3_3 { get; set; }
        public string HabNvl4 { get; set; }
        public string DescHabNvl4 { get; set; }
        public string HabNvl5 { get; set; }
        public string DescHabNvl5 { get; set; }
        public string tesouroini { get; set; }
    }
}
