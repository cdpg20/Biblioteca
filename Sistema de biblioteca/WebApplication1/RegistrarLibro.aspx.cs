using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class RegistarLibro : System.Web.UI.Page
    {

        private Sistema_de_biblioteca.Biblioteca biblioteca;
        //protected TextBox txtNombreLibro;
        //protected Label lblNombreLibro;
        protected void Page_Load(object sender, EventArgs e)
        {
            biblioteca = new Sistema_de_biblioteca.Biblioteca();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            
            biblioteca.AgregarLibro(new Sistema_de_biblioteca.Libro(txtTituloLibro.Text, txtAuthor.Text, txtEditorial.Text, int.Parse(txtCopias.Text), DateTime.Now, txtCodigoLibro.Text));
            Session["biblioteca"] = biblioteca;
        }
    }
}