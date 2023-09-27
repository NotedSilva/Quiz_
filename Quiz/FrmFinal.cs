using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class FrmFinal : Form
    {
        public FrmFinal()
        {
            InitializeComponent();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFinal_Load(object sender, EventArgs e)
        {
            labelAcertos.Text = Dados.Acertos.ToString();
            labelErros.Text = Dados.Erros.ToString();
        }
    }
}
