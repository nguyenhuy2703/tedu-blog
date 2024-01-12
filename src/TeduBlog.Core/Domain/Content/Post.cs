using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TeduBlog.Core.Domain.Content
{
    [Table("Post")]
    [Index(nameof(Slug),IsUnique=true)]
    public class Post
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(250)]
        //public string Title { get; set; }
        public required string Name { get; set; }
        [Required]
        [Column(TypeName ="varchar(250)")]
        public required string Slug { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
        [Required]
        public Guid CategotyId { get; set; }
        [MaxLength(500)]
        public String? Thumbnail {  get; set; }

        public String? Content { get; set; }
        [MaxLength(500)]
        public Guid AuthorUserID {  get; set; }
        [MaxLength(128)]
        public String? Source { get; set; }
        [MaxLength(250)]
        public String? Tags { get; set;}
        [MaxLength(160)]
        public String? SeoDescription { get; set;}

        public int ViewCount { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsPaid  { get; set; }
        public double RoyaltyAmount { get; set; }
        public PostStatus Status { get; set; }
    }
    public enum PostStatus
    {
        Draft = 1,
        Canceled = 2,
        WaitingForApproval = 3,
        Rejected = 4,
        WaitingForPublish = 5,
        Published = 6,
    }
}
