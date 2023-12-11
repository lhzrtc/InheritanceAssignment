namespace InheritanceAssignment
{
    partial class Form1
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
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateRectangle = new System.Windows.Forms.Button();
            this.btnCreateBox = new System.Windows.Forms.Button();
            this.btnCreatePyramid = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(233, 149);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(160, 29);
            this.txtLength.TabIndex = 0;
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(233, 210);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(160, 29);
            this.txtWidth.TabIndex = 1;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(233, 271);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(160, 29);
            this.txtHeight.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Height";
            // 
            // btnCreateRectangle
            // 
            this.btnCreateRectangle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRectangle.Location = new System.Drawing.Point(233, 322);
            this.btnCreateRectangle.Name = "btnCreateRectangle";
            this.btnCreateRectangle.Size = new System.Drawing.Size(160, 36);
            this.btnCreateRectangle.TabIndex = 6;
            this.btnCreateRectangle.Text = "Create Rectangle";
            this.btnCreateRectangle.UseVisualStyleBackColor = true;
            this.btnCreateRectangle.Click += new System.EventHandler(this.btnCreateRectangle_Click);
            // 
            // btnCreateBox
            // 
            this.btnCreateBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBox.Location = new System.Drawing.Point(233, 389);
            this.btnCreateBox.Name = "btnCreateBox";
            this.btnCreateBox.Size = new System.Drawing.Size(160, 36);
            this.btnCreateBox.TabIndex = 7;
            this.btnCreateBox.Text = "Create Box";
            this.btnCreateBox.UseVisualStyleBackColor = true;
            this.btnCreateBox.Click += new System.EventHandler(this.btnCreateBox_Click);
            // 
            // btnCreatePyramid
            // 
            this.btnCreatePyramid.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePyramid.Location = new System.Drawing.Point(233, 450);
            this.btnCreatePyramid.Name = "btnCreatePyramid";
            this.btnCreatePyramid.Size = new System.Drawing.Size(160, 36);
            this.btnCreatePyramid.TabIndex = 8;
            this.btnCreatePyramid.Text = "Create Pyramid";
            this.btnCreatePyramid.UseVisualStyleBackColor = true;
            this.btnCreatePyramid.Click += new System.EventHandler(this.btnCreatePyramid_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(512, 146);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(346, 337);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(460, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "OOP Class: Inheritance Assignment";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(89, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 501);
            this.panel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnCreatePyramid);
            this.Controls.Add(this.btnCreateBox);
            this.Controls.Add(this.btnCreateRectangle);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateRectangle;
        private System.Windows.Forms.Button btnCreateBox;
        private System.Windows.Forms.Button btnCreatePyramid;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}

