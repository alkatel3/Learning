class Program {
    public static void Main(String[] args)
    {
        Byte[] data = new Byte[100];

        string[] files = { "../../../Program.cs",
                 "../../../AsyncWaitClass.csproj",
                 "AsyncWaitClass.dll",
                 "AsyncWaitClass.pdb"
        };
        AsyncReader[] ascArr = new AsyncReader[4];
        for (int i = 0; i < files.Length; i++)
        {
            ascArr[i] = new(
                new FileStream(
                    files[i],
                    FileMode.Open,
                    FileAccess.Read,
                    FileShare.Read,
                    1024,
                    FileOptions.Asynchronous),
                1000);
        }
        Console.WriteLine("Main thread ID = {0}",
            Thread.CurrentThread.ManagedThreadId);
        FileStream fs = new FileStream(
            files[0],
            FileMode.Open,
            FileAccess.Read,
            FileShare.Read,
            1024,
            FileOptions.Asynchronous);

        fs.BeginRead(data,
            0,
            data.Length,
            delegate (IAsyncResult ar)
            {
                Console.WriteLine("Reading in thread {0} finished", Thread.CurrentThread.ManagedThreadId);

                int byteRead = fs.EndRead(ar);
                fs.Close();
                Console.WriteLine("Count of read bytes = {0}", byteRead);
                Console.WriteLine(System.Text.Encoding.UTF8.GetString(data).Remove(0, 1));
            },
            null);

        foreach (AsyncReader ast in ascArr)
        {
            while (ast == ascArr[0] && !ast.asRes.IsCompleted)
            {
                Console.WriteLine("Operation isn't done,wait");
                Thread.Sleep(10);
            }
            while (ast == ascArr[1] && !ast.asRes.AsyncWaitHandle.WaitOne(10, false))
            {
                Console.WriteLine("Operation isn't done,wait");
            }
            Console.WriteLine(ast.EndRead());
        }
    }
}
public class AsyncReader
{
    FileStream Stream;
    byte[] data;
    public IAsyncResult asRes;

    public AsyncReader(FileStream stream, int size)
    {
        Stream = stream;
        data = new byte[size];
        asRes = stream.BeginRead(
            data,
            0,
            size,
            null,
            null);
    }
    public String EndRead() 
    {
        int countByte = Stream.EndRead(asRes);
        Stream.Close();
        return string.Format("File: {0}\n{1}\n\n",
            Stream.Name,
            System.Text.Encoding.Default.GetString(data));
            }
}
