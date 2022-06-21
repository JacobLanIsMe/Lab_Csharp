
namespace Lab_Form
{
    partial class Form_M07
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
            this.btnObjectInit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegister01 = new System.Windows.Forms.Button();
            this.btnRegister02 = new System.Windows.Forms.Button();
            this.btnDeregister = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMessageBox = new System.Windows.Forms.Button();
            this.btnDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnObjectInit
            // 
            this.btnObjectInit.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnObjectInit.Location = new System.Drawing.Point(514, 39);
            this.btnObjectInit.Name = "btnObjectInit";
            this.btnObjectInit.Size = new System.Drawing.Size(134, 44);
            this.btnObjectInit.TabIndex = 0;
            this.btnObjectInit.Text = "物件初始化";
            this.btnObjectInit.UseVisualStyleBackColor = true;
            this.btnObjectInit.Click += new System.EventHandler(this.btnObjectInit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "註冊事件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegister01
            // 
            this.btnRegister01.Location = new System.Drawing.Point(159, 122);
            this.btnRegister01.Name = "btnRegister01";
            this.btnRegister01.Size = new System.Drawing.Size(119, 47);
            this.btnRegister01.TabIndex = 2;
            this.btnRegister01.Text = "Register01";
            this.btnRegister01.UseVisualStyleBackColor = true;
            // 
            // btnRegister02
            // 
            this.btnRegister02.Location = new System.Drawing.Point(159, 187);
            this.btnRegister02.Name = "btnRegister02";
            this.btnRegister02.Size = new System.Drawing.Size(119, 47);
            this.btnRegister02.TabIndex = 3;
            this.btnRegister02.Text = "Register02";
            this.btnRegister02.UseVisualStyleBackColor = true;
            // 
            // btnDeregister
            // 
            this.btnDeregister.Location = new System.Drawing.Point(159, 255);
            this.btnDeregister.Name = "btnDeregister";
            this.btnDeregister.Size = new System.Drawing.Size(119, 47);
            this.btnDeregister.TabIndex = 4;
            this.btnDeregister.Text = "解除註冊";
            this.btnDeregister.UseVisualStyleBackColor = true;
            this.btnDeregister.Click += new System.EventHandler(this.btnDeregister_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(433, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "50%off",
            "20%off"});
            this.comboBox1.Location = new System.Drawing.Point(433, 226);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(433, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "折扣後金額";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(514, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 44);
            this.button3.TabIndex = 8;
            this.button3.Text = "Set Property";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMessageBox
            // 
            this.btnMessageBox.Location = new System.Drawing.Point(159, 319);
            this.btnMessageBox.Name = "btnMessageBox";
            this.btnMessageBox.Size = new System.Drawing.Size(119, 47);
            this.btnMessageBox.TabIndex = 9;
            this.btnMessageBox.Text = "MessageBox";
            this.btnMessageBox.UseVisualStyleBackColor = true;
            this.btnMessageBox.Click += new System.EventHandler(this.btnMessageBox_Click);
            // 
            // btnDialog
            // 
            this.btnDialog.Location = new System.Drawing.Point(159, 372);
            this.btnDialog.Name = "btnDialog";
            this.btnDialog.Size = new System.Drawing.Size(119, 47);
            this.btnDialog.TabIndex = 10;
            this.btnDialog.Text = "Dialog Result";
            this.btnDialog.UseVisualStyleBackColor = true;
            this.btnDialog.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // Form_M07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDialog);
            this.Controls.Add(this.btnMessageBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDeregister);
            this.Controls.Add(this.btnRegister02);
            this.Controls.Add(this.btnRegister01);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnObjectInit);
            this.Name = "Form_M07";
            this.Text = "Form_M07";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObjectInit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRegister01;
        private System.Windows.Forms.Button btnRegister02;
        private System.Windows.Forms.Button btnDeregister;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnMessageBox;
        private System.Windows.Forms.Button btnDialog;
    }
}