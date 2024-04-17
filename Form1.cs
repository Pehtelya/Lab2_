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

namespace Lab2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            DataGridViewTextBoxColumn columnFIO = new DataGridViewTextBoxColumn();
            columnFIO.HeaderText = "ФИО";
            dataGridView1.Columns.Add(columnFIO);

            DataGridViewTextBoxColumn columnGroup = new DataGridViewTextBoxColumn();
            columnGroup.HeaderText = "Группа";
            dataGridView1.Columns.Add(columnGroup);

            DataGridViewTextBoxColumn columnSubject = new DataGridViewTextBoxColumn();
            columnSubject.HeaderText = "Предмет";
            dataGridView1.Columns.Add(columnSubject);

            DataGridViewTextBoxColumn columnGrade = new DataGridViewTextBoxColumn();
            columnGrade.HeaderText = "Оценка";
            dataGridView1.Columns.Add(columnGrade);

      
            AddStudent("Иванов Иван Иванович", "Группа 1", "Прораммирование C#", "5");
            AddStudent("Петров Петр Петрович", "Группа 2", "Прораммирование C#", "4");
            AddStudent("Сидоров Сидор Сидорович", "Группа 3", "Прораммирование C#", "3");
        }

    
        private void AddStudent(string fio, string group, string subject, string grade)
        {
            dataGridView1.Rows.Add(fio, group, subject, grade);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.BackColor = SystemColors.Control;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.PapayaWhip;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialogIn = new OpenFileDialog();
            fileDialogIn.Filter = "txt files |*.txt;*.dat;*.bin";
            if (fileDialogIn.ShowDialog() == DialogResult.OK) 
                {
                textBox1.Text = fileDialogIn.FileName;
                StreamReader fr = new StreamReader(fileDialogIn.FileName);
            }
           
     
            DataSet ds = new DataSet();

          

            ds.Tables.Add("Информация о студентах");
        }

        private void button3_Click(object sender, EventArgs e)
        {
           SaveFileDialog fileDialogOut = new SaveFileDialog();
            fileDialogOut.FileName = ".txt";
            fileDialogOut.DefaultExt = ".txt";
           fileDialogOut.Filter = "txt files |*.txt;*.dat;*.bin";

            if (fileDialogOut.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = fileDialogOut.FileName;

     
                StreamWriter sw = new StreamWriter(fileDialogOut.FileName);
                
                sw.Write(textBox2.Text);

                sw.Close();

               
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}