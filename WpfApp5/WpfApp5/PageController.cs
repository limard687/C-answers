using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    internal class PageController
    {
        private static Authorization authorizationPage;

        private static RegistrationPage registrationPage;
        public static Authorization AuthorizationPage
        {
            get
            {
                if (authorizationPage == null)
                {
                    authorizationPage = new Authorization();
                }
                return authorizationPage;
            }
        }

        public static RegistrationPage RegistrationPage
        {
            get
            {
                if (registrationPage == null)
                {
                    registrationPage = new RegistrationPage();
                }
                return registrationPage;
            }
        }
    }
}
