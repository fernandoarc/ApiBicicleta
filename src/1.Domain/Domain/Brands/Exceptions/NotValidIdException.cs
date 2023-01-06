namespace Domain.Brands.Exceptions
{
    public class NotValidIdException : Exception
    {
        public override string Message
        {
            get
            {
                return $"El id debe ser mayor a 0 (cero)";
            }
        }
    }
}
