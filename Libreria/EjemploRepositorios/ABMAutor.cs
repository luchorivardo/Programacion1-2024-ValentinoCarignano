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
            string telefono = tbTelefonoAlta.Text;
            string fechaNacimiento = tbTelefonoAlta.Text;
            string biografia = tbBiografiaAlta.Text;
            try
            {
                _autorLogic.AltaAutor(nombre, apellido, nacionalidad, telefono, fechaNacimiento, biografia);
                MessageBox.Show("El autor se ha registrado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
