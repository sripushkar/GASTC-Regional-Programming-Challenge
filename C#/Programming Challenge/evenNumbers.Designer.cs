namespace Programming_Challenge
{
    partial class evenNumbers
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
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.promptLbl = new System.Windows.Forms.Label();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.evenNumbersLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuBtn.Location = new System.Drawing.Point(638, 729);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(421, 86);
            this.mainMenuBtn.TabIndex = 2;
            this.mainMenuBtn.Text = "Main Menu";
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(666, 86);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(343, 55);
            this.titleLbl.TabIndex = 3;
            this.titleLbl.Text = "Even Numbers";
            // 
            // promptLbl
            // 
            this.promptLbl.AutoSize = true;
            this.promptLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLbl.Location = new System.Drawing.Point(114, 226);
            this.promptLbl.Name = "promptLbl";
            this.promptLbl.Size = new System.Drawing.Size(524, 55);
            this.promptLbl.TabIndex = 4;
            this.promptLbl.Text = "Please Enter a Number";
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(124, 304);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(156, 31);
            this.numberInput.TabIndex = 5;
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(124, 406);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(421, 86);
            this.submitBtn.TabIndex = 6;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 563);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 7;
            // 
            // evenNumbersLbl
            // 
            this.evenNumbersLbl.AutoSize = true;
            this.evenNumbersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evenNumbersLbl.Location = new System.Drawing.Point(114, 539);
            this.evenNumbersLbl.Name = "evenNumbersLbl";
            this.evenNumbersLbl.Size = new System.Drawing.Size(0, 55);
            this.evenNumbersLbl.TabIndex = 8;
            // 
            // evenNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 933);
            this.Controls.Add(this.evenNumbersLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.promptLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.mainMenuBtn);
            this.Name = "evenNumbers";
            this.Text = "evenNumbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label promptLbl;
        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label evenNumbersLbl;
    }
}