﻿namespace PS.BearDiner.Application.Menus.Commands.CreateMenu
{
    public record CreateMenuCommand(
      string Name,
      string Description,
      List<MenuSectionCommand> Sections);

    public record MenuSectionCommand(
        string Name,
        string Description,
        List<MenuItemCommand> Items);

    public record MenuItemCommand(
        string Name,
        string Description);
}