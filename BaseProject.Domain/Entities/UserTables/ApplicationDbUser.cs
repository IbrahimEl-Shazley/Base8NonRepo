using AAITHelper;
using BaseProject.Domain.Entities.AdditionalTables;
using BaseProject.Domain.Entities.Chat;
using BaseProject.Domain.Entities.SettingTables;
using BaseProject.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace BaseProject.Domain.Entities.UserTables
{
    public class ApplicationDbUser : IdentityUser
    {
        public ApplicationDbUser()
        {
            ContactUs = new HashSet<ContactUs>();
            Notifications = new HashSet<Notification>();
            Devices = new HashSet<Device>();
            Sender = new HashSet<Messages>();
            Receiver = new HashSet<Messages>();
            HubConnections = new HashSet<HubConnection>();
            Orders = new HashSet<Order>();
            OrdersP = new HashSet<Order>();
        }

        public bool IsCodeActivated { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; }
        public int Code { get; set; } = 1234;
        public string FullName { get; set; }
        public UserType AccountType { get; set; } 
        public DateTime RegisterDate { get; set; } = HelperDate.GetCurrentDate();
        public bool AllowNotify { get; set; } = true;
        public string? ProfilePicture { get; set; }
        public string? Lat { get; set; } 
        public string? Lng { get; set; }
        public string? Location { get; set; }
        public string Lang { get; set; } = "ar";

        public virtual ICollection<ContactUs> ContactUs { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<Messages> Sender { get; set; }
        public virtual ICollection<Messages> Receiver { get; set; }
        public virtual ICollection<HubConnection> HubConnections { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Order> OrdersP { get; set; }
    }
}