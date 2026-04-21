using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
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
            DgvMatriz3.CellPainting += DgvMatriz1_CellPainting;
            DgvMatriz4.CellPainting += DgvMatriz2_CellPainting;
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
        //----------------------------- Region, Boton 1 Practica 2 Panel 3-------------------------------------
        //---------------------------------------------------------------------------------------------
        #region
        private void BtnPractica1P1_Click(object sender, EventArgs e)
        {
            int Columnas;
            int Renglones;
            int AnchoConstante;
            int AlturaConstante;
            //Verifica el Numero de columnas en campo 1
            if (!EsNumero(TbxCaptura1.Text))
            {
                MessageBox.Show("Capture el Numero de columnas de la matriz de la matriz");
                TbxCaptura1.Focus();
                return;
            }

            //Verifica el ancho constante de las columnas en campo 2
            if (!EsNumero(TbxCaptura2.Text))
            {
                MessageBox.Show("Capture el Ancho de las columnas matriz");
                TbxCaptura2.Focus();
                return;
            }
            AnchoConstante = Convert.ToInt32(TbxCaptura2.Text);
            Columnas = Convert.ToInt32(TbxCaptura1.Text);

            //Verifica el Numero de renglones  en campo 3
            if (!EsNumero(TbxCaptura3.Text))
            {
                MessageBox.Show("Capture el Numero de renglones de la matriz");
                TbxCaptura3.Focus();
                return;
            }
            Renglones = Convert.ToInt32(TbxCaptura3.Text);

            //Valida el alto constante de las filas en campo 4
            if (!EsNumero(TbxCaptura4.Text))
            {
                MessageBox.Show("Capture la altura de las columnas matriz");
                TbxCaptura4.Focus();
                return;
            }
            AlturaConstante = Convert.ToInt32(TbxCaptura4.Text);

            //Limpia la matriz de practicas anteriores
            DgvMatriz3.Columns.Clear();
            DgvMatriz3.Rows.Clear();


            //Genera Columnas de practica 2
            for (int i = 0; i < Columnas; i++)
            {
                DgvMatriz3.Columns.Add("Col" + i.ToString(), "HC" + i.ToString());
                DgvMatriz3.Columns[i].Width = AnchoConstante;


            }
            for (int r = 0; r < Renglones; r++)
            {
                DgvMatriz3.Rows.Add();
                DgvMatriz3.Rows[r].Height = AlturaConstante;
            }
        }
        bool EsNumero(string valor)
        {
            int Numero;
            bool Resultado;
            Resultado = int.TryParse(valor, out Numero);
            return Resultado;
        }

        #endregion
        //---------------------------------------------------------------------------------------------
        //----------------------------- Region, Boton 2 Practica 2 Panel 3-------------------------------------
        //DgvMatriz1_CellPainting-----------------------------------------------------------------------------
        #region
        //Funcion de la segunda practica, llena la matriz con numeros aleatorios
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


                    c++;

                }
                r++;

            }
        }
        
        //Esta Funcion sirve para crear lineas de colores a cordenadas Randoms
        private void DgvMatriz1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            Object Valor;
            int Numero;
            bool EsNumero;
            Point CentroCelda;
            Point Destino;
            Pen Pluma1;
            Pen Pluma2;
            Pen Pluma3;
            Pen Pluma4;
            Pen Pluma5;
            Pen Pluma6;
            Pen Pluma7;
            Pen Pluma8;
            Pen Pluma9;
            Pen Pluma10;
            Random random;

            Rectangle RectanguloCelda;

            //Prepara objetos de trabajo
            Pluma1 = new Pen(Color.Red, 1);
            Pluma2 = new Pen(Color.Blue, 2);
            Pluma3 = new Pen(Color.BlueViolet, 3);
            Pluma4 = new Pen(Color.DimGray, 4);
            Pluma5 = new Pen(Color.Bisque, 5);
            Pluma6 = new Pen(Color.BurlyWood, 6);
            Pluma7 = new Pen(Color.Azure, 7);
            Pluma8 = new Pen(Color.Orange, 8);
            Pluma9 = new Pen(Color.BlueViolet, 9);
            Pluma10 = new Pen(Color.Black, 10);
            CentroCelda = new Point();
            Destino = new Point();
            random = new Random();
            Destino.X = random.Next(0, DgvMatriz3.Width);
            Destino.Y = random.Next(0, DgvMatriz3.Height);
            //Descartar Encabezados
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            //Pinta la celda normal
            e.Paint(e.CellBounds, DataGridViewPaintParts.All);

            //Determina el valor de la celda
            Valor = e.Value;

            //Dibuja la linea
            if(Valor != null)
            {
                EsNumero = int.TryParse(Valor.ToString(), out Numero);
                if (EsNumero)
                {
                    //Obtiene limites de ñla celda 
                    RectanguloCelda = e.CellBounds;

                    //Calculo Centro de la celda
                    CentroCelda.X = RectanguloCelda.Left + RectanguloCelda.Width / 2;
                    CentroCelda.Y = RectanguloCelda.Top + RectanguloCelda.Height / 2;

                    //Dibuja Linea de diferentes colores dependiendo del numero en la celda
                    switch (Numero){
                        case 1:
                            e.Graphics.DrawLine(Pluma1, CentroCelda.X, CentroCelda.Y, Destino.X, Destino.Y);
                            break;
                        case 2: 
                            e.Graphics.DrawLine(Pluma2, CentroCelda.X, CentroCelda.Y, Destino.X, Destino.Y); 
                            break;
                        case 3:
                            e.Graphics.DrawLine(Pluma3, CentroCelda.X, CentroCelda.Y, Destino.X, Destino.Y);
                            break;
                        case 4:
                            e.Graphics.DrawLine(Pluma4, CentroCelda.X, CentroCelda.Y, Destino.X, Destino.Y);
                            break;
                        case 5:
                            e.Graphics.DrawLine(Pluma5, CentroCelda.X, CentroCelda.Y, Destino.X, Destino.Y);
                            break;
                        case 6:
                            e.Graphics.DrawLine(Pluma6, CentroCelda.X, CentroCelda.Y, Destino.X, Destino.Y);
                            break;
                        case 7:
                            e.Graphics.DrawLine(Pluma7, CentroCelda.X, CentroCelda.Y, Destino.X, Destino.Y);
                            break;
                        case 8:
                            e.Graphics.DrawLine(Pluma8, CentroCelda.X, CentroCelda.Y, Destino.X, Destino.Y);
                            break;
                        case 9:
                            e.Graphics.DrawLine(Pluma9, CentroCelda.X, CentroCelda.Y, Destino.X, Destino.Y);
                            break;
                        case 0:
                            e.Graphics.DrawLine(Pluma10, CentroCelda.X, CentroCelda.Y, Destino.X, Destino.Y);
                            break;
                    }
                    
                }
            }
        }
        #endregion
        //---------------------------------------------------------------------------------------------
        //----------------------------- Region, Boton 1, Practica 2 Panel 4-------------------------------------
        //-------------------------------------------------------------------------------------------------
        #region
        /*Genera la matriz dependiendo De los valores Dados en el diseñador 
        y Valida los TexBox del diseñador sacando sus valores*/
        private void Btn1Panel2Practica2_Click(object sender, EventArgs e)
        {
            int Columnas;
            int Renglones;
            int AnchoConstante;
            int AlturaConstante;
            //Verifica el Numero de columnas en campo 1
            if (!EsNumero(TbxCaptura1.Text))
            {
                MessageBox.Show("Capture el Numero de columnas de la matriz de la matriz");
                TbxCaptura1.Focus();
                return;
            }

            //Verifica el ancho constante de las columnas en campo 2
            if (!EsNumero(TbxCaptura2.Text))
            {
                MessageBox.Show("Capture el Ancho de las columnas matriz");
                TbxCaptura2.Focus();
                return;
            }
            AnchoConstante = Convert.ToInt32(TbxCaptura2.Text);
            Columnas = Convert.ToInt32(TbxCaptura1.Text);

            //Verifica el Numero de renglones  en campo 3
            if (!EsNumero(TbxCaptura3.Text))
            {
                MessageBox.Show("Capture el Numero de renglones de la matriz");
                TbxCaptura3.Focus();
                return;
            }
            Renglones = Convert.ToInt32(TbxCaptura3.Text);

            //Valida el alto constante de las filas en campo 4
            if (!EsNumero(TbxCaptura4.Text))
            {
                MessageBox.Show("Capture la altura de las columnas matriz");
                TbxCaptura4.Focus();
                return;
            }
            AlturaConstante = Convert.ToInt32(TbxCaptura4.Text);

            //Limpia la matriz de practicas anteriores
            DgvMatriz4.Columns.Clear();
            DgvMatriz4.Rows.Clear();


            //Genera Columnas de practica 2
            for (int i = 0; i < Columnas; i++)
            {
                DgvMatriz4.Columns.Add("Col" + i.ToString(), "HC" + i.ToString());
                DgvMatriz4.Columns[i].Width = AnchoConstante;


            }
            for (int r = 0; r < Renglones; r++)
            {
                DgvMatriz4.Rows.Add();
                DgvMatriz4.Rows[r].Height = AlturaConstante;
            }
        }
        #endregion
        //---------------------------------------------------------------------------------------------
        //----------------------------- Region, Boton 2, Practica 2 Panel 4-------------------------------------
        //-------------------------------------------------------------------------------------------------
        #region
        //LLena la matriz con letras aleatoreas
        private void Btn2Practica2P2_Click(object sender, EventArgs e)
        {
            int r = 0;
            Random Random;
            Random = new Random();
            while (r < DgvMatriz4.RowCount)
            {
                int c = 0;
                while (c < DgvMatriz4.ColumnCount)
                {
                    DgvMatriz4.Rows[r].Cells[c].Value = (char)Random.Next('A', 'Z' + 1);
                    DgvMatriz4.Rows[r].Cells[c].Style.BackColor = Color.White;
                    c++;
                }
                r++;
            }

        }
        //Traza lineas para pintar de amarillo 
        #endregion
        //---------------------------------------------------------------------------------------------
        //----------------------------- Region, Boton 3, Practica 2 Panel 4-------------------------------------
        //DgvMatriz2_CellPainting -------------------------------------------------------------------
        #region
        private void Btn3Practica2P2_Click(object sender, EventArgs e)
        {
            string Texto;
            int r;
            int i;
            int c;
            bool PalabraTerminada = false;
            r = 0;
            i = 0;
            Texto = TbxCaptura5.Text.ToUpper();
            while (r < DgvMatriz4.RowCount)
            {
                c = 0;
                while (c < DgvMatriz4.ColumnCount-1)
                {
                    char letra;

                    letra = (char)DgvMatriz4.Rows[r].Cells[c].Value;
                    DgvMatriz4.Rows[r].Cells[c].Style.BackColor = Color.White;
                    if (!PalabraTerminada)
                    {
                        if (letra == Texto[i])
                        {
                            DgvMatriz4.Rows[r].Cells[c].Style.BackColor = Color.Yellow;
                            i++;

                            if (i == Texto.Length)
                            {
                                PalabraTerminada = true;
                            }
                        }
                    }
                    c++;
                }
                r++;
                //Pintado Realizado
            }
        }

        //Pinta cada celda de la tabla 2
        private void DgvMatriz2_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            Object Valor;
            Point CentroCelda;
            Pen Pluma1;


            Rectangle RectanguloCelda;

            //Prepara objetos de trabajo
            Pluma1 = new Pen(Color.Red, 2);

            CentroCelda = new Point();
            

            //Descartar Encabezados
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            //Pinta la celda normal
            e.Paint(e.CellBounds, DataGridViewPaintParts.All);

            //Determina el valor de la celda
            Valor = e.Value;

            
            if (e.CellStyle.BackColor == Color.Yellow)
            {
                MessageBox.Show(Valor.ToString());
            }

            //Dibuja la linea
            if (Valor != null)
            {
              

                if (e.CellStyle.BackColor == Color.Yellow)
                {

                    //Obtiene limites de la celda 
                    RectanguloCelda = e.CellBounds;

                    //Calculo Centro de la celda
                    CentroCelda.X = RectanguloCelda.Left + RectanguloCelda.Width / 2;
                    CentroCelda.Y = RectanguloCelda.Top + RectanguloCelda.Height / 2;

                    //Dibuja Linea de diferentes colores dependiendo del numero en la celda
                    e.Graphics.DrawLine(Pluma1, CentroCelda.X, CentroCelda.Y, CentroCelda.X-200, CentroCelda.Y);
   

                }
            }
            e.Handled = true;
        }
         #endregion



    }
}       