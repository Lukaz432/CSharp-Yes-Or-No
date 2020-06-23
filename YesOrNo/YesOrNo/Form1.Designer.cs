namespace YesOrNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picYes = new System.Windows.Forms.PictureBox();
            this.picNo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.yesBtn = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.notSureBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNo)).BeginInit();
            this.SuspendLayout();
            // 
            // picYes
            // 
            this.picYes.Image = ((System.Drawing.Image)(resources.GetObject("picYes.Image")));
            this.picYes.Location = new System.Drawing.Point(80, 72);
            this.picYes.Name = "picYes";
            this.picYes.Size = new System.Drawing.Size(77, 41);
            this.picYes.TabIndex = 0;
            this.picYes.TabStop = false;
            // 
            // picNo
            // 
            this.picNo.Image = ((System.Drawing.Image)(resources.GetObject("picNo.Image")));
            this.picNo.Location = new System.Drawing.Point(301, 72);
            this.picNo.Name = "picNo";
            this.picNo.Size = new System.Drawing.Size(77, 41);
            this.picNo.TabIndex = 1;
            this.picNo.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Leave";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yesBtn
            // 
            this.yesBtn.Location = new System.Drawing.Point(37, 232);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(75, 23);
            this.yesBtn.TabIndex = 3;
            this.yesBtn.Text = "Show Yes";
            this.yesBtn.UseVisualStyleBackColor = true;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.Location = new System.Drawing.Point(136, 232);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(75, 23);
            this.noBtn.TabIndex = 4;
            this.noBtn.Text = "Show No";
            this.noBtn.UseVisualStyleBackColor = true;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // notSureBtn
            // 
            this.notSureBtn.Location = new System.Drawing.Point(238, 232);
            this.notSureBtn.Name = "notSureBtn";
            this.notSureBtn.Size = new System.Drawing.Size(75, 23);
            this.notSureBtn.TabIndex = 5;
            this.notSureBtn.Text = "Not Sure";
            this.notSureBtn.UseVisualStyleBackColor = true;
            this.notSureBtn.Click += new System.EventHandler(this.notSureBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 302);
            this.Controls.Add(this.notSureBtn);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picNo);
            this.Controls.Add(this.picYes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picYes;
        private System.Windows.Forms.PictureBox picNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.Button notSureBtn;
    }
}

