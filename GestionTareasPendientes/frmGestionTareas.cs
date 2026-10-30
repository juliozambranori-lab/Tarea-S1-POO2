namespace GestionTareasPendientes
{
    public partial class frmGestionTareas : Form
    {
        public frmGestionTareas()
        {
            InitializeComponent();
        }

        private void frmGestionTareas_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (lstTareas.Items.Count > 0)
                {
                    lstTareas.Items.Clear();
                }
                else
                {
                    MessageBox.Show("La lista ya está vacía.",
                                    "Información",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

            }
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            if (txtTarea.Text.Trim() != "")
            {
                lstTareas.Items.Add(txtTarea.Text);
                txtTarea.Clear();
                txtTarea.Focus();
            }
            else
            {
                MessageBox.Show("Ingrese una tarea.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedIndex != -1)
            {
                lstTareas.Items.RemoveAt(lstTareas.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Seleccione una tarea para eliminar.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
    }
}
}