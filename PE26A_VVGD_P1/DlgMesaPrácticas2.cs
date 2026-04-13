using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE26A_VVGD_P1
{
    public partial class DlgMesaPrácticas2 : Form
    {
        public DlgMesaPrácticas2()
        {
            InitializeComponent();
        }

        private void DlgMesaPrácticas1_Load(object sender, EventArgs e)
        {

        }
        //Elementos de la interfaz gráfica que no se utilizan en esta práctica, pero que se han dejado para futuras prácticas----------------
        private void PnlSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnPractica1P1_Click(object sender, EventArgs e)
        {

        }
        //------------------------------------------------------------------------
        //Funciones de botones para mostrar y ocultar paneles de prácticas--------
        private void BtnPráctica1_Click(object sender, EventArgs e)
        {
            if (PnlPracticas1.Visible)
            {
                PnlPracticas1.Visible = false;
            }
            else
            {
                PnlPracticas1.Visible = true;
                PnlPracticas2.Visible = false;
                PnlPracticas3.Visible = false;
                PnlPracticas4.Visible = false;
            }
        }

        private void BtnPractica2_Click(object sender, EventArgs e)
        {
            if (PnlPracticas2.Visible)
            {
                PnlPracticas2.Visible = false;
            }
            else
            {
                PnlPracticas2.Visible = true;
                PnlPracticas1.Visible = false;
                PnlPracticas3.Visible = false;
                PnlPracticas4.Visible = false;
            }
        }

        private void BtnPractica3_Click(object sender, EventArgs e)
        {
            if (PnlPracticas3.Visible)
            {
                PnlPracticas3.Visible = false;
            }
            else
            {
                PnlPracticas3.Visible = true;
                PnlPracticas1.Visible = false;
                PnlPracticas2.Visible = false;
                PnlPracticas4.Visible = false;
            }
        }

        private void BtnPractica4_Click(object sender, EventArgs e)
        {
            if (PnlPracticas4.Visible)
            {
                PnlPracticas4.Visible = false;
            }
            else
            {
                PnlPracticas4.Visible = true;
                PnlPracticas1.Visible = false;
                PnlPracticas2.Visible = false;
                PnlPracticas3.Visible = false;

            }
        }







        //Fin de funciones de botones para mostrar y ocultar paneles de practicas-
        //------------------------------------------------------------------------
    }
}
