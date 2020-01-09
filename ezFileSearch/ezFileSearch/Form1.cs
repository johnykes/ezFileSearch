using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ezFileSearch
{
    public partial class form_main : Form
    {
        #region variables
        ez_SearchResult SR;
        ez_Sender       Sender;
        string atom_path    = @"D:\devcode\adm_ist\ezFileSearch\AtomPortable\AtomPortable.exe";
        string sublime_path = @"D:\devcode\adm_ist\ezFileSearch\SublimePortable\sublime_text";
        
        string serverTag   = "server:";
        string locationTag = "location:";
        string fileTag     = "file:";
        string user;
        string mainDirectory_path;
        #endregion variables

        #region objects
        public class ez_File
        {
            public FileInfo fi;
            public Button btn;
            public CheckBox cb;

            public ez_File()
            {
                fi  = null;
                btn = new Button();
                cb  = new CheckBox();
            }
        }
        public class ez_Loc
        {
            public List<ez_File> files;
            public Button btn;
            public string path;

            public ez_Loc()
            {
                files = new List<ez_File>();
                btn = new Button();
            }
        }
        public class ez_Srv
        {
            public List<ez_Loc> locations;
            public Button btn;

            public ez_Srv()
            {
                locations = new List<ez_Loc>();
                btn = new Button();
            }
        }
        public class ez_SearchResult
        {
            public List<ez_Srv> servers;
            public Button btn;

            public ez_SearchResult()
            {
                servers = new List<ez_Srv>();
                btn = new Button();
            }
        }
        public class ez_Sender
        {
            public string server;
            public string location;
            public string file;

            public ez_Sender()
            {
                server = string.Empty;
                location = string.Empty;
                file = string.Empty;
            }
        }
        #endregion objects

        public form_main()
        {
            InitializeComponent();

            // get user name in order to get the preferences
            user = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            user = user.Replace(user.Substring(0, user.LastIndexOf(@"\")+1), "");

            // get app folder location
            mainDirectory_path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location).Replace("ezFileSearch\\bin\\Debug", "");

            // try to get user details
            string json_text = string.Empty;
            string user_data_path = mainDirectory_path + @"\" + "Data" + @"\" + user + ".json";

            // get editors path
            atom_path    = mainDirectory_path + "\\Editors\\AtomPortable\\AtomPortable.exe";
            sublime_path = mainDirectory_path + "\\Editors\\SublimePortable\\sublime_text";
            //notepad++_path not needed, not portable

            try
            {
                json_text  = File.ReadAllText(user_data_path);
                JsonTextReader reader = new JsonTextReader(new StringReader(json_text));
                JObject o = (JObject)JToken.ReadFrom(reader);

                object test = o["servers"];

                foreach(var data in o["servers"])
                {
                    tb_serverList.AppendText(data + Environment.NewLine);
                }
                
                foreach(var data in o["locations"])
                {
                    tb_locationList.AppendText(data + Environment.NewLine);
                }

                foreach (var data in o["patterns"])
                {
                    tb_patternList.AppendText(data + Environment.NewLine);
                }

                tb_text.Text    = (string)o["text"];
                tb_newText.Text = (string)o["newText"];

                cb_editor.SelectedIndex = ((JToken)o["editorIdx"]).ToObject<int>();
            }
            catch
            {
                // create user json and directory if does not exists
                FileInfo file = new FileInfo(user_data_path);
                file.Directory.Create();
                File.WriteAllText(user_data_path, "{\n}");
            }

            // init global variables
            SR     = new ez_SearchResult();
            Sender = new ez_Sender();
        }

        private void form_main_Load(object sender, EventArgs e)
        {
            // set theme similar to atom one dark
            this.BackColor                   = Color.FromArgb(40, 44, 52);
            this.tb_serverList.BackColor     = Color.FromArgb(51, 56, 66);
            this.tb_locationList.BackColor   = Color.FromArgb(51, 56, 66);
            this.tb_patternList.BackColor    = Color.FromArgb(51, 56, 66);
            this.label_findFiles.BackColor   = Color.FromArgb(51, 56, 66);
            this.label_replaceText.BackColor = Color.FromArgb(51, 56, 66);
            this.cb_editor.BackColor         = Color.FromArgb(51, 56, 66);
            this.tb_text.BackColor           = Color.FromArgb(51, 56, 66);
            this.tb_newText.BackColor        = Color.FromArgb(51, 56, 66);
        }


        #region UI
        #region find files
        private void pb_findFiles_Click(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += findFiles;
            worker.RunWorkerAsync();
        }

        private void label_findFiles_Click(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += findFiles;
            worker.RunWorkerAsync();
        }
        #endregion find files
        #region replace text
        private void pb_replaceText_Click(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += replaceText;
            worker.RunWorkerAsync();
        }

        private void label_replaceText_Click(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += replaceText;
            worker.RunWorkerAsync();
        }
        #endregion replace text
        #region cb_editor_Safety
        private void cb_editor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }
        #endregion cb_editor_Safety
        #endregion UI

        #region backend
        private void findFiles(object sender, DoWorkEventArgs e)
        {
            // take input from UI
            string[] servers   = tb_serverList.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            string[] locations = tb_locationList.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            string[] patterns  = tb_patternList.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            bool textFilter = false;
            string text = string.Empty;
            this.tb_text.Invoke(new MethodInvoker(delegate
            {
                if (tb_text.Text != string.Empty)
                    textFilter = true;
            }));
            this.tb_text.Invoke(new MethodInvoker(delegate
            {
                text = tb_text.Text;
            }));

            // remove empty lines
            servers = servers.Where(val => !string.IsNullOrEmpty(val)).Distinct().ToArray();
            locations = locations.Where(val => !string.IsNullOrEmpty(val)).Distinct().ToArray();
            patterns = patterns.Where(val => !string.IsNullOrEmpty(val)).Distinct().ToArray();

            // delete everything from last search
            SR = new ez_SearchResult();
            this.panel_dynamic.Invoke(new MethodInvoker(delegate
            {
                panel_dynamic.Controls.Clear();
            }));

            // disable scrollbar while generating UI elements (bug workaround)
            this.panel_dynamic.Invoke(new MethodInvoker(delegate
            {
                panel_dynamic.VerticalScroll.Enabled = false;
                panel_dynamic.AutoScroll = false;
            }));

            int x = 0, y = 6, x_spacing = 15, y_spacing = 33;

            // button for opening all files
            Button b_all = new Button();
            b_all.Location = new Point(x, y);
            b_all.Name = "btn_OpenAllFiles";
            b_all.AutoSize = true;
            b_all.ForeColor = Color.White;
            b_all.Text = "open all";
            b_all.Font = new Font("Microsoft Sans Serif", 12f);
            b_all.Click += new EventHandler(openFiles_click);
            this.panel_dynamic.Invoke(new MethodInvoker(delegate
            {
                panel_dynamic.Controls.Add(b_all);
            }));
            // increment y
            y += y_spacing;

            // find all files
            foreach (string server in servers)
            {
                Button b_srv = new Button();
                b_srv.Location = new Point(x + x_spacing, y);
                b_srv.Name = serverTag + server;
                b_srv.Text = server;
                b_srv.AutoSize = true;
                b_srv.ForeColor = Color.White;
                b_srv.Text = server;
                b_srv.Font = new Font("Microsoft Sans Serif", 12f);
                b_srv.Click += new EventHandler(openFiles_click);
                this.panel_dynamic.Invoke(new MethodInvoker(delegate
                {
                    panel_dynamic.Controls.Add(b_srv);
                }));
                // increment y
                y += y_spacing;

                // create ez_Srv and save info
                ez_Srv ez_server = new ez_Srv();
                ez_server.btn = b_srv;

                foreach (string location in locations)
                {
                    Button b_loc = new Button();
                    b_loc.Location = new Point(x + 2*x_spacing, y);
                    b_loc.Name = serverTag + server + locationTag + location;
                    b_loc.Text = location;
                    b_loc.AutoSize = true;
                    b_loc.ForeColor = Color.White;
                    b_loc.Font = new Font("Microsoft Sans Serif", 12f);
                    b_loc.Click += new EventHandler(openFiles_click);
                    this.panel_dynamic.Invoke(new MethodInvoker(delegate
                    {
                        panel_dynamic.Controls.Add(b_loc);
                    }));
                    // increment y
                    y += y_spacing;

                    // create ez_Loc and save it to our ez_Srv
                    ez_Loc ez_location = new ez_Loc();
                    ez_location.btn = b_loc;
                    ez_server.locations.Add(ez_location);

                    try
                    {
                        //local host or server?
                        string path;
                        if (server != "localhost" && server != "local")
                        {
                            path = @"\\" + server + @"\" + location;
                            path = path.Replace(":", "$");
                        }
                        else
                            path = location;

                        // save math in ez_Loc
                        ez_location.path = path;

                        DirectoryInfo dir = new DirectoryInfo(path);

                        List<FileInfo> files = new List<FileInfo>();

                        // get all files
                        foreach (string pattern in patterns)
                        {
                            List<FileInfo> fi = dir.GetFiles(pattern).ToList();
                            files.AddRange(fi);
                        }

                        if(files.Count() == 0)
                        {
                            // msg: no files in server -> location matching the patterns
                        }
                        else
                        {
                            // now, foreach file do the shit
                            foreach (var file in files)
                            {
                                if(textFilter)
                                {
                                    if(findTextInFile(file.FullName, text))
                                    {
                                        // create button and checkbox
                                        Button b = new Button();
                                        b.Text = file.Name;
                                        b.Name = serverTag + server + locationTag + location + fileTag + file.Name;
                                        b.AutoSize = true;
                                        b.ForeColor = Color.White;
                                        b.Font = new Font("Microsoft Sans Serif", 12f);
                                        b.Click += new EventHandler(openFiles_click);
                                        /*CheckBox c = new CheckBox();
                                        c.Checked = true;
                                        c.AutoSize = true;
                                        c.CheckedChanged += new EventHandler(checkedChanged_click);

                                        // set x si y for checkbox and button
                                        c.Location = new Point(x + 3*x_spacing, y + y_spacing/4);*/
                                        b.Location = new Point(x + 3 * x_spacing, y); // *4 if checkbox

                                        // increment y
                                        y += y_spacing;

                                        this.panel_dynamic.Invoke(new MethodInvoker(delegate
                                        {
                                            //panel_dynamic.Controls.Add(c);
                                        }));
                                        this.panel_dynamic.Invoke(new MethodInvoker(delegate
                                        {
                                            panel_dynamic.Controls.Add(b);
                                        }));

                                        // create ez_File and save it to our ez_Loc from our ez_Srv
                                        ez_File ez_file = new ez_File();
                                        ez_file.fi = new FileInfo(file.Name);
                                        ez_file.btn = b;
                                        //ez_file.cb = c;
                                        ez_location.files.Add(ez_file);
                                    }
                                }
                                else
                                {
                                    // create button and checkbox
                                    Button b = new Button();
                                    b.Text = file.Name;
                                    b.Name = serverTag + server + locationTag + location + fileTag + file.Name;
                                    b.AutoSize = true;
                                    b.ForeColor = Color.White;
                                    b.Font = new Font("Microsoft Sans Serif", 12f);
                                    b.Click += new EventHandler(openFiles_click);
                                    /*CheckBox c = new CheckBox();
                                    c.Checked = true;
                                    c.AutoSize = true;
                                    c.CheckedChanged += new EventHandler(checkedChanged_click);

                                    // set x si y for checkbox and button
                                    c.Location = new Point(x + 3*x_spacing, y + y_spacing/4);*/
                                    b.Location = new Point(x + 3 * x_spacing, y); // *4 if checkbox

                                    // increment y
                                    y += y_spacing;

                                    this.panel_dynamic.Invoke(new MethodInvoker(delegate
                                    {
                                        //panel_dynamic.Controls.Add(c);
                                    }));
                                    this.panel_dynamic.Invoke(new MethodInvoker(delegate
                                    {
                                        panel_dynamic.Controls.Add(b);
                                    }));

                                    // create ez_File and save it to our ez_Loc from our ez_Srv
                                    ez_File ez_file = new ez_File();
                                    ez_file.fi = new FileInfo(file.Name);
                                    ez_file.btn = b;
                                    //ez_file.cb = c;
                                    ez_location.files.Add(ez_file);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw;
                        // msg: no directory
                    }
                }
                SR.servers.Add(ez_server);
            }

            // enable scrollbar after generating UI elements (bug workaround)
            this.panel_dynamic.Invoke(new MethodInvoker(delegate
            {
                panel_dynamic.VerticalScroll.Enabled = true;
                panel_dynamic.AutoScroll = true;
            }));
        }

        private void replaceText(object sender, DoWorkEventArgs e)
        {
            string text    = string.Empty;
            string newText = string.Empty;

            this.tb_text.Invoke(new MethodInvoker(delegate
            {
                text = tb_text.Text;
            }));
            this.tb_newText.Invoke(new MethodInvoker(delegate
            {
                newText = tb_newText.Text;
            }));

            foreach (ez_Srv s in SR.servers)
            {
                foreach (ez_Loc l in s.locations)
                {
                    foreach (ez_File f in l.files)
                    {
                        replaceTextInFile(l.path + "\\" + f.fi.Name, text, newText);
                    }
                }
            }
        }

        static public bool findTextInFile(string filePath, string searchText)
        {
            bool ret = false;

            StreamReader reader = new StreamReader(filePath);
            string content_original = reader.ReadToEnd();
            string content_new = content_original;
            reader.Close();

            content_new = Regex.Replace(content_original, searchText, "****t3xt_f0und_h3r3****");

            if (content_new != content_original)
                ret = true;

            
            return ret;
        }

        static public void replaceTextInFile(string filePath, string searchText, string replaceText)
        {
            StreamReader reader = new StreamReader(filePath);
            string content = reader.ReadToEnd();
            reader.Close();

            content = Regex.Replace(content, searchText, replaceText);

            StreamWriter writer = new StreamWriter(filePath);
            writer.Write(content);
            writer.Close();
        }
        #endregion

        private void openFiles_click(object sender, EventArgs e)
        {
            // get sender details
            Sender = getSenderDetails(sender, "button");
            
            // open file(s)
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += openFiles;
            worker.RunWorkerAsync();
        }

        private void checkedChanged_click(object sender, EventArgs e)
        {
            // get sender details
            Sender = getSenderDetails(sender, "checkbox");

            // check/uncheck file(s)/location(s)/server(s)
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += checkedChanged;
            worker.RunWorkerAsync();
        }

        private void openFiles(object sender, EventArgs e)
        {
            //.atom
            string command = string.Empty;
            int editorIdx = 0;
            this.cb_editor.Invoke(new MethodInvoker(delegate
            {
                editorIdx = cb_editor.SelectedIndex;
            }));
            switch(editorIdx)
            {
                case 0:
                    {
                        // atom
                        command = atom_path;
                        break;
                    }
                case 1:
                    {
                        // notepad++
                        command = "start notepad++";
                        break;
                    }
                case 2:
                    {
                        // sublime
                        command = "start " + sublime_path;
                        break;
                    }
                default:
                    {
                        // I think we can use sublime as default
                        break;
                    }
            }

            if (Sender.file != string.Empty)
            {
                ez_Srv srv = SR.servers.Where(el => el.btn.Text == Sender.server).First();
                ez_Loc loc = srv.locations.Where(el => el.btn.Text == Sender.location).First();
                command += " " + "\"" + loc.path + @"\" + Sender.file + "\"";
            }
            else if (Sender.location != string.Empty)
            {
                ez_Srv srv = SR.servers.Where(el => el.btn.Text == Sender.server).First();
                ez_Loc loc = srv.locations.Where(el => el.btn.Text == Sender.location).First();

                foreach(ez_File f in loc.files)
                {
                    command += " " + "\"" + loc.path + @"\" + f.fi.Name + "\"";
                }
            }
            else if (Sender.server != string.Empty)
            {
                ez_Srv srv = SR.servers.Where(el => el.btn.Text == Sender.server).First();

                foreach (ez_Loc l in srv.locations)
                {
                    foreach (ez_File f in l.files)
                    {
                        command += " " + "\"" + l.path + @"\" + f.fi.Name + "\"";
                    }
                }
            }
            else
            {
                foreach (ez_Srv s in SR.servers)
                {
                    foreach (ez_Loc l in s.locations)
                    {
                        foreach (ez_File f in l.files)
                        {
                            command += " " + "\"" + l.path + @"\" + f.fi.Name + "\"";
                        }
                    }
                }
            }

            // run CMD to open file(s) in text editor
            runPowershell(command);
        }

        private void checkedChanged(object sender, EventArgs e)
        {
            //
        }

        private string runPowershell(string script)
        {
            PowerShell ps = PowerShell.Create();
            ps.AddScript(script);
            return ps.Invoke().ToString();
        }

        private ez_Sender getSenderDetails(object sender, string sender_type)
        {
            ez_Sender s = new ez_Sender();

            // case - button
            switch (sender_type)
            {
                case "button":
                    {
                        string name = ((Button)sender).Name;
                        if (name.Contains(fileTag))
                        {
                            s.file = name.Substring(name.IndexOf(fileTag) + fileTag.Length);
                            s.location = name.Substring(name.IndexOf(locationTag) + locationTag.Length, name.IndexOf(fileTag) - name.IndexOf(locationTag) - locationTag.Length);
                            s.server = name.Substring(serverTag.Length, name.IndexOf(locationTag) - serverTag.Length);
                        }
                        else if (name.Contains(locationTag))
                        {
                            s.location = name.Substring(name.IndexOf(locationTag) + locationTag.Length);
                            s.server = name.Substring(serverTag.Length, name.IndexOf(locationTag) - name.IndexOf(serverTag) - serverTag.Length);
                        }
                        else if (name.Contains(serverTag))
                        {
                            s.server = name.Substring(serverTag.Length);
                        }

                        break;
                    }
                case "checkbox":
                    {
                        break;
                    }
                default:
                    {
                        // we're fucked
                        break;
                    }
            }
            
            return s;
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(System.IO.Path.GetDirectoryName(Application.ExecutablePath));
            //MessageBox.Show(System.AppDomain.CurrentDomain.FriendlyName);
        }

        private void form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // get input from UI
            string[] servers   = tb_serverList.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            for (int i = 0; i < servers.Length; i++)
                servers[i] = servers[i].Replace(" ", "");
            string[] locations = tb_locationList.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            string[] patterns  = tb_patternList.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            int editorIdx = cb_editor.SelectedIndex;

            // remove empty lines
            servers   = servers.Where(val => !string.IsNullOrEmpty(val)).Distinct().ToArray();
            locations = locations.Where(val => !string.IsNullOrEmpty(val)).Distinct().ToArray();
            patterns  = patterns.Where(val => !string.IsNullOrEmpty(val)).Distinct().ToArray();

            // save user's last session preferences
            JObject j = new JObject();
            JArray s = new JArray(servers);
            j["servers"] = s;
            JArray l = new JArray(locations);
            j["locations"] = l;
            JArray p = new JArray(patterns);
            j["patterns"] = p;

            j["text"]    = tb_text.Text;
            j["newText"] = tb_newText.Text;

            j["editorIdx"] = editorIdx;

            string json_text = j.ToString();
            File.WriteAllText(mainDirectory_path + @"\" + "Data" + @"\" + user + ".json", json_text);

        }


    }
}
