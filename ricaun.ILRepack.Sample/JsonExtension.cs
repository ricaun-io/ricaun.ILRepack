namespace ricaun.ILRepack.Sample
{
    public static class JsonExtension
    {
        public static string ToJson(this object value)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(value);
        }

        public static T FromJson<T>(this string value)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(value);
        }

        public static string Name => typeof(Newtonsoft.Json.JsonConvert).Assembly.GetName().Name;
    }
}