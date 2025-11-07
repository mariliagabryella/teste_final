using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inscrições
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void inscricoesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inscricoesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basedadosDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'basedadosDataSet.Inscricoes'. Você pode movê-la ou removê-la conforme necessário.
            this.inscricoesTableAdapter.Fill(this.basedadosDataSet.Inscricoes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
        }
    }
}
