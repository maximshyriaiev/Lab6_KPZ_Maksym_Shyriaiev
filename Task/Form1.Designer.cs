
namespace ООП_ШИРЯЄВ
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GameMenu = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.ScoreCounter = new System.Windows.Forms.Label();
            this.LivesCounter = new System.Windows.Forms.Label();
            this.GameLevel = new System.Windows.Forms.Label();
            this.GameArea = new System.Windows.Forms.PictureBox();
            this.GameBall = new System.Windows.Forms.PictureBox();
            this.GamePlatform = new System.Windows.Forms.PictureBox();
            this.Msg = new System.Windows.Forms.Label();
            this.Continue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GameMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamePlatform)).BeginInit();
            this.SuspendLayout();
            // 
            // GameMenu
            // 
            this.GameMenu.BackColor = System.Drawing.Color.Transparent;
            this.GameMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GameMenu.BackgroundImage")));
            this.GameMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameMenu.Location = new System.Drawing.Point(782, 2);
            this.GameMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GameMenu.Name = "GameMenu";
            this.GameMenu.Size = new System.Drawing.Size(273, 991);
            this.GameMenu.TabIndex = 0;
            this.GameMenu.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            // 
            // ScoreCounter
            // 
            this.ScoreCounter.AutoSize = true;
            this.ScoreCounter.BackColor = System.Drawing.Color.Black;
            this.ScoreCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreCounter.ForeColor = System.Drawing.Color.White;
            this.ScoreCounter.Location = new System.Drawing.Point(801, 297);
            this.ScoreCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreCounter.Name = "ScoreCounter";
            this.ScoreCounter.Size = new System.Drawing.Size(150, 33);
            this.ScoreCounter.TabIndex = 5;
            this.ScoreCounter.Text = "SCORE: 0";
            // 
            // LivesCounter
            // 
            this.LivesCounter.AutoSize = true;
            this.LivesCounter.BackColor = System.Drawing.Color.Black;
            this.LivesCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivesCounter.ForeColor = System.Drawing.Color.White;
            this.LivesCounter.Location = new System.Drawing.Point(801, 385);
            this.LivesCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LivesCounter.Name = "LivesCounter";
            this.LivesCounter.Size = new System.Drawing.Size(128, 33);
            this.LivesCounter.TabIndex = 8;
            this.LivesCounter.Text = "LIVES: 3";
            // 
            // GameLevel
            // 
            this.GameLevel.AutoSize = true;
            this.GameLevel.BackColor = System.Drawing.Color.Black;
            this.GameLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameLevel.ForeColor = System.Drawing.Color.White;
            this.GameLevel.Location = new System.Drawing.Point(801, 206);
            this.GameLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GameLevel.Name = "GameLevel";
            this.GameLevel.Size = new System.Drawing.Size(128, 33);
            this.GameLevel.TabIndex = 9;
            this.GameLevel.Text = "LEVEL 1";
            // 
            // GameArea
            // 
            this.GameArea.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GameArea.Location = new System.Drawing.Point(-2, 2);
            this.GameArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GameArea.Name = "GameArea";
            this.GameArea.Size = new System.Drawing.Size(774, 1049);
            this.GameArea.TabIndex = 10;
            this.GameArea.TabStop = false;
            this.GameArea.Click += new System.EventHandler(this.GameArea_Click);
            // 
            // GameBall
            // 
            this.GameBall.BackColor = System.Drawing.Color.Transparent;
            this.GameBall.Image = ((System.Drawing.Image)(resources.GetObject("GameBall.Image")));
            this.GameBall.Location = new System.Drawing.Point(357, 755);
            this.GameBall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GameBall.Name = "GameBall";
            this.GameBall.Size = new System.Drawing.Size(38, 38);
            this.GameBall.TabIndex = 11;
            this.GameBall.TabStop = false;
            // 
            // GamePlatform
            // 
            this.GamePlatform.BackColor = System.Drawing.Color.Transparent;
            this.GamePlatform.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GamePlatform.BackgroundImage")));
            this.GamePlatform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GamePlatform.Location = new System.Drawing.Point(292, 914);
            this.GamePlatform.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GamePlatform.Name = "GamePlatform";
            this.GamePlatform.Size = new System.Drawing.Size(150, 49);
            this.GamePlatform.TabIndex = 12;
            this.GamePlatform.TabStop = false;
            // 
            // Msg
            // 
            this.Msg.AutoSize = true;
            this.Msg.BackColor = System.Drawing.Color.Transparent;
            this.Msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msg.ForeColor = System.Drawing.Color.Indigo;
            this.Msg.Location = new System.Drawing.Point(51, 428);
            this.Msg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Msg.Name = "Msg";
            this.Msg.Size = new System.Drawing.Size(0, 61);
            this.Msg.TabIndex = 13;
            this.Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Continue
            // 
            this.Continue.AutoSize = true;
            this.Continue.BackColor = System.Drawing.Color.Transparent;
            this.Continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.ForeColor = System.Drawing.Color.Indigo;
            this.Continue.Location = new System.Drawing.Point(124, 505);
            this.Continue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(0, 40);
            this.Continue.TabIndex = 14;
            this.Continue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1052, 950);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.Msg);
            this.Controls.Add(this.GamePlatform);
            this.Controls.Add(this.GameBall);
            this.Controls.Add(this.GameArea);
            this.Controls.Add(this.GameLevel);
            this.Controls.Add(this.LivesCounter);
            this.Controls.Add(this.ScoreCounter);
            this.Controls.Add(this.GameMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1074, 1007);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamePlatform)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GameMenu;
        private System.Windows.Forms.PictureBox GameArea;
        public System.Windows.Forms.Timer GameTimer;
        public System.Windows.Forms.Label ScoreCounter;
        public System.Windows.Forms.Label LivesCounter;
        public System.Windows.Forms.Label GameLevel;
        private System.Windows.Forms.PictureBox GameBall;
        private System.Windows.Forms.PictureBox GamePlatform;
        public System.Windows.Forms.Label Msg;
        public System.Windows.Forms.Label Continue;
    }
}

