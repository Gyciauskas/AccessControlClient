using System;

namespace AccessControlClient.Shared
{
    public class UserAccessLevel
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// User Id
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Access level Id
        /// </summary>
        public int AccessLevelId { get; set; }

        /// <summary>
        /// Activation date
        /// </summary>
        public DateTime ActivationDate { get; set; }

        /// <summary>
        /// Expiration date
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// User access level status
        /// </summary>
        public UserAccessLevelStatus Status { get; set; }

        /// <summary>
        /// Use limit
        /// </summary>
        public int UseLimit { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        public string Version { get; set; }
    }
}
