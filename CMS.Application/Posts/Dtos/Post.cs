
namespace CMS.Application.Posts.Dtos
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Content { get; set; } = default!;
        public DateTime PublishDate { get; set; } = default!;
    }
}
