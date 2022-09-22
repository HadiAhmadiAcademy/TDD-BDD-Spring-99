using System;
using ValueTransformation.Framework.Attributes;

namespace ValueTransformation.Framework.ValueTransformers
{
    public static class ValueTransformerFactory
    {
        public static IValueTransformer Create(TransformAttribute attribute)
        {
            //TODO:refactor this
            if (attribute.Type == TransformType.Email) return new EmailTransformer();
            if (attribute.Type == TransformType.String) return new StringTransformer();
            if (attribute.Type == TransformType.FixedLengthString) return new FixedLengthStringTransformer();
            throw new NotSupportedException();
        }
    }
}