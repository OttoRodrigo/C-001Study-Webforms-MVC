using RPGProjectOnis.Mdl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjectOnis.Data
{
    public class DataPDM
    {
        internal List<PDM> listaPDMs()
        {
            var dbPDM = File.ReadAllLines("C:/Users/Otto_/source/repos/RPGProject/RPGProjectOnis/Data/PDM.txt");
            List<PDM> listaPDMs = new List<PDM>();

            foreach (var line in dbPDM)
            {
                var itens = line.Split(';');
                var reg = new PDM
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
                listaPDMs.Add(reg);
            }

            return listaPDMs;
        }

        internal PDM encontraPDM(int id)
        {
            var listaPDM = listaPDMs();

            return listaPDM.Single(p => p.cod == id);
        }

        internal int buscaNovoId()
        {
            var PDMs = listaPDMs();
            var cod = PDMs.Max(p => p.cod);

            return cod + 1;

        }

        internal void addPDM(PDM personagem)
        {
            var dbPDMcaminho = "C:/Users/Otto_/source/repos/RPGProject/RPGProjectOnis/Data/PDM.txt";
            int id = buscaNovoId();
            StreamWriter arq = File.AppendText(dbPDMcaminho);

            arq.WriteLine(id.ToString() + ";" + personagem.nome + ";" + personagem.nivel + ";" + personagem.vida
                          + ";" + personagem.classeArmadura + ";" + personagem.forca + ";" + personagem.habilidade
                          + ";" + personagem.constituicao + ";" + personagem.inteligencia + ";" + personagem.sabedoria
                          + ";" + personagem.carisma + ";" + personagem.status + ";" + personagem.raca
                          + ";" + personagem.classe + ";" + personagem.tipo
                          + ";" + personagem.loot + ";" + personagem.ouro + ";");
            arq.Close();
        }

        internal void deletePDM(int id)
        {
            var listadePDMs = listaPDMs();
            var remover = listadePDMs.Single(p => p.cod == id);
            listadePDMs.Remove(remover);

            var dbPDMcaminho = "C:/Users/Otto_/source/repos/RPGProject/RPGProjectOnis/Data/PDM.txt";
            File.Delete(dbPDMcaminho);
            StreamWriter arq = File.AppendText(dbPDMcaminho);

            foreach(var line in listadePDMs)
            {
                arq.WriteLine(line.cod.ToString() + ";" + line.nome + ";" + line.nivel + ";" + line.vida
                              + ";" + line.classeArmadura + ";" + line.forca + ";" + line.habilidade
                              + ";" + line.constituicao + ";" + line.inteligencia + ";" + line.sabedoria
                              + ";" + line.carisma + ";" + line.status + ";" + line.raca
                              + ";" + line.classe + ";" + line.tipo
                              + ";" + line.loot + ";" + line.ouro + ";");
            }
            arq.Close();
        }

        internal void updatePDM(PDM AtPersonagem)
        {
            var listadePDMs = listaPDMs();

            var dbPDMcaminho = "C:/Users/Otto_/source/repos/RPGProject/RPGProjectOnis/Data/PDM.txt";
            File.Delete(dbPDMcaminho);
            StreamWriter arq = File.AppendText(dbPDMcaminho);

            foreach (var line in listadePDMs)
            {
                if(AtPersonagem.cod == line.cod)
                {
                    arq.WriteLine(AtPersonagem.cod.ToString() + ";" + AtPersonagem.nome + ";" + AtPersonagem.nivel + ";" + AtPersonagem.vida
                              + ";" + AtPersonagem.classeArmadura + ";" + AtPersonagem.forca + ";" + AtPersonagem.habilidade
                              + ";" + AtPersonagem.constituicao + ";" + AtPersonagem.inteligencia + ";" + AtPersonagem.sabedoria
                              + ";" + AtPersonagem.carisma + ";" + AtPersonagem.status + ";" + AtPersonagem.raca
                              + ";" + AtPersonagem.classe + ";" + AtPersonagem.tipo
                              + ";" + AtPersonagem.loot + ";" + AtPersonagem.ouro + ";");
                }
                else
                {
                    arq.WriteLine(line.cod.ToString() + ";" + line.nome + ";" + line.nivel + ";" + line.vida
                              + ";" + line.classeArmadura + ";" + line.forca + ";" + line.habilidade
                              + ";" + line.constituicao + ";" + line.inteligencia + ";" + line.sabedoria
                              + ";" + line.carisma + ";" + line.status + ";" + line.raca
                              + ";" + line.classe + ";" + line.tipo
                              + ";" + line.loot + ";" + line.ouro + ";");
                }                
            }
            arq.Close();
        }
    }
}
