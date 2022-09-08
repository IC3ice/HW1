namespace test;

public class UnitTest1
{
    [Fact]
    public void Test2()
    {
               double[] OMG = { 5, 1, 0, 1, 0, 0, 1, 0, 0, 1, 1 };
               double[] RQ = MAM.Change(5555.75);
               Assert.Equal(OMG, RQ);
    }
}