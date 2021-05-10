using System;

namespace PluginInterface
{
    public class PluginAttribute : Attribute
    {
        public string Name;
        public string Extension;
    }
    public interface IPlugin
    {
        void Compress(byte[] data, string FilePath);
        byte[] Decompress(string FilePath);
    }
}