using Northwind.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employees.WebForms.employees
{
    public partial class details : System.Web.UI.Page
    {
        private Employee employee;
        private string backUrl;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.backUrl = Request.UrlReferrer.AbsolutePath;
            var idAsString = Request.QueryString["id"];
            if (idAsString == null) Response.Redirect("/");

            var id = int.Parse(idAsString);
            this.employee = new NorthwindEntities().Employees
                .FirstOrDefault(empl => empl.EmployeeID == id);
        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public object EmployeeDetailsView_GetItem()
        {
            return this.employee;
        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            Response.Redirect(backUrl);
        }
    }
}