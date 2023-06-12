using Bunit;
using MobileMonitoring.Client.Pages;
using MobileMonitoring.Shared;


namespace MobileMonitoring.TestProject
{
    public class UnitTest1 : TestContext
    {
      //public UnitTest1()
      //{
      //  Services.AddHttpClient();
      //}

    [Fact]
        public void SelectModuleInSettings()
        {
      
        // Arrange
        var ctx = new TestContext();
        var cut = ctx.RenderComponent<Settings>();
        var paraElm = cut.Find("InputSelect");

        // Act
        cut.Find("button").Click();
        //var paraElmText = paraElm.TextContent;

        // Assert
        paraElm.MarkupMatches("<InputNumber class=\"mb-2 form-control\" id=\"threshold\" placeholder=\"@tiles.FirstOrDefault(threshold => threshold.IdTile == Int32.Parse(selectedModule))?.Threshold\" @bind-Value=Notifications cleanup />");



        }
    }
}