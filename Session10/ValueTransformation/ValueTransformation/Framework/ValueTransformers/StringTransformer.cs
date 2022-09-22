using System;

namespace ValueTransformation.Framework.ValueTransformers
{
    public class StringTransformer : IValueTransformer
    {
        public string Transform(string input)
        {
            return $"{input}+{Guid.NewGuid()}";
        }
    }
}