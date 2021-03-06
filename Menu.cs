using System;
using System.Collections.Generic;
using System.Linq;
using Лаб1.MenuItem;
using Лаб1.MenuItems;

namespace Лаб1
{
    public class Menu
    {
        private static List<MenuItemCore> MenuItems = new List<MenuItemCore>();

        public static int ItemsCount
        {
            get
            {
                return MenuItems.Count();
            }
        }

        public static void ClearItems()
        {
            Menu.MenuItems.Clear();
        }

        public static void AddItem(MenuItemCore menuItem)
        {
            Menu.MenuItems.Add(menuItem);
        }

        public static void AddItem(string title, MenuItemWDelegate.ExecuteHandler handler)
        {
            Menu.MenuItems.Add(new MenuItemWDelegate(title, handler));
        }

        public static void Execute()
        {
            int iMenu = IOUtils.SafeReadInteger("mi", null) - 1;
            if (iMenu >= 0 && iMenu < Menu.MenuItems.Count)
            {
                Menu.MenuItems.ToArray()[iMenu].Execute();
            }
            else
            {
                Console.WriteLine("Menu item not found.");
            }
        }
        public static void ShowMenu()
        {
            Console.WriteLine("=== MENU ===");

            int iMenuItem = 1;
            foreach (MenuItemCore menuItem in Menu.MenuItems)
            {
                Console.WriteLine("{0}: {1}", iMenuItem++, menuItem.Title);
            }
        }
    }
}
