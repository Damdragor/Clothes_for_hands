using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Clothes_for_hands
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            using (Model1 db = new Model1())
            {
                Img userObj = db.Img.FirstOrDefault(MaterialsTry => MaterialsTry.Name.Equals("Силикон 0x28"));
                InitializeMyGroupBox(30, 200, userObj.Name, userObj.Picture);

            }

            using (Model1 db = new Model1())
            {
                Img userObj = db.Img.FirstOrDefault(MaterialsTry => MaterialsTry.Name.Equals("Силикон 1x27"));
                InitializeMyGroupBox(30, 300, userObj.Name, userObj.Picture);

            }
            InitializeComponent();


        }

        private void InitializeMyGroupBox(int x, int y, String name, String picture)
        {

            // Create and initialize a GroupBox and a Button control.
            GroupBox groupBox1 = new GroupBox();
            groupBox1.Size = new Size(500, 100);

            picture = "D:/4-IS_MlkNik/c#/materials/" + picture.Substring(13);
            PictureBox pb1 = new PictureBox();
            pb1.Image = Image.FromFile(picture);
            pb1.Location = new Point(5, 10);
            pb1.Size = new Size(100, 100);
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;

            Label lb2 = new Label();
            lb2.Text = name;
            lb2.Size = new Size(180, 20);
            lb2.Font = new Font("Candara", 10);
            lb2.Location = new Point(220, 10);


            Label lb7 = new Label();
            lb7.Text = "Количество:";
            lb7.Size = new Size(180, 20);
            lb7.Font = new Font("Candara", 10);
            lb7.Location = new Point(110, 30);

            Label lb8 = new Label();
            lb8.Text = "Количество на складе:";
            lb8.Size = new Size(180, 20);
            lb8.Font = new Font("Candara", 10);
            lb8.Location = new Point(110, 50);

            Label lb5 = new Label();
            lb5.Text = "Поставщики:";
            lb5.Font = new Font("Candara", 10);
            lb5.Location = new Point(110, 70);

            Label lb6 = new Label();
            lb6.Text = "";
            lb6.Font = new Font("Candara", 10);
            lb6.Location = new Point(200, 70);

            groupBox1.Controls.Add(pb1);

            groupBox1.Controls.Add(lb2);

            groupBox1.Controls.Add(lb5);
            groupBox1.Controls.Add(lb6);
            groupBox1.Controls.Add(lb7);
            groupBox1.Controls.Add(lb8);

            groupBox1.Location = new Point(x, y);
            Controls.Add(groupBox1);




        }



        private void InitializeMyGroupBox1(int x, int y, String name, String picture)
        {

           
            GroupBox groupBox1 = new GroupBox();
            groupBox1.Size = new Size(500, 100);

            picture = "D:/4-IS_MlkNik/c#/materials/" + picture.Substring(13);
            PictureBox pb1 = new PictureBox();
            pb1.Image = Image.FromFile(picture);
            pb1.Location = new Point(5, 10);
            pb1.Size = new Size(100, 100);
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;

            Label lb2 = new Label();
            lb2.Text = name;
            lb2.Size = new Size(180, 20);
            lb2.Font = new Font("Candara", 10);
            lb2.Location = new Point(220, 10);


            Label lb7 = new Label();
            lb7.Text = "Количество:";
            lb7.Size = new Size(180, 20);
            lb7.Font = new Font("Candara", 10);
            lb7.Location = new Point(110, 30);

            Label lb8 = new Label();
            lb8.Text = "Количество на складе:";
            lb8.Size = new Size(180, 20);
            lb8.Font = new Font("Candara", 10);
            lb8.Location = new Point(110, 50);

            Label lb5 = new Label();
            lb5.Text = "Поставщики:";
            lb5.Font = new Font("Candara", 10);
            lb5.Location = new Point(110, 70);

            Label lb6 = new Label();
            lb6.Text = "";
            lb6.Font = new Font("Candara", 10);
            lb6.Location = new Point(200, 70);

            groupBox1.Controls.Add(pb1);

            groupBox1.Controls.Add(lb2);

            groupBox1.Controls.Add(lb5);
            groupBox1.Controls.Add(lb6);
            groupBox1.Controls.Add(lb7);
            groupBox1.Controls.Add(lb8);

            groupBox1.Location = new Point(x, y);
            Controls.Add(groupBox1);




        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.SelectedIndex)
            {
                case 0:
                    {
                        MessageBox.Show("Фильтрация: Все типы");
                        materialTypeBindingSource.Filter = null; break;
                    }

                case 1:
                    {
                        MessageBox.Show("Фильтрация: Краска");
                        materialTypeBindingSource.Filter = "[Title] LIKE'" + comboBox4.SelectedText + "%'";
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Фильтрация: Силикон");
                        materialTypeBindingSource.Filter = "[Title] LIKE'" + comboBox4.SelectedText + "%'";
                        break;
                    }
                case 3:
                    {
                        MessageBox.Show("Фильтрация: Резина");
                        materialTypeBindingSource.Filter = "[Title] LIKE'" + comboBox4.SelectedText + "%'";
                        break;
                    }

            }
            label13.Text = (dataGridView1.RowCount - 1).ToString();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
            this.materialTypeTableAdapter.Fill(this.clothes_for_handsDataSet.MaterialType);

        }

       
        private void button8_Click(object sender, EventArgs e)
        {
           
           

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    {
                        MessageBox.Show("Сортировка: по возрастанию наименования");
                        materialTypeBindingSource.Sort = "[Title] ASC"; 
                        break;
                    }
                case 1:
                    {
                        MessageBox.Show("Сортировка: по возрастанию дефектного процента");
                        materialTypeBindingSource.Sort = "[DefectedPercent] ASC";
                        break;
                            
                    }
                case 2:
                    {
                        MessageBox.Show("Сортировка: по убыванию наименования");
                        materialTypeBindingSource.Sort = "[Title] DESC";
                        break;
                       
                    }
                case 3:
                    {
                        MessageBox.Show("Сортировка: по убыванию дефектного процента");
                        materialTypeBindingSource.Sort = "[DefectedPercent]  DESC";
                        break;
                    }

            }
         
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void materialTypeBindingSource4_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            using (Model1 db = new Model1())
            {
                Img userObj = db.Img.FirstOrDefault(user => user.Name.Equals(textBox2.Text));
                if (userObj != null)
                {
                    MessageBox.Show(userObj.Picture);
                }
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
            this.Hide();
        }
    }
}




