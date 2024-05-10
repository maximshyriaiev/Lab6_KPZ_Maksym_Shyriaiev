using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ООП_ШИРЯЄВ
{
    public partial class LevelConstructor : Form
    {
        private readonly BlockDrawer blockDrawer = new BlockDrawer();
        private string map = string.Empty;
        private int count = 0;

        public LevelConstructor()
        {
            InitializeComponent();
            InitializeControls();
        }

        // SRP: Initializes UI controls.
        private void InitializeControls()
        {
            AddBlue.Text = "Add Blue Block";
            AddPurple.Text = "Add Purple Block";
            SaveButton.Text = "Save";
            ConstructorExit.Text = "Exit";

            pictureBox1.Image = Image.FromFile(@"Images\BackBack.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Size = new Size(Width, Height);
            Controls.Add(pictureBox1);
        }

        // Creates a block with the given background image.
        // DIP: Accepts the path to the block's image as an argument to avoid direct dependency on the file system.
        private void CreateBlock(string backgroundImage)
        {
            blockDrawer.BlocksView = new PictureBox
            {
                Height = 32,
                Width = 100,
                Tag = "Blocks",
                BackgroundImage = Image.FromFile(backgroundImage)
            };

            // Positions the block within the drawing area.
            if (blockDrawer.Columns < 4)
            {
                if (blockDrawer.Rows < 5)
                {
                    blockDrawer.BlocksView.Left = blockDrawer.DirX;
                    blockDrawer.BlocksView.Top = blockDrawer.DirY;
                    DrawArea.Controls.Add(blockDrawer.BlocksView);

                    blockDrawer.DirX += blockDrawer.BlocksView.Width;
                    blockDrawer.Rows++;
                }
                if (blockDrawer.Rows == 5)
                {
                    blockDrawer.DirY += blockDrawer.BlocksView.Height;
                    blockDrawer.DirX = 9;
                    blockDrawer.Columns++;
                    blockDrawer.Rows = 0;
                }
            }
        }

        // Adds a blue block to the level.
        // OCP: Allows adding other types of blocks without modifying the LevelConstructor code.
        private void AddBlue_Click(object sender, EventArgs e)
        {
            if (count < 20)
            {
                CreateBlock(@"Images\BlueBlock.png");
                map += "0 ";
            }
            count++;
        }

        // Adds a purple block to the level.
        // OCP: Allows adding other types of blocks without modifying the LevelConstructor code.
        private void AddPurple_Click(object sender, EventArgs e)
        {
            if (count < 20)
            {
                CreateBlock(@"Images\PurpleBlock.png");
                map += "1 ";
            }
            count++;
        }

        // Saves the level configuration to a file.
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (DrawArea.Controls.Count == 0)
            {
                MessageBox.Show("Your level can't be empty!");
            }
            else
            {
                File.WriteAllText("level.txt", map.Trim());
            }
        }

        // Exits the level constructor.
        private void ConstructorExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DrawArea_Click(object sender, EventArgs e)
        {

        }
    }

    public class BlockDrawer
    {
        // Properties for block positioning.
        public int DirX { get; set; }
        public int DirY { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }

        public PictureBox BlocksView { get; set; }

        public BlockDrawer()
        {
            DirX = 9;
            DirY = 1;
            Rows = 0;
            Columns = 0;
        }
    }
}
