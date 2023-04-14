using OOPSPrograms.InventoryDataManagement;
using System;
namespace OOPSPrograms
{
    class Program
    {
        static string jsonFilePath = @"C:\Users\Basha\Documents\BridgeLabz\Object_Oriented_Programs\OOPSPrograms\InventoryDataManagement\Inventory.json";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the OOPS Programs");
            InventoryDetailManagement inventory = new InventoryDetailManagement();
            inventory.ReadJSONFile(jsonFilePath);
        }
    }
}