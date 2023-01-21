using System;

namespace Project1
{
    class ThreeD
    {
        int x, y, z;
        public ThreeD()
        {
            x = y = z = 0;
        }
        public ThreeD(int a, int b,int c)
        {
            x = a;
            y = b;
            z = c;
        }
        public static ThreeD operator +(ThreeD ob1, ThreeD ob2)
        {
            var result = new ThreeD();
            result.x = ob1.x + ob2.x;
            result.y = ob1.y + ob2.y;
            result.z = ob1.z + ob2.z;
            return result;
        }
        public static ThreeD operator -(ThreeD ob1, ThreeD ob2)
        {
            var result = new ThreeD();
            result.x = ob1.x - ob2.x;
            result.y = ob1.y - ob2.y;
            result.z = ob1.z - ob2.z;
            return result;
        }
        public static ThreeD operator -(ThreeD ob1)
        {
            var result = new ThreeD();
            result.x = -ob1.x;
            result.y = -ob1.y ;
            result.z = -ob1.z ;
            return result;
        }
        public static ThreeD operator --(ThreeD ob1)
        {
            var result = new ThreeD();
            result.x = ob1.x-1;
            result.y = ob1.y-1;
            result.z = ob1.z-1;
            return result;
        }
        public static ThreeD operator ++(ThreeD ob1)
        {
            var result = new ThreeD();
            result.x = ob1.x+1;
            result.y = ob1.y+1;
            result.z = ob1.z + 1;
            return result;
        }
        public static ThreeD operator +(ThreeD ob1, int num)
        {
            var result = new ThreeD();
            result.x = ob1.x + num;
            result.y = ob1.y + num;
            result.z = ob1.z + num;
            return result;
        }
        public static ThreeD operator +(int num, ThreeD ob1)
        {
            var result = new ThreeD();
            result.x = ob1.x + num;
            result.y = ob1.y + num;
            result.z = ob1.z + num;
            return result;
        }
        public static bool operator <(ThreeD ob1, ThreeD ob2)
        {
            if (Math.Sqrt(ob1.x*ob1.x+ ob1.y * ob1.y+ ob1.z * ob1.z)<
                Math.Sqrt(ob2.x * ob2.x + ob2.y * ob2.y + ob2.y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >(ThreeD ob1, ThreeD ob2)
        {
            if (Math.Sqrt(ob1.x * ob1.x + ob1.y * ob1.y + ob1.z * ob1.z) >
                Math.Sqrt(ob2.x * ob2.x + ob2.y * ob2.y + ob2.y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator true(ThreeD ob)
        {
            if ((ob.x != 0) || (ob.y != 0) || (ob.z != 0))
                return true; 
            else
                return false;
        }
       
        public static bool operator false(ThreeD ob)
        {
            if ((ob.x == 0) && (ob.y == 0) && (ob.z == 0))
                return true; 
            else
                return false;
        }
        public static ThreeD operator |(ThreeD ob1, ThreeD ob2)
        {
            if ((ob1.x != 0) || (ob1.y != 0) || (ob1.z != 0)|
                (ob2.x != 0) || (ob2.y != 0) || (ob2.z != 0))
                return new ThreeD(1,1,1);
            else
                return new ThreeD(0, 0, 0);
        }
        public static ThreeD operator &(ThreeD ob1, ThreeD ob2)
        {
            if ((ob1.x != 0) || (ob1.y != 0) || (ob1.z != 0) &
                (ob2.x != 0) || (ob2.y != 0) || (ob2.z != 0))
                return new ThreeD(1, 1, 1);
            else
                return new ThreeD(0, 0, 0);
        }
        public static bool operator !(ThreeD ob)
        {
            if (ob)
                return false;
            else
                return true;
        }
        public static implicit operator int(ThreeD ob)
        {
            return ob.x * ob.y * ob.z;
        }
        public void Show()
        {
            Console.WriteLine($"x={x}\ty={y}\tz={z}");
        }
    }
}
