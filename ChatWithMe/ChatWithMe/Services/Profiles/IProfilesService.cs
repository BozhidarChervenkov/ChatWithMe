namespace ChatWithMe.Services.Profiles
{
    using System.Threading.Tasks;

    using ChatWithMe.ViewModels.Profiles;

    public interface IProfilesService
    {
        ProfileViewModel MyProfile(string userId);

        ProfileViewModel ProfileById(string otherUserId, string currentUserId);

        Task<bool> AddFriendRequest(string currentUserId, string idOfWantedUser);
        FriendRequestListViewModel FriendRequests(string id);
    }
}
