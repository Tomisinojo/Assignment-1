
namespace WindowsFormsApp5
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.textBMI = new System.Windows.Forms.TextBox();
            this.radioKilograms = new System.Windows.Forms.RadioButton();
            this.radioPounds = new System.Windows.Forms.RadioButton();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonreset = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weight";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "BodyMassIndex";
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(103, 96);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(181, 20);
            this.textHeight.TabIndex = 3;
            // 
            // textWeight
            // 
            this.textWeight.Location = new System.Drawing.Point(103, 26);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(181, 20);
            this.textWeight.TabIndex = 4;
            // 
            // textBMI
            // 
            this.textBMI.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBMI.Font = new System.Drawing.Font("Cambria Math", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBMI.Location = new System.Drawing.Point(59, 228);
            this.textBMI.Multiline = true;
            this.textBMI.Name = "textBMI";
            this.textBMI.ReadOnly = true;
            this.textBMI.Size = new System.Drawing.Size(225, 69);
            this.textBMI.TabIndex = 5;
            // 
            // radioKilograms
            // 
            this.radioKilograms.AutoSize = true;
            this.radioKilograms.Location = new System.Drawing.Point(59, 162);
            this.radioKilograms.Name = "radioKilograms";
            this.radioKilograms.Size = new System.Drawing.Size(70, 17);
            this.radioKilograms.TabIndex = 6;
            this.radioKilograms.TabStop = true;
            this.radioKilograms.Text = "Kilograms";
            this.radioKilograms.UseVisualStyleBackColor = true;
            // 
            // radioPounds
            // 
            this.radioPounds.AutoSize = true;
            this.radioPounds.Location = new System.Drawing.Point(199, 162);
            this.radioPounds.Name = "radioPounds";
            this.radioPounds.Size = new System.Drawing.Size(80, 17);
            this.radioPounds.TabIndex = 7;
            this.radioPounds.TabStop = true;
            this.radioPounds.Text = "Pounds(lbs)";
            this.radioPounds.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(59, 332);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(225, 23);
            this.buttonCalculate.TabIndex = 8;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonreset
            // 
            this.buttonreset.Location = new System.Drawing.Point(59, 371);
            this.buttonreset.Name = "buttonreset";
            this.buttonreset.Size = new System.Drawing.Size(75, 23);
            this.buttonreset.TabIndex = 9;
            this.buttonreset.Text = "Reset";
            this.buttonreset.UseVisualStyleBackColor = true;
            this.buttonreset.Click += new System.EventHandler(this.buttonreset_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.Location = new System.Drawing.Point(209, 371);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(75, 23);
            this.buttonexit.TabIndex = 10;
            this.buttonexit.Text = "Exit";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.buttonreset);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.radioPounds);
            this.Controls.Add(this.radioKilograms);
            this.Controls.Add(this.textBMI);
            this.Controls.Add(this.textWeight);
            this.Controls.Add(this.textHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.TextBox textWeight;
        private System.Windows.Forms.TextBox textBMI;
        private System.Windows.Forms.RadioButton radioKilograms;
        private System.Windows.Forms.RadioButton radioPounds;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonreset;
        private System.Windows.Forms.Button buttonexit;
    }
}

