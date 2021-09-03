namespace ChatWithMe.Services.Home
{
    using ChatWithMe.Data;
    using ChatWithMe.ViewModels.Home;

    public class HomeService : IHomeService
    {
        private readonly ApplicationDbContext context;

        public HomeService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public UsersListViewModel Users()
        {
            var usersInList = new UsersListViewModel();

            foreach (var user in this.context.Users)
            {
                usersInList.UsersList.Add(new UserInListViewModel
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Gender = user.Gender,
                    CustomPofilePicture = user.CustomPofilePicture
                });
            }

            return usersInList;
        }
    }
}
