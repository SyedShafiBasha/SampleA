using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SevenLake.DomainModel;

namespace SevenLake.BusineesLogic
{
    public static class RouteJsonLogic
    {
        public static List<FlattenedJson> GetFlattenedRouteJson()
        {
            var myJsonResponse = System.IO.File.ReadAllText("RestAPI_JSON_Input.json");
            List<MyArray> myDeserializedClass = JsonConvert.DeserializeObject<List<MyArray>>(myJsonResponse);
            List<FlattenedJson> listFlattenedJson = new List<FlattenedJson>();

            foreach (var item in myDeserializedClass)
            {
                foreach (var stop in item.stops)
                {
                    foreach (var obj in stop.objects)
                    {
                        FlattenedJson flattenedJson = new FlattenedJson();
                        flattenedJson.routename = item.routename;
                        flattenedJson.stopname = stop.stopname;
                        flattenedJson.objecttype = obj.objecttype;
                        flattenedJson.objectname = obj.objectname;
                        listFlattenedJson.Add(flattenedJson);
                    }
                }
            }
            return listFlattenedJson;

        }
    }
}
