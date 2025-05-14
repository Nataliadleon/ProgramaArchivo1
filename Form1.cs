using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14deMay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            StreamWriter Archivo;
            string cajaTexto = txtCaja1.Text;
            string caja2Texto = txtCaja2.Text;
            string caja3Texto = txtCaja3.Text;
            Archivo = File.CreateText("FicheroFinal.txt");
            Archivo.WriteLine(cajaTexto);
            Archivo.WriteLine(caja2Texto);
            Archivo.WriteLine(caja3Texto);
            Archivo.Close();
        }
    }
}
