using System;
using System.Linq;
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
            if (!Page.IsPostBack)
            {
                BindStandards();
                BindStudents();
            }
           
        }

        private void BindStudents(int? standardId=null)
        {
            ddlStudent.Items.Clear();
            if (standardId != null)
            {
                var students = from student in _studentContext.Students
                    where student.StandardId == standardId.Value
                    select new
                    {
                        StudentId = student.StudentId,
                        Name = student.FirstName + " " + student.LastName
                    };

                ddlStudent.DataSource = students.ToList();
                ddlStudent.DataTextField = "Name";
                ddlStudent.DataValueField = "StudentId";
                ddlStudent.DataBind();
            }

            ddlStudent.Items.Insert(0,"--Select Student--");
        }

        private void BindStandards()
        {
            ddlStudent.Items.Clear();
            var standards = _studentContext.Standards.ToList();
            ddlStandard.DataSource = standards;
            ddlStandard.DataTextField = "Name";
            ddlStandard.DataValueField = "StandardId";
            ddlStandard.DataBind();

            ddlStandard.Items.Insert(0,"--Select Standard--");
        }

        protected void ddlStandard_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            BindStudents(Convert.ToInt32(ddlStandard.SelectedValue));
        }
    }
}