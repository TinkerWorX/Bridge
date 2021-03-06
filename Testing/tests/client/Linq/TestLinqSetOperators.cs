using Bridge.Test;
using Bridge.ClientTest.Utilities;
using System.Linq;

namespace Bridge.ClientTest.Linq
{
    [Category(Constants.MODULE_LINQ)]
    [TestFixture(TestNameFormat = "Set - {0}")]
    public class TestLinqSetOperators
    {
        [Test(ExpectedCount = 8)]
        public static void Test()
        {
            // TEST
            int[] a = { 1, 2 };
            int[] b = { 1, 2 };

            var result = a.Intersect(b).ToArray();

            // TEST
            int[] numbers = { 1, 2, 3, 3, 1, 5, 4, 2, 3 };

            var uniqueNumbers = numbers.Distinct().ToArray();
            Assert.AreDeepEqual(uniqueNumbers, new[] { 1, 2, 3, 5, 4 }, "Distinct() to remove duplicate elements");

            // TEST
            var distinctPersonGroups = (from p in Person.GetPersons()
                                        select p.Group).Distinct().ToArray();
            Assert.AreDeepEqual(distinctPersonGroups, new[] { "A", "C", "B", null }, "Distinct() to remove duplicate Group elements");

            // TEST
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var uniqueNumbersAB = numbersA.Union(numbersB).ToArray();
            Assert.AreDeepEqual(uniqueNumbersAB, new[] { 0, 2, 4, 5, 6, 8, 9, 1, 3, 7 }, "Union() to get unique number sequence");

            // TEST
            var nameChars = from p in Person.GetPersons()
                            select p.Name[0];
            var cityChars = from p in Person.GetPersons()
                            select p.City[0];
            var uniqueFirstChars = nameChars.Union(cityChars).ToArray();

            Assert.AreDeepEqual(uniqueFirstChars, new[] { (int)'F', (int)'Z', (int)'J', (int)'B', (int)'D', (int)'I', (int)'M', (int)'N',
                                                        (int)'E', (int)'T', (int)'L', (int)'P', (int)'R', (int)'O' },
                "Union to get unique first letters of Name and City");

            // TEST
            var commonNumbersCD = numbersA.Intersect(numbersB).ToArray();
            Assert.AreDeepEqual(commonNumbersCD, new[] { 5, 8 }, "Intersect() to get common number sequence");

            // TEST
            nameChars = from p in Person.GetPersons()
                        select p.Name[0];
            cityChars = from p in Person.GetPersons()
                        select p.City[0];

            var commonFirstChars = nameChars.Intersect(cityChars).ToArray();
            Assert.AreDeepEqual(commonFirstChars, new[] { (int)'B', (int)'D' }, "Intersect() to get common first letters of Name and City");

            // TEST
            var exceptNumbersCD = numbersA.Except(numbersB).ToArray();
            Assert.AreDeepEqual(exceptNumbersCD, new[] { 0, 2, 4, 6, 9 },
                "Except() to get numbers from first sequence and does not contain the second sequence numbers");

            // TEST
            var exceptFirstChars = nameChars.Except(cityChars).ToArray();
            Assert.AreDeepEqual(exceptFirstChars, new[] { (int)'F', (int)'Z', (int)'J', (int)'I', (int)'M', (int)'N' },
                "Except() to get letters from Name sequence and does not contain City letters");
        }
    }
}
