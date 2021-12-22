using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton
{
    public partial class Form2 : Form
    {
        private Logger logger;
        public Form2()
        {
            InitializeComponent();
           
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            logger = Logger.Instance;
            logger.Write(textBox2.Text);
        }

        private void Form2Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
