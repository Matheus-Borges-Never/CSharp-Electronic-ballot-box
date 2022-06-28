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
    public partial class Form1 : Form
    {
        string c = Urna.candidatos.imagens;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text.Length == 2)
            {

                string c = Urna.candidatos.imagens;

                if ( txtNumero.Text == "10")
                {

                    lblCandidato.Text = Urna.candidatos.caramelo;
                    ptbCandidatos.Image = Image.FromFile(c + "caramelo.jpg");
                    btnConfirmar.Enabled = true;

                }
                else if (txtNumero.Text == "20")
                {

                    lblCandidato.Text = Urna.candidatos.dogecoin;
                    ptbCandidatos.Image = Image.FromFile(c + "cao_dogecoin.jpg");
                    btnConfirmar.Enabled = true;

                }
                else if (txtNumero.Text == "30")
                {

                    lblCandidato.Text = Urna.candidatos.neguinha;
                    ptbCandidatos.Image = Image.FromFile(c + "cao_neguinha.jpg");
                    btnConfirmar.Enabled = true;

                }
                else if (txtNumero.Text == "40")
                {

                    lblCandidato.Text = Urna.candidatos.pinscherBranco;
                    ptbCandidatos.Image = Image.FromFile(c + "cao_pinscher_branco.jpg");
                    btnConfirmar.Enabled = true;

                }
                else if (txtNumero.Text == "50")
                {

                    lblCandidato.Text = Urna.candidatos.pinscherNeguinha;
                    ptbCandidatos.Image = Image.FromFile(c + "cao_pinscher_neguinho.jpg");
                    btnConfirmar.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Candidato Inválido");
                }
            }
            else if(txtNumero.Text.Length == 0)
            {
                

                lblCandidato.Text = Urna.candidatos.vote;
                ptbCandidatos.Image = Image.FromFile(c + "eleitor.png");
                btnConfirmar.Enabled = false;
            }
            else if (txtNumero.Text.Length != 2)
            {
                string c = Urna.candidatos.imagens;

                lblCandidato.Text = Urna.candidatos.vote;
                ptbCandidatos.Image = Image.FromFile(c + "eleitor.png");
                btnConfirmar.Enabled = false;
            }
            
        }


        private void txtNumero_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (btnConfirmar.Enabled == true)
                {
                    votar();
                }
                else if (btnBranco.Enabled == true)
                {
                    votar();
                }
            } 
        }

        private void votar()
        {
            string c = Urna.candidatos.imagens;

            if (txtNumero.Text == "10")
            {
                Urna.candidatos.vCaramelo++;

            }
            else if (txtNumero.Text == "20")
            {
                Urna.candidatos.vDogecoin++;

            }
            else if (txtNumero.Text == "30")
            {
                Urna.candidatos.vNeguinha++;

            }
            else if (txtNumero.Text == "40")
            {
                Urna.candidatos.vPinscherBranco++;

            }
            else if (txtNumero.Text == "50")
            {
                Urna.candidatos.vPinscherNeguinha++;

            }else if (btnBranco.Enabled == true)
            {
                Urna.candidatos.vBranco++;
            }
            Urna.candidatos.totalVotos++;
            MessageBox.Show("Votação Finalizada");
            txtNumero.Text = "";
            btnBranco.Enabled = true;
            btnNulo.Enabled = true;
            ptbCandidatos.Image = Image.FromFile(c + "eleitor.png");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            apuracao frmapuracao = new apuracao();
            frmapuracao.Show();
        }

        private void btnNulo_Click(object sender, EventArgs e)
        {
            if (btnNulo.Enabled)
            {
                lblCandidato.Text = Urna.candidatos.vote;
                ptbCandidatos.Image = Image.FromFile(c + "eleitor.png");
                btnBranco.Enabled = true;
                btnNulo.Enabled = true;
            }
            Urna.candidatos.totalVotos++;
            Urna.candidatos.vNulo++;
            MessageBox.Show("Votação Finalizada");
            txtNumero.Text = "";
            btnBranco.Enabled = true;
            btnNulo.Enabled = true;
            ptbCandidatos.Image = Image.FromFile(c + "eleitor.png");
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            if (btnBranco.Enabled)
            {
                lblCandidato.Text = Urna.candidatos.vote;
                ptbCandidatos.Image = Image.FromFile(c + "eleitor.png");
                btnBranco.Enabled = true;
                btnNulo.Enabled = true;
            }
            Urna.candidatos.totalVotos++;
            Urna.candidatos.vBranco++;
            MessageBox.Show("Votação Finalizada");
            txtNumero.Text = "";
            btnBranco.Enabled = true;
            btnNulo.Enabled = true;
            ptbCandidatos.Image = Image.FromFile(c + "eleitor.png");
        }
    }
}
