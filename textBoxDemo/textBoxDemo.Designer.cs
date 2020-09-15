namespace textBoxDemo
{
    partial class textBoxDemoForm
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
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnReadInput = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtEnterName = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(35, 45);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(117, 17);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Enter your name:";
            this.lblInput.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(35, 87);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(90, 17);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "You entered:";
            this.lblOutput.Click += new System.EventHandler(this.LblOutput_Click);
            // 
            // btnReadInput
            // 
            this.btnReadInput.Location = new System.Drawing.Point(38, 129);
            this.btnReadInput.Name = "btnReadInput";
            this.btnReadInput.Size = new System.Drawing.Size(92, 33);
            this.btnReadInput.TabIndex = 2;
            this.btnReadInput.Text = "&Read Input";
            this.btnReadInput.UseVisualStyleBackColor = true;
            this.btnReadInput.Click += new System.EventHandler(this.BtnReadInput_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(195, 129);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 33);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // txtEnterName
            // 
            this.txtEnterName.Location = new System.Drawing.Point(158, 42);
            this.txtEnterName.Name = "txtEnterName";
            this.txtEnterName.Size = new System.Drawing.Size(120, 22);
            this.txtEnterName.TabIndex = 4;
            this.txtEnterName.TextChanged += new System.EventHandler(this.TxtEnterName_TextChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(158, 87);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(120, 22);
            this.txtOutput.TabIndex = 5;
            this.txtOutput.TextChanged += new System.EventHandler(this.TxtOutput_TextChanged);
            // 
            // textBoxDemoForm
            // 
            this.AcceptButton = this.btnReadInput;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(345, 206);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtEnterName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReadInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Name = "textBoxDemoForm";
            this.Text = "textBoxDemoForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnReadInput;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtEnterName;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

