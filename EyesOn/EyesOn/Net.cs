using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace EyesOn
{
    public static class Net
    {
        //public static async Task<string> JsonRequest(string url, params object[] datas)
        public static async Task<string> JsonRequest(string url, object data)
        {
            try
            {
                var httpReq = (HttpWebRequest)HttpWebRequest.Create(new Uri(url));
                httpReq.Method = "GET";
                httpReq.ContentType = "application/json";

                ////send json
                //using (var stream = await Task.Factory.FromAsync<Stream>(httpReq.BeginGetRequestStream, httpReq.EndGetRequestStream, null))
                //{
                //    using (var streamWriter = new StreamWriter(stream))
                //    {
                //        //string json = "{\"x\":\"true\"}";

                //        //foreach (var data in datas)
                //        //{
                //        var json = JsonConvert.SerializeObject(data);
                //        streamWriter.Write(json);
                //        //}
                //        streamWriter.Flush();
                //    }
                //}

                //get response
                //httpReq.BeginGetResponse((ar) =>
                //{
                //    var request = (HttpWebRequest)ar.AsyncState;
                //    using (var response = (HttpWebResponse)request.EndGetResponse(ar))
                //    {
                //        string json;
                //        using (var s = new StreamReader(response.GetResponseStream()))
                //        {
                //            json = s.ReadToEnd();
                //        }

                //        //var result = JsonConvert.DeserializeObject<Model.LoginResult>(json);
                //        //FinishLogin(result);

                //        //RunOnUiThread(() =>
                //        //{
                //        //    ListAdapter = new ArrayAdapter<string>(this,
                //        //                Resource.Layout.TweetItemView, results);
                //        //});
                //    }
                //}, httpReq);

                using (var response = (HttpWebResponse)await Task.Factory.FromAsync<WebResponse>(httpReq.BeginGetResponse, httpReq.EndGetResponse, null))
                {
                    string result;
                    using (var s = new StreamReader(response.GetResponseStream()))
                    {
                        result = s.ReadToEnd();

                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                int stopme = 1;

                return string.Empty;
            }
        }
    }
}
