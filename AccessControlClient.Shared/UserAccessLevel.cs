using System;

namespace AccessControlClient.Shared
{
    public class UserAccessLevel
    {
        /// <summary>
        /// Id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// User Id
        /// </summary>
        public int userId { get; set; }

        /// <summary>
        /// Access level Id
        /// </summary>
        public int accessLevelId { get; set; }

        /// <summary>
        /// Activation date
        /// </summary>
        public DateTime activationDate { get; set; }

        /// <summary>
        /// Expiration date
        /// </summary>
        public DateTime? expirationDate { get; set; }

        /// <summary>
        /// User access level status
        /// </summary>
        public UserAccessLevelStatus status { get; set; }

        /// <summary>
        /// Use limit
        /// </summary>
        public int useLimit { get; set; }

        /// <summary>
        /// Access level name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        public string version { get; set; }
    }
}
