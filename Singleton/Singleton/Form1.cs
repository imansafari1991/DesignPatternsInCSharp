namespace Singleton
{
    public partial class Form1 : Form
    {
        private Logger logger;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logger = Logger.Instance;
            logger.Write(textBox1.Text);
        
        }

        private void Form2Btn_Click(object sender, EventArgs e)
        {
            var frm = new Form2();
            logger.Write("Form2 Opened");

            frm.ShowDialog();
            logger.Write("Form 2 Closed");
        }
    }
}