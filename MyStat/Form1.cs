using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyStat
{
    public partial class Form1 : Form
    {
        public List<Student> Students { get; set; }
        UserControl1 user = new UserControl1();

        public Form1()
        {
            InitializeComponent();
            colorRgb();

            Students = new List<Student>
            {
                new Student
                {
                    StudentName = "Ulvi",
                    StudentImage = Properties.Resources._41b4b35e_8bdc_425e_848c_e822e51991c1,
                },
                new Student
                {
                    StudentName = "Ilkin",
                    StudentImage = Properties.Resources._41b4b35e_8bdc_425e_848c_e822e51991c1,
                },
                new Student
                {
                    StudentName = "Muhhaa",
                    StudentImage = Properties.Resources._41b4b35e_8bdc_425e_848c_e822e51991c1,
                }
            };

            
            this.Controls.Clear();

            

            int x = 0;
            int y = 0;
            foreach (var item in Students)
            {
                var studentUC = new UserControl1();
                studentUC.FullName = item.StudentName;
                studentUC.image = item.StudentImage;
                studentUC.Location = new Point(x, y);
                y += 100;
                this.Controls.Add(studentUC);
            }
        }

        private void colorRgb()
        {
            pictureBox1.BackColor = Color.FromArgb(58, 96, 110);
            mystatLb.BackColor = Color.FromArgb(58, 96, 110);
            menuPicBoxBacnkround.BackColor = Color.FromArgb(170, 192, 175);
            photoLb.BackColor = Color.FromArgb(170, 192, 175);
            fullNameLb.BackColor = Color.FromArgb(170, 192, 175);
            markpresenceLb.BackColor = Color.FromArgb(170, 192, 175);
            markonlineLb.BackColor = Color.FromArgb(170, 192, 175);
            testLb.BackColor = Color.FromArgb(170, 192, 175);
            classworkLb.BackColor = Color.FromArgb(170, 192, 175);
        }

    }
    public class Student
    {
        public Image StudentImage { get; set; }
        public string StudentName { get; set; }
    }


}
