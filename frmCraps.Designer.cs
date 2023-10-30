namespace CS311_Project2_DCC
{
    partial class Craps
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDie1 = new Label();
            lblDie2 = new Label();
            txtBet = new TextBox();
            lblBankBalance = new Label();
            lblResult = new Label();
            btnRoll = new Button();
            btnReset = new Button();
            lblBetStatus = new Label();
            lblRound = new Label();
            btnRules = new Button();
            SuspendLayout();
            // 
            // lblDie1
            // 
            lblDie1.AccessibleRole = AccessibleRole.None;
            lblDie1.BackColor = Color.DarkRed;
            lblDie1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblDie1.ForeColor = SystemColors.HighlightText;
            lblDie1.Location = new Point(134, 162);
            lblDie1.Name = "lblDie1";
            lblDie1.Size = new Size(90, 90);
            lblDie1.TabIndex = 0;
            lblDie1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDie2
            // 
            lblDie2.AccessibleRole = AccessibleRole.None;
            lblDie2.BackColor = Color.Navy;
            lblDie2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblDie2.ForeColor = SystemColors.HighlightText;
            lblDie2.Location = new Point(268, 162);
            lblDie2.Name = "lblDie2";
            lblDie2.Size = new Size(90, 90);
            lblDie2.TabIndex = 1;
            lblDie2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBet
            // 
            txtBet.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBet.Location = new Point(36, 62);
            txtBet.Name = "txtBet";
            txtBet.PlaceholderText = "Enter your bet";
            txtBet.Size = new Size(211, 33);
            txtBet.TabIndex = 2;
            // 
            // lblBankBalance
            // 
            lblBankBalance.AutoSize = true;
            lblBankBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBankBalance.Location = new Point(32, 30);
            lblBankBalance.Name = "lblBankBalance";
            lblBankBalance.Size = new Size(211, 25);
            lblBankBalance.TabIndex = 3;
            lblBankBalance.Text = "Bank Balance: $100.00";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblResult.Location = new Point(36, 269);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(38, 37);
            lblResult.TabIndex = 4;
            lblResult.Text = "   ";
            lblResult.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnRoll
            // 
            btnRoll.BackColor = SystemColors.ControlLight;
            btnRoll.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRoll.Location = new Point(306, 37);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(149, 67);
            btnRoll.TabIndex = 5;
            btnRoll.Text = "Roll!";
            btnRoll.UseVisualStyleBackColor = false;
            btnRoll.Click += btnRoll_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(200, 325);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(89, 29);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset Game";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblBetStatus
            // 
            lblBetStatus.AutoSize = true;
            lblBetStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblBetStatus.Location = new Point(36, 105);
            lblBetStatus.Name = "lblBetStatus";
            lblBetStatus.Size = new Size(32, 25);
            lblBetStatus.TabIndex = 7;
            lblBetStatus.Text = "    ";
            lblBetStatus.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblRound
            // 
            lblRound.AutoSize = true;
            lblRound.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRound.ForeColor = SystemColors.HotTrack;
            lblRound.Location = new Point(36, 328);
            lblRound.Name = "lblRound";
            lblRound.Size = new Size(77, 21);
            lblRound.TabIndex = 8;
            lblRound.Text = " Round 1";
            lblRound.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnRules
            // 
            btnRules.BackColor = SystemColors.ButtonHighlight;
            btnRules.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRules.Location = new Point(356, 328);
            btnRules.Name = "btnRules";
            btnRules.Size = new Size(99, 26);
            btnRules.TabIndex = 9;
            btnRules.Text = "Game Rules";
            btnRules.UseVisualStyleBackColor = false;
            btnRules.Click += btnRules_Click;
            // 
            // Craps
            // 
            AcceptButton = btnRoll;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(529, 379);
            Controls.Add(btnRules);
            Controls.Add(lblRound);
            Controls.Add(lblBetStatus);
            Controls.Add(btnReset);
            Controls.Add(btnRoll);
            Controls.Add(lblResult);
            Controls.Add(lblBankBalance);
            Controls.Add(txtBet);
            Controls.Add(lblDie2);
            Controls.Add(lblDie1);
            Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Craps";
            Text = "Craps";
            Load += Craps_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDie1;
        private Label lblDie2;
        private TextBox txtBet;
        private Label lblBankBalance;
        private Label lblResult;
        private Button btnRoll;
        private Button btnReset;
        private Label lblBetStatus;
        private Label lblRound;
        private Button btnRules;
    }
}