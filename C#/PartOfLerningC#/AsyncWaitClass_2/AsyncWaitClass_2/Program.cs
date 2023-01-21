namespace AsyncWaitClass_2
{
    internal class Program
    {
        private static byte[] staticData = new byte[100]; 
        static void Main(string[] args)
        {
            string[] files =
            {
                "../../../Program.cs",
                "../../../AsyncWaitClass_2.csproj",
                "AsyncWaitClass_2.dll"
            };
            for(int i = 0; i < files.Length; i++)
            {
                new AsyncCallBackReader(new FileStream(files[i], FileMode.Open, FileAccess.Read, FileShare.Read, 1024, FileOptions.Asynchronous),
                    100,
                    delegate (byte[] data)
                    {
                        Console.WriteLine("Count of read byte = {0}", data.Length);
                        Console.WriteLine(System.Text.Encoding.UTF8.GetString(data) + "\n\n");
                    });
                Console.ReadLine();
            }
        }
    }
    public delegate void AsyncBytesReaderDel(byte[] streamData);

    class AsyncCallBackReader
    {
        FileStream stream;
        byte[] data;
        IAsyncResult AsyncResult;
        AsyncBytesReaderDel callbackMethod;

        public AsyncCallBackReader(FileStream s, int size, AsyncBytesReaderDel meth)
        {
            stream =s;
            data= new byte[size];
            callbackMethod = meth;
            AsyncResult = s.BeginRead(data, 0, size, ReadIsComplete, null);
        }
        public void ReadIsComplete(IAsyncResult asyncResult)
        {
            int countByte = stream.EndRead(asyncResult);
            stream.Close();
            callbackMethod(data);
        }
    }
}