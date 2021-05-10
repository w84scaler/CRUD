using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Newtonsoft.Json;
using System.Reflection;

namespace oop1
{
    public class SerializatorAttribute : Attribute
    {
        public string Name;
        public string Extension;
    }
    public abstract class DataManager
    {
        public abstract byte[] ListToByte(List<object> list);
        public abstract List<object> ByteToList(byte[] data);
    }

    [Serializator(Name = "Binary", Extension = "bin")]
    public class BinDataManager : DataManager
    {
        public override byte[] ListToByte(List<object> list)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            binaryFormatter.Serialize(ms, list);
            return ms.ToArray();
        }
        public override List<object> ByteToList(byte[] data)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            MemoryStream ms = new MemoryStream(data);
            List<object> list = (List<object>)binaryFormatter.Deserialize(ms);
            return list;
        }
    }

    [Serializator(Name = "Json", Extension = "json")]
    public class JsonDataManager : DataManager
    {
        public override byte[] ListToByte(List<object> list)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            string json = JsonConvert.SerializeObject(list, settings);
            byte[] data = Encoding.UTF8.GetBytes(json);
            return data;
        }
        public override List<object> ByteToList(byte[] data)
        {
            string json = Encoding.UTF8.GetString(data);
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            List<object> list = JsonConvert.DeserializeObject<List<object>>(json, settings);
            return list;
        }
    }

    [Serializator(Name = "Nedojson", Extension = "txt")]
    public class TextDataManager : DataManager
    {
        public override byte[] ListToByte(List<object> list)
        {
            string nedojson = String.Empty;
            for (int i = 0; i <= list.Count - 1; i++)
            {
                nedojson += NedoJsonSerialize(list[i]);
                nedojson += "}";
                if (i != list.Count - 1) nedojson += ",";
            }
            byte[] data = Encoding.UTF8.GetBytes(nedojson);
            return data;
        }

        public override List<object> ByteToList(byte[] data)
        {
            string nedojson = Encoding.UTF8.GetString(data);
            List<object> ObjectList = new List<object>();
            while (nedojson != String.Empty)
            {
                ObjectList.Add(NedoJsonDeserialize(ref nedojson));
            }
            return ObjectList;
        }

        private static string NedoJsonSerialize(object obj)
        {
            string str = String.Empty;
            Type type = obj.GetType();
            str += type.ToString() + "{";
            FieldInfo[] fields = type.GetFields();
            for (int i = 0; i <= fields.Length - 1; i++)
            {
                if (fields[i].FieldType.ToString().IndexOf("oop1.") > -1)
                {
                    str += NedoJsonSerialize(fields[i].GetValue(obj)) + "}";
                }
                else
                {
                    str += fields[i].FieldType.ToString() + ":" + fields[i].GetValue(obj);
                }
                if (i != fields.Length - 1) str += ",";
            }
            return str;
        }

        private static object NedoJsonDeserialize(ref string str)
        {
            Type ObjectType = StrToType(ref str, str.IndexOf('{'));
            object obj = Activator.CreateInstance(ObjectType);

            foreach (FieldInfo field in ObjectType.GetFields())
            {
                int index1 = str.IndexOf(':');
                int index2 = str.IndexOf('{');
                object value = null;
                if (index1 < index2 || index2 == -1)
                {
                    Type type = StrToType(ref str, index1);
                    string value_str = StrOfValue(ref str);
                    if (type.Name == "Int32")
                        value = Convert.ToInt32(value_str);
                    else if (type.Name == "String")
                        value = value_str;
                    else if (type.Name == "Boolean")
                        value = Convert.ToBoolean(value_str);
                }
                else
                {
                    value = NedoJsonDeserialize(ref str);
                }
                field.SetValue(obj, value);
            }
            if (str.IndexOf(',') != -1)
                str = str.Remove(0, 2);
            else
                str = str.Remove(0, 1);
            return obj;
        }

        private static Type StrToType(ref string str, int i)
        {
            Type type = Type.GetType(str.Substring(0, i), false, true);
            str = str.Remove(0, i + 1);
            return type;
        }

        private static string StrOfValue(ref string str)
        {
            int index1 = str.IndexOf(',');
            int index2 = str.IndexOf('}');
            if (index1 < index2 && index1 != -1)
            {
                string s = str.Substring(0, index1);
                str = str.Remove(0, index1 + 1);
                return s;
            }
            else
            {
                string s = str.Substring(0, index2);
                str = str.Remove(0, index2);
                return s;
            }
        }
    }
}
