
using System.IO.Compression;

namespace Graph
{
    public class MnistData
    {
        public static List<TestCase> Data = LoadImagesAndLables(
                "C:/Users/Dell/OneDrive/Рабочий стол/Studying/Other/Learning/Learning/C#/DataStructures/Graph/Graph/bin/Debug/net6.0/t10k-labels-idx1-ubyte.gz",
                "t10k-images-idx3-ubyte.gz").ToList();

        public static string ToStringImage(byte[,] pixels)
        {
            string s = "";
            for (int i = 0; i < 28; ++i)
            {
                for (int j = 0; j < 28; ++j)
                {
                    if (pixels[i, j] == 0)
                        s += " "; // white
                    else if (pixels[i, j] == 255)
                        s += "O"; // black
                    else
                        s += "."; // gray
                }
                s += "\n";
            }
            return s;
        }


        public static IEnumerable<TestCase> LoadImagesAndLables(string labelFile, string imageFile)
        {
            byte[] labels = LoadLabel(labelFile);
            IEnumerable<byte[,]> enumerable = LoadImages(imageFile);
            int cc = 0;
            foreach (byte[,] item in enumerable)
            {
                yield return new TestCase
                {
                    Label = labels[cc],
                    Image = item
                };
                cc++;
            }
        }

        public static IEnumerable<byte[,]> LoadImages(string imageFile)
        {
            using FileStream raw = File.OpenRead(imageFile);
            using GZipStream gz = new GZipStream(raw, CompressionMode.Decompress);
            using BinaryReaderMSB reader = new BinaryReaderMSB(gz);
            int num = reader.ReadInt32MSB();
            if (num != 2051)
            {
                throw new InvalidDataException(num.ToString("x"));
            }

            int itemCount = reader.ReadInt32MSB();
            int rowCount = reader.ReadInt32MSB();
            int colCount = reader.ReadInt32MSB();
            for (int i = 0; i < itemCount; i++)
            {
                byte[,] array = new byte[rowCount, colCount];
                for (int j = 0; j < rowCount; j++)
                {
                    for (int k = 0; k < colCount; k++)
                    {
                        array[j, k] = reader.ReadByte();
                    }
                }

                yield return array;
            }
        }

        public static byte[] LoadLabel(string labelFile)
        {
            using FileStream stream = File.OpenRead(labelFile);
            using GZipStream stream2 = new GZipStream(stream, CompressionMode.Decompress);
            using BinaryReaderMSB binaryReaderMSB = new BinaryReaderMSB(stream2);
            int num = binaryReaderMSB.ReadInt32MSB();
            if (num != 2049)
            {
                throw new InvalidDataException(num.ToString("x"));
            }

            int count = binaryReaderMSB.ReadInt32MSB();
            return binaryReaderMSB.ReadBytes(count);
        }
    }

    public class TestCase
    {
        public byte Label { get; set; }

        public byte[,] Image { get; set; }

        public double[,] AsDouble()
        {
            double[,] array = new double[Image.GetLength(0), Image.GetLength(1)];
            for (int i = 0; i < Image.GetLength(0); i++)
            {
                for (int j = 0; j < Image.GetLength(1); j++)
                {
                    array[i, j] = (double)(int)Image[i, j] / 256.0;
                }
            }

            return array;
        }
    }

    public class BinaryReaderMSB : BinaryReader
    {
        public BinaryReaderMSB(Stream stream)
            : base(stream)
        {
        }

        public int ReadInt32MSB()
        {
            byte[] array = ReadBytes(4);
            Array.Reverse((Array)array);
            return BitConverter.ToInt32(array, 0);
        }
    }
}
