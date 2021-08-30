namespace ChatWithMe.Services.Profiles
{
    using ChatWithMe.ViewModels.Profiles;

    public interface IProfilesService
    {
        MyProfileViewModel ProfileInfo(string userId);
    }
}
