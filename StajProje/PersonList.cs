using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StajProje
{
    public class PersonList
    {
        [JsonProperty(PropertyName = "Kişi Listesi")]
        public List<Person> personList = new List<Person>();
    }
}
