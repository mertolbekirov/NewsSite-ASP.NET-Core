using System.ComponentModel.DataAnnotations;

namespace NewsSite.Data.Models
{
    public class Post
    {
        public string VideoUrl { get; set; }

        public byte[] InPostImageData { get; set; }

        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        public string Language { get; set; }
    }
}
