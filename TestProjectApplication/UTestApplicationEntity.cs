using Systekna.Commands;

namespace UTestApplication
{
    public class TestsEntityApplication
    {
        #region ...
        public IApplicationCommand command;
        [SetUp] public void Setup() 
            => command = FactoryApplicationCommand.Create;
        #endregion

        [Test] public void TestGetAll()
        {
            var result = command.GetAll(new());
            Assert.IsNotNull(result);
        }
    }
}