
namespace Lab_Form
{
    partial class Form_M04_OpenHelloForm
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
            this.btnOpenHelloForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMethod = new System.Windows.Forms.Button();
            this.btnBirthYear = new System.Windows.Forms.Button();
            this.btnEncapsulation = new System.Windows.Forms.Button();
            this.btnPartialClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenHelloForm
            // 
            this.btnOpenHelloForm.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOpenHelloForm.Location = new System.Drawing.Point(449, 12);
            this.btnOpenHelloForm.Name = "btnOpenHelloForm";
            this.btnOpenHelloForm.Size = new System.Drawing.Size(254, 60);
            this.btnOpenHelloForm.TabIndex = 0;
            this.btnOpenHelloForm.Text = "Open Hello Form";
            this.btnOpenHelloForm.UseVisualStyleBackColor = true;
            this.btnOpenHelloForm.Click += new System.EventHandler(this.btnOpenHelloForm_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(449, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "My First Method";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMethod
            // 
            this.btnMethod.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMethod.Location = new System.Drawing.Point(449, 144);
            this.btnMethod.Name = "btnMethod";
            this.btnMethod.Size = new System.Drawing.Size(254, 60);
            this.btnMethod.TabIndex = 2;
            this.btnMethod.Text = "Method";
            this.btnMethod.UseVisualStyleBackColor = true;
            this.btnMethod.Click += new System.EventHandler(this.btnMethod_Click_1);
            // 
            // btnBirthYear
            // 
            this.btnBirthYear.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBirthYear.Location = new System.Drawing.Point(449, 210);
            this.btnBirthYear.Name = "btnBirthYear";
            this.btnBirthYear.Size = new System.Drawing.Size(254, 60);
            this.btnBirthYear.TabIndex = 3;
            this.btnBirthYear.Text = "Return Birth Year";
            this.btnBirthYear.UseVisualStyleBackColor = true;
            this.btnBirthYear.Click += new System.EventHandler(this.btnBirthYear_Click);
            // 
            // btnEncapsulation
            // 
            this.btnEncapsulation.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEncapsulation.Location = new System.Drawing.Point(449, 276);
            this.btnEncapsulation.Name = "btnEncapsulation";
            this.btnEncapsulation.Size = new System.Drawing.Size(254, 60);
            this.btnEncapsulation.TabIndex = 4;
            this.btnEncapsulation.Text = "封裝";
            this.btnEncapsulation.UseVisualStyleBackColor = true;
            this.btnEncapsulation.Click += new System.EventHandler(this.btnEncapsulation_Click);
            // 
            // btnPartialClass
            // 
            this.btnPartialClass.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPartialClass.Location = new System.Drawing.Point(449, 342);
            this.btnPartialClass.Name = "btnPartialClass";
            this.btnPartialClass.Size = new System.Drawing.Size(254, 60);
            this.btnPartialClass.TabIndex = 5;
            this.btnPartialClass.Text = "Partial Class";
            this.btnPartialClass.UseVisualStyleBackColor = true;
            this.btnPartialClass.Click += new System.EventHandler(this.btnPartialClass_Click);
            // 
            // Form_M04_OpenHelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPartialClass);
            this.Controls.Add(this.btnEncapsulation);
            this.Controls.Add(this.btnBirthYear);
            this.Controls.Add(this.btnMethod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpenHelloForm);
            this.Name = "Form_M04_OpenHelloForm";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenHelloForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMethod;
        private System.Windows.Forms.Button btnBirthYear;
        private System.Windows.Forms.Button btnEncapsulation;
        private System.Windows.Forms.Button btnPartialClass;
    }
}