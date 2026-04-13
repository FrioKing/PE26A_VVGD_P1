using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE26A_VVGD_P1
{

    public partial class DlgMesaPrácticas1 : Form
    {

        //Atributos globales para la clase DlgMesaPrácticas1

        //RA = Renglon actual
        int RA;

        //Constructor
        public DlgMesaPrácticas1()
        {
            InitializeComponent();
            RA = 0;
        }
        //---------------------------------------------------------------------------------------------------------------------
        //----------------------------------------Region Practica 1------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------
        #region

        //Genera Matriz para ejercicios de llenado de matrices
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
            DgvMatriz1.Columns.Clear();
            DgvMatriz1.Rows.Clear();
            RA = 0;
            
            //Generar columnas Incrementa y decrementa
            for (int i = 0; i < Tamaño; i++)
            {
                DgvMatriz1.Columns.Add("Col" + i.ToString(), "HC" + i.ToString());
                if (i < (Tamaño / 2))
                {
                    DgvMatriz1.Columns[i].Width = (i * 1) + AnchoConstante;

                }
                else
                {
                    DgvMatriz1.Columns[i].Width = (Tamaño - i) + AnchoConstante;
                }


            }

            //Genera Filas
            for (int r = 0; r < Tamaño; r++) {
                DgvMatriz1.Rows.Add();
            }
            //Final de la funcion de LA PRIMERA practica
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

        //Funciones de botones para mostrar y ocultar paneles de prácticas
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
                PnlPracticaGrados.Visible = false;
            }
        }

        //Boton para mostrar panel 2 y ocultar los demás paneles
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
                PnlPracticaGrados.Visible = false;
            }
        }

        //Boton para mostrar panel 3 y ocultar los demás paneles
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
                PnlPracticaGrados.Visible = false;
            }
        }

        //Boton para mostrar panel 4 y ocultar los demás paneles
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
                PnlPracticaGrados.Visible = false;
            }
        }

        //Funcion de grados , para mostrar el panel de practica de clima, y ocultar los demás paneles
        private void BtnPracticaClima_Click(object sender, EventArgs e)
        {
            if (PnlPracticaGrados.Visible)
            {
                PnlPracticaGrados.Visible = false;
            }
            else
            {
                PnlPracticaGrados.Visible = true;
                PnlPracticas1.Visible = false;
                PnlPracticas2.Visible = false;
                PnlPracticas3.Visible = false;
                PnlPracticas4.Visible = false;

            }
        }
        //Genera un llenado En l Matriz practica 1, panel 2
        private void BtnPractica1P2_Click(object sender, EventArgs e)
        {
            for (int r = 0; r < DgvMatriz1.Rows.Count; r++)
            {
                for (int c = 0; c < DgvMatriz1.Columns.Count; c++)
                {
                    //Pinta la celda dependiendo de su posición, y asigna el valor del ancho de la columna a cada celda
                    DgvMatriz1.Rows[r].Cells[c].Value = DgvMatriz1.Columns[c].Width;

                    if (c < (DgvMatriz1.Columns.Count / 2))
                    {

                        DgvMatriz1.Rows[r].Cells[c].Style.BackColor = Color.FromArgb(c, 127 + (c * 8), 127 + (c * 8));
                    }
                    else
                    {
                        DgvMatriz1.Rows[r].Cells[c].Style.BackColor = Color.FromArgb(255 - ((c - 15) * 8), 255 - ((c - 15) * 8), 255 - ((c - 15) * 8));
                    }

                }
            }
        }

        //Boton para generar la practica 3, de la primera practica
        private void BtnPractica1P3_Click(object sender, EventArgs e)
        {
            int r = 0;
            Random Random;
            int ValorRandom;
            Random = new Random();
            while (r < DgvMatriz1.RowCount)
            {
                int c = 0;
                while (c < DgvMatriz1.ColumnCount)
                {
                    ValorRandom = Random.Next(0, 10);

                    DgvMatriz1.Rows[r].Cells[c].Value = ValorRandom;

                    if (ValorRandom == 9)
                    {
                        DgvMatriz1.Rows[r].Cells[c].Style.BackColor = Color.Red;
                    }

                    c++;

                }
                r++;

            }
        }
        #endregion
        //---------------------------------------------------------------------------------------------------------------------
        //----------------------------------------Region Practica 2------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------
        #region

        //Boton para generar la practica 2, de la primera practica
        private void BtnPractica2P1_Click_1(object sender, EventArgs e)
        {
            int Columnas;
            int Renglones;
            int AnchoConstante;
            int AlturaConstante;

            //Verificadores de txbox para la practica 2
            //Verifica el Numero de columnas en campo 1
            if (!EsNumero(TbxCaptura1.Text))
            {
                MessageBox.Show("Capture el Numero de columnas de la matriz de la matriz");
                TbxCaptura1.Focus();
                return;
            }
            Columnas = Convert.ToInt32(TbxCaptura1.Text);

            //Verifica el Numero de renglones  en campo 2
            if (!EsNumero(TbxCaptura2.Text))
            {
                MessageBox.Show("Capture el Numero de renglones de la matriz");
                TbxCaptura2.Focus();
                return;
            }

            //Verifica el ancho constante de las columnas en campo 3
            Renglones = Convert.ToInt32(TbxCaptura2.Text);
            if (!EsNumero(TbxCaptura3.Text))
            {
                MessageBox.Show("Capture el Ancho de las columnas matriz");
                TbxCaptura3.Focus();
                return;
            }
            AnchoConstante = Convert.ToInt32(TbxCaptura3.Text);

            //  Verifica el alto constante de las filas en campo 4
            if (!EsNumero(TbxCaptura4.Text))
            {
                MessageBox.Show("Capture el ancho de la matriz");
                TbxCaptura4.Focus();
                return;
            }
            AlturaConstante = Convert.ToInt32(TbxCaptura4.Text);

            //Genera Columnas de practica 2 en forma de cilindro 
            for (int i = 0; i < Renglones; i++)
            {
                DgvMatriz2.Columns.Add("Col" + i.ToString(), "HC" + i.ToString());
                if (i < (Renglones / 2))
                {
                    DgvMatriz2.Columns[i].Width = (i * 1) + AnchoConstante;

                }
                else
                {
                    DgvMatriz2.Columns[i].Width = (i - i) + AnchoConstante;
                }
            }
        }

        private void BtnPractica2P1_Click(object sender, EventArgs e)
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
            DgvMatriz2.Columns.Clear();
            DgvMatriz2.Rows.Clear();
            RA = 0;

            //Genera Columnas de practica 2
            for (int i = 0; i < Columnas; i++)
            {
                DgvMatriz2.Columns.Add("Col" + i.ToString(), "HC" + i.ToString());
                DgvMatriz2.Columns[i].Width = AnchoConstante;
                if (CbxCilindro.Checked)
                {
                    if (i < (Columnas / 2))
                    {
                        DgvMatriz2.Columns[i].Width = (i * 1) + AnchoConstante;

                    }
                    else
                    {
                        DgvMatriz2.Columns[i].Width = (Columnas - i) + AnchoConstante;
                    }
                }
                else
                {
                    DgvMatriz2.Columns[i].Width = AnchoConstante;
                }

            }
            for (int r = 0; r < Renglones; r++)
            {
                DgvMatriz2.Rows.Add();
                DgvMatriz2.Rows[r].Height = AlturaConstante;
            }
        }

        //Colorea la matriz Practica2, panel 2
        private void BtnPractica2P2_Click(object sender, EventArgs e)
        {
            for (int r = 0; r < DgvMatriz2.Rows.Count; r++)
            {
                for (int c = 0; c < DgvMatriz2.Columns.Count; c++)
                {
                    int rojo = ((r * c) * 1000) % 256;
                    int verde = ((r + c * 500) % 256);
                    int azul = ((r * 5 + c * 3) % 200) % 256;
                    DgvMatriz2.Rows[r].Cells[c].Style.BackColor =
                        Color.FromArgb(rojo, verde, azul);
                    DgvMatriz2.Rows[r].Cells[c].Value = rojo + "," + verde + "," + azul;


                }
            }
            //Hacer que se coloren las celdas en todos los colores posibles
        }

        //Genera números randoms, y los colorea dependiendo si son pares o impares, y muestra la sumatoria de cada uno
        private void BtnPractica3P2_Click(object sender, EventArgs e)
        {
            int ContadorImpares;
            int ContadorPares;
            int SumaPares = 0;
            int SumaImpares = 0;
            ContadorPares = 0;
            ContadorImpares = 0;
            int ValorRandom;
            RA = 0;
            Random Random;
            Random = new Random();

            for (int r = 0; r < DgvMatriz2.Rows.Count; r++)
            {
                for (int c = 0; c < DgvMatriz2.Columns.Count; c++)
                {
                    ValorRandom = Random.Next(0, 11);

                    if (ValorRandom % 2 == 0)
                    {

                        // Pares
                        DgvMatriz2.Rows[r].Cells[c].Style.BackColor = Color.BlueViolet;
                        TBXCantidadPares.Text = ContadorPares++.ToString();
                        SumaPares += ValorRandom;
                    }
                    else
                    {

                        // impares
                        DgvMatriz2.Rows[r].Cells[c].Style.BackColor = Color.BlanchedAlmond;
                        TBXCantidadImpares.Text = ContadorImpares++.ToString();
                        SumaImpares += ValorRandom;
                    }

                    // Asignar el valor a la celda
                    DgvMatriz2.Rows[r].Cells[c].Value = ValorRandom;
                }
            }

            // Mostrar los resultados de las sumatorias
            SumatoriaPares.Text = SumaPares.ToString();
            SumatoriaImpares.Text = SumaImpares.ToString();
        }

        //Ordena los digitos de mayor a menor en cada renglon
        private void BtnPractica4P2_Click(object sender, EventArgs e)
        {

            //Saca el valor de numeros de columnas para el ciclo for, y lo asigna a la variable tamaño
            int Tamaño;
            if (!EsNumero(TbxCaptura1.Text))
            {
                MessageBox.Show("Capture el tamaño de la matriz");
                TbxCaptura1.Focus();
                return;
            }
            Tamaño = Convert.ToInt32(TbxCaptura1.Text);

            //Ciclo para ordenar los numeros de cada renglon de mayor a menor, y pintarlos de verde
            for (int x = 0; x < Tamaño; x++)
            {
                for (int c = 0; c < DgvMatriz2.Columns.Count - 1; c++)
                {
                    int Valor1;
                    int Valor2;
                    Valor1 = Convert.ToInt32(DgvMatriz2.Rows[RA].Cells[c].Value);
                    Valor2 = Convert.ToInt32(DgvMatriz2.Rows[RA].Cells[c + 1].Value);
                    if (Valor2 > Valor1)
                    {
                        DgvMatriz2.Rows[RA].Cells[c].Value = Valor2;
                        DgvMatriz2.Rows[RA].Cells[c + 1].Value = Valor1;
                    }

                }

                for (int c = 0; c < DgvMatriz2.Columns.Count; c++)
                {
                    DgvMatriz2.Rows[RA].Cells[c].Style.BackColor = Color.Green;
          
                }
            }
            RA++;
            if (RA == DgvMatriz2.Rows.Count - 1)
            {
                RA = 0;
            }
        }

        //Practica 2 Boton 5
        private void BtnPractica5P2_Click(object sender, EventArgs e)
        {
            int Tamaño;
            if (!EsNumero(TbxCaptura1.Text))
            {

                MessageBox.Show("Capture el tamaño de la matriz");
                TbxCaptura1.Focus();
                return;
            }
            Tamaño = Convert.ToInt32(TbxCaptura1.Text);
            for (int i=0;i<=Tamaño;i++)
            {
                BtnPractica4P2_Click(sender, EventArgs.Empty);
            }
        }
        #endregion
        //---------------------------------------------------------------------------------------------------------------------
        //----------------------------------------Region Practica 3------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------
        #region
        //Genera Matriz
        private void Btn1Panel3P1_Click(object sender, EventArgs e)
        {

            //Limpia columnas
            DgvMatriz3.Columns.Clear();
            DgvMatriz3.Rows.Clear();

            //Genera columnas
            for (int i = 0; i < 7; i++)
            {
                DgvMatriz3.Columns.Add("Dia " + (i + 1).ToString(), "Dia " + (i + 1).ToString());
                DgvMatriz3.Columns[i].Width = 50;
            }

            //Crea y nombra columnas nuevas.
            DgvMatriz3.Columns.Add("Promedio", "Promedio");
            DgvMatriz3.Columns.Add("#Bajas", "#Bajas");
            DgvMatriz3.Columns.Add("#Medias", "#Medias");
            DgvMatriz3.Columns.Add("#Altas", "#Altas");

            //Genera filas
            for (int r = 0; r < 5; r++)
            {
                DgvMatriz3.Rows.Add();
                DgvMatriz3.Rows[r].Height = 30;

                //Nombra cada laborarorio.
                DgvMatriz3.Rows[r].HeaderCell.Value = "Laboratorio " + (r + 1);
                DgvMatriz3.RowHeadersWidth = 120;
            }
        }

        //Genera números randoms
        private void Btn2Panel3P1_Click(object sender, EventArgs e)
        {
            int r = 0, c, ValorRandom;
            Random Random = new Random();

            //Limpia las celdas
            for (int i = 0; i < 5; i++)
            {
                DgvMatriz3.Rows[i].Cells["#Altas"].Style.BackColor = Color.White;
                DgvMatriz3.Rows[i].Cells["#Medias"].Style.BackColor = Color.White;
                DgvMatriz3.Rows[i].Cells["#Bajas"].Style.BackColor = Color.White;
                DgvMatriz3.Rows[i].Cells["Promedio"].Value = "";
                DgvMatriz3.Rows[i].Cells["#Bajas"].Value = "";
                DgvMatriz3.Rows[i].Cells["#Medias"].Value = "";
                DgvMatriz3.Rows[i].Cells["#Altas"].Value = "";
            }
            while (r < 5)
            {
                c = 0;
                while (c < 7)
                {
                    ValorRandom = Random.Next(0, 41);

                    DgvMatriz3.Rows[r].Cells[c].Value = ValorRandom;

                    DgvMatriz3.Rows[r].Cells[c].Style.BackColor = Color.White;
                    c++;
                }
                r++;
            }
        }

        // Promedio
        private void Btn3Panel3P1_Click(object sender, EventArgs e)
        {
            double Promedio = 0, Resultado;
            int Valor;

            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c <= 6; c++)
                {
                    Valor = Convert.ToInt32(DgvMatriz3.Rows[r].Cells[c].Value);
                    Promedio += Valor;
                }
                Resultado = Promedio / 7;

                //Muestra en el promedio deseado
                DgvMatriz3.Rows[r].Cells["Promedio"].Value = Resultado.ToString();

                Promedio = 0;
            }
        }
        //da el numero de temperaturas altas y las pinta de rojo
        private void Btn4Panel3P1_Click(object sender, EventArgs e)
        {
            int Altas = 0, Valor;

            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c <= 6; c++)
                {
                    Valor = Convert.ToInt32(DgvMatriz3.Rows[r].Cells[c].Value);
                    if (Valor > 25)
                    {
                        DgvMatriz3.Rows[r].Cells[c].Style.BackColor = Color.Red;
                        Altas++;
                    }
                }
                DgvMatriz3.Rows[r].Cells["#Altas"].Value = Altas.ToString();

                Altas = 0;
            }
        }
        //Determina que laboratorio tuvo la mayor de temperaturas altas
        private void Btn5Panel3P1_Click(object sender, EventArgs e)
        {
            int MasAltas = 0, Valor;

            for (int r = 0; r < 5; r++)
            {
                Valor = Convert.ToInt32(DgvMatriz3.Rows[r].Cells["#Altas"].Value);

                if (MasAltas < Valor)
                {
                    MasAltas = Valor;
                }
            }
            for (int r = 0; r < 5; r++)
            {
                Valor = Convert.ToInt32(DgvMatriz3.Rows[r].Cells["#Altas"].Value);
                if (Valor == MasAltas)
                {
                    DgvMatriz3.Rows[r].Cells["#Altas"].Style.BackColor = Color.Maroon;
                }
            }

        }

        // Muestra cuantas temperaturas altas bajas y medias tuvo cada laboratorio
        private void Btn6Panel3P1_Click(object sender, EventArgs e)
        {
            int Altas = 0, Medias = 0, Bajas = 0, Valor;

           //Recorre la matriz
            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c <= 6; c++)
                {
                    //Asigna el valor de cada celda a la variable Valor
                    Valor = Convert.ToInt32(DgvMatriz3.Rows[r].Cells[c].Value);

                    //Determina si el valor es bajo, medio o alto, y los cuenta y los pinta dependiendo de su valor
                    if (Valor <= 18)
                    {
                        DgvMatriz3.Rows[r].Cells[c].Style.BackColor = Color.Green;
                        Bajas++;
                    }
                    else if (Valor > 18 && Valor <= 25)
                    {
                        DgvMatriz3.Rows[r].Cells[c].Style.BackColor = Color.Yellow;
                        Medias++;
                    }
                    else
                    {
                        DgvMatriz3.Rows[r].Cells[c].Style.BackColor = Color.Red;
                        Altas++;
                    }
                }

                //Muestra el numero de temperaturas bajas, medias y altas en su debida celda
                DgvMatriz3.Rows[r].Cells["#Bajas"].Value = Bajas.ToString();
                DgvMatriz3.Rows[r].Cells["#Medias"].Value = Medias.ToString();
                DgvMatriz3.Rows[r].Cells["#Altas"].Value = Altas.ToString();

                Bajas = 0; Medias = 0; Altas = 0;
            }

            //Pinta las celdas de bajas, medias y altas cuando Ya se completo la tabla de conteo de cada una
            for (int r = 0; r < 5; r++)
            {
                DgvMatriz3.Rows[r].Cells["#Bajas"].Style.BackColor = Color.Green;
                DgvMatriz3.Rows[r].Cells["#Medias"].Style.BackColor = Color.Yellow;
                DgvMatriz3.Rows[r].Cells["#Altas"].Style.BackColor = Color.Red;
            }
        }

        #endregion


        //------------------------------------------------------------------------
        //Convierte grados centigrados a farenheit
        //------------------------------------------------------------------------
        private double ConvertirGradosCAF(double centigrados)
        {
            double fahrenheit = (centigrados * 1.8) + 32;
            return fahrenheit;
        }

        //------------------------------------------------------------------------
        //convierte grados farenheit a centigrados
        //------------------------------------------------------------------------
        private double ConvertirGradosFAC(double farenheit)
        {
            double centigrados = (farenheit - 32) / 1.8;
            return centigrados;
        }

        //-----------------------------------------------------------Manejo de Funciones------------------------------------------------
        //------------------------------------------------------------------------
        //Boton Convertir Farenheit a Celcius --- Numeros
        //------------------------------------------------------------------------
        private void BtnFAC_Click_2(object sender, EventArgs e)
        {
            double resultado;
            resultado = ConvertirGradosFAC(Convert.ToDouble(IngresarValorF.Text));
            ResultadoFarenheitAC.Text = resultado.ToString();
        }

        //------------------------------------------------------------------------
        //Boton Convertir Centigrados a Farenheit --- Numeros
        //------------------------------------------------------------------------
        private void BtnCAF_Click(object sender, EventArgs e)
        {
            double Resultado;
            Resultado = ConvertirGradosCAF(Convert.ToDouble(IngresarValorC.Text));
            ResultadoCelciusAF.Text = Resultado.ToString();
        }
        private void BtnFAC_Click(object sender, EventArgs e)
        {
            double resultado;
            resultado = ConvertirGradosFAC(Convert.ToDouble(IngresarValorF.Text));
            ResultadoFarenheitAC.Text = resultado.ToString();
        }
    }
}

    