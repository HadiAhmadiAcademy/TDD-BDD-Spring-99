using System.Text;

namespace XmlNinja
{
    public class NinjaSerializer
    {
        public static string Serialize(object target)
        {
            if (target == null) return string.Empty;

            var xmlBuilder = new StringBuilder();

            var nameOfClass = target.GetType().Name;
            xmlBuilder.Append(XmlTag.OpenTagFor(nameOfClass));
            var properties = target.GetType().GetProperties();
            foreach (var propertyInfo in properties)
            {
                var nameOfProperty = propertyInfo.Name;
                var value = propertyInfo.GetValue(target);
                xmlBuilder.Append(XmlTag.GetTag(nameOfProperty, value));
            }
            xmlBuilder.Append(XmlTag.CloseTagFor(nameOfClass));
            return xmlBuilder.ToString();
        }
    }
}