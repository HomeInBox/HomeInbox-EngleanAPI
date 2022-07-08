namespace Extention
{
    public static class Extension
    {
        public static bool IsNotNullOrEmpty(this string param)
        {
            return !string.IsNullOrEmpty(param);
        }
    }
}