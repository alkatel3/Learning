using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    /*Описать структуру RequestItem содержащую поля: 
    товар; количество единиц товара.*/
    struct RequestItem
    {
        Article Article;
        int Count;

        public RequestItem(Article article, int count)
        {
            Article = article;
            Count = count;
        }
    }
}
