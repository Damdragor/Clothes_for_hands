using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clothes_for_hands
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            this.agentTypeTableAdapter.Fill(this.clothes_for_handsDataSet.AgentType);
          
            this.materialTypeTableAdapter.Fill(this.clothes_for_handsDataSet.MaterialType);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (Model1 db = new Model1())
            {
                MaterialType userObj = new MaterialType();
                userObj.ID = int.Parse(textBox1.Text);
                userObj.Title = comboBox3.Text;
                userObj.DefectedPercent = double.Parse(textBox2.Text);
                db.MaterialType.Add(userObj);
                db.SaveChanges();
                MessageBox.Show("Новые данные добавлены!");
            }
            label3.Text = (dataGridView1.RowCount - 1).ToString();
            using (Model1 db = new Model1())
            {
               AgentType useObj = new AgentType();
                useObj.Title = comboBox1.Text;
                db.AgentType.Add(useObj);
                db.SaveChanges();
            }
            label4.Text = (agentTypeDataGridView.RowCount - 1).ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
