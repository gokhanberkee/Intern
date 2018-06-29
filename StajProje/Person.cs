using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace StajProje
{
    public class Person
    {
        [JsonProperty(PropertyName = "İsim")]
        public string Name;
        [JsonProperty(PropertyName = "Soyisim")]
        public string surname;
        [JsonProperty(PropertyName = "Yaş")]
        public string age;
        [JsonProperty(PropertyName = "TCKNO")]
        public string TCKNO;
        [JsonProperty(PropertyName = "Cinsiyet")]
        public string gender;
        [JsonProperty(PropertyName = "E-mail")]
        public string mail;

    }
}
