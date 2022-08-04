using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynacoopConsole1
{
    internal class ConnectionFactory
    {
        public static IOrganizationService GetService()
        {
            string connectionString =
             "AuthType=OAuth;" +
             "Username=Emmanuel@Dynacoops.onmicrosoft.com; " +
             "Password=Caps1367#;" +
             "Url=https://org8993d19f.crm2.dynamics.com/;" +
             "AppId=95d0d068-9056-43de-b236-777e997d0892;" +
             "RedirectUri=app://9896d91c-3ad3-4762-918f-3024bebc5d1a;";


            CrmServiceClient crmServiceClient = new CrmServiceClient(connectionString);
            return crmServiceClient.OrganizationWebProxyClient;

        }

    }

}