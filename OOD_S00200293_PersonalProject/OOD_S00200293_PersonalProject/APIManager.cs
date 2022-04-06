using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OOD_S00200293_PersonalProject
{
    public enum httpMethod
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    class APIManager
    {

        public string endPoint { get; set; }
        public httpMethod method { get; set; }

        public APIManager()
        {
            endPoint = string.Empty;
            method = httpMethod.GET;
        }

        public string MakeRequest()
        {
            string responseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = method.ToString();

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("HTTP get request failed with: " + response.StatusCode);
                }
                else
                {
                    //process the response data stream
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream !=  null)
                        {
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                responseValue = reader.ReadToEnd();
                            }//End of stream reader
                        }
                    }
                }
            }

            return responseValue;
        }
    }
}
