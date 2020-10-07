namespace Distance_Converter
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
            this.lblEnterConvert = new System.Windows.Forms.Label();
            this.lblDistanceConverted = new System.Windows.Forms.Label();
            this.txtDistanceEntered = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.grpBoxFrom = new System.Windows.Forms.GroupBox();
            this.listBoxFrom = new System.Windows.Forms.ListBox();
            this.grpBoxTo = new System.Windows.Forms.GroupBox();
            this.listBoxTo = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.txtDistanceConverted = new System.Windows.Forms.TextBox();
            this.grpBoxFrom.SuspendLayout();
            this.grpBoxTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnterConvert
            // 
            this.lblEnterConvert.AutoSize = true;
            this.lblEnterConvert.Font = new System.Drawing.Font("Gunplay", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterConvert.Location = new System.Drawing.Point(2, 9);
            this.lblEnterConvert.Name = "lblEnterConvert";
            this.lblEnterConvert.Size = new System.Drawing.Size(326, 20);
            this.lblEnterConvert.TabIndex = 0;
            this.lblEnterConvert.Text = "Enter a distance you would like to convert:";
            // 
            // lblDistanceConverted
            // 
            this.lblDistanceConverted.AutoSize = true;
            this.lblDistanceConverted.Font = new System.Drawing.Font("Gunplay", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistanceConverted.Location = new System.Drawing.Point(572, 116);
            this.lblDistanceConverted.Name = "lblDistanceConverted";
            this.lblDistanceConverted.Size = new System.Drawing.Size(210, 20);
            this.lblDistanceConverted.TabIndex = 1;
            this.lblDistanceConverted.Text = "Distance converted will be:";
            // 
            // txtDistanceEntered
            // 
            this.txtDistanceEntered.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDistanceEntered.Font = new System.Drawing.Font("Gunplay", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistanceEntered.Location = new System.Drawing.Point(334, 6);
            this.txtDistanceEntered.Name = "txtDistanceEntered";
            this.txtDistanceEntered.Size = new System.Drawing.Size(100, 27);
            this.txtDistanceEntered.TabIndex = 2;
            this.txtDistanceEntered.TextChanged += new System.EventHandler(this.txtDistanceEntered_TextChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConvert.Font = new System.Drawing.Font("Gunplay", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(694, 212);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(88, 33);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // grpBoxFrom
            // 
            this.grpBoxFrom.Controls.Add(this.listBoxFrom);
            this.grpBoxFrom.Font = new System.Drawing.Font("Gunplay", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxFrom.Location = new System.Drawing.Point(160, 70);
            this.grpBoxFrom.Name = "grpBoxFrom";
            this.grpBoxFrom.Size = new System.Drawing.Size(168, 175);
            this.grpBoxFrom.TabIndex = 4;
            this.grpBoxFrom.TabStop = false;
            this.grpBoxFrom.Text = "From";
            // 
            // listBoxFrom
            // 
            this.listBoxFrom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBoxFrom.Font = new System.Drawing.Font("Gunplay", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFrom.FormattingEnabled = true;
            this.listBoxFrom.ItemHeight = 20;
            this.listBoxFrom.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.listBoxFrom.Location = new System.Drawing.Point(23, 46);
            this.listBoxFrom.Name = "listBoxFrom";
            this.listBoxFrom.Size = new System.Drawing.Size(114, 84);
            this.listBoxFrom.TabIndex = 7;
            this.listBoxFrom.SelectedIndexChanged += new System.EventHandler(this.listBoxFrom_SelectedIndexChanged);
            // 
            // grpBoxTo
            // 
            this.grpBoxTo.Controls.Add(this.listBoxTo);
            this.grpBoxTo.Font = new System.Drawing.Font("Gunplay", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxTo.Location = new System.Drawing.Point(383, 70);
            this.grpBoxTo.Name = "grpBoxTo";
            this.grpBoxTo.Size = new System.Drawing.Size(168, 175);
            this.grpBoxTo.TabIndex = 5;
            this.grpBoxTo.TabStop = false;
            this.grpBoxTo.Text = "To";
            // 
            // listBoxTo
            // 
            this.listBoxTo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBoxTo.Font = new System.Drawing.Font("Gunplay", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTo.FormattingEnabled = true;
            this.listBoxTo.ItemHeight = 20;
            this.listBoxTo.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.listBoxTo.Location = new System.Drawing.Point(28, 46);
            this.listBoxTo.Name = "listBoxTo";
            this.listBoxTo.Size = new System.Drawing.Size(114, 84);
            this.listBoxTo.TabIndex = 8;
            this.listBoxTo.SelectedIndexChanged += new System.EventHandler(this.listBoxTo_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Gunplay", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(694, 431);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 33);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Gunplay", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(244, 287);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 8;
            // 
            // txtDistanceConverted
            // 
            this.txtDistanceConverted.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDistanceConverted.Font = new System.Drawing.Font("Gunplay", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistanceConverted.Location = new System.Drawing.Point(633, 162);
            this.txtDistanceConverted.Name = "txtDistanceConverted";
            this.txtDistanceConverted.Size = new System.Drawing.Size(100, 27);
            this.txtDistanceConverted.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Distance_Converter.Properties.Resources.distance_background_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 476);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.grpBoxTo);
            this.Controls.Add(this.grpBoxFrom);
            this.Controls.Add(this.txtDistanceConverted);
            this.Controls.Add(this.txtDistanceEntered);
            this.Controls.Add(this.lblDistanceConverted);
            this.Controls.Add(this.lblEnterConvert);
            this.Name = "Form1";
            this.Text = "Distance Convertor Form";
            this.grpBoxFrom.ResumeLayout(false);
            this.grpBoxTo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterConvert;
        private System.Windows.Forms.Label lblDistanceConverted;
        private System.Windows.Forms.TextBox txtDistanceEntered;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.GroupBox grpBoxFrom;
        private System.Windows.Forms.ListBox listBoxFrom;
        private System.Windows.Forms.GroupBox grpBoxTo;
        private System.Windows.Forms.ListBox listBoxTo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtDistanceConverted;
    }
}

