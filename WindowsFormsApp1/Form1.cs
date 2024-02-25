using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CategoryServiceRef.CategoryServiceClient catClient = new CategoryServiceRef.CategoryServiceClient("BasicHttpBinding_ICategoryService");
            var catList = catClient.GetCategory(1);
            label1.Text = catList.CategoryName;
            label2.Text = catList.ToString();   
        }
    }
}
