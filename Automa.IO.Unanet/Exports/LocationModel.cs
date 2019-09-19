﻿using ExcelTrans.Services;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Automa.IO.Unanet.Exports
{
    public class LocationModel : ModelBase
    {
        public string key { get; set; }
        //
        public string location { get; set; }
        public string active { get; set; }
        public string delete { get; set; }

        public static Task<bool> ExportFile(UnanetClient una, string sourceFolder)
        {
            var filePath = Path.Combine(sourceFolder, $"{una.Exports["location master"].Item2}.csv");
            if (File.Exists(filePath))
                File.Delete(filePath);
            return Task.Run(() => una.GetEntitiesByExport(una.Exports["location master"].Item1, f =>
            {
                f.Checked["suppressOutput"] = true;
            }, sourceFolder));
        }

        public static IEnumerable<LocationModel> Read(UnanetClient una, string sourceFolder)
        {
            var filePath = Path.Combine(sourceFolder, $"{una.Exports["location master"].Item2}.csv");
            using (var sr = File.OpenRead(filePath))
                return CsvReader.Read(sr, x => new LocationModel
                {
                    key = x[0],
                    //
                    location = x[1],
                    active = x[2],
                    delete = x[3],
                }, 1).ToList();
        }

        public static IEnumerable<LocationModel> EnsureAndRead(UnanetClient una, string sourceFolder)
        {
            var filePath = Path.Combine(sourceFolder, $"{una.Exports["location master"].Item2}.csv");
            if (!File.Exists(filePath))
                ExportFile(una, sourceFolder).Wait();
            return Read(una, sourceFolder);
        }
    }
}
