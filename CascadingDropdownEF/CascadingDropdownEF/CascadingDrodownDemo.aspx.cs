using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CascadingDropdownEF.Models;

namespace CascadingDropdownEF
{
    public partial class CascadingDrodownDemo : System.Web.UI.Page
    {
        private readonly StudentContext _studentContext;

        public CascadingDrodownDemo()
        {
            _studentContext = new StudentContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}