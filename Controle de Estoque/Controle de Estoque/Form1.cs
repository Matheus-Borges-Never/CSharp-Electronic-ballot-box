using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Controle_de_Estoque
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str = "";
            str = "Data source = 10.64.45.32, 1433; Initial Catalog = TI41; User Id = aluno; Password = 123456";
            con = new SqlConnection(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                MessageBox.Show("A conexão com o banco está aberta.");
            }
            else if (con.State == ConnectionState.Closed)
            {
                MessageBox.Show("A conexão com o banco está fechada.");
            }
            else
            {
                MessageBox.Show("A conexão com o banco pode estar corrompida.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                SqlCommand cm;
                string sql = "";
                sql = "insert into cadastro_matheus (produto,estoque,vlr_unit) values (@PRODUTO,@ESTOQUE,@VLR_UNIT)";
                cm = new SqlCommand(sql, con);

                cm.Parameters.Add("@PRODUTO", SqlDbType.VarChar).Value = txtProduto.Text;
                cm.Parameters.Add("@ESTOQUE", SqlDbType.VarChar).Value = nmrEstoque.Text;
                cm.Parameters.Add("@VLR_UNIT", SqlDbType.Char).Value = mtbValor.Text;

                int ret = cm.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("O Produto foi inserido com sucesso!");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlCommand cm;
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable tb = new DataTable();
            string sql = "select * from estoque_matheus";
            cm = new SqlCommand(sql, con);
            da.SelectCommand = cm;
            da.Fill(tb);
            dtgCliente.DataSource = null;
            dtgCliente.DataSource = tb;
        }

        private void dtgCliente_Click(object sender, EventArgs e)
        {
            if (dtgCliente.Rows.Count > 0)
            {
                lblId.Text = dtgCliente.CurrentRow.Cells[0].Value.ToString();
                txtProduto.Text = dtgCliente.CurrentRow.Cells[1].Value.ToString();
                nmrEstoque.Text = dtgCliente.CurrentRow.Cells[2].Value.ToString();
                mtbValor.Text = dtgCliente.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                SqlCommand cm;
                string sql = "";
                sql = "update estoque_matheus set PRODUTO=@PRODUTO, ESTOQUE=@ESTOQUE, VLR_UNIT=@VLR_UNIT where id=@ID ";
                cm = new SqlCommand(sql, con);

                cm.Parameters.Add("@PRODUTO", SqlDbType.VarChar).Value = txtProduto.Text;
                cm.Parameters.Add("@ESTOQUE", SqlDbType.BigInt).Value = nmrEstoque.Text;
                cm.Parameters.Add("@VLR_UNIT", SqlDbType.Decimal).Value = mtbValor.Text;
                cm.Parameters.Add("@ID", SqlDbType.BigInt).Value = lblId.Text;

                int ret = cm.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("O Produto foi alterado com sucesso!");
                }
            }
        }

        private void dtgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
