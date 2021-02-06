
namespace Statistics
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonclr = new System.Windows.Forms.Button();
            this.listvalues = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textsum = new System.Windows.Forms.TextBox();
            this.textmean = new System.Windows.Forms.TextBox();
            this.textmedian = new System.Windows.Forms.TextBox();
            this.textvar = new System.Windows.Forms.TextBox();
            this.textstd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "VALUES";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 1;
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(263, 12);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(75, 23);
            this.buttonadd.TabIndex = 2;
            this.buttonadd.Text = "Add";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttonclr
            // 
            this.buttonclr.Location = new System.Drawing.Point(263, 65);
            this.buttonclr.Name = "buttonclr";
            this.buttonclr.Size = new System.Drawing.Size(75, 23);
            this.buttonclr.TabIndex = 3;
            this.buttonclr.Text = "Clear";
            this.buttonclr.UseVisualStyleBackColor = true;
            this.buttonclr.Click += new System.EventHandler(this.buttonclr_Click);
            // 
            // listvalues
            // 
            this.listvalues.FormattingEnabled = true;
            this.listvalues.Location = new System.Drawing.Point(89, 52);
            this.listvalues.Name = "listvalues";
            this.listvalues.Size = new System.Drawing.Size(120, 134);
            this.listvalues.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "MEDIAN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "SUM";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "MEAN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "VARIANCE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "STANDARD DEVIATION";
            // 
            // textsum
            // 
            this.textsum.Location = new System.Drawing.Point(194, 233);
            this.textsum.Name = "textsum";
            this.textsum.Size = new System.Drawing.Size(126, 20);
            this.textsum.TabIndex = 10;
            // 
            // textmean
            // 
            this.textmean.Location = new System.Drawing.Point(194, 270);
            this.textmean.Name = "textmean";
            this.textmean.Size = new System.Drawing.Size(126, 20);
            this.textmean.TabIndex = 11;
            // 
            // textmedian
            // 
            this.textmedian.Location = new System.Drawing.Point(194, 304);
            this.textmedian.Name = "textmedian";
            this.textmedian.Size = new System.Drawing.Size(126, 20);
            this.textmedian.TabIndex = 12;
            // 
            // textvar
            // 
            this.textvar.Location = new System.Drawing.Point(194, 342);
            this.textvar.Name = "textvar";
            this.textvar.Size = new System.Drawing.Size(126, 20);
            this.textvar.TabIndex = 13;
            // 
            // textstd
            // 
            this.textstd.Location = new System.Drawing.Point(194, 380);
            this.textstd.Name = "textstd";
            this.textstd.Size = new System.Drawing.Size(126, 20);
            this.textstd.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 572);
            this.Controls.Add(this.textstd);
            this.Controls.Add(this.textvar);
            this.Controls.Add(this.textmedian);
            this.Controls.Add(this.textmean);
            this.Controls.Add(this.textsum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listvalues);
            this.Controls.Add(this.buttonclr);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttonclr;
        private System.Windows.Forms.ListBox listvalues;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textsum;
        private System.Windows.Forms.TextBox textmean;
        private System.Windows.Forms.TextBox textmedian;
        private System.Windows.Forms.TextBox textvar;
        private System.Windows.Forms.TextBox textstd;
    }
}

