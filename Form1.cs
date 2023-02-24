using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Manager_Classic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Please select your path." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    fileManager.Url = new Uri(fbd.SelectedPath);
                    txtPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (fileManager.CanGoBack)
                fileManager.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (fileManager.CanGoForward) 
                fileManager.GoForward();
        }
    }
}
