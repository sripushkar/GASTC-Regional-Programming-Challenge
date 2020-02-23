namespace Programming_Challenge
{
    partial class telephoneConverter
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
            this.evenNumbersLbl = new System.Windows.Forms.Label();
            this.outputLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.promptLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // evenNumbersLbl
            // 
            this.evenNumbersLbl.AutoSize = true;
            this.evenNumbersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evenNumbersLbl.Location = new System.Drawing.Point(106, 595);
            this.evenNumbersLbl.Name = "evenNumbersLbl";
            this.evenNumbersLbl.Size = new System.Drawing.Size(0, 55);
            this.evenNumbersLbl.TabIndex = 15;
            // 
            // outputLbl
            // 
            this.outputLbl.AutoSize = true;
            this.outputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLbl.Location = new System.Drawing.Point(116, 619);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(0, 55);
            this.outputLbl.TabIndex = 14;
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(116, 462);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(421, 86);
            this.submitBtn.TabIndex = 13;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(116, 360);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(486, 44);
            this.input.TabIndex = 12;
            // 
            // promptLbl
            // 
            this.promptLbl.AutoSize = true;
            this.promptLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLbl.Location = new System.Drawing.Point(106, 282);
            this.promptLbl.Name = "promptLbl";
            this.promptLbl.Size = new System.Drawing.Size(1205, 55);
            this.promptLbl.TabIndex = 11;
            this.promptLbl.Text = "Please Enter a Phone Number with characters included";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(574, 120);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(477, 55);
            this.titleLbl.TabIndex = 10;
            this.titleLbl.Text = "Telephone Converter";
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuBtn.Location = new System.Drawing.Point(630, 785);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(421, 86);
            this.mainMenuBtn.TabIndex = 9;
            this.mainMenuBtn.Text = "Main Menu";
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(630, 462);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(421, 86);
            this.resetBtn.TabIndex = 17;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // telephoneConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 1023);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.evenNumbersLbl);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.input);
            this.Controls.Add(this.promptLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.mainMenuBtn);
            this.Name = "telephoneConverter";
            this.Text = "telephoneConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label evenNumbersLbl;
        private System.Windows.Forms.Label outputLbl;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label promptLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Button resetBtn;
    }
}