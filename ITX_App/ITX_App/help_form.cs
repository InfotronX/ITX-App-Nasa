using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ITX_App
{
    public partial class help_form : Form
    {
        public help_form()
        {
            Init();
        }

        private void Init()
        {
            // Setăm dimensiunile formularului
            this.ClientSize = new Size(420, 420);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "Help";

            // Setăm fundalul
            this.BackgroundImage = Properties.Resources.ResourceManager.GetObject("help_form_background_image") as Image;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Crearea butoanelor
            Button btnCodeTutorial = new Button();
            Button btnAppTutorial = new Button();
            Button btnClose = new Button();

            // Setarea proprietăților pentru butonul Tutorial Cod
            btnCodeTutorial.Location = new Point(150, 150); // Poziție ajustată
            btnCodeTutorial.Name = "btnCodeTutorial";
            btnCodeTutorial.Size = new Size(150, 50);
            btnCodeTutorial.TabIndex = 0;
            btnCodeTutorial.Text = "Create an account";
            btnCodeTutorial.UseVisualStyleBackColor = true;
            btnCodeTutorial.BackColor = Color.Transparent;
            btnCodeTutorial.ForeColor = Color.White;
            btnCodeTutorial.FlatStyle = FlatStyle.Flat;
            btnCodeTutorial.FlatAppearance.BorderSize = 0;
            btnCodeTutorial.MouseEnter += BtnMouseEnter;
            btnCodeTutorial.MouseLeave += BtnMouseLeave;
            btnCodeTutorial.Click += new EventHandler(BtnCodeTutorial_Click);

            // Setarea proprietăților pentru butonul Tutorial Aplicație
            btnAppTutorial.Location = new Point(80, 220); // Poziție ajustată
            btnAppTutorial.Name = "btnAppTutorial";
            btnAppTutorial.Size = new Size(150, 50);
            btnAppTutorial.TabIndex = 1;
            btnAppTutorial.Text = "how to use the ITX app";
            btnAppTutorial.UseVisualStyleBackColor = true;
            btnAppTutorial.BackColor = Color.Transparent;
            btnAppTutorial.ForeColor = Color.White;
            btnAppTutorial.FlatStyle = FlatStyle.Flat;
            btnAppTutorial.FlatAppearance.BorderSize = 0;
            btnAppTutorial.MouseEnter += BtnMouseEnter;
            btnAppTutorial.MouseLeave += BtnMouseLeave;
            btnAppTutorial.Click += new EventHandler(BtnAppTutorial_Click);

            // Setarea proprietăților pentru butonul Close
            btnClose.Location = new Point(320, 10); // Poziția butonului Close
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 30);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.BackColor = Color.Transparent;
            btnClose.ForeColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.MouseEnter += BtnMouseEnter;
            btnClose.MouseLeave += BtnMouseLeave;
            btnClose.Click += new EventHandler(BtnClose_Click);

            // Adăugăm butoanele în formular
            this.Controls.Add(btnCodeTutorial);
            this.Controls.Add(btnAppTutorial);
            this.Controls.Add(btnClose);
        }

        private void BtnMouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.BackColor = Color.White; // Fundal alb
                button.ForeColor = Color.Black; // Text negru
            }
        }

        // Eveniment pentru când mouse-ul pleacă de pe butoane
        private void BtnMouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.BackColor = Color.Transparent; // Fundal transparent
                button.ForeColor = Color.White; // Text alb
            }
        }

        private void BtnCodeTutorial_Click(object sender, EventArgs e)
        {
            Process.Start("https://youtu.be/6cQ3a1G7skM");
        }

        // Event handler pentru click pe butonul Tutorial Aplicație
        private void BtnAppTutorial_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=example_app_tutorial"); 
        }

        // Event handler pentru click pe butonul de închidere
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Închide formularul
        }

        private void help_form_Load(object sender, EventArgs e)
        {
            Init();
        }
    }
}

