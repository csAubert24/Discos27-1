using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto_dominio;
using proyecto_negocio;


namespace winAppDiscos
{
    public partial class Catalogo : Form
    {
        private List<Discos> listaPokemos;
        public Catalogo()
        {
            InitializeComponent();
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            DiscosNegocio negocio = new DiscosNegocio();
            listaPokemos = negocio.listar(); ;
            dgvDiscos.DataSource = listaPokemos;
              
            cargarImagen(listaPokemos[0].url);
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Discos seleccionado = (Discos) dgvDiscos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.url);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbDiscos.Load(imagen);
            }
            catch (Exception ex)
            {

                pbDiscos.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png");
            }
            
        }
    }
}
