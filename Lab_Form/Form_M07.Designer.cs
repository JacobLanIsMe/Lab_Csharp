
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
            // Form_M07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeregister);
            this.Controls.Add(this.btnRegister02);
            this.Controls.Add(this.btnRegister01);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnObjectInit);
            this.Name = "Form_M07";
            this.Text = "Form_M07";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObjectInit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRegister01;
        private System.Windows.Forms.Button btnRegister02;
        private System.Windows.Forms.Button btnDeregister;
    }
}