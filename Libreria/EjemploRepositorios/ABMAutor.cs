using CEntidades.Entidades;
using CLogica.Contracts;

namespace CPresentacion
{
    public partial class ABMAutor : Form
    {

        private IAutorLogic _autorLogic;

        public ABMAutor(IAutorLogic autorLogic)
        {
            _autorLogic = autorLogic;
            InitializeComponent();
        }

        private void tabControlPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlPrincipal.SelectedIndex == 0)
            {
                CargarListadoAutores();
            }
        }

        private void ABMAutor_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
        }

        private void CargarListadoAutores()
        {
            List<dynamic> autors = _autorLogic.ObtenerAutoresParaListado();
            dgvListadoAutores.DataSource = autors;
        }

        private void ConfigureDataGridView()
        {
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "btnEliminarColumna";
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Text = "Eliminar";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dgvListadoAutores.Columns.Add(deleteButtonColumn);
            CargarListadoAutores();
            deleteButtonColumn.DisplayIndex = dgvListadoAutores.Columns.Count - 1;

            dgvListadoAutores.CellClick += dgvListadoAutores_CellClick;
        }

        private void dgvListadoAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListadoAutores.Columns["btnEliminarColumna"].Index && e.RowIndex >= 0)
            {
                string autorId = dgvListadoAutores.Rows[e.RowIndex].Cells["IdAutor"].Value.ToString();

                _autorLogic.BajaAutor(autorId);
                CargarListadoAutores();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombreAlta.Text;
            string apellido = tbApellidoAlta.Text;
            string nacionalidad = tbNacionalidadAlta.Text;
            string email = tbEmailAlta.Text;
            string fechaNacimiento = tbFechaNacimientoAlta.Text;
            string telefono = tbTelefonoAlta.Text;
            string biografia = tbBiografiaAlta.Text;

            try
            {
                _autorLogic.AltaAutor(nombre, apellido, nacionalidad, email, fechaNacimiento, telefono, biografia);
                MessageBox.Show("El autor se ha registrado con éxito.");

                tbNombreAlta.Clear();
                tbApellidoAlta.Clear();
                tbNacionalidadAlta.Clear();
                tbEmailAlta.Clear();
                tbFechaNacimientoAlta.Clear();
                tbTelefonoAlta.Clear();
                tbBiografiaAlta.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string idAutor = tbIdAutorModificacion.Text;
            string nombre = tbNombreModificacion.Text;
            string apellido = tbApellidoModificacion.Text;
            string nacionalidad = tbNacionalidadModificacion.Text;
            string email = tbEmailModificacion.Text;
            string fechaNacimiento = tbFechaNacimientoModificacion.Text;
            string telefono = tbTelefonoModificacion.Text;
            string biografia = tbBiografiaModificacion.Text;

            try
            {
                _autorLogic.ActualizacionAutor(idAutor, nombre, apellido, nacionalidad, email, fechaNacimiento, telefono, biografia);
                MessageBox.Show("El autor se ha actualizado con éxito.");

                tbIdAutorModificacion.Clear();
                tbNombreModificacion.Clear();
                tbApellidoModificacion.Clear();
                tbNacionalidadModificacion.Clear();
                tbEmailModificacion.Clear();
                tbFechaNacimientoModificacion.Clear();
                tbTelefonoModificacion.Clear();
                tbBiografiaModificacion.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bnRecargarAlta_Click(object sender, EventArgs e)
        {
            CargarListadoAutores();
        }
    }
}
