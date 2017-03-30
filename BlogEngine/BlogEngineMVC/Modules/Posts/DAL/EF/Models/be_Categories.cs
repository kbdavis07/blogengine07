namespace BlogEngineMVC.Modules.Posts.DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class be_Categories
    {
        [Key]
        public int CategoryRowID { get; set; }

        public Guid BlogID { get; set; }

        public Guid CategoryID { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public Guid? ParentID { get; set; }
    }
}
