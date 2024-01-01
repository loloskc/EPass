using EPass.Data;
using EPass.Models;
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

namespace EPass
{
    public partial class FormCreateEditFurn : Form
    {
        private readonly ApplicationDbContext _context;
        private bool _isEditing = false;
        private readonly Furniture furniture;
        public FormCreateEditFurn(PassLab pass, ApplicationDbContext context)
        {
            InitializeComponent();
            this.pass = pass;
            _context = context;
            furniture = new Furniture();
        }

        public FormCreateEditFurn(PassLab pass, ApplicationDbContext context, Furniture furniture)
        {
            InitializeComponent();
            this.pass = pass;
            _context = context;
            textBox1.Text = furniture.Name;
            textBox2.Text = furniture.Quantity.ToString();
            _isEditing = true;
            this.furniture = furniture;
        }


        private PassLab pass;

        private void button1_Click(object sender, EventArgs e)
        {


        }

        public Furniture GetFurniture() => furniture;

        private void button1_Click_1(object sender, EventArgs e)
        {
            furniture.passLabId = pass.Id;
            int.TryParse(textBox2.Text, out int val);
            furniture.Quantity = val;
            furniture.Name = textBox1.Text;
            FurnRepository furnRepository = new FurnRepository(_context);
            if (!_isEditing) furnRepository.Add(furniture);
            else furnRepository.Update(furniture);
            this.Close();

        }
    }
}
