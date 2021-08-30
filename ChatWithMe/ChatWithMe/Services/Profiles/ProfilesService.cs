namespace ChatWithMe.Services.Profiles
{
    using System.Linq;

    using ChatWithMe.Data;
    using ChatWithMe.ViewModels.Profiles;

    public class ProfilesService : IProfilesService
    {
        private readonly ApplicationDbContext context;

        public ProfilesService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public MyProfileViewModel ProfileInfo(string userId)
        {
            var user = this.context.Users.FirstOrDefault(u => u.Id == userId);

            var viewModel = new MyProfileViewModel();

            if (user != null)
            {
                viewModel = new MyProfileViewModel
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Gender = user.Gender,
                    CustomPofilePicture = user.CustomPofilePicture,
                    Friends = user.Friends,
                    FriendRequestsFromUsers = user.FriendRequestsFromUser,
                    FriendRequestToUsers = user.FriendRequestsToUser
                };
            }
            else
            {
                viewModel = null;
            }

            return viewModel;
        }
    }
}
