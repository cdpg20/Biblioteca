using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ListaLibros : System.Web.UI.Page
    {

        private Sistema_de_biblioteca.Biblioteca biblioteca;
        protected void Page_Load(object sender, EventArgs e)
        {
            biblioteca =(Sistema_de_biblioteca.Biblioteca) Session["biblioteca"];
            if (tblListaLibros != null)
            {

                
                foreach (var libro in biblioteca.ObtenerListaLibros())
                {
                    TableRow row = new TableRow();
                    row.Cells.Add(new TableCell() { Text = libro.ObtenerNombre() });
                    row.Cells.Add(new TableCell() { Text = libro.Autor });
                    row.Cells.Add(new TableCell() { Text = libro.ObtenerCantidad().ToString() });
                    row.Cells.Add(new TableCell() { Text = libro.CodigoLibro });
                    row.Cells.Add(new TableCell() { Text = libro.Editorial });
                    tblListaLibros.Rows.Add(row);
                }
                
            }

        }
    }
}