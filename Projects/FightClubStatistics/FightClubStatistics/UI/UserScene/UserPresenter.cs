using FightClubStatistics.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubStatistics.UI.UserScene
{
    class UserPresenter
    {
        private IUserUserControl view;
        private List<User> usersList;
        private IUserRepository usersRepository;
        private int showingCount;

        public UserPresenter(IUserUserControl ctrl)
        {
            view = ctrl;
            usersRepository = new UserRepository(new MyContext());
            usersList = new List<User>();
            usersList = usersRepository.GetAll().ToList();
            showingCount = usersList.Count;

            view.DrawUsersTable(usersList);
        }

        public void TurnEditUserControl(int id)
        {
            view.SwitchScene(Scene.EditUserScene, usersRepository.Get(id));
        }

        public void EditUser(User user)
        {
            usersRepository.Update(user);
            UpdateUsersList();
        }

        public void DeleteUser(int id)
        {
            usersRepository.Delete(id);
            UpdateUsersList();
        }

        public void TurnAddUserControl()
        {
            view.SwitchScene(Scene.EditUserScene);
        }

        public void AddUser(User newUser)
        {
            usersRepository.Add(newUser);
            UpdateUsersList();
        }
        
        private void UpdateUsersList()
        {
            usersList = usersRepository.GetAll().ToList();
            view.DrawUsersTable(usersList);
        }

        public void ChangeUsersShowingCount(int count)
        {
            showingCount = count;
            if (showingCount <= usersRepository.GetAll().Count())
            {
                view.DrawUsersTable(usersList.Take(showingCount).ToList());
            }
            else
            {
                
            }
        }

        public void ShowAllUsers()
        {
            UpdateUsersList();
        }

        public void ShowUsersWithValidEmails()
        {
            usersList = usersRepository.GetAllWithValidEmail().ToList();
            view.DrawUsersTable(usersList);
        }

        public void ShowUsersWithoutValidEmails()
        {
            usersList = usersRepository.GetAllWithoutValidEmail().ToList();
            view.DrawUsersTable(usersList);
        }
    }
}
