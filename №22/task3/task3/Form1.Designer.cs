namespace task3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblX = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.cbSH = new System.Windows.Forms.CheckBox();
            this.cbXCube = new System.Windows.Forms.CheckBox();
            this.cbEX = new System.Windows.Forms.CheckBox();
            this.btnGetResult = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(210, 57);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 15);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(210, 89);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(17, 15);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "B:";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(233, 54);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(100, 23);
            this.tbX.TabIndex = 2;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(233, 86);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 23);
            this.tbB.TabIndex = 3;
            // 
            // cbSH
            // 
            this.cbSH.AutoSize = true;
            this.cbSH.Location = new System.Drawing.Point(210, 129);
            this.cbSH.Name = "cbSH";
            this.cbSH.Size = new System.Drawing.Size(52, 19);
            this.cbSH.TabIndex = 4;
            this.cbSH.Text = "sh(x)";
            this.cbSH.UseVisualStyleBackColor = true;
            // 
            // cbXCube
            // 
            this.cbXCube.AutoSize = true;
            this.cbXCube.Location = new System.Drawing.Point(268, 129);
            this.cbXCube.Name = "cbXCube";
            this.cbXCube.Size = new System.Drawing.Size(46, 19);
            this.cbXCube.TabIndex = 5;
            this.cbXCube.Text = "x^2";
            this.cbXCube.UseVisualStyleBackColor = true;
            // 
            // cbEX
            // 
            this.cbEX.AutoSize = true;
            this.cbEX.Location = new System.Drawing.Point(326, 129);
            this.cbEX.Name = "cbEX";
            this.cbEX.Size = new System.Drawing.Size(46, 19);
            this.cbEX.TabIndex = 6;
            this.cbEX.Text = "e^x";
            this.cbEX.UseVisualStyleBackColor = true;
            // 
            // btnGetResult
            // 
            this.btnGetResult.Location = new System.Drawing.Point(233, 165);
            this.btnGetResult.Name = "btnGetResult";
            this.btnGetResult.Size = new System.Drawing.Size(100, 23);
            this.btnGetResult.TabIndex = 7;
            this.btnGetResult.Text = "Рассчитать";
            this.btnGetResult.UseVisualStyleBackColor = true;
            this.btnGetResult.Click += new System.EventHandler(this.btnGetResult_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(233, 206);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(100, 23);
            this.tbResult.TabIndex = 8;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(164, 209);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(63, 15);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Результат:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(777, 485);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnGetResult);
            this.Controls.Add(this.cbEX);
            this.Controls.Add(this.cbXCube);
            this.Controls.Add(this.cbSH);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblX);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Label lblX;
        private Label lblB;
        private TextBox tbX;
        private TextBox tbB;
        private CheckBox cbSH;
        private CheckBox cbXCube;
        private CheckBox cbEX;
        private Button btnGetResult;
        private TextBox tbResult;
        private Label lblResult;
    }
}