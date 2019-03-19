using Microsoft.SharePoint.Client;
using Microsoft.SharePoint.Client.UserProfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace SPO.Provider.TaggingWeb
{
    public static class ProfileHelper
    {
        public static string GetProfilePropertyFor(ClientContext ctx, string userName, string propertyName)
        {
            string _result = string.Empty;
            if (ctx != null)
            {
                try
                {
                    PeopleManager peopleManager = new PeopleManager(ctx);
                    var _profileProperty = peopleManager.GetUserProfilePropertyFor(userName, propertyName);
                    ctx.ExecuteQuery();
                    _result = _profileProperty.Value;
                }
                catch
                {
                    throw;
                }
            }
            return _result;
        }
    }
}