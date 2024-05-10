using System;
using System.Drawing;
using System.Windows.Forms;

namespace ООП_ШИРЯЄВ
{
    public partial class ArcanoidMenu : Form
    {
        private PictureBox gameMenu;

        public ArcanoidMenu()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            InitializeMenuButtons(); // SRP: Separated initialization of menu buttons.
            InitializeGameMenuPictureBox(); // SRP: Separated initialization of the game menu picture box.
            InitializeRulesPanel(); // SRP: Separated initialization of the rules panel.
        }

        private void InitializeMenuButtons()
        {
            GameRules.Text = "Rules";
            MenuExit.Text = "Exit";
            Constructor.Text = "Constructor";
            Play.Text = "Play";
        }

        private void InitializeGameMenuPictureBox()
        {
            gameMenu = new PictureBox();
            gameMenu.Image = Image.FromFile(@"Images\ArcanoidMenu.jpg");
            gameMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            gameMenu.Location = new Point(0, 0);
            gameMenu.Size = new Size(Width, Height);
            Controls.Add(gameMenu);
        }

        private void InitializeRulesPanel()
        {
            Rules.Image = Image.FromFile(@"Images\GameRules.png");
            Rules.Visible = false;
            Ok.Visible = false;
        }

        private void Play_Click(object sender, EventArgs e)
        {
            StartGame(); // SRP: Starting the game in a separate method.
        }

        private void StartGame()
        {
            MainForm gameForm = new MainForm();
            gameForm.Show();
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            ExitApplication(); // SRP: Exiting the application in a separate method.
        }

        private void ExitApplication()
        {
            Application.Exit();
        }

        private void GameRules_Click(object sender, EventArgs e)
        {
            ShowRules(); // SRP: Showing the rules in a separate method.
        }

        private void ShowRules()
        {
            Rules.Visible = true;
            Ok.Visible = true;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            HideRules(); // SRP: Hiding the rules in a separate method.
        }

        private void HideRules()
        {
            Rules.Visible = false;
            Ok.Visible = false;
        }

        private void Constructor_Click(object sender, EventArgs e)
        {
            OpenLevelConstructor(); // SRP: Opening the level constructor in a separate method.
        }

        private void OpenLevelConstructor()
        {
            LevelConstructor constructor = new LevelConstructor();
            constructor.Show();
        }

        private void ArcanoidMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
