using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReqresTestProject
{
    abstract class Base
    {
        public IRestResponse<User> response;
        public RestClient endpoint = new RestClient("https://reqres.in/api/users");
        public DateTime date = DateTime.Today;
    }
}
