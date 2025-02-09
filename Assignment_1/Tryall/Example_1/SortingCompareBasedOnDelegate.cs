namespace C__Session_12.Delegate_Example_2
{
    public static class SortingCompareBasedOnDelegate
    {
        public static bool SortAsc(int x, int y)
        {
            return x > y;
        }
        public static bool SortDesc(int x, int y)
        {
            return x < y;
        }
    }
}

