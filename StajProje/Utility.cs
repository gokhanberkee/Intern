using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StajProje
{
    public class Utility
    {
        public  static PersonList ReadPersons()
        {
            PersonList personList;
            StringBuilder sb = new StringBuilder();
            sb.Append("{\"Kişi Listesi\": [");
            using (StreamReader r = new StreamReader("C:\\Users\\GökhanBerke\\Desktop\\Staj\\Visual\\StajProje\\veriSeti.txt"))
            {
                String line;
                while ((line = r.ReadLine()) != null)
                {
                    sb.Append(line);
                    if (r.Peek() != -1)
                    {
                        sb.Append(",");
                    }
                }

                sb.Append("]}");

                string jsonMessage = sb.ToString();
                personList = JsonConvert.DeserializeObject<PersonList>(jsonMessage);                
                r.Close();
            }
            
            return personList;
        }
    }
}
