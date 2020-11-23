using System;
using System.Drawing;
using System.Windows.Forms;

namespace app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString();
            label1.Text = "hi hello my name is mohcine!"; 
        }

      

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Are you sure!!", "Close App", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }


        bool drag;
        int MouseX;
        int MouseY;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            MouseX = Cursor.Position.X - this.Left;
            MouseY = Cursor.Position.Y - this.Top;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                this.Left = Cursor.Position.X - MouseX;
                this.Top = Cursor.Position.Y - MouseY;
            }
        }

        Button btn = null;
        void buttonActive(Button button)
        {
            if (btn != null)
            {
                btn.ForeColor = Color.White;
            }
            btn = button;
            button.ForeColor = Color.Indigo;
        }

        Form actualForm = null;
        public void displayForm(Form form)
        {
            if (actualForm != null)
            {
                actualForm.Close();
            }
            actualForm = form;
            form.TopLevel = false;
            mainPanel.Controls.Add(form);
            form.BringToFront();
            form.Dock = DockStyle.Fill;
            form.Show();
        }
         
        private void back_Click(object sender, EventArgs e)
        {
            if (actualForm != null)
            {
                actualForm.Close();

            }
        }
         
        private void homeBtn_Click(object sender, EventArgs e)
        {
            displayForm(new AllMembers());
              buttonActive(homeBtn);
        }

        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            displayForm(new AddMember());
            buttonActive(addMemberBtn);
        }

        private void searchMemberBtn_Click(object sender, EventArgs e)
        {
            displayForm(new Search());
            buttonActive(searchMemberBtn);
        }

        private void deleteMemberBtn_Click(object sender, EventArgs e)
        {

        }

        private void updateMemberBtn_Click(object sender, EventArgs e)
        {
            displayForm(new Update());
            buttonActive(updateMemberBtn);
        }

        private void renewRegistrationBtn_Click(object sender, EventArgs e)
        {
            displayForm(new RenewRegistration());
            buttonActive(renewRegistrationBtn);
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this app is developed by Mohcine Dev \n if you have any problem or question you can contact him by \n Tel : 0615369076 \n mail : mouhcineDev@gmail.com", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
