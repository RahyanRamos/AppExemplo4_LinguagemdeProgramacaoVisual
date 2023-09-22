using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppExemplo4.Formularios;

namespace AppExemplo4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrarPessoas_Click(object sender, EventArgs e)
        {
            FormCadastrarPessoa form = new FormCadastrarPessoa();
            form.ShowDialog();
        }

        private void btConsultarPessoa_Click(object sender, EventArgs e)
        {
            FormConsultarPessoas form = new FormConsultarPessoas();
            form.ShowDialog();
        }
    }
}
