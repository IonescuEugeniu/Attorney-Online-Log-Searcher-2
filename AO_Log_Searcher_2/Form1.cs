using Microsoft.WindowsAPICodePack.Dialogs;
using System.Diagnostics;

namespace AO_Log_Searcher_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_mainPath_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog(); dialog.IsFolderPicker = true;
            if (tb_mainPath.Text != "")
            {
                dialog.InitialDirectory = tb_mainPath.Text;
            }
            else
            {
                string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
                dialog.InitialDirectory = strWorkPath;
            }
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                tb_mainPath.Text = dialog.FileName;
            }
        }

        private void tb_mainPath_TextChanged(object sender, EventArgs e)
        {
            cb_clientList.Items.Clear();
            try
            {
                string aopath = tb_mainPath.Text; List<string> clientList = new();
                foreach (string a in Directory.GetDirectories(aopath))
                {
                    foreach (string b in Directory.GetDirectories(a))
                    {
                        if (b.Contains(@"\logs"))
                        {
                            clientList.Add(b.Remove(0, aopath.Length));
                        }
                    }
                }
                cb_clientList.Items.AddRange(clientList.ToArray());
            }
            catch
            {
                return;
            }
        }

        private void cb_clientList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cb_clientList.SelectedItem != null)
                {
                    string selectedItem = cb_clientList.SelectedItem.ToString(); string[] s = new string[] { @"\logs", @"\logs\" };
                    if (selectedItem.EndsWith(s[0]))
                    {
                        selectedItem = selectedItem.Remove(selectedItem.Length - s[0].Length, s[0].Length);
                    }
                    if (selectedItem.EndsWith(s[1]))
                    {
                        selectedItem = selectedItem.Remove(selectedItem.Length - s[1].Length, s[1].Length);
                    }
                    tb_mainPath.Text += selectedItem;
                }
            }
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            rtb_logOutput.Clear();
            try
            {
                string[] terms = tb_terms.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries); terms = terms.Select(s => s.ToLowerInvariant()).ToArray();
                List<string> termsOptional = new List<string>(), termsRequired = new List<string>();
                for (int i = 0; i < terms.Length; i++)
                {
                    string term = terms[i];
                    switch (term[0])
                    {
                        case '?': { terms[i] = term.Remove(0, 1); termsOptional.Add(terms[i]); break; }
                        case '!': { terms[i] = term.Remove(0, 1); termsRequired.Add(terms[i]); break; }
                        default: { termsOptional.Add(term); break; }
                    }
                }
                string path = tb_mainPath.Text + cb_clientList.SelectedItem?.ToString();
                if (termsOptional.Count == 0 && termsRequired.Count == 0)
                {
                    rtb_logOutput.Text += "Search path is empty!";
                }
                else
                {
                    foreach (string file in Directory.GetFiles(path, "*.log", SearchOption.AllDirectories))
                    {
                        string[] lines = File.ReadAllLines(file);
                        var fileURL = new Uri(file);
                        foreach (string line in lines)
                        {
                            if (ArrayContainsAny(line, termsOptional) && ArrayContainsAll(line, termsRequired))
                            {
                                rtb_logOutput.Text += "<" + fileURL.AbsoluteUri + ">" + "\n" + line + "\n";
                            }
                        }
                    }
                }
            }
            catch
            {
                rtb_logOutput.Text += "Terms field is empty!";
            }
        }

        private void rtb_logOutput_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            var linkUri = new Uri(e.LinkText);
            new Process
            {
                StartInfo = new ProcessStartInfo(linkUri.LocalPath)
                {
                    UseShellExecute = true
                }
            }.Start();
        }

        private void tb_terms_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_search_Click(sender, e);
            }
        }

        private bool ArrayContainsAny(string line, List<string> list)
        {
            if (list.Count == 0)
            {
                return true;
            }
            int count = 0;
            foreach (string item in list)
            {
                if (line.ToLowerInvariant().Contains(item))
                {
                    count++;
                }
            }
            if (count > 0) { return true; }
            else { return false; }
        }

        private bool ArrayContainsAll(string line, List<string> list)
        {
            if (list.Count == 0)
            {
                return true;
            }
            int count = 0;
            foreach (string item in list)
            {
                if (line.ToLowerInvariant().Contains(item))
                {
                    count++;
                }
            }
            if (count == list.Count) { return true; }
            else { return false; }
        }
    }
}