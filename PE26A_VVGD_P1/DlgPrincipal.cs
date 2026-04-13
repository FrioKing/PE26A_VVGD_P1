using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Libreria para reproducir musica de fondo
using WMPLib;
namespace PE26A_VVGD_P1
{
    //-------------------------------------------------------------------------
    //Programacion Estructurada 26A
    //-------------------------------------------------------------------------
    //Dialogo del menu principal
    //VVGD. 04/02/2026
    //_------------------------------------------------------------------------
    public partial class DlgPrincipal : Form
    {
        //Mueve el formulario al arrastrar el panel superior
        bool dragging = false;
        Point startPoint = new Point(0, 0);
        // ESTA ES LA LÍNEA QUE DEBES AGREGAR:
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        //------------------------------------------------------------------------
        //Constructor
        //------------------------------------------------------------------------
        public DlgPrincipal()
        {
            InitializeComponent();
            //Volumen Inicial de la musica
            player.settings.volume = 50;
        }
        
        //------------------------------------------------------------------------
        //Pregunta al usuario si desea salir del programa
        //------------------------------------------------------------------------
        private void Mundos_Click(object sender, EventArgs e)
        {
            var Resultado = DialogResult.Yes;
            //DeCLARAR VARIABLE, Inicialisamos en yes
            /*PROMPT: ChatG, Estoy desarrollando practicas de Programacion Estructurada en c# Con visual studio
            Nececito utilizar el componente MessageBox pero no muestra titulo el mensaje ni el icono del mensaje 
            con la finalidad de que la interaccio con el usuario  sea mas enriquecedora*/

            MessageBox.Show("Desea salir de este podrio","ERROR",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            
            /*DESCRIPCION: El siguiente código utiliza uno de los metodos sobrecargados de Show que
             agrega mas parametros a los normales, por ejemplo, aqui se agregaron los botonoes Si y No, 
            y agrega un icono de advertencia */

            if (Resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //-----------------------------------------------------------Manejo de Funciones------------------------------------------------

        //------------------------------------------------------------------------
        //Funcionciones de los botones de las practicas
        //------------------------------------------------------------------------

        private void BTNMesaPracticas1_Click(object sender, EventArgs e)
        {
            DlgMesaPrácticas1 DlgMesaPrácticas1;
            DlgMesaPrácticas1 = new DlgMesaPrácticas1();
            DlgMesaPrácticas1.Show();
        }
       
        private void BTNMesaPracticas2_Click(object sender, EventArgs e)
        {
            DlgMesaPrácticas2 DlgMesaPrácticas2;
            DlgMesaPrácticas2 = new DlgMesaPrácticas2();
            DlgMesaPrácticas2.Show();
        }

        private void BTNMesaPracticas3_Click(object sender, EventArgs e)
        {
            DlgMesaPrácticas3 DlgMesaPrácticas3;
            DlgMesaPrácticas3 = new DlgMesaPrácticas3();
            DlgMesaPrácticas3.Show();  
        }

        private void BTNMesaPracticas4_Click(object sender, EventArgs e)
        {
            DlgMesaPrácticas4 DlgMesaPrácticas4;    
            DlgMesaPrácticas4 = new DlgMesaPrácticas4();
            DlgMesaPrácticas4.Show();
        }

        //------------------------------------------------------------------------
        //Funciones Vacias Pero utilizables en un futuro
        //------------------------------------------------------------------------

         private void DlgPrincipal_Load(object sender, EventArgs e)
         {
            // Color Negro con 150 de opacidad (0 es invisible, 255 es sólido)
            PanelBackOpacity.BackColor = Color.FromArgb(180, 20, 20, 20);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Formato de 24 horas: HH:mm:ss
            // Formato de 12 horas: hh:mm:ss tt
            LblTimer.Text = DateTime.Now.ToString("hh:mm:ss");
            LblFecha.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy   ");
        }

        private void ResultadoCelciusAF_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResultadoFarenheitAC_TextChanged(object sender, EventArgs e)
        {

        }

        private void TituloGFarenheit_Click(object sender, EventArgs e)
        {

        }

        private void IngresarValorF_TextChanged(object sender, EventArgs e)
        {

        }

        private void IngresarValorC_TextChanged(object sender, EventArgs e)
        {

        }

        private void TituloGCentigrado_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelBackOpacity_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblTimer_Click(object sender, EventArgs e)
        {

        }
        //este boton maximiza o restaura el programa dependiendo del estado en el que se encuentre
        private void BtnPanCompleta_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        //Este boton minimiza todo el programa
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //Funciones para mover el formulario al arrastrar la barra de braveza
        private void BackGroundMusica_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void BackGroundMusica_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void BackGroundMusica_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            player.URL = @"C:\Users\TuUsuario\Music\cancion.mp3";
            player.controls.play();
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }

        private void BtnElegirCancion_Click(object sender, EventArgs e)
        {
            // 1. Creamos la ventanita
            OpenFileDialog buscarMusica = new OpenFileDialog();

            // 2. Filtramos para que solo aparezcan archivos de música
            buscarMusica.Filter = "Archivos de Audio|*.mp3;*.wav;*.wma";

            // 3. Si el usuario seleccionó un archivo y le dio a OK
            if (buscarMusica.ShowDialog() == DialogResult.OK)
            {
                // Pasamos la ruta del archivo seleccionado al reproductor
                player.URL = buscarMusica.FileName;

                // ¡Y que empiece la música!
                player.controls.play();
            }
        ShowDialog: buscarMusica.Title = "Selecciona tu música Cyberpunk";
        }



        //Ultimas dos llaves del codigo.
    }
}
