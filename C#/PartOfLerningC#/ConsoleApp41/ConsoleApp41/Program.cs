using System;

namespace ConsoleApp41
{
    
    
        class MathLib
        {
            public readonly double K = 23;  // можно так инициализировать

            public MathLib(double _k)
            {
                K = _k; // поле для чтения может быть инициализировано или изменено в конструкторе после компиляции
            }
            public void ChangeField()
            {
                // так нельзя
                //K = 34;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                MathLib mathLib = new MathLib(3.8);
                Console.WriteLine(mathLib.K); // 3.8

                //mathLib.K = 7.6; // поле для чтения нельзя установить вне своего класса
                Console.ReadLine();

            }
        }
    }
