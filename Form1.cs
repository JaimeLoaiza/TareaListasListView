using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_AnimalesNocturnos
{
    public partial class Form1 : Form
    {
        List<AnimalesNocturnos> ListadeAnimales = new List<AnimalesNocturnos>();
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnlistaanimales_Click(object sender, EventArgs e)
        {
            LISTADOANIMALES.Items.Clear();
            foreach(AnimalesNocturnos animales in ListadeAnimales)
            {
                ListViewItem item = new ListViewItem();
                item = LISTADOANIMALES.Items.Add(animales.Id.ToString());
                item.SubItems.Add(animales.Nombre);
                item.SubItems.Add(animales.Tipo);
                item.SubItems.Add(animales.Especie);
            }
        }
        private void btnagregaranimal_Click(object sender, EventArgs e)
        {
            AnimalesNocturnos animales = new AnimalesNocturnos();
            animales.Id = Convert.ToInt32(txtid.Text);
            animales.Nombre = txtnombre.Text;
            animales.Tipo = txttipo.Text;
            animales.Especie = txtespecie.Text;
            ListadeAnimales.Add(animales);
            txtid.Text = String.Empty;
            txtnombre.Text = String.Empty;
            txttipo.Text = String.Empty;
            txtespecie.Text = String.Empty;
            txtid.Focus();
            MessageBox.Show("El Animal Nocturno ha sido agregado Exitosamente");
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnlimpiarlista_Click(object sender, EventArgs e)
        {
            LISTADOANIMALES.Items.Clear();
            txtid.Focus();
        }
    }
}
