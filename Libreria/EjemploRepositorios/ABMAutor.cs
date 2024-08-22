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
            if (tabControlPrincipal.SelectedIndex == 0)
            {
                CargarListadoAutores();
            }
        }

        private void CargarListadoAutores()
        {
            List<dynamic> autors = _autorLogic.ObtenerAutoresParaListado();
            dgvListadoAutores.DataSource = autors;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
