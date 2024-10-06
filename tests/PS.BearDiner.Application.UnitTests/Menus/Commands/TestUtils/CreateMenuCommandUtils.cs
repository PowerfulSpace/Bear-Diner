
using PS.BearDiner.Application.Menus.Commands.CreateMenu;
using PS.BearDiner.Application.UnitTests.TestUtils.Constants;

namespace PS.BearDiner.Application.UnitTests.Menus.Commands.TestUtils
{
    public class CreateMenuCommandUtils
    {
        public static CreateMenuCommand CreateCommand() =>
            new CreateMenuCommand(
                Guid.Parse(Constants.Host.Id.ToString()!),
                Constants.Menu.Name,
                Constants.Menu.Description,
                CreateSectionsCommand());

        public static List<CreateMenuSectionCommand> CreateSectionsCommand(int sectionCount = 1) =>
            Enumerable.Range(0, sectionCount)
                .Select(index => new CreateMenuSectionCommand(
                    Constants.Menu.SectionNameFromIndex(index),
                    Constants.Menu.SectionDescriptionFromIndex(index),
                    CreateItemsCommand()))
                .ToList();

        public static List<CreateMenuItemCommand> CreateItemsCommand(int itemCount = 1) =>
            Enumerable.Range(0, itemCount)
                .Select(index => new CreateMenuItemCommand(
                    Constants.Menu.ItemNameFromIndex(index),
                    Constants.Menu.ItemDescriptionFromIndex(index)))
                .ToList();
    }
}
