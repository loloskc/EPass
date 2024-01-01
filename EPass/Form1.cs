using EPass.Data;

namespace EPass
{
    public partial class Form1 : Form
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // calling up program information
            Label lab = new Label();
            lab.Text = "Программа разработана Демидовым Денисом\nГруппа: П-486";
            MyMessageBox myMessageBox = new MyMessageBox(lab);
            myMessageBox.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableForm(context,this);
            tableForm.Show();
            this.Hide();


        }
    }
}