namespace oef01
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
            this.lbxListOfValues = new System.Windows.Forms.ListBox();
            this.tbxNewValue = new System.Windows.Forms.TextBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxListOfValues
            // 
            this.lbxListOfValues.FormattingEnabled = true;
            this.lbxListOfValues.Location = new System.Drawing.Point(12, 12);
            this.lbxListOfValues.Name = "lbxListOfValues";
            this.lbxListOfValues.Size = new System.Drawing.Size(120, 95);
            this.lbxListOfValues.TabIndex = 0;
            // 
            // tbxNewValue
            // 
            this.tbxNewValue.Location = new System.Drawing.Point(12, 113);
            this.tbxNewValue.Name = "tbxNewValue";
            this.tbxNewValue.Size = new System.Drawing.Size(120, 20);
            this.tbxNewValue.TabIndex = 1;
            this.tbxNewValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxNewValue_KeyDown);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(12, 139);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(120, 23);
            this.btnToevoegen.TabIndex = 2;
            this.btnToevoegen.Text = "Toevoegen!";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.tbxNewValue);
            this.Controls.Add(this.lbxListOfValues);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxListOfValues;
        private System.Windows.Forms.TextBox tbxNewValue;
        private System.Windows.Forms.Button btnToevoegen;
    }
}

