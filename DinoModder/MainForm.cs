using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DinoModder
{
    public partial class MainForm : Form
    {
        ChromeDriver driver;
        public MainForm()
        {
            InitializeComponent();
        }

        private void control_mod_Click(object sender, EventArgs e)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(DataPacks.Mod1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChromeOptions options = new ChromeOptions();
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            driver = new ChromeDriver(driverService, new ChromeOptions());
            driver.Navigate().GoToUrl("chrome://dino");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(DataPacks.GenerateAutoObstacleBySpeed(numericUpDown1.Value.ToString()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript($"var element = document.getElementById('offline-resources-2x');\nelement.setAttribute('src', '{DataPacks.DiamondPickaxe}');");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript($"var element = document.getElementById('offline-resources-2x');\nelement.setAttribute('src', '{DataPacks.DinoMiner}');");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript($"var element = document.getElementById('offline-resources-2x');\nelement.setAttribute('src', '{DataPacks.Unnamed}');");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(@"
            var max_id;
            max_id = setInterval(function() { });
            while (max_id--)
            {
                clearInterval(max_id);
            }
            Runner.instance_.setSpeed(6);
            ");
        }
    }
}
