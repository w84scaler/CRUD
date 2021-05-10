using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.IO;
using PluginInterface;

namespace oop1
{
    class PluginLoader
    {
        private readonly string pluginPath = Path.Combine(Directory.GetCurrentDirectory(), "Plugins");

        public List<IPlugin> RefreshPlugins()
        {
            List<IPlugin> PluginList = new List<IPlugin>();

            DirectoryInfo PluginDirectory = new DirectoryInfo(pluginPath);
            if (!PluginDirectory.Exists) PluginDirectory.Create();

            var PluginFiles = Directory.GetFiles(pluginPath, "*.dll");
            foreach (var file in PluginFiles)
            {
                Assembly asm = Assembly.LoadFrom(file);
                var types = asm.GetTypes().
                                Where(t => t.GetInterfaces().
                                Where(i => i.FullName == typeof(IPlugin).FullName).Any());

                foreach (var type in types)
                {
                    var plugin = asm.CreateInstance(type.FullName) as IPlugin;
                    PluginList.Add(plugin);
                }
            }
            return PluginList;
        }
    }
}