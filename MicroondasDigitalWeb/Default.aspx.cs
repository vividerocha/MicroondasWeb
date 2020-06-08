using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MicroondasDigitalWeb.Controllers;

namespace MicroondasDigitalWeb
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(lblPotencia.Text == "")
                {
                    lblPotencia.Text = "10";
                }

                if(Session["Timer"] == null)
                {
                    Session["Timer"] = "00:00";
                }
                if(Session["Alimento"] == null)
                {
                    Session["Alimento"] = "Alimento";
                }
                Timer1.Enabled = false;
                cronometro.Text = "00:00";
                if(Session["Mensagem"] != null) { 
                    lblMensagem.Text = Session["Mensagem"].ToString();
                }
                else
                {
                    lblMensagem.Text = "";
                }
                
            }
            
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            string tempo = Session["Timer"].ToString();
            string[] tmp = tempo.Split(':');
            string minutos = tmp[0].ToString();
            string segundos = tmp[1].ToString();
            int segs = Convert.ToInt16(segundos);
            int mins = Convert.ToInt16(minutos);

            if (tempo != "00:00")
            {
                if (segs == 0)
                {
                    if (mins == 0)
                    {
                        int segundosTotais = (mins * 60) + segs;
                        //cronometro zerou
                        MicroondasController contr = new MicroondasController();
                        string mensagem = contr.aquecerAlimento(Session["Alimento"].ToString(), segundosTotais, Convert.ToInt16(lblPotencia.Text), lblCaractereAquecimento.Text);
                        Session["mensagem"] = mensagem;
                        Session["Alimento"] = "";
                        Response.Redirect("Default.aspx");
                    }
                    else
                    {
                        mins = mins - 1;
                        segs = 59;
                    }

                }
                else
                {
                    segs = segs - 1;
                }

                if (mins.ToString().Length == 1)
                {
                    if (mins == 0)
                    {
                        minutos = "00";
                    }
                    else
                    {
                        minutos = "0" + mins;
                    }

                }
                else
                {
                    minutos = mins.ToString();
                }

                if (segs.ToString().Length == 1)
                {
                    if (segs == 0)
                    {
                        segundos = "00";
                    }
                    else
                    {
                        segundos = "0" + segs;
                    }

                }
                else
                {
                    segundos = segs.ToString();
                }
                Session["Timer"] = minutos + ":" + segundos;
                cronometro.Text = minutos + ":" + segundos;
            }
            else
            {
                int segundosTotais = (mins * 60) + segs;
                //cronometro zerou
                MicroondasController contr = new MicroondasController();
                string mensagem = contr.aquecerAlimento(Session["Alimento"].ToString(), segundosTotais, Convert.ToInt16(lblPotencia.Text), lblCaractereAquecimento.Text);
                Session["mensagem"] = mensagem;
                Session["Alimento"] = "";
                Response.Redirect("Default.aspx");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["mensagem"] = "";
            lblMensagem.Text = "";
            Timer1.Enabled = false;
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if(cronometro.Text == "00:00")
            {
                Session["Timer"] = "00:30";
                lblPotencia.Text = "8";
            }
            else
            {
                string tempo = cronometro.Text;
                string[] tmp = tempo.Split(':');
                int minutos = Convert.ToInt16(tmp[0].ToString());
                int segundos = Convert.ToInt16(tmp[1].ToString());
                int totalSegundos = (minutos * 60) + segundos;
                //tempo máximo é de 2 minutos
                if (totalSegundos > 120)
                {
                    lblMensagem.Text = "O tempo máximo para aquecimento é de 2 minutos!";
                    Timer1.Enabled = false;
                }
                else
                {
                    Session["Timer"] = cronometro.Text;
                    Session["mensagem"] = "";
                    lblMensagem.Text = "";
                    Timer1.Enabled = true;
                }
                
            }
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session["mensagem"] = "";
            lblMensagem.Text = "";
            Session["Timer"] = "00:00";
            cronometro.Text = "00:00";
            Timer1.Enabled = false;
        }

        protected void trataTextoCronometro(string tempo)
        {
            string[] tmp = tempo.Split(':');
            string minutos = tmp[0].ToString();
            string segundos = tmp[1].ToString();
            
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            MicroondasController micro = new MicroondasController();
            cronometro.Text = micro.configuraCronometro("1", Session["Timer"].ToString());
            Session["Timer"] = cronometro.Text;
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            MicroondasController micro = new MicroondasController();
            cronometro.Text = micro.configuraCronometro("2", Session["Timer"].ToString());
            Session["Timer"] = cronometro.Text;
        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            MicroondasController micro = new MicroondasController();
            cronometro.Text = micro.configuraCronometro("3", Session["Timer"].ToString());
            Session["Timer"] = cronometro.Text;
        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            MicroondasController micro = new MicroondasController();
            cronometro.Text = micro.configuraCronometro("4", Session["Timer"].ToString());
            Session["Timer"] = cronometro.Text;
        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            MicroondasController micro = new MicroondasController();
            cronometro.Text = micro.configuraCronometro("5", Session["Timer"].ToString());
            Session["Timer"] = cronometro.Text;
        }

        protected void btn6_Click(object sender, EventArgs e)
        {
            MicroondasController micro = new MicroondasController();
            cronometro.Text = micro.configuraCronometro("6", Session["Timer"].ToString());
            Session["Timer"] = cronometro.Text;
        }

        protected void btn7_Click(object sender, EventArgs e)
        {
            MicroondasController micro = new MicroondasController();
            cronometro.Text = micro.configuraCronometro("7", Session["Timer"].ToString());
            Session["Timer"] = cronometro.Text;
        }

        protected void btn8_Click(object sender, EventArgs e)
        {
            MicroondasController micro = new MicroondasController();
            cronometro.Text = micro.configuraCronometro("8", Session["Timer"].ToString());
            Session["Timer"] = cronometro.Text;
        }

        protected void btn9_Click(object sender, EventArgs e)
        {
            MicroondasController micro = new MicroondasController();
            cronometro.Text = micro.configuraCronometro("9", Session["Timer"].ToString());
            Session["Timer"] = cronometro.Text;
        }

        protected void btn0_Click(object sender, EventArgs e)
        {
            MicroondasController micro = new MicroondasController();
            cronometro.Text = micro.configuraCronometro("0", Session["Timer"].ToString());
            Session["Timer"] = cronometro.Text;
        }

        protected void btnPotencia_Click(object sender, EventArgs e)
        {
            MicroondasController micro = new MicroondasController();
            lblPotencia.Text = micro.aumentaPotencia(Convert.ToInt16(lblPotencia.Text)).ToString();
        }

        protected void btnPeixe_Click(object sender, EventArgs e)
        {
            MicroondasController micro = new MicroondasController();
            cronometro.Text = "00:03";
            Session["Timer"] = cronometro.Text;
            Session["Alimento"] = "Peixe";
        }

        protected void btnFrango_Click(object sender, EventArgs e)
        {
            MicroondasController micro = new MicroondasController();
            cronometro.Text = "00:05";
            Session["Timer"] = cronometro.Text;
            Session["Alimento"] = "Frango";
        }

        protected void btnPipoca_Click(object sender, EventArgs e)
        {
            MicroondasController micro = new MicroondasController();
            cronometro.Text = "00:07";
            Session["Timer"] = cronometro.Text;
            Session["Alimento"] = "Pipoca";
        }

        protected void btnCarne_Click(object sender, EventArgs e)
        {
            MicroondasController micro = new MicroondasController();
            cronometro.Text = "00:09";
            Session["Timer"] = cronometro.Text;
            Session["Alimento"] = "Carne";
        }

        protected void btnSopa_Click(object sender, EventArgs e)
        {
            MicroondasController micro = new MicroondasController();
            cronometro.Text = "00:06";
            Session["Timer"] = cronometro.Text;
            Session["Alimento"] = "Sopa";
        }
    }
}