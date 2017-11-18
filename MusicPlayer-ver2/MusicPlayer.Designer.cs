namespace MusicPlayer_ver2
{
    partial class MusicPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.playBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.volBtn = new System.Windows.Forms.Button();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.songListView = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFromListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.removeFromListToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 48);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("infoToolStripMenuItem.Image")));
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.infoToolStripMenuItem.Text = "Properties";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playBtn.BackgroundImage")));
            this.playBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playBtn.FlatAppearance.BorderSize = 0;
            this.playBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.Location = new System.Drawing.Point(84, 341);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(27, 27);
            this.playBtn.TabIndex = 0;
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previousBtn.BackgroundImage")));
            this.previousBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previousBtn.FlatAppearance.BorderSize = 0;
            this.previousBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.previousBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousBtn.Location = new System.Drawing.Point(48, 341);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(27, 27);
            this.previousBtn.TabIndex = 1;
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextBtn.BackgroundImage")));
            this.nextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextBtn.FlatAppearance.BorderSize = 0;
            this.nextBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Location = new System.Drawing.Point(120, 341);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(27, 27);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.AutoEllipsis = true;
            this.stopBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stopBtn.BackgroundImage")));
            this.stopBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stopBtn.FlatAppearance.BorderSize = 0;
            this.stopBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Location = new System.Drawing.Point(12, 341);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(27, 27);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // volBtn
            // 
            this.volBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("volBtn.BackgroundImage")));
            this.volBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.volBtn.FlatAppearance.BorderSize = 0;
            this.volBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.volBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volBtn.Location = new System.Drawing.Point(156, 341);
            this.volBtn.Name = "volBtn";
            this.volBtn.Size = new System.Drawing.Size(27, 27);
            this.volBtn.TabIndex = 4;
            this.volBtn.UseVisualStyleBackColor = true;
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(1, 30);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(400, 301);
            this.player.TabIndex = 5;
            // 
            // songListView
            // 
            this.songListView.BackColor = System.Drawing.SystemColors.MenuText;
            this.songListView.ContextMenuStrip = this.contextMenuStrip1;
            this.songListView.ForeColor = System.Drawing.SystemColors.Menu;
            this.songListView.Location = new System.Drawing.Point(402, 24);
            this.songListView.Name = "songListView";
            this.songListView.Size = new System.Drawing.Size(260, 355);
            this.songListView.TabIndex = 7;
            this.songListView.UseCompatibleStateImageBehavior = false;
            this.songListView.View = System.Windows.Forms.View.Details;
            this.songListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.songListView_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.openBrowserToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.fileToolStripMenuItem.Text = "Media";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // openBrowserToolStripMenuItem
            // 
            this.openBrowserToolStripMenuItem.Name = "openBrowserToolStripMenuItem";
            this.openBrowserToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.openBrowserToolStripMenuItem.Text = "Open Browser";
            // 
            // removeFromListToolStripMenuItem
            // 
            this.removeFromListToolStripMenuItem.Name = "removeFromListToolStripMenuItem";
            this.removeFromListToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.removeFromListToolStripMenuItem.Text = "Remove from List";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(403, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Title";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(596, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Length";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(660, 376);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.songListView);
            this.Controls.Add(this.player);
            this.Controls.Add(this.volBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.playBtn);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MusicPlayer";
            this.Text = "MusicPlayer";
            this.Load += new System.EventHandler(this.MusicPlayer_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button volBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.ListView songListView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFromListToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

