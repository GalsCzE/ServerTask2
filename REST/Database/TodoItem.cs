using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace REST.Database
{
    public class TodoItem
    {
        [PrimaryKey]
        public int UserID { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public TodoItem()
        {
        }
        public override string ToString()
        {
            return "UserID:" + UserID + " ID:" + ID + " Title:" + Title + " Text: " + Body;
        }
    }
}
