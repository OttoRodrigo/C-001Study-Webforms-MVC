using RPGProjectOnis.Mdl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjectOnis.Data
{
    public class DataMessage
    {
        public string contMessage(int id, char tipo, string item)
        {
            var messages = listaMessage().Single(p => p.id == id && p.tipo == tipo);
            var valret = "";

            if (messages.id == 1 && messages.tipo == 'S' ||
                messages.id == 1 && messages.tipo == 'V' ||
                messages.id == 2 && messages.tipo == 'V')
            {
                valret =  item + messages.message1;
            }
            if (messages.id == 1 && messages.tipo == 'E')
            {
                valret =  messages.message1 + item + messages.message2;
            }

            return valret;

        }

        private List<Message> listaMessage()
        {
            var dbMessage = File.ReadAllLines("C:/Users/Otto_/source/repos/RPGProject/RPGProjectOnis/Data/Message.txt");
            List<Message> listaMessage = new List<Message>();

            foreach (var line in dbMessage)
            {

                var itens = line.Split(';');

                var reg = new Message
                {
                    id = Convert.ToInt32(itens[0]),
                    tipo = Convert.ToChar(itens[1]),
                    message1 = itens[2],
                    message2 = itens[3]
                  
                };
                listaMessage.Add(reg);
            }

            return listaMessage;
        }

    }
}
