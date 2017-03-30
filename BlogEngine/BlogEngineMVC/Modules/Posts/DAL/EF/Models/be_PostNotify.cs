namespace BlogEngineMVC.Modules.Posts.DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class be_PostNotify
    {
        [Key]
        public int PostNotifyID { get; set; }

        public Guid BlogID { get; set; }

        public Guid PostID { get; set; }

        [StringLength(255)]
        public string NotifyAddress { get; set; }
    }
}
