using RPGProjectOnis.Mdl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjectOnis.Data
{
    public class DataPDJ
    {

        internal List<PDJ> ListaPDJ()
        {
            var dbPDJ = File.ReadAllLines("C:/Users/Otto_/source/repos/RPGProject/RPGProjectOnis/Data/PDJ.txt");
            List<PDJ> listadePDJ = new List<PDJ>();

            foreach (var line in dbPDJ)
            {
                var itens = line.Split(';');
                var reg = new PDJ
                (
                 Convert.ToInt32(itens[0]),
                                 itens[1],
                 itens[2] == "" ? 0 : Convert.ToInt32(itens[2]),
                 itens[3] == "" ? 0 : Convert.ToInt32(itens[3]),
                 itens[4] == "" ? 0 : Convert.ToInt32(itens[4]),
                 itens[5] == "" ? 0 : Convert.ToInt32(itens[5]),
                 itens[6] == "" ? 0 : Convert.ToInt32(itens[6]),
                 itens[7] == "" ? 0 : Convert.ToInt32(itens[7]),
                 itens[8] == "" ? 0 : Convert.ToInt32(itens[8]),
                 itens[9] == "" ? 0 : Convert.ToInt32(itens[9]),
                 itens[10] == "" ? 0 : Convert.ToInt32(itens[10]),
                 itens[11] == "" ? 0 : Convert.ToInt32(itens[11]),
                 itens[12] == "" ? 0 : Convert.ToInt32(itens[12]),
                 itens[13] == "" ? 0 : Convert.ToInt32(itens[13]),
                                 itens[14],
                                 itens[15],
                 itens[16] == "" ? 0 : Convert.ToInt32(itens[16])
                );
                listadePDJ.Add(reg);
            }


            return listadePDJ;
        }

        private int buscaNovoId()
        {
            var PDJs = ListaPDJ();
            var cod = PDJs.Max(p => p.cod);

            return cod+1;

        }

        internal void addPDJ(PDJ personagem)
        {
            var dbPDJcaminho = "C:/Users/Otto_/source/repos/RPGProject/RPGProjectOnis/Data/PDJ.txt";
            int id = buscaNovoId();
            StreamWriter arq = File.AppendText(dbPDJcaminho);

            arq.WriteLine(id.ToString()+";"+personagem.nome + ";" +personagem.nivel + ";" +personagem.vida
                          + ";" +personagem.classeArmadura + ";" +personagem.forca + ";" +personagem.habilidade
                          + ";" +personagem.constituicao + ";" +personagem.inteligencia + ";" +personagem.sabedoria
                          + ";" +personagem.carisma + ";" +personagem.status + ";" +personagem.raca
                          + ";" +personagem.classe + ";" +personagem.jogador
                          + ";" +personagem.Inventario + ";" +personagem.Ouro + ";");
            arq.Close();
        }
    }
}
