using FontAwesome.Sharp;
using ProjetoRH_GerenciadorDeServiços.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoRH_GerenciadorDeServiços {
    public partial class MainForm : Form {

        private IconButton currentButton;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public MainForm() {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 55);
            panelMenu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void ActivateButton(object senderBtn, Color color) {
            if (senderBtn != null) {
                DisableButton();
                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = Color.FromArgb(255, 136, 99);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;

                leftBorderBtn.BackColor = Color.FromArgb(198, 176, 156);
                leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();


            }
        }

        private void DisableButton() {
            if (currentButton != null) {

                currentButton.BackColor = Color.FromArgb(255, 232, 210);
                currentButton.ForeColor = Color.FromArgb(255, 136, 99);
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.FromArgb(255, 136, 99);
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm) {
            if (currentChildForm != null) {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnServicos_Click(object sender, EventArgs e) {
            ActivateButton(sender, Color.FromArgb(255, 232, 210));
           OpenChildForm(new FormServicos());
        }

        private void btnConfig_Click(object sender, EventArgs e) {
            ActivateButton(sender, Color.FromArgb(255, 232, 210));
            OpenChildForm(new FormConfig());
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            DisableButton();
            leftBorderBtn.Visible = false;
            currentChildForm.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnFechar_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }
    }
}
