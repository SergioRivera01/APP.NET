using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void equiposBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.equiposBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laLigaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'laLigaDataSet.Jugador' Puede moverla o quitarla según sea necesario.
            this.jugadorTableAdapter.Fill(this.laLigaDataSet.Jugador);
            // TODO: esta línea de código carga datos en la tabla 'laLigaDataSet.Estadios' Puede moverla o quitarla según sea necesario.
            this.estadiosTableAdapter.Fill(this.laLigaDataSet.Estadios);
            // TODO: esta línea de código carga datos en la tabla 'laLigaDataSet.Equipos' Puede moverla o quitarla según sea necesario.
            this.equiposTableAdapter.Fill(this.laLigaDataSet.Equipos);

        }

        private void estadiosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            string messageGuardar = "Se ha guardado correctamente";
            MessageBox.Show(messageGuardar);
            this.Validate();
            this.equiposBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laLigaDataSet);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Has elegido eliminar un equipo. ¿Estas seguro?";
            string caption = "Has eliminado el equipo...";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(this, message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                try
                {
                    this.equiposTableAdapter.Delete(Convert.ToInt32(this.id_EquipoTextBox.Text),
                        this.nombre_EquipoTextBox.Text,
                        Convert.ToInt32(this.año_CreacionTextBox.Text),
                        this.ciudadTextBox.Text,
                        this.comunidadTextBox.Text,
                        Convert.ToDecimal(this.presupuestoTextBox.Text)
                        );

                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                this.equiposTableAdapter.Fill(this.laLigaDataSet.Equipos);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
