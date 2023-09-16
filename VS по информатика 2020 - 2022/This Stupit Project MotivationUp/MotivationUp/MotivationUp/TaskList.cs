using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotivationUp
{
    public partial class TaskList : Form
    {
        public TaskList()
        {
            InitializeComponent();
        }
        int ClickCounter = 0;
        int x1 = 13;
        int y1 = 1;
        int x4 = 415;
        int y4 = 61;
        int x2 = 490;
        int y2 = 61;
        int x3 = 553;
        int y3 = 61;
        int Cchange = 1;
        public void button1_Click(object sender, EventArgs e)
        {
            ClickCounter++;
            //Task
            TextBox TaskTitle = new TextBox();
            TaskTitle.Size = new Size(400, 101);
            TaskTitle.Location = new Point(x1, y1 + 60);
            Controls.Add(TaskTitle);
            y1 += 23;
            //Button Done
            Button DoneT = new Button();
            DoneT.Text = "Done";
            DoneT.Tag = "CompletedTask";
            DoneT.Size = new Size(63, 20);
            DoneT.Location = new Point(x2, y2);
            DoneT.BackColor = System.Drawing.Color.Green;
            Controls.Add(DoneT);
            y2 += 23;
            // Button X
            Button CancelT = new Button();
            CancelT.Text = "X";
            CancelT.Tag = "CanceledTask";
            CancelT.Size = new Size(38, 20);
            CancelT.Location = new Point(x3, y3);
            CancelT.BackColor = System.Drawing.Color.Red;
            Controls.Add(CancelT);
            y3 += 23;
            // Button change level of importance
            Button LevelOfImp = new Button();
            LevelOfImp.Text = "Task";
            LevelOfImp.Size = new Size(75, 20);
            LevelOfImp.Location = new Point(x4, y4);
            Controls.Add(LevelOfImp);
            y4 += 23;
            //change task level of importance
            void Rcolor_Click(object sender3, EventArgs c)
            {
                if (Cchange == 1)
                {
                    TaskTitle.BackColor = System.Drawing.Color.Red;
                    LevelOfImp.BackColor = System.Drawing.Color.Red;
                    LevelOfImp.Text = "Urgent";
                }
                if (Cchange == 2)
                {
                    TaskTitle.BackColor = System.Drawing.Color.Yellow;
                    LevelOfImp.BackColor = System.Drawing.Color.Yellow;
                    LevelOfImp.Text = "Important";
                }
                if (Cchange == 3)
                {
                    TaskTitle.BackColor = System.Drawing.Color.LimeGreen;
                    LevelOfImp.BackColor = System.Drawing.Color.LimeGreen;
                    LevelOfImp.Text = "Unimportant";
                }
                if (Cchange == 4)
                {
                    TaskTitle.BackColor = System.Drawing.Color.White;
                    LevelOfImp.BackColor = System.Drawing.Color.White;
                    LevelOfImp.Text = "Task";
                    Cchange = 0;
                }
                Cchange++;
            }
            LevelOfImp.Click += new EventHandler(Rcolor_Click);
            //Remove event for Done and X
            //Done button event
            void CompletedT_Click(object sender1, EventArgs a)
            {
                Controls.Remove(CancelT);
                Controls.Remove(DoneT);
                Controls.Remove(LevelOfImp);
                Controls.Remove(TaskTitle);
                ClickCounter--;
                y1 -= 23;
                y2 -= 23;
                y3 -= 23;
                y4 -= 23;
            }
            DoneT.Click += new EventHandler(CompletedT_Click);
            //X button event
            void CanceledT_Click(object sender2, EventArgs b)
            {
                Controls.Remove(CancelT);
                Controls.Remove(DoneT);
                Controls.Remove(LevelOfImp);
                Controls.Remove(TaskTitle);
                ClickCounter--;
                y1 -= 23;
                y2 -= 23;
                y3 -= 23;
                y4 -= 23;
            }
            CancelT.Click += new EventHandler(CanceledT_Click);
            //Max tasks
            if (this.ClickCounter == 10)
            {
                button1.Enabled = false;
            }
        }
        //open write 3 good things
        private void button2_Click(object sender, EventArgs e)
        {
            write3words w3w = new write3words();
            w3w.Show();
            this.Hide();
        }
    }
}
