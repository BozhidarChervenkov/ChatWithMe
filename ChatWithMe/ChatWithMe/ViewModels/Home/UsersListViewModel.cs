namespace ChatWithMe.ViewModels.Home
{
    using System.Collections.Generic;

    public class UsersListViewModel
    {
        public UsersListViewModel()
        {
            this.UsersList = new HashSet<UserInListViewModel>();
        }

        public ICollection<UserInListViewModel> UsersList { get; set; }
    }
}

