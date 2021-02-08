namespace GOMOKU_19001
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.winCountBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dim12 = new System.Windows.Forms.RadioButton();
            this.dim8 = new System.Windows.Forms.RadioButton();
            this.dim10 = new System.Windows.Forms.RadioButton();
            this.dim5 = new System.Windows.Forms.RadioButton();
            this.dim3 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.gameGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.TwoPlayer = new System.Windows.Forms.CheckBox();
            this.HintButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // winCountBox
            // 
            this.winCountBox.Location = new System.Drawing.Point(12, 91);
            this.winCountBox.Name = "winCountBox";
            this.winCountBox.Size = new System.Drawing.Size(82, 20);
            this.winCountBox.TabIndex = 0;
            this.winCountBox.TabStop = false;
            this.winCountBox.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Moon 2.0 Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "WIN COUNT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Moon 2.0 Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "WELCOME TO GOMOKU";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dim12);
            this.panel1.Controls.Add(this.dim8);
            this.panel1.Controls.Add(this.dim10);
            this.panel1.Controls.Add(this.dim5);
            this.panel1.Controls.Add(this.dim3);
            this.panel1.Location = new System.Drawing.Point(138, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 27);
            this.panel1.TabIndex = 5;
            // 
            // dim12
            // 
            this.dim12.AutoSize = true;
            this.dim12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dim12.ForeColor = System.Drawing.Color.Black;
            this.dim12.Location = new System.Drawing.Point(263, 2);
            this.dim12.Name = "dim12";
            this.dim12.Size = new System.Drawing.Size(70, 22);
            this.dim12.TabIndex = 5;
            this.dim12.Text = "12x12";
            this.dim12.UseVisualStyleBackColor = true;
            // 
            // dim8
            // 
            this.dim8.AutoSize = true;
            this.dim8.Checked = true;
            this.dim8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dim8.ForeColor = System.Drawing.Color.Black;
            this.dim8.Location = new System.Drawing.Point(129, 2);
            this.dim8.Name = "dim8";
            this.dim8.Size = new System.Drawing.Size(52, 22);
            this.dim8.TabIndex = 3;
            this.dim8.TabStop = true;
            this.dim8.Text = "8x8";
            this.dim8.UseVisualStyleBackColor = true;
            // 
            // dim10
            // 
            this.dim10.AutoSize = true;
            this.dim10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dim10.ForeColor = System.Drawing.Color.Black;
            this.dim10.Location = new System.Drawing.Point(187, 2);
            this.dim10.Name = "dim10";
            this.dim10.Size = new System.Drawing.Size(70, 22);
            this.dim10.TabIndex = 4;
            this.dim10.Text = "10x10";
            this.dim10.UseVisualStyleBackColor = true;
            // 
            // dim5
            // 
            this.dim5.AutoSize = true;
            this.dim5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dim5.ForeColor = System.Drawing.Color.Black;
            this.dim5.Location = new System.Drawing.Point(70, 3);
            this.dim5.Name = "dim5";
            this.dim5.Size = new System.Drawing.Size(52, 22);
            this.dim5.TabIndex = 2;
            this.dim5.Text = "5x5";
            this.dim5.UseVisualStyleBackColor = true;
            // 
            // dim3
            // 
            this.dim3.AutoSize = true;
            this.dim3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dim3.ForeColor = System.Drawing.Color.Black;
            this.dim3.Location = new System.Drawing.Point(3, 3);
            this.dim3.Name = "dim3";
            this.dim3.Size = new System.Drawing.Size(52, 22);
            this.dim3.TabIndex = 1;
            this.dim3.Text = "3x3";
            this.dim3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Moon 2.0 Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(138, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "GRID SIZE";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Black;
            this.startButton.Location = new System.Drawing.Point(12, 117);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(108, 23);
            this.startButton.TabIndex = 8;
            this.startButton.TabStop = false;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // gameGrid
            // 
            this.gameGrid.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.gameGrid.Location = new System.Drawing.Point(13, 147);
            this.gameGrid.Name = "gameGrid";
            this.gameGrid.Size = new System.Drawing.Size(500, 500);
            this.gameGrid.TabIndex = 9;
            // 
            // TwoPlayer
            // 
            this.TwoPlayer.AutoSize = true;
            this.TwoPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoPlayer.ForeColor = System.Drawing.Color.Black;
            this.TwoPlayer.Location = new System.Drawing.Point(138, 119);
            this.TwoPlayer.Name = "TwoPlayer";
            this.TwoPlayer.Size = new System.Drawing.Size(105, 20);
            this.TwoPlayer.TabIndex = 10;
            this.TwoPlayer.Text = "Two Player";
            this.TwoPlayer.UseVisualStyleBackColor = true;
            // 
            // HintButton
            // 
            this.HintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HintButton.ForeColor = System.Drawing.Color.Black;
            this.HintButton.Location = new System.Drawing.Point(407, 120);
            this.HintButton.Name = "HintButton";
            this.HintButton.Size = new System.Drawing.Size(75, 23);
            this.HintButton.TabIndex = 11;
            this.HintButton.Text = "HINT";
            this.HintButton.UseVisualStyleBackColor = true;
            this.HintButton.Click += new System.EventHandler(this.HintButton_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(525, 657);
            this.Controls.Add(this.HintButton);
            this.Controls.Add(this.TwoPlayer);
            this.Controls.Add(this.gameGrid);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.winCountBox);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "GOMOKU";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox winCountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton dim12;
        private System.Windows.Forms.RadioButton dim8;
        private System.Windows.Forms.RadioButton dim10;
        private System.Windows.Forms.RadioButton dim5;
        private System.Windows.Forms.RadioButton dim3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.FlowLayoutPanel gameGrid;
        private System.Windows.Forms.CheckBox TwoPlayer;
        private System.Windows.Forms.Button HintButton;
    }
}

