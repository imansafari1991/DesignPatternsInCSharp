namespace Example2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Creator[] c = new Creator[2];
            c[0] = new ConcreteCreator1();
            c[1] = new ConcreteCreator2();
            foreach (Creator cr in c)
            {
                Product p = cr.FactoryMethod();
                string s = p.GetType().Name;
                listBox1.Items.Add("Created " + s);

            }
        }
    }
}