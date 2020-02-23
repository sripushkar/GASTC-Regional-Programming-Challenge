namespace Programming_Challenge
{
    partial class orderNumbers
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
            this.orderNumbersLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.promptLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderNumbersLbl
            // 
            this.orderNumbersLbl.AutoSize = true;
            this.orderNumbersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNumbersLbl.Location = new System.Drawing.Point(201, 512);
            this.orderNumbersLbl.Name = "orderNumbersLbl";
            this.orderNumbersLbl.Size = new System.Drawing.Size(0, 55);
            this.orderNumbersLbl.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 14;
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(211, 379);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(421, 86);
            this.submitBtn.TabIndex = 13;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(211, 277);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(156, 31);
            this.numberInput.TabIndex = 12;
            // 
            // promptLbl
            // 
            this.promptLbl.AutoSize = true;
            this.promptLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLbl.Location = new System.Drawing.Point(201, 199);
            this.promptLbl.Name = "promptLbl";
            this.promptLbl.Size = new System.Drawing.Size(879, 55);
            this.promptLbl.TabIndex = 11;
            this.promptLbl.Text = "Please Enter a Number(enter 0 to reset)";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(753, 59);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(356, 55);
            this.titleLbl.TabIndex = 10;
            this.titleLbl.Text = "Order Numbers";
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuBtn.Location = new System.Drawing.Point(725, 702);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(421, 86);
            this.mainMenuBtn.TabIndex = 9;
            this.mainMenuBtn.Text = "Main Menu";
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(725, 379);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(421, 86);
            this.resetBtn.TabIndex = 16;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // orderNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1698, 992);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.orderNumbersLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.promptLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.mainMenuBtn);
            this.Name = "orderNumbers";
            this.Text = "orderNumbers";
            this.Load += new System.EventHandler(this.orderNumbers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderNumbersLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.Label promptLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Button resetBtn;
    }
}