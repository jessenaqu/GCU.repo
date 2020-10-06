namespace Milestone1
{
    partial class hotTopicInventory
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
            this.viewInventoryButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.editInventoryButton = new System.Windows.Forms.Button();
            this.addItemsButton = new System.Windows.Forms.Button();
            this.removeItemsButton = new System.Windows.Forms.Button();
            this.reorderItemsButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewInventoryButton
            // 
            this.viewInventoryButton.BackColor = System.Drawing.Color.LightCoral;
            this.viewInventoryButton.Font = new System.Drawing.Font("VCR OSD Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewInventoryButton.Location = new System.Drawing.Point(44, 39);
            this.viewInventoryButton.Name = "viewInventoryButton";
            this.viewInventoryButton.Size = new System.Drawing.Size(185, 35);
            this.viewInventoryButton.TabIndex = 0;
            this.viewInventoryButton.Text = "View Inventory ";
            this.viewInventoryButton.UseVisualStyleBackColor = false;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.LightCoral;
            this.searchButton.Font = new System.Drawing.Font("VCR OSD Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(655, 39);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(103, 35);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // editInventoryButton
            // 
            this.editInventoryButton.BackColor = System.Drawing.Color.LightCoral;
            this.editInventoryButton.Font = new System.Drawing.Font("VCR OSD Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editInventoryButton.Location = new System.Drawing.Point(44, 110);
            this.editInventoryButton.Name = "editInventoryButton";
            this.editInventoryButton.Size = new System.Drawing.Size(185, 35);
            this.editInventoryButton.TabIndex = 2;
            this.editInventoryButton.Text = "Edit Inventory";
            this.editInventoryButton.UseVisualStyleBackColor = false;
            this.editInventoryButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // addItemsButton
            // 
            this.addItemsButton.BackColor = System.Drawing.Color.LightCoral;
            this.addItemsButton.Font = new System.Drawing.Font("VCR OSD Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemsButton.Location = new System.Drawing.Point(44, 181);
            this.addItemsButton.Name = "addItemsButton";
            this.addItemsButton.Size = new System.Drawing.Size(185, 35);
            this.addItemsButton.TabIndex = 3;
            this.addItemsButton.Text = "Add Items";
            this.addItemsButton.UseVisualStyleBackColor = false;
            // 
            // removeItemsButton
            // 
            this.removeItemsButton.BackColor = System.Drawing.Color.LightCoral;
            this.removeItemsButton.Font = new System.Drawing.Font("VCR OSD Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItemsButton.Location = new System.Drawing.Point(44, 254);
            this.removeItemsButton.Name = "removeItemsButton";
            this.removeItemsButton.Size = new System.Drawing.Size(185, 35);
            this.removeItemsButton.TabIndex = 4;
            this.removeItemsButton.Text = "Remove Items";
            this.removeItemsButton.UseVisualStyleBackColor = false;
            // 
            // reorderItemsButton
            // 
            this.reorderItemsButton.BackColor = System.Drawing.Color.LightCoral;
            this.reorderItemsButton.Font = new System.Drawing.Font("VCR OSD Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorderItemsButton.Location = new System.Drawing.Point(44, 333);
            this.reorderItemsButton.Name = "reorderItemsButton";
            this.reorderItemsButton.Size = new System.Drawing.Size(185, 35);
            this.reorderItemsButton.TabIndex = 5;
            this.reorderItemsButton.Text = "Reorder Items";
            this.reorderItemsButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Milestone1.Properties.Resources.HotTopicLogo1;
            this.pictureBox1.Location = new System.Drawing.Point(441, 297);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 71);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // hotTopicInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(799, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reorderItemsButton);
            this.Controls.Add(this.removeItemsButton);
            this.Controls.Add(this.addItemsButton);
            this.Controls.Add(this.editInventoryButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.viewInventoryButton);
            this.Name = "hotTopicInventory";
            this.Text = "Hot Topic Inventory Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewInventoryButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button editInventoryButton;
        private System.Windows.Forms.Button addItemsButton;
        private System.Windows.Forms.Button removeItemsButton;
        private System.Windows.Forms.Button reorderItemsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

