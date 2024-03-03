using WebApp.Models;

namespace WebApp.ViewModels
{
    public class AccountDetailsViewModel
    {
        public string Title { get; set; } = "Account Details";

        public AccountDetailsBasicInfoModel BasicInfo { get; set; } = new AccountDetailsBasicInfoModel()
        {
            ProfileImage = "images/profile-picture.svg",
            FirstName = "John",
            LastName = "Doe",
            Email = "john@domain.com"
        };

        public AccountDetailsAddressInfoModel AddressInfo { get; set; } = new AccountDetailsAddressInfoModel();
    }
}
