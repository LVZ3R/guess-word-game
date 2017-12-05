namespace guessWordGame
{
    partial class addUserForm
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
            this.loginBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lNameBox = new System.Windows.Forms.TextBox();
            this.maleBtn = new System.Windows.Forms.RadioButton();
            this.femaleBtn = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.yearOfBirthBox = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yearOfBirthBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(97, 12);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(145, 20);
            this.loginBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логін";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(97, 38);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(145, 20);
            this.passwordBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ім\'я";
            // 
            // fNameBox
            // 
            this.fNameBox.Location = new System.Drawing.Point(97, 81);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(145, 20);
            this.fNameBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Прізвище";
            // 
            // lNameBox
            // 
            this.lNameBox.Location = new System.Drawing.Point(97, 107);
            this.lNameBox.Name = "lNameBox";
            this.lNameBox.Size = new System.Drawing.Size(145, 20);
            this.lNameBox.TabIndex = 0;
            // 
            // maleBtn
            // 
            this.maleBtn.AutoSize = true;
            this.maleBtn.Enabled = false;
            this.maleBtn.Location = new System.Drawing.Point(97, 133);
            this.maleBtn.Name = "maleBtn";
            this.maleBtn.Size = new System.Drawing.Size(62, 17);
            this.maleBtn.TabIndex = 5;
            this.maleBtn.TabStop = true;
            this.maleBtn.Text = "чоловік";
            this.maleBtn.UseVisualStyleBackColor = true;
            // 
            // femaleBtn
            // 
            this.femaleBtn.AutoSize = true;
            this.femaleBtn.Enabled = false;
            this.femaleBtn.Location = new System.Drawing.Point(189, 133);
            this.femaleBtn.Name = "femaleBtn";
            this.femaleBtn.Size = new System.Drawing.Size(53, 17);
            this.femaleBtn.TabIndex = 5;
            this.femaleBtn.TabStop = true;
            this.femaleBtn.Text = "жінка";
            this.femaleBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Пошта";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(97, 156);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(145, 20);
            this.emailBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Рік народження";
            // 
            // yearOfBirthBox
            // 
            this.yearOfBirthBox.Location = new System.Drawing.Point(98, 183);
            this.yearOfBirthBox.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.yearOfBirthBox.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.yearOfBirthBox.Name = "yearOfBirthBox";
            this.yearOfBirthBox.Size = new System.Drawing.Size(144, 20);
            this.yearOfBirthBox.TabIndex = 8;
            this.yearOfBirthBox.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Додати користувача";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yearOfBirthBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.femaleBtn);
            this.Controls.Add(this.maleBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.lNameBox);
            this.Controls.Add(this.fNameBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBox);
            this.Name = "addUserForm";
            this.Text = "Новий користувач";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.addUserForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.yearOfBirthBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lNameBox;
        private System.Windows.Forms.RadioButton maleBtn;
        private System.Windows.Forms.RadioButton femaleBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown yearOfBirthBox;
        private System.Windows.Forms.Button button1;
    }
}