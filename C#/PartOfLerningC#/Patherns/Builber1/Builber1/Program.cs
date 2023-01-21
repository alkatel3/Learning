using System;
using System.Collections.Generic;
using System.Text;

namespace Builber1
{
    public class HtmlElement
    {
        public string Name, Text;
        public List<HtmlElement> Elements =
            new List<HtmlElement>();
        private const int indentSize = 2;

        public HtmlElement()
        {
        }
        public HtmlElement(string name, string text)
        {
            Name = name;
            Text = text;
        }

        public override string ToString()
        {
            return ToStringImpl(0);
        }

        private string ToStringImpl(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', indentSize * indent);
            sb.Append($"{i}<{Name}>\n");
            if (!string.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new string(' ', indentSize * (indent + 1)));
                sb.Append(Text);
                sb.Append("\n");
            }
            foreach (var e in Elements)
                sb.Append(e.ToStringImpl(indent + 1));
            sb.Append($"{i}</{Name}>\n");
            return sb.ToString();
        }

        
    }
    public class HtmlBuilber
    {
        private readonly string rootName;
        protected HtmlElement root = new();

        public HtmlBuilber(string rootName)//"ul"
        {
            this.rootName = rootName;
            root.Name = rootName;
        }
        public void AddChild(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);
        }
        public override string ToString()
        {
            return root.ToString();
        }
        public void Clear()
        {
            root = new HtmlElement { Name = rootName };
        }
        public HtmlElement Build()=>root;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var words = new[] { "hello", "world" };
            var builder = new HtmlBuilber("ul");
            foreach (var word in words)
                builder.AddChild("li", word);
            Console.WriteLine(builder.ToString());

        }
    }
}
