using Northwind.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employees.WebForms
{
    public partial class _Default : Page
    {
        NorthwindEntities northwind = new NorthwindEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Employee> EmplaoyeesGridView_GetData()
        {
            return this.northwind.Employees;
        }

        protected void EmplaoyeesGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var employee = EmplaoyeesGridView.SelectedRow;
            Response.Redirect("/employees/details?id=" + EmplaoyeesGridView.SelectedDataKey.Value);

        }
    }
}