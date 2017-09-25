using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using REST.Database;

namespace REST.Entity
{
    /// <summary>
    /// Entity class mirrors web entity
    /// </summary>
     public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int IDs { get; set; }
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }

        public override string ToString()
         {
             return $"UserID: {userId}, ID: {id}, Title: {title}, Body: {body}";
         }
    }
}
