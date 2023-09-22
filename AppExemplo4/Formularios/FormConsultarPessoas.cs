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

namespace AppExemplo4.Formularios
{
    public partial class FormConsultarPessoas : Form
    {
        public FormConsultarPessoas()
        {
            InitializeComponent();

            var pasta = new XLWorkbook("C:\\registros\\cadastro.xlsx");
            var planilha = pasta.Worksheet(1);
            var linhas = planilha.RowsUsed();

            for (int i = 2; i < linhas.Count()+1; i++)
            {
                cbNome.Items.Add(planilha.Cell(i, 2).Value);
            }
        }
    }
}
