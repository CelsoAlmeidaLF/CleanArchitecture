using Systekna.Commands;
using Systekna.Core.Entity;

namespace UTestApplication
{
    public class TestsEntityApplication
    {
        #region ...
        public IApplicationCommand<EntityCommand> command;
        [SetUp] public void Setup() => command = FactoryApplicationCommand.Create;
        #endregion

        [Test] public void TestGetAll()
        {
            var result = command.GetAll(new());
            Assert.IsNotNull(result);
        }
    }
}