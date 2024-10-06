using ITX_App;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ITX_App
{
    public partial class Log_in_form : Form
    {
        //TO DO schimbat doar baza de date

        private String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Nasa Space App 2024\\Cod David\\test1\\test1\\Data_base_users.mdf\";Integrated Security=True";
        private String query;
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader reader;

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnCreateAccount;

        public Log_in_form()
        {
            Init();
        }

        private void Init()
        {

            try
            {
                query = "select username , password from Users";

                con = new SqlConnection(connectionString);

                cmd = new SqlCommand(query, con);

                con.Open();

                DataSet ds = new DataSet();
  
            }
            catch (Exception es)
            {

                MessageBox.Show(es.Message);

            }

            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Setăm imaginea de fundal a formularului
            this.BackgroundImage = Properties.Resources.ResourceManager.GetObject("main_form_background_image") as Image;
            this.BackgroundImageLayout = ImageLayout.Stretch;
               
            // btnClose         
            this.btnClose.Location = new System.Drawing.Point(320, 240);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.BackColor = Color.Transparent;
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.ForeColor = Color.White;  // Text alb

            // MouseEnter și MouseLeave
            this.btnClose.MouseEnter += new EventHandler(this.Button_MouseEnter);
            this.btnClose.MouseLeave += new EventHandler(this.Button_MouseLeave);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // btnLogin
            this.btnLogin.Location = new System.Drawing.Point(120, 180);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.BackColor = Color.Transparent;
            this.btnLogin.FlatStyle = FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.ForeColor = Color.White;  // Text alb

            // MouseEnter și MouseLeave
            this.btnLogin.MouseEnter += new EventHandler(this.Button_MouseEnter);
            this.btnLogin.MouseLeave += new EventHandler(this.Button_MouseLeave);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // btnHelp
            this.btnHelp.Location = new System.Drawing.Point(20, 240);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.BackColor = Color.Transparent;
            this.btnHelp.FlatStyle = FlatStyle.Flat;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.ForeColor = Color.White;  // Text alb

            // MouseEnter și MouseLeave
            this.btnHelp.MouseEnter += new EventHandler(this.Button_MouseEnter);
            this.btnHelp.MouseLeave += new EventHandler(this.Button_MouseLeave);
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
 
            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(120, 60);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 22);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.BackColor = Color.White;  // Fundal alb pentru text box
            this.txtUsername.ForeColor = Color.Black;  // Text negru pentru text box

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(120, 120);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 22);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.BackColor = Color.White;  // Fundal alb pentru text box
            this.txtPassword.ForeColor = Color.Black;  // Text negru pentru text box
            this.lblPassword.ForeColor = System.Drawing.Color.White;

            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(20, 60);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 17);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username:";
            this.lblUsername.BackColor = Color.Transparent;
            this.lblUsername.ForeColor = System.Drawing.Color.White;

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 120);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            this.lblPassword.BackColor = Color.Transparent;

            // btnCreateAccount
            this.btnCreateAccount.Location = new System.Drawing.Point(220, 180);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(100, 23);
            this.btnCreateAccount.TabIndex = 7;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.BackColor = Color.Transparent;
            this.btnCreateAccount.FlatStyle = FlatStyle.Flat;
            this.btnCreateAccount.FlatAppearance.BorderSize = 0;
            this.btnCreateAccount.ForeColor = Color.White;  // Text alb

            // Evenimente MouseEnter și MouseLeave
            this.btnCreateAccount.MouseEnter += new EventHandler(this.Button_MouseEnter);
            this.btnCreateAccount.MouseLeave += new EventHandler(this.Button_MouseLeave);
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);

            // MainForm
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(420, 420);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnClose);
            this.Name = "Log-in Form";
            this.Text = "ITX App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // MouseEnter
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.ForeColor = Color.Black; // Schimbă textul la negru
            }
        }

        // MouseLeave
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.ForeColor = Color.White; // Revine textul la alb
            }
        }

        // butonul de închidere
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // butonul de login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            reader = cmd.ExecuteReader();
         
            bool verif = false;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            
            while(reader.Read() && verif == false)
            {
                if (reader["username"].ToString() == username)
                {
                    if (reader["password"].ToString() == password)
                        verif = true;
                }
            }

            if (verif == true)
            {
                reader.Close();
                Main_Dash_Form open = new Main_Dash_Form();
                open.Show();
            }
            else 
            {
                MessageBox.Show("Username or password are wrong");
                reader.Close();
            }
        }

        // butonul de ajutor
        private void btnHelp_Click(object sender, EventArgs e)
        {
            help_form open = new help_form();
            open.ShowDialog();
        }

        // butonul de creare cont
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            account_create_form open = new account_create_form();
            open.ShowDialog();
        }

        private void Log_in_form_Load(object sender, EventArgs e)
        {
            Init(); // Inițializarea interfeței formularului
        }
    }
}
