
namespace Lab_Form
{
    partial class Form_M12
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVar = new System.Windows.Forms.Button();
            this.btnLocalVar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelInstanceCount = new System.Windows.Forms.Label();
            this.labelStaticCount = new System.Windows.Forms.Label();
            this.btnCallHelloForm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(55, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "+=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Count: 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVar);
            this.groupBox1.Controls.Add(this.btnLocalVar);
            this.groupBox1.Location = new System.Drawing.Point(294, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 214);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnVar
            // 
            this.btnVar.Location = new System.Drawing.Point(53, 130);
            this.btnVar.Name = "btnVar";
            this.btnVar.Size = new System.Drawing.Size(154, 57);
            this.btnVar.TabIndex = 1;
            this.btnVar.Text = "var.";
            this.btnVar.UseVisualStyleBackColor = true;
            // 
            // btnLocalVar
            // 
            this.btnLocalVar.Location = new System.Drawing.Point(53, 47);
            this.btnLocalVar.Name = "btnLocalVar";
            this.btnLocalVar.Size = new System.Drawing.Size(154, 57);
            this.btnLocalVar.TabIndex = 0;
            this.btnLocalVar.Text = "Local var.";
            this.btnLocalVar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(294, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 214);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "static";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Static Count";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(53, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 57);
            this.button3.TabIndex = 0;
            this.button3.Text = "Instance Count";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelInstanceCount
            // 
            this.labelInstanceCount.AutoSize = true;
            this.labelInstanceCount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstanceCount.Location = new System.Drawing.Point(555, 295);
            this.labelInstanceCount.Name = "labelInstanceCount";
            this.labelInstanceCount.Size = new System.Drawing.Size(89, 24);
            this.labelInstanceCount.TabIndex = 4;
            this.labelInstanceCount.Text = "Count: 0";
            // 
            // labelStaticCount
            // 
            this.labelStaticCount.AutoSize = true;
            this.labelStaticCount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaticCount.Location = new System.Drawing.Point(555, 378);
            this.labelStaticCount.Name = "labelStaticCount";
            this.labelStaticCount.Size = new System.Drawing.Size(89, 24);
            this.labelStaticCount.TabIndex = 5;
            this.labelStaticCount.Text = "Count: 0";
            // 
            // btnCallHelloForm
            // 
            this.btnCallHelloForm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallHelloForm.Location = new System.Drawing.Point(71, 378);
            this.btnCallHelloForm.Name = "btnCallHelloForm";
            this.btnCallHelloForm.Size = new System.Drawing.Size(185, 41);
            this.btnCallHelloForm.TabIndex = 6;
            this.btnCallHelloForm.Text = "Call HelloForm";
            this.btnCallHelloForm.UseVisualStyleBackColor = true;
            this.btnCallHelloForm.Click += new System.EventHandler(this.btnCallHelloForm_Click);
            // 
            // Form_M12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCallHelloForm);
            this.Controls.Add(this.labelStaticCount);
            this.Controls.Add(this.labelInstanceCount);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form_M12";
            this.Text = "Form_M12";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVar;
        private System.Windows.Forms.Button btnLocalVar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelInstanceCount;
        private System.Windows.Forms.Label labelStaticCount;
        private System.Windows.Forms.Button btnCallHelloForm;
    }
}