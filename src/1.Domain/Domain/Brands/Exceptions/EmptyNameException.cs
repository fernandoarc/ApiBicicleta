namespace Domain.Brands.Exceptions
{
    public class EmptyNameException : Exception
    {
        public override string Message
        {
            get
            {
                return $"El campo nombre no puede ser nulo";
            }
        }
    }
}
