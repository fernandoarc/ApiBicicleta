namespace Domain.Brands.Exceptions
{
    public class MinLengthNameException : Exception
    {
        public override string Message
        {
            get
            {
                return $"El nombre no cumple con la cantidad minima de caracteres";
            }
        }
    }
}
