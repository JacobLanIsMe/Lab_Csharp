
namespace Lab_Form
{
    partial class Form_M02_HelloForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHello = new System.Windows.Forms.Button();
            this.labelChiName = new System.Windows.Forms.Label();
            this.textBoxChiName = new System.Windows.Forms.TextBox();
            this.labelEngName = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelZodiac = new System.Windows.Forms.Label();
            this.textBoxEngName = new System.Windows.Forms.TextBox();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.textBoxZodiac = new System.Windows.Forms.TextBox();
            this.btnHi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHello.Location = new System.Drawing.Point(116, 323);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(147, 38);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Say Hello!";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // labelChiName
            // 
            this.labelChiName.AutoSize = true;
            this.labelChiName.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelChiName.Location = new System.Drawing.Point(116, 99);
            this.labelChiName.Name = "labelChiName";
            this.labelChiName.Size = new System.Drawing.Size(65, 21);
            this.labelChiName.TabIndex = 1;
            this.labelChiName.Text = "姓名:";
            // 
            // textBoxChiName
            // 
            this.textBoxChiName.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxChiName.Location = new System.Drawing.Point(274, 96);
            this.textBoxChiName.Name = "textBoxChiName";
            this.textBoxChiName.Size = new System.Drawing.Size(145, 27);
            this.textBoxChiName.TabIndex = 2;
            // 
            // labelEngName
            // 
            this.labelEngName.AutoSize = true;
            this.labelEngName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEngName.Location = new System.Drawing.Point(116, 154);
            this.labelEngName.Name = "labelEngName";
            this.labelEngName.Size = new System.Drawing.Size(149, 24);
            this.labelEngName.TabIndex = 3;
            this.labelEngName.Text = "English Name: ";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelGender.Location = new System.Drawing.Point(116, 212);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(65, 21);
            this.labelGender.TabIndex = 4;
            this.labelGender.Text = "性別:";
            // 
            // labelZodiac
            // 
            this.labelZodiac.AutoSize = true;
            this.labelZodiac.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelZodiac.Location = new System.Drawing.Point(116, 269);
            this.labelZodiac.Name = "labelZodiac";
            this.labelZodiac.Size = new System.Drawing.Size(65, 21);
            this.labelZodiac.TabIndex = 5;
            this.labelZodiac.Text = "星座:";
            // 
            // textBoxEngName
            // 
            this.textBoxEngName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEngName.Location = new System.Drawing.Point(274, 153);
            this.textBoxEngName.Name = "textBoxEngName";
            this.textBoxEngName.Size = new System.Drawing.Size(145, 26);
            this.textBoxEngName.TabIndex = 6;
            // 
            // textBoxGender
            // 
            this.textBoxGender.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxGender.Location = new System.Drawing.Point(274, 209);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.Size = new System.Drawing.Size(145, 27);
            this.textBoxGender.TabIndex = 7;
            // 
            // textBoxZodiac
            // 
            this.textBoxZodiac.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxZodiac.Location = new System.Drawing.Point(274, 266);
            this.textBoxZodiac.Name = "textBoxZodiac";
            this.textBoxZodiac.Size = new System.Drawing.Size(145, 27);
            this.textBoxZodiac.TabIndex = 8;
            // 
            // btnHi
            // 
            this.btnHi.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHi.Location = new System.Drawing.Point(274, 323);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(145, 38);
            this.btnHi.TabIndex = 9;
            this.btnHi.Text = "Say Hi!";
            this.btnHi.UseVisualStyleBackColor = true;
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // Form_M02_HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.textBoxZodiac);
            this.Controls.Add(this.textBoxGender);
            this.Controls.Add(this.textBoxEngName);
            this.Controls.Add(this.labelZodiac);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelEngName);
            this.Controls.Add(this.textBoxChiName);
            this.Controls.Add(this.labelChiName);
            this.Controls.Add(this.btnHello);
            this.Name = "Form_M02_HelloForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Label labelChiName;
        private System.Windows.Forms.TextBox textBoxChiName;
        private System.Windows.Forms.Label labelEngName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelZodiac;
        private System.Windows.Forms.TextBox textBoxEngName;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.TextBox textBoxZodiac;
        private System.Windows.Forms.Button btnHi;
    }
}

