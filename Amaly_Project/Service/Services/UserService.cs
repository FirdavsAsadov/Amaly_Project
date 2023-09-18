using Amaly_Project.Data;
using Amaly_Project.Models;
using Amaly_Project.Service.Interfeys;

namespace Amaly_Project.Service.Services
{
    public class UserService : IUserService
    {
        private readonly EFcoreContext _eFcoreContext;
        public UserService(EFcoreContext eFcoreContext)
        {
            _eFcoreContext = eFcoreContext;
        }
        public void Add(User user)
        {
            var existingUser = _eFcoreContext.Users.FirstOrDefault(u => u.Id == user.Id);
            if (existingUser != null)
            {
                throw new ArgumentException("This user already exists!!");
            }
            _eFcoreContext.Add(user);
            _eFcoreContext.SaveChanges();
        }
        public void Remove(int id)
        {
            var removingUser = _eFcoreContext.Users.FirstOrDefault(x => x.Id == id);
            if (removingUser != null)
            {
                _eFcoreContext.Remove(removingUser);
            }
            else
            {
                throw new NotImplementedException("Not found this user");
            }
        }
        public void Update(User user)
        {
            var updatingUser = _eFcoreContext.Users.FirstOrDefault(x => x.Id == user.Id);
            if (updatingUser != null)
            {
                var newUser = new User()
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                };
                _eFcoreContext.Add(newUser);
                _eFcoreContext.SaveChanges();
            }
        }
        public User GetById(int id)
        {
            return _eFcoreContext.Users.FirstOrDefault(x => x.Id == id);
        }
    }
}
