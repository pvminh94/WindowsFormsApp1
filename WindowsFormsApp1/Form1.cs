using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://kekhaigiattbyt.moh.gov.vn/cong-khai-gia");
            int rowSize = driver.FindElements(By.XPath("//tbody//tr")).Count;
            //for (int page = 1; page < 24025; page++)
            //{
            //    for (int i = 1; i < rowSize; i++)
            //    {
            //        for (int col = 1; col < ; i++)
            //        {

            //        }
            //    }
            //}
            //string result = driver.FindElement(By.XPath("//tbody//tr[1]//td[1]//*[@class='ng-binding']")).Text;
            //if(result ==null)
            //string result = driver.FindElement(By.XPath("//tbody//tr[2]//td[1][@class='ng-binding']")).Text;

            //1:
            //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            //var div = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"congKhaiGia\"]/div[2]/div/div/div[3]/a[3]")));
            //div.Click();
            //2:
            for (int i = 1; i < 24040; i++)
            {
                var element = driver.FindElement(By.XPath("//*[@id=\"congKhaiGia\"]/div[2]/div/div/div[3]/a[3]"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("var evt = document.createEvent('MouseEvents');" + "evt.initMouseEvent('click',true, true, window, 0, 0, 0, 0, 0, false, false, false, false, 0,null);" + "arguments[0].dispatchEvent(evt);", element);
            }
                
            

        }
    }
}
