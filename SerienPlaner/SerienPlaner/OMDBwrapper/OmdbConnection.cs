﻿using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using SerienPlaner.Json;

namespace SerienPlaner.OMDBwrapper
{
    public enum ReturnType
    {
        Json,
        Xml
    }

    public enum PlotType
    {
        Short,
        Full
    }

    public enum TypeOfSearch
    {
        Movie,
        Series,
        Episode
    }

    public enum RequestBy
    {
        ImdbId,
        Title,
        Search
    }

    public class OmdbConnection
    {
        private const string Baseurl = "http://www.omdbapi.com/?";

        public OmdbResult GetResult(OmdbRequestBuilder builder)
        {
            var uri = new Uri(Baseurl + builder.RequestString);

            WebRequest request = null;
            WebResponse response = null;
            try
            {
                request = WebRequest.Create(uri);
                request.Timeout = 1000;
                try
                {
                    response = request.GetResponse();
                }
                catch(Exception)
                {
                    return null;
                }
                var jsonSerializer = new JavaScriptSerializer();
                using (var stream = response.GetResponseStream())
                {
                    if (stream == null) return null;
                    var reader = new StreamReader(stream, Encoding.UTF8);
                    var json = reader.ReadToEnd();
                    return jsonSerializer.Deserialize<OmdbResult>(json);
                }
            }
            finally
            {
                response?.Close();
                request?.Abort();
            }
        }
    }
}
