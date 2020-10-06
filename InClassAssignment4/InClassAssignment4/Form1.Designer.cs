namespace InClassAssignment4
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
            this.lblNumberOfSecondElapsed = new System.Windows.Forms.Label();
            this.txtSecondsElapsed = new System.Windows.Forms.TextBox();
            this.lblNumberOfDays = new System.Windows.Forms.Label();
            this.btnFindOut = new System.Windows.Forms.Button();
            this.listShape = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumberOfSecondElapsed
            // 
            this.lblNumberOfSecondElapsed.AutoSize = true;
            this.lblNumberOfSecondElapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfSecondElapsed.Location = new System.Drawing.Point(25, 51);
            this.lblNumberOfSecondElapsed.Name = "lblNumberOfSecondElapsed";
            this.lblNumberOfSecondElapsed.Size = new System.Drawing.Size(261, 25);
            this.lblNumberOfSecondElapsed.TabIndex = 1;
            this.lblNumberOfSecondElapsed.Text = "Number of Seconds Elapsed";
            // 
            // txtSecondsElapsed
            // 
            this.txtSecondsElapsed.Font = new System.Drawing.Font("VCR OSD Mono", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondsElapsed.Location = new System.Drawing.Point(292, 51);
            this.txtSecondsElapsed.Name = "txtSecondsElapsed";
            this.txtSecondsElapsed.Size = new System.Drawing.Size(100, 27);
            this.txtSecondsElapsed.TabIndex = 2;
            // 
            // lblNumberOfDays
            // 
            this.lblNumberOfDays.AutoSize = true;
            this.lblNumberOfDays.Font = new System.Drawing.Font("VCR OSD Mono", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDays.Location = new System.Drawing.Point(424, 54);
            this.lblNumberOfDays.Name = "lblNumberOfDays";
            this.lblNumberOfDays.Size = new System.Drawing.Size(0, 20);
            this.lblNumberOfDays.TabIndex = 3;
            // 
            // btnFindOut
            // 
            this.btnFindOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindOut.Location = new System.Drawing.Point(329, 127);
            this.btnFindOut.Name = "btnFindOut";
            this.btnFindOut.Size = new System.Drawing.Size(158, 35);
            this.btnFindOut.TabIndex = 4;
            this.btnFindOut.Text = "Find Out!";
            this.btnFindOut.UseVisualStyleBackColor = true;
            this.btnFindOut.Click += new System.EventHandler(this.btnFindOut_Click);
            // 
            // listShape
            // 
            this.listShape.FormattingEnabled = true;
            this.listShape.Items.AddRange(new object[] {
            "Circle ",
            "Triangle ",
            "Recrangle",
            "Pentagon",
            "Hexagon"});
            this.listShape.Location = new System.Drawing.Point(89, 217);
            this.listShape.Name = "listShape";
            this.listShape.Size = new System.Drawing.Size(120, 95);
            this.listShape.TabIndex = 5;
            this.listShape.SelectedIndexChanged += new System.EventHandler(this.listShape_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(428, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 101);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 68);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(660, 246);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(660, 285);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listShape);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnFindOut);
            this.Controls.Add(this.lblNumberOfDays);
            this.Controls.Add(this.txtSecondsElapsed);
            this.Controls.Add(this.lblNumberOfSecondElapsed);
            this.Name = "Form1";
            this.Text = "In Class Assignment 4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumberOfSecondElapsed;
        private System.Windows.Forms.TextBox txtSecondsElapsed;
        private System.Windows.Forms.Label lblNumberOfDays;
        private System.Windows.Forms.Button btnFindOut;
        private System.Windows.Forms.ListBox listShape;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

