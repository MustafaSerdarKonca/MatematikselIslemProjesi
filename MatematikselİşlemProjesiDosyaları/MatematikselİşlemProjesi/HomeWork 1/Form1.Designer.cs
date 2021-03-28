namespace HomeWork_1
{
    partial class Calculater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculater));
            this.grbBoxOne = new System.Windows.Forms.GroupBox();
            this.bakircayLogo = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblFinish = new System.Windows.Forms.Label();
            this.mskTxtBoxFinish = new System.Windows.Forms.MaskedTextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.mskTxtBoxStart = new System.Windows.Forms.MaskedTextBox();
            this.allTabs = new System.Windows.Forms.TabControl();
            this.tbPgOddNbs = new System.Windows.Forms.TabPage();
            this.lvMultiplicationOdd = new System.Windows.Forms.ListView();
            this.lvTotalOdd = new System.Windows.Forms.ListView();
            this.lvNumbersOdd = new System.Windows.Forms.ListView();
            this.tbPgEvenNbs = new System.Windows.Forms.TabPage();
            this.lvMultiplicationEven = new System.Windows.Forms.ListView();
            this.lvTotalEven = new System.Windows.Forms.ListView();
            this.lvNumbersEven = new System.Windows.Forms.ListView();
            this.tbPgPrimeNbs = new System.Windows.Forms.TabPage();
            this.lvMultiplicationPrime = new System.Windows.Forms.ListView();
            this.lvTotalPrime = new System.Windows.Forms.ListView();
            this.lvNumberPrime = new System.Windows.Forms.ListView();
            this.tbPgArmstrongNbs = new System.Windows.Forms.TabPage();
            this.lvMultiplitionArmstrong = new System.Windows.Forms.ListView();
            this.lvTotalArmstrong = new System.Windows.Forms.ListView();
            this.lvNumbersArmstrong = new System.Windows.Forms.ListView();
            this.notificationOne = new System.Windows.Forms.NotifyIcon(this.components);
            this.smallIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.wiewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbBoxOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bakircayLogo)).BeginInit();
            this.allTabs.SuspendLayout();
            this.tbPgOddNbs.SuspendLayout();
            this.tbPgEvenNbs.SuspendLayout();
            this.tbPgPrimeNbs.SuspendLayout();
            this.tbPgArmstrongNbs.SuspendLayout();
            this.smallIconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBoxOne
            // 
            this.grbBoxOne.Controls.Add(this.bakircayLogo);
            this.grbBoxOne.Controls.Add(this.btnBack);
            this.grbBoxOne.Controls.Add(this.btnForward);
            this.grbBoxOne.Controls.Add(this.btnCalculate);
            this.grbBoxOne.Controls.Add(this.lblFinish);
            this.grbBoxOne.Controls.Add(this.mskTxtBoxFinish);
            this.grbBoxOne.Controls.Add(this.lblStart);
            this.grbBoxOne.Controls.Add(this.mskTxtBoxStart);
            this.grbBoxOne.Location = new System.Drawing.Point(22, 24);
            this.grbBoxOne.Name = "grbBoxOne";
            this.grbBoxOne.Size = new System.Drawing.Size(747, 87);
            this.grbBoxOne.TabIndex = 0;
            this.grbBoxOne.TabStop = false;
            this.grbBoxOne.Text = "Login Information";
            // 
            // bakircayLogo
            // 
            this.bakircayLogo.Image = global::HomeWork_1.Properties.Resources.BakircayLogo;
            this.bakircayLogo.Location = new System.Drawing.Point(22, 19);
            this.bakircayLogo.Name = "bakircayLogo";
            this.bakircayLogo.Size = new System.Drawing.Size(52, 52);
            this.bakircayLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bakircayLogo.TabIndex = 7;
            this.bakircayLogo.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(564, 34);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 25);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "<<Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnForward.Location = new System.Drawing.Point(645, 34);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(75, 25);
            this.btnForward.TabIndex = 5;
            this.btnForward.Text = "Forward>>";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalculate.Location = new System.Drawing.Point(445, 34);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Location = new System.Drawing.Point(261, 42);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(34, 13);
            this.lblFinish.TabIndex = 3;
            this.lblFinish.Text = "Finish";
            // 
            // mskTxtBoxFinish
            // 
            this.mskTxtBoxFinish.Location = new System.Drawing.Point(302, 39);
            this.mskTxtBoxFinish.Mask = "00000";
            this.mskTxtBoxFinish.Name = "mskTxtBoxFinish";
            this.mskTxtBoxFinish.Size = new System.Drawing.Size(100, 20);
            this.mskTxtBoxFinish.TabIndex = 2;
            this.mskTxtBoxFinish.Text = "10000";
            this.mskTxtBoxFinish.ValidatingType = typeof(int);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(94, 39);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(29, 13);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Start";
            // 
            // mskTxtBoxStart
            // 
            this.mskTxtBoxStart.Location = new System.Drawing.Point(135, 36);
            this.mskTxtBoxStart.Mask = "00000";
            this.mskTxtBoxStart.Name = "mskTxtBoxStart";
            this.mskTxtBoxStart.Size = new System.Drawing.Size(100, 20);
            this.mskTxtBoxStart.TabIndex = 0;
            this.mskTxtBoxStart.Text = "1";
            this.mskTxtBoxStart.ValidatingType = typeof(int);
            // 
            // allTabs
            // 
            this.allTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allTabs.Controls.Add(this.tbPgOddNbs);
            this.allTabs.Controls.Add(this.tbPgEvenNbs);
            this.allTabs.Controls.Add(this.tbPgPrimeNbs);
            this.allTabs.Controls.Add(this.tbPgArmstrongNbs);
            this.allTabs.Location = new System.Drawing.Point(22, 117);
            this.allTabs.Name = "allTabs";
            this.allTabs.SelectedIndex = 0;
            this.allTabs.Size = new System.Drawing.Size(747, 321);
            this.allTabs.TabIndex = 1;
            // 
            // tbPgOddNbs
            // 
            this.tbPgOddNbs.Controls.Add(this.lvMultiplicationOdd);
            this.tbPgOddNbs.Controls.Add(this.lvTotalOdd);
            this.tbPgOddNbs.Controls.Add(this.lvNumbersOdd);
            this.tbPgOddNbs.Location = new System.Drawing.Point(4, 22);
            this.tbPgOddNbs.Name = "tbPgOddNbs";
            this.tbPgOddNbs.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgOddNbs.Size = new System.Drawing.Size(739, 295);
            this.tbPgOddNbs.TabIndex = 0;
            this.tbPgOddNbs.Text = "Odd Numbers";
            this.tbPgOddNbs.UseVisualStyleBackColor = true;
            // 
            // lvMultiplicationOdd
            // 
            this.lvMultiplicationOdd.HideSelection = false;
            this.lvMultiplicationOdd.Location = new System.Drawing.Point(-4, 256);
            this.lvMultiplicationOdd.Name = "lvMultiplicationOdd";
            this.lvMultiplicationOdd.Size = new System.Drawing.Size(747, 41);
            this.lvMultiplicationOdd.TabIndex = 5;
            this.lvMultiplicationOdd.UseCompatibleStateImageBehavior = false;
            this.lvMultiplicationOdd.View = System.Windows.Forms.View.SmallIcon;
            // 
            // lvTotalOdd
            // 
            this.lvTotalOdd.HideSelection = false;
            this.lvTotalOdd.Location = new System.Drawing.Point(-4, 213);
            this.lvTotalOdd.Name = "lvTotalOdd";
            this.lvTotalOdd.Size = new System.Drawing.Size(747, 47);
            this.lvTotalOdd.TabIndex = 4;
            this.lvTotalOdd.UseCompatibleStateImageBehavior = false;
            this.lvTotalOdd.View = System.Windows.Forms.View.SmallIcon;
            // 
            // lvNumbersOdd
            // 
            this.lvNumbersOdd.HideSelection = false;
            this.lvNumbersOdd.Location = new System.Drawing.Point(0, 0);
            this.lvNumbersOdd.Name = "lvNumbersOdd";
            this.lvNumbersOdd.Size = new System.Drawing.Size(747, 218);
            this.lvNumbersOdd.TabIndex = 3;
            this.lvNumbersOdd.UseCompatibleStateImageBehavior = false;
            this.lvNumbersOdd.View = System.Windows.Forms.View.List;
            // 
            // tbPgEvenNbs
            // 
            this.tbPgEvenNbs.Controls.Add(this.lvMultiplicationEven);
            this.tbPgEvenNbs.Controls.Add(this.lvTotalEven);
            this.tbPgEvenNbs.Controls.Add(this.lvNumbersEven);
            this.tbPgEvenNbs.Location = new System.Drawing.Point(4, 22);
            this.tbPgEvenNbs.Name = "tbPgEvenNbs";
            this.tbPgEvenNbs.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgEvenNbs.Size = new System.Drawing.Size(739, 295);
            this.tbPgEvenNbs.TabIndex = 1;
            this.tbPgEvenNbs.Text = "Even Numbers";
            this.tbPgEvenNbs.UseVisualStyleBackColor = true;
            // 
            // lvMultiplicationEven
            // 
            this.lvMultiplicationEven.HideSelection = false;
            this.lvMultiplicationEven.Location = new System.Drawing.Point(-4, 256);
            this.lvMultiplicationEven.Name = "lvMultiplicationEven";
            this.lvMultiplicationEven.Size = new System.Drawing.Size(747, 41);
            this.lvMultiplicationEven.TabIndex = 5;
            this.lvMultiplicationEven.UseCompatibleStateImageBehavior = false;
            this.lvMultiplicationEven.View = System.Windows.Forms.View.SmallIcon;
            // 
            // lvTotalEven
            // 
            this.lvTotalEven.HideSelection = false;
            this.lvTotalEven.Location = new System.Drawing.Point(-4, 213);
            this.lvTotalEven.Name = "lvTotalEven";
            this.lvTotalEven.Size = new System.Drawing.Size(747, 47);
            this.lvTotalEven.TabIndex = 4;
            this.lvTotalEven.UseCompatibleStateImageBehavior = false;
            this.lvTotalEven.View = System.Windows.Forms.View.SmallIcon;
            // 
            // lvNumbersEven
            // 
            this.lvNumbersEven.HideSelection = false;
            this.lvNumbersEven.Location = new System.Drawing.Point(-4, -2);
            this.lvNumbersEven.Name = "lvNumbersEven";
            this.lvNumbersEven.Size = new System.Drawing.Size(747, 218);
            this.lvNumbersEven.TabIndex = 3;
            this.lvNumbersEven.UseCompatibleStateImageBehavior = false;
            this.lvNumbersEven.View = System.Windows.Forms.View.List;
            // 
            // tbPgPrimeNbs
            // 
            this.tbPgPrimeNbs.Controls.Add(this.lvMultiplicationPrime);
            this.tbPgPrimeNbs.Controls.Add(this.lvTotalPrime);
            this.tbPgPrimeNbs.Controls.Add(this.lvNumberPrime);
            this.tbPgPrimeNbs.Location = new System.Drawing.Point(4, 22);
            this.tbPgPrimeNbs.Name = "tbPgPrimeNbs";
            this.tbPgPrimeNbs.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgPrimeNbs.Size = new System.Drawing.Size(739, 295);
            this.tbPgPrimeNbs.TabIndex = 2;
            this.tbPgPrimeNbs.Text = "Prime Numbers";
            this.tbPgPrimeNbs.UseVisualStyleBackColor = true;
            // 
            // lvMultiplicationPrime
            // 
            this.lvMultiplicationPrime.HideSelection = false;
            this.lvMultiplicationPrime.Location = new System.Drawing.Point(-4, 244);
            this.lvMultiplicationPrime.Name = "lvMultiplicationPrime";
            this.lvMultiplicationPrime.Size = new System.Drawing.Size(747, 53);
            this.lvMultiplicationPrime.TabIndex = 5;
            this.lvMultiplicationPrime.UseCompatibleStateImageBehavior = false;
            this.lvMultiplicationPrime.View = System.Windows.Forms.View.SmallIcon;
            // 
            // lvTotalPrime
            // 
            this.lvTotalPrime.HideSelection = false;
            this.lvTotalPrime.Location = new System.Drawing.Point(-4, 204);
            this.lvTotalPrime.Name = "lvTotalPrime";
            this.lvTotalPrime.Size = new System.Drawing.Size(747, 46);
            this.lvTotalPrime.TabIndex = 4;
            this.lvTotalPrime.UseCompatibleStateImageBehavior = false;
            this.lvTotalPrime.View = System.Windows.Forms.View.SmallIcon;
            // 
            // lvNumberPrime
            // 
            this.lvNumberPrime.HideSelection = false;
            this.lvNumberPrime.Location = new System.Drawing.Point(-4, -2);
            this.lvNumberPrime.Name = "lvNumberPrime";
            this.lvNumberPrime.Size = new System.Drawing.Size(747, 218);
            this.lvNumberPrime.TabIndex = 3;
            this.lvNumberPrime.UseCompatibleStateImageBehavior = false;
            this.lvNumberPrime.View = System.Windows.Forms.View.List;
            // 
            // tbPgArmstrongNbs
            // 
            this.tbPgArmstrongNbs.Controls.Add(this.lvMultiplitionArmstrong);
            this.tbPgArmstrongNbs.Controls.Add(this.lvTotalArmstrong);
            this.tbPgArmstrongNbs.Controls.Add(this.lvNumbersArmstrong);
            this.tbPgArmstrongNbs.Location = new System.Drawing.Point(4, 22);
            this.tbPgArmstrongNbs.Name = "tbPgArmstrongNbs";
            this.tbPgArmstrongNbs.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgArmstrongNbs.Size = new System.Drawing.Size(739, 295);
            this.tbPgArmstrongNbs.TabIndex = 3;
            this.tbPgArmstrongNbs.Text = "Armstrong Numbers";
            this.tbPgArmstrongNbs.UseVisualStyleBackColor = true;
            // 
            // lvMultiplitionArmstrong
            // 
            this.lvMultiplitionArmstrong.HideSelection = false;
            this.lvMultiplitionArmstrong.Location = new System.Drawing.Point(-4, 258);
            this.lvMultiplitionArmstrong.Name = "lvMultiplitionArmstrong";
            this.lvMultiplitionArmstrong.Size = new System.Drawing.Size(747, 41);
            this.lvMultiplitionArmstrong.TabIndex = 2;
            this.lvMultiplitionArmstrong.UseCompatibleStateImageBehavior = false;
            this.lvMultiplitionArmstrong.View = System.Windows.Forms.View.SmallIcon;
            // 
            // lvTotalArmstrong
            // 
            this.lvTotalArmstrong.HideSelection = false;
            this.lvTotalArmstrong.Location = new System.Drawing.Point(-4, 215);
            this.lvTotalArmstrong.Name = "lvTotalArmstrong";
            this.lvTotalArmstrong.Size = new System.Drawing.Size(747, 47);
            this.lvTotalArmstrong.TabIndex = 1;
            this.lvTotalArmstrong.UseCompatibleStateImageBehavior = false;
            this.lvTotalArmstrong.View = System.Windows.Forms.View.SmallIcon;
            // 
            // lvNumbersArmstrong
            // 
            this.lvNumbersArmstrong.HideSelection = false;
            this.lvNumbersArmstrong.Location = new System.Drawing.Point(-4, 0);
            this.lvNumbersArmstrong.Name = "lvNumbersArmstrong";
            this.lvNumbersArmstrong.Size = new System.Drawing.Size(747, 218);
            this.lvNumbersArmstrong.TabIndex = 0;
            this.lvNumbersArmstrong.UseCompatibleStateImageBehavior = false;
            this.lvNumbersArmstrong.View = System.Windows.Forms.View.List;
            // 
            // notificationOne
            // 
            this.notificationOne.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notificationOne.ContextMenuStrip = this.smallIconMenu;
            this.notificationOne.Icon = ((System.Drawing.Icon)(resources.GetObject("notificationOne.Icon")));
            this.notificationOne.Text = "Calculator";
            this.notificationOne.Visible = true;
            // 
            // smallIconMenu
            // 
            this.smallIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wiewToolStripMenuItem,
            this.hideToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.smallIconMenu.Name = "smallIconMenu";
            this.smallIconMenu.Size = new System.Drawing.Size(104, 70);
            // 
            // wiewToolStripMenuItem
            // 
            this.wiewToolStripMenuItem.Name = "wiewToolStripMenuItem";
            this.wiewToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.wiewToolStripMenuItem.Text = "Show";
            this.wiewToolStripMenuItem.Click += new System.EventHandler(this.wiewToolStripMenuItem_Click);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Close";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Calculater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.allTabs);
            this.Controls.Add(this.grbBoxOne);
            this.Name = "Calculater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculater";
            this.Load += new System.EventHandler(this.Calculater_Load);
            this.Shown += new System.EventHandler(this.Calculater_Shown);
            this.grbBoxOne.ResumeLayout(false);
            this.grbBoxOne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bakircayLogo)).EndInit();
            this.allTabs.ResumeLayout(false);
            this.tbPgOddNbs.ResumeLayout(false);
            this.tbPgEvenNbs.ResumeLayout(false);
            this.tbPgPrimeNbs.ResumeLayout(false);
            this.tbPgArmstrongNbs.ResumeLayout(false);
            this.smallIconMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBoxOne;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxFinish;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxStart;
        private System.Windows.Forms.TabControl allTabs;
        private System.Windows.Forms.TabPage tbPgOddNbs;
        private System.Windows.Forms.TabPage tbPgEvenNbs;
        private System.Windows.Forms.TabPage tbPgPrimeNbs;
        private System.Windows.Forms.TabPage tbPgArmstrongNbs;
        private System.Windows.Forms.ListView lvNumbersArmstrong;
        private System.Windows.Forms.ListView lvTotalArmstrong;
        private System.Windows.Forms.ListView lvMultiplitionArmstrong;
        private System.Windows.Forms.ListView lvMultiplicationOdd;
        private System.Windows.Forms.ListView lvTotalOdd;
        private System.Windows.Forms.ListView lvNumbersOdd;
        private System.Windows.Forms.ListView lvMultiplicationEven;
        private System.Windows.Forms.ListView lvTotalEven;
        private System.Windows.Forms.ListView lvNumbersEven;
        private System.Windows.Forms.ListView lvMultiplicationPrime;
        private System.Windows.Forms.ListView lvTotalPrime;
        private System.Windows.Forms.ListView lvNumberPrime;
        private System.Windows.Forms.NotifyIcon notificationOne;
        private System.Windows.Forms.ContextMenuStrip smallIconMenu;
        private System.Windows.Forms.ToolStripMenuItem wiewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox bakircayLogo;
    }
}

