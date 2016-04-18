using FightClubStatistics.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubStatistics
{
    class UserRepository : AbstractRepository, IRepository<User> , IUserRepository
    {
        public UserRepository(MyContext context)
        {
            this.context = context;
        }

        public void Add(User item)
        {
            context.Users.Add(item);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            User user = context.Users.Find(id);
            if (user != null)
            {
                context.Users.Remove(user);
            }
            context.SaveChanges();
        }

        public User Get(int id)
        {
            return context.Users.Find(id);
        }

        public IEnumerable<User> GetAll()
        {
            return context.Users;
        }

        public void Update(User item)
        {
            User oldUser;
            oldUser = context.Users.Where(x => x.UserId == item.UserId).FirstOrDefault();
            oldUser.Login = item.Login;
            oldUser.Password = item.Password;
            oldUser.EMail = item.EMail;
            oldUser.IsEmailValid = item.IsEmailValid;
            oldUser.PlayerData.Name = item.PlayerData.Name;
            oldUser.PlayerData.Exp = item.PlayerData.Exp;
            context.SaveChanges();
        }

        public IEnumerable<User> FindRegisteredUsersByDate(DateTime date)
        {
            return GetAll().Where(user => user.CreationDate == date).ToList();
        }

        public IEnumerable<User> FindUsersWithValidEMail()
        {
            return GetAll().Where(user => user.IsEmailValid).ToList();
        }

        public IEnumerable<User> GetAllWithValidEmail()
        {
            return context.Users.Where(x => x.IsEmailValid);
        }

        public IEnumerable<User> GetAllWithoutValidEmail()
        {
            return context.Users.Where(x => !x.IsEmailValid);
        }
    }
}
