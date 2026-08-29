using EF.Core.Repository.Interface.Manager;
using DotNetApiDemo.Models;

namespace DotNetApiDemo.Interfaces.Manager
{
    public interface IPostManager:ICommonManager<Post>
    {
        Post GetById(int id);
    }
}
