namespace StringsAndArrays
{
    partial class frmNames
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
            this.lblEnter = new System.Windows.Forms.Label();
            this.txtBxEnterName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDisplay1 = new System.Windows.Forms.Button();
            this.btnDisplay2 = new System.Windows.Forms.Button();
            this.btnDisplay3 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtBxDisplay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Location = new System.Drawing.Point(22, 25);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(87, 17);
            this.lblEnter.TabIndex = 0;
            this.lblEnter.Text = "&Enter Name:";
            // 
            // txtBxEnterName
            // 
            this.txtBxEnterName.Location = new System.Drawing.Point(115, 19);
            this.txtBxEnterName.Name = "txtBxEnterName";
            this.txtBxEnterName.Size = new System.Drawing.Size(151, 23);
            this.txtBxEnterName.TabIndex = 1;
            this.txtBxEnterName.TextChanged += new System.EventHandler(this.txtBxEnterName_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(280, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDisplay1
            // 
            this.btnDisplay1.Location = new System.Drawing.Point(25, 79);
            this.btnDisplay1.Name = "btnDisplay1";
            this.btnDisplay1.Size = new System.Drawing.Size(106, 32);
            this.btnDisplay1.TabIndex = 3;
            this.btnDisplay1.Text = "Display List &1";
            this.btnDisplay1.UseVisualStyleBackColor = true;
            this.btnDisplay1.Click += new System.EventHandler(this.btnDisplay1_Click);
            // 
            // btnDisplay2
            // 
            this.btnDisplay2.Location = new System.Drawing.Point(25, 117);
            this.btnDisplay2.Name = "btnDisplay2";
            this.btnDisplay2.Size = new System.Drawing.Size(106, 31);
            this.btnDisplay2.TabIndex = 4;
            this.btnDisplay2.Text = "Display List &2";
            this.btnDisplay2.UseVisualStyleBackColor = true;
            this.btnDisplay2.Click += new System.EventHandler(this.btnDisplay2_Click);
            // 
            // btnDisplay3
            // 
            this.btnDisplay3.Location = new System.Drawing.Point(25, 154);
            this.btnDisplay3.Name = "btnDisplay3";
            this.btnDisplay3.Size = new System.Drawing.Size(106, 32);
            this.btnDisplay3.TabIndex = 5;
            this.btnDisplay3.Text = "Display List &3";
            this.btnDisplay3.UseVisualStyleBackColor = true;
            this.btnDisplay3.Click += new System.EventHandler(this.btnDisplay3_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(25, 228);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 33);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "C&lear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(25, 267);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 33);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtBxDisplay
            // 
            this.txtBxDisplay.Location = new System.Drawing.Point(162, 79);
            this.txtBxDisplay.Name = "txtBxDisplay";
            this.txtBxDisplay.ReadOnly = true;
            this.txtBxDisplay.Size = new System.Drawing.Size(193, 221);
            this.txtBxDisplay.TabIndex = 8;
            this.txtBxDisplay.Text = "";
            // 
            // frmNames
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(379, 325);
            this.Controls.Add(this.txtBxDisplay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisplay3);
            this.Controls.Add(this.btnDisplay2);
            this.Controls.Add(this.btnDisplay1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBxEnterName);
            this.Controls.Add(this.lblEnter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmNames";
            this.Text = "Names";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.TextBox txtBxEnterName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDisplay1;
        private System.Windows.Forms.Button btnDisplay2;
        private System.Windows.Forms.Button btnDisplay3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox txtBxDisplay;
    }
}

