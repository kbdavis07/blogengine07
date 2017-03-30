namespace BlogEngineMVC.Modules.Posts.DAL.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PostContext : DbContext
    {
        public PostContext()
            : base("name=Post")
        {
        }

        public virtual DbSet<be_Categories> be_Categories { get; set; }
        public virtual DbSet<be_PostCategory> be_PostCategory { get; set; }
        public virtual DbSet<be_PostComment> be_PostComment { get; set; }
        public virtual DbSet<be_PostNotify> be_PostNotify { get; set; }
        public virtual DbSet<be_Post> be_Posts { get; set; }
        public virtual DbSet<be_PostTag> be_PostTag { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
