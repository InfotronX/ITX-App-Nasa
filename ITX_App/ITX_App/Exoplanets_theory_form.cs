using ITX_App.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ITX_App
{
    public partial class Exoplanets_theory_form : Form
    {
        public Exoplanets_theory_form()
        {
            InitializeComponent();

            // Setăm formularul să fie fullscreen la deschidere
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;  // Eliminăm bordura pentru a fi fullscreen complet

            // Adăugăm butonul de Close în partea dreaptă sus
            Button btnClose = new Button();
            btnClose.Text = "Close";
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Size = new Size(60, 40);
            btnClose.Location = new Point(this.ClientSize.Width - btnClose.Width - 10, 10);
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;  // Ancorăm butonul în dreapta sus
            btnClose.Click += BtnClose_Click;
            this.Controls.Add(btnClose);

            // Setăm imaginea de fundal preluată din resurse
            this.BackgroundImage = Resources.ResourceManager.GetObject("theory_form_background_image") as Image;
            this.BackgroundImageLayout = ImageLayout.Stretch;  // Setăm ca imaginea să fie redimensionată pe tot ecranul
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            // Închiderea formularului la apăsarea butonului
            Close();
        }

        private void Exoplanets_theory_form_Load(object sender, EventArgs e)
        {
            // Orice cod suplimentar care trebuie încărcat la deschiderea formularului
        }
    }
}
