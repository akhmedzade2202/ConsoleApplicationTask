using ConsoleApplication.Services.Interfaces;
using ConsoleApplication1.Models;
using ConsoleApplication1.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApplication1.Services
{
    public class DatabaseService : IDatabaseService
    {
        private readonly string _path;

        public DatabaseService()
        {
            string projectRoot = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            string folder = Path.Combine(projectRoot, "Database");

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            _path = Path.Combine(folder, "db.json");

            if (!File.Exists(_path))
                File.WriteAllText(_path, "[]");

            Console.WriteLine($"DB fayl yeri: {_path}");
        }

        public List<Classroom> Load()
        {
            string json = File.ReadAllText(_path);
            var data = JsonConvert.DeserializeObject<List<Classroom>>(json);
            return data ?? new List<Classroom>();
        }

        public void Save(List<Classroom> data)
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(_path, json);
        }
    }
}
