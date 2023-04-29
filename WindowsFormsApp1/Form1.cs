using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        WebDriver driver = new ChromeDriver();
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Form1()
        {
            InitializeComponent();
            Form_load();
        }

        private void Form_load()
        {
            driver.Navigate().GoToUrl("https://kekhaigiattbyt.moh.gov.vn/cong-khai-gia");
            //sẽ khởi tạo Xpath tùy chỉnh theo website, nhập vào textbox....
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var op = new ChromeOptions();
            // op.DebuggerAddress = "127.0.0.1:9999";        

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromHours(1));
            var element_page_next = wait.Until(driver=> driver.FindElement(By.XPath("//*[@id=\"congKhaiGia\"]/div[2]/div/div/div[3]/a[3]")));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            String data,data2 = "";
            int step = 1;
            int rowSize =wait.Until(driver=> driver.FindElements(By.XPath("//table/tbody/tr"))).Count;
            try
            {
                do
                {
                    for (int row = 1; row <= rowSize; row++)
                    {

                        string c1 = wait.Until(driver => driver.FindElement(By.XPath("//*[@id=\"congKhaiGia\"]/div[2]/div/div/div[2]/table/tbody/tr[" + row + "]/td[1]/div"))).Text + "|";
                        string c2 = wait.Until(driver => driver.FindElement(By.XPath("//*[@id=\"congKhaiGia\"]/div[2]/div/div/div[2]/table/tbody/tr[" + row + "]/td[2]"))).Text + "|";
                        string c3 = wait.Until(driver => driver.FindElement(By.XPath("//*[@id=\"congKhaiGia\"]/div[2]/div/div/div[2]/table/tbody/tr[" + row + "]/td[3]"))).Text + "|";
                        string c4 = wait.Until(driver => driver.FindElement(By.XPath("//*[@id=\"congKhaiGia\"]/div[2]/div/div/div[2]/table/tbody/tr[" + row + "]/td[4]/a/b"))).Text + "[";
                        string c5 = wait.Until(driver => driver.FindElement(By.XPath("//*[@id=\"congKhaiGia\"]/div[2]/div/div/div[2]/table/tbody/tr[" + row + "]/td[4]/span/i"))).Text + "]|";
                        string c6 = wait.Until(driver => driver.FindElement(By.XPath("//*[@id=\"congKhaiGia\"]/div[2]/div/div/div[2]/table/tbody/tr[" + row + "]/td[5]"))).Text + "|";
                        string c7 = wait.Until(driver => driver.FindElement(By.XPath("//*[@id=\"congKhaiGia\"]/div[2]/div/div/div[2]/table/tbody/tr[" + row + "]/td[6]"))).Text + "|";
                        string c8 = wait.Until(driver => driver.FindElement(By.XPath("//*[@id=\"congKhaiGia\"]/div[2]/div/div/div[2]/table/tbody/tr[" + row + "]/td[7]/div"))).Text + "|";
                        string c9 = wait.Until(driver => driver.FindElement(By.XPath("//*[@id=\"congKhaiGia\"]/div[2]/div/div/div[2]/table/tbody/tr[" + row + "]/td[8]/div"))).Text.Replace("\r\n", "-") + "|";
                        //string c10 = wait.Until(driver => driver.FindElement(By.XPath("//*[@id=\"congKhaiGia\"]/div[2]/div/div/div[2]/table/tbody/tr[" + row + "]/td[8]/div/span"))).Text + "]|";--trạng thái hiệu lực màu xanh ko lấy
                        string c11 = wait.Until(driver => driver.FindElement(By.XPath("//*[@id=\"congKhaiGia\"]/div[2]/div/div/div[2]/table/tbody/tr[" + row + "]/td[9]"))).Text + "|";
                        string c12 = wait.Until(driver => driver.FindElement(By.XPath("//*[@id=\"congKhaiGia\"]/div[2]/div/div/div[2]/table/tbody/tr[" + row + "]/td[10]"))).Text + "|";
                        string c13 = wait.Until(driver => driver.FindElement(By.XPath("//*[@id=\"congKhaiGia\"]/div[2]/div/div/div[2]/table/tbody/tr[" + row + "]/td[11]"))).Text + "|";
                        string c14 = wait.Until(driver => driver.FindElement(By.XPath("//*[@id=\"congKhaiGia\"]/div[2]/div/div/div[2]/table/tbody/tr[" + row + "]/td[12]"))).Text + "|";
                        string c15 = wait.Until(driver => driver.FindElement(By.XPath("//*[@id=\"congKhaiGia\"]/div[2]/div/div/div[2]/table/tbody/tr[" + row + "]/td[13]"))).Text + "|";
                        string c16 = wait.Until(driver => driver.FindElement(By.XPath("//*[@id=\"congKhaiGia\"]/div[2]/div/div/div[2]/table/tbody/tr[" + row + "]/td[14]"))).Text + "|";
                        string c17 = wait.Until(driver => driver.FindElement(By.XPath("//*[@id=\"congKhaiGia\"]/div[2]/div/div/div[2]/table/tbody/tr[" + row + "]/td[15]"))).Text + "|";
                        string c18 = wait.Until(driver => driver.FindElement(By.XPath("//*[@id=\"congKhaiGia\"]/div[2]/div/div/div[2]/table/tbody/tr[" + row + "]/td[16]/span[1]"))).Text + "[";
                        string c19 = wait.Until(driver => driver.FindElement(By.XPath("//*[@id=\"congKhaiGia\"]/div[2]/div/div/div[2]/table/tbody/tr[" + row + "]/td[16]/span[2]/i"))).Text + "]|";
                        string c20 = wait.Until(driver => driver.FindElement(By.XPath("//*[@id=\"congKhaiGia\"]/div[2]/div/div/div[2]/table/tbody/tr[" + row + "]/td[17]"))).Text + "\r\n";
                        data = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c11 + c12 + c13 + c14 + c15 + c16 + c17 + c18 + c19 + c20;
                        data2 += data;
                        

                    }
                    step++;
                    js.ExecuteScript("var evt = document.createEvent('MouseEvents');" + "evt.initMouseEvent('click',true, true, window, 0, 0, 0, 0, 0, false, false, false, false, 0,null);" + "arguments[0].dispatchEvent(evt);", element_page_next);
                }
                while (step <3);
                //while (element_page_next != null);
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt"), true))
                {
                    outputFile.WriteLine(data2);
                }
            }
            catch(Exception ex)
            {
                new Exception("finish!");
            }
            finally { driver.Quit(); };           

        }
    }
}
