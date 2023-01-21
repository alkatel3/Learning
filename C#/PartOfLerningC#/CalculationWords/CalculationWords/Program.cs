using System;
using System.Collections.Generic;

namespace CalculationWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text");
            string text = @"Создать примитивный англо-русский и русско-английский словарь, содержащий пары слов — названий 
                            стран на русском и английском языках. Пользователь
                            должен иметь возможность выбирать направление перевода и запрашивать перевод.
                            Создать необобщенный класс точки в трехмерном
                            пространстве с целочисленными координатами(Point3D), 
                            который наследуется от generic-класса Point2D<T>, рассмотренного в уроке.Реализовать в классе:
                            ■ конструктор с параметрами, который принимает начальные значения для координат точки
                            ■ метод ToString()
                            Создать обобщенный класс прямой на плоскости. В
                            классе предусмотреть 2 поля типа обобщенной точки — 
                            точки, через которые проходит прямая. Реализовать
                            в классе:
                            ■ конструктор, который принимает 2 точки
                            ■ конструктор, которые принимает 4 координаты(x и у
                            координаты для первой и второй точки)
                            ■ метод ToString()
                            Подсчитать, сколько раз каждое слово встречается в заданном тексте. Результат записать в коллекцию
                            Dictionary < TKey, TValue >";
            text.ToLower();
            var words=text.Split(' ', '\n');
            List<string> wordsList=new();
            for (var i=0;i<words.Length;i++)
            {
                words[i].Trim();
                Console.WriteLine(words[i]);
                wordsList.Add(words[i]);
            }
            Dictionary<string, int> CountOfWords = new();
            for(int i = 0; i < wordsList.Count; i++)
            {
                int count = 1;
                var word = wordsList[i];
                wordsList.RemoveAt(i);
                for(int j = 0; j < wordsList.Count; j++)
                {
                    if (wordsList[j] == word)
                    {
                        count++;
                        wordsList.RemoveAt(j);
                    }
                }
                try
                {
                    CountOfWords.Add(word, count);
                }
                catch
                {

                }
            }
            foreach(var item in CountOfWords)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
