using System;
using System.IO;
using Newtonsoft.Json;

namespace DataAccessLayer.Converters
{
    public class JsonSerializer
    {
        public static T ConvertJsonToModel<T>(string json)
        {
            T model = JsonConvert.DeserializeObject<T>(json, new JsonSerializerSettings()
            {
                MaxDepth = Int32.MaxValue,
                NullValueHandling = NullValueHandling.Ignore
            });
            return model;
        }

        public static string CreateUrlString(dynamic requestObject)
        {
            var serializer = new Newtonsoft.Json.JsonSerializer();
            var stringWriter = new StringWriter();
            using (var writer = new Newtonsoft.Json.JsonTextWriter(stringWriter))
            {
                writer.QuoteName = false;
                serializer.Serialize(writer, requestObject);
            }
            var model = stringWriter.ToString();
            model = model.Replace("order:0", "order:DESC").Replace("order:1", "order:ASC");
            if (model.Contains("types"))
            {
                model = model.Replace("\"[", "[").Replace("]\"", "]");
            }
            return model;
        }
    }
}
