namespace task2
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
            this.lblZ = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbZ = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btnGetResult = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbResultSecond = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(213, 140);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(14, 15);
            this.lblZ.TabIndex = 0;
            this.lblZ.Text = "Z";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(213, 104);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 15);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Y";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(213, 66);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 15);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "X";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(247, 63);
            this.tbX.Name = "tbX";
            this.tbX.ReadOnly = true;
            this.tbX.Size = new System.Drawing.Size(100, 23);
            this.tbX.TabIndex = 3;
            this.tbX.Text = "16.55 * 10^(-3)";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(247, 101);
            this.tbY.Name = "tbY";
            this.tbY.ReadOnly = true;
            this.tbY.Size = new System.Drawing.Size(100, 23);
            this.tbY.TabIndex = 4;
            this.tbY.Text = "-2.75";
            // 
            // tbZ
            // 
            this.tbZ.Location = new System.Drawing.Point(247, 137);
            this.tbZ.Name = "tbZ";
            this.tbZ.ReadOnly = true;
            this.tbZ.Size = new System.Drawing.Size(100, 23);
            this.tbZ.TabIndex = 5;
            this.tbZ.Text = "0.15";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(247, 223);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(100, 23);
            this.tbResult.TabIndex = 6;
            // 
            // btnGetResult
            // 
            this.btnGetResult.Location = new System.Drawing.Point(247, 184);
            this.btnGetResult.Name = "btnGetResult";
            this.btnGetResult.Size = new System.Drawing.Size(100, 23);
            this.btnGetResult.TabIndex = 7;
            this.btnGetResult.Text = "Рассчитать";
            this.btnGetResult.UseVisualStyleBackColor = true;
            this.btnGetResult.Click += new System.EventHandler(this.btnGetResult_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(181, 226);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(60, 15);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Результат";
            // 
            // tbResultSecond
            // 
            this.tbResultSecond.Location = new System.Drawing.Point(247, 252);
            this.tbResultSecond.Name = "tbResultSecond";
            this.tbResultSecond.ReadOnly = true;
            this.tbResultSecond.Size = new System.Drawing.Size(100, 23);
            this.tbResultSecond.TabIndex = 9;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(667, 421);
            this.Controls.Add(this.tbResultSecond);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnGetResult);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbZ);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblZ);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Label lblZ;
        private Label lblY;
        private Label lblX;
        private TextBox tbX;
        private TextBox tbY;
        private TextBox tbZ;
        private TextBox tbResult;
        private Button btnGetResult;
        private Label lblResult;
        private TextBox tbResultSecond;
    }
}