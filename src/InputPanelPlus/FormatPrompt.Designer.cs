namespace InputPanelPlus
{
    partial class FormatPrompt
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
            this.buttonMathML = new System.Windows.Forms.Button();
            this.buttonLatex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMathML
            // 
            this.buttonMathML.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMathML.Location = new System.Drawing.Point(12, 12);
            this.buttonMathML.Name = "buttonMathML";
            this.buttonMathML.Size = new System.Drawing.Size(236, 36);
            this.buttonMathML.TabIndex = 0;
            this.buttonMathML.Text = "MathML";
            this.buttonMathML.UseVisualStyleBackColor = true;
            // 
            // buttonLatex
            // 
            this.buttonLatex.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.buttonLatex.Location = new System.Drawing.Point(12, 54);
            this.buttonLatex.Name = "buttonLatex";
            this.buttonLatex.Size = new System.Drawing.Size(236, 36);
            this.buttonLatex.TabIndex = 1;
            this.buttonLatex.Text = "LaTeX";
            this.buttonLatex.UseVisualStyleBackColor = true;
            // 
            // FormatPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 104);
            this.ControlBox = false;
            this.Controls.Add(this.buttonLatex);
            this.Controls.Add(this.buttonMathML);
            this.Name = "FormatPrompt";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Format";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMathML;
        private System.Windows.Forms.Button buttonLatex;
    }
}