﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfoReminder.Model.Rest.Authentication;
using RestSharp;

namespace InfoReminder.Model.Rest
{
    /// <summary>
    /// Class used to interact with info-reminder web service
    /// </summary>
    public class InfoReminderWebApi
    {
        /// <summary>
        /// Default base url (http://inforeminder:3000/client)
        /// </summary>
        public static string DefaultBaseUrl 
        {
            get 
            { 
                return "http://inforeminder:3000/client";
            }
        }

        /// <summary>
        /// Session cookie name
        /// </summary>
        public static string SessionCookieName
        {
            get
            {
                return "_info-reminder_session";
            }
        }

        /// <summary>
        /// Base url to web service, default it's http://inforeminder:3000/client
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
            BaseUrl = DefaultBaseUrl;
            ClientCredentials = new ClientCredentials();
        }

        /// <summary>
        /// Full constructor
        /// </summary>
        /// <param name="baseUrl">Url of web service</param>
        /// <param name="credentials">Credentials used to authenticate in web service</param>
        public InfoReminderWebApi(string baseUrl, ClientCredentials credentials)
        {
            BaseUrl = baseUrl;
            ClientCredentials = credentials;
        }

        /// <summary>
        /// Alternative constructor
        /// </summary>
        /// <param name="baseUrl">Url of web service</param>
        /// <param name="userId">Id of user used to authenticate requests</param>
        /// <param name="authToken">Authentication token</param>
        public InfoReminderWebApi(string baseUrl, int userId, string authToken) : this(baseUrl, new ClientCredentials(userId, string.Empty, authToken))
        {
            
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
            
            // Extracts session cookie for further requests
            if (response.Cookies.Count > 0)
            {
                var session = response.Cookies.First((c) => { return c.Name.Equals(SessionCookieName); });
                ClientCredentials.SessionId = session.Value;
            }

            return response.Data;
        }
    }
}

