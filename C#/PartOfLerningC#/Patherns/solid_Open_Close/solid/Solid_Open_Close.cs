using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace solid
{
    public enum Color
    {
        Red, Green, Blue
    }
    public enum Size
    {
        Small, Medium, Large
    }
    public class Product
    {
        public readonly string Name;
        public readonly Color Color;
        public readonly Size Size;

        public Product(string name, Color color, Size size)
        {
            Name = name?? throw new ArgumentNullException(paramName:nameof(name));
            Color = color;
            Size = size;

        }
    }
    
    public class ProductFilter
    {
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach(var item in products)
            {
                if (item.Color == color)
                {
                    yield return item;
                }
            }
        }
        public static IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var p in products)
                if (p.Size == size)
                    yield return p;
        }

        public static IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color)
        {
            foreach (var p in products)
                if (p.Size == size && p.Color == color)
                    yield return p;
        } // state space explosion
          // 3 criteria = 7 methods

        // OCP = open for extension but closed for modification
    }
    public abstract class Specification<T>
    {
        public abstract bool IsSatisfied(T item);
        public static Specification<T> operator &(Specification<T> first, Specification<T> second)
        {
            return new AndSpecification<T>(first, second);
        }
    }
    public class ColorSpecification: Specification<Product>
    {
        private Color color;
        public ColorSpecification(Color color)
        {
            this.color = color;
        }
        public override bool IsSatisfied(Product item)
        {
            return item.Color == color;
        }
    }
    public class SizeSpecification : Specification<Product>
    {
        private Size size;
        public SizeSpecification(Size size)
        {
            this.size = size;
        }
        public override bool IsSatisfied(Product item)
        {
            return item.Size==size;
        }
    }

    public interface IFilter<T> 
    {
        IEnumerable<T> Filter(IEnumerable<T> items, Specification<T> spec);
    }
    public class BetterFilter: IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, Specification<Product> spec)
        {
            foreach (var i in items)
            {
                if(spec.IsSatisfied(i))
                {
                    yield return i;
                }
            }
        }
    }
    public abstract class CompositeSpecification<T> : Specification<T>
    {
        protected readonly Specification<T>[] items;

        public CompositeSpecification(params Specification<T>[] items)
        {
            this.items = items;
        }
    }
    //combinator
    public class AndSpecification <T>: CompositeSpecification<T>
    {
        public AndSpecification(params Specification<T>[] items) : base(items)
        {

        }
        public override bool IsSatisfied(T item)
        {
            return items.All(i => i.IsSatisfied(item));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            var pf = new ProductFilter();
            Console.WriteLine("Green products (old)");
            foreach(var p in pf.FilterByColor(products, Color.Green))
            {
                Console.WriteLine(p.Name);
            }

            var bf = new BetterFilter();
            Console.WriteLine("Green products (new):");
            foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
               Console.WriteLine($" - {p.Name} is green");

            Console.WriteLine("Large products");
            foreach (var p in bf.Filter(products, new SizeSpecification(Size.Large)))
                Console.WriteLine($" - {p.Name} is large");

            var largeGreenSpec = new ColorSpecification(Color.Green)
                                 & new SizeSpecification(Size.Large);
            //var largeGreenSpec = Color.Green.And(Size.Large);

            Console.WriteLine("Large blue items");
            foreach (var p in bf.Filter(products,
              new AndSpecification<Product>(new ColorSpecification(Color.Blue),
                new SizeSpecification(Size.Large)))
            )
            {
                Console.WriteLine($" - {p.Name} is big and blue");
            }
        }
    }
}
