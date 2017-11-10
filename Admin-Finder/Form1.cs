using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Finder
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        Thread myTread;       

        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = lbl_Target;
            ServicePointManager.DefaultConnectionLimit = 2000;

        }

        private void txb_Target_Enter(object sender, EventArgs e)
        {
            if (txb_Target.Text == "example.com or www.example.com")
            {
                txb_Target.Text = string.Empty;
            }
        }

        private void txb_Target_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_Target.Text))
            {
                txb_Target.Text = "example.com or www.example.com";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtReader("Panels.txt");
            CheckForIllegalCrossThreadCalls = false;

        }

        private async void TxtReader(string filename)
        {

            int count = 0;
            string line = "";
            lxb_Panels.Items.Clear();

            try
            {
                StreamReader sr = new StreamReader(filename);

                while ((line = await sr.ReadLineAsync()) != null)
                {
                    lxb_Panels.Items.Add(line);
                    count++;

                }               
                
                // Set Progress Bar
                progressBar1.Maximum = count;
                progressBar1.Value = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Olustu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_AddTxt_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents|*.txt", Multiselect = false, ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        TxtReader(ofd.FileName);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dosya adına dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void Scan()
        {
            HttpWebRequest request;
            HttpWebResponse response;
            string status = "";
            int length = lxb_Panels.Items.Count;


            for (int i = 0; i < length; i++)
            {
                try
                {
                    
                    request = (HttpWebRequest)HttpWebRequest.Create("https://" + txb_Target.Text + "/" + lxb_Panels.Items[i].ToString());
                    response = (HttpWebResponse)request.GetResponse();
                    status = response.StatusCode.ToString();

                    if (status == "OK")
                    {                     
                        lxb_Found.Items.Add(lxb_Panels.Items[i].ToString());
                    }

                }

                catch
                {                    
                    //lxb_Found.Items.Add(lxb_Panels.Items[i].ToString() + "     Skipped");
                }

                progressBar1.Value += 1;         
            }

            lxb_Found.Items.Add("----Finish----");



        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            lxb_Found.Items.Clear();
            myTread = new Thread(new ThreadStart(Scan));
            myTread.Start();
           

        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            myTread.Abort();
        }
    }
}
