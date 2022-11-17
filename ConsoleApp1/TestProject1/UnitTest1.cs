using ConsoleApp1;

namespace TestProject1
{
    public class ProgramTests
    {
        [Test]
        public void checkSqrtInArr_EmptyArr_Test()
        {
            int[] ints = {};
            int[] ints2 = {};
            if (Program.checkSqrtInArr(ints, ints2) == true)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
        [Test]
        public void checkSqrtInArr_True_Test()
        {
            int[] ints = { 1};
            int[] ints2 = { 1};
            if (Program.checkSqrtInArr(ints, ints2) == true)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
        [Test]
        public void checkSqrtInArr_ReverseCheckArr_Test()
        {
            int[] ints = { 1, 2 };
            int[] ints2 = { 4, 1 };
            if (Program.checkSqrtInArr(ints, ints2) == true)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
        [Test]
        public void checkSqrtInArr_MoreThenNeed_Test()
        {
            int[] ints = { 1, 2 };
            int[] ints2 = { 1,2,3,4 };
            if (Program.checkSqrtInArr(ints, ints2) == true)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
        [Test]
        public void checkSqrtInArr_MoreOftheSame_Test()
        {
            int[] ints = { 1,1,1,1,1,1};
            int[] ints2 = { 1,5 };
            if (Program.checkSqrtInArr(ints, ints2) == true)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
        [Test]
        public void checkSqrtInArr_False_Test()
        {
            int[] ints = { 1, 2 };
            int[] ints2 = { 1,3, 5};
            if (Program.checkSqrtInArr(ints, ints2) == false)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}