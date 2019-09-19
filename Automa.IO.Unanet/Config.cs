﻿using System;
using System.Collections.Generic;

namespace Automa.IO.Unanet
{
    internal class Config
    {
        #region Exports

        public readonly static Dictionary<string, Tuple<string, string>> ExportsSandbox = new Dictionary<string, Tuple<string, string>>
        {
            // Lookup
            { "location master", new Tuple<string, string>("742", "DEG_ Location - Master") },
            { "labor category master", new Tuple<string, string>("743", "DEG_ Labor Category - Master") },
            { "vendor profile", new Tuple<string, string>("741", "DEG_ Vendor Profile") },

            // Organization
            { "organization", new Tuple<string, string>("733", "DEG_ Organization") },
            { "customer profile", new Tuple<string, string>("734", "DEG_ Customer Profile") },
            { "organization address", new Tuple<string, string>("735", "DEG_ Organization Address") },
            { "organization contact", new Tuple<string, string>("736", "DEG_ Organization Contact") },

            // Project
            { "project", new Tuple<string, string>("728", "DEG_ Project") },
            { "task", new Tuple<string, string>("729", "DEG_ Task") },
            { "fixed price item", new Tuple<string, string>("0", "DEG_ Fixed Price Item") },
            { "fixed price item [post]", new Tuple<string, string>("732", "DEG_ Fixed Price Item [post]") },
            { "assignment", new Tuple<string, string>("737", "DEG_ Assignment") },
            { "project administrator", new Tuple<string, string>("738", "DEG_ Project Administrators") },
            { "labor category project", new Tuple<string, string>("0", "DEG_ Labor Category - Project") },

            // Person
            { "person", new Tuple<string, string>("730", "DEG_ Person") },
            { "approval group", new Tuple<string, string>("739", "DEG_ Approval Group") },

            // Time/Invoice
            { "time", new Tuple<string, string>("731", "DEG_ Time") },
            { "invoice", new Tuple<string, string>("0", "DEG_ Invoice Export") },
        };

        public readonly static Dictionary<string, Tuple<string, string>> Exports = new Dictionary<string, Tuple<string, string>>
        {
            // Lookup
            { "location master", new Tuple<string, string>("818", "DEG_ Location - Master") }, //new
            { "labor category master", new Tuple<string, string>("814", "DEG_ Labor Category - Master") }, //new
            //{ "vendor profile", new Tuple<string, string>("741", "DEG_ Vendor Profile") },
            //
            { "organization", new Tuple<string, string>("734", "DEG_ Organization") },
            { "customer profile", new Tuple<string, string>("751", "Customer Profile") }, //base
            { "organization address", new Tuple<string, string>("770", "Organization Address") }, //base
            { "organization contact", new Tuple<string, string>("771", "Organization Contact") }, //base

            // Project
            { "project", new Tuple<string, string>("810", "DEG_ Project") }, //new
            { "task", new Tuple<string, string>("820", "DEG_ Task") }, //new
            { "fixed price item", new Tuple<string, string>("795", "DEG_ Fixed Price Item") },
            { "fixed price item [post]", new Tuple<string, string>("733", "DEG_ Fixed Price Item [post]") },
            { "assignment", new Tuple<string, string>("812", "DEG_ Assignment") }, //new
            { "project administrator", new Tuple<string, string>("780", "Project Administrators") }, //base
            { "labor category project", new Tuple<string, string>("817", "DEG_ Labor Category - Project") }, //new

            // Person
            { "person", new Tuple<string, string>("811", "DEG_ Person") }, //new
            { "approval group", new Tuple<string, string>("748", "Approval Group") }, //base

            // Time/Invoice
            { "time", new Tuple<string, string>("819", "DEG_ Time") }, //new
            { "invoice", new Tuple<string, string>("724", "Invoice Export") }, //base
        };

        #endregion

        #region Imports

        public readonly static Dictionary<string, string> Imports = new Dictionary<string, string>
        {
            { "credit card - generic", "GenericCreditCardImport" },
        };

        #endregion
    }
}

//static Dictionary<string, string> _set = new Dictionary<string, string>();
//static XAttribute XAttribute(string name, string value) { Console.WriteLine(name); _set.Add(name, ""); var r = !string.IsNullOrEmpty(value) ? new XAttribute(name, value) : null; return r; }
//static XAttribute XAttribute<T>(string name, T? value) where T : struct { Console.WriteLine(name); _set.Add(name, ""); var r = value != null ? new XAttribute(name, value) : null; return r; }
