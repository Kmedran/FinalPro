using FinalPro.Datos;
using FinalPro.Datos.Parametros;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace FinalPro
{
    public partial class Form1 : Form
    {

        private ConetMysql ConetMysql;

        Usuario sr = new Usuario();
        private Usuario Usuario;
        private string connectionString;
        




            public Form1()
        {
            InitializeComponent();
            Usuario = new Usuario();
            ConetMysql = new ConetMysql();



        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btg_Click(object sender, EventArgs e)
        {
            int idTarget = (int)numericUpDownActualizar.Value;

            // Encuentra la fila con el ID correspondiente al valor del NumericUpDown
            DataGridViewRow selectedRow = null;
            foreach (DataGridViewRow row in dataGridViewConetMysql.Rows)
            {
                if (Convert.ToInt32(row.Cells["ID"].Value) == idTarget)
                {
                    selectedRow = row;
                    break;
                }
            }

            if (selectedRow != null)
            {
                Usuario.nombrep  = textBoxNP.Text;
                Usuario.animep = textBoxAP.Text;
                Usuario.fechae = dateTimePicker.Value;
                Usuario.cantidade = textBoxCE.Text;
                Usuario.cantidadt = textBoxCT.Text;
                Usuario.emision = checkBox1.Checked;
                Usuario.finalizado = checkBox2.Checked;

                // Validar los datos antes de la actualización
                DialogResult result = MessageBox.Show("¿Está seguro de que desea actualizar este registro?", "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int resultado = ConetMysql.ActualizarPersonaje(idTarget, Usuario.nombrep, Usuario.animep, Usuario.fechae, Usuario.cantidade, Usuario.cantidadt, Usuario.emision, Usuario.finalizado);

                        if (resultado > 0)
                        {
                            MessageBox.Show("El personaje se actualizo correctamente.");
                            // Recargar los datos en el DataGridView
                            RecargarDatosDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el personaje.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar el registro: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se encontró un personaje con el ID proporcionado.");
            }
        }

        private void RecargarDatosDataGridView()
        {
            dataGridViewConetMysql.DataSource = ConetMysql.LeerConetMysql();
            dataGridViewConetMysql.Refresh();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bta_Click(object sender, EventArgs e)
        {
            if (ConetMysql.ProbarConexion())
            { MessageBox.Show("Si se pudo 👌❤️"); }
            else
            {
                MessageBox.Show("Nel Pastel 😢🥲😓");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario.nombrep = textBoxNP.Text;
            Usuario.animep = textBoxAP.Text;
            Usuario.fechae = dateTimePicker.Value;
            Usuario.cantidade = textBoxCE.Text;
            Usuario.cantidadt = textBoxCT.Text;
            Usuario.emision = checkBox1.Checked;
            Usuario.finalizado = checkBox2.Checked;
            MessageBox.Show("La Información Se a Guardado Correctamente");

            int respuesta = ConetMysql.AñadirPersonaje(Usuario.nombrep, Usuario.animep, Usuario.fechae, Usuario.cantidade, Usuario.cantidadt, Usuario.emision, Usuario.finalizado);

            if (respuesta > 0)
            {
                limpiarTextBox();
                MessageBox.Show("Se añadio correctemente");
                dataGridViewConetMysql.DataSource = ConetMysql.LeerConetMysql();
            }
            else
            {
                MessageBox.Show("Hubo un error al añadir el personaje");
            }
        }
        private void limpiarTextBox()
        {
            textBoxNP.Text = "";
            textBoxAP.Text = "";
            textBoxCE.Text = "";
            textBoxCT.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            dateTimePicker.Value = DateTime.Now;
        }

        private void buttoncargar_Click(object sender, EventArgs e)
        {
            dataGridViewConetMysql.DataSource = ConetMysql.LeerConetMysql();
        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            int ID = (int)numericUpDownEliminar.Value;

            int respuesta = ConetMysql.EliminarPersonaje(ID);

            if (respuesta > 0)
            {
                limpiarTextBox();
                MessageBox.Show("Se elimino correctemente");
                dataGridViewConetMysql.DataSource = ConetMysql.LeerConetMysql();
            }
            else
            {
                MessageBox.Show("Se elimino el personaje pero debe cargar otravez la pagina");
            }
        }

        private void numericUpDownActualizar_ValueChanged(object sender, EventArgs e)
        {
            int idTarget = (int)numericUpDownActualizar.Value;

            // Encuentra la fila con el ID correspondiente al valor del NumericUpDown
            DataGridViewRow selectedRow = null;
            foreach (DataGridViewRow row in dataGridViewConetMysql.Rows)
            {
                if (Convert.ToInt32(row.Cells["ID"].Value) == idTarget)
                {
                    selectedRow = row;
                    break;
                }
            }

            if (selectedRow != null)
            {
                // Actualiza los TextBox y otros controles con los valores de la fila seleccionada
                textBoxNP.Text = selectedRow.Cells["nombrep"].Value?.ToString() ?? string.Empty;
                textBoxAP.Text = selectedRow.Cells["animep"].Value?.ToString() ?? string.Empty;
                textBoxCE.Text = selectedRow.Cells["cantidade"].Value?.ToString() ?? string.Empty;
                textBoxCT.Text = selectedRow.Cells["cantidadt"].Value?.ToString() ?? string.Empty;
                dateTimePicker.Value = selectedRow.Cells["fechae"].Value != null ? Convert.ToDateTime(selectedRow.Cells["fechae"].Value) : DateTime.MinValue;
                
            }
            else
            {
                // Si no se encuentra la fila, limpia los TextBox y otros controles
                textBoxNP.Text = string.Empty;
                textBoxAP.Text = string.Empty;
                textBoxCE.Text = string.Empty;
                textBoxCT.Text = string.Empty;
                dateTimePicker.Value = DateTime.Now;
                



            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

