namespace Game_Of_Memory
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.lbHightScore = new System.Windows.Forms.ListBox();
            this.btnHightScore = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlPanela1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlPanela1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Of Memory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.Color.Transparent;
            this.btnEasy.Location = new System.Drawing.Point(46, 85);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(140, 41);
            this.btnEasy.TabIndex = 1;
            this.btnEasy.Text = "EASY";
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(46, 155);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(140, 41);
            this.btnMedium.TabIndex = 2;
            this.btnMedium.Text = "MEDIUM";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnHard
            // 
            this.btnHard.Location = new System.Drawing.Point(46, 227);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(140, 41);
            this.btnHard.TabIndex = 3;
            this.btnHard.Text = "HARD";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // lbHightScore
            // 
            this.lbHightScore.FormattingEnabled = true;
            this.lbHightScore.Location = new System.Drawing.Point(219, 130);
            this.lbHightScore.Name = "lbHightScore";
            this.lbHightScore.Size = new System.Drawing.Size(224, 95);
            this.lbHightScore.TabIndex = 4;
            this.lbHightScore.Visible = false;
            // 
            // btnHightScore
            // 
            this.btnHightScore.Location = new System.Drawing.Point(219, 85);
            this.btnHightScore.Name = "btnHightScore";
            this.btnHightScore.Size = new System.Drawing.Size(224, 30);
            this.btnHightScore.TabIndex = 5;
            this.btnHightScore.Text = "Најдобри резултати";
            this.btnHightScore.UseVisualStyleBackColor = true;
            this.btnHightScore.Click += new System.EventHandler(this.btnHightScore_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "За играта";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlPanela1
            // 
            this.pnlPanela1.Controls.Add(this.label2);
            this.pnlPanela1.Location = new System.Drawing.Point(219, 231);
            this.pnlPanela1.Name = "pnlPanela1";
            this.pnlPanela1.Size = new System.Drawing.Size(224, 100);
            this.pnlPanela1.TabIndex = 7;
            this.pnlPanela1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 52);
            this.label2.TabIndex = 0;
            this.label2.Text = "Game of Memory е имплементација на мемориска игра чија цел е да се погодат сите п" +
    "арови на слики и собирање на колку што може повеке поени.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_Of_Memory.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(455, 357);
            this.Controls.Add(this.pnlPanela1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHightScore);
            this.Controls.Add(this.lbHightScore);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Game Of Memory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlPanela1.ResumeLayout(false);
            this.pnlPanela1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.ListBox lbHightScore;
        private System.Windows.Forms.Button btnHightScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel pnlPanela1;
        private System.Windows.Forms.Label label2;
    }
}

