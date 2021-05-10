using System.IO;
using System.IO.Compression;
using PluginInterface;

namespace Plugins
{
    [Plugin(Name = "deflate", Extension = "defl")]
    public class DeflateCompressor : IPlugin
    {
        public void Compress(byte[] data, string FilePath)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(data, 0, data.Length);
            using (FileStream fs = new FileStream(FilePath, FileMode.Create))
            {
                using (DeflateStream ds = new DeflateStream(fs, CompressionMode.Compress))
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
                using (DeflateStream ds = new DeflateStream(fs, CompressionMode.Decompress))
                {
                    ds.CopyTo(ms);
                }
            }
            byte[] Data = ms.ToArray();
            return Data;
        }
    }
}