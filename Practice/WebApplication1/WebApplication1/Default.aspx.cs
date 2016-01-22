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
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }

        protected void gridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridView1.PageIndex = e.NewPageIndex;
            gridView1.DataBind();
        }

        private void BindData()
        {
            var items = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                items.Add(i + 1);
            }

            gridView1.DataSource = items;
            gridView1.DataBind();
        }
    }
}