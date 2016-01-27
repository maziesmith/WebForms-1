using Northwind.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employees.WebForms.employees
{
    public partial class listview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Northwind.Data.Employee> EmployeesListview_GetData()
        {
            return new NorthwindEntities().Employees;
        }

        protected void EmployeesListview_SelectedIndexChanging(object sender, ListViewSelectEventArgs e)
        {
            this.EmployeesListview.SelectedIndex = e.NewSelectedIndex;
        }
    }
}