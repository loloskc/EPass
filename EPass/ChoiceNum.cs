using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPass
{
    public partial class ChoiceNum : Form
    {
        public ChoiceNum()
        {
            InitializeComponent();
        }
        public int num;

        public int GetNum() => num;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=null)
            {
                int.TryParse(textBox1.Text, out int num);
                this.num = num;
                this.Close();
            }
            else
            {
                Label label = new Label();
                label.Text = "Введите число";
                MyMessageBox form = new MyMessageBox(label);
            }
            
        }
    }
}
