using RPGProjectOnis.Mdl;
using RPGProjectOnis.Mdl.GV;
using RPGProjectOnis.Svc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPGProjectOnis.Web.WF
{
    public partial class ListaPersonagensPage : System.Web.UI.Page
    {
        SvcRacas _racas = new SvcRacas();
        SvcClasses _classes = new SvcClasses();
        SvcPDJ _PDJs = new SvcPDJ();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cbRacas();
                cbClasse();
                cbNivel();
                gridPersonagens();
            }
        }

        protected void gridPersonagens()
        {
            var PDJs = _PDJs.listaPDJ();
            List<gvPDJ> gridpers = new List<gvPDJ>();

            foreach(var item in PDJs)
            {
                var classeitem = _classes.buscaClasse(item.classe);
                var racaitem = _racas.buscaRaca(item.raca);
                gridpers.Add(new gvPDJ { id = item.cod, nome = item.nome, jogador = item.jogador,
                                         classe = classeitem.nome, raca = racaitem.nome, nivel = item.nivel });
            }

            gdPersonagens.DataSource = gridpers;
            gdPersonagens.AllowPaging = true;
            gdPersonagens.PageSize = 10;
            gdPersonagens.DataBind();


            //gdPersonagens.;
            //gdPersonagens.DataBind();
           
        }

        protected void grdItens_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gdPersonagens.PageIndex = e.NewPageIndex;
            gridPersonagens();
        }

        protected void gdPersonagens_OnPageIndexChanged(object sender, GridViewPageEventArgs e)
        {
            gdPersonagens.PageIndex = e.NewPageIndex;
            gdPersonagens.DataBind();
        }

        protected void dpNivel_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void dpRacas_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void dpClasses_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void cbRacas()
        {
            var listadeRacas = _racas.ListarRacascTodos();

            dpRacas.DataSource = listadeRacas;
            

            dpRacas.DataTextField = "nome";//item.nome;
            dpRacas.DataValueField = "id";//item.id.ToString();

            dpRacas.DataBind();
        }

        protected void cbClasse()
        {
            var listadeClasses = _classes.ListarClassescTodas();

            dpClasses.DataSource = listadeClasses;

            dpClasses.DataTextField = "nome";
            dpClasses.DataValueField = "id";

            dpClasses.DataBind();
        }

        protected void cbNivel()
        {
            List<string> nvl = new List<string>();
            nvl.Add("Todos");

            for(var i = 1; i <= 20; i++)
            {
                nvl.Add(i.ToString());
            }

            dpNivel.DataSource = nvl;
            dpNivel.DataBind();
        }

    }
}