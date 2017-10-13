using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace DATA_ENTRY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon =Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
            this.Size = new Size(818, 365);
        }
        public bool done = false;//للتحقق اذا ادخل صوره ام لا
        private void add_Click(object sender, EventArgs e)
        {

            if (textid.Text.Trim() == "" || textname.Text.Trim() == "" || textaddress.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter All Data\t");
                return;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(textid.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Numbers only !\t");
                textid.Focus();
                textid.SelectAll();
                return;
            }

            Regex re = new Regex("^[a-zA-Z]+\\s*[a-zA-Z]*\\s*[a-zA-Z]*\\s*[a-zA-Z]*\\s*[a-zA-Z]*\\s*[a-zA-Z]*\\s*[a-zA-Z]*$");
            // if (System.Text.RegularExpressions.Regex.IsMatch(textname.Text, "[^a-zA-Z]"))
            string checkname1 = textname.Text;
            if (re.IsMatch(checkname1))
             {

                goto g;

            }
            else
            {
                MessageBox.Show("Please Enter Correct Name !\t");
                textname.Focus();
                textname.SelectAll();


                return;
            }
        g:
            StreamWriter strw1 = new StreamWriter("Data.txt", true);
            strw1.Close();
            StreamReader strr = new StreamReader("Data.txt");
            string strcheck = strr.ReadToEnd();
            strr.Close();
            if (strcheck.Contains(textid.Text + ";"))
            {
                MessageBox.Show("The Id is Exist\t");
                textid.Focus();
                textid.SelectAll();
                return;
            }

            StreamWriter strw = new StreamWriter("Data.txt", true);
//////
           
/////

            string strtxt = textid.Text + ";"
                          + textname.Text + ";" + textaddress.Text;
            strw.WriteLine(strtxt);
            strw.Close();
            if (!Directory.Exists("img"))
                Directory.CreateDirectory("img");
            if (done==true)
            picperson.Image.Save("img/" + textid.Text + ".jpg");
            MessageBox.Show("Added\t");
            textid.Focus();
            foreach(Control c in this.Controls){
                textid.Text = "";
                textname.Text = "";
                textaddress.Text = "";
            }
            picperson.Image = new PictureBox().Image;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textid.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter the ID!\t");
                    textid.Focus();
                    return;
                }
                if (System.Text.RegularExpressions.Regex.IsMatch(textid.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please Enter Numbers only !\t");
                    textid.Focus();
                    textid.SelectAll();
                    return;
                }
                StreamWriter strw1 = new StreamWriter("Data.txt", true);
                strw1.Close();
                StreamReader sr = new StreamReader("Data.txt");
                string linedata;
                Boolean found = false;
                do
                {
                    linedata = sr.ReadLine();
                    if (linedata != null)
                    {
                        string[] strarry = linedata.Split(';');
                        if (strarry[0] == textid.Text)
                        {
                            textid.Text = strarry[0];
                            textname.Text = strarry[1];
                            textaddress.Text = strarry[2];
                            if (File.Exists("img/" + textid.Text + ".jpg"))
                                picperson.Image = Image.FromFile("img/" + textid.Text + ".jpg");
                            else
                                picperson.Image = new PictureBox().Image;
                            found = true;
                            break;
                        }
                    }

                } while (linedata != null);
                sr.Close();
                if (found)
                {
                    //     MessageBox.Show("Found\t");
                }

                else
                {
                    MessageBox.Show("Not Found\t");
                    picperson.Image = new PictureBox().Image;
                    textid.Focus();
                    textname.Text = null;
                    textaddress.Text = null;
                }
            }//لو صادف اي خطاء غير متوقع
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
            }

        private void button3_Click(object sender, EventArgs e)
        {

            Form formshow = new Form();
            formshow.Size = this.Size;
            formshow.StartPosition = FormStartPosition.CenterScreen;
            formshow.Font = this.Font;
            formshow.Text = "All Data";
            formshow.Icon = this.Icon;
            TextBox textshow = new TextBox();
            textshow.Multiline = true;
            textshow.Dock = DockStyle.Fill;
            formshow.Controls.Add(textshow);


            try
            {
                StreamReader sr = new StreamReader("Data.txt");
                string stshowalldata = sr.ReadToEnd();
                sr.Close();
                stshowalldata=stshowalldata.Replace(";"," \\ ");
                textshow.Text = stshowalldata;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            formshow.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void butselectphoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Images|*.png;*.jpg;*.bmp;*.gif";
            if (of.ShowDialog() == DialogResult.OK)
            {
                picperson.Image=Image.FromFile(of.FileName);
                done = true;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(818, 365);
        }
    }
}
