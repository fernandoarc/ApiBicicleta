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
            VerifyEmptyName();
            VerifyMinLengthName();
            VerifyMaxLengthName();
        }

        private void VerifyEmptyName()
        {
            if (Name is null || Name == string.Empty)
                throw new EmptyNameException();
        }
        private void VerifyMinLengthName()
        {
            if (Name is null || Name == string.Empty)
                throw new MinLengthNameException();
        }
        private void VerifyMaxLengthName()
        {
            if (Name is null || Name == string.Empty)
                throw new MaxLengthNameException();
        }
    }
}
