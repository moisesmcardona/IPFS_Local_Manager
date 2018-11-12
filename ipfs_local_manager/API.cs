using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ipfs_uploader
{
    class API
    {
        private static string api_endpoint = Properties.Settings.Default.APIEndpoint + "files";
        public static string UploadFile(string ipfs_path, string file)
        {
            using (var client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            {
                {
                    formData.Add(new StreamContent(new FileStream(file, FileMode.Open)), "file", Path.GetFileName(file));
                    Uri uri = new Uri(api_endpoint + "/write?arg=" + WebUtility.HtmlEncode(ipfs_path + "/" + Path.GetFileName(file)) + "&create=true");
                    HttpResponseMessage response = client.PostAsync(uri, formData).Result;
                    if (!response.IsSuccessStatusCode)
                    {
                        return "Error";
                    }
                    else
                    {
                        StreamReader reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                        if (reader.ReadToEnd() == "")
                        {
                            Flush(ipfs_path + "/" + Path.GetFileName(file));
                        }
                        return reader.ReadToEnd();
                    }
                }
            }
        }
        public static string Stat(string ipfs_path)
        {
            using (var client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            {
                {
                    Uri uri = new Uri(api_endpoint + "/stat?arg=" + WebUtility.HtmlEncode(ipfs_path));
                    HttpResponseMessage response = client.GetAsync(uri).Result;
                    if (!response.IsSuccessStatusCode)
                    {
                        return "Error";
                    }
                    StreamReader reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    return reader.ReadToEnd();
                }
            }
        }

        public static string Flush(string ipfs_path)
        {
            using (var client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            {
                {
                    Uri uri = new Uri(api_endpoint + "/flush?arg=" + WebUtility.HtmlEncode(ipfs_path));
                    HttpResponseMessage response = client.GetAsync(uri).Result;
                    if (!response.IsSuccessStatusCode)
                    {
                        return "Error";
                    }
                    else
                    {
                        StreamReader reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                        dynamic jsonresponse = JsonConvert.DeserializeObject(reader.ReadToEnd());
                        return jsonresponse["Hash"];
                    }
                }
            }
        }
        public static string ListContent(string ipfs_path)
        {

            using (var client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            {
                {
                    Uri uri = new Uri(api_endpoint + "/ls?arg=" + WebUtility.HtmlEncode(ipfs_path));
                    HttpResponseMessage response = client.GetAsync(uri).Result;
                    StreamReader reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    return reader.ReadToEnd();
                }
            }
        }
        public static string MakeDir(string ipfs_path)
        {

            using (var client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            {
                {
                    Uri uri = new Uri(api_endpoint + "/mkdir?arg=" + WebUtility.HtmlEncode(ipfs_path));
                    HttpResponseMessage response = client.GetAsync(uri).Result;
                    if (!response.IsSuccessStatusCode)
                    {
                        return "Error";
                    }
                    StreamReader reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    return reader.ReadToEnd();
                }
            }
        }
        public static string RemovePath(string ipfs_path)
        {

            using (var client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            {
                {
                    Uri uri = new Uri(api_endpoint + "/rm?arg=" + WebUtility.HtmlEncode(ipfs_path) + "&recursive=true");
                    HttpResponseMessage response = client.GetAsync(uri).Result;
                    if (!response.IsSuccessStatusCode)
                    {
                        return "Error";
                    }
                    StreamReader reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
