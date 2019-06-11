using BeerTrade.ViewModels;
using System.Threading.Tasks;
using FsCheck;
using FsCheck.Xunit;
using Xunit;

namespace BeerTrade.Tests
{
    public sealed class MainViewModelTests
    {
        public sealed class TheSumMethod
        {
            [Fact]
            public async Task AddsTwoToTheValueProvided1()
            {
                // Arrange
                var viewModel = new MainPageViewModel();
                const int value = 1;
                const int expectedValue = 3;

                // Act
                var result = await viewModel.AddTwoUsingEveryLastBitOfComputerPower(value);

                // Assert
                Assert.Equal(result, expectedValue);
            }

            [Theory]
            [InlineData(1)]
            [InlineData(2)]
            [InlineData(3)]
            [InlineData(4)]
            public async Task AddsTwoToTheValueProvided2(int value)
            {
                // Arrange
                var viewModel = new MainPageViewModel();
                var expectedValue = value + 2;

                // Act
                var result = await viewModel.AddTwoUsingEveryLastBitOfComputerPower(value);

                // Assert
                Assert.Equal(result, expectedValue);
            }

            [Property]
            public void AddsTwoToTheValueProvided3(NonZeroInt value)
            {
                // Arrange
                var expectedValue = value.Get + 2;
                var viewModel = new MainPageViewModel();

                // Act
                var result = viewModel
                    .AddTwoUsingEveryLastBitOfComputerPower(value.Get)
                    .GetAwaiter()
                    .GetResult();

                // Assert
                Assert.Equal(result, expectedValue);
            }
        }
    }
}
