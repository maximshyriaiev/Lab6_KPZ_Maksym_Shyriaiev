using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Media;


namespace ООП_ШИРЯЄВ
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            DoubleBuffered = true;
            ScoreCounter.Text = "SCORE: 0";
            LivesCounter.Text = "LIVES: 3";
            Msg.Text = "TO START";
            Continue.Text = "PRESS SPACE";
            GameLevel.Text = "Level 1";
            GameMenu.Image = Image.FromFile(@"Images\ArcanoidMenu2.jpg");

        }

    
        private void MainForm_Load(object sender, EventArgs e)
        {
            Game game = new Game(GameBall, GamePlatform, GameArea, GameTimer, ScoreCounter, Msg, GameLevel, LivesCounter, Continue);

            KeyUp += game.StartGame;
            GameTimer.Tick += game.GameTime;
            GameTimer.Tick += game.Collision;
            KeyDown += game.KeyIsDown;
            KeyUp += game.KeyIsUp;
            KeyUp += game.GoNext;
        }

        private void GameArea_Click(object sender, EventArgs e)
        {

        }
    }

    class Game
    {
        Platform gamePlatform = new Platform();
        Ball gameBall = new Ball();
        GameArea gameArea = new GameArea();
        Blocks gameBlocks = new Blocks();
        Bonus gameBonus;

        Timer gameTimer = new Timer();
        Timer timeBonus = new Timer();

        readonly Label scoreCounter = new Label();
        readonly Label msg = new Label();
        readonly Label gameLevel = new Label();
        readonly Label livesCounter = new Label();
        readonly Label continueGame = new Label();

        private Random randomBallSpeed = new Random();
        private bool GameIsOver { get; set; }
        private bool NextLevel { get; set; }
        private int Score { get; set; }
        private int Lives { get; set; }

        private bool BonusIsLive = true;

        public Game(PictureBox ballView, PictureBox platformView, PictureBox areaView, Timer gameTime, Label sCount, Label mess, Label gLevel, Label lCount, Label cont)
        {
            gameBall.BallView = ballView;
            gamePlatform.PlatformView = platformView;
            gameArea.AreaView = areaView;
            gameTimer = gameTime;

            scoreCounter = sCount;
            msg = mess;
            gameLevel = gLevel;
            livesCounter = lCount;
            continueGame = cont;
        }

        private void GameSetup()
        {
            GameIsOver = false;
            NextLevel = false;

            Score = 0;
            Lives = 3;

            continueGame.Text = "";
            msg.Text = "";
            gameLevel.Text = "LEVEL 1";
            gameBall.BallView.Left = gameArea.AreaWidth / 2;
            gameBall.BallView.Top = gameArea.AreaHeight / 2;
            gamePlatform.PlatformView.Left = gameArea.AreaWidth / 2;
            gameTimer.Start();
        }

        public void StartGame(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                GenerateBlocks();
                GameSetup();
            }
        }
       

        private void GenerateBlocks()
        {
            int row = 0;
            int top = 0;
            int left = 12;

            for (int i = 0; i < 20; i++)
            {
                gameBlocks.blocks = new PictureBox
                {
                    Height = gameBlocks.BlockHeight,
                    Width = gameBlocks.BlockWidth,
                    Tag = "Blocks",
                    BackgroundImage = Image.FromFile(@"Images\BlueBlock.png")
                };

                if (row == 5)
                {
                    top += 32;
                    left = 12;
                    row = 0;
                }
                if (row < 5)
                {
                    row++;
                    gameBlocks.blocks.Left = left;
                    gameBlocks.blocks.Top = top;
                    gameArea.AreaView.Controls.Add(gameBlocks.blocks);
                    left = left + 100;
                }
            }
        }

        private void GenerateLevel()
        {
            string blocks;
            try
            {
                StreamReader reader = new StreamReader("level.txt", Encoding.Default);
                blocks = reader.ReadToEnd();
                reader.Close();

                string[] x = blocks.Split(null);

                int row = 0;
                int top = 0;
                int left = 12;

                for (int i = 0; i < x.Length; i++)
                {
                    gameBlocks.blocks = new PictureBox
                    {
                        Height = gameBlocks.BlockHeight,
                        Width = gameBlocks.BlockWidth
                    };

                    if (row < 5)
                    {
                        if (x[i] == "0")
                        {
                            gameBlocks.blocks.Tag = "Blocks";
                            gameBlocks.blocks.BackgroundImage = Image.FromFile(@"Images\BlueBlock.png");
                        }
                        if (x[i] == "1")
                        {
                            gameBlocks.blocks.Tag = "HardBlocks";
                            gameBlocks.blocks.BackgroundImage = Image.FromFile(@"Images\PurpleBlock.png");
                        }

                        gameArea.AreaView.Controls.Add(gameBlocks.blocks);
                        gameBlocks.blocks.Left = left;
                        gameBlocks.blocks.Top = top;
                        row++;
                        left = left + 100;
                    }

                    if (row == 5)
                    {
                        top += 32;
                        left = 12;
                        row = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}! File not found!");
            }

        }

        private void RemoveBlocks()
        {
            foreach (Control x in gameArea.AreaView.Controls)
            {
                gameArea.AreaView.Controls.Clear();
            }
        }

        public void GameTime(object sender, EventArgs e)
        {
            scoreCounter.Text = "SCORE: " + Score;
            livesCounter.Text = "LIVES: " + Lives;

            if (gamePlatform.MoveLeft == true && gamePlatform.PlatformView.Left > 0)
            {
                gamePlatform.PlatformView.Left -= gamePlatform.PlatformSpeed;
            }
            if (gamePlatform.MoveRight == true && gamePlatform.PlatformView.Left < gameArea.AreaView.Width - gamePlatform.PlatformView.Width)
            {
                gamePlatform.PlatformView.Left += gamePlatform.PlatformSpeed;
            }

            gameBall.BallView.Left += gameBall.BallSpeedX;
            gameBall.BallView.Top += gameBall.BallSpeedY;
            if (gameBonus != null)
            {
                gameBonus.BonusView.Top += gameBonus.BonusSpeed;
            }

            if (gameArea.AreaView.Controls.Count == 0 && NextLevel == false)
            {
                GameContinue();
                Score += 100;
            }

            if (gameBall.BallView.Top > gameArea.AreaView.Height)
            {
                Lives--;
                if (Lives <= 0)
                {
                    livesCounter.Text = "LIVES: 0";
                    GameOver("Game Over");
                }
                else
                {
                    gameBall.BallView.Left = gameArea.AreaWidth / 2;
                    gameBall.BallView.Top = gameArea.AreaHeight / 2;
                    gamePlatform.PlatformView.Left = gameArea.AreaWidth / 2;
                }
            }

            if (gameArea.AreaView.Controls.Count == 0 && NextLevel == true)
            {
                GameOver("You won!");
            }
        }

        public void Collision(object sender, EventArgs e)
        {
            if (gameBall.BallView.Bounds.IntersectsWith(gamePlatform.PlatformView.Bounds))
            {
                gameBall.BallSpeedY = randomBallSpeed.Next(6, 10) * -1;

                if (gameBall.BallSpeedX < 0)
                {
                    gameBall.BallSpeedX = randomBallSpeed.Next(6, 10) * -1;
                }
                else
                {
                    gameBall.BallSpeedX = randomBallSpeed.Next(6, 10);
                }
            }

            if (gameBall.BallView.Left < 0 || gameBall.BallView.Left > gameArea.AreaWidth - gameBall.BallView.Width)
            {
                gameBall.BallSpeedX = -gameBall.BallSpeedX;
            }
            if (gameBall.BallView.Top < 0 || gameBall.BallView.Top > gameArea.AreaHeight)
            {
                gameBall.BallSpeedY = -gameBall.BallSpeedY;
            }

            foreach (Control x in gameArea.AreaView.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Blocks")
                {
                    if (gameBall.BallView.Bounds.IntersectsWith(x.Bounds))
                    {
                        Score += 10;
                        gameBall.BallSpeedY = -gameBall.BallSpeedY;
                        gameArea.AreaView.Controls.Remove(x);
                        GenerateBonus();
                    }
                }

                if (x is PictureBox && (string)x.Tag == "HardBlocks")
                {
                    if (gameBall.BallView.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameBall.BallSpeedY = -gameBall.BallSpeedY;
                        x.BackgroundImage = Image.FromFile(@"Images\PurpleBlockDestroyed.png");
                        x.Tag = "damageBlock";
                    }
                }
                else if (x is PictureBox && (string)x.Tag == "damageBlock")
                {
                    if (gameBall.BallView.Bounds.IntersectsWith(x.Bounds))
                    {
                        Score += 10;
                        gameBall.BallSpeedY = -gameBall.BallSpeedY;
                        gameArea.AreaView.Controls.Remove(x);
                    }
                }

                if (x is PictureBox && (string)x.Tag == "ScoreBonus")
                {
                    if (x.Top > gameArea.AreaView.Height)
                    {
                        gameArea.AreaView.Controls.Remove(x);
                        BonusIsLive = true;
                    }

                    if (gamePlatform.PlatformView.Bounds.IntersectsWith(x.Bounds))
                    {
                        Score += ((ScoreBonus)gameBonus).ExtraScore;
                        gameArea.AreaView.Controls.Remove(x);
                        BonusIsLive = true;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "LifeBonus")
                {
                    if (x.Top > gameArea.AreaView.Height)
                    {
                        gameArea.AreaView.Controls.Remove(x);
                        BonusIsLive = true;
                    }

                    if (gamePlatform.PlatformView.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (Lives < 5)
                        {
                            Lives += ((LifeBonus)gameBonus).ExtraLife;
                        }
                        gameArea.AreaView.Controls.Remove(x);
                        BonusIsLive = true;
                    }
                    
                }
               

                if (x is PictureBox && (string)x.Tag == "PlatformBonus")
                {
                    if (x.Top > gameArea.AreaView.Height)
                    {
                        gameArea.AreaView.Controls.Remove(x);
                        BonusIsLive = true;
                    }

                    if (gamePlatform.PlatformView.Bounds.IntersectsWith(x.Bounds))
                    {
                        gamePlatform.PlatformView.Width = gamePlatform.PlatformWidth + ((PlatformBonus)gameBonus).ExtraWidth;
                        gamePlatform.PlatformView.BackgroundImage = Image.FromFile(@"Images\BigPlatform.png");

                        gameArea.AreaView.Controls.Remove(x);
                        BonusIsLive = true;

                        timeBonus.Interval = 10000;

                        timeBonus.Tick += TimeBonus_Tick;
                        timeBonus.Start();
                    }
                    if (x is PictureBox && (string)x.Tag == "SpeedBonus")
{
    if (x.Top > gameArea.AreaView.Height)
    {
        gameArea.AreaView.Controls.Remove(x);
        BonusIsLive = true;
    }
}

                }
            }
        }

        private void TimeBonus_Tick(object sender, EventArgs e)
        {
            gamePlatform.PlatformView.Width = gamePlatform.PlatformWidth;
            gamePlatform.PlatformView.BackgroundImage = Image.FromFile(@"Images\gamePlatform.png");
            timeBonus.Stop();
        }

        private void GenerateBonus()
        {
            Random randBonus = new Random();
            int random = randBonus.Next(1, 5);

            if (random == 1)
            {

                if (BonusIsLive == true)
                {
                    gameBonus = new ScoreBonus();
                    gameBonus.BonusView = new PictureBox
                    {
                        BackgroundImage = Image.FromFile(gameBonus.BonusBackGround),
                        Width = gameBonus.BonusWidth,
                        Height = gameBonus.BonusHeight,
                        Top = gameArea.AreaHeight / 2,
                        Left = gameArea.AreaWidth / 2,
                        Tag = "ScoreBonus"
                    };
                }
                BonusIsLive = false;
            }

            if (random == 2)
            {
                if (BonusIsLive == true)
                {
                    gameBonus = new LifeBonus();
                    gameBonus.BonusView = new PictureBox
                    {
                        BackgroundImage = Image.FromFile(gameBonus.BonusBackGround),
                        Width = gameBonus.BonusWidth,
                        Height = gameBonus.BonusHeight,
                        Top = gameArea.AreaHeight / 2,
                        Left = gameArea.AreaWidth / 2,
                        Tag = "LifeBonus"
                    };
                }
                BonusIsLive = false;
            }

            if (random == 3)
            {
                if (BonusIsLive == true)
                {
                    gameBonus = new PlatformBonus();
                    gameBonus.BonusView = new PictureBox
                    {
                        BackgroundImage = Image.FromFile(gameBonus.BonusBackGround),
                        Width = gameBonus.BonusWidth,
                        Height = gameBonus.BonusHeight,
                        Top = gameArea.AreaHeight / 2,
                        Left = gameArea.AreaWidth / 2,
                        Tag = "PlatformBonus"
                    };
                }
                BonusIsLive = false;
            }
            if (gameBonus != null) gameArea.AreaView.Controls.Add(gameBonus.BonusView);
        }

        private void GameContinue()
        {
            NextLevel = true;
            gameLevel.Text = "Level 2";

            gameBall.BallView.Left = gameArea.AreaWidth / 2;
            gameBall.BallView.Top = gameArea.AreaHeight / 2;
            gamePlatform.PlatformView.Left = gameArea.AreaWidth / 2;

            RemoveBlocks();
            GenerateLevel();
        }

        private void GameOver(string message)
        {
            GameIsOver = true;
            gameTimer.Stop();

            scoreCounter.Text = "Score: " + Score;
            msg.Text = message;
            continueGame.Text = "Press Enter";
        }

        public void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                gamePlatform.MoveLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                gamePlatform.MoveRight = true;
            }
        }

        public void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                gamePlatform.MoveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                gamePlatform.MoveRight = false;
            }
        }

        public void GoNext(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && GameIsOver == true)
            {
                RemoveBlocks();
                GameSetup();
                GenerateBlocks();
            }
        }
    }

    class Platform
    {
        public int PlatformSpeed { get; }
        public int PlatformWidth { get; }

        public bool MoveLeft { get; set; }
        public bool MoveRight { get; set; }

        public PictureBox PlatformView = new PictureBox();

        public Platform()
        {
            PlatformSpeed = 12;
            PlatformWidth = 100;
        }
    }

    class Ball
    {
        public int BallSpeedX { get; set; }
        public int BallSpeedY { get; set; }

        public PictureBox BallView = new PictureBox();

        public Ball()
        {
            BallSpeedX = 5;
            BallSpeedY = 5;
        }
    }

    class GameArea
    {
        public PictureBox AreaView = new PictureBox();
        public int AreaWidth { get; }
        public int AreaHeight { get; }

        public GameArea()
        {
            AreaWidth = 516;
            AreaHeight = 682;
        }
    }

    class Blocks
    {
        public PictureBox blocks = new PictureBox();
        public int BlockHeight { get; }
        public int BlockWidth { get; }

        public Blocks()
        {
            BlockHeight = 32;
            BlockWidth = 100;
        }
    }

    abstract class Bonus
    {
        public PictureBox BonusView = new PictureBox();

        public int BonusSpeed { get; }
        public int BonusHeight { get; }
        public int BonusWidth { get; }
        public string BonusBackGround { get; }

        public Bonus(string bonusBackGround)
        {
            BonusSpeed = 4;
            BonusHeight = 25;
            BonusWidth = 26;
            BonusBackGround = bonusBackGround;
        }
    }

    class LifeBonus : Bonus
    {
        public int ExtraLife { get; }

        public LifeBonus() : base(@"Images\LifeBonus.png")
        {
            ExtraLife = 1;
        }
    }

    class ScoreBonus : Bonus
    {
        public int ExtraScore { get; }

        public ScoreBonus() : base(@"Images\ScoreBonus.png")
        {
            ExtraScore = 50;
        }
    }

    class PlatformBonus : Bonus
    {
        public int ExtraWidth { get; }

        public PlatformBonus() : base(@"Images\PlatBonus.png")
        {
            ExtraWidth = 50;
        }
}

   }