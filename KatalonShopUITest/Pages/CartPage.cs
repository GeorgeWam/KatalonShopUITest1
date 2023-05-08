using KatalonShopUITest.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatalonShopUITest.Pages
{
    public static class CartPage
    {

        /// <summary>
        /// This identifies all elements with add to cart. We just need to call the method and pass in the the index position of the element
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static IWebElement AddToCart(int index)
        {
            
            IList<IWebElement> element = Context.driver.FindElements(By.XPath("//a[text()='Add to cart']")); // First we create a list of the similar locators
            IWebElement item = element[index]; //Then we reference the index number position of the locator we need
            return item; //Then we return iterator to be used where needed. 
        }

        public static IWebElement PriceTag()
        {

            IList<IWebElement> element = Context.driver.FindElements(By.XPath("//span[text()='20.00']")); // First we create a list of the similar locators
            IWebElement item = element[0]; //Then we reference the index number position of the locator we need
            return item; //Then we return iterator to be used where needed. 
        }
        


        public static IWebElement CartLink
        {
            get { return Context.driver.FindElement(By.XPath("//a[@href='https://cms.demo.katalon.com/cart/']")); }
        }

        public static int TotalItemsInCart(int totalItems)
        {
            int items = 0; // First we create a list of the similar locators
            if (totalItems == 4)
            {
                while (items < 3)
                {
                    items = Context.driver.FindElements(By.XPath("//input[@title='Qty']")).Count;
                }
                return items;
            }
            else
            {
                while (items < 2)
                {
                    items = Context.driver.FindElements(By.XPath("//input[@title='Qty']")).Count;
                }
                return items;
            }
            
        }

        

        public static IWebElement FindLowestPricedItem()
        {
            List<IWebElement> itemPrices = Context.driver.FindElements(By.XPath("//span[@class='woocommerce-Price-amount amount']")).ToList(); //We find all the elements 
            List<double> prices = new List<double>();
            //We remove the dollar sign from the prices
            foreach (IWebElement itemPrice in itemPrices)
            {
                double price = double.Parse(itemPrice.Text.Replace("$", ""));
                prices.Add(price);
            }
            //We get the index for the lowest price
            int lowestIndex = prices.IndexOf(prices.Min());
            //We identify the element with the lowest price
            List<IWebElement> items = Context.driver.FindElements(By.XPath("//td[@class='product-name']")).ToList();
            //We assign the indicies
            IWebElement lowestPricedItem = items[lowestIndex];
            //we return the element
            return lowestPricedItem;
        }


        

        public static IWebElement ItemWithLowestPrice
        {
            get { return Context.driver.FindElement(By.XPath("//a[@data-product_sku='POSTER-FLYING-NINJA']")); }
        }
    }
}
