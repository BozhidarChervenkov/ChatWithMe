namespace ChatWithMe.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static GlobalConstants.GlobalConstants;
    
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(PostTextContentMinLength)]
        [MaxLength(PostTextContentMaxLength)]
        public string TextContent { get; set; }

        [Required]
        public string PostedByUserId { get; set; }

        public ApplicationUser PostedByUser { get; set; }

        public string PostImage { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsDeleted { get; set; }
    }
}
