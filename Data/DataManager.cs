using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Newtonsoft.Json;
using ClientFlowCRM.Models;

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

                string json = JsonConvert.SerializeObject(clients, Formatting.Indented);
                File.WriteAllText(FilePath, json);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<Client> LoadData()
        {
            try
            {
                if (!File.Exists(FilePath))
                    return new List<Client>();

                string json = File.ReadAllText(FilePath);
                return JsonConvert.DeserializeObject<List<Client>>(json) ?? new List<Client>();
            }
            catch
            {
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