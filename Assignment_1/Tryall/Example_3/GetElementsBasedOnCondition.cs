using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Session_12.More_Generics
{
    public delegate bool ConditionDelegate<T>(T x);
    public static class GetElementsBasedOnCondition<T>
    {
        public static List<T> GetElements(List<T> Elements, ConditionDelegate<T> conditionDelegate)
        {
            List<T> Values = new List<T>();

            //if (Elements is null || conditionDelegate is null) return Values;
            if (Elements?.Count == 0 || conditionDelegate is null) return Values;

            foreach (T element in Elements)
                if (conditionDelegate(element))
                    Values.Add(element);
            return Values;
        }

        public static List<T> GetElementsUsingBuiltInDelegate(List<T> Elements, Predicate<T> conditionDelegate)
        {
            List<T> Values = new List<T>();

            //if (Elements is null || conditionDelegate is null) return Values;
            if (Elements?.Count == 0 || conditionDelegate is null) return Values;

            foreach (T element in Elements)
                if (conditionDelegate(element))
                    Values.Add(element);
            return Values;
        }
    }
}
