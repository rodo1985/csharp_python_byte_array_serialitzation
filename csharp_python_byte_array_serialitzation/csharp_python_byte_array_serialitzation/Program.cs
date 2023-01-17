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
            // var to set the process we want to test
            bool serialize = false;

            if (serialize)
            {
                // image size
                int image_width = 2448;
                int image_height = 2048;
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
            else
            {
                // save time.now
                DateTime startTime = DateTime.Now;

                // to get rectangle values serialized from python code
                float[] rect = new float[4];

                using (BinaryReader binary_reader = new BinaryReader(File.Open("byteArray.data", FileMode.Open)))
                {
                    for (int i = 0; i < rect.Length; i++)
                    {
                        rect[i] = binary_reader.ReadSingle();
                    }
                }

                Console.WriteLine((DateTime.Now - startTime).Milliseconds + " ms");
            }
            
        }
    }
}
