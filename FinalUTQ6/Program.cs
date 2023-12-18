using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Newtonsoft.Json;

namespace FinalUTQ6
{
    // PlayerSettingsList: Start identifying what's in the players settings
    public class PlayerSettingsList
    {
        // player name is a string
        public string PlayerName { get; set; }

        // level
        public int Level { get; set; }

        // HP level
        public int HP { get; set; }

        // inventory will be a list
        public List<string> Inventory { get; set; }
    
        // license key is a string, ID 
        public string LicenseKey { get; set; }
    }

    // Save / load settings in ManageSettings
    public class ManageSettings
    {
        private static ManageSettings setting;

        // set the file name for the hard-drive file
        private const string nameFile = "c:\\templates\\FinalUT.json";
       

        private ManageSettings() { }

        // Instance of the manage settings
        public static ManageSettings Instance
        {
            get
            {
                if (setting == null)
                {
                    setting = new ManageSettings();
                }
                return setting;
            }
        }

        // Load Settings: read the json file with the settings info, then deserialize
        public PlayerSettingsList LoadSettings()
        {
                string jsonFile = File.ReadAllText(nameFile);
                return JsonConvert.DeserializeObject<PlayerSettingsList>(jsonFile); 
        }

        // Save Settings: serialize the settings entered, then write those changes into the file 
        public void SaveSettings(PlayerSettingsList settings)
        {
            string json = JsonConvert.SerializeObject(settings);
            File.WriteAllText(nameFile, json);
        }
    }

    // Program: contains Main
    internal class Program
    {
        // Main: load, modify & display settings
        static void Main(string[] args)
        {
            
            ManageSettings settingsManage = ManageSettings.Instance;

            // Load player settings
            PlayerSettingsList playerSettings = settingsManage.LoadSettings();

            // Display the settings 
            Console.WriteLine("Settings -- ");
            Console.WriteLine("Player Name: " + playerSettings.PlayerName);
            Console.WriteLine("Level: " + playerSettings.Level);
            Console.WriteLine("HP: " + playerSettings.HP);
            Console.WriteLine("Inventory:");

            // for each thing in the inventory, list it
            foreach (var item in playerSettings.Inventory)
            {
                Console.WriteLine(" - " + item);
            }

            // Display license key
            Console.WriteLine("License Key: " + playerSettings.LicenseKey);

            // Modify settings - increase player settings level, lose HP, add inventory
            playerSettings.Level++;
            playerSettings.HP += 5;
            playerSettings.Inventory.Add("This is a new item");

            // Save
            settingsManage.SaveSettings(playerSettings);

        }
    }
}
