using KatalonShopUITest.Hooks;
using KatalonShopUITest.Utilities;
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

        public static void IdentifyPrices()
        {
            //Identifying xPath for the prices
            IList<IWebElement> element = Context.driver.FindElements(By.XPath("//span[@class='woocommerce-Price-amount amount']")); // First we create a list of the similar locators
            IWebElement no1 = element[0];
            IWebElement no2 = element[2];
            IWebElement no3 = element[4];
            IWebElement no4 = element[6];

            double price1 = double.Parse(no1.Text.Replace("$", ""));
            double price2 = double.Parse(no2.Text.Replace("$", ""));
            double price3 = double.Parse(no3.Text.Replace("$", ""));
            double price4 = double.Parse(no4.Text.Replace("$", ""));

            List<double> priceList = new List<double> { price1, price2, price3, price4};

            double smallestPrice = priceList.Min();

            switch (smallestPrice)
            {
                case 18:
                    Context.driver.FindElement(By.XPath("//a[@data-product_id='26']")).Click();
                    break;

                case 35:
                    Context.driver.FindElement(By.XPath("//a[@data-product_id='27']")).Click();
                    break;

                case 20:
                    Context.driver.FindElement(By.XPath("//a[@data-product_id='25']")).Click();
                    break;

                case 12:
                    IWebElement xButton = Context.driver.FindElement(By.XPath("//a[@data-product_id='54']"));
                    Helpers.HandleClickInteruptedException(xButton);
                    //xButton.Click();
                    break;

            }

        }
    }
}
