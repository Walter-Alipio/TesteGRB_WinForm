using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace TesteGRB_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                Robot test = new Robot();
                test.GetInfoCep("08534000");
            }
            catch (NullReferenceException error)
            {
                Console.WriteLine(error.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string path = Directory.GetCurrentDirectory();

           IWebDriver driver = new ChromeDriver(path);

           

            driver.Navigate().GoToUrl("www.jetconsulta.com.br");

            System.Threading.Thread.Sleep(5000);
        }
    }
}
