namespace ChatWithMe.Services.Profiles
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using ChatWithMe.Data;
    using ChatWithMe.Models;
    using ChatWithMe.ViewModels.Profiles;

    public class ProfilesService : IProfilesService
    {
        private readonly ApplicationDbContext context;

        public ProfilesService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public ProfileViewModel MyProfile(string userId)
        {
            var user = this.context.Users.FirstOrDefault(u => u.Id == userId);

            var viewModel = new ProfileViewModel();

            var friends = this.context.Friends.Where(f=>f.UserFriendId == userId).ToList();

            if (user != null)
            {
                viewModel = new ProfileViewModel
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Gender = user.Gender,
                    CustomPofilePicture = user.CustomPofilePicture,
                    Friends = friends,
                    FriendRequests = user.FriendRequests
                };
            }
            else
            {
                viewModel = null;
            }

            return viewModel;
        }

        public ProfileViewModel ProfileById(string otherUserId, string currentUserId)
        {
            var otherUser = this.context.Users.FirstOrDefault(u => u.Id == otherUserId);
            var currentUser = this.context.Users.FirstOrDefault(u => u.Id == currentUserId);

            var viewModel = new ProfileViewModel();

            var otherUserFriends = this.context.Friends.Where(f => f.ApplicationUserId == otherUserId).ToList();
            var varUserFriends = this.context.Friends.Where(f => f.ApplicationUserId == currentUserId);
            var isUserFriend = varUserFriends.Any(f => f.UserFriendId == otherUserId);

            if (otherUser != null)
            {
                viewModel = new ProfileViewModel
                {
                    Id = otherUser.Id,
                    FirstName = otherUser.FirstName,
                    LastName = otherUser.LastName,
                    Gender = otherUser.Gender,
                    CustomPofilePicture = otherUser.CustomPofilePicture,
                    Friends = otherUserFriends,
                    IsUserFriend = isUserFriend
                };
            }
            else
            {
                viewModel = null;
            }

            return viewModel;
        }

        public FriendRequestListViewModel FriendRequests(string currentUserId, string idOfWantedUser)
        {
            var databaseFriendRequests = this.context.FriendRequests
                .Where(fr => fr.ToUserId == idOfWantedUser && fr.IsDeleted == false)
                .Select(fr => new FriendRequestViewModel
                {
                    Id = fr.Id,
                    FromUserId = fr.FromUserId,
                    FromUserFirstName = fr.FromUser.FirstName,
                    FromUserLastName = fr.FromUser.LastName,
                    FromUserProfileImage = fr.FromUser.CustomPofilePicture,
                    CurrentUserId = currentUserId,
                    CreatedOn = fr.CreatedOn
                })
                .ToList();

            var viewModel = new FriendRequestListViewModel
            {
                FriendRequests = databaseFriendRequests
            };

            return viewModel;
        }

        public async Task<bool> AddFriendRequest(string currentUserId, string idOfWantedUser)
        {
            var senderUser = this.context.Users.FirstOrDefault(u => u.Id == currentUserId);
            var receiverUser = this.context.Users.FirstOrDefault(u => u.Id == idOfWantedUser);

            if (senderUser == null || receiverUser == null || this.context.FriendRequests.Any(fc => fc.FromUserId == senderUser.Id && fc.ToUserId == receiverUser.Id))
            {
                return false;
            }

            var friendRequest = new FriendRequest
            {
                FromUserId = senderUser.Id,
                FromUser = senderUser,
                ToUserId = receiverUser.Id,
                ToUser = receiverUser,
                CreatedOn = DateTime.Now
            };

            await this.context.FriendRequests.AddAsync(friendRequest);
            await this.context.SaveChangesAsync();

            return true;
        }

        public async Task<BecomeFriendsViewModel> BecomeFriends(int friendRequestId)
        {
            var friendRequest = this.context.FriendRequests.FirstOrDefault(fr => fr.Id == friendRequestId);
            friendRequest.IsDeleted = true;

            var firstUser = this.context.Users.FirstOrDefault(u => u.Id == friendRequest.FromUserId);
            var secondUser = this.context.Users.FirstOrDefault(u => u.Id == friendRequest.ToUserId);

            firstUser.Friends.Add(new Friend { UserFriendId = secondUser.Id, FirstName = secondUser.FirstName, LastName = secondUser.LastName, ApplicationUserId = firstUser.Id });
            secondUser.Friends.Add(new Friend { UserFriendId = firstUser.Id, FirstName =firstUser.FirstName, LastName = firstUser.LastName, ApplicationUserId = secondUser.Id });

            await this.context.SaveChangesAsync();

            var viewModel = new BecomeFriendsViewModel
            {
                FirstFriend = firstUser,
                SecondFriend= secondUser
            };

            return viewModel;
        }
    }
}
