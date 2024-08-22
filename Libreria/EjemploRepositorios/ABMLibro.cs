using CEntidades.Entidades;
using CLogica.Contracts;

namespace EjemploRepositorios
{
    public partial class ABMLibro : Form
    {
        private IPersonaLogic _exampleLogic;

        public ABMLibro(IPersonaLogic exampleLogic)
        {
            _exampleLogic = exampleLogic;
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            List<Persona> examples = await _exampleLogic.ObtenerPersonas();
        }
    }
}
