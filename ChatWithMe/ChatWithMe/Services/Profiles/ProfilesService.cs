﻿namespace ChatWithMe.Services.Profiles
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

            if (user != null)
            {
                viewModel = new ProfileViewModel
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Gender = user.Gender,
                    CustomPofilePicture = user.CustomPofilePicture,
                    Friends = user.Friends,
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

            if (otherUser != null)
            {
                viewModel = new ProfileViewModel
                {
                    Id = otherUser.Id,
                    FirstName = otherUser.FirstName,
                    LastName = otherUser.LastName,
                    Gender = otherUser.Gender,
                    CustomPofilePicture = otherUser.CustomPofilePicture,
                    Friends = otherUser.Friends
                };
            }
            else
            {
                viewModel = null;
            }

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

        public FriendRequestListViewModel FriendRequests(string id)
        {
            var databaseFriendRequests = this.context.FriendRequests
                .Where(u=>u.ToUserId == id)
                .Select(fr => new FriendRequestViewModel
                {
                    Id = fr.Id,
                    FromUserId = fr.FromUserId,
                    FromUserFirstName = fr.FromUser.FirstName,
                    FromUserLastName = fr.FromUser.LastName,
                    FromUserProfileImage = fr.FromUser.CustomPofilePicture,
                    CreatedOn = fr.CreatedOn
                })
                .ToList();

            var viewModel = new FriendRequestListViewModel
            {
                FriendRequests = databaseFriendRequests
            };

            return viewModel;
        }
    }
}
