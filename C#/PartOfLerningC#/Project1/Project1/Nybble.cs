using System;

namespace Project1
{
    class Nybble
    {
        int val;

        public Nybble()
        {
            val = 0;
        }
        public Nybble(int i)
        {
            val = i;
            val = val & 0xF;
        }
        public static Nybble operator +(Nybble ob1, Nybble ob2)
        {
            Nybble result = new Nybble();
            result.val = ob1.val + ob2.val;
            result.val = result.val & 0xF;
            return result;
        }
        public static Nybble operator +(Nybble op1, int op2)
        {
            Nybble result = new Nybble();
            result.val = op1.val + op2;
            result.val = result.val & 0xF;
            return result;
        }
        public static Nybble operator +(int op1, Nybble op2)
        {
            Nybble result = new Nybble();
            result.val = op1 + op2.val;
            result.val = result.val & 0xF;
            return result;
        }
        public static Nybble operator ++(Nybble op)
        {
            Nybble result = new Nybble();
            result.val = op.val + 1;
            result.val = result.val & 0xF; // сохранить 4 младших разряда
            return result;
        }
        // Перегрузить оператор >.
        public static bool operator >(Nybble op1, Nybble op2)
        {
            if (op1.val > op2.val) return true;
            else return false;
        }
        // Перегрузить оператор <.
        public static bool operator <(Nybble op1, Nybble op2)
        {
            if (op1.val < op2.val) return true;
            else return false;
        }
        public static implicit operator int(Nybble op)
        {
            return op.val;
        }
        // Преобразовать тип int в тип Nybble.
        public static implicit operator Nybble(int op)
        {
            return new Nybble(op);
        }

    }
}
