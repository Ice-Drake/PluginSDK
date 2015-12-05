using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PluginSDK
{
    /// <summary>
    ///  All chat source plugins that allows account registration can implement this interface.
    /// </summary>
    interface IChatSourceAccountManager
    {
        /// <summary>
        /// Create an account.
        /// </summary>
        /// <param name="account">Account to be created.</param>
        /// <returns>Returns true if successful.</returns>
        bool createAccount(Account account);

        /// <summary>
        /// Log in the existing account.
        /// </summary>
        /// <param name="account">Account to be log in with.</param>
        /// <returns>Returns true if successful.</returns>
        bool login(Account acount);

        /// <summary>
        /// Log off the existing account.
        /// </summary>
        /// <param name="account">Account to be log off with.</param>
        /// <returns>Returns true if successful.</returns>
        bool logoff(Account account);

        /// <summary>
        /// Modify an existing account.
        /// </summary>
        /// <param name="account">Account to be modified.</param>
        /// <returns>Returns true if successful.</returns>
        bool modifyAccount(Account account);

        /// <summary>
        /// Remove an existing account.
        /// </summary>
        /// <param name="account">Account to be removed.</param>
        /// <returns>Returns true if successful.</returns>
        bool removeAccount(Account account);
    }
}
