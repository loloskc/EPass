using EPass.Data.Enum;
using EPass.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EPass
{
    public partial class ChoiceAddress : Form
    {
        public ChoiceAddress()
        {
            InitializeComponent();
            string[] adressStr = { Address.Lenina.ToString(), Address.Construction.ToString() };
            comboBox1.Items.AddRange(adressStr);
        }

        public int GetAddress() => comboBox1.SelectedIndex;

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1) this.Close();
            else
            {
                Label label = new Label();
                label.Text = "Выберите адрес";
                MyMessageBox form = new MyMessageBox(label);
                form.ShowDialog();
            }
        }


    }
}
