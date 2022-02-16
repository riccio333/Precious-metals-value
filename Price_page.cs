using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Precious_metals_value
{
    public partial class Price_page : System.Windows.Forms.Form
    {
        public Price_page()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GetAPIKey()
        {
            string APIKeyFile = Environment.CurrentDirectory + @"\APIKeys\APIKey.txt";
            string helpFile = Environment.CurrentDirectory + @"\APIKeys\help.txt";
            string APIKeyusdeur = Environment.CurrentDirectory + @"\APIKeys\APIKey usd-eur.txt";

            if (Directory.Exists(Environment.CurrentDirectory + @"\APIKeys"))
            {
                try
                {
                    string APIKey = File.ReadLines(APIKeyFile).First();
                }
                catch
                {
                    var result = MessageBox.Show("You need to put your APIKey in the APIKey.txt file. Do you want to open APIKey.txt?", "APIKey invalid", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    

                    if (result == DialogResult.Yes)
                    {
                        Process.Start("notepad.exe", APIKeyFile);
                    }
                    else if (result == DialogResult.No)
                    {
                        var close = MessageBox.Show("You can't use this program without an APIKey!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        if (close == DialogResult.OK)
                        {
                            Environment.Exit(0);
                        }
                    }

                    using (FileStream fs = File.Create(APIKeyFile));
                    {
                        //the API Key will go in there
                    }
                    using (FileStream fs = File.Create(APIKeyusdeur));
                    {
                        //the second API Key will go in there
                    }
                    using (FileStream fs = File.Create(helpFile));
                    {
                        System.IO.File.WriteAllText(helpFile, @"## How to get your APIKey for metals value:

-Go to https://www.goldapi.io/ and click the button 'get free api key or sign in' and choose your google account.

-Then the site will reditect you to the dashboard of the site. Copy your APIKey and paste it in the file called APIKey.txt


## How to get your APIKey for exchange value:

-Go to https://freecurrencyapi.net/ and click the button 'Get Free API Key' and create an account. 

-Verify your account and go to https://freecurrencyapi.net/dashboard

-Copy your APIKey and paste it in the file called APIKey usd-eur.txt");
                    }
                }
            }
            else
            {
                Directory.CreateDirectory("APIKeys");

                using (FileStream fs = File.Create(APIKeyFile));
                {
                    //the API Key will go in this .txt file
                }
                using (FileStream fs = File.Create(APIKeyusdeur));
                {
                    //the second API Key will go in there
                }
                using (FileStream fs = File.Create(helpFile));
                {
                    System.IO.File.WriteAllText(helpFile, @"## How to get your APIKey for metals value:

-Go to https://www.goldapi.io/ and click the button 'get free api key or sign in' and choose your google account.

-Then the site will reditect you to the dashboard of the site. Copy your APIKey and paste it in the file called APIKey.txt


## How to get your APIKey for exchange value:

-Go to https://freecurrencyapi.net/ and click the button 'Get Free API Key' and create an account. 

-Verify your account and go to https://freecurrencyapi.net/dashboard

-Copy your APIKey and paste it in the file called APIKey usd-eur.txt");
                }

                var result = MessageBox.Show("You need to put your APIKey in the APIKey.txt file. Do you want to open APIKey.txt?", "APIKey invalid", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Process.Start("notepad.exe", APIKeyFile);
                }
                else if (result == DialogResult.No)
                {
                    var close = MessageBox.Show("You can't use this program without an APIKey!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (close == DialogResult.OK)
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async Task GetGoldPrice()
        {
            GetAPIKey();

            string APIKeyFile = Environment.CurrentDirectory + @"\APIKeys\APIKey.txt";
            string APIKey = File.ReadLines(APIKeyFile).First();

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://www.goldapi.io/api/XAU/EUR"),
                Headers =
    {
        { "x-rapidapi-host", "https://www.goldapi.io/api/XAU/EUR" },
        { "x-access-token", APIKey},
    },
            };
            using (var response = await client.SendAsync(request))
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();

                    Gold gold = JsonConvert.DeserializeObject<Gold>(body);

                    double OuncesToGrams = gold.price / 31.1034768;

                    lbl_goldprice.Text = OuncesToGrams.ToString("0.00") + " €/g\n" + gold.price.ToString() + " €/otz";

                }
                else
                {
                    var isvalid = MessageBox.Show("APIKey invalid! Do you want to change it?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (isvalid == DialogResult.Yes)
                    {
                        Process.Start("notepad.exe", APIKeyFile);
                    }
                    else if (isvalid == DialogResult.No)
                    {
                        var close = MessageBox.Show("You can't use this program without an APIKey!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        if (close == DialogResult.OK)
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            }
        }

        public class Gold
        {
            public int timestamp { get; set; }
            public string metal { get; set; }
            public string currency { get; set; }
            public string exchange { get; set; }
            public string symbol { get; set; }
            public double prev_close_price { get; set; }
            public double open_price { get; set; }
            public double low_price { get; set; }
            public double high_price { get; set; }
            public int open_time { get; set; }
            public double price { get; set; }
            public double ch { get; set; }
            public double chp { get; set; }
            public double ask { get; set; }
            public double bid { get; set; }
        }

        private void gold_button_Click(object sender, EventArgs e)
        {
            GetGoldPrice();
        }

        private async Task GetSilverPrice()
        {
            GetAPIKey();
            string APIKeyFile = Environment.CurrentDirectory + @"\APIKeys\APIKey.txt";
            string APIKey = File.ReadLines(APIKeyFile).First();

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://www.goldapi.io/api/XAG/EUR"),
                Headers =
    {
        { "x-rapidapi-host", "https://www.goldapi.io/api/XAG/EUR" },
        { "x-access-token", APIKey},
    },
            };
            using (var response = await client.SendAsync(request))
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();

                    Silver silver = JsonConvert.DeserializeObject<Silver>(body);

                    double OuncesToGrams = silver.price / 31.1034768;
                    lbl_silverprice.Text = OuncesToGrams.ToString("0.000") + " €/g\n" + silver.price.ToString() + " €/otz";
                }
                else
                {
                    var isvalid = MessageBox.Show("APIKey invalid! Do you want to change it?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (isvalid == DialogResult.Yes)
                    {
                        Process.Start("notepad.exe", APIKeyFile);
                    }
                    else if (isvalid == DialogResult.No)
                    {
                        var close = MessageBox.Show("You can't use this program without an APIKey!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        if (close == DialogResult.OK)
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            }
        }

        public class Silver
        {
            public int timestamp { get; set; }
            public string metal { get; set; }
            public string currency { get; set; }
            public string exchange { get; set; }
            public string symbol { get; set; }
            public double prev_close_price { get; set; }
            public double open_price { get; set; }
            public double low_price { get; set; }
            public double high_price { get; set; }
            public int open_time { get; set; }
            public double price { get; set; }
            public double ch { get; set; }
            public double chp { get; set; }
            public double ask { get; set; }
            public double bid { get; set; }
        }

        private void silver_button_Click(object sender, EventArgs e)
        {
            GetSilverPrice();
        }

        private async Task GetPlatinumPrice()
        {
            GetAPIKey();
            string APIKeyFile = Environment.CurrentDirectory + @"\APIKeys\APIKey.txt";
            string APIKey = File.ReadLines(APIKeyFile).First();

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://www.goldapi.io/api/XPT/EUR"),
                Headers =
    {
        { "x-rapidapi-host", "https://www.goldapi.io/api/XPT/EUR" },
        { "x-access-token", APIKey},
    },
            };
            using (var response = await client.SendAsync(request))
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();

                    Platinum platinum = JsonConvert.DeserializeObject<Platinum>(body);

                    double OuncesToGrams = platinum.price / 31.1034768;
                    lbl_platinumprice.Text = OuncesToGrams.ToString("0.00") + " €/g\n" + platinum.price.ToString() + " €/otz";
                }
                else
                {
                    var isvalid = MessageBox.Show("APIKey invalid! Do you want to change it?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (isvalid == DialogResult.Yes)
                    {
                        Process.Start("notepad.exe", APIKeyFile);
                    }
                    else if (isvalid == DialogResult.No)
                    {
                        var close = MessageBox.Show("You can't use this program without an APIKey!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        if (close == DialogResult.OK)
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            }
        }

        private void siticoneRoundedButton2_Click_2(object sender, EventArgs e)
        {
            GetPlatinumPrice();
        }

        public class Platinum
        {
            public int timestamp { get; set; }
            public string metal { get; set; }
            public string currency { get; set; }
            public string exchange { get; set; }
            public string symbol { get; set; }
            public double prev_close_price { get; set; }
            public double open_price { get; set; }
            public double low_price { get; set; }
            public double high_price { get; set; }
            public int open_time { get; set; }
            public double price { get; set; }
            public double ch { get; set; }
            public double chp { get; set; }
            public double ask { get; set; }
            public double bid { get; set; }
        }

        private async Task GetPalladiumPrice()
        {
            GetAPIKey();
            string APIKeyFile = Environment.CurrentDirectory + @"\APIKeys\APIKey.txt";
            string APIKey = File.ReadLines(APIKeyFile).First();

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://www.goldapi.io/api/XPD/EUR"),
                Headers =
    {
        { "x-rapidapi-host", "https://www.goldapi.io/api/XPD/EUR" },
        { "x-access-token", APIKey},
    },
            };
            using (var response = await client.SendAsync(request))
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();

                    Palladium palladium = JsonConvert.DeserializeObject<Palladium>(body);

                    double OuncesToGrams = palladium.price / 31.1034768;
                    lbl_palladiumprice.Text = OuncesToGrams.ToString("0.00") + " €/g\n" + palladium.price.ToString() + " €/otz";
                }
                else
                {
                    var isvalid = MessageBox.Show("APIKey invalid! Do you want to change it?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (isvalid == DialogResult.Yes)
                    {
                        Process.Start("notepad.exe", APIKeyFile);
                    }
                    else if (isvalid == DialogResult.No)
                    {
                        var close = MessageBox.Show("You can't use this program without an APIKey!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        if (close == DialogResult.OK)
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            }
        }

        public class Palladium
        {
            public int timestamp { get; set; }
            public string metal { get; set; }
            public string currency { get; set; }
            public string exchange { get; set; }
            public string symbol { get; set; }
            public double prev_close_price { get; set; }
            public double open_price { get; set; }
            public double low_price { get; set; }
            public double high_price { get; set; }
            public int open_time { get; set; }
            public double price { get; set; }
            public double ch { get; set; }
            public double chp { get; set; }
            public double ask { get; set; }
            public double bid { get; set; }
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            GetPalladiumPrice();
        }

        private async Task GetAPIStats()
        {
            string APIKeyFile = Environment.CurrentDirectory + @"\APIKeys\APIKey.txt";
            string APIKey = File.ReadLines(APIKeyFile).First();

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://www.goldapi.io/api/stat"),
                Headers =
    {
        { "x-rapidapi-host", "https://www.goldapi.io/api/stat" },
        { "x-access-token", APIKey },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();

                    APIStats stats = JsonConvert.DeserializeObject<APIStats>(body);
                    MessageBox.Show("Your requests today: " + stats.requests_today.ToString() + "\nYour requests this month: " + stats.requests_month.ToString(), "Your APIKey Stats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var isvalid = MessageBox.Show("APIKey invalid! Do you want to change it?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (isvalid == DialogResult.Yes)
                    {
                        Process.Start("notepad.exe", APIKeyFile);
                    }
                    else if (isvalid == DialogResult.No)
                    {
                        var close = MessageBox.Show("You can't use this program without an APIKey!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        if (close == DialogResult.OK)
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            }
        }

        public class APIStats
        {
            public int requests_today { get; set; }
            public int requests_yesterday { get; set; }
            public int requests_month { get; set; }
            public int requests_last_month { get; set; }
        }

        private void siticoneRoundedButton4_Click(object sender, EventArgs e)
        {
            GetAPIStats();
        }

        private async Task GetAPIStatus()
        {
            string APIKeyFile = Environment.CurrentDirectory + @"\APIKeys\APIKey.txt";
            string APIKey = File.ReadLines(APIKeyFile).First();

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://www.goldapi.io/api/status"),
                Headers =
    {
        { "x-rapidapi-host", "https://www.goldapi.io/api/status" },
        { "x-access-token", APIKey },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();

                    APIStatus status = JsonConvert.DeserializeObject<APIStatus>(body);
                    MessageBox.Show("APIs are all fine.", "API Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("APIs are currenly offline.", "API Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public class APIStatus
        {
            public bool result { get; set; }
        }

        private void siticoneRoundedButton5_Click(object sender, EventArgs e)
        {
            GetAPIStatus();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            Calculate_page calculatepage = new Calculate_page();
            calculatepage.Show();
            this.Hide();
        }

        private void lab_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/riccio333/Precious-metals-value");
        }

        public Point mouseLocation;

        private void mouse_down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouse_move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void lbl_title_Click(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            int fontLength = Properties.Resources.MontserratAlternates_Medium.Length;
            byte[] fontdata = Properties.Resources.MontserratAlternates_Medium;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            int fontLength = Properties.Resources.PTMono_Regular.Length;
            byte[] fontdata = Properties.Resources.PTMono_Regular;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton6_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {

        }

        private void gold_groupbox_Enter(object sender, EventArgs e)
        {

        }

        private void platinum_groupbox_Enter(object sender, EventArgs e)
        {

        }

        private void calculate_button_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
