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
            this.listBoxGenre.Location = new System.Drawing.Point(86, 63);
            this.listBoxGenre.Name = "listBoxGenre";
            this.listBoxGenre.Size = new System.Drawing.Size(130, 148);
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
            this.animeGenre.Location = new System.Drawing.Point(85, 24);
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
            this.grpBoxAnimeSelect.Location = new System.Drawing.Point(86, 286);
            this.grpBoxAnimeSelect.Name = "grpBoxAnimeSelect";
            this.grpBoxAnimeSelect.Size = new System.Drawing.Size(161, 154);
            this.grpBoxAnimeSelect.TabIndex = 2;
            this.grpBoxAnimeSelect.TabStop = false;
            this.grpBoxAnimeSelect.Text = "Select an Anime";
            // 
            // btnAnime2
            // 
            this.btnAnime2.AutoSize = true;
            this.btnAnime2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAnime2.Location = new System.Drawing.Point(0, 89);
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
            this.btnAnime1.Location = new System.Drawing.Point(0, 43);
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
            this.grpBoxDetails.Location = new System.Drawing.Point(91, 461);
            this.grpBoxDetails.Name = "grpBoxDetails";
            this.grpBoxDetails.Size = new System.Drawing.Size(260, 83);
            this.grpBoxDetails.TabIndex = 4;
            this.grpBoxDetails.TabStop = false;
            this.grpBoxDetails.Text = "Anime Details";
            // 
            // ckBoxEpisodes
            // 
            this.ckBoxEpisodes.AutoSize = true;
            this.ckBoxEpisodes.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ckBoxEpisodes.Location = new System.Drawing.Point(131, 34);
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
            this.ckBoxName.Location = new System.Drawing.Point(6, 34);
            this.ckBoxName.Name = "ckBoxName";
            this.ckBoxName.Size = new System.Drawing.Size(79, 40);
            this.ckBoxName.TabIndex = 0;
            this.ckBoxName.Text = "Name";
            this.ckBoxName.UseVisualStyleBackColor = false;
            // 
            // btnDisplayAnime
            // 
            this.btnDisplayAnime.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAnime.Location = new System.Drawing.Point(548, 375);
            this.btnDisplayAnime.Name = "btnDisplayAnime";
            this.btnDisplayAnime.Size = new System.Drawing.Size(155, 36);
            this.btnDisplayAnime.TabIndex = 5;
            this.btnDisplayAnime.Text = "Display Anime";
            this.btnDisplayAnime.UseVisualStyleBackColor = true;
            this.btnDisplayAnime.Click += new System.EventHandler(this.btnDisplayAnime_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(799, 375);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(155, 36);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lblEpisodes
            // 
            this.lblEpisodes.AutoSize = true;
            this.lblEpisodes.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpisodes.Location = new System.Drawing.Point(720, 339);
            this.lblEpisodes.Name = "lblEpisodes";
            this.lblEpisodes.Size = new System.Drawing.Size(0, 36);
            this.lblEpisodes.TabIndex = 7;
            // 
            // lblAnimeName
            // 
            this.lblAnimeName.AutoSize = true;
            this.lblAnimeName.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimeName.Location = new System.Drawing.Point(720, 303);
            this.lblAnimeName.Name = "lblAnimeName";
            this.lblAnimeName.Size = new System.Drawing.Size(0, 36);
            this.lblAnimeName.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 547);
            this.Controls.Add(this.lblAnimeName);
            this.Controls.Add(this.lblEpisodes);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisplayAnime);
            this.Controls.Add(this.grpBoxDetails);
            this.Controls.Add(this.grpBoxAnimeSelect);
            this.Controls.Add(this.animeGenre);
            this.Controls.Add(this.listBoxGenre);
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
    }
}

