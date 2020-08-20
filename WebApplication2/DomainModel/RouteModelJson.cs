using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevenLake.DomainModel
{
    public class Object
    {
        public string objecttype { get; set; }
        public string objectname { get; set; }
    }

    public class Stop
    {
        public string stopname { get; set; }
        public List<Object> objects { get; set; }
    }

    public class MyArray
    {
        public string routename { get; set; }
        public List<Stop> stops { get; set; }
    }

    public class FlattenedJson
    {
        public string routename { get; set; }
        public string stopname { get; set; }
        public string objecttype { get; set; }
        public string objectname { get; set; }
    }


}
