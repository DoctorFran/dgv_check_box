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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            gdvDados.DataSource = fonteDadosDataTable();
        }
        /// <summary>
        /// Cria um DataTable para vincular no DataGridView
        /// </summary>
        /// <returns>DataTabe</returns>
        private DataTable fonteDadosDataTable()
        {
            DataTable dt = new DataTable("macorattiDataTable");

            //Cria colunas no DataTable;

            //cria a coluna id e inclua no datatable
            DataColumn id = new DataColumn("id");
            dt.Columns.Add(id); 
            //cria a coluna nome e inclui no datatable
            DataColumn nome = new DataColumn("nome");
            dt.Columns.Add(nome); //LastName column created and add to DataTable

            //Inclui alguns dados no DataTable
            DataRow dr;
            for (int contador = 0; contador <= 9; contador++)
            {
                dr = dt.NewRow();
                dr["id"] = contador;
                dr["nome"] = "Macoratti " + contador;
                dt.Rows.Add(dr);
            }

            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in gdvDados.Rows)
            {
                //valos exibir a linha da [0](Cells[0]) pois ela representa a coluna checkbox 
                //que foi selecionada
                if (dr.Cells[0].Value != null) 
                {
                    MessageBox.Show("Linha " + dr.Index + " foi selecionada");
                }
            }
        }
    }
}
