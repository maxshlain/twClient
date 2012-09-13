using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Twitterizer;

namespace twClient
{
    public partial class Form1 : Form
    {
        string consumerKey = Properties.Settings.Default.consumerKey;
        string consumerSecret = Properties.Settings.Default.consumerSecret;
        string callbackAddy = "oob";
        OAuthTokenResponse tokenResponse2 = new OAuthTokenResponse();


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            OAuthTokenResponse tokenResponse = new OAuthTokenResponse();
            tokenResponse = Twitterizer.OAuthUtility.GetRequestToken(consumerKey, consumerSecret, callbackAddy);
            string pin = "";

            if (string.IsNullOrEmpty(Properties.Settings.Default.pinSaved))
            {
                // Need to check if the user is a valid user.

                //OAuthTokenResponse tokenResponse = new OAuthTokenResponse();
                tokenResponse = Twitterizer.OAuthUtility.GetRequestToken(consumerKey, consumerSecret, callbackAddy);
                txt_login.Text = "Token is:  " + tokenResponse.Token.ToString();

                string target = "http://twitter.com/oauth/authorize?oauth_token=" + tokenResponse.Token;
                try
                {
                    System.Diagnostics.Process.Start(target);
                }
                catch (System.ComponentModel.Win32Exception noBrowser)
                {
                    if (noBrowser.ErrorCode == -2147467259)
                        MessageBox.Show(noBrowser.Message);
                }
                catch (System.Exception other)
                {
                    MessageBox.Show(other.Message);
                }

                pin = "2279180"; //This WILL NOT WORK. User needs to enter the PIN
                EnterPin enterpin = new EnterPin();
                enterpin.ShowDialog(); //show dialog causes it to wait for user input. Show() would not work
                pin = Properties.Settings.Default.pin;
            }
            else {
                pin = Properties.Settings.Default.pinSaved;
            }

            
             tokenResponse2 = OAuthUtility.GetAccessToken(consumerKey, consumerSecret, tokenResponse.Token, pin);
             txt_login.Text = "App "+ tokenResponse2.ScreenName.ToString()+" access allowed.";

        }

        private void btn_tweet_Click(object sender, EventArgs e)
        {

            OAuthTokens tokens = new OAuthTokens();
            //tokens.AccessToken = tokenResponse2.Token; // 15083553-ytdhRbkwCAavvQXpbW01NtKbwCAuOXcsZIBpLJlvw
            //tokens.AccessTokenSecret = tokenResponse2.TokenSecret; //f8dnabiXlmnilGyUllRrgwQX8pL85sCunOf5OvOXf0
            //tokens.ConsumerKey = consumerKey; // YWm9zyLW7gFSvV2EsVbQ
            //tokens.ConsumerSecret = consumerSecret; // W9d57yqhAbLV8rZB1syx3V06U6kmDtCNxxlaFkGpSg


            tokens.AccessToken = "15083553-ytdhRbkwCAavvQXpbW01NtKbwCAuOXcsZIBpLJlvw";
            tokens.AccessTokenSecret = "f8dnabiXlmnilGyUllRrgwQX8pL85sCunOf5OvOXf0";
            tokens.ConsumerKey = "YWm9zyLW7gFSvV2EsVbQ";
            tokens.ConsumerSecret = "W9d57yqhAbLV8rZB1syx3V06U6kmDtCNxxlaFkGpSg";

            //TwitterStatus tweetResponse = new TwitterStatus();
            TwitterResponse<TwitterStatus> tweetResponse = TwitterStatus.Update(tokens, txt_tweet.Text);
            if (tweetResponse.Result == RequestResult.Success)
            {
                txt_tweet.AppendText(" Update Successful.");
            }
            else
            {
                txt_tweet.AppendText(" Update did not go through.");
            }

        }
    }
}
