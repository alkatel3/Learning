using System;

namespace Learning
{
    /*Придумать класс, описывающий студента. Предусмотреть в нем следующие моменты: фамилия, имя, 
      отчество, группа, возраст, массив (зубчатый) оценок по 
      программированию, администрированию и дизайну.
      А также добавить методы по работе с перечисленными 
      данными: возможность установки/получения оценки, получение среднего балла по заданному предмету, 
      распечатка данных о студенте.*/
    enum Discipline
    {
        Programming,
        Administration,
        Design
    }
    class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        string MiddleName;
        string Groupe;
        int Age;
        double[][] Marks;

        public Student(string firstName, string lastName, string middleName, string groupe, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Groupe = groupe;
            Age = age;
            Marks = new double[3][];
            for(int i = 0; i < Marks.Length; i++)
            {
                Marks[i] = new double[0];
            }
        }
        public void GetMark(Discipline discipline, double Mark)
        {
            int CodeOfDiscipline = Convert.ToInt32(discipline);
            Console.WriteLine($"You got {Mark} on the {discipline}");
            double[] marks = new double[Marks[CodeOfDiscipline].Length+1];
            for(int i = 0; i < Marks[CodeOfDiscipline].Length; i++)
            {
                marks[i] = Marks[CodeOfDiscipline][i];
            }
            marks[marks.Length - 1] = Mark;
            Marks[CodeOfDiscipline] = marks;
        }
        public double GetAverageMark(Discipline discipline)
        {
            
            int CodeOfDiscipline = Convert.ToInt32(discipline);
            double result = 0;
            if (Marks[CodeOfDiscipline].Length == 0)
            {
                Console.WriteLine($"You don't have marks on {discipline}");
                return 0;
            }
            foreach(var mark in Marks[CodeOfDiscipline])
            {
                result += mark;
            }
            result /= Marks[CodeOfDiscipline].Length;
            return result;
        }
        public void GetInformation()
        {
            Console.Write($"Student:\t{LastName} {FirstName} {MiddleName}\n" +
                $"Age:\t{Age}\n" +
                $"Group:\t{Groupe}\n" +
                $"Marks on {Discipline.Administration}: ");
            foreach(var item in Marks[Convert.ToInt32(Discipline.Administration)])
            {
                Console.Write($"{item}; ");
            }
            Console.Write($"\nMarks on {Discipline.Design}: ");
            foreach (var item in Marks[Convert.ToInt32(Discipline.Design)])
            {
                Console.Write($"{item}; ");
            }
            Console.Write($"\nMarks on {Discipline.Programming}: ");
            foreach (var item in Marks[Convert.ToInt32(Discipline.Programming)])
            {
                Console.Write($"{item}; ");
            }
            Console.WriteLine();
        }
    }
}
