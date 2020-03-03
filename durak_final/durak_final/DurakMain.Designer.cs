namespace durak_final
{
    partial class DurakMain
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
            this.ComputerPlayerLabel = new System.Windows.Forms.Label();
            this.ComputerPlayerCardsPannel = new System.Windows.Forms.Panel();
            this.CardsInPlayPannel = new System.Windows.Forms.Panel();
            this.CardsInPlayLabel = new System.Windows.Forms.Label();
            this.PlayerCardsPannel = new System.Windows.Forms.Panel();
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.DeckPannel = new System.Windows.Forms.Panel();
            this.DeckLabel = new System.Windows.Forms.Label();
            this.HeapPannel = new System.Windows.Forms.Panel();
            this.HeapLabel = new System.Windows.Forms.Label();
            this.TrumpLabel = new System.Windows.Forms.Label();
            this.DisplayTrumpLabel = new System.Windows.Forms.Label();
            this.InfoButton = new System.Windows.Forms.Button();
            this.PassButton = new System.Windows.Forms.Button();
            this.ExitButtion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComputerPlayerLabel
            // 
            this.ComputerPlayerLabel.AutoSize = true;
            this.ComputerPlayerLabel.Location = new System.Drawing.Point(14, 78);
            this.ComputerPlayerLabel.Name = "ComputerPlayerLabel";
            this.ComputerPlayerLabel.Size = new System.Drawing.Size(126, 20);
            this.ComputerPlayerLabel.TabIndex = 0;
            this.ComputerPlayerLabel.Text = "Computer Player";
            // 
            // ComputerPlayerCardsPannel
            // 
            this.ComputerPlayerCardsPannel.Location = new System.Drawing.Point(146, 13);
            this.ComputerPlayerCardsPannel.Name = "ComputerPlayerCardsPannel";
            this.ComputerPlayerCardsPannel.Size = new System.Drawing.Size(642, 163);
            this.ComputerPlayerCardsPannel.TabIndex = 1;
            // 
            // CardsInPlayPannel
            // 
            this.CardsInPlayPannel.Location = new System.Drawing.Point(146, 182);
            this.CardsInPlayPannel.Name = "CardsInPlayPannel";
            this.CardsInPlayPannel.Size = new System.Drawing.Size(642, 163);
            this.CardsInPlayPannel.TabIndex = 5;
            // 
            // CardsInPlayLabel
            // 
            this.CardsInPlayLabel.AutoSize = true;
            this.CardsInPlayLabel.Location = new System.Drawing.Point(14, 247);
            this.CardsInPlayLabel.Name = "CardsInPlayLabel";
            this.CardsInPlayLabel.Size = new System.Drawing.Size(102, 20);
            this.CardsInPlayLabel.TabIndex = 4;
            this.CardsInPlayLabel.Text = "Cards In Play";
            // 
            // PlayerCardsPannel
            // 
            this.PlayerCardsPannel.Location = new System.Drawing.Point(146, 351);
            this.PlayerCardsPannel.Name = "PlayerCardsPannel";
            this.PlayerCardsPannel.Size = new System.Drawing.Size(642, 163);
            this.PlayerCardsPannel.TabIndex = 9;
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.AutoSize = true;
            this.PlayerNameLabel.Location = new System.Drawing.Point(14, 416);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(98, 20);
            this.PlayerNameLabel.TabIndex = 8;
            this.PlayerNameLabel.Text = "Player Name";
            // 
            // DeckPannel
            // 
            this.DeckPannel.Location = new System.Drawing.Point(979, 12);
            this.DeckPannel.Name = "DeckPannel";
            this.DeckPannel.Size = new System.Drawing.Size(239, 163);
            this.DeckPannel.TabIndex = 3;
            // 
            // DeckLabel
            // 
            this.DeckLabel.AutoSize = true;
            this.DeckLabel.Location = new System.Drawing.Point(912, 78);
            this.DeckLabel.Name = "DeckLabel";
            this.DeckLabel.Size = new System.Drawing.Size(46, 20);
            this.DeckLabel.TabIndex = 2;
            this.DeckLabel.Text = "Deck";
            // 
            // HeapPannel
            // 
            this.HeapPannel.Location = new System.Drawing.Point(979, 351);
            this.HeapPannel.Name = "HeapPannel";
            this.HeapPannel.Size = new System.Drawing.Size(239, 163);
            this.HeapPannel.TabIndex = 11;
            // 
            // HeapLabel
            // 
            this.HeapLabel.AutoSize = true;
            this.HeapLabel.Location = new System.Drawing.Point(910, 416);
            this.HeapLabel.Name = "HeapLabel";
            this.HeapLabel.Size = new System.Drawing.Size(48, 20);
            this.HeapLabel.TabIndex = 10;
            this.HeapLabel.Text = "Heap";
            // 
            // TrumpLabel
            // 
            this.TrumpLabel.AutoSize = true;
            this.TrumpLabel.Location = new System.Drawing.Point(847, 247);
            this.TrumpLabel.Name = "TrumpLabel";
            this.TrumpLabel.Size = new System.Drawing.Size(111, 20);
            this.TrumpLabel.TabIndex = 6;
            this.TrumpLabel.Text = "Current Trump";
            // 
            // DisplayTrumpLabel
            // 
            this.DisplayTrumpLabel.AutoSize = true;
            this.DisplayTrumpLabel.Location = new System.Drawing.Point(975, 247);
            this.DisplayTrumpLabel.Name = "DisplayTrumpLabel";
            this.DisplayTrumpLabel.Size = new System.Drawing.Size(109, 20);
            this.DisplayTrumpLabel.TabIndex = 7;
            this.DisplayTrumpLabel.Text = "Display Trump";
            // 
            // InfoButton
            // 
            this.InfoButton.Location = new System.Drawing.Point(146, 531);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(114, 35);
            this.InfoButton.TabIndex = 12;
            this.InfoButton.Text = "Info";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // PassButton
            // 
            this.PassButton.Location = new System.Drawing.Point(580, 531);
            this.PassButton.Name = "PassButton";
            this.PassButton.Size = new System.Drawing.Size(114, 35);
            this.PassButton.TabIndex = 13;
            this.PassButton.Text = "Pass";
            this.PassButton.UseVisualStyleBackColor = true;
            // 
            // ExitButtion
            // 
            this.ExitButtion.Location = new System.Drawing.Point(979, 531);
            this.ExitButtion.Name = "ExitButtion";
            this.ExitButtion.Size = new System.Drawing.Size(114, 35);
            this.ExitButtion.TabIndex = 14;
            this.ExitButtion.Text = "Exit";
            this.ExitButtion.UseVisualStyleBackColor = true;
            this.ExitButtion.Click += new System.EventHandler(this.ExitButtion_Click);
            // 
            // DurakMain
            // 
            this.AcceptButton = this.InfoButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButtion;
            this.ClientSize = new System.Drawing.Size(1230, 578);
            this.Controls.Add(this.ExitButtion);
            this.Controls.Add(this.PassButton);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.DisplayTrumpLabel);
            this.Controls.Add(this.TrumpLabel);
            this.Controls.Add(this.HeapPannel);
            this.Controls.Add(this.HeapLabel);
            this.Controls.Add(this.DeckPannel);
            this.Controls.Add(this.DeckLabel);
            this.Controls.Add(this.PlayerCardsPannel);
            this.Controls.Add(this.PlayerNameLabel);
            this.Controls.Add(this.CardsInPlayPannel);
            this.Controls.Add(this.CardsInPlayLabel);
            this.Controls.Add(this.ComputerPlayerCardsPannel);
            this.Controls.Add(this.ComputerPlayerLabel);
            this.Name = "DurakMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durak";
            this.Load += new System.EventHandler(this.Cards_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ComputerPlayerLabel;
        private System.Windows.Forms.Panel ComputerPlayerCardsPannel;
        private System.Windows.Forms.Panel CardsInPlayPannel;
        private System.Windows.Forms.Label CardsInPlayLabel;
        private System.Windows.Forms.Panel PlayerCardsPannel;
        private System.Windows.Forms.Label PlayerNameLabel;
        private System.Windows.Forms.Panel DeckPannel;
        private System.Windows.Forms.Label DeckLabel;
        private System.Windows.Forms.Panel HeapPannel;
        private System.Windows.Forms.Label HeapLabel;
        private System.Windows.Forms.Label TrumpLabel;
        private System.Windows.Forms.Label DisplayTrumpLabel;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Button PassButton;
        private System.Windows.Forms.Button ExitButtion;
    }
}

