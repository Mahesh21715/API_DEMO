using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Test_API
{
    class UserData
    {
        public int UserId { get; set; }

        [PrimaryKey]
        public int Id { get; set; }
        public string Title { get; set; }
       
    }
}
