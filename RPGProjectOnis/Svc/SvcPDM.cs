using RPGProjectOnis.Data;
using RPGProjectOnis.Mdl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjectOnis.Svc
{
    public class SvcPDM
    {
        DataPDM _dadosPDM = new DataPDM();

        public List<PDM> ListarPDMs()
        {
                        

            return _dadosPDM.listaPDMs();
        }

        public PDM encontraPDM(int id)
        {
           return _dadosPDM.encontraPDM(id);
        }

        public void addPDM(PDM personagem)
        {
            _dadosPDM.addPDM(personagem);
        }

        public void deletePDM(int id)
        {
            _dadosPDM.deletePDM(id);
        }

        public void updatePDM(PDM atPersonagem)
        {
            _dadosPDM.updatePDM(atPersonagem);
        }
    }
}
