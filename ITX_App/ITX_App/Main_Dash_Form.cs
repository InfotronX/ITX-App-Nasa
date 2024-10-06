using System;
using System.Drawing;
using System.Windows.Forms;

namespace ITX_App
{
    public partial class Main_Dash_Form : Form
    {
        public Main_Dash_Form()
        {
            Init();
        }

        private void Init()
        {
            this.ClientSize = new Size(420, 420); // Dimensiunea ferestrei
            this.StartPosition = FormStartPosition.CenterScreen; // Poziționarea pe ecran
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Bara de titlu vizibilă
            this.MaximizeBox = false; // Dezactivează butonul de maximizare
            this.Text = "Exoplanet Education - Learn";

            // Crearea butoanelor
            Button btnLesson1 = new Button();
            Button btnLesson2 = new Button();
            Button btnLesson3 = new Button();
            Button btnClose = new Button();

            // Setarea proprietăților pentru butonul Lesson 1
            btnLesson1.Location = new Point(60, 100); // Poziționarea butonului Lesson 1
            btnLesson1.Name = "btnLesson1"; // Numele butonului
            btnLesson1.Size = new Size(300, 70); // Dimensiunea butonului Lesson 1
            btnLesson1.TabIndex = 0; // Indexul pentru tabulare
            btnLesson1.Text = "Lesson 1: Theory of Exoplanets";
            btnLesson1.BackColor = Color.Transparent; // Fundal transparent
            btnLesson1.ForeColor = Color.White; // Text alb
            btnLesson1.FlatStyle = FlatStyle.Flat; // Stil plat
            btnLesson1.FlatAppearance.BorderSize = 0; // Fără margine
            btnLesson1.MouseEnter += BtnMouseEnter; // Când mouse-ul este deasupra
            btnLesson1.MouseLeave += BtnMouseLeave; // Când mouse-ul pleacă
            btnLesson1.Click += new EventHandler(BtnLesson1_Click);

            // Setarea proprietăților pentru butonul Lesson 2
            btnLesson2.Location = new Point(60, 180); // Poziționarea butonului Lesson 2
            btnLesson2.Name = "btnLesson2";
            btnLesson2.Size = new Size(300, 70); // Dimensiunea butonului Lesson 2
            btnLesson2.TabIndex = 1;
            btnLesson2.Text = "Lesson 2: Exoplanets";
            btnLesson2.BackColor = Color.Transparent;
            btnLesson2.ForeColor = Color.White;
            btnLesson2.FlatStyle = FlatStyle.Flat;
            btnLesson2.FlatAppearance.BorderSize = 0;
            btnLesson2.MouseEnter += BtnMouseEnter;
            btnLesson2.MouseLeave += BtnMouseLeave;
            btnLesson2.Click += new EventHandler(BtnLesson2_Click);

            // Setarea proprietăților pentru butonul de Close
            btnClose.Location = new Point(320, 360); // Poziționarea butonului Close în dreapta jos
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 25); // Dimensiunea butonului Close (mai mic)
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.BackColor = Color.Transparent; // Fundal transparent
            btnClose.ForeColor = Color.White; // Text alb
            btnClose.FlatStyle = FlatStyle.Flat; // Stil plat
            btnClose.FlatAppearance.BorderSize = 0; // Fără margine
            btnClose.MouseEnter += BtnMouseEnter; // Când mouse-ul este deasupra
            btnClose.MouseLeave += BtnMouseLeave; // Când mouse-ul pleacă
            btnClose.Click += new EventHandler(BtnClose_Click);

            // Adăugăm butoanele în formular
            this.Controls.Add(btnLesson1);
            this.Controls.Add(btnLesson2);
            this.Controls.Add(btnClose);

            // Opțional: adăugăm un fundal
            this.BackgroundImage = Properties.Resources.ResourceManager.GetObject("main_dash_form_background_image") as Image; // Înlocuiește cu resursa ta
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        // Eveniment pentru hover pe butoane
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

        // Event handler pentru click pe butonul Lesson 1
        private void BtnLesson1_Click(object sender, EventArgs e)
        {
            Exoplanets_theory_form open = new Exoplanets_theory_form();
            open.ShowDialog();
        }

        // Event handler pentru click pe butonul Lesson 2
        private void BtnLesson2_Click(object sender, EventArgs e)
        {
            Exoplanets_3D_form__1 open = new Exoplanets_3D_form__1();
            open.ShowDialog();
           
        }

        // Event handler pentru click pe butonul de închidere
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close(); // Închide aplicația
        }

        private void Main_Dash_Form_Load(object sender, EventArgs e)
        {
            Init();
        }
    }
}
