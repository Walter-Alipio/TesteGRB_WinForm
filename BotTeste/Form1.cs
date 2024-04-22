using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace BotTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver(Directory.GetCurrentDirectory());

            driver.Navigate().GoToUrl("www.jetconsulta.com.br");
        }
    }
}
