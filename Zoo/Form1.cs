using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel4.Controls.Add(childForm);
            this.panel4.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Sim_animals(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sim_workers(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Pets_children(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Events(), sender);
        }
    }
}
