namespace HelloWorldApp
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
            this.clickHere = new System.Windows.Forms.Button();
            this.joinTheDarkSide = new System.Windows.Forms.Label();
            this.useTheForce = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clickHere
            // 
            this.clickHere.BackColor = System.Drawing.Color.Black;
            this.clickHere.Font = new System.Drawing.Font("Star Jedi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickHere.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clickHere.Location = new System.Drawing.Point(401, 12);
            this.clickHere.Name = "clickHere";
            this.clickHere.Size = new System.Drawing.Size(500, 80);
            this.clickHere.TabIndex = 0;
            this.clickHere.Text = "Click Here!!";
            this.clickHere.UseVisualStyleBackColor = false;
            this.clickHere.Click += new System.EventHandler(this.button1_Click);
            // 
            // joinTheDarkSide
            // 
            this.joinTheDarkSide.AutoSize = true;
            this.joinTheDarkSide.BackColor = System.Drawing.Color.Red;
            this.joinTheDarkSide.Font = new System.Drawing.Font("Star Jedi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinTheDarkSide.Location = new System.Drawing.Point(323, 196);
            this.joinTheDarkSide.Name = "joinTheDarkSide";
            this.joinTheDarkSide.Size = new System.Drawing.Size(0, 32);
            this.joinTheDarkSide.TabIndex = 1;
            // 
            // useTheForce
            // 
            this.useTheForce.AutoSize = true;
            this.useTheForce.BackColor = System.Drawing.Color.Blue;
            this.useTheForce.Font = new System.Drawing.Font("Star Jedi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useTheForce.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.useTheForce.Location = new System.Drawing.Point(778, 387);
            this.useTheForce.Name = "useTheForce";
            this.useTheForce.Size = new System.Drawing.Size(0, 32);
            this.useTheForce.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1256, 621);
            this.Controls.Add(this.useTheForce);
            this.Controls.Add(this.joinTheDarkSide);
            this.Controls.Add(this.clickHere);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickHere;
        private System.Windows.Forms.Label joinTheDarkSide;
        private System.Windows.Forms.Label useTheForce;
    }
}

