using RPGProjectOnis.Data;
using RPGProjectOnis.Mdl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjectOnis.Svc
{
    public class SvcClasses
    {
        public List<Classes> ListarClasses()
        {
            var dadosClasses = new DataClasses();
            var listaClasses = dadosClasses.listaClasses();
            var rem = listaClasses.Single(p => p.id == 0);
            listaClasses.Remove(rem);

            return listaClasses;
        }

        public List<Classes> ListarClassescTodas()
        {
            var dadosClasses = new DataClasses();
            var listaClasses = dadosClasses.listaClasses();

            return listaClasses;
        }

        public Classes buscaClasse(int id)
        {
            var dadosClasses = new DataClasses();
            var classe = dadosClasses.BuscaClasse(id);
            return classe;
        }
    }
}
