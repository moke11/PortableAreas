﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Compilation;

namespace MainApp.Infrastructure
{
    public class PluginAreaBootstrapper
    {
        public static readonly List<Assembly> PluginAssemblies = new List<Assembly>();

        public static List<string> PluginNames()
        {
            return PluginAssemblies
                .Select(pluginAssembly => pluginAssembly.GetName().Name)
                .ToList();
        }

        public static void Init()
        {
            var fullPluginPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Areas");

            if (!Directory.Exists(fullPluginPath))
            {
                Directory.CreateDirectory(fullPluginPath);
            }

            foreach (var file in Directory.EnumerateFiles(fullPluginPath, "*Plugin*.dll"))
            {
                PluginAssemblies.Add(Assembly.LoadFile(file));
            }

            PluginAssemblies.ForEach(BuildManager.AddReferencedAssembly);
        }
    }
}