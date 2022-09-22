using System;

namespace ValueTransformation.Framework.Attributes
{
    public class TransformAttribute : Attribute
    {
        public TransformType Type { get; }
        public TransformAttribute(TransformType type = TransformType.String)
        {
            Type = type;
        }
    }
}