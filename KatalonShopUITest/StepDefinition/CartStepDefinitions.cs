using KatalonShopUITest.Hooks;
using KatalonShopUITest.Pages;
using KatalonShopUITest.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace KatalonShopUITest
{
    [Binding]
    public class CartStepDefinitions
    {

        [Given(@"I added four random items to my cart")]
        public void GivenIAddedFourRandomItemsToMyCart()
        {
            //For flying Ninja item
            Helpers.ExplicitlyWaitForElement("//img[@src='https://cms.demo.katalon.com/wp-content/uploads/2019/08/poster_2_up-300x300.jpg']");
            CartPage.AddToCart(0).Click();

            //For happy Ninja item 1
            Helpers.ExplicitlyWaitForElement("//img[@src='https://cms.demo.katalon.com/wp-content/uploads/2019/08/T_7_front-300x300.jpg']");
            CartPage.AddToCart(1).Click();

            //For happy Ninja item 2
            CartPage.AddToCart(2).Click();

            //For Ninja Silhouette
            Helpers.PageScrollDown();
            Helpers.ExplicitlyWaitForElement("//img[@src='https://cms.demo.katalon.com/wp-content/uploads/2019/08/T_5_front-300x300.jpg']");
            CartPage.AddToCart(3).Click();
        }


        [When(@"I view my cart")]
        public void WhenIViewMyCart()
        {
            CartPage.CartLink.Click();
        }

        [Then(@"I find total four items listed in my cart")]
        public void ThenIFindTotalFourItemsListedInMyCart()
        {
            Helpers.PageScrollDown();
            Helpers.ExplicitlyWaitForElement("//a[text()='Ninja Silhouette']");
            Assert.AreEqual(CartPage.TotalItemsInCart(4), 4);
        }

        [When(@"I search for lowest price item")]
        public void WhenISearchForLowestPriceItem()
        {
            CartPage.FindLowestPricedItem();
        }

        [When(@"I am able to remove the lowest price Item from my cart")]
        public void WhenIAmAbleToRemoveTheLowestPriceItemFromMyCart()
        {
            CartPage.ItemWithLowestPrice.Click();
        }

        [Then(@"I am able to verify three items in my cart")]
        public void ThenIAmAbleToVerifyThereeItemsInMyCart()
        {
            Helpers.ExplicitlyWaitForElement("//a[text()='Ninja Silhouette']");
            Helpers.PageScrollDown();
            Assert.AreEqual(3, CartPage.TotalItemsInCart(3));
        }
    }
}
