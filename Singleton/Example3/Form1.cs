namespace Example3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Singleton s1=Singleton.getInstance();
            Singleton s2 = Singleton.getInstance();

            Singleton s3 = Singleton.getInstance();

            Singleton s4 = Singleton.getInstance();

            Console.WriteLine();
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s3.GetHashCode());
            Console.WriteLine(s4.GetHashCode());

            MessageBox.Show($"{s1.GetHashCode()} {s2.GetHashCode()} {s3.GetHashCode()} {s4.GetHashCode()}");


        }
    }
}