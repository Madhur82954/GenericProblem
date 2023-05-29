using System;
using System.Collections.Generic;
using System.Text;

namespace GenericProblem
{
    internal class TestClass<T> where T:IComparable
    {
        public T FirstValue, SecondValue, ThirdValue;

        public TestClass(T firstvalue,T secondvalue,T thirdvalue)
        {
            this.FirstValue = firstvalue;
            this.SecondValue = secondvalue;
            this.ThirdValue = thirdvalue;
        }
        public T Compare(T firstvalue,T secondvalue,T thirdvalue)
        {
            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0)
            {
                return firstvalue;
            }
            if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0)
            {
                return secondvalue;
            }
            if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0)
            {
                return thirdvalue;
            }
            return default;
        }

        /*public float floatCompare(float first, float second, float third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            return 0;
        }*/
       /* public int IntCompare(int first,int second,int third)
        {
            if(first.CompareTo(second)>0 && first.CompareTo(third)>0)
            {
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            return 0;
        }*/
    }
}
