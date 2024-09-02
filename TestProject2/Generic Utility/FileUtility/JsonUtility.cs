using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiten_s_Automation_Exercise.GenericUtility.FileUtility
{
    internal class JsonUtility
    {
        public string ReadJson(string Token)
        {
            String jsonString = File.ReadAllText("E:\\VisualStudio\\Hiten's_Automation_Exercise\\Hiten's_Automation_Exercise\\TestData\\Data.json");
            JToken JsonObj = JToken.Parse(jsonString);
            string data = JsonObj.SelectToken(Token).Value<string>();
            return data;
        }
    }
}
