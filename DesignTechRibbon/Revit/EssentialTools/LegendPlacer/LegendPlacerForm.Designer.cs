﻿namespace DesignTechRibbon.Revit.EssentialTools.LegendPlacer
{
    partial class LegendPlacerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LegendPlacerForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSelectedCount = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.PlaceButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.designtechLogo = new System.Windows.Forms.PictureBox();
            this.groupBoxSelection = new System.Windows.Forms.GroupBox();
            this.DeselectAll = new System.Windows.Forms.Button();
            this.SelectAllSheets = new System.Windows.Forms.Button();
            this.LegendListBox = new System.Windows.Forms.ListBox();
            this.SheetListBox = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designtechLogo)).BeginInit();
            this.groupBoxSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelSelectedCount);
            this.groupBox1.Controls.Add(this.StatusLabel);
            this.groupBox1.Controls.Add(this.StopButton);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.closeButton);
            this.groupBox1.Controls.Add(this.designtechLogo);
            this.groupBox1.Controls.Add(this.groupBoxSelection);
            this.groupBox1.Controls.Add(this.LegendListBox);
            this.groupBox1.Controls.Add(this.SheetListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 540);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Legends";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sheet List";
            // 
            // labelSelectedCount
            // 
            this.labelSelectedCount.AutoSize = true;
            this.labelSelectedCount.Location = new System.Drawing.Point(488, 346);
            this.labelSelectedCount.Name = "labelSelectedCount";
            this.labelSelectedCount.Size = new System.Drawing.Size(115, 17);
            this.labelSelectedCount.TabIndex = 13;
            this.labelSelectedCount.Text = "Selected Sheets:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(365, 507);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(83, 17);
            this.StatusLabel.TabIndex = 12;
            this.StatusLabel.Text = "Please Wait";
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(343, 461);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(128, 38);
            this.StopButton.TabIndex = 11;
            this.StopButton.Text = "Cancel";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click_1);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 414);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(465, 39);
            this.progressBar1.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RemoveButton);
            this.groupBox2.Controls.Add(this.PlaceButton);
            this.groupBox2.Location = new System.Drawing.Point(491, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 148);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(28, 87);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(130, 39);
            this.RemoveButton.TabIndex = 6;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // PlaceButton
            // 
            this.PlaceButton.Location = new System.Drawing.Point(28, 32);
            this.PlaceButton.Name = "PlaceButton";
            this.PlaceButton.Size = new System.Drawing.Size(130, 39);
            this.PlaceButton.TabIndex = 5;
            this.PlaceButton.Text = "Place";
            this.PlaceButton.UseVisualStyleBackColor = true;
            this.PlaceButton.Click += new System.EventHandler(this.PlaceButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(551, 496);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(129, 38);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // designtechLogo
            // 
            this.designtechLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.designtechLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.designtechLogo.Image = ((System.Drawing.Image)(resources.GetObject("designtechLogo.Image")));
            this.designtechLogo.Location = new System.Drawing.Point(7, 461);
            this.designtechLogo.Margin = new System.Windows.Forms.Padding(4);
            this.designtechLogo.Name = "designtechLogo";
            this.designtechLogo.Size = new System.Drawing.Size(312, 73);
            this.designtechLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.designtechLogo.TabIndex = 6;
            this.designtechLogo.TabStop = false;
            // 
            // groupBoxSelection
            // 
            this.groupBoxSelection.Controls.Add(this.DeselectAll);
            this.groupBoxSelection.Controls.Add(this.SelectAllSheets);
            this.groupBoxSelection.Location = new System.Drawing.Point(491, 21);
            this.groupBoxSelection.Name = "groupBoxSelection";
            this.groupBoxSelection.Size = new System.Drawing.Size(179, 150);
            this.groupBoxSelection.TabIndex = 4;
            this.groupBoxSelection.TabStop = false;
            this.groupBoxSelection.Text = "Selection";
            // 
            // DeselectAll
            // 
            this.DeselectAll.Location = new System.Drawing.Point(28, 91);
            this.DeselectAll.Name = "DeselectAll";
            this.DeselectAll.Size = new System.Drawing.Size(130, 39);
            this.DeselectAll.TabIndex = 2;
            this.DeselectAll.Text = "None";
            this.DeselectAll.UseVisualStyleBackColor = true;
            this.DeselectAll.Click += new System.EventHandler(this.DeselectAll_Click);
            // 
            // SelectAllSheets
            // 
            this.SelectAllSheets.Location = new System.Drawing.Point(27, 36);
            this.SelectAllSheets.Name = "SelectAllSheets";
            this.SelectAllSheets.Size = new System.Drawing.Size(130, 39);
            this.SelectAllSheets.TabIndex = 0;
            this.SelectAllSheets.Text = "All Sheets";
            this.SelectAllSheets.UseVisualStyleBackColor = true;
            this.SelectAllSheets.Click += new System.EventHandler(this.SelectAllSheets_Click);
            // 
            // LegendListBox
            // 
            this.LegendListBox.FormattingEnabled = true;
            this.LegendListBox.HorizontalScrollbar = true;
            this.LegendListBox.ItemHeight = 16;
            this.LegendListBox.Location = new System.Drawing.Point(241, 37);
            this.LegendListBox.Name = "LegendListBox";
            this.LegendListBox.ScrollAlwaysVisible = true;
            this.LegendListBox.Size = new System.Drawing.Size(230, 372);
            this.LegendListBox.TabIndex = 1;
            // 
            // SheetListBox
            // 
            this.SheetListBox.FormattingEnabled = true;
            this.SheetListBox.HorizontalScrollbar = true;
            this.SheetListBox.ItemHeight = 16;
            this.SheetListBox.Location = new System.Drawing.Point(5, 37);
            this.SheetListBox.Name = "SheetListBox";
            this.SheetListBox.ScrollAlwaysVisible = true;
            this.SheetListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.SheetListBox.Size = new System.Drawing.Size(230, 372);
            this.SheetListBox.TabIndex = 0;
            this.SheetListBox.SelectedIndexChanged += new System.EventHandler(this.SheetListBox_SelectedIndexChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // LegendPlacerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 558);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LegendPlacerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Place Legends";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LegendPlacerForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.designtechLogo)).EndInit();
            this.groupBoxSelection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox LegendListBox;
        private System.Windows.Forms.ListBox SheetListBox;
        private System.Windows.Forms.Button PlaceButton;
        private System.Windows.Forms.GroupBox groupBoxSelection;
        private System.Windows.Forms.PictureBox designtechLogo;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button SelectAllSheets;
        private System.Windows.Forms.Button DeselectAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label labelSelectedCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}