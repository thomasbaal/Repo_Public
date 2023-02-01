using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Serialize_Deserialize_with_sytem_text_json
{
    public class MicrosoftDeserializer
    {
        //
        public JsonComplexObject_Paste_Special.Company? DeserializeUsingSystemTextJson(string json)
        {
            var companyData = JsonSerializer.Deserialize<JsonComplexObject_Paste_Special.Company>(json,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return companyData;


        }
    }
}
