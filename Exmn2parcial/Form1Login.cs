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
    public partial class Form1Login : Form
    {
        public Form1Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (txt_usuario.Text == "jromelio")
            //{
            //    errorProvider1.SetError(txt_usuario, "USUARIO INCONRRECTO");
            //    txt_usuario.Focus();
            //    return;

            //}
            //errorProvider1.SetError(txt_usuario, "");

            //if (txt_contra.Text == "1999Yasmin")
            //{
            //    errorProvider1.SetError(txt_contra, "CONTRACEÑA INCONRRECTO");
            //    txt_contra.Focus();
            //    return;
            //}
            //errorProvider1.SetError(txt_contra, "");


            if (txt_usuario.Text != "jromelio")
            {
                errorProvider1.SetError(txt_usuario, "USUARIO INCONRRECTO");
                txt_usuario.Focus();
                return;

            }
            errorProvider1.SetError(txt_usuario, "");

            if (txt_contra.Text != "1999Yasmin")
            {
                errorProvider1.SetError(txt_contra, "CONTRACEÑA INCONRRECTO");
                txt_contra.Focus();
                return;
            }
            errorProvider1.SetError(txt_contra, "");

            Principal formulario = new Principal();
            this.Hide();
            formulario.Show();


           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
