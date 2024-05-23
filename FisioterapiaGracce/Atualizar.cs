using PessoaTI20N;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FisioterapiaGracce
{
    public partial class Atualizar : Form
    {

        DAO bd;
        public Atualizar()
        {
            InitializeComponent();
            bd = new DAO();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//fim do campo cpf

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//fim do dados

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                long cpf = Convert.ToInt64(textBox3.Text);
                string campo = textBox1.Text;
                string dado = textBox2.Text;
                //atualizar dados
                MessageBox.Show(bd.Atualizar(cpf, "pessoa", campo, dado));
                //limpar campos
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado!!\n\n" + ex);
            }

        }//fim do atulizar

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }//fim do cancelar

        private void Atualizar_Load(object sender, EventArgs e)
        {

        }
    }//fim do projeto
}//fim da classe

