namespace BlogEngineMVC.Modules.Posts.DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class be_PostComment
    {
        [Key]
        public int PostCommentRowID { get; set; }

        public Guid BlogID { get; set; }

        public Guid PostCommentID { get; set; }

        public Guid PostID { get; set; }

        public Guid ParentCommentID { get; set; }

        public DateTime CommentDate { get; set; }

        [StringLength(255)]
        public string Author { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Website { get; set; }

        public string Comment { get; set; }

        [StringLength(255)]
        public string Country { get; set; }

        [StringLength(50)]
        public string Ip { get; set; }

        public bool? IsApproved { get; set; }

        [StringLength(100)]
        public string ModeratedBy { get; set; }

        [StringLength(255)]
        public string Avatar { get; set; }

        public bool IsSpam { get; set; }

        public bool IsDeleted { get; set; }
    }
}
