using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace MyBankIsDifferent.Models
{
    public class MembershipService
    {
        private MembershipProvider _provider;

        public MembershipService()
            : this(null)
        {
        }

        public MembershipService(MembershipProvider provider)
        {
            _provider = provider ?? Membership.Provider;
        }

        public int MinPasswordLength
        {
            get
            {
                return _provider.MinRequiredPasswordLength;
            }
        }

        //public bool ValidateUser(string userName, string password)
        //{
        //    return _provider.ValidateUser(userName, password);
        //}

        public static bool ValidateUser(string userName, string password)
        {
            return ((userName == "Haacked" && password == "password") ||
                     (userName == "MrAnonymous" && password == "password") ||
                     (userName == "GeekUser" && password == "password") ||
                     (userName == "SmartUser" && password == "password")
                  );

        }

        public MembershipCreateStatus CreateUser(string userName, string password, string email)
        {
            MembershipCreateStatus status;
            _provider.CreateUser(userName, password, email, null, null, true, null, out status);
            return status;
        }

        public bool ChangePassword(string userName, string oldPassword, string newPassword)
        {
            MembershipUser currentUser = _provider.GetUser(userName, true /* userIsOnline */);
            return currentUser.ChangePassword(oldPassword, newPassword);
        }
    }
}