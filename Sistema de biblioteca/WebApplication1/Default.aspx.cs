using Sistema_de_biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        private Biblioteca biblioteca;
        protected void Page_Load(object sender, EventArgs e)
        {
            biblioteca = new Biblioteca();
        }
    }
}