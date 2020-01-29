using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form

    {
        private const string V = "{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}";
        private const string Format = V;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox_Datos_Bancarios.Enabled = false;
            groupBox_Datos_Personales.Enabled = false;


        }

        private void groupBox_Datos_Personales_Enter(object sender, EventArgs e)
        {
            //  groupBox_Datos_Personales.Enabled = false;

        }

        private void button_Edicion_Click(object sender, EventArgs e)
        {
            groupBox_Datos_Personales.Enabled = true;
            groupBox_Datos_Bancarios.Enabled = true;

        }

        private void groupBox_Datos_Bancarios_Enter(object sender, EventArgs e)
        {
            // groupBox_Datos_Bancarios.Enabled = false;

        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            groupBox_Datos_Personales.Enabled = false;
            groupBox_Datos_Bancarios.Enabled = false;

            groupBox_Datos_Personales.Text = "";
            groupBox_Datos_Bancarios.Text = "";



        }
        

        private void button_Ejecutar_Click(object sender, EventArgs e)
        {
            
            

            using (StreamWriter writer = new StreamWriter("../../Archivos/ServiciosFinancieros.txt"))
            {
                writer.WriteLine(string.Format(
                    Format,
                    textBox_Nombre.Text,
                    ",",
                    textBox_Apellido.Text,
                    ",",
                    textBox_direccion.Text,
                    ",",
                    dateTimePicker_Fecha_de_Nacimiento.Text,
                    ",",
                    radioButton_Femenino.Text,
                    ",",
                    
                    radioButton_Masculino.Text,
                    ",",
                     radioButton_Otro.Text,
                    ",",
                    textBox_Cantidad.Text,
                    ",",
                    textBox_Saldo.Text,
                    ",",
                    radioButton_deposito.Text,
                    ",",
                    radioButton_Retiro.Text,
                    ",",
                    radioButton_COnsulta.Text,
                    ","


                    ));
            }

            MessageBox.Show(string.Format("REGISTRO EXTITOO"));

        }

        private void radioButton_COnsulta_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
