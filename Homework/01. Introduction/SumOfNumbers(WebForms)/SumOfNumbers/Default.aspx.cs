using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SumOfNumbers
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Result.Enabled = false;
        }

        private void Sum()
        {
            decimal x, y, z;

            if (!decimal.TryParse(FirstNumber.Text, out x))
            {
            }

            if (!decimal.TryParse(SecondNumber.Text, out y))
            {
            }

            z = x + y;

            Result.Text = z.ToString();
        }

        protected void Btn_Calculate_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Sum();
            }
            else
            {
                error_group.Visible = true;
            }
        }
    }
}