using System;

namespace Learning
{
    /*Описать структуру Request содержащую поля: код 
      заказа; клиент; дата заказа; перечень заказанных товаров; 
      сумма заказа (реализовать вычисляемым свойством).*/
    /*Описать перечисление PayType определяющее форму 
      оплаты клиентом заказа, и добавить соответствующее 
      поле в структуру Request из задания №4.*/
    enum PayType
    {
        cash,
        card
    };
    class Request
    {
        int Number;
        Client Client;
        DateTime dateOfOrder;
        Article[] OrderList;
        double Sum;
        PayType payType;

        public Request(int number, Client client, DateTime dateOfOrder, Article[] orderList, double sum, PayType payType)
        {
            Number = number;
            Client = client;
            this.dateOfOrder = dateOfOrder;
            OrderList = orderList;
            Sum = sum;
            this.payType = payType;
        }
    }
}
