namespace BlogEngineMVC.Modules.Posts.DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class be_PostCategory
    {
        [Key]
        public int PostCategoryID { get; set; }

        public Guid BlogID { get; set; }

        public Guid PostID { get; set; }

        public Guid CategoryID { get; set; }
    }
}
