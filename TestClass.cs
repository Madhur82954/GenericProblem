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
        public T Compare()
        {
            if (FirstValue.CompareTo(SecondValue) > 0 && FirstValue.CompareTo(ThirdValue) > 0)
            {
                return FirstValue;
            }
            if (SecondValue.CompareTo(FirstValue) > 0 && SecondValue.CompareTo(ThirdValue) > 0)
            {
                return SecondValue;
            }
            if (ThirdValue.CompareTo(FirstValue) > 0 && ThirdValue.CompareTo(SecondValue) > 0)
            {
                return ThirdValue;
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
