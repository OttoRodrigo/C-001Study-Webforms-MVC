using RPGProjectOnis.Data;
using RPGProjectOnis.Mdl;
using RPGProjectOnis.Svc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPGProjectOnis.Web.WF
{
    public partial class CriarPersonagemPage : System.Web.UI.Page
    {
        private int _addForR = 0,_addDesR = 0, _addConR = 0, _addIntR = 0, _addSabR = 0, _addCarR = 0;
        private int _addForC = 0, _addDesC = 0, _addConC = 0, _addIntC = 0, _addSabC = 0, _addCarC = 0;
        private DataMessage _instMessage = new DataMessage();
        SvcRacas _racas = new SvcRacas();
        SvcClasses _classes = new SvcClasses();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cbRacas();
                addAtrRacas();
                cbClasse();
                addAtrClasses();
            }
            
        }

        protected void cbRacas()
        {
            var listadeRacas = _racas.ListarRacas();

            dpRacas.DataSource = listadeRacas;

            dpRacas.DataTextField = "nome";//item.nome;
            dpRacas.DataValueField = "id";//item.id.ToString();
            
            dpRacas.DataBind();
        }

        protected void cbClasse()
        {
            var listadeClasses = _classes.ListarClasses();

            dpClasses.DataSource = listadeClasses;

            dpClasses.DataTextField = "nome";
            dpClasses.DataValueField = "id";

            dpClasses.DataBind();
        }

        protected void dpRacas_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            addAtrRacas(); 
        }

        protected void dpClasses_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            addAtrClasses();
        }
               
        protected void addDpEquip(string equips)
        {
            string[]  equipamentos = equips.Split('|');
            List<string> dpdataequip1 = new List<string>();
            List<string> dpdataequip2 = new List<string>();
            List<string> dpdataequip3 = new List<string>();
            List<string> dpdataequip4 = new List<string>();
            var count = 0;

            foreach (var item in equipamentos)
            {

                string[] opcoes = item.Split('*');

                if (count == 0)
                {
                    foreach(var opc in opcoes)
                    {
                        dpdataequip1.Add(opc);
                    }
                }
                if (count == 1)
                {
                    foreach (var opc in opcoes)
                    {
                        dpdataequip2.Add(opc);
                    }
                }
                if (count == 2)
                {
                    foreach (var opc in opcoes)
                    {
                        dpdataequip3.Add(opc);
                    }
                }
                if (count == 3)
                {
                    foreach (var opc in opcoes)
                    {
                        dpdataequip4.Add(opc);
                    }
                }

                count++;
            }


            dpEq1.DataSource = dpdataequip1;
            dpEq2.DataSource = dpdataequip2;
            dpEq3.DataSource = dpdataequip3;
            dpEq4.DataSource = dpdataequip4;


            dpEq1.DataBind();
            dpEq2.DataBind();
            dpEq3.DataBind();
            if(equipamentos.Length > 3 )
            {
                dpEq4.Visible = true;
                dpEq4.DataBind();
            }
            else
            {
                dpEq4.Visible = false;
                dpEq4.DataBind();
            }
        }

        protected void addVida(int vida)
        {
            tbVida.Text = vida.ToString();
        }

        protected void addHabIniClasse(string hab1, string hab1Desc, string hab2, string hab2Desc)
        {
            var habIniciais = hab1 + "</br>" + hab1Desc + "</br></br>" + hab2 + "</br>" + hab2Desc;
            lbHabClasse.Text = habIniciais; 
        }

        protected void addHabRaca(int codhab1, string hab1, string hab1Desc,
                                  int codhab2, string hab2, string hab2Desc,
                                  int codhab3, string hab3, string hab3Desc)
        {
            var habRaca = hab1 + "</br>" + hab1Desc + "</br></br>" + hab2 + "</br>" + hab2Desc +
                                                      "</br></br>" + hab3 + "</br>" + hab3Desc;
            lbHabRaca.Text = habRaca;
        }


        protected void addAtrClasses()
        {
            var classe = _classes.buscaClasse(Convert.ToInt32(dpClasses.SelectedValue));
            addVida(classe.iniVida);
            addHabIniClasse(classe.HabNvl1_1, classe.DescHabNvl1_1, classe.HabNvl1_2, classe.DescHabNvl1_2);
            addDpEquip(classe.equipamentos);
        }

        protected void addAtrRacas()
        {
            var raca = _racas.buscaRaca(Convert.ToInt32(dpRacas.SelectedValue));
            addAtr(raca.atrRacial1, raca.atrRacial1Val, raca.atrRacial2, raca.atrRacial2Val,
                   raca.atrRacial3, raca.atrRacial3Val, "r");
            addHabRaca(raca.abRacial1, raca.abRacial1Nome, raca.abRacial1Desc,
                       raca.abRacial2, raca.abRacial2Nome, raca.abRacial2Desc,
                       raca.abRacial3, raca.abRacial3Nome, raca.abRacial3Desc);
        }

        protected void addAtr(int atr1, int val1, int atr2, int val2, int atr3, int val3, string raccla)
        {
            if(raccla == "r")
            {
                _addForR = atr1 == 1 ? val1 : atr2 == 1 ? val2 : atr3 == 1 ? val3 : 0;
                _addDesR = atr1 == 2 ? val1 : atr2 == 2 ? val2 : atr3 == 2 ? val3 : 0;
                _addConR = atr1 == 3 ? val1 : atr2 == 3 ? val2 : atr3 == 3 ? val3 : 0;
                _addIntR = atr1 == 4 ? val1 : atr2 == 4 ? val2 : atr3 == 4 ? val3 : 0;
                _addSabR = atr1 == 5 ? val1 : atr2 == 5 ? val2 : atr3 == 5 ? val3 : 0;
                _addCarR = atr1 == 6 ? val1 : atr2 == 6 ? val2 : atr3 == 6 ? val3 : 0;
            }
            if (raccla == "c")
            {
                _addForC = atr1 == 1 ? val1 : atr2 == 1 ? val2 : atr3 == 1 ? val3 : 0;
                _addDesC = atr1 == 2 ? val1 : atr2 == 2 ? val2 : atr3 == 2 ? val3 : 0;
                _addConC = atr1 == 3 ? val1 : atr2 == 3 ? val2 : atr3 == 3 ? val3 : 0;
                _addIntC = atr1 == 4 ? val1 : atr2 == 4 ? val2 : atr3 == 4 ? val3 : 0;
                _addSabC = atr1 == 5 ? val1 : atr2 == 5 ? val2 : atr3 == 5 ? val3 : 0;
                _addCarC = atr1 == 6 ? val1 : atr2 == 6 ? val2 : atr3 == 6 ? val3 : 0;
            }

            lbAddFor.Text = _addForC + _addForR >= 0 ? "+" + (_addForC + _addForR).ToString() : (_addForC + _addForR).ToString();
            lbAddDes.Text = _addDesC + _addDesR >= 0 ? "+" + (_addDesC + _addDesR).ToString() : (_addDesC + _addDesR).ToString();
            lbAddCon.Text = _addConC + _addConR >= 0 ? "+" + (_addConC + _addConR).ToString() : (_addConC + _addConR).ToString();
            lbAddInt.Text = _addIntC + _addIntR >= 0 ? "+" + (_addIntC + _addIntR).ToString() : (_addIntC + _addIntR).ToString();
            lbAddSab.Text = _addSabC + _addSabR >= 0 ? "+" + (_addSabC + _addSabR).ToString() : (_addSabC + _addSabR).ToString();
            lbAddCaris.Text = _addCarC + _addCarR >= 0 ? "+" + (_addCarC + _addCarR).ToString() : (_addCarC + _addCarR).ToString();
        }

        protected void btnCriarPers_OnClick(Object sender, EventArgs e)
        {
            var valid = validaCampos();

            if (valid)
            {
                PDJ personagem = new PDJ();
                personagem.nome = TbNomePers.Text;
                personagem.nivel = 1;
                personagem.vida = Convert.ToInt32(tbVida.Text);
                personagem.forca = Convert.ToInt32(tbForca.Text) + Convert.ToInt32(lbAddFor.Text);
                personagem.habilidade = Convert.ToInt32(tbDest.Text) + Convert.ToInt32(lbAddDes.Text);
                personagem.constituicao = Convert.ToInt32(tbConst.Text) + Convert.ToInt32(lbAddCon.Text);
                personagem.inteligencia = Convert.ToInt32(tbInt.Text) + Convert.ToInt32(lbAddInt.Text);
                personagem.sabedoria = Convert.ToInt32(tbSab.Text) + Convert.ToInt32(lbAddSab.Text);
                personagem.carisma = Convert.ToInt32(tbCaris.Text) + Convert.ToInt32(lbAddCaris.Text);
                personagem.status = 1;
                personagem.raca = Convert.ToInt32(dpRacas.SelectedValue);
                personagem.classe = Convert.ToInt32(dpClasses.SelectedValue);
                personagem.jogador = tbJogador.Text;
                personagem.Inventario = dpEq1.SelectedValue + "|" + dpEq2.SelectedValue
                                + "|" + dpEq3.SelectedValue + "|" + dpEq4.SelectedValue;
                personagem.Ouro = 0;

                SvcPDJ pdjacess = new SvcPDJ();
                pdjacess.addPDJ(personagem);

                chamaMenssagemJs(1, 'S', "Personagem");
                limpaCampos();
            }
        }

        protected bool validaCampos()
        {

            
            List<string> validaAtr = new List<string>();
            string itemmsg = "";
            int count = 1;

            if (tbForca.Text == "")
                validaAtr.Add("Força");
            if (tbDest.Text == "")
                validaAtr.Add("Destreza");
            if (tbConst.Text == "")
                validaAtr.Add("Constituição");
            if (tbInt.Text == "")
                validaAtr.Add("Inteligência");
            if (tbSab.Text == "")
                validaAtr.Add("Sabedoria");
            if (tbCaris.Text == "")
                validaAtr.Add("Carisma");

            if(validaAtr.Count() != 0)
            {
                foreach(var item in validaAtr)
                {
                    if(count == 1 || count == validaAtr.Count())
                    {
                        itemmsg += count == validaAtr.Count() ? " e " + item : item;
                    }
                    if(count !=1 && count != validaAtr.Count())
                    {
                        itemmsg += ", " + item;
                    }
                    count++;
                }

                chamaMenssagemJs(1, 'V', itemmsg);
                return false;
            }
            
            if(TbNomePers.Text == "")
            {
                chamaMenssagemJs(1, 'V', "Nome do Personagem");
                return false;
            }

            List<string> validaValAtr = new List<string>();

            if (Convert.ToInt32(tbForca.Text) > 18 || Convert.ToInt32(tbForca.Text) < 0)
                validaValAtr.Add("Força");
            if (Convert.ToInt32(tbDest.Text) > 18 || Convert.ToInt32(tbDest.Text) < 0)
                validaValAtr.Add("Destreza");
            if (Convert.ToInt32(tbConst.Text) > 18 || Convert.ToInt32(tbConst.Text) < 0)
                validaValAtr.Add("Constituição");
            if (Convert.ToInt32(tbInt.Text) > 18 || Convert.ToInt32(tbInt.Text) < 0)
                validaValAtr.Add("Inteligência");
            if (Convert.ToInt32(tbSab.Text) > 18 || Convert.ToInt32(tbSab.Text) < 0)
                validaValAtr.Add("Sabedoria");
            if (Convert.ToInt32(tbCaris.Text) > 18 || Convert.ToInt32(tbCaris.Text) < 0)
                validaValAtr.Add("Carisma");

            if (validaValAtr.Count() != 0)
            {
                foreach (var item in validaValAtr)
                {
                    if (count == 1 || count == validaValAtr.Count())
                    {
                        itemmsg += count == validaValAtr.Count() && count != 1 ? " e " + item : item;
                    }
                    if (count != 1 && count != validaValAtr.Count())
                    {
                        itemmsg += ", " + item;
                    }
                    count++;
                }

                chamaMenssagemJs(2, 'V', itemmsg);
                return false;
            }

            return true;
        }

        protected void limpaCampos()
        {
            TbNomePers.Text = "";
            tbJogador.Text = "";
            tbForca.Text = "";
            tbDest.Text = "";
            tbConst.Text = "";
            tbInt.Text = "";
            tbSab.Text = "";
            tbCaris.Text = "";
        }

        protected void chamaMenssagemJs(int cod, char tipo, string item)
        {
            var message = _instMessage.contMessage(cod, tipo, item);

            ScriptManager.RegisterClientScriptBlock(
                    Page,
                    Page.GetType(),
                    "mensagem",
                    $"<script type=\"text/javascript\">alert('{message}');</script>",
                    false);
        }

    }
}