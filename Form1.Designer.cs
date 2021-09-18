namespace WinShutDown
{
    partial class Form1
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
            System.Windows.Forms.Button btnShutdown;
            System.Windows.Forms.Button btnRestart;
            System.Windows.Forms.Button btnSleep;
            this.picture = new System.Windows.Forms.PictureBox();
            this.Temp = new System.Windows.Forms.Label();
            btnShutdown = new System.Windows.Forms.Button();
            btnRestart = new System.Windows.Forms.Button();
            btnSleep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShutdown
            // 
            btnShutdown.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btnShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnShutdown.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnShutdown.Location = new System.Drawing.Point(397, 92);
            btnShutdown.Name = "btnShutdown";
            btnShutdown.Size = new System.Drawing.Size(128, 34);
            btnShutdown.TabIndex = 0;
            btnShutdown.Text = "Shut down";
            btnShutdown.UseCompatibleTextRendering = true;
            btnShutdown.UseVisualStyleBackColor = false;
            btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // btnRestart
            // 
            btnRestart.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnRestart.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRestart.Location = new System.Drawing.Point(397, 161);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new System.Drawing.Size(128, 34);
            btnRestart.TabIndex = 1;
            btnRestart.Text = "Restart";
            btnRestart.UseCompatibleTextRendering = true;
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnSleep
            // 
            btnSleep.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btnSleep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnSleep.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSleep.Location = new System.Drawing.Point(397, 26);
            btnSleep.Name = "btnSleep";
            btnSleep.Size = new System.Drawing.Size(128, 34);
            btnSleep.TabIndex = 2;
            btnSleep.Text = "Sleep";
            btnSleep.UseCompatibleTextRendering = true;
            btnSleep.UseVisualStyleBackColor = false;
            btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // picture
            // 
            this.picture.BackgroundImage = global::WinShutDown.Properties.Resources.E_IhtTOXEAAh1AB;
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture.InitialImage = null;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(360, 240);
            this.picture.TabIndex = 3;
            this.picture.TabStop = false;
            // 
            // Temp
            // 
            this.Temp.AutoSize = true;
            this.Temp.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Temp.Location = new System.Drawing.Point(27, 275);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(86, 20);
            this.Temp.TabIndex = 4;
            this.Temp.Text = "Ititializing...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 326);
            this.Controls.Add(this.Temp);
            this.Controls.Add(this.picture);
            this.Controls.Add(btnSleep);
            this.Controls.Add(btnRestart);
            this.Controls.Add(btnShutdown);
            this.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Shut Down Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label Temp;
    }
}

