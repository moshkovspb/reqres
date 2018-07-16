using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReqresTestProject
{
    class UserGet : Base
    {
        public UserGet(string id) {
            var request = new RestRequest(id);
            response = endpoint.Execute<User>(request);
        }

    }
}
