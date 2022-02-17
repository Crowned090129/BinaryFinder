namespace BinarySearch.Library
{
    public class BinarySearch
    {
        public static (bool, int) Find(int[] obj, int num)
        {
            int lowIndex = 0;
            int highIndex = obj.Length - 1;
            int midIndex = Convert.ToInt32(((highIndex - lowIndex) / 2));
            int finded = 0;

            while (finded != num)
            {
                if (num == obj[midIndex])
                    finded = obj[midIndex];
                else if (num > obj[midIndex])
                    lowIndex = midIndex + 1;
                else if (num < obj[midIndex])
                    highIndex = midIndex - 1;

                midIndex = Convert.ToInt32(((highIndex - lowIndex) / 2)) + lowIndex;
            }

            if (finded == num)
                return (true, midIndex);
            else
                return (false, 0);
        }
    }
}