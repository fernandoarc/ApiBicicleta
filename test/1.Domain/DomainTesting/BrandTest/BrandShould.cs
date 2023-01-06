using Domain.Brands.Exceptions;

namespace DomainTesting.BrandTest
{
    public class BrandShould
    {
        [Fact]
        public void Create_DataValid_ReturnNewBrand()
        {
            // Arrange
            int id = 1;
            string name = "Trek";

            // Act
            var brand = new Brand(id, name);

            // Assert
            Assert.NotNull(brand);
        }

        [Fact]
        public void Create_IdZero_ReturnException()
        {
            // Arrange
            int id = 0;
            string name = "Trek";
            var expectedErrorMessage = new NotValidIdException().Message;

            // Act
            var ex = Assert.Throws<NotValidIdException>(() => new Brand(id, name));

            // Assert
            Assert.Equal(expectedErrorMessage, ex.Message);
        }

        [Fact]
        public void Create_NameEmpty_ReturnException()
        {
            // Arrange
            int id = 1;
            string name = "";
            var expectedErrorMessage = new EmptyNameException().Message;

            // Act
            var ex = Assert.Throws<EmptyNameException>(() => new Brand(id, name));

            // Assert
            Assert.Equal(expectedErrorMessage, ex.Message);
        }

        [Fact]
        public void Create_NameMinLength_ReturnException()
        {
            // Arrange
            int id = 1;
            string name = "ss";
            var expectedErrorMessage = new MinLengthNameException().Message;

            // Act
            var ex = Assert.Throws<MinLengthNameException>(() => new Brand(id, name));

            // Assert
            Assert.Equal(expectedErrorMessage, ex.Message);
        }
        [Fact]
        public void Create_NameMaxLength_ReturnException()
        {
            // Arrange
            int id = 1;
            string name = "sssssssssssssssssssssssssssssssssssssssssssssssssss";
            var expectedErrorMessage = new MaxLengthNameException().Message;

            // Act
            var ex = Assert.Throws<MaxLengthNameException>(() => new Brand(id, name));

            // Assert
            Assert.Equal(expectedErrorMessage, ex.Message);
        }
    }
}
