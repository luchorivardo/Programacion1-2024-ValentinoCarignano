using CEntidades.Entidades;
using CLogica.Contracts;

namespace EjemploRepositorios
{
    public partial class Form1 : Form
    {
        private IPersonaLogic _exampleLogic;

        public Form1(IPersonaLogic exampleLogic)
        {
            _exampleLogic = exampleLogic;
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            List<Libro> examples = await _exampleLogic.GetAll();
        }
    }
}
