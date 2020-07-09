using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace OrangeHRMJune2020.StepBinding
{
    [Binding]
    class AddNumbers
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int input)
        {
            Console.WriteLine(input);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("When I pressed Add---->");
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            Console.WriteLine("result: {0}", result);
        }

    }
}
