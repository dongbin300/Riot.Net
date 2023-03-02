using Newtonsoft.Json;

using System.Net;

namespace Lol.Net.Applications
{
    public class BaseApplication
    {
        public static async Task<T> RequestAsync<T>(HttpClient client, string url)
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

        public static async Task<T> RequestPostAsync<T>(HttpClient client, string url, HttpContent? content = null)
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

        public static async Task<byte[]> RequestBytesAsync(HttpClient client, string url)
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
