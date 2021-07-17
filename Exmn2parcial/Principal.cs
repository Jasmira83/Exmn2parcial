using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exmn2parcial
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            dg_datos.Columns.Add("medicamento", "Medicamento");
            dg_datos.Columns.Add("categoria", "Categoria");
            dg_datos.Columns.Add("presentacion", "Presentacion");
            dg_datos.Columns.Add("cantidad", "Cantidad");
            dg_datos.Columns.Add("precio", "Precio");

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {

            dg_datos.Rows.Add(txt_nomedicamento.Text, cbx_categoria.Text, cbx_presentacion.Text, txt_cantidada.Text, txt_precio.Text);
            txt_nomedicamento.Text = string.Empty;
            cbx_presentacion.Text = string.Empty;
            cbx_categoria.Text = string.Empty;
            txt_cantidada.Text = string.Empty;
            txt_precio.Text = string.Empty;

            total();


            bool error = false;

            foreach(char caracter in txt_cliente.Text)
            {
               if(char.IsDigit(caracter))
                {
                    error = true;
                    break;
                }
            }
            //verificar la condicion de error
            if(error)
            {
                errorProvider1.SetError(txt_cliente, "No se admiten numeros");
            }
            else
            {
                errorProvider1.Clear();
            }

           

            foreach (char caracter in txt_nomedicamento.Text)
            {
                if (char.IsDigit(caracter))
                {
                    error = true;
                    break;
                }
            }
            //verificar la condicion de error
            if (error)
            {
                errorProvider1.SetError(txt_cliente, "No se admiten numeros");
            }
            else
            {
                errorProvider1.Clear();
            }

            //.............................................................

            ////foreach (num caracter in txt_cliente.Text)
            ////{
            ////    int num;
            ////    if (!int.TryParse(txt_cantidada.Text, out num))
            ////    {
            ////        error = true;
            ////        break;
            ////    }
            ////}
            ////verificar la condicion de error
            //int num;
            //if (!int.TryParse(txt_cantidada.Text, out num))
            //{
            //    errorProvider1.SetError(txt_cantidada, "No se admiten letras");
            //}
            //else
            //{
            //    errorProvider1.Clear();
            //}

            //if (!int.TryParse(txt_precio.Text, out num))
            //{
            //    errorProvider1.SetError(txt_precio, "No se admiten letras");
            //}
            //else
            //{
            //    errorProvider1.Clear();
            //}

        }

        public void total()

        {
            Decimal total = 0;
            foreach (DataGridViewRow row in dg_datos.Rows)
            {
                total = (Convert.ToDecimal(row.Cells["Cantidad"].Value) * Convert.ToDecimal(row.Cells["Precio"].Value) + total);
            }

            txt_total.Text = total.ToString();
        }



        private void btn_cancelar_Click(object sender, EventArgs e)
        {


            dg_datos.Rows.Clear();

            txt_direccioncliente.Text = "";
            txt_cliente.Text = string.Empty;
            txt_nomedicamento.Text = "";
            cbx_presentacion.Text = "";
            cbx_categoria.Text = "";
            txt_cantidada.Text = string.Empty;
            txt_precio.Text = string.Empty;
            txt_total.Text = "";
        }

    

        private void txt_Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro(a) que desea Cerrar del sistema?",
         "Consulta",
         MessageBoxButtons.YesNo,
          MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txt_nomedicamento_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
