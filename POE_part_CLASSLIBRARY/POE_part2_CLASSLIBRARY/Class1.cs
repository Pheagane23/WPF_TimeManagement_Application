using System;

namespace POE_part1_CLASSLIBRARY
{
    public class Calculation
    {
        public int StudyCal(int credits, int weeks, int classHours)
        {
            return ((credits * 10) / weeks) - classHours;
        }

    }
}
