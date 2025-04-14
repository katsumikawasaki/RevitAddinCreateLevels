
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevitAddinCreateLevels
{
    public partial class Form1 : Form
    {
        //既存レベル
        public BindingList<LevelClass> exsistLevels;
        //新規レベル
        public BindingList<LevelClass> newLevels;
        public Form1()
        {
            InitializeComponent();

            newLevels = new BindingList<LevelClass>();
            exsistLevels = new BindingList<LevelClass>();
            /*
            LevelClass taskItem = new LevelClass() { LevelName = "レベル 3", LevelHeight = 5000 };
            newLevels.Add(taskItem);
            */
            //既存レベル
            dataGridView1.DataSource = exsistLevels;
            //新規レベル
            dataGridView2.DataSource = newLevels;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
