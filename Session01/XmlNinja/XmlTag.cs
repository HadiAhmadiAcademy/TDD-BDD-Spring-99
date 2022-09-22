namespace XmlNinja
{
    internal class XmlTag
    {
        public static string GetTag(string tag, object value)
        {
            return $"{OpenTagFor(tag)}{value}{CloseTagFor(tag)}";
        }

        public static string OpenTagFor(string tagName)
        {
            return $"<{tagName}>";
        }

        public static string CloseTagFor(string nameOfClass)
        {
            return $"</{nameOfClass}>";
        }
    }
}