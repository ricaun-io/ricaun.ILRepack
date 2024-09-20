namespace ricaun.ILRepack.Sample
{
    public static class References
    {
        public static string Newtonsoft_Json => typeof(Newtonsoft.Json.JsonConvert).Assembly.GetName().Name;
        public static string System_Text_Json => typeof(System.Text.Json.JsonSerializer).Assembly.GetName().Name;
    }
}