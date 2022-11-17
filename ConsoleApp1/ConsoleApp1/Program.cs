namespace ConsoleApp1
{
    public static class Program
    {
        static void Main(string[] args)
        {

        }

        public static bool checkSqrtInArr(int[] correctArr, int[] checkArr)
        {
            if(correctArr.Length==0 && checkArr.Length == 0)
            {
                return true;
            }
            List <bool> goodIterations = new List<bool>{ };
            foreach (int number in correctArr)
            {
                int sqrtNumber = number * number;
                bool iteration = false;
                foreach (var checkNumber in checkArr)
                {
                    if(checkNumber == sqrtNumber)
                    {
                        iteration= true;
                        break;
                    }
                }
                if (iteration)
                {
                    goodIterations.Add(true);
                }
                else
                {
                    goodIterations.Add(false);
                }

            }
            foreach (bool item in goodIterations)
            {
                if (item == false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}