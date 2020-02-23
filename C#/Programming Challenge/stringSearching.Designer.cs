namespace Programming_Challenge
{
    partial class stringSearching
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
            this.resetBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.targetString = new System.Windows.Forms.TextBox();
            this.targetLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.searchString = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.outputLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(670, 712);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(421, 86);
            this.resetBtn.TabIndex = 22;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(156, 712);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(421, 86);
            this.submitBtn.TabIndex = 21;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // targetString
            // 
            this.targetString.Location = new System.Drawing.Point(156, 318);
            this.targetString.Name = "targetString";
            this.targetString.Size = new System.Drawing.Size(156, 31);
            this.targetString.TabIndex = 20;
            // 
            // targetLbl
            // 
            this.targetLbl.AutoSize = true;
            this.targetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetLbl.Location = new System.Drawing.Point(146, 240);
            this.targetLbl.Name = "targetLbl";
            this.targetLbl.Size = new System.Drawing.Size(613, 55);
            this.targetLbl.TabIndex = 19;
            this.targetLbl.Text = "Please enter a target string:";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(698, 100);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(356, 55);
            this.titleLbl.TabIndex = 18;
            this.titleLbl.Text = "Order Numbers";
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuBtn.Location = new System.Drawing.Point(670, 920);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(421, 86);
            this.mainMenuBtn.TabIndex = 17;
            this.mainMenuBtn.Text = "Main Menu";
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // searchString
            // 
            this.searchString.Location = new System.Drawing.Point(156, 466);
            this.searchString.Name = "searchString";
            this.searchString.Size = new System.Drawing.Size(156, 31);
            this.searchString.TabIndex = 24;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.Location = new System.Drawing.Point(146, 388);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(635, 55);
            this.searchLbl.TabIndex = 23;
            this.searchLbl.Text = "Please enter a search string:";
            // 
            // outputLbl
            // 
            this.outputLbl.AutoSize = true;
            this.outputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLbl.Location = new System.Drawing.Point(146, 567);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(0, 55);
            this.outputLbl.TabIndex = 25;
            // 
            // stringSearching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1727, 1067);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.searchString);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.targetString);
            this.Controls.Add(this.targetLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.mainMenuBtn);
            this.Name = "stringSearching";
            this.Text = "stringSearching";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox targetString;
        private System.Windows.Forms.Label targetLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.TextBox searchString;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Label outputLbl;
    }
}