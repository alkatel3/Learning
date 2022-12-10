using MNIST.IO;

namespace Graph
{
    public class MnistData
    {
        public static List<TestCase> Data = FileReaderMNIST.LoadImagesAndLables(
                "t10k-labels-idx1-ubyte.gz",
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
    }
}
