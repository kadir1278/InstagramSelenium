using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramFollower
{
    // #adım 1 -> selenium kütüphanesi yükle
    // #adım 2 -> selenium chrome web driver yükle
    class Program
    {
        static void Main(string[] args)
        {
            string un = "kadirr.1278";
            
            IWebDriver driver = new ChromeDriver(); // chrome aç
            driver.Navigate().GoToUrl("https://www.instagram.com/" + un); // instagram sayfasına git
            
            IWebElement takipSayisi = driver.FindElement(By.CssSelector("#react-root > section > main > div > header > section > ul > li:nth-child(3) > a > span"));
            IWebElement takipciSayisi = driver.FindElement(By.CssSelector("#react-root > section > main > div > header > section > ul > li:nth-child(2) > a"));
            IWebElement gonderiSayisi = driver.FindElement(By.CssSelector("#react-root > section > main > div > header > section > ul > li:nth-child(1) > a"));


            string x = takipSayisi.Text.ToString();
            string y = takipciSayisi.Text.ToString();
            string z = gonderiSayisi.Text.ToString();

            Console.WriteLine("Takip Sayısı Getiriliyor");
            Console.WriteLine(x);
            Console.WriteLine("Takipci Sayısı Getiriliyor");
            Console.WriteLine(y);
            Console.WriteLine("Gönderi Sayısı Getiriliyor");
            Console.WriteLine(z);

            driver.Close();
            
        }

    }
}
