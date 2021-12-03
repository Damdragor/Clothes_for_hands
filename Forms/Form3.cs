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
    public partial class Form3 : Form
    {
        public Form3()
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

        private void Form3_Load(object sender, EventArgs e)
        {
            
            this.agentTypeTableAdapter.Fill(this.clothes_for_handsDataSet.AgentType);
          
            this.materialTypeTableAdapter.Fill(this.clothes_for_handsDataSet.MaterialType);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (Model1 db = new Model1())
            {
                int textboxID = Convert.ToInt32(textBox1.Text);
                MaterialType user = db.MaterialType.FirstOrDefault(p => p.ID.Equals(textboxID));
                if (user != null)
                {
                    user.Title = comboBox3.Text;
                    user.DefectedPercent = double.Parse(textBox2.Text);
                }
                db.SaveChanges();
                MessageBox.Show("Данные изменены!");

            }
        }
    }
}
