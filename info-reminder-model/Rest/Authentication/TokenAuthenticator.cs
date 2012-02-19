using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfoReminder.Model.Entities;
using RestSharp;

namespace InfoReminder.Model.Rest.Authentication
{
    /// <summary>
    /// Authenticator used to authenticate in info-reminder web service (It requires user id and auth token)
    /// </summary>
    class TokenAuthenticator : IAuthenticator
    {
        public ClientCredentials Credentials { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public TokenAuthenticator()
        {

        }

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="credentials">Credentials used to authenticate</param>
        public TokenAuthenticator(ClientCredentials credentials)
        {
            Credentials = credentials;
        }

        /// <summary>
        /// It adds UserId/AuthToken pattern to request url
        /// </summary>
        /// <param name="client">RestClient object</param>
        /// <param name="request">RestRequest object</param>
        public void Authenticate(IRestClient client, IRestRequest request)
        {
            string authPart = string.Format("{0:d}/{1:s}", Credentials.User.UserId, Credentials.AuthToken);
            request.Resource = string.Format("{0:s}/{1:s}", request.Resource, authPart);
            request.AddUrlSegment("Authentication", authPart);
        }
    }
}
