namespace durak_final
{
    partial class AboutForm
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
            this.GameNameLabel = new System.Windows.Forms.Label();
            this.AuthorsLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.HowToPlayLabel = new System.Windows.Forms.Label();
            this.DisplayNameLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DiscriptionDisplayLabel = new System.Windows.Forms.Label();
            this.HowToPlayDisplayLabel = new System.Windows.Forms.Label();
            this.ExitButtion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameNameLabel
            // 
            this.GameNameLabel.AutoSize = true;
            this.GameNameLabel.Location = new System.Drawing.Point(12, 9);
            this.GameNameLabel.Name = "GameNameLabel";
            this.GameNameLabel.Size = new System.Drawing.Size(55, 20);
            this.GameNameLabel.TabIndex = 0;
            this.GameNameLabel.Text = "Name:";
            // 
            // AuthorsLabel
            // 
            this.AuthorsLabel.AutoSize = true;
            this.AuthorsLabel.Location = new System.Drawing.Point(11, 46);
            this.AuthorsLabel.Name = "AuthorsLabel";
            this.AuthorsLabel.Size = new System.Drawing.Size(69, 20);
            this.AuthorsLabel.TabIndex = 2;
            this.AuthorsLabel.Text = "Authors:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(11, 84);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(89, 20);
            this.DescriptionLabel.TabIndex = 4;
            this.DescriptionLabel.Text = "Description";
            // 
            // HowToPlayLabel
            // 
            this.HowToPlayLabel.AutoSize = true;
            this.HowToPlayLabel.Location = new System.Drawing.Point(11, 137);
            this.HowToPlayLabel.Name = "HowToPlayLabel";
            this.HowToPlayLabel.Size = new System.Drawing.Size(96, 20);
            this.HowToPlayLabel.TabIndex = 6;
            this.HowToPlayLabel.Text = "How To Play";
            // 
            // DisplayNameLabel
            // 
            this.DisplayNameLabel.AutoSize = true;
            this.DisplayNameLabel.Location = new System.Drawing.Point(120, 9);
            this.DisplayNameLabel.Name = "DisplayNameLabel";
            this.DisplayNameLabel.Size = new System.Drawing.Size(52, 20);
            this.DisplayNameLabel.TabIndex = 1;
            this.DisplayNameLabel.Text = "Durak";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(396, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Zachary Bricknell, Rollington Williams, Roshan Persaud";
            // 
            // DiscriptionDisplayLabel
            // 
            this.DiscriptionDisplayLabel.AutoSize = true;
            this.DiscriptionDisplayLabel.Location = new System.Drawing.Point(121, 84);
            this.DiscriptionDisplayLabel.Name = "DiscriptionDisplayLabel";
            this.DiscriptionDisplayLabel.Size = new System.Drawing.Size(590, 40);
            this.DiscriptionDisplayLabel.TabIndex = 5;
            this.DiscriptionDisplayLabel.Text = "Durham College OOP3 Durak Project - to perform and display various C# concepts \nt" +
    "o output a working adaptation of the card game \"Durak\". ";
            // 
            // HowToPlayDisplayLabel
            // 
            this.HowToPlayDisplayLabel.AutoSize = true;
            this.HowToPlayDisplayLabel.Location = new System.Drawing.Point(120, 137);
            this.HowToPlayDisplayLabel.Name = "HowToPlayDisplayLabel";
            this.HowToPlayDisplayLabel.Size = new System.Drawing.Size(47, 20);
            this.HowToPlayDisplayLabel.TabIndex = 7;
            this.HowToPlayDisplayLabel.Text = "Soon";
            // 
            // ExitButtion
            // 
            this.ExitButtion.Location = new System.Drawing.Point(349, 403);
            this.ExitButtion.Name = "ExitButtion";
            this.ExitButtion.Size = new System.Drawing.Size(114, 35);
            this.ExitButtion.TabIndex = 8;
            this.ExitButtion.Text = "Exit";
            this.ExitButtion.UseVisualStyleBackColor = true;
            this.ExitButtion.Click += new System.EventHandler(this.ExitButtion_Click);
            // 
            // AboutForm
            // 
            this.AcceptButton = this.ExitButtion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButtion;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButtion);
            this.Controls.Add(this.HowToPlayDisplayLabel);
            this.Controls.Add(this.DiscriptionDisplayLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DisplayNameLabel);
            this.Controls.Add(this.HowToPlayLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.AuthorsLabel);
            this.Controls.Add(this.GameNameLabel);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameNameLabel;
        private System.Windows.Forms.Label AuthorsLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label HowToPlayLabel;
        private System.Windows.Forms.Label DisplayNameLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label DiscriptionDisplayLabel;
        private System.Windows.Forms.Label HowToPlayDisplayLabel;
        private System.Windows.Forms.Button ExitButtion;
    }
}