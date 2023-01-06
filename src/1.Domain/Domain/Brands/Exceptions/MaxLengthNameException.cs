namespace Domain.Brands.Exceptions
{
    public class MaxLengthNameException : Exception
    {
        public override string Message
        {
            get
            {
                return $"Se ha superado la cantidad maxima de caracteres permitido";
            }
        }
    }
}
