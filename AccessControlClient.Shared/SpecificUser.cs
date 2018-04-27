using System;

namespace AccessControlClient.Shared
{
    public class SpecificUser
    {
        /// <summary>
        /// User Id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// First name
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        public string lastName { get; set; }

        /// <summary>
        /// Middle name
        /// </summary>
        public string middleName { get; set; }

        /// <summary>
        /// User email
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// Employee number
        /// </summary>
        public string employeeNumber { get; set; }

        /// <summary>
        /// Phone name
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        /// User type
        /// </summary>
        public UserType userType { get; set; }

        /// <summary>
        /// Company Id
        /// </summary>
        public int? companyId { get; set; }

        /// <summary>
        /// Department Id
        /// </summary>
        public int? departmentId { get; set; }

        /// <summary>
        /// User title Id
        /// </summary>
        public int? userTitleId { get; set; }

        /// <summary>
        /// Activation date
        /// </summary>
        public DateTime activationDate { get; set; }

        /// <summary>
        /// Expiration date
        /// </summary>
        public DateTime? expirationDate { get; set; }

        /// <summary>
        /// Additional field 1
        /// </summary>
        public string additional1 { get; set; }

        /// <summary>
        /// Additional field 2
        /// </summary>
        public string additional2 { get; set; }

        /// <summary>
        /// Additional field 3
        /// </summary>
        public string additional3 { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        public string version { get; set; } 
    }
}
