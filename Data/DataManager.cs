using ClientFlowCRM.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientFlowCRM.Data
{
    public static class DataManager
    {
        private static readonly string FilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "ClientFlowCRM",
            "clients.json"
        );

        public static bool SaveData(List<Client> clients)
        {
            try
            {
                string directory = Path.GetDirectoryName(FilePath);
                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                var settings = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    TypeNameHandling = TypeNameHandling.Auto
                };

                string json = JsonConvert.SerializeObject(clients, settings);
                File.WriteAllText(FilePath, json);

                if (File.Exists(FilePath))
                {
                    string savedContent = File.ReadAllText(FilePath);
                    System.Diagnostics.Debug.WriteLine($"Saved {clients.Count} clients, file size: {savedContent.Length}");
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Save error: {ex.Message}");
                return false;
            }
        }

        public static List<Client> LoadData()
        {
            try
            {
                if (!File.Exists(FilePath))
                {
                    System.Diagnostics.Debug.WriteLine("No save file found");
                    return new List<Client>();
                }

                string json = File.ReadAllText(FilePath);
                System.Diagnostics.Debug.WriteLine($"Loading file, size: {json.Length}");

                var settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto
                };

                var clients = JsonConvert.DeserializeObject<List<Client>>(json, settings);
                System.Diagnostics.Debug.WriteLine($"Loaded {clients?.Count ?? 0} clients");

                return clients ?? new List<Client>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Load error: {ex.Message}");
                return new List<Client>();
            }
        }

        public static bool ExportToCSV(List<Client> clients, string filePath)
        {
            try
            {
                using (var writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("ID,Name,Email,Phone,Company,Source,Score,Temperature,DealValue,Interactions");
                    foreach (var c in clients)
                    {
                        writer.WriteLine($"{c.Id},{c.Name},{c.Email},{c.Phone},{c.Company},{c.Source},{c.Score},{c.Temperature},{c.TotalDealValue},{c.InteractionCount}");
                    }
                }
                return true;
            }
            catch { return false; }
        }
    }
}