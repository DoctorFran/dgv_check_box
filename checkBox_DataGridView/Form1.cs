using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace checkBox_DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cria um objeto DataTable
            DataTable dt = new DataTable();
            //inclui duas colunas no datatable definindo o seu tipo como booleano e string
            dt.Columns.Add("Estado", typeof(bool));  
            dt.Columns.Add("Nome", typeof(string));
            //cria um array do tipo string com nomes
            string[] nomes = { "Macoratti", "Jefferson", "Janice", "Jessica", "Miriam" };  
            //define um array com valores booleanos
            bool[] status = { true, true, false, true, false };    
            //inclui linhas e valores no datatable
            for (int i = 0; i < 5; i++)
            {
                DataRow dr = dt.NewRow();
                dr["Estado"] = status[i];
                dr["Nome"] = nomes[i];
                dt.Rows.Add(dr);
            }
            //vincula os valores do datatable no DataGridView
            dataGridView1.DataSource = dt;  
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /// Este evento é disparado quando o usuário clica no conteúdo de uma célula
            /// Vamos exibir uma mensagem contendo os valores true ou valse refletindo os 
            /// o valores da coluna checkbox
            /// 
            //Verificamos se e somente se a celula checkbox (Estado) foi clicada
            if (e.ColumnIndex == dataGridView1.Columns["Estado"].Index)  //Checking index of checkbox column is equal to clickable cell index.
            {
                //interrompe a edição
                dataGridView1.EndEdit();  
                //exibe os valores 
                MessageBox.Show("=> " + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());  //Displaying value of that cell which is either true or false in this case.
            }
        }
    }
}
