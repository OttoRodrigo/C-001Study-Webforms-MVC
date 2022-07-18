using RPGProjectOnis.Data;
using RPGProjectOnis.Mdl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjectOnis.Svc
{
    public class SvcRacas
    {
        public List<Racas> ListarRacas()
        {
            var dadosRacas = new DataRacas();
            var listaRacas = dadosRacas.ListaRacasTxt();
            var rem = listaRacas.Single(p => p.id == 0);
            listaRacas.Remove(rem);

            return listaRacas;
        }

        public List<Racas> ListarRacascTodos()
        {
            var dadosRacas = new DataRacas();
            var listaRacas = dadosRacas.ListaRacasTxt();
            
            return listaRacas;
        }

        public Racas buscaRaca(int id)
        {
            var dadosRacas = new DataRacas();
            var raca = dadosRacas.BuscaRaca(id);
            return raca;
        }
    }
}
