using CMS.Application.Posts.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CMS.API.Controllers.Posts
{
    [ApiController]
    [Route("[controller]")]

    public class PostController : ControllerBase
    {
        private readonly ILogger<PostController> _logger;

        public PostController(ILogger<PostController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public async Task<List<Post>> GetAll()
        {
            var posts = new List<Post>() 
            { 
                new Post()
                {
                    Id = 1,
                    Title = "Como crear un API REST en .NET Core",
                    Description = "Tutorial como crear api rest usando DDD",
                    Content = "test test test",
                    PublishDate = DateTime.Now,
                },
                new Post()
                {
                    Id = 2,
                    Title = "Como conectar c# con BD",
                    Description = "Tutorial omo conectar c# con BD",
                    Content = "test test test",
                    PublishDate = DateTime.Now,
                }
            };

            return await Task.FromResult(posts);
        }

        [HttpGet("ById/{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var posts = new List<Post>()
            {
                new Post()
                {
                    Id = 1,
                    Title = "Como crear un API REST en .NET Core",
                    Description = "Tutorial como crear api rest usando DDD",
                    Content = "test test test",
                    PublishDate = DateTime.Now,
                },
                new Post()
                {
                    Id = 2,
                    Title = "Como conectar c# con BD",
                    Description = "Tutorial omo conectar c# con BD",
                    Content = "test test test",
                    PublishDate = DateTime.Now,
                }
            };

            var post = posts.FirstOrDefault(x => x.Id == id);

            if (post == default!)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }

            return Ok(post);
        }

        [HttpPost()]
        public async Task<IActionResult> CreatPost([FromBody] Post input)
        {
            var posts = new List<Post>()
            {
                new Post()
                {
                    Id = 1,
                    Title = "Como crear un API REST en .NET Core",
                    Description = "Tutorial como crear api rest usando DDD",
                    Content = "test test test",
                    PublishDate = DateTime.Now,
                },
                new Post()
                {
                    Id = 2,
                    Title = "Como conectar c# con BD",
                    Description = "Tutorial omo conectar c# con BD",
                    Content = "test test test",
                    PublishDate = DateTime.Now,
                }
            };

            posts.Add(input);

            return Ok(posts);
        }

        [HttpPut()]
        public async Task<IActionResult> UpdatePost([FromBody] Post input)
        {
            var posts = new List<Post>()
            {
                new Post()
                {
                    Id = 1,
                    Title = "Como crear un API REST en .NET Core",
                    Description = "Tutorial como crear api rest usando DDD",
                    Content = "test test test",
                    PublishDate = DateTime.Now,
                },
                new Post()
                {
                    Id = 2,
                    Title = "Como conectar c# con BD",
                    Description = "Tutorial omo conectar c# con BD",
                    Content = "test test test",
                    PublishDate = DateTime.Now,
                }
            };

            posts.FirstOrDefault(x => x.Id == input.Id).Description = input.Description;

            return Ok(posts);
        }

        [HttpDelete("ById/{id}")]
        public async Task<IActionResult> CreatPost([FromRoute] int id)
        {
            var posts = new List<Post>()
            {
                new Post()
                {
                    Id = 1,
                    Title = "Como crear un API REST en .NET Core",
                    Description = "Tutorial como crear api rest usando DDD",
                    Content = "test test test",
                    PublishDate = DateTime.Now,
                },
                new Post()
                {
                    Id = 2,
                    Title = "Como conectar c# con BD",
                    Description = "Tutorial omo conectar c# con BD",
                    Content = "test test test",
                    PublishDate = DateTime.Now,
                }
            };

            var post = posts.FirstOrDefault(x => x.Id == id);
            posts.Remove(post);

            return Ok(posts);
        }
    }
}
