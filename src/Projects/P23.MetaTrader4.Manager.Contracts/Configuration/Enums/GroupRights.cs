using System;

namespace P23.MetaTrader4.Manager.Contracts.Configuration.Enums
{
    /// <summary>
    /// Group rights
    /// </summary>
    [Flags]
    public enum GroupRights
    {
        /// <summary>
        /// Email
        /// </summary>
        Email = 1,
        /// <summary>
        /// Trailing
        /// </summary>
        Trailing = 2,
        /// <summary>
        /// Advisor
        /// </summary>
        Advisor = 4,
        /// <summary>
        /// Expiration
        /// </summary>
        Expiration = 8,
        /// <summary>
        /// All signals
        /// </summary>
        SignalsAll = 16,
        /// <summary>
        /// Own signals
        /// </summary>
        SignalsOwn = 32
    };
}