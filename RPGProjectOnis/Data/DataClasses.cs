using RPGProjectOnis.Mdl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjectOnis.Data
{
    public class DataClasses
    {      

        internal Classes BuscaClasse(int id)
        {
            var listadeClasses = listaClasses();
            return listadeClasses.Single(p => p.id == id);
        }

        public List<Classes> listaClasses()
        {
            var dbClasses = File.ReadAllLines("C:/Users/Otto_/source/repos/RPGProject/RPGProjectOnis/Data/Classes.txt");
            List<Classes> listadeClasses = new List<Classes>();

            foreach (var line in dbClasses)
            {
                var itens = line.Split(';');
                var reg = new Classes
                {
                    id = Convert.ToInt32(itens[0]),
                    nome = itens[1],
                    proficiencias = itens[2],
                    equipamentos = itens[3],
                    iniVida = itens[4] == " " ? 0 : Convert.ToInt32(itens[4]),
                    vidaPorNivel = itens[5],
                    pericias = itens[6],
                    HabNvl1_1 = itens[7],
                    DescHabNvl1_1 = itens[8],
                    HabNvl1_2 = itens[9],
                    DescHabNvl1_2 = itens[10]
                    //Falta terminar
                };
                listadeClasses.Add(reg);
            }

            return listadeClasses;

        }
    }
}
