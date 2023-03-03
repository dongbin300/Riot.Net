using Lol.Net.Interfaces;

using Newtonsoft.Json;

using System.Net;
using System.Text;

namespace Lol.Net.Clients
{
    public class BaseClient : IClient
    {
        public HttpClient client { get; set; }

        public BaseClient()
        {
            client = new HttpClient();
        }

        public BaseClient(HttpClient client)
        {
            this.client = client;
        }

        public static async Task<T> GetAsync<T>(HttpClient client, string url)
        {
            try
            {
                var response = await client.GetAsync(url).ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    var jsonStringResult = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    T? data = JsonConvert.DeserializeObject<T>(jsonStringResult);
                    return data ?? default!;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
            catch
            {
                throw;
            }
        }

        public static async Task<T> PostAsync<T>(HttpClient client, string url, HttpContent? content = null)
        {
            try
            {
                var response = await client.PostAsync(url, content).ConfigureAwait(false);
                var jsonStringResult = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                T? data = JsonConvert.DeserializeObject<T>(jsonStringResult);
                return data ?? default!;
            }
            catch
            {
                throw;
            }
        }

        public static async Task<T> PostAsync<T>(HttpClient client, string url, string jsonString)
        {
            try
            {
                var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                return await PostAsync<T>(client, url, content);
            }
            catch
            {
                throw;
            }
        }

        public static async Task<byte[]> GetBytesAsync(HttpClient client, string url)
        {
            try
            {
                var requestResult = await client.GetAsync(url).ConfigureAwait(false);

                var response = requestResult.EnsureSuccessStatusCode();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var result = await response.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
                    return result;
                }
                else
                {
                    return Array.Empty<byte>();
                }
            }
            catch
            {
                return Array.Empty<byte>();
            }
        }

        public static async Task DownloadFileAsync(HttpClient client, string url, string localPath)
        {
            try
            {
                var response = await client.GetAsync(url).ConfigureAwait(false);
                using var stream = new FileStream(localPath, FileMode.CreateNew);
                await response.Content.CopyToAsync(stream).ConfigureAwait(false);
            }
            catch
            {
                throw;
            }
        }
    }
}
