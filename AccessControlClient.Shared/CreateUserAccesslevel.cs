using System;

namespace AccessControlClient.Shared
{
    public class CreateUserAccesslevel
    {
        public int AccessLevelId { get; set; }
        public DateTime ActivationDate { get; set; }
        public DateTime? ExpirationDate { get; set; } 
        public int UseLimit { get; set; }
        public UserAccessLevelStatus Status { get; set; }
    }
}
