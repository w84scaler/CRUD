using System.IO;
using System.IO.Compression;
using PluginInterface;

namespace Plugins
{
    [Plugin(Name = "gzip", Extension = "gzip")]
    public class GZipCompressor : IPlugin
    {
        public void Compress(byte[] data, string FilePath)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(data, 0, data.Length);
            using (FileStream fs = new FileStream(FilePath, FileMode.Create))
            {
                using (GZipStream ds = new GZipStream(fs, CompressionMode.Compress))
                {
                    ms.Position = 0;
                    ms.CopyTo(ds);
                }
            }
        }

        public byte[] Decompress(string FilePath)
        {
            MemoryStream ms = new MemoryStream();
            using (FileStream fs = new FileStream(FilePath, FileMode.Open))
            {
                using (GZipStream ds = new GZipStream(fs, CompressionMode.Decompress))
                {
                    ds.CopyTo(ms);
                }
            }
            byte[] Data = ms.ToArray();
            return Data;
        }
    }
}