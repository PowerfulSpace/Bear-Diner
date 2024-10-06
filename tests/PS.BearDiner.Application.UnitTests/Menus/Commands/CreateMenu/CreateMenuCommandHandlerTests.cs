using FluentAssertions;
using Moq;
using PS.BearDiner.Application.Common.Interfaces.Persistence;
using PS.BearDiner.Application.Menus.Commands.CreateMenu;
using PS.BearDiner.Application.UnitTests.Menus.Commands.TestUtils;

namespace PS.BearDiner.Application.UnitTests.Menus.Commands.CreateMenu
{
    public class CreateMenuCommandHandlerTests
    {
        private readonly CreateMenuCommandHandler _handler;
        private readonly Mock<IMenuRepository> _mockMenuRepository;

        public CreateMenuCommandHandlerTests()
        {
            _mockMenuRepository = new Mock<IMenuRepository>();
            _handler = new CreateMenuCommandHandler(_mockMenuRepository);
        }

        public async Task CreateMenuCommandHandler_WhenMenuIsValid_ShouldCreateAndReturnMenu()
        {
            //Arrange
            var CreateMenuCommand = CreateMenuCommandUtils.CreateCommand();

            //Act
            var result = await _handler.Handle(CreateMenuCommand, default);

            //Assert
            result.IsError.Should().BeFalse();

            result.Value.ValidateCreatedFrom(CreateMenuCommand);
        }
    }
}