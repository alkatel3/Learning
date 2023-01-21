using System;

namespace DotNetDesignPatternDemos.Solid
{
    public class Document
    {

    }
    public interface IMachine
    {
        void Print(Document d);
        void Fax(Document d);
        void Scan(Document d);
    }
    public class MultuFunctionPrinter : IMachine
    {
        public void Fax(Document d)
        {
            //
        }

        public void Print(Document d)
        {
            //
        }

        public void Scan(Document d)
        {
            //
        }
    }
    public class OldFunctionPrinter : IMachine
    {
        public void Fax(Document d)
        {
            //
        }

        public void Print(Document d)
        {
            //
        }

        public void Scan(Document d)
        {
            //
        }
    }
    public interface IPrinter
    {
        void Print(Document d);
    }
    public interface IScanner
    {
        void Scan(Document d);
    }
    public class PhotoCopier : IPrinter, IScanner
    {
        public void Print(Document d)
        {
            //
        }

        public void Scan(Document d)
        {
            //
        }
    }
    public interface IMultiFunctionDevice:IPrinter, IScanner
    {
        //IFax
    }
    public class MulriFunctionMAchine : IMultiFunctionDevice
    {
        private IPrinter Printer;
        private IScanner Scanner;

        public MulriFunctionMAchine(IPrinter printer, IScanner scanner)
        {
            Printer = printer;
            Scanner = scanner;
        }

        public void Print(Document d)
        {
            Printer.Print(d);
        }

        public void Scan(Document d)
        {
            Scanner.Scan(d);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
