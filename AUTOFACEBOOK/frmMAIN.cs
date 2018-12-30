using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using System.IO;
using System.Xml.Serialization;
using System.Net.Http;
using HtbSolutions;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AUTOFACEBOOK
{
    public partial class frmMAIN : Form
    {
        private static int[] timer = { 30, 35, 40, 45, 50, 55, 60};
        private static readonly string xmlpath = @"C:\ProgramData\AutoFacebook.xml";
        private static List<UserData> db = new List<UserData>();
        private static List<Thread> dt = new List<Thread>();
        private static XmlSerializer xmlseri;
        private static string[] msg_cont;
        
        public frmMAIN()
        {
            using (FileStream file = new FileStream(xmlpath, FileMode.OpenOrCreate, FileAccess.Read))
            {
                xmlseri = new XmlSerializer(typeof(List<UserData>));
                try { db = xmlseri.Deserialize(file) as List<UserData>; } catch { }
                file.Close();
                file.Dispose();
            }
            InitializeComponent();
        }

        private void frmMAIN_Load(object sender, EventArgs e)
        {
            db.ForEach(o => lstLACC.Items.Add(o.Email));
            foreach (string content in File.ReadAllLines("message.txt"))
            { lstLCOM.Items.Add(content); }
        }

        private void frmMAIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllLines("message.txt", lstLCOM.Items.OfType<string>());
        }

        private void frmMAIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (FileStream file = new FileStream(xmlpath, FileMode.Create, FileAccess.Write))
            {
                xmlseri = new XmlSerializer(typeof(List<UserData>));
                xmlseri.Serialize(file, db);
                file.Close();
                file.Dispose();
            }
            if (db != null) db.Clear();
        }

        private void btnACOM_Click(object sender, EventArgs e)
        {
            string content = Microsoft.VisualBasic.Interaction.InputBox("NỘI DUNG BÌNH LUẬN:");
            if (content != "") lstLCOM.Items.Add(content); 
        }

        private void btnDCOM_Click(object sender, EventArgs e)
        {
            lstLCOM.Items.Remove(lstLCOM.SelectedItem);
        }

        private void btnAACC_Click(object sender, EventArgs e)
        {
            // DESIGN DIALOG FORM
            Form dialog = new Form()
            {
                Width = 415,
                Height = 125,
                MinimizeBox = false,
                MaximizeBox = false,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
                Text = "Login Form To Input",
            };

            // ADDING CONTROL TO DIALOG FORM
            dialog.Controls.Add(new Label() { Left = 20, Top = 20, Width = 40, Text = "EMAIL" });
            dialog.Controls.Add(new Label() { Left = 20, Top = 50, Width = 40, Text = "PASS" });
            dialog.Controls.Add(new TextBox() { Left = 70, Top = 16, Width = 240 });
            dialog.Controls.Add(new TextBox() { Left = 70, Top = 46, Width = 240, UseSystemPasswordChar = true });
            Button result = new Button() { Text = "OK", Left = 325, Top = 15, Width = 60, Height = 52, DialogResult = DialogResult.OK };
            dialog.Controls.Add(result);
            dialog.AcceptButton = result;

            // CREATE EVENT FOR OK BUTTON
            result.Click += (send, evnt) =>
            {
                // GET EMAIL AND PASSWORD FROM USER
                string Email = dialog.Controls[2].Text;
                string Passw = dialog.Controls[3].Text;

                // REQUIRED USER AND PASS TO LOGIN
                if (Email == "" || Passw == "")
                {
                    MessageBox.Show("Vui lòng điền tên tài khoản và mật khẩu để đăng nhập.");
                    dialog.DialogResult = DialogResult.None;
                    return;
                }

                // HIDDEN DIALOG FORM AND CREATE NEW USERDATA
                dialog.Close();
                UserData account = new UserData();
                account.Cookie = new List<string>();
                account.PostData = new List<Thread>();
                account.Email = Email;
                string fb_dtsg_token;

                using (HttpClient http = new HttpClient() { BaseAddress = new Uri("https://www.facebook.com/") })
                {
                    http.DefaultRequestHeaders.UserAgent.ParseAdd(
                        "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36"); // Set Google Browser

                    // ACTIVATION FACEBOOK COOKIE
                    HttpResponseMessage response = http.GetAsync("").Result;
                    foreach (string cookie in response.Headers.GetValues("Set-Cookie"))
                    {
                        account.Cookie.Add(cookie.Substring(0, cookie.IndexOf(';')));
                        http.DefaultRequestHeaders.Add("Cookie", cookie.Substring(0, cookie.IndexOf(';')));
                    }

                    // CREATE POST DATA TO LOGIN FACEBOOK
                    var Data = new List<KeyValuePair<string, string>>();
                    Data.Add(new KeyValuePair<string, string>("email", Email));
                    Data.Add(new KeyValuePair<string, string>("pass", Passw));
                    Data.Add(new KeyValuePair<string, string>("locale", "vi_VN"));
                    Data.Add(new KeyValuePair<string, string>("next", "https://www.facebook.com/"));
                    Data.Add(new KeyValuePair<string, string>("login_source", "login_bluebar"));
                    Data.Add(new KeyValuePair<string, string>("prefill_contact_point", Email));
                    Data.Add(new KeyValuePair<string, string>("prefill_source", "last_login"));
                    Data.Add(new KeyValuePair<string, string>("prefill_type", "contact_point"));

                    // POST LOGIN DATA TO FACEBOOK
                    response = http.PostAsync("login/device-based/regular/login/?login_attempt=1&lwv=111", new FormUrlEncodedContent(Data)).Result;
                    foreach (string cookie in response.Headers.GetValues("Set-Cookie"))
                    {
                        account.Cookie.Add(cookie.Substring(0, cookie.IndexOf(';')));
                        http.DefaultRequestHeaders.Add("Cookie", cookie.Substring(0, cookie.IndexOf(';')));
                    }

                    // GET FB_DTSG AND USER_ID TO CONFIRM ON APP
                    using (StreamReader source = new StreamReader(response.Content.ReadAsStreamAsync().Result))
                    {
                        string html = source.ReadToEndAsync().Result;
                        fb_dtsg_token = Regex.Match(html, "\"token\":\"(.*?)\"").Groups[1].Value;
                        account.ID = Regex.Match(html, "\"USER_ID\":\"(.*?)\"").Groups[1].Value;
                    }

                    // FACEBOOK ACCOUNT CHECKING
                    if (account.ID == "0")
                    {
                        MessageBox.Show("Không thể lấy USER_ID. Vui lòng kiểm tra Email và Mật khẩu.");
                        return;
                    }

                    // CREATE POST DATA TO GET ACCESS TOKEN OF THE PAGES MANAGE FOR IOS APP
                    Data = new List<KeyValuePair<string, string>>();
                    Data.Add(new KeyValuePair<string, string>("fb_dtsg", fb_dtsg_token));
                    Data.Add(new KeyValuePair<string, string>("app_id", "165907476854626"));
                    Data.Add(new KeyValuePair<string, string>("redirect_uri", "fbconnect://success"));
                    Data.Add(new KeyValuePair<string, string>("return_format", "access_token"));
                    Data.Add(new KeyValuePair<string, string>("from_post", "1"));
                    Data.Add(new KeyValuePair<string, string>("sso_device", "ios"));
                    Data.Add(new KeyValuePair<string, string>("__CONFIRM__", "1"));
                    Data.Add(new KeyValuePair<string, string>("ref", "Default"));
                    Data.Add(new KeyValuePair<string, string>("access_token", null));
                    Data.Add(new KeyValuePair<string, string>("sdk", null));
                    Data.Add(new KeyValuePair<string, string>("private", null));
                    Data.Add(new KeyValuePair<string, string>("tos", null));
                    Data.Add(new KeyValuePair<string, string>("login", null));
                    Data.Add(new KeyValuePair<string, string>("read", null));
                    Data.Add(new KeyValuePair<string, string>("write", null));
                    Data.Add(new KeyValuePair<string, string>("extended", null));
                    Data.Add(new KeyValuePair<string, string>("social_confirm", null));
                    Data.Add(new KeyValuePair<string, string>("confirm", null));
                    Data.Add(new KeyValuePair<string, string>("seen_scopes", null));
                    Data.Add(new KeyValuePair<string, string>("auth_type", null));
                    Data.Add(new KeyValuePair<string, string>("auth_token", null));
                    Data.Add(new KeyValuePair<string, string>("auth_nonce", null));
                    Data.Add(new KeyValuePair<string, string>("default_audience", null));
                    Data.Add(new KeyValuePair<string, string>("domain", null));
                    Data.Add(new KeyValuePair<string, string>("display", "popup"));

                    // GET ACCESS TOKEN OF THE PAGES MANAGE FOR IOS APP
                    response = http.PostAsync("v1.0/dialog/oauth/confirm", new FormUrlEncodedContent(Data)).Result;
                    using (StreamReader source = new StreamReader(response.Content.ReadAsStreamAsync().Result))
                    {
                        string html = source.ReadToEndAsync().Result;
                        account.Token = Regex.Match(html, "access_token=(.*?)&").Groups[1].Value;
                    }

                    // ADDING USERDATA TO DATABASE
                    db.Add(account);
                    lstLACC.Items.Add(Email);
                }
            };

            // SHOW AND RELEASE DIALOG
            dialog.ShowDialog();
            dialog.Dispose();
        }

        private void btnDACC_Click(object sender, EventArgs e)
        {
            string Email = lstLACC.GetItemText(lstLACC.SelectedItem);
            lstLACC.Items.Remove(lstLACC.SelectedItem);
            db.Remove(db.Find(o => (o.Email == Email)));
        }

        private void lstLACC_DoubleClick(object sender, EventArgs e)
        {
            string Email = lstLACC.GetItemText(lstLACC.SelectedItem);
            UserData account = db.Find(o => (o.Email == Email));
            if (account == null) return;

            Form dialog = new Form()
            {
                Width = 280,
                Height = 125,
                MinimizeBox = false,
                MaximizeBox = false,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
                Text = "Login Form To Input",
            };

            dialog.Controls.Add(new Label() { Left = 20, Top = 20, Width = 45, Text = "EMAIL:" });
            dialog.Controls.Add(new Label() { Left = 20, Top = 50, Width = 45, Text = "ID:" });
            dialog.Controls.Add(new Label() { Left = 70, Top = 20, Width = 240, Text = account.Email });
            dialog.Controls.Add(new Label() { Left = 70, Top = 50, Width = 240, Text = account.ID });
            dialog.ShowDialog();
            dialog.Dispose();
        }

        private void lstLACC_SelectedValueChanged(object sender, EventArgs e)
        {
            lstLPOST.Items.Clear();
            string Email = lstLACC.GetItemText(lstLACC.SelectedItem);
            UserData account = db.Find(o => (o.Email == Email));
            if (account == null) return;
            dt = account.PostData;
            dt.ForEach(o => lstLPOST.Items.Add(o.Link));
        }

        private void btnAPOST_Click(object sender, EventArgs e)
        {
            string Email = lstLACC.GetItemText(lstLACC.SelectedItem);
            UserData account = db.Find(o => (o.Email == Email));
            if (account == null) return;
            dt = account.PostData;
            string link = Microsoft.VisualBasic.Interaction.InputBox("LINK BÀI VIẾT");
            if (link != "") dt.Add(new Thread() { Link = link, ID = Facebook.GetPostID(link) });
            account.PostData = dt;
            lstLACC_SelectedValueChanged(sender, e);
        }

        private void btnDPOST_Click(object sender, EventArgs e)
        {
            string Email = lstLACC.GetItemText(lstLACC.SelectedItem);
            string Link = lstLPOST.GetItemText(lstLPOST.SelectedItem);
            UserData account = db.Find(o => (o.Email == Email));
            if (account == null) return;
            dt = account.PostData;
            dt.Remove(dt.Find(o => (o.Link == Link)));
            lstLPOST.Items.Remove(lstLPOST.SelectedItem);
            account.PostData = dt;
        }

        private void lstLPOST_DoubleClick(object sender, EventArgs e)
        {
            string Link = lstLPOST.GetItemText(lstLPOST.SelectedItem);
            if (Link == "") return;

            Form dialog = new Form()
            {
                Width = 280,
                Height = 110,
                MinimizeBox = false,
                MaximizeBox = false,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
                Text = "Link To Comment",
            };

            Link = Link.Replace(@"https://", null);
            Link = Link.Replace(@"facebook.com/", null);
            Link = Link.Replace(@"www.", null);

            dialog.Controls.Add(new Label() { Left = 15, Top = 15, Width = 45, Text = "LINK:" });
            dialog.Controls.Add(new Label() { Left = 60, Top = 15, Width = 180, Height = 100, Text = Link });
            dialog.ShowDialog();
            dialog.Dispose();
        }

        private void btnRUN_Click(object sender, EventArgs e)
        {
            msg_cont = lstLCOM.Items.OfType<string>().ToArray();
            if (msg_cont.Count() == 0) return;

            ///////////////////////////////////////
            this.Visible = false;
            NotifyIcon TrayIcon = new NotifyIcon();
            TrayIcon.Text = this.Text;
            TrayIcon.Icon = this.Icon;
            TrayIcon.Visible = true;

            ///////////////////////////////////////
            List<Task> ThreadPool = new List<Task>();
            db.ForEach(account => ThreadPool.Add(Task.Factory.StartNew(() => AutoComment(account))));
            Task.WaitAll(ThreadPool.ToArray());

            ///////////////////////////////////////
            TrayIcon.Visible = false;
            TrayIcon.Dispose();
            this.Visible = true;
        }

        private static void AutoComment(UserData account) 
        {
            using (HttpClient http = new HttpClient())
            {
                http.DefaultRequestHeaders.UserAgent.ParseAdd(
                    "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36"); // Set Google Browser
                account.Cookie.ForEach(o => http.DefaultRequestHeaders.Add("Cookie", o.ToString())); // Adding Cookies
 
                HttpResponseMessage response = http.GetAsync("https://b-api.facebook.com/restserver.php?" +
                    "method=auth.getSessionForApp&" +
                    "format=json&" + 
                    "access_token=" + account.Token + "&" +
                    "new_app_id=6628568379&" +
                    "generate_session_cookies=1&" +
                    "generate_machine_id=F04fXNiaGjP9KCrfwoF8SDs0&" +
                    "__mref=message_bubble").Result;

                using (StreamReader source = new StreamReader(response.Content.ReadAsStreamAsync().Result))
                {
                    string access_token = Regex.Match(source.ReadToEndAsync().Result, "\"access_token\":\"(.*?)\"").Groups[1].Value;
                    account.PostData.ForEach(o =>
                    {
                        http.GetAsync("https://graph.fb.me/" + o.ID +
                            "/comments?message=" + msg_cont[AutoIt.Random(0, msg_cont.Count() - 1)] +
                            "&access_token=" + access_token + "&method=post");
                        System.Threading.Thread.Sleep(timer[
                            AutoIt.Random(0, timer.Count() - 1)]
                            * 1000); // Set Delay Time
                    });
                }
            }
        }
    }
}