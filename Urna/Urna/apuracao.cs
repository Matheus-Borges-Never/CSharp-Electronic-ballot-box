using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urna
{
    public partial class apuracao : Form
    {
        public apuracao()
        {
            InitializeComponent();
        }

        private void apuracao_Load(object sender, EventArgs e)
        {
            listarImagem();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mostrar();
        }

        private void listarImagem()
        {
            string c = Urna.candidatos.imagens;
            ptbCaramelo.Image = Image.FromFile(c + "caramelo.jpg");
            ptbDogecoin.Image = Image.FromFile(c + "cao_dogecoin.jpg");
            ptbNeguinha.Image = Image.FromFile(c + "cao_neguinha.jpg");
            ptbPinscherBranco.Image = Image.FromFile(c + "cao_pinscher_branco.jpg");
            ptbPinscherNeguinha.Image = Image.FromFile(c + "cao_pinscher_neguinho.jpg");
        }

        private void mostrar()
        {
            double votos = 0,totalvotos=0, resultado = 0;
            if (Urna.candidatos.totalVotos > 0)
            {
                totalvotos = Urna.candidatos.totalVotos;
                votos = Urna.candidatos.vCaramelo;
                resultado = votos / totalvotos * 100;
                lblTotalVotos.Text += "" + Urna.candidatos.totalVotos;
                lblCaramelo.Text = "" + Urna.candidatos.vCaramelo + " / " +
                    resultado.ToString() + "%";

                totalvotos = Urna.candidatos.totalVotos;
                votos = Urna.candidatos.vDogecoin;
                resultado = votos / totalvotos * 100;
                lblTotalVotos.Text += "" + Urna.candidatos.totalVotos;
                lblDogecoin.Text = "" + Urna.candidatos.vDogecoin + " / " +
                    resultado.ToString() + "%";

                totalvotos = Urna.candidatos.totalVotos;
                votos = Urna.candidatos.vNeguinha;
                resultado = votos / totalvotos * 100;
                lblTotalVotos.Text += "" + Urna.candidatos.totalVotos;
                lblNeguinha.Text = "" + Urna.candidatos.vNeguinha + " / " +
                    resultado.ToString() + "%";

                totalvotos = Urna.candidatos.totalVotos;
                votos = Urna.candidatos.vPinscherBranco;
                resultado = votos / totalvotos * 100;
                lblTotalVotos.Text += "" + Urna.candidatos.totalVotos;
                lblPinscherBranco.Text = "" + Urna.candidatos.vPinscherBranco + " / " +
                    resultado.ToString() + "%";

                totalvotos = Urna.candidatos.totalVotos;
                votos = Urna.candidatos.vPinscherNeguinha;
                resultado = votos / totalvotos * 100;
                lblTotalVotos.Text += "" + Urna.candidatos.totalVotos;
                lblPinscherNeguinha.Text = "" + Urna.candidatos.vPinscherNeguinha + " / " +
                    resultado.ToString() + "%";

                totalvotos = Urna.candidatos.totalVotos;
                votos = Urna.candidatos.vBranco;
                resultado = votos / totalvotos * 100;
                lblBranco.Text = Urna.candidatos.vBranco.ToString();
                lblBranco.Text = "" + Urna.candidatos.vBranco + " / " +
                    resultado.ToString() + "%";

                totalvotos = Urna.candidatos.totalVotos;
                votos = Urna.candidatos.vNulo;
                resultado = votos / totalvotos * 100;
                lblNulo.Text = Urna.candidatos.vNulo.ToString();
                lblNulo.Text = "" + Urna.candidatos.vNulo + " / " +
                    resultado.ToString() + "%";

            }
            lblTotalVotos.Text = "Total de Votos: " + Urna.candidatos.totalVotos;


        }

        private double calculaPorc(int votos, int totalVotos)
        {
            return votos / totalVotos * 100;

        }

        private void lblTotalVotos_Click(object sender, EventArgs e)
        {

        }

        private void lblBranco_Click(object sender, EventArgs e)
        {

        }
    }
}
