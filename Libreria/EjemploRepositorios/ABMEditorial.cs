using CDatos.Repositories.Contracts;
using CLogica.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentacion
{
    public partial class ABMEditorial : Form
    {
        private IEditorialLogic _editorialLogic;
        public ABMEditorial(IEditorialLogic editorialLogic)
        {
            _editorialLogic = editorialLogic;
            InitializeComponent();
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text.Trim();
            string contacto = txt_contacto.Text.Trim();
            string direccion = txt_direccion.Text.Trim();
            try
            {
                _editorialLogic.AltaEditorial(nombre, contacto, direccion);
                MessageBox.Show("El autor se ha registrado con éxito.");
                txt_contacto.Clear();
                txt_direccion.Clear();
                txt_nombre.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
