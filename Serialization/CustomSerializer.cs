using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace Serialization
{
    class CustomSerializer
    {
        public string Serialize(object obj)
        {
            var objType = obj.GetType();
            IList<FieldInfo> fieldName = new List<FieldInfo>(objType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public));

            string result = "<?\n";

            foreach (var val in fieldName)
            {
                var propValue = val.GetValue(obj);
                result += val.Name + "=" + propValue + "\n";
            }
            result += "?>";

            return result;
        }
    }
}