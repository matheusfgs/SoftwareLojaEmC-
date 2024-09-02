using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista03exepag
{
    public partial class FrmLista3atv : Form
    {
        public FrmLista3atv()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //Pegar os dados da tela
            float preco1 = float.Parse(txtPreco1.Text);
            float preco2 = float.Parse(txtPreco2.Text);
            float preco3 = float.Parse(txtPreco3.Text);
            float ValorCompra;


            //Calcular o valor da compra

            ValorCompra = preco1 + preco2 + preco3;

            //Mostrar Resultados na label

            lblres1.Text = (ValorCompra/1).ToString("C");
            lblres2.Text = (ValorCompra/2).ToString("C");
            lblres3.Text = (ValorCompra/3).ToString("C");
            lblres4.Text = (ValorCompra/4).ToString("C");
            lblres5.Text = (ValorCompra/5).ToString("C");   

        }
    }
}
