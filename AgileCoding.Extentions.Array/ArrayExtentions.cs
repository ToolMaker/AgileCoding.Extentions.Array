namespace AgileCoding.Extentions.Arrays
{
    using System;

    public static class ArrayExtentions
    {
        public static bool IsNullOrEmpty(this Array array)
        {
            if (array != null)
            {
                return array.Length == 0;
            }
            return true;
        }
    }
}
