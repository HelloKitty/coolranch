﻿using System.ComponentModel;
using System.Windows.Forms;

namespace CoolRanch
{
    partial class BrowserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.ServerList = new System.Windows.Forms.ListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gametypeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mapHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playersHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConnectButton = new System.Windows.Forms.Button();
            this.CancelBrowseButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ServerList
            // 
            this.ServerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.gametypeHeader,
            this.mapHeader,
            this.playersHeader});
            this.ServerList.FullRowSelect = true;
            this.ServerList.Location = new System.Drawing.Point(12, 12);
            this.ServerList.MultiSelect = false;
            this.ServerList.Name = "ServerList";
            this.ServerList.Size = new System.Drawing.Size(600, 268);
            this.ServerList.TabIndex = 0;
            this.ServerList.UseCompatibleStateImageBehavior = false;
            this.ServerList.View = System.Windows.Forms.View.Details;
            this.ServerList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ConnectToSelected);
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 320;
            // 
            // gametypeHeader
            // 
            this.gametypeHeader.Text = "Game type";
            this.gametypeHeader.Width = 90;
            // 
            // mapHeader
            // 
            this.mapHeader.Text = "Map";
            this.mapHeader.Width = 90;
            // 
            // playersHeader
            // 
            this.playersHeader.Text = "Players";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectButton.Location = new System.Drawing.Point(456, 286);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 1;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectToSelected);
            // 
            // CancelBrowseButton
            // 
            this.CancelBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBrowseButton.Location = new System.Drawing.Point(537, 286);
            this.CancelBrowseButton.Name = "CancelBrowseButton";
            this.CancelBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.CancelBrowseButton.TabIndex = 2;
            this.CancelBrowseButton.Text = "Cancel";
            this.CancelBrowseButton.UseVisualStyleBackColor = true;
            this.CancelBrowseButton.Click += new System.EventHandler(this.CancelBrowseButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RefreshButton.Location = new System.Drawing.Point(12, 286);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 3;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.statusLabel.Location = new System.Drawing.Point(93, 291);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(41, 13);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "(status)";
            // 
            // BrowserForm
            // 
            this.AcceptButton = this.ConnectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.CancelBrowseButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.ServerList);
            this.Icon = global::CoolRanch.Properties.Resources.Icon;
            this.Name = "BrowserForm";
            this.Text = "Lobby Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BrowserForm_FormClosing);
            this.Shown += new System.EventHandler(this.BrowserForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView ServerList;
        private ColumnHeader nameHeader;
        private ColumnHeader gametypeHeader;
        private ColumnHeader mapHeader;
        private ColumnHeader playersHeader;
        private Button ConnectButton;
        private Button CancelBrowseButton;
        private Button RefreshButton;
        private Label statusLabel;
    }
}