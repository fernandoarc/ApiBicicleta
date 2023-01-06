using Domain.Brands.Exceptions;

namespace Domain.Brands
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;

        public Brand(int id, string name)
        {
            Id = id;
            Name = name;
            VerifyNotValidId();
            VerifyEmptyName();
            VerifyMinLengthName();
            VerifyMaxLengthName();
        }

        private void VerifyNotValidId()
        {
            if (Id <= 0)
                throw new NotValidIdException();
        }
        private void VerifyEmptyName()
        {
            if (Name is null || Name == string.Empty)
                throw new EmptyNameException();
        }
        private void VerifyMinLengthName()
        {
            if (Name.Length < 3)
                throw new MinLengthNameException();
        }
        private void VerifyMaxLengthName()
        {
            if (Name.Length > 50)
                throw new MaxLengthNameException();
        }
    }
}
