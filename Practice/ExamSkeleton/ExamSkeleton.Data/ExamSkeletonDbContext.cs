using ExamSkeleton.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSkeleton.Data
{
    public class ExamSkeletonDbContext : IdentityDbContext<User>
    {
        public ExamSkeletonDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        //public DbSet<Category> Categories { get; set; }

        //public DbSet<Book> Books { get; set; }

        //public DbSet<Comment> Comments { get; set; }

        //public DbSet<Author> Authors { get; set; }

        public static ExamSkeletonDbContext Create()
        {
            return new ExamSkeletonDbContext();
        }
    }
}
