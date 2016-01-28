using ChatSystem.Data.Repository;
using Error_Handler_Control;
using ExamSkeleton.Data;
using ExamSkeleton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamSkeleton
{
    public partial class _Default : Page
    {
        //IRepository<User> users = new EfGenericRepository<User>(new ExamSkeletonDbContext());

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            ErrorSuccessNotifier.AddSuccessMessage("Bravo");
        }
    }
}