using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ArquitecturaCapas
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        public void Cargar()
        {
            dataGridView1.DataSource = CapaModeloNegocio.People.Get();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string nombre = txtNombre.Text;

            CapaModeloNegocio.People.Insertar(id, nombre);
            Cargar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                string nombre = txtNombre.Text; 

                CapaModeloNegocio.People.Actualizar(id, nombre);
                Cargar(); 
            }
            else
            {
                MessageBox.Show("Selecciona un registro para editar.");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                CapaModeloNegocio.People.Eliminar(id);
                Cargar();
            }
            else
            {
                MessageBox.Show("Seleccione un registro para eliminar.");
            }
        }
    }
}
