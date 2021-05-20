using System;
using Лаб1.MenuItem;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Лаб1.MenuItems;

namespace Лаб1
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, string> argsDic = CmdArgsParser.Parse(args);
            IOUtils.SetExtValues(argsDic);

            Menu.ClearItems();
            Menu.AddItem(new MenuItemExit());
            Menu.AddItem("Hello world!", PrintHelloWorld);
            Menu.AddItem(new MenuItemCalc());
            Menu.AddItem(new MenuItemDate());
            Menu.AddItem(new MenuItemSafeIntReading());

            if (argsDic != null)
            {
                try
                {
                    Menu.Execute();
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                }
            }
            else
            {
                while (true)
                {
                    Menu.ShowMenu();
                    Menu.Execute();
                }
            }
        }

        public static void PrintHelloWorld()
        {
            Console.WriteLine("Hello world!");
        }
    }


    struct Point
    {
        int X;
        int Y;
    }

    interface IList
    {
        int Count { get; }
        void AddItem();
        void Clear();
    }
}


 
