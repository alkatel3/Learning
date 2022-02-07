using System;

namespace Learning
{
    /* Описать структуру Article, содержащую следующие
       поля: код товара; название товара; цену товара.*/
    /*Описать перечисление ArticleType определяющее 
      типы товаров, и  добавить соответствующее поле 
      в структуру Article из задания №1.*/
    enum ArticleType
    {
        Sweets,
        MeatProduct,
        MilkProduct,
        Other
    };
    struct Article
    {
        static int Number = -1;
        public string Name { get; private set; }
        public double Price { get; private set; }
        ArticleType articleType;

        public Article(string name, int price,ArticleType articleType)
        {
            Name = name;
            Price = price;
            Number++;
            this.articleType = articleType;
        }

        public void Rename(string newName)
        {
            Console.WriteLine($"Rename {this}\n" +
                $"Old name\t{Name}\n" +
                $"New name]t{newName}");
            Name = newName;
        }
        public void Revaluation(double newPrice)
        {
            Console.WriteLine($"Rename {this}\n" +
                $"Old price\t{Price}\n" +
                $"New price\t{newPrice}");
            Price = newPrice;
        }

        public void GetInformation()
        {
            Console.WriteLine($"Product:\t {Name}\n" +
                $"Number:\t{Number}\n" +
                $"Price:\t{Price}");
        }

    }
}
