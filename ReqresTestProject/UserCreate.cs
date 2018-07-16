using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReqresTestProject
{
    class UserCreate : Base
    {

        public UserCreate(string name, string job)
        {
            var request = new RestRequest(Method.POST);
            request.AddParameter("name", name);
            request.AddParameter("job", job);
            response = endpoint.Execute<User>(request);
        }

    }
}
