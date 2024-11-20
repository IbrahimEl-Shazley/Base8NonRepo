using BaseProject.Domain.Entities.UserTables;
using BaseProject.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace BaseProject.Persistence.Seeds
{
    public static class DefaultUser
    {
        public static List<ApplicationDbUser> IdentityBasicUserList()
        {
            var hasher = new PasswordHasher<ApplicationDbUser>();

            return new List<ApplicationDbUser>()
            {
                new ApplicationDbUser
                {
                    // ادمن لوحه التحكم
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    UserName = "aait@aait.sa",
                    Email = "aait@aait.sa",            
                    FullName = "aait@aait.sa",
                    AccountType =  UserType.Admin,
                    IsCodeActivated = true,
                    RegisterDate = DateTime.Now,
                    IsActive = true,
                    ProfilePicture = "images/Users/default.jpg",
                    NormalizedEmail = "aait@aait.sa",
                    NormalizedUserName = "Aait@Aait.sa",


                },
                new ApplicationDbUser
                {
                    // يوزر لسرفس
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    UserName = "Api@aait.sa",
                    Email = "Api@aait.sa",
                    FullName = "Api@aait.sa",
                    PhoneNumber= "0100200300",
                    AccountType = UserType.Client,
                    IsCodeActivated = true,
                    RegisterDate = DateTime.Now,
                    IsActive = true,
                    ProfilePicture = "images/Users/default.jpg",
                    NormalizedEmail = "Api@aait.sa",
                    NormalizedUserName = "Api@Aait.sa",
                },
            };
        }
    }
}
