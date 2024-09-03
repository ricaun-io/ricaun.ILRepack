namespace ricaun.ILRepack.Sample
{
    public class Class
    {
        public string Text { get; set; } = "Sample Text";
        override public string ToString()
        {
            return this.ToJson();
        }
    }
}