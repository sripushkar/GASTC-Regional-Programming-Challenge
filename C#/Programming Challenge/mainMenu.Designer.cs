namespace Programming_Challenge
{
    partial class mainMenu
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
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.evenNumbersBtn = new System.Windows.Forms.Button();
            this.orderNumbersBtn = new System.Windows.Forms.Button();
            this.telephoneConverterBtn = new System.Windows.Forms.Button();
            this.stringSearchingBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.Location = new System.Drawing.Point(708, 127);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(224, 55);
            this.welcomeLbl.TabIndex = 0;
            this.welcomeLbl.Text = "Welcome";
            // 
            // evenNumbersBtn
            // 
            this.evenNumbersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evenNumbersBtn.Location = new System.Drawing.Point(610, 235);
            this.evenNumbersBtn.Name = "evenNumbersBtn";
            this.evenNumbersBtn.Size = new System.Drawing.Size(421, 86);
            this.evenNumbersBtn.TabIndex = 1;
            this.evenNumbersBtn.Text = "Even Numbers";
            this.evenNumbersBtn.UseVisualStyleBackColor = true;
            this.evenNumbersBtn.Click += new System.EventHandler(this.evenNumbersBtn_Click);
            // 
            // orderNumbersBtn
            // 
            this.orderNumbersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNumbersBtn.Location = new System.Drawing.Point(610, 374);
            this.orderNumbersBtn.Name = "orderNumbersBtn";
            this.orderNumbersBtn.Size = new System.Drawing.Size(421, 86);
            this.orderNumbersBtn.TabIndex = 2;
            this.orderNumbersBtn.Text = "Order Numbers";
            this.orderNumbersBtn.UseVisualStyleBackColor = true;
            this.orderNumbersBtn.Click += new System.EventHandler(this.orderNumbersBtn_Click);
            // 
            // telephoneConverterBtn
            // 
            this.telephoneConverterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephoneConverterBtn.Location = new System.Drawing.Point(603, 513);
            this.telephoneConverterBtn.Name = "telephoneConverterBtn";
            this.telephoneConverterBtn.Size = new System.Drawing.Size(435, 159);
            this.telephoneConverterBtn.TabIndex = 3;
            this.telephoneConverterBtn.Text = "Telephone Converter";
            this.telephoneConverterBtn.UseVisualStyleBackColor = true;
            this.telephoneConverterBtn.Click += new System.EventHandler(this.telephoneConverterBtn_Click);
            // 
            // stringSearchingBtn
            // 
            this.stringSearchingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringSearchingBtn.Location = new System.Drawing.Point(603, 725);
            this.stringSearchingBtn.Name = "stringSearchingBtn";
            this.stringSearchingBtn.Size = new System.Drawing.Size(435, 123);
            this.stringSearchingBtn.TabIndex = 4;
            this.stringSearchingBtn.Text = "String Searching";
            this.stringSearchingBtn.UseVisualStyleBackColor = true;
            this.stringSearchingBtn.Click += new System.EventHandler(this.stringSearchingBtn_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1642, 999);
            this.Controls.Add(this.stringSearchingBtn);
            this.Controls.Add(this.telephoneConverterBtn);
            this.Controls.Add(this.orderNumbersBtn);
            this.Controls.Add(this.evenNumbersBtn);
            this.Controls.Add(this.welcomeLbl);
            this.Name = "mainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Button evenNumbersBtn;
        private System.Windows.Forms.Button orderNumbersBtn;
        private System.Windows.Forms.Button telephoneConverterBtn;
        private System.Windows.Forms.Button stringSearchingBtn;
    }
}

