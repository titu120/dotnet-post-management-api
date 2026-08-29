using DotNetApiDemo.Context;
using DotNetApiDemo.Interfaces.Manager;
using DotNetApiDemo.Manager;
using DotNetApiDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace DotNetApiDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PostController : ControllerBase
    {

        //ApplicationDbContext _dbContext;
        IPostManager _postManager;


        //public PostController(ApplicationDbContext dbContext)
        //{
        //    _dbContext = dbContext;
       
        //}

        public PostController(IPostManager postManager)
        {
           _postManager = postManager;
        }

        [HttpGet]

        public List<Post> GetAll() { 

            //var posts = _dbContext.Posts.ToList();
            var posts = _postManager.GetAll().ToList();
            return  posts;

        }

        [HttpGet]
        public Post GetById(int id)
        {
            var post = _postManager.GetById(id);
            return post;
        }


        [HttpPost]

        public Post Add(Post post)
        {
            post.CreatedDate = DateTime.Now;
            //_dbContext.Posts.Add(post);
            //bool isSaved = _dbContext.SaveChanges() > 0;

            bool isSaved = _postManager.Add(post);


            if(isSaved)
            {
                return post;
            }
            return null;
        }


    }
}
