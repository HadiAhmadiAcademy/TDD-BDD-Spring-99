namespace ValueTransformation.Framework.ValueTransformers
{
    public class EmailTransformer : IValueTransformer
    {
        public string Transform(string input)
        {
            return Faker.Internet.Email();
        }
    }
}