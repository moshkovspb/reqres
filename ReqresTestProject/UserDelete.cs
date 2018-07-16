using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReqresTestProject
{
    class UserDelete : Base
    {

        public UserDelete(string id)
        {
            var request = new RestRequest(id, Method.DELETE);
            response = endpoint.Execute<User>(request);
        }

    }
}
