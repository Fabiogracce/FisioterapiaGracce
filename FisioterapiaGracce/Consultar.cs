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
    public partial class Consultar : Form
    {
        DAO bd;
        public Consultar()
        {
            InitializeComponent();
            bd = new DAO();

            ConfigurarGrid();//estruturar grid
            NomeDados();// dar nomes as colunas
            bd.PreencherVetor();// consultar bc dados
            AdcionarDados();//Inserir linhas na tela


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//fim do dateGrid

        public void NomeDados()
        {
            dataGridView1.Columns[0].Name = "CPF";
            dataGridView1.Columns[0].Name = "Nome";
            dataGridView1.Columns[0].Name = "Telefone";
            dataGridView1.Columns[0].Name = "Endereço";

        }//fim do metodo

        public void AdcionarDados()
        {
            for (int i = 0; i < bd.QuantidadeDados(); i++)

            {
                dataGridView1.Rows.Add(bd.cpf[i], bd.nome[i], bd.telefone[i], bd.endereço[i]);

            }//fim do metodo
        }
        public void ConfigurarGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//usuario nao adciona linha
            dataGridView1.AllowUserToDeleteRows = false;//usuario nao apaga linha
            dataGridView1.AllowUserToResizeColumns = false;//usuario nao adciona colunas
            dataGridView1.AllowUserToResizeRows = false;//usuario modifica linhas
            dataGridView1.ColumnCount = 4;//Quantidade de colunas

        }



    }//fim da classe
}//fim do projeto

