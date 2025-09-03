namespace S8con.Test;

[TestClass]
public  class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        int x =1 ;
        Assert.AreEqual(x+1,2);
    }

    public void TastMethod2()
    {
        int result = Program.add(3,5);
        Assert.AreEqual(result,8);
    }
}
