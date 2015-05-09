namespace Game_Of_Memory
{
    partial class Score
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnZacuvajRezultat = new System.Windows.Forms.Button();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Резултат:";
            // 
            // btnZacuvajRezultat
            // 
            this.btnZacuvajRezultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZacuvajRezultat.Location = new System.Drawing.Point(64, 342);
            this.btnZacuvajRezultat.Name = "btnZacuvajRezultat";
            this.btnZacuvajRezultat.Size = new System.Drawing.Size(223, 46);
            this.btnZacuvajRezultat.TabIndex = 2;
            this.btnZacuvajRezultat.Text = "Зачувај го резултатот";
            this.btnZacuvajRezultat.UseVisualStyleBackColor = true;
            this.btnZacuvajRezultat.Click += new System.EventHandler(this.btnZacuvajRezultat_Click);
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(81, 151);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(191, 20);
            this.tbIme.TabIndex = 3;
            this.tbIme.Text = "Внеси име";
            this.tbIme.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_Of_Memory.Properties.Resources.welldone1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(354, 388);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.btnZacuvajRezultat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Score";
            this.Text = "Резултат";
            this.Load += new System.EventHandler(this.Score_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnZacuvajRezultat;
        private System.Windows.Forms.TextBox tbIme;
    }
}