using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PessoaTI20N
{
    public partial class Excluir : Form
    {

        DAO bd;
        public Excluir()
        {
            InitializeComponent();
            bd = new DAO();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim do campo cpf

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                long cpf = Convert.ToInt64(textBox1.Text);//coletando cpf

                //chamar metodo
                MessageBox.Show(bd.Excluir(cpf, "pessoa"));
                textBox1.Text = "";
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Algo deu errado!!\n\n" + ex);
            }
        }//fim do excluir

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do cancelar
    }//fim da classe
}//fim do projeto
