namespace UltimateQuiz_v0._2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonGeo = new System.Windows.Forms.Button();
            this.buttonMath = new System.Windows.Forms.Button();
            this.buttonVideoGames = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonToUsersManager = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxUsersMainForm = new System.Windows.Forms.ListBox();
            this.labelUsersList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(149, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a quiz";
            // 
            // buttonHistory
            // 
            this.buttonHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonHistory.BackColor = System.Drawing.Color.Gray;
            this.buttonHistory.Location = new System.Drawing.Point(29, 328);
            this.buttonHistory.Margin = new System.Windows.Forms.Padding(20);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(148, 101);
            this.buttonHistory.TabIndex = 2;
            this.buttonHistory.Text = "History \r\n(Coming soon!) ";
            this.buttonHistory.UseVisualStyleBackColor = false;
            // 
            // buttonGeo
            // 
            this.buttonGeo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonGeo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGeo.BackColor = System.Drawing.Color.Gray;
            this.buttonGeo.Location = new System.Drawing.Point(307, 328);
            this.buttonGeo.Margin = new System.Windows.Forms.Padding(20);
            this.buttonGeo.Name = "buttonGeo";
            this.buttonGeo.Size = new System.Drawing.Size(148, 101);
            this.buttonGeo.TabIndex = 2;
            this.buttonGeo.Text = "Geography\r\n(Coming soon!) ";
            this.buttonGeo.UseVisualStyleBackColor = false;
            // 
            // buttonMath
            // 
            this.buttonMath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonMath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMath.BackColor = System.Drawing.Color.Gray;
            this.buttonMath.Location = new System.Drawing.Point(29, 481);
            this.buttonMath.Margin = new System.Windows.Forms.Padding(20);
            this.buttonMath.Name = "buttonMath";
            this.buttonMath.Size = new System.Drawing.Size(148, 101);
            this.buttonMath.TabIndex = 2;
            this.buttonMath.Text = "Math\r\n(Coming soon!) ";
            this.buttonMath.UseVisualStyleBackColor = false;
            // 
            // buttonVideoGames
            // 
            this.buttonVideoGames.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonVideoGames.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonVideoGames.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonVideoGames.Location = new System.Drawing.Point(307, 481);
            this.buttonVideoGames.Margin = new System.Windows.Forms.Padding(20);
            this.buttonVideoGames.Name = "buttonVideoGames";
            this.buttonVideoGames.Size = new System.Drawing.Size(148, 101);
            this.buttonVideoGames.TabIndex = 2;
            this.buttonVideoGames.Text = "Video Games";
            this.buttonVideoGames.UseVisualStyleBackColor = false;
            this.buttonVideoGames.Click += new System.EventHandler(this.buttonVideoGames_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(151, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "More topics will be added in future versions! Well... Maybe..?\r\n";
            // 
            // buttonToUsersManager
            // 
            this.buttonToUsersManager.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonToUsersManager.Location = new System.Drawing.Point(342, 140);
            this.buttonToUsersManager.Name = "buttonToUsersManager";
            this.buttonToUsersManager.Size = new System.Drawing.Size(130, 48);
            this.buttonToUsersManager.TabIndex = 6;
            this.buttonToUsersManager.Text = "Users";
            this.buttonToUsersManager.UseVisualStyleBackColor = false;
            this.buttonToUsersManager.Click += new System.EventHandler(this.buttonToUsersManager_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "I would recommend you \r\nto create a user before you start =>\r\n";
            // 
            // listBoxUsersMainForm
            // 
            this.listBoxUsersMainForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxUsersMainForm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxUsersMainForm.FormattingEnabled = true;
            this.listBoxUsersMainForm.ItemHeight = 19;
            this.listBoxUsersMainForm.Location = new System.Drawing.Point(12, 227);
            this.listBoxUsersMainForm.Name = "listBoxUsersMainForm";
            this.listBoxUsersMainForm.Size = new System.Drawing.Size(460, 78);
            this.listBoxUsersMainForm.TabIndex = 7;
            // 
            // labelUsersList
            // 
            this.labelUsersList.AutoSize = true;
            this.labelUsersList.BackColor = System.Drawing.Color.White;
            this.labelUsersList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelUsersList.Location = new System.Drawing.Point(12, 199);
            this.labelUsersList.Name = "labelUsersList";
            this.labelUsersList.Size = new System.Drawing.Size(64, 25);
            this.labelUsersList.TabIndex = 8;
            this.labelUsersList.Text = "Users:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.labelUsersList);
            this.Controls.Add(this.listBoxUsersMainForm);
            this.Controls.Add(this.buttonToUsersManager);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonVideoGames);
            this.Controls.Add(this.buttonGeo);
            this.Controls.Add(this.buttonMath);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(500, 650);
            this.MinimumSize = new System.Drawing.Size(500, 650);
            this.Name = "MainForm";
            this.Text = "Ultimate Quiz v0.2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonGeo;
        private System.Windows.Forms.Button buttonMath;
        private System.Windows.Forms.Button buttonVideoGames;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonToUsersManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxUsersMainForm;
        private System.Windows.Forms.Label labelUsersList;
    }
}

