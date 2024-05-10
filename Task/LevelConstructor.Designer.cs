
using System.Windows.Forms;

namespace ООП_ШИРЯЄВ
{
    partial class LevelConstructor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelConstructor));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DrawArea = new System.Windows.Forms.PictureBox();
            this.AddBlue = new System.Windows.Forms.Button();
            this.AddPurple = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ConstructorExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawArea)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(783, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 978);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DrawArea
            // 
            this.DrawArea.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DrawArea.Location = new System.Drawing.Point(0, 0);
            this.DrawArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DrawArea.Name = "DrawArea";
            this.DrawArea.Size = new System.Drawing.Size(774, 1049);
            this.DrawArea.TabIndex = 11;
            this.DrawArea.TabStop = false;
            this.DrawArea.Click += new System.EventHandler(this.DrawArea_Click);
            // 
            // AddBlue
            // 
            this.AddBlue.BackColor = System.Drawing.Color.Transparent;
            this.AddBlue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddBlue.BackgroundImage")));
            this.AddBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBlue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBlue.ForeColor = System.Drawing.Color.White;
            this.AddBlue.Location = new System.Drawing.Point(806, 171);
            this.AddBlue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddBlue.Name = "AddBlue";
            this.AddBlue.Size = new System.Drawing.Size(255, 77);
            this.AddBlue.TabIndex = 12;
            this.AddBlue.Text = "Add Blue Block";
            this.AddBlue.UseVisualStyleBackColor = false;
            this.AddBlue.Click += new System.EventHandler(this.AddBlue_Click);
            // 
            // AddPurple
            // 
            this.AddPurple.BackColor = System.Drawing.Color.Transparent;
            this.AddPurple.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddPurple.BackgroundImage")));
            this.AddPurple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPurple.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddPurple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPurple.ForeColor = System.Drawing.Color.White;
            this.AddPurple.Location = new System.Drawing.Point(806, 277);
            this.AddPurple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddPurple.Name = "AddPurple";
            this.AddPurple.Size = new System.Drawing.Size(255, 77);
            this.AddPurple.TabIndex = 13;
            this.AddPurple.Text = "Add Purple Block";
            this.AddPurple.UseVisualStyleBackColor = false;
            this.AddPurple.Click += new System.EventHandler(this.AddPurple_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveButton.BackgroundImage")));
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(802, 440);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(262, 74);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ConstructorExit
            // 
            this.ConstructorExit.BackColor = System.Drawing.Color.Transparent;
            this.ConstructorExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConstructorExit.BackgroundImage")));
            this.ConstructorExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConstructorExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConstructorExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConstructorExit.ForeColor = System.Drawing.Color.White;
            this.ConstructorExit.Location = new System.Drawing.Point(802, 862);
            this.ConstructorExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConstructorExit.Name = "ConstructorExit";
            this.ConstructorExit.Size = new System.Drawing.Size(262, 74);
            this.ConstructorExit.TabIndex = 15;
            this.ConstructorExit.Text = "Exit";
            this.ConstructorExit.UseVisualStyleBackColor = false;
            this.ConstructorExit.Click += new System.EventHandler(this.ConstructorExit_Click);
            // 
            // LevelConstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1076, 977);
            this.Controls.Add(this.ConstructorExit);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddPurple);
            this.Controls.Add(this.AddBlue);
            this.Controls.Add(this.DrawArea);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "LevelConstructor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конструктор уровней";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox DrawArea;
        private System.Windows.Forms.Button AddBlue;
        private System.Windows.Forms.Button AddPurple;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ConstructorExit;
    }
}