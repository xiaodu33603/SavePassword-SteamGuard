using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace SavePass
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        SteamGuardAccount SteamGuardAccount = new SteamGuardAccount();
        private long steamTime = 0;
        private long currentSteamChunk = 0;

        private void loadAccountInfo()
        {
            txtLoginToken.Text = SteamGuardAccount.GenerateSteamGuardCode();
        }

        private void loadAccount()
        {
            if (radioButton1.Checked == true)
            {
                //这里是你的SharedSecret码
                SteamGuardAccount.SharedSecret = "xxxxxxxxxxxxxxxxxxxxxx"; 
            }
            else
            {
                //这里是你的SharedSecret码，这是两个账户
                SteamGuardAccount.SharedSecret = "xxxxxxxxxxxxxxxxxxxxxx";
            }
        }

        private async void timerSteamGuard_Tick(object sender, EventArgs e)
        {
            
            steamTime = await TimeAligner.GetSteamTimeAsync();
            

            currentSteamChunk = steamTime / 30L;
            int secondsUntilChange = (int)(steamTime - (currentSteamChunk * 30L));

            loadAccount();
            loadAccountInfo();
            pbTimeout.Value = 30 - secondsUntilChange;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (qq.Text != "")
            {
                Clipboard.SetText(qq.Text);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (wifi.Text != "")
            {
                Clipboard.SetText(wifi.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dsteam.Text != "")
            {
                Clipboard.SetText(dsteam.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (zsteam.Text != "")
            {
                Clipboard.SetText(zsteam.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ubisoft.Text != "")
            {
                Clipboard.SetText(ubisoft.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (bilibili.Text != "")
            {
                Clipboard.SetText(bilibili.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ps4.Text != "")
            {
                Clipboard.SetText(ps4.Text);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (zpyemal.Text != "")
            {
                Clipboard.SetText(zpyemal.Text);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ljhemail.Text != "")
            {
                Clipboard.SetText(ljhemail.Text);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (email.Text != "")
            {
                Clipboard.SetText(email.Text);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (admin.Text != "")
            {
                Clipboard.SetText(admin.Text);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (mysql.Text != "")
            {
                Clipboard.SetText(mysql.Text);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (admintor.Text != "")
            {
                Clipboard.SetText(admintor.Text);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (zpysteam.Text != "")
            {
                Clipboard.SetText(zpysteam.Text);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (zpyspass.Text != "")
            {
                Clipboard.SetText(zpyspass.Text);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (txtLoginToken.Text != "")
            {
                Clipboard.SetText(txtLoginToken.Text);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            SteamCode steamcode = new SteamCode();
            steamcode.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (dadyqq.Text != "")
            {
                Clipboard.SetText(dadyqq.Text);
            }
        }

    }
}
public class SteamGuardAccount
{


    public string SharedSecret;

    private static byte[] steamGuardCodeTranslations = new byte[] { 50, 51, 52, 53, 54, 55, 56, 57, 66, 67, 68, 70, 71, 72, 74, 75, 77, 78, 80, 81, 82, 84, 86, 87, 88, 89 };

    public string GenerateSteamGuardCode()
    {
        return GenerateSteamGuardCodeForTime(TimeAligner.GetSteamTime());
    }

    public string GenerateSteamGuardCodeForTime(long time)
    {
        if (this.SharedSecret == null || this.SharedSecret.Length == 0)
        {
            return "";
        }

        string sharedSecretUnescaped = Regex.Unescape(this.SharedSecret);
        byte[] sharedSecretArray = Convert.FromBase64String(sharedSecretUnescaped);
        byte[] timeArray = new byte[8];

        time /= 30L;

        for (int i = 8; i > 0; i--)
        {
            timeArray[i - 1] = (byte)time;
            time >>= 8;
        }

        HMACSHA1 hmacGenerator = new HMACSHA1();
        hmacGenerator.Key = sharedSecretArray;
        byte[] hashedData = hmacGenerator.ComputeHash(timeArray);
        byte[] codeArray = new byte[5];
        try
        {
            byte b = (byte)(hashedData[19] & 0xF);
            int codePoint = (hashedData[b] & 0x7F) << 24 | (hashedData[b + 1] & 0xFF) << 16 | (hashedData[b + 2] & 0xFF) << 8 | (hashedData[b + 3] & 0xFF);

            for (int i = 0; i < 5; ++i)
            {
                codeArray[i] = steamGuardCodeTranslations[codePoint % steamGuardCodeTranslations.Length];
                codePoint /= steamGuardCodeTranslations.Length;
            }
        }
        catch (Exception)
        {
            return null; //Change later, catch-alls are bad!
        }
        return Encoding.UTF8.GetString(codeArray);
    }
}
