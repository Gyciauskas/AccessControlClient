using System;

namespace AccessControlClient.Shared
{
    public class CreateUser
    {
        /// <summary>
        /// First name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Middle name
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// User email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Phone name
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// User type
        /// </summary>
        public UserType UserType { get; set; }

        /// <summary>
        /// Company name/Id
        /// </summary>
        public int? CompanyId { get; set; }

        /// <summary>
        /// Department name/Id
        /// </summary>
        public int? DepartmentId { get; set; }

        /// <summary>
        /// User title
        /// </summary>
        public int? UserTitleId { get; set; }

        /// <summary>
        /// Activation date
        /// </summary>
        public DateTime ActivationDate { get; set; }

        /// <summary>
        /// Expiration date
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Additional field 1
        /// </summary>
        public string Additional1 { get; set; }

        /// <summary>
        /// Additional field 2
        /// </summary>
        public string Additional2 { get; set; }

        /// <summary>
        /// Additional field 3
        /// </summary>
        public string Additional3 { get; set; }
    }
}
