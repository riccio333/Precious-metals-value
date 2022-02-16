using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Precious_metals_value
{
    public partial class Calculate_page : Form
    {
        public Calculate_page()
        {
            InitializeComponent();
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

                    using (FileStream fs = File.Create(APIKeyFile)) ;
                    {
                        //the API Key will go in there
                    }
                    using (FileStream fs = File.Create(helpFile)) ;
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

                using (FileStream fs = File.Create(APIKeyFile)) ;
                {
                    //the API Key will go in this .txt file
                }
                using (FileStream fs = File.Create(helpFile)) ;
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

        private void GetAPIKeyEURUSD()
        {
            string APIKeyFile = Environment.CurrentDirectory + @"\APIKeys\APIKey.txt";
            string helpFile = Environment.CurrentDirectory + @"\APIKeys\help.txt";
            string APIKeyusdeur = Environment.CurrentDirectory + @"\APIKeys\APIKey usd-eur.txt";

            if (Directory.Exists(Environment.CurrentDirectory + @"\APIKeys"))
            {
                try
                {
                    string APIKey = File.ReadLines(APIKeyusdeur).First();
                }
                catch
                {
                    var result = MessageBox.Show("You need to put your APIKey in the APIKey usd-eur.txt file. Do you want to open APIKey usd-eur.txt?", "APIKey invalid", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


                    if (result == DialogResult.Yes)
                    {
                        Process.Start("notepad.exe", APIKeyusdeur);
                    }
                    else if (result == DialogResult.No)
                    {
                        var close = MessageBox.Show("You can't use this program without an APIKey!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        if (close == DialogResult.OK)
                        {
                            Environment.Exit(0);
                        }
                    }

                    using (FileStream fs = File.Create(APIKeyusdeur));
                    {
                        //the second API Key will go in there
                    }
                    using (FileStream fs = File.Create(helpFile));
                    {
                        System.IO.File.WriteAllText(helpFile, @"---How to get your APIKey for metals value:

Go to https://www.goldapi.io/ and click the button 'get free api key or sign in' create an account.

When your account you will reditect to the dashboard of the site. Copy your APIKey and paste it in the file called APIKey.txt


---How to get your APIKey for exchange value:

Go to https://freecurrencyapi.net/ and click the button 'Get Free API Key' and create an account. 

Verify your account and go to https://freecurrencyapi.net/dashboard
**If you don't want to put your personal info, go to 'https://fake-it.ws/' and use that fake identity.**

Copy your APIKey and paste it in the file called APIKey usd-eur.txt");
                    }
                }
            }
            else
            {
                Directory.CreateDirectory("APIKeys");

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

                var result = MessageBox.Show("You need to put your APIKey usd-eur in the APIKey usd-eur.txt file. Do you want to open APIKey usd-eur.txt?", "APIKey invalid", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Process.Start("notepad.exe", APIKeyusdeur);
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

        private void calculateprice_button_Click(object sender, EventArgs e)
        {
            ValueToAnotherValue();
        }

        private async Task ValueToAnotherValue()
        {

            //EUR to USD


            if(cbx_values.SelectedIndex == 0)
            {

                double parse = 0;

                try
                {
                    parse = double.Parse(money_txt.Text);
                }
                catch
                {
                    if (calculated_value_txt.Text.Length == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        MessageBox.Show("Only numbers are valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                GetAPIKeyEURUSD();

                string APIKeyusdeur = Environment.CurrentDirectory + @"\APIKeys\APIKey usd-eur.txt";
                string APIKey = File.ReadLines(APIKeyusdeur).First();

                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://freecurrencyapi.net/api/v2/latest?apikey=" + APIKey + "&base_currency=EUR"),
                    Headers =
    {
        { "x-rapidapi-host", "https://freecurrencyapi.net/api/v2/latest?apikey=" + APIKey + "&base_currency=EUR"}
    },
                };

                using (var response = await client.SendAsync(request))
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        response.EnsureSuccessStatusCode();
                        var body = await response.Content.ReadAsStringAsync();

                        Root eurtousd = JsonConvert.DeserializeObject<Root>(body);

                        double EURtoUSD = parse * eurtousd.data.USD;
                        calculated_value_txt.Text = EURtoUSD.ToString("0.000") + " $";

                    }
                    else
                    {
                        var isvalid = MessageBox.Show("APIKey invalid! Do you want to change it?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                        if (isvalid == DialogResult.Yes)
                        {
                            Process.Start("notepad.exe", APIKeyusdeur);
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


            //USD to EUR


            else if(cbx_values.SelectedIndex == 1)
            {
                double parse = 0;

                try
                {
                    parse = double.Parse(money_txt.Text);
                }
                catch
                {
                    if (calculated_value_txt.Text.Length == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        MessageBox.Show("Only numbers are valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                GetAPIKeyEURUSD();

                string APIKeyusdeur = Environment.CurrentDirectory + @"\APIKeys\APIKey usd-eur.txt";
                string APIKey = File.ReadLines(APIKeyusdeur).First();

                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://freecurrencyapi.net/api/v2/latest?apikey=" + APIKey + "&base_currency=USD"),
                    Headers =
    {
        { "x-rapidapi-host", "https://freecurrencyapi.net/api/v2/latest?apikey=" + APIKey + "&base_currency=USD"}
    },
                };

                using (var response = await client.SendAsync(request))
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        response.EnsureSuccessStatusCode();
                        var body = await response.Content.ReadAsStringAsync();

                        Root usdtoeur = JsonConvert.DeserializeObject<Root>(body);

                        double EURtoUSD = parse * usdtoeur.data.EUR;
                        calculated_value_txt.Text = EURtoUSD.ToString("0.000") + " €";

                    }
                    else
                    {
                        var isvalid = MessageBox.Show("APIKey invalid! Do you want to change it?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                        if (isvalid == DialogResult.Yes)
                        {
                            Process.Start("notepad.exe", APIKeyusdeur);
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


            //EUR to GBP


            else if (cbx_values.SelectedIndex == 2)
            {
                double parse = 0;

                try
                {
                    parse = double.Parse(money_txt.Text);
                }
                catch
                {
                    if (calculated_value_txt.Text.Length == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        MessageBox.Show("Only numbers are valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                GetAPIKeyEURUSD();

                string APIKeyusdeur = Environment.CurrentDirectory + @"\APIKeys\APIKey usd-eur.txt";
                string APIKey = File.ReadLines(APIKeyusdeur).First();

                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://freecurrencyapi.net/api/v2/latest?apikey=" + APIKey + "&base_currency=EUR"),
                    Headers =
    {
        { "x-rapidapi-host", "https://freecurrencyapi.net/api/v2/latest?apikey=" + APIKey + "&base_currency=EUR"}
    },
                };

                using (var response = await client.SendAsync(request))
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        response.EnsureSuccessStatusCode();
                        var body = await response.Content.ReadAsStringAsync();

                        Root usdtoeur = JsonConvert.DeserializeObject<Root>(body);

                        double EURtoGBP = parse * usdtoeur.data.GBP;
                        calculated_value_txt.Text = EURtoGBP.ToString("0.000") + " £";

                    }
                    else
                    {
                        var isvalid = MessageBox.Show("APIKey invalid! Do you want to change it?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                        if (isvalid == DialogResult.Yes)
                        {
                            Process.Start("notepad.exe", APIKeyusdeur);
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


            //GBP to EUR


            else if(cbx_values.SelectedIndex == 3)
            {
                double parse = 0;

                try
                {
                    parse = double.Parse(money_txt.Text);
                }
                catch
                {
                    if (calculated_value_txt.Text.Length == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        MessageBox.Show("Only numbers are valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                GetAPIKeyEURUSD();

                string APIKeyusdeur = Environment.CurrentDirectory + @"\APIKeys\APIKey usd-eur.txt";
                string APIKey = File.ReadLines(APIKeyusdeur).First();

                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://freecurrencyapi.net/api/v2/latest?apikey=" + APIKey + "&base_currency=GBP"),
                    Headers =
    {
        { "x-rapidapi-host", "https://freecurrencyapi.net/api/v2/latest?apikey=" + APIKey + "&base_currency=GBP"}
    },
                };

                using (var response = await client.SendAsync(request))
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        response.EnsureSuccessStatusCode();
                        var body = await response.Content.ReadAsStringAsync();

                        Root usdtoeur = JsonConvert.DeserializeObject<Root>(body);

                        double EURtoUSD = parse * usdtoeur.data.EUR;
                        calculated_value_txt.Text = EURtoUSD.ToString("0.000") + " €";

                    }
                    else
                    {
                        var isvalid = MessageBox.Show("APIKey invalid! Do you want to change it?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                        if (isvalid == DialogResult.Yes)
                        {
                            Process.Start("notepad.exe", APIKeyusdeur);
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


            //combobox error


            else if (cbx_values.SelectedIndex == -1)
            {
                MessageBox.Show("You need to select a conversion first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class Query
        {
            public string apikey { get; set; }
            public int timestamp { get; set; }
            public string base_currency { get; set; }
        }

        public class Data
        {
            public double EUR { get; set; }
            public double USD { get; set; }
            public double GBP { get; set; }
        }

        public class Root
        {
            public Query query { get; set; }
            public Data data { get; set; }
        }

        private void weight_to_price_btn_Click(object sender, EventArgs e)
        {
            metals_error();
            measure_error();
            WeightToPrice();
        }

        private void metals_error()
        {
            if(cbx_metal.SelectedIndex == -1)
            {
                MessageBox.Show("You need to select a metal first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void measure_error()
        {
            if(cbx_measure.SelectedIndex == -1)
            {
                MessageBox.Show("You need to select a unit of measure!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task WeightToPrice()
        {
            GetAPIKey();

            //Gold

            if (cbx_metal.SelectedIndex == 0)
            {

                if (cbx_measure.SelectedIndex == 0)
                {
                    double parse = 0;

                    try
                    {
                        parse = double.Parse(txt_quantity.Text);
                    }
                    catch
                    {
                        if (txt_quantity.Text.Length == 0)
                        {
                            //nothing
                        }
                        else
                        {
                            MessageBox.Show("Only numbers are valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

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
                            double GramsToPrice = parse * OuncesToGrams;

                            lbl_price_measure.Text = GramsToPrice.ToString("0.0000") + " €";

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
                } else if (cbx_measure.SelectedIndex == 1)
                {
                    double parse = 0;

                    try
                    {
                        parse = double.Parse(txt_quantity.Text);
                    }
                    catch
                    {
                        if (txt_quantity.Text.Length == 0)
                        {
                            //nothing
                        }
                        else
                        {
                            MessageBox.Show("Only numbers are valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

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
                            double GramsToKgPrice = parse * OuncesToGrams * 1000;

                            lbl_price_measure.Text = GramsToKgPrice.ToString("0.000") + " €";

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
                } else if (cbx_measure.SelectedIndex == 2)
                { 
                    double parse = 0;

                    try
                    {
                        parse = double.Parse(txt_quantity.Text);
                    }
                    catch
                    {
                        if (txt_quantity.Text.Length == 0)
                        {
                            //nothing
                        }
                        else
                        {
                            MessageBox.Show("Only numbers are valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

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
                            double GramsToTonnPrice = parse * OuncesToGrams * 1000000;

                            lbl_price_measure.Text = GramsToTonnPrice.ToString("0.0") + " €";

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
                } else if (cbx_measure.SelectedIndex == 3)
                {
                    double parse = 0;

                    try
                    {
                        parse = double.Parse(txt_quantity.Text);
                    }
                    catch
                    {
                        if (txt_quantity.Text.Length == 0)
                        {
                            //nothing
                        }
                        else
                        {
                            MessageBox.Show("Only numbers are valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

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

                            double OztToOz = gold.price / 1.0971;
                            double GramsToOzPrice = parse * OztToOz;

                            lbl_price_measure.Text = GramsToOzPrice.ToString("0.00") + " €";

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
                } else if (cbx_measure.SelectedIndex == 4)
                {
                    double parse = 0;

                    try
                    {
                        parse = double.Parse(txt_quantity.Text);
                    }
                    catch
                    {
                        if (txt_quantity.Text.Length == 0)
                        {
                            //nothing
                        }
                        else
                        {
                            MessageBox.Show("Only numbers are valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

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

                            double Otz = gold.price;
                            double OtzToPrice = parse * Otz;

                            lbl_price_measure.Text = OtzToPrice.ToString("0.00") + " €";

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
            }



            //Silver



            if(cbx_metal.SelectedIndex == 1)
            {
                if(cbx_measure.SelectedIndex == 0)
                {
                    double parse = 0;

                    try
                    {
                        parse = double.Parse(txt_quantity.Text);
                    }
                    catch
                    {
                        if (txt_quantity.Text.Length == 0)
                        {
                            //nothing
                        }
                        else
                        {
                            MessageBox.Show("Only numbers are valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

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
                            double GramsToPrice = parse * OuncesToGrams;

                            lbl_price_measure.Text = GramsToPrice.ToString("0.0000") + " €";

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
                else if (cbx_measure.SelectedIndex == 1)
                {
                    double parse = 0;

                    try
                    {
                        parse = double.Parse(txt_quantity.Text);
                    }
                    catch
                    {
                        if (txt_quantity.Text.Length == 0)
                        {
                            //nothing
                        }
                        else
                        {
                            MessageBox.Show("Only numbers are valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

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
                            double GramsToKgPrice = parse * OuncesToGrams * 1000;

                            lbl_price_measure.Text = GramsToKgPrice.ToString("0.000") + " €";

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
                else if (cbx_measure.SelectedIndex == 2)
                {
                    double parse = 0;

                    try
                    {
                        parse = double.Parse(txt_quantity.Text);
                    }
                    catch
                    {
                        if (txt_quantity.Text.Length == 0)
                        {
                            //nothing
                        }
                        else
                        {
                            MessageBox.Show("Only numbers are valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

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
                            double GramsToTonnPrice = parse * OuncesToGrams * 1000000;

                            lbl_price_measure.Text = GramsToTonnPrice.ToString("0.0") + " €";

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
                else if (cbx_measure.SelectedIndex == 3)
                {
                    double parse = 0;

                    try
                    {
                        parse = double.Parse(txt_quantity.Text);
                    }
                    catch
                    {
                        if (txt_quantity.Text.Length == 0)
                        {
                            //nothing
                        }
                        else
                        {
                            MessageBox.Show("Only numbers are valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

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

                            double OztToOz = silver.price / 1.0971;
                            double GramsToOzPrice = parse * OztToOz;

                            lbl_price_measure.Text = GramsToOzPrice.ToString("0.00") + " €";

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
                else if (cbx_measure.SelectedIndex == 4)
                {
                    double parse = 0;

                    try
                    {
                        parse = double.Parse(txt_quantity.Text);
                    }
                    catch
                    {
                        if (txt_quantity.Text.Length == 0)
                        {
                            //nothing
                        }
                        else
                        {
                            MessageBox.Show("Only numbers are valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

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

                            double Otz = silver.price;
                            double OtzToPrice = parse * Otz;

                            lbl_price_measure.Text = OtzToPrice.ToString("0.00") + " €";

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
            }



            //Platinum



            if(cbx_metal.SelectedIndex == 2)
            {
                if (cbx_measure.SelectedIndex == 0)
                {
                    double parse = 0;

                    try
                    {
                        parse = double.Parse(txt_quantity.Text);
                    }
                    catch
                    {
                        if (txt_quantity.Text.Length == 0)
                        {
                            //nothing
                        }
                        else
                        {
                            MessageBox.Show("Only numbers are valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

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
                            double GramsToPrice = parse * OuncesToGrams;

                            lbl_price_measure.Text = GramsToPrice.ToString("0.0000") + " €";

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
                else if (cbx_measure.SelectedIndex == 1)
                {
                    double parse = 0;

                    try
                    {
                        parse = double.Parse(txt_quantity.Text);
                    }
                    catch
                    {
                        if (txt_quantity.Text.Length == 0)
                        {
                            //nothing
                        }
                        else
                        {
                            MessageBox.Show("Only numbers are valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

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
                            double GramsToKgPrice = parse * OuncesToGrams * 1000;

                            lbl_price_measure.Text = GramsToKgPrice.ToString("0.000") + " €";

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
                else if (cbx_measure.SelectedIndex == 2)
                {
                    double parse = 0;

                    try
                    {
                        parse = double.Parse(txt_quantity.Text);
                    }
                    catch
                    {
                        if (txt_quantity.Text.Length == 0)
                        {
                            //nothing
                        }
                        else
                        {
                            MessageBox.Show("Only numbers are valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

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
                            double GramsToTonnPrice = parse * OuncesToGrams * 1000000;

                            lbl_price_measure.Text = GramsToTonnPrice.ToString("0.0") + " €";

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
                else if (cbx_measure.SelectedIndex == 3)
                {
                    double parse = 0;

                    try
                    {
                        parse = double.Parse(txt_quantity.Text);
                    }
                    catch
                    {
                        if (txt_quantity.Text.Length == 0)
                        {
                            //nothing
                        }
                        else
                        {
                            MessageBox.Show("Only numbers are valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

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

                            double OztToOz = platinum.price / 1.0971;
                            double GramsToOzPrice = parse * OztToOz;

                            lbl_price_measure.Text = GramsToOzPrice.ToString("0.00") + " €";

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
                else if (cbx_measure.SelectedIndex == 4)
                {
                    double parse = 0;

                    try
                    {
                        parse = double.Parse(txt_quantity.Text);
                    }
                    catch
                    {
                        if (txt_quantity.Text.Length == 0)
                        {
                            //nothing
                        }
                        else
                        {
                            MessageBox.Show("Only numbers are valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

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

                            double Otz = platinum.price;
                            double OtzToPrice = parse * Otz;

                            lbl_price_measure.Text = OtzToPrice.ToString("0.00") + " €";

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
            }



            //Palladium



            if(cbx_metal.SelectedIndex == 3)
            {
                if (cbx_measure.SelectedIndex == 0)
                {
                    double parse = 0;

                    try
                    {
                        parse = double.Parse(txt_quantity.Text);
                    }
                    catch
                    {
                        if (txt_quantity.Text.Length == 0)
                        {
                            //nothing
                        }
                        else
                        {
                            MessageBox.Show("Only numbers are valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

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
                            double GramsToPrice = parse * OuncesToGrams;

                            lbl_price_measure.Text = GramsToPrice.ToString("0.0000") + " €";

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
                else if (cbx_measure.SelectedIndex == 1)
                {
                    double parse = 0;

                    try
                    {
                        parse = double.Parse(txt_quantity.Text);
                    }
                    catch
                    {
                        if (txt_quantity.Text.Length == 0)
                        {
                            //nothing
                        }
                        else
                        {
                            MessageBox.Show("Only numbers are valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

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
                            double GramsToKgPrice = parse * OuncesToGrams * 1000;

                            lbl_price_measure.Text = GramsToKgPrice.ToString("0.000") + " €";

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
                else if (cbx_measure.SelectedIndex == 2)
                {
                    double parse = 0;

                    try
                    {
                        parse = double.Parse(txt_quantity.Text);
                    }
                    catch
                    {
                        if (txt_quantity.Text.Length == 0)
                        {
                            //nothing
                        }
                        else
                        {
                            MessageBox.Show("Only numbers are valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

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
                            double GramsToTonnPrice = parse * OuncesToGrams * 1000000;

                            lbl_price_measure.Text = GramsToTonnPrice.ToString("0.0") + " €";

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
                else if (cbx_measure.SelectedIndex == 3)
                {
                    double parse = 0;

                    try
                    {
                        parse = double.Parse(txt_quantity.Text);
                    }
                    catch
                    {
                        if (txt_quantity.Text.Length == 0)
                        {
                            //nothing
                        }
                        else
                        {
                            MessageBox.Show("Only numbers are valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

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

                            double OztToOz = palladium.price / 1.0971;
                            double GramsToOzPrice = parse * OztToOz;

                            lbl_price_measure.Text = GramsToOzPrice.ToString("0.00") + " €";

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
                else if (cbx_measure.SelectedIndex == 4)
                {
                    double parse = 0;

                    try
                    {
                        parse = double.Parse(txt_quantity.Text);
                    }
                    catch
                    {
                        if (txt_quantity.Text.Length == 0)
                        {
                            //nothing
                        }
                        else
                        {
                            MessageBox.Show("Only numbers are valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

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

                            double Otz = palladium.price;
                            double OtzToPrice = parse * Otz;

                            lbl_price_measure.Text = OtzToPrice.ToString("0.00") + " €";

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

        private async Task UsdEurAPIStatus()
        {

        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            UsdEurAPIStatus();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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

        private void price_button_Click(object sender, EventArgs e)
        {
            Price_page pricepage = new Price_page();
            pricepage.Show();
            this.Hide();
        }

        private void lab_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/riccio333/Precious-metals-value");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void calculated_value_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
