namespace EXSM3941_Test
{
    public class UnitTest1
    {
        [Fact]
        public void AddOne_Test_Max() => Assert.Throws(typeof(Exception), () => { Program.AddOne(int.MaxValue); });

        [Theory,
        // Positive value.
        InlineData(1, 2),
        // Zero value.
        InlineData(0, 1),
        // Negative value.
        InlineData(-1, 0),
        // Negative mid-ground value.
        InlineData(-1000, -999),
        // Positive mid-ground value.
        InlineData(1000, 1001),
        // Edge case lowest.
        InlineData(int.MinValue, int.MinValue+1),
        // Edge case highest.
        InlineData(int.MaxValue-1, int.MaxValue)]
        public void AddOne_Test(int paramOne, int expectedResult) => Assert.Equal(expectedResult, Program.AddOne(paramOne));
    }
}