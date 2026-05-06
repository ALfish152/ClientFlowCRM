using ClientFlowCRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ClientFlowCRM
{
    public partial class ClientForm : Form
    {
        public Client ClientData { get; private set; }

        public ClientForm()
        {
            InitializeComponent();
            ClientData = null;
            this.Text = "Add New Client";
            cmbSource.SelectedIndex = 0;
        }

        public ClientForm(Client existingClient)
        {
            InitializeComponent();
            ClientData = null;
            this.Text = "Edit Client";

            txtName.Text = existingClient.Name;
            txtEmail.Text = existingClient.Email;
            txtPhone.Text = existingClient.Phone;
            txtCompany.Text = existingClient.Company;

            for (int i = 0; i < cmbSource.Items.Count; i++)
            {
                if (cmbSource.Items[i].ToString() == existingClient.Source)
                {
                    cmbSource.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            ClientData = new Client
            {
                Name = txtName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Company = txtCompany.Text.Trim(),
                Source = cmbSource.SelectedItem?.ToString() ?? "Website"
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            MakeRoundedTextBox(txtName);
            MakeRoundedTextBox(txtEmail);
            MakeRoundedTextBox(txtPhone);
            MakeRoundedTextBox(txtCompany);
            DrawAvatar(pictureBox1); 
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
  
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MakeRoundedTextBox(System.Windows.Forms.TextBox txt, int radius = 8)
        {
            var panel = new System.Windows.Forms.Panel();
            panel.Size = new System.Drawing.Size(txt.Width + 4, txt.Height + 6);
            panel.Location = new System.Drawing.Point(txt.Left - 2, txt.Top - 3);
            panel.BackColor = txt.BackColor;
            panel.Parent = txt.Parent;

            txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txt.Parent = panel;
            txt.Location = new System.Drawing.Point(8, 5);
            txt.Width = panel.Width - 16;
            txt.BringToFront();

            panel.Paint += (s, e) =>
            {
                var g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                var rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
                int d = radius * 2;
                using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    path.AddArc(rect.X, rect.Y, d, d, 180, 90);
                    path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
                    path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
                    path.CloseAllFigures();
                    g.FillPath(new SolidBrush(txt.BackColor), path);
                    g.DrawPath(new Pen(System.Drawing.Color.FromArgb(210, 213, 218), 1.5f), path);
                }
            };

            panel.BringToFront();
        }

        private void DrawAvatar(PictureBox pb)
        {
            Bitmap bmp = new Bitmap(pb.Width, pb.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Blue circle background
                g.FillEllipse(new SolidBrush(Color.FromArgb(70, 130, 180)),
                    0, 0, pb.Width - 2, pb.Height - 2);

                // Head
                g.FillEllipse(Brushes.White, pb.Width / 2 - 12, 10, 24, 24);

                // Body
                g.FillEllipse(Brushes.White, pb.Width / 2 - 20, 38, 40, 30);
            }
            pb.Image = bmp;
        }
   

    }
}