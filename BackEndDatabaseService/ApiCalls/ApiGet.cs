using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using MediCore.Models.PatientDataClasses;
using Newtonsoft.Json;

namespace MediCore.BackEndDatabaseService.ApiCalls
{
    public static class ApiGet
    {
        public static async Task<List<PatientData>> ApiGetAll()
        {
            // Replace these with your API endpoint, username, and password
            string apiUrl = $"https://www.datadoctors.patpatwithhat.de/api/patients/";
            string username = "docData";
            string password = "DataIsMyJam321#";

            // Create HttpClient instance
            using (HttpClient client = new HttpClient())
            {
                // Set basic authentication header
                var authValue = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{username}:{password}")));
                client.DefaultRequestHeaders.Authorization = authValue;

                // Send GET request to the API endpoint
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                // Check if request was successful
                if (response.IsSuccessStatusCode)
                {
                    // Read response content
                    string? responseData = await response.Content.ReadAsStringAsync();
                    List<PatientData?> DATA = JsonConvert.DeserializeObject<List<PatientData>>(responseData);
                    return DATA;
                }
                else
                {
                    return null;
                }
            }
        }
        public static async Task ApiGetPatientData() { }

    }
}