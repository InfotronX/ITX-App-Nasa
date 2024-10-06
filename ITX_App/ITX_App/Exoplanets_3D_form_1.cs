using ITX_App.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ITX_App
{
    public partial class Exoplanets_3D_form__1 : Form
    {
        private List<Exoplanet> exoplanets;
        private Exoplanet currentPlanet;
        private Button closeButton;
        private ComboBox planetComboBox; // Declarația controlului ComboBox
        private PictureBox pictureBox; // Înlocuim GlowingPictureBox cu PictureBox
        private Label infoLabel; // Declarația Label

        public Exoplanets_3D_form__1()
        {
            Init();
            InitializeComponent();

            // Inițializăm lista de exoplanete cu imaginile din resurse
            exoplanets = new List<Exoplanet>
            {
                new Exoplanet("Kepler-452b", "Distance: 1400 light years.\n• This planet orbits a star very similar to our sun.", 40, Resources.planet1),
                new Exoplanet("Proxima Centauri b", "Distance: 4.2 light years.\n• Closest known exoplanet to the sun.", 30, Resources.planet2),
                new Exoplanet("HD 209458b", "Distance: 150 light years.\n• First exoplanet observed transiting its star.\n• Known as a 'hot Jupiter,' with an extremely short orbit.\n• Atmosphere has been observed to contain water vapor and carbon dioxide.", 35, Resources.planet3),
                new Exoplanet("Trappist-1e", "Distance: 39 light years.\n• Located in a system with seven planets, three in the habitable zone.\n• It's an Earth-sized planet and may have an atmosphere that can support liquid water.", 25, Resources.planet4),
                new Exoplanet("55 Cancri e", "Distance: 41 light years.\n• Known as a super-Earth due to its high mass and density.\n• Surface temperatures can reach up to 2000 degrees Celsius.", 30, Resources.planet5),
                new Exoplanet("WASP-12b", "Distance: 600 light years.\n• Known as one of the darkest planets, it absorbs nearly all light that hits it.\n• Orbits very close to its star, resulting in extreme temperatures.", 45, Resources.planet6),
                new Exoplanet("Gliese 581g", "Distance: 20 light years.\n• Believed to be in the habitable zone of its star.\n• A prime candidate for supporting liquid water and possibly life.", 30, Resources.planet7),
                new Exoplanet("Kepler-22b", "Distance: 600 light years.\n• Roughly 2.4 times the size of Earth.\n• Located in the habitable zone, where it may support liquid water.", 30, Resources.planet8),
                new Exoplanet("HD 189733b", "Distance: 64 light years.\n• A 'hot Jupiter' known for high winds and potentially glass rain.\n• Visible clouds contain silicate particles, giving it a blue hue.", 35, Resources.planet9),
                new Exoplanet("Kepler-186f", "Distance: 490 light years.\n• First Earth-sized planet in the habitable zone of another star.\n• Thought to have water and possibly a rocky surface.", 30, Resources.planet10),
                new Exoplanet("GJ 1214b", "Distance: 40 light years.\n• Known as a 'water world', potentially having thick clouds.\n• Orbits a red dwarf star in the constellation Ophiuchus.", 30, Resources.planet11),
                new Exoplanet("LHS 1140b", "Distance: 40 light years.\n• A super-Earth located in the habitable zone.\n• Believed to be rocky with a dense atmosphere that could support life.", 25, Resources.planet12),
                new Exoplanet("TOI-700d", "Distance: 101 light years.\n• Similar in size to Earth, it is situated in the habitable zone.\n• Orbits a red dwarf star, possibly having conditions favorable for life.", 28, Resources.planet13),
                new Exoplanet("Ross 128 b", "Distance: 11 light years.\n• Closest potentially habitable exoplanet to Earth after Proxima Centauri b.\n• Orbits a calm red dwarf star, which increases its habitability potential.", 27, Resources.planet14),
                new Exoplanet("K2-18b", "Distance: 124 light years.\n• Known to have water vapor in its atmosphere.\n• Classified as a super-Earth, potentially habitable.", 40, Resources.planet15),
                new Exoplanet("GJ 357 d", "Distance: 31 light years.\n• Located in the habitable zone and is a super-Earth.\n• Conditions may support liquid water and possibly life.", 26, Resources.planet16),
                new Exoplanet("Wolf 1061c", "Distance: 14 light years.\n• A super-Earth found within the habitable zone.\n• Potentially has the right conditions for supporting life.", 29, Resources.planet17),
                new Exoplanet("GJ 273b", "Distance: 12 light years.\n• Also called Luyten b, it is located in the habitable zone.\n• Close to its red dwarf star, it may have liquid water.", 32, Resources.planet18),
            };

            currentPlanet = exoplanets[0];

            foreach (var planet in exoplanets)
            {
                planetComboBox.Items.Add(planet.Name);
            }

            planetComboBox.SelectedIndex = 0;

            // Setăm fundalul din resurse
            this.BackgroundImage = Resources.background;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Init()
        {
            this.WindowState = FormWindowState.Maximized;
            this.planetComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox = new PictureBox(); // Folosim PictureBox normal
            this.infoLabel = new System.Windows.Forms.Label();
            closeButton = new Button();
            closeButton.Text = "Close";
            closeButton.Size = new Size(100, 30);
            closeButton.Location = new Point(1400, 700); // Poziția în colțul din dreapta sus
            closeButton.Click += CloseButton_Click; // Adaugă evenimentul de click
            this.Controls.Add(closeButton);

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // planetComboBox
            // 
            this.planetComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.planetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.planetComboBox.SelectedIndexChanged += new System.EventHandler(this.planetComboBox_SelectedIndexChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Size = new Size(400, 400); // Dimensiunea imaginii
            this.pictureBox.Location = new Point(100, this.ClientSize.Height / 2 - this.pictureBox.Height / 2); // Poziționare stânga-mijloc
            this.pictureBox.Anchor = AnchorStyles.Left; // Fixăm la stânga
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // infoLabel
            // 
            this.infoLabel.Location = new Point(this.pictureBox.Right + 200, this.pictureBox.Top + 380); // Aliniat la dreapta imaginii
            this.infoLabel.Width = 400;
            this.infoLabel.Height = 300;
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.infoLabel.AutoSize = false;
            this.infoLabel.Font = new Font("Arial", 14, FontStyle.Bold);
            this.infoLabel.ForeColor = Color.Gold;
            this.infoLabel.BackColor = Color.Transparent;
            // 
            // ExoplanetDiscoveryForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.planetComboBox);
            this.Name = "ExoplanetDiscoveryForm";
            this.Text = "Exoplanet Discovery";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        private void planetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = planetComboBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < exoplanets.Count)
            {
                currentPlanet = exoplanets[selectedIndex];
                UpdateInfoAndImage();
            }
        }

        private void UpdateInfoAndImage()
        {
            infoLabel.Text = currentPlanet.Description;
            pictureBox.Image = currentPlanet.Image;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Închide formularul
        }

        private void Exoplanets_3D_form__1_Load(object sender, EventArgs e)
        {
            UpdateInfoAndImage();
        }
    }

    public class Exoplanet
    {
        public string Name { get; }
        public string Description { get; }
        public int Size { get; }
        public Image Image { get; }

        public Exoplanet(string name, string description, int size, Image image)
        {
            Name = name;
            Description = description;
            Size = size;
            Image = image;
        }
    }
}
