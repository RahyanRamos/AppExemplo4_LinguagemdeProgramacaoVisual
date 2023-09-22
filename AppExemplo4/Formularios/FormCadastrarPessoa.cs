using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;

namespace AppExemplo4.Formularios
{
    public partial class FormCadastrarPessoa : Form
    {
        public FormCadastrarPessoa()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            var pasta = new XLWorkbook("C:\\registros\\cadastro.xlsx");
            var planilha = pasta.Worksheet(1);
            var linhas = planilha.RowsUsed();
            int linhaRegistro = linhas.Count() + 1;

            planilha.Cell(linhaRegistro, 1).Value = linhaRegistro - 1;
            planilha.Cell(linhaRegistro, 2).Value = txtNome.Text;
            planilha.Cell(linhaRegistro, 3).Value = txtCpf.Text;
            planilha.Cell(linhaRegistro, 4).Value = txtEmail.Text;
            planilha.Cell(linhaRegistro, 5).Value = dtpNascimento.Value;

            pasta.Save();
            MessageBox.Show("REGISTRO SALVO!");

            txtCpf.Clear();
            txtEmail.Clear();
            txtNome.Clear();
            dtpNascimento.Value = DateTime.Today;
            txtNome.Focus();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtCpf.Clear();
            txtEmail.Clear();
            txtNome.Clear();
            dtpNascimento.Value = DateTime.Today;
            txtNome.Focus();
        }
    }
}
