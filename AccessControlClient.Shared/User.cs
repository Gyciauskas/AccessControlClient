using System;

namespace AccessControlClient.Shared
{
    public class User
    {
        public int id { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string middleName { get; set; }

        public string email { get; set; }

        public string phoneNumber { get; set; }

        public UserType userType { get; set; }

        public int? companyId { get; set; }

        public int? departmentId { get; set; }

        public int? userTitleId { get; set; }

        public DateTime activationDate { get; set; }

        public DateTime? expirationDate { get; set; }

        public string additional1 { get; set; }

        public string additional2 { get; set; }

        public string additional3 { get; set; }

        public string version { get; set; }
    }
}
