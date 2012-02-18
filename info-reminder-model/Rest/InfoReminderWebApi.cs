using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfoReminder.Model.Entities;
using RestSharp;

namespace InfoReminder.Model.Rest
{
    /// <summary>
    /// Class used to interact with info-reminder web service
    /// </summary>
    class InfoReminderWebApi
    {
        /// <summary>
        /// Base url to web service, default it's http://localhost:3000
        /// </summary>
        public string BaseUrl { get; set; }

        /// <summary>
        /// Client credentials used to authenticate requests
        /// </summary>
        public ClientCredentials ClientCredentials { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public InfoReminderWebApi()
        {
            BaseUrl = "http://localhost:3000/client";
        }

        /// <summary>
        /// Executes request
        /// </summary>
        /// <typeparam name="T">Type of expected object</typeparam>
        /// <param name="request">Request to send</param>
        /// <returns>Requested object</returns>
        public T Execute<T>(RestRequest request) where T : new()
        {
            RestClient client = new RestClient(BaseUrl);
            client.BaseUrl = BaseUrl;
            client.Authenticator = new TokenAuthenticator(ClientCredentials);
            request.RequestFormat = DataFormat.Json;
 
            RestResponse<T> response = client.Execute<T>(request);

            return response.Data;
        }
    }
}
