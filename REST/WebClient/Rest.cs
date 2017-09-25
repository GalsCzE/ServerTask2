using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using REST.Entity;
using REST.Interfaces;
using REST.Database;
using SQLite;

namespace REST.WebClient
{
    class Rest : Interfaces.IWebClient
    {
        /// <summary>
        /// Downloads persons list from web source async, parse form JSON to Person entity
        /// </summary>
        /// <returns>Persons list entity</returns>
        /// 

        private static TodoItemDatabase _database;
        public static TodoItemDatabase Database
        {
            get
            {
                if (_database == null)
                {
                    var fileHelper = new FileHelper();
                    _database = new TodoItemDatabase(fileHelper.GetLocalFilePath("TodoSQLite.db3"));
                }
                return _database;
            }
        }
        public async Task< List<Person> > GetPersonsListAsync()
        {

            string url = "https://jsonplaceholder.typicode.com";
            var client = new RestClient(url);
            // client.Authenticator = new HttpBasicAuthenticator(username, password);

            var request = new RestRequest("/posts", Method.GET);
            // request.AddParameter("error", "1"); // adds to POST or URL querystring based on Method
            //request.AddUrlSegment("id", "123"); // replaces matching token in request.Resource

           // request.AddHeader("header", "value");

            IRestResponse response = client.Execute(request);

            IParser parser = new JsonParser();
  
            List<Person> a = await parser.ParseStringAsync<List<Person>>(response.Content);
            foreach (Person s in a)
            {
                await Database.SaveItemAsync(s);
            }
            
            return await parser.ParseStringAsync<List<Person>>(response.Content);
        }
    }
}
