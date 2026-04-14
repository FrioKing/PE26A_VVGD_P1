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


        //------------------------------------------------------------------------
        //--------Funciones de botones para mostrar y ocultar paneles de prácticas
        //------------------------------------------------------------------------
        #region
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
        #endregion
        //---------------------------------------------------------------------------------------------
        //----------------------------- Region, Boton 1 Practica 2-------------------------------------
        //---------------------------------------------------------------------------------------------
        #region
        private void BtnPractica1P1_Click(object sender, EventArgs e)
        {
            int Tamaño;
            int AnchoConstante;

            //Verifica el tamaño de la matriz en campo 1
            if (!EsNumero(TbxCaptura1.Text))
            {
                MessageBox.Show("Capture el tamaño de la matriz");
                TbxCaptura1.Focus();
                return;
            }
            Tamaño = Convert.ToInt32(TbxCaptura1.Text);

            //Verifica el ancho constante de las columnas en campo 2
            if (!EsNumero(TbxCaptura2.Text))
            {
                MessageBox.Show("Capture el  de la matriz");
                TbxCaptura2.Focus();
                return;
            }
            AnchoConstante = Convert.ToInt32(TbxCaptura2.Text);

            //Limpiar Columnas y filas anteriores
            DgvMatriz3.Columns.Clear();
            DgvMatriz3.Rows.Clear();

            //Generar columnas 
            for (int i = 0; i < Tamaño; i++)
            {
                DgvMatriz3.Columns.Add("Col" + i.ToString(), "HC" + i.ToString());
            }

            //Genera Filas
            for (int r = 0; r < Tamaño; r++)
            {
                DgvMatriz3.Rows.Add();
            }
        }

        //Determina si la cadena es un valor numerico
        //Aqui se Creo la funcion EsNumero
        bool EsNumero(string valor)
        {
            int Numero;
            bool Resultado;
            Resultado = int.TryParse(valor, out Numero);
            return Resultado;
        }

        #endregion
        //---------------------------------------------------------------------------------------------
        //----------------------------- Region, Boton 2 Practica 2-------------------------------------
        //---------------------------------------------------------------------------------------------
        #region
        //Funcion de la segunda practica, llena la matriz con numeros aleatorios y resalta los 9 en rojo
        private void Btn2Practica2P1_Click(object sender, EventArgs e)
        {
            int r = 0;
            Random Random;
            int ValorRandom;
            Random = new Random();
            while (r < DgvMatriz3.RowCount)
            {
                int c = 0;
                while (c < DgvMatriz3.ColumnCount)
                {
                    ValorRandom = Random.Next(0, 10);

                    DgvMatriz3.Rows[r].Cells[c].Value = ValorRandom;

                    if (ValorRandom == 9)
                    {
                        DgvMatriz3.Rows[r].Cells[c].Style.BackColor = Color.Red;
                    }

                    c++;

                }
                r++;

            }
        }
        #endregion
        //---------------------------------------------------------------------------------------------
        //----------------------------- Region, Boton 3 Practica 2-------------------------------------
        //---------------------------------------------------------------------------------------------
        #region
        //Dibuja lineas sobre la tabla apartir de un patron
        private void Btn3Practica2P1_Click(object sender, EventArgs e)
        {
            object ValorCelda;
            int numero;
            bool EsNumero;
            Point CentroCelda;
            Pen Pluma;
            Rectangle RectanguloCelda;

            //Prepara objetos de trabajo
            Pluma= new Pen(Color.Red, 1);
            CentroCelda= new Point();
        }
        #endregion

        //---------------------------
        //Funciones Vacias
        //---------------------------
        private void TbxCaptura1_TextChanged(object sender, EventArgs e)
        {

        }
    }






        //Fin de funciones de botones para mostrar y ocultar paneles de practicas-
        //------------------------------------------------------------------------
    }

