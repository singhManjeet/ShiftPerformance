using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;

namespace ShiftPerformance.Utils
{
    public static class GoogleAppService
    {
        /// <summary>
        /// Creates an instance of the service
        /// </summary>
        /// <param name="permission">valid operations are Read and Write. Default is Read.</param>
        /// <returns></returns>
        public static SheetsService GetService(string permission = "Read")
        {
            // Create Google Sheets API service.
            return new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = GetCredential(permission),
                ApplicationName = ConfigurationManager.AppSettings["ApplicationName"].ToString(),
            });
        }
        /// <summary>
        /// Gets the credentials for the Google Api from the Client secret Json in the creds folder.
        /// </summary>
        /// <param name="permission"></param>
        /// <returns></returns>
        private static UserCredential GetCredential(string permission)
        {
            // If modifying these scopes, delete your previously saved credentials
            // at ~/creds/sheets.googleapis.com-Shift-Performance.json
            string[] Scopes = { permission == "Read" ?  SheetsService.Scope.SpreadsheetsReadonly :  SheetsService.Scope.Spreadsheets };

            UserCredential credential;
            string credPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "creds\\");
            using (var stream =
                new FileStream(credPath +"client_secret.json", FileMode.Open, FileAccess.Read))
            {
                credPath += "sheets.googleapis.com-Shift-Performance.json";

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            return credential;
        }
    }
}