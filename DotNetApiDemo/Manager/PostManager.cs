using DotNetApiDemo.Context;
using DotNetApiDemo.Interfaces.Manager;
using DotNetApiDemo.Models;
using DotNetApiDemo.Repository;
using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Manager;

namespace DotNetApiDemo.Manager
{
    public class PostManager : CommonManager<Post>,IPostManager
    {
        public PostManager(ApplicationDbContext _dbContext) : base(new PostRepository(_dbContext))
        {

        }

        public Post GetById(int id)
        {
            return GetFirstOrDefault(x=> x.Id == id);
        }
    }
}
