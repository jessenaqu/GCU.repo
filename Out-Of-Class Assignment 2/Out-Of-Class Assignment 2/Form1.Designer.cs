namespace Out_Of_Class_Assignment_2
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
            this.listBoxGenre = new System.Windows.Forms.ListBox();
            this.animeGenre = new System.Windows.Forms.Label();
            this.grpBoxAnimeSelect = new System.Windows.Forms.GroupBox();
            this.btnAnime2 = new System.Windows.Forms.RadioButton();
            this.btnAnime1 = new System.Windows.Forms.RadioButton();
            this.grpBoxDetails = new System.Windows.Forms.GroupBox();
            this.ckBoxEpisodes = new System.Windows.Forms.CheckBox();
            this.ckBoxName = new System.Windows.Forms.CheckBox();
            this.btnDisplayAnime = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblEpisodes = new System.Windows.Forms.Label();
            this.lblAnimeName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBoxAnimeSelect.SuspendLayout();
            this.grpBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxGenre
            // 
            this.listBoxGenre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxGenre.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGenre.FormattingEnabled = true;
            this.listBoxGenre.ItemHeight = 36;
            this.listBoxGenre.Items.AddRange(new object[] {
            "Action ",
            "Drama",
            "Horror",
            "Romance",
            "Slice-of-Life"});
            this.listBoxGenre.Location = new System.Drawing.Point(115, 78);
            this.listBoxGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxGenre.Name = "listBoxGenre";
            this.listBoxGenre.Size = new System.Drawing.Size(172, 220);
            this.listBoxGenre.Sorted = true;
            this.listBoxGenre.TabIndex = 0;
            this.listBoxGenre.Tag = "";
            this.listBoxGenre.SelectedIndexChanged += new System.EventHandler(this.listBoxGenre_SelectedIndexChanged);
            // 
            // animeGenre
            // 
            this.animeGenre.AutoSize = true;
            this.animeGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.animeGenre.Font = new System.Drawing.Font("Javanese Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animeGenre.Location = new System.Drawing.Point(113, 30);
            this.animeGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.animeGenre.Name = "animeGenre";
            this.animeGenre.Size = new System.Drawing.Size(131, 36);
            this.animeGenre.TabIndex = 1;
            this.animeGenre.Text = "Select a Genre";
            // 
            // grpBoxAnimeSelect
            // 
            this.grpBoxAnimeSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grpBoxAnimeSelect.Controls.Add(this.btnAnime2);
            this.grpBoxAnimeSelect.Controls.Add(this.btnAnime1);
            this.grpBoxAnimeSelect.Font = new System.Drawing.Font("Javanese Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxAnimeSelect.Location = new System.Drawing.Point(115, 352);
            this.grpBoxAnimeSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxAnimeSelect.Name = "grpBoxAnimeSelect";
            this.grpBoxAnimeSelect.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxAnimeSelect.Size = new System.Drawing.Size(215, 190);
            this.grpBoxAnimeSelect.TabIndex = 2;
            this.grpBoxAnimeSelect.TabStop = false;
            this.grpBoxAnimeSelect.Text = "Select an Anime";
            // 
            // btnAnime2
            // 
            this.btnAnime2.AutoSize = true;
            this.btnAnime2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAnime2.Location = new System.Drawing.Point(0, 110);
            this.btnAnime2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnime2.Name = "btnAnime2";
            this.btnAnime2.Size = new System.Drawing.Size(14, 13);
            this.btnAnime2.TabIndex = 3;
            this.btnAnime2.TabStop = true;
            this.btnAnime2.UseVisualStyleBackColor = false;
            // 
            // btnAnime1
            // 
            this.btnAnime1.AutoSize = true;
            this.btnAnime1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAnime1.Location = new System.Drawing.Point(0, 53);
            this.btnAnime1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnime1.Name = "btnAnime1";
            this.btnAnime1.Size = new System.Drawing.Size(14, 13);
            this.btnAnime1.TabIndex = 3;
            this.btnAnime1.TabStop = true;
            this.btnAnime1.UseVisualStyleBackColor = false;
            // 
            // grpBoxDetails
            // 
            this.grpBoxDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grpBoxDetails.Controls.Add(this.ckBoxEpisodes);
            this.grpBoxDetails.Controls.Add(this.ckBoxName);
            this.grpBoxDetails.Font = new System.Drawing.Font("Javanese Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDetails.Location = new System.Drawing.Point(121, 567);
            this.grpBoxDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxDetails.Name = "grpBoxDetails";
            this.grpBoxDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxDetails.Size = new System.Drawing.Size(347, 102);
            this.grpBoxDetails.TabIndex = 4;
            this.grpBoxDetails.TabStop = false;
            this.grpBoxDetails.Text = "Anime Details";
            // 
            // ckBoxEpisodes
            // 
            this.ckBoxEpisodes.AutoSize = true;
            this.ckBoxEpisodes.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ckBoxEpisodes.Location = new System.Drawing.Point(175, 42);
            this.ckBoxEpisodes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckBoxEpisodes.Name = "ckBoxEpisodes";
            this.ckBoxEpisodes.Size = new System.Drawing.Size(106, 40);
            this.ckBoxEpisodes.TabIndex = 5;
            this.ckBoxEpisodes.Text = "Episodes";
            this.ckBoxEpisodes.UseVisualStyleBackColor = false;
            // 
            // ckBoxName
            // 
            this.ckBoxName.AutoSize = true;
            this.ckBoxName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ckBoxName.Location = new System.Drawing.Point(8, 42);
            this.ckBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckBoxName.Name = "ckBoxName";
            this.ckBoxName.Size = new System.Drawing.Size(79, 40);
            this.ckBoxName.TabIndex = 0;
            this.ckBoxName.Text = "Name";
            this.ckBoxName.UseVisualStyleBackColor = false;
            // 
            // btnDisplayAnime
            // 
            this.btnDisplayAnime.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAnime.Location = new System.Drawing.Point(731, 462);
            this.btnDisplayAnime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisplayAnime.Name = "btnDisplayAnime";
            this.btnDisplayAnime.Size = new System.Drawing.Size(207, 44);
            this.btnDisplayAnime.TabIndex = 5;
            this.btnDisplayAnime.Text = "Display Anime";
            this.btnDisplayAnime.UseVisualStyleBackColor = true;
            this.btnDisplayAnime.Click += new System.EventHandler(this.btnDisplayAnime_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1065, 462);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(207, 44);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lblEpisodes
            // 
            this.lblEpisodes.AutoSize = true;
            this.lblEpisodes.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpisodes.Location = new System.Drawing.Point(960, 417);
            this.lblEpisodes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEpisodes.Name = "lblEpisodes";
            this.lblEpisodes.Size = new System.Drawing.Size(0, 36);
            this.lblEpisodes.TabIndex = 7;
            // 
            // lblAnimeName
            // 
            this.lblAnimeName.AutoSize = true;
            this.lblAnimeName.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimeName.Location = new System.Drawing.Point(960, 373);
            this.lblAnimeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnimeName.Name = "lblAnimeName";
            this.lblAnimeName.Size = new System.Drawing.Size(0, 36);
            this.lblAnimeName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1413, 673);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAnimeName);
            this.Controls.Add(this.lblEpisodes);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisplayAnime);
            this.Controls.Add(this.grpBoxDetails);
            this.Controls.Add(this.grpBoxAnimeSelect);
            this.Controls.Add(this.animeGenre);
            this.Controls.Add(this.listBoxGenre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Anime Customizer";
            this.grpBoxAnimeSelect.ResumeLayout(false);
            this.grpBoxAnimeSelect.PerformLayout();
            this.grpBoxDetails.ResumeLayout(false);
            this.grpBoxDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGenre;
        private System.Windows.Forms.Label animeGenre;
        private System.Windows.Forms.GroupBox grpBoxAnimeSelect;
        private System.Windows.Forms.RadioButton btnAnime2;
        private System.Windows.Forms.RadioButton btnAnime1;
        private System.Windows.Forms.GroupBox grpBoxDetails;
        private System.Windows.Forms.CheckBox ckBoxEpisodes;
        private System.Windows.Forms.CheckBox ckBoxName;
        private System.Windows.Forms.Button btnDisplayAnime;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblEpisodes;
        private System.Windows.Forms.Label lblAnimeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

