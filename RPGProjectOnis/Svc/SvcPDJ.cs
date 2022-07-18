using RPGProjectOnis.Data;
using RPGProjectOnis.Mdl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjectOnis.Svc
{
    public class SvcPDJ
    {
        DataPDJ _pdjacess = new DataPDJ();

        public void addPDJ(PDJ personagem)
        {
            
            _pdjacess.addPDJ(personagem);
        }

        public List<PDJ> listaPDJ()
        {
            return _pdjacess.ListaPDJ();
        }
    }
}
