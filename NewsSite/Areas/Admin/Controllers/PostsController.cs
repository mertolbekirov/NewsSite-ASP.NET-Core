using NewsSite.Data;

namespace NewsSite.Areas.Admin.Controllers
{
    public class PostsController : AdminController
    {
        private readonly NewsSiteDbContext data;

        public PostsController(NewsSiteDbContext data)
        {
            this.data = data;
        }

        public void Post(string content, string videoUrl, string language)
        {
            var post = new Data.Models.Post
            {
                Content = content,
                VideoUrl = videoUrl,
                Language = language
            };

            foreach (var file in Request.Form.Files)
            {
                MemoryStream ms = new MemoryStream();
                file.CopyTo(ms);
                post.InPostImageData = ms.ToArray();

                ms.Close();
                ms.Dispose();
            }

            data.Posts.Add(post);
            data.SaveChanges();
        }
    }
}
