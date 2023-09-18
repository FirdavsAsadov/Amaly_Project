using Amaly_Project.Models;

namespace Amaly_Project.Service.Interfeys
{
    public interface IUserService
    {
        public void Add(User user);
        public void Remove(int id);
        public void Update(User user);
        public User GetById(int id);
        
    }
}
