
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TesteGRB_WinForm
{
    internal class Robot 
    {
        private ChromeDriver drive { get; set; }
        public Robot()
        {
            drive = new ChromeDriver();
        }

        public string GetInfoCep(string cep)
        {
            drive.Navigate().GoToUrl("https://www.google.com.br");

            drive.FindElement(By.XPath("//*[@id=\\'input\\']")).SendKeys("https://buscacepinter.correios.com.br/app/endereco/index.php");
            drive.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]")).Click();

            drive.FindElement(By.XPath("//*[@id=\\'endereco\\']")).SendKeys(cep);
            drive.FindElement(By.XPath("//*[@id=\'btn_pesquisar\']")).Click();
            return GetResult();
        }

        private string GetResult()
        {
            var logradouro = drive.FindElement(By.XPath("//*[@id=\'resultado-DNEC\']/tbody/tr/td[1]")).Text;
            var bairro = drive.FindElement(By.XPath("//*[@id=\'resultado-DNEC\']/tbody/tr/td[2]")).Text;
            var uf = drive.FindElement(By.XPath("//*[@id=\'resultado-DNEC\']/tbody/tr/td[3]")).Text;
            var cep = drive.FindElement(By.XPath("//*[@id=\'resultado-DNEC\']/tbody/tr/td[4]")).Text;

            var resultado = $"Logradouro {logradouro} | Bairro {bairro} | UF {uf} | CEP {cep}";
            return resultado;
        }
    }
}
