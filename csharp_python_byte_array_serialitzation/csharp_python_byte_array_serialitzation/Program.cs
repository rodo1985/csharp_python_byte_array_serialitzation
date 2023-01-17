using System;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace csharp_python_byte_array_serialitzation
{
    class Program
    {
        static void Main(string[] args)
        {
            // image size
            int image_width = 2248;
            int image_height = 2248;
            int channels = 3;
            int size = image_width * image_height * channels;

            // create byte array
            byte[] byteArray = Enumerable.Range(0, size).Select(x => (byte)x).ToArray();

            // save time.now
            DateTime startTime = DateTime.Now;
            
            // serialize data
            using (var ms = new MemoryStream())
            {
                new BinaryFormatter().Serialize(ms, byteArray);
                File.WriteAllBytes("byteArray.data", ms.ToArray());
            }

            Console.WriteLine((DateTime.Now - startTime).Milliseconds + " ms");
            
        }
    }
}
