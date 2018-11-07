using Newtonsoft.Json;
using System.Collections.Generic;

namespace MyCompany.Cart.Api
{
    public class Loader
    {
        public List<Transactions> Load(string[] lines)
        {
            List<Transactions> transactions = new List<Transactions>();

            var columns = lines[0].Split(',');

            var listObjResult = new List<Dictionary<string, string>>();

            for (int line = 1; line < lines.Length; line++)
            {
                var objResult = new Dictionary<string, string>();
                for (int colIndex = 0; colIndex < columns.Length; colIndex++)
                {
                    string key = columns[colIndex];
                    string value = lines[line].Split(',')[colIndex];
                    objResult.Add(key, string.IsNullOrEmpty(value) ? "0" : value);
                }

                transactions.Add(
                    JsonConvert.DeserializeObject<Transactions>(
                        JsonConvert.SerializeObject(objResult)
                    )
                    );
            }
            return transactions;
        }
    }
}
