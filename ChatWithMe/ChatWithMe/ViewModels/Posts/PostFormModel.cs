namespace ChatWithMe.ViewModels.Posts
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Http;

    using static GlobalConstants.GlobalConstants;

    public class PostFormModel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Post Content")]
        [MinLength(PostTextContentMinLength)]
        [MaxLength(PostTextContentMaxLength)]
        public string TextContent { get; set; }

        public string PostedByUserId { get; set; }

        public IFormFile PostImage { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsDeleted { get; set; }       
    }
}
