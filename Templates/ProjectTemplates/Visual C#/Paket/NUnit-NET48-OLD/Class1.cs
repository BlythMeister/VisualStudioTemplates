using NUnit.Framework;

namespace $safeprojectname$
{
	[TestFixture, Parallelizable(ParallelScope.All)]
    class Class1
    {
		private class TestContext
        {
            public TestContext()
            {                
            }
        }
		
		[Test]
		public void Test1()
		{
			//Arrange
			var context = new TestContext();
			
			//Act
			
			//Assert
		}		
    }
}