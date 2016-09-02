using System;
using System.Windows.Forms;
using Senparc.Weixin.HttpUtility;
using Senparc.Weixin.QY.CommonAPIs;
using Senparc.Weixin.QY.Containers;
using Senparc.Weixin.Helpers;
using System.Configuration;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Senparc.Weixin.QY.AdvancedAPIs;
using Senparc.Weixin.QY;

namespace QyWexin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tProxyHost.Text = GetConfig("ProxyHost");
            this.tProxyPort.Text = GetConfig("ProxyPort");
            this.tProxyName.Text = GetConfig("ProxyUsername");
            this.tProxyPassword.Text = GetConfig("ProxyPassword");

            this.tCorpId.Text = GetConfig("CorpId");
            this.tCorpSecret.Text = GetConfig("CorpSecret");

            this.tRtnMsg.Text = string.Empty;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string proxyHost = this.tProxyHost.Text;
            string proxyPort = this.tProxyPort.Text;
            string proxyName = this.tProxyName.Text;
            string proxyPassword = this.tProxyPassword.Text;

            string corpId = this.tCorpId.Text;
            string corpSecret = this.tCorpSecret.Text;

            try {

                //RequestUtility.SetHttpProxy(proxyHost, proxyPort, proxyName, proxyPassword);
                string token = AccessTokenContainer.TryGetToken(corpId, corpSecret);

                //上传图片
                if(!string.IsNullOrWhiteSpace(this.tPicPath.Text))
                {
                    if(!File.Exists(this.tPicPath.Text))
                    {
                        this.tRtnMsg.Text = "图片路径不存在！";
                        return;
                    }
                    else
                    {
                        string media = string.Format("Content-Disposition:form-data;name=\"file\";filename=\"{0}\"\r\nContent-Type:application/octet-stream\r\n\r\n", this.tPicPath.Text);
                        var uploadResult = MediaApi.UploadimgMedia(token, media);
                        this.tUploadPicUrl.Text = uploadResult.url;
                    }
                }

                var sendNewsUrl = "https://qyapi.weixin.qq.com/cgi-bin/message/send?access_token={0}";
                var result = CommonJsonSend.Send(token, sendNewsUrl, ConstructNewsData());
                this.tRtnMsg.Text = result.errcode + "  " + result.errmsg;
            }
            catch(Exception ex)
            {
                this.tRtnMsg.Text = ex.Message;
            }
        }

        private MessageNews ConstructNewsData()
        {
            var data = new MessageNews();
            var news = new news();
            var article = new Articles();

            data.touser = "@all";
            data.msgtype = "news";
            data.agentid = 0;

            news.articles = new List<Articles>();
            article.title = this.tTitle.Text;
            article.description = this.tDescription.Text;
            article.url = this.tUrl.Text;
            article.picurl = this.tUploadPicUrl.Text;
            news.articles.Add(article);

            data.news = news;

            return data;
        }

        private string GetConfig(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        private void SetConfig(string key, string value)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.tPicPath.Text = openFileDialog1.FileName;
            }
        }
    }
}
