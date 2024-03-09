namespace SnakeC_
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Apple = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.lose = new System.Windows.Forms.Label();
            this.LimeColor = new System.Windows.Forms.RadioButton();
            this.BlueColor = new System.Windows.Forms.RadioButton();
            this.YellowColor = new System.Windows.Forms.RadioButton();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Button();
            this.VioletColor = new System.Windows.Forms.RadioButton();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 75;
            this.Timer.Tick += new System.EventHandler(this.update);
            // 
            // Apple
            // 
            this.Apple.AutoSize = true;
            this.Apple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Apple.ForeColor = System.Drawing.Color.Red;
            this.Apple.Location = new System.Drawing.Point(870, 9);
            this.Apple.Name = "Apple";
            this.Apple.Size = new System.Drawing.Size(0, 20);
            this.Apple.TabIndex = 0;
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Lime;
            this.PlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayButton.Location = new System.Drawing.Point(380, 200);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(240, 100);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(380, 450);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(240, 100);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // lose
            // 
            this.lose.AutoSize = true;
            this.lose.Font = new System.Drawing.Font("Mistral", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lose.ForeColor = System.Drawing.Color.Red;
            this.lose.Location = new System.Drawing.Point(380, 100);
            this.lose.Name = "lose";
            this.lose.Size = new System.Drawing.Size(247, 56);
            this.lose.TabIndex = 3;
            this.lose.Text = "Вы проиграли";
            // 
            // LimeColor
            // 
            this.LimeColor.AutoSize = true;
            this.LimeColor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimeColor.ForeColor = System.Drawing.SystemColors.Window;
            this.LimeColor.Location = new System.Drawing.Point(230, 337);
            this.LimeColor.Name = "LimeColor";
            this.LimeColor.Size = new System.Drawing.Size(80, 23);
            this.LimeColor.TabIndex = 4;
            this.LimeColor.TabStop = true;
            this.LimeColor.Text = "Зелёная";
            this.LimeColor.UseVisualStyleBackColor = true;
            // 
            // BlueColor
            // 
            this.BlueColor.AutoSize = true;
            this.BlueColor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BlueColor.ForeColor = System.Drawing.SystemColors.Window;
            this.BlueColor.Location = new System.Drawing.Point(380, 337);
            this.BlueColor.Name = "BlueColor";
            this.BlueColor.Size = new System.Drawing.Size(70, 23);
            this.BlueColor.TabIndex = 5;
            this.BlueColor.TabStop = true;
            this.BlueColor.Text = "Синяя";
            this.BlueColor.UseVisualStyleBackColor = true;
            // 
            // YellowColor
            // 
            this.YellowColor.AutoSize = true;
            this.YellowColor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YellowColor.ForeColor = System.Drawing.SystemColors.Window;
            this.YellowColor.Location = new System.Drawing.Point(540, 335);
            this.YellowColor.Name = "YellowColor";
            this.YellowColor.Size = new System.Drawing.Size(87, 25);
            this.YellowColor.TabIndex = 6;
            this.YellowColor.TabStop = true;
            this.YellowColor.Text = "Жёлтая";
            this.YellowColor.UseVisualStyleBackColor = true;
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.ColorLabel.Location = new System.Drawing.Point(432, 308);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(129, 24);
            this.ColorLabel.TabIndex = 7;
            this.ColorLabel.Text = "Цвет змейки ";
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Lime;
            this.Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Play.Location = new System.Drawing.Point(869, 587);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(100, 60);
            this.Play.TabIndex = 8;
            this.Play.Text = ">>";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // VioletColor
            // 
            this.VioletColor.AutoSize = true;
            this.VioletColor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VioletColor.ForeColor = System.Drawing.SystemColors.Window;
            this.VioletColor.Location = new System.Drawing.Point(678, 335);
            this.VioletColor.Name = "VioletColor";
            this.VioletColor.Size = new System.Drawing.Size(123, 25);
            this.VioletColor.TabIndex = 9;
            this.VioletColor.TabStop = true;
            this.VioletColor.Text = "Фиолетовая";
            this.VioletColor.UseVisualStyleBackColor = false;
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LengthLabel.ForeColor = System.Drawing.Color.Yellow;
            this.LengthLabel.Location = new System.Drawing.Point(13, 9);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(0, 20);
            this.LengthLabel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.VioletColor);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.YellowColor);
            this.Controls.Add(this.BlueColor);
            this.Controls.Add(this.LimeColor);
            this.Controls.Add(this.lose);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.Apple);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label Apple;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label lose;
        private System.Windows.Forms.RadioButton LimeColor;
        private System.Windows.Forms.RadioButton BlueColor;
        private System.Windows.Forms.RadioButton YellowColor;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.RadioButton VioletColor;
        private System.Windows.Forms.Label LengthLabel;
    }
}

