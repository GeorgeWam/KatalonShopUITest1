using KatalonShopUITest.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace KatalonShopUITest.StepDefinition
{
    [Binding]
    public class CommonSteps
    {


        [Given(@"the application is up and running")]
        public void GivenTheApplicationIsUpAndRunning()
        {
            Context.LaunchApplicationUnderTest();
        }
    }
}
