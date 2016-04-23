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
            BindStandards();
            BindStudents();
        }

        private void BindStudents(int? standardId=null)
        {
            ListItem studentDefaultItem = new ListItem {Text = "--Select Student--"};


            if (standardId != null)
            {
                
            }
        }

        private void BindStandards()
        {
            var standards = _studentContext.Standards.ToList();
            ddlStandard.DataSource = standards;
            ddlStandard.DataTextField = "Name";
            ddlStandard.DataValueField = "StandardId";
            ddlStandard.DataBind();
        }
    }
}