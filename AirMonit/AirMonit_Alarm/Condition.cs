using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirMonit_Alarm
{
    enum Condition
    {
        GREATER_THAN, LESSER_THAN, EQUALS, EQUAL_OR_GREATER_THAN, EQUAL_OR_LESSER_THAN

    }

    static class ConditionMethods
    {
        public static Exception ConditionNotValidException { get; private set; }

        public static bool CompareValues(
            this Condition condition, int firstValue, int secondValue)
        {
            switch (condition)
            {
                case Condition.EQUALS:
                    return firstValue == secondValue;

                case Condition.GREATER_THAN:
                    return firstValue > secondValue;

                case Condition.LESSER_THAN:
                    return firstValue < secondValue;

                case Condition.EQUAL_OR_GREATER_THAN:
                    return firstValue >= secondValue;

                case Condition.EQUAL_OR_LESSER_THAN:
                    return firstValue <= secondValue;

                default:
                    throw ConditionNotValidException;
            }

        }
    }

}
