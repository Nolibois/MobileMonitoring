using Bunit;
using Microsoft.AspNetCore.Components;
using MobileMonitoring.Client.Pages;
using MobileMonitoring.Shared;


namespace MobileMonitoring.TestProject
{
    public class UnitTest1 : TestContext
	{
        /// <summary>
        /// Usual Case: Matches component Tile
        /// </summary>
        [Fact]
        public void RenderUsualTileDto()
        {
            //Arrange
            var counter = 0;
            TileDto tile = new (
                1, "Notifications cleanup", 15, "System administration", 6, true
            );

            //Act
            var cut = RenderComponent<Client.Shared.Tile>(parameters => parameters
             .Add(p => p.Data, tile)
             .Add(p => p.OnClick, () => counter++)
            );

            //Assert
            cut.MarkupMatches("""
                <button class="nav-link card content-box rounded-0 m-3 text-bg-primary">
                    <div class="card-body">
                        <p class="card-text">15K</p>
                    </div>
                    <div class="card-footer border-0">Notifications cleanup</div>
                    <div class="border-box"></div>
                </button>
            """);
        }

        /// <summary>
        /// Extreme case: If Number is null
        /// </summary>
        [Fact]
        public void RenderNumberTileDto()
        {
            //Arrange
            var counter = 0;
            TileDto tile = new(
                1, "Notifications cleanup", null, "System administration", 6, true
            );

            //Act
            var cut = RenderComponent<Client.Shared.Tile>(parameters => parameters
             .Add(p => p.Data, tile)
             .Add(p => p.OnClick, () => counter++)
            );

            //Assert
            cut.MarkupMatches("""
                <button class="nav-link card content-box rounded-0 m-3 text-bg-primary">
                    <div class="card-body">
                        <p class="card-text">N/A</p>
                    </div>
                    <div class="card-footer border-0">Notifications cleanup</div>
                    <div class="border-box"></div>
                </button>
            """);
        }

        /// <summary>
        /// Error Case: If Tile is null => 
        /// Number : N/A
        /// Name: ""
        /// Button Class: "text-bg-danger"
        /// </summary>
        [Fact]
        public void RenderNullTileThrowsException()
        {
            //Arrange
            var counter = 0;

            //Act
            var act = () => RenderComponent<Client.Shared.Tile>(parameters => parameters
             .Add(p => p.Data, null)
             .Add(p => p.OnClick, () => counter++)
            );

            //Assert
            Assert.Throws<ArgumentNullException>(act);
        }

        /// <summary>
        /// Usual case: Event called xhen button pressed
        /// </summary>
        [Fact]
        public void OnClickCalledWhenUserClick()
        {
            //Arrange
            var counter = 0;
            TileDto tile = new(
                1, "Notifications cleanup", 15, "System administration", 6, true
            );

            //Act
            var cut = RenderComponent<Client.Shared.Tile>(parameters => parameters
             .Add(p => p.Data, tile)
             .Add(p => p.OnClick, () => counter++)
            );
            
            cut.Find("button").Click();

            //Assert
            Assert.Equal(1, counter);
        }

        /// <summary>
        /// Extreme case
        /// </summary>
        [Fact]
        public void DefaultOnClickDoesNothing()
        {
            
        }

        /// <summary>
        /// Error Case
        /// </summary>        
        [Fact]
        public void NullOnClickThrowsException()
        {
            //Arrange
            TileDto tile = new(
                1, "Notifications cleanup", 15, "System administration", 6, true
            );

            //Act
            var act = () => RenderComponent<Client.Shared.Tile>(parameters => parameters
             .Add(p => p.Data, tile)
             .Add(p => p.OnClick, null)
            );

            //Assert
            Assert.Throws<ArgumentNullException>(act);
        }

    }
}