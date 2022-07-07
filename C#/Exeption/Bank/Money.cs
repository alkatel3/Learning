using System;

/*
    Написать класс Money, предназначенный для хранения денежной суммы (в гривнах и копейках).
    Для класса реализовать перегрузку операторов:
        + (сложение денежных сумм),
        – (вычитание сумм),
        / (деление суммы на целое число),
        * (умножение суммы на целое число),
        ++ (сумма увеличивается на 1 копейку),
        -- (сумма уменьшается на 1 копейку), 
        <,
        >,
        ==,
        !=.
 */

namespace Bank
{
    class Money
    {
        public long GlobalPennie { get; private set; }
        public long Hryvnia { get; private set; }
        public long Pennie { get; private set; }

        public Money(long hryvnia, long pennie)
        {
            if (hryvnia < 0 || pennie < 0)
            {
                throw new Bankrut();
            }
            if (pennie >= 100)
            {
                Pennie = pennie % 100;
                Hryvnia = (pennie - Pennie)/100;
            }
            Hryvnia += hryvnia;
            GlobalPennie = hryvnia * 100 + pennie;
        }

        public static Money operator +(Money money1, Money money2)
        {
            long hryvnia = money1.Hryvnia + money2.Hryvnia;
            long pennies = money1.Pennie + money2.Pennie;
            return new Money(hryvnia, pennies);
        }

        public static Money operator -(Money money1, Money money2)
        {
            if (money1.GlobalPennie < money2.GlobalPennie)
            {
                throw new Bankrut();
            }
            if (money1.Pennie < money2.Pennie)
            {
                money1.Hryvnia--;
                money1.Pennie += 100;
            }
            long pennie = money1.Pennie - money2.Pennie;
            long hryvnia = money1.Hryvnia - money2.Hryvnia;
            return new Money(hryvnia, pennie);
        }

        public static Money operator /(Money money1, int number)
        {
            long hryvnia = money1.Hryvnia / number;
            long pennies = money1.Pennie / number;
            return new Money(hryvnia, pennies);
        }

        public static Money operator *(Money money1, int number)
        {
            long hryvnia = money1.Hryvnia * number;
            long pennies = money1.Pennie * number;
            return new Money(hryvnia, pennies);
        }
        public static Money operator ++(Money money1)
        {
            money1.Pennie++;
            return money1;
        }
        public static Money operator --(Money money1)
        {
            if (money1.GlobalPennie == 0)
            {
                throw new Bankrut();
            }
            if (money1.Pennie ==0)
            {
                money1.Hryvnia--;
                money1.Pennie += 100;
            }
            money1.Pennie--;
            return money1;
        }

        public static bool operator >(Money money1, Money money2)
        {

            return (money1.Hryvnia>money2.Hryvnia)&&(money1.Pennie > money2.Pennie);
        }
        public static bool operator <(Money money1, Money money2)
        {

            return (money1.Hryvnia < money2.Hryvnia) && (money1.Pennie < money2.Pennie);
        }

        public static bool operator ==(Money money1, Money money2)
        {

            return (money1.Hryvnia == money2.Hryvnia) && (money1.Pennie == money2.Pennie);
        }
        public static bool operator !=(Money money1, Money money2)
        {

            return !(money1 == money2);
        }
        public override string ToString()
        {
            return $"Balance {Hryvnia} hryvnias and {Pennie} pennies";
        }

        public void AddMoneyToBalance(long hryvnia, long pennie)
        {
            Money money = new Money(hryvnia, pennie);
            money += this;
            this.Hryvnia = money.Hryvnia;
            this.Pennie = money.Pennie;
        }
        public void SubtractMoneyFromBalance(long hryvnia, long pennie)
        {
            Money money = new Money(hryvnia, pennie);
            money = this - money;
            this.Hryvnia = money.Hryvnia;
            this.Pennie = money.Pennie;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
