using System;
using System.Collections.Generic;
using System.Text;

namespace ReqresTestProject
{
    class User
    {
        public Data data { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string job { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }

}
