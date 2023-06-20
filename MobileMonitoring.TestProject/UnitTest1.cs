using Bunit;
using MobileMonitoring.Client.Pages;


namespace MobileMonitoring.TestProject
{
    public class UnitTest1 : TestContext
	{
        
        /// <summary>
        /// Check counter init
        /// </summary>
		[Fact(DisplayName = "Check counter initilisation")]
		public void IntitalCounterTextHTML()
		{
            var cut = RenderComponent<Counter>();
            var expectedHtml = @"<h1>Counter</h1>
                                  <p role=""status"">Current count: 0</p>
                                  <button class=""btn btn-primary"">Click me</button>";

            cut.MarkupMatches(expectedHtml);
        }
        
        /// <summary>
        /// Test click button once
        /// </summary>
        [Fact(DisplayName = "Click button increase the counter")]
        public void IncreaseCounterOnce()
        {
            IRenderedFragment cut = RenderComponent<Counter>();

            cut.Find("button").Click();

            cut.GetChangesSinceFirstRender().ShouldHaveSingleTextChange("Current count: 1");
        }

        /// <summary>
        /// Test click button twice
        /// </summary>
        [Fact(DisplayName = "Click button increase the counter a second time")]
        public void IncreaseCounterTwice()
        {
            IRenderedFragment cut = RenderComponent<Counter>();

            cut.Find("button").Click();

            cut.GetChangesSinceFirstRender().ShouldHaveSingleTextChange("Current count: 1");

            cut.Find("button").Click();

            cut.GetChangesSinceFirstRender().ShouldHaveSingleTextChange("Current count: 2");
        }


	}
}