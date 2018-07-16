using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReqresTestProject
{
    class UserUpdate : Base
    {

        public UserUpdate(string name, string job)
        {
            var request = new RestRequest(Method.PUT);
            request.AddParameter("name", name);
            request.AddParameter("job", job);
            response = endpoint.Execute<User>(request);
        }

    }
}
