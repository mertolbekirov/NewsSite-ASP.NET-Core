using System.ComponentModel.DataAnnotations;

namespace NewsSite.Models.Posts
{
    public class PostFormModel
    {
        public string VideoUrl { get; set; }

        public byte[] InPostImageData { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string Language { get; set; }
    }
}
