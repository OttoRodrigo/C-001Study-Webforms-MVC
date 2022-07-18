using RPGProjectOnis.Mdl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjectOnis.Data
{
    public class DataRacas
    {      

        internal List<Racas> ListaRacasTxt()
        {
            var dbRacas = File.ReadAllLines("C:/Users/Otto_/source/repos/RPGProject/RPGProjectOnis/Data/Racas.txt");
            List<Racas> listadeRacas = new List<Racas>();

            foreach (var line in dbRacas)
            {
                var itens = line.Split(';');
                var reg = new Racas
                {
                    id = Convert.ToInt32(itens[0]),
                    nome = itens[1],
                    abRacial1 = itens[2] == " " ? 0 : Convert.ToInt32(itens[2]),
                    abRacial1Nome = itens[3],
                    abRacial1Desc = itens[4],
                    abRacial2 = itens[5] == " " ? 0 : Convert.ToInt32(itens[5]),
                    abRacial2Nome = itens[6],
                    abRacial2Desc = itens[7],
                    abRacial3 = itens[8] == " " ? 0 : Convert.ToInt32(itens[8]),
                    abRacial3Nome = itens[9],
                    abRacial3Desc = itens[10],
                    atrRacial1 = itens[11] == " " ? 0 : Convert.ToInt32(itens[11]),
                    atrRacial1Val = itens[12] == " " ? 0 : Convert.ToInt32(itens[12]),
                    atrRacial2 = itens[13] == " " ? 0 : Convert.ToInt32(itens[13]),
                    atrRacial2Val = itens[14] == " " ? 0 : Convert.ToInt32(itens[14]),
                    atrRacial3 = itens[15] == " " ? 0 : Convert.ToInt32(itens[15]),
                    atrRacial3Val = itens[16] == " " ? 0 : Convert.ToInt32(itens[16])
                };
                listadeRacas.Add(reg);
            }
                

            return listadeRacas;
        }

        internal Racas BuscaRaca(int id)
        {
            var listaRacas = ListaRacasTxt();
            return listaRacas.Single(p => p.id == id);
        }
               
    }
}
