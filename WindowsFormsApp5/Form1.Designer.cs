using System;

namespace WindowsFormsApp5
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reapplyToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleRMYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hueModifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hOGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sVMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skinToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.morphologyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reapplyToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reapplyToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.tophatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reapplyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilatationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reapplyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomHatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reapplyToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.blobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractBiggestBlobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homogenityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reapplyToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reapplyToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reapplyToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.differenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultGestureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.skinToolStripMenuItem1,
            this.morphologyToolStripMenuItem,
            this.edgeDetectionToolStripMenuItem,
            this.resizeToolStripMenuItem,
            this.resultGestureToolStripMenuItem,
            this.inputToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(851, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.openToolStripMenuItem.Text = "open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.saveToolStripMenuItem.Text = "save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayScaleToolStripMenuItem,
            this.sepiaToolStripMenuItem,
            this.grayScaleRMYToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.rGBToolStripMenuItem,
            this.hueModifierToolStripMenuItem,
            this.binarToolStripMenuItem,
            this.mergeToolStripMenuItem,
            this.hOGToolStripMenuItem,
            this.sVMToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            this.filterToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click);
            // 
            // grayScaleToolStripMenuItem
            // 
            this.grayScaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reapplyToolStripMenuItem7});
            this.grayScaleToolStripMenuItem.Name = "grayScaleToolStripMenuItem";
            this.grayScaleToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.grayScaleToolStripMenuItem.Text = "Gray scale";
            this.grayScaleToolStripMenuItem.Click += new System.EventHandler(this.grayScaleToolStripMenuItem_Click_1);
            // 
            // reapplyToolStripMenuItem7
            // 
            this.reapplyToolStripMenuItem7.Name = "reapplyToolStripMenuItem7";
            this.reapplyToolStripMenuItem7.Size = new System.Drawing.Size(121, 22);
            this.reapplyToolStripMenuItem7.Text = "Re-apply";
            this.reapplyToolStripMenuItem7.Click += new System.EventHandler(this.reapplyToolStripMenuItem7_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click_1);
            // 
            // grayScaleRMYToolStripMenuItem
            // 
            this.grayScaleRMYToolStripMenuItem.Name = "grayScaleRMYToolStripMenuItem";
            this.grayScaleRMYToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.grayScaleRMYToolStripMenuItem.Text = "Gray ScaleRMY";
            this.grayScaleRMYToolStripMenuItem.Click += new System.EventHandler(this.grayScaleRMYToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // rGBToolStripMenuItem
            // 
            this.rGBToolStripMenuItem.Name = "rGBToolStripMenuItem";
            this.rGBToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.rGBToolStripMenuItem.Text = "RGB";
            this.rGBToolStripMenuItem.Click += new System.EventHandler(this.rGBToolStripMenuItem_Click);
            // 
            // hueModifierToolStripMenuItem
            // 
            this.hueModifierToolStripMenuItem.Name = "hueModifierToolStripMenuItem";
            this.hueModifierToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.hueModifierToolStripMenuItem.Text = "Hue Modifier";
            this.hueModifierToolStripMenuItem.Click += new System.EventHandler(this.hueModifierToolStripMenuItem_Click);
            // 
            // binarToolStripMenuItem
            // 
            this.binarToolStripMenuItem.Name = "binarToolStripMenuItem";
            this.binarToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.binarToolStripMenuItem.Text = "Binarization";
            this.binarToolStripMenuItem.Click += new System.EventHandler(this.binarToolStripMenuItem_Click);
            // 
            // mergeToolStripMenuItem
            // 
            this.mergeToolStripMenuItem.Name = "mergeToolStripMenuItem";
            this.mergeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.mergeToolStripMenuItem.Text = "Merge";
            this.mergeToolStripMenuItem.Click += new System.EventHandler(this.mergeToolStripMenuItem_Click);
            // 
            // hOGToolStripMenuItem
            // 
            this.hOGToolStripMenuItem.Name = "hOGToolStripMenuItem";
            this.hOGToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.hOGToolStripMenuItem.Text = "HOEF";
            this.hOGToolStripMenuItem.Click += new System.EventHandler(this.hOGToolStripMenuItem_Click);
            // 
            // sVMToolStripMenuItem
            // 
            this.sVMToolStripMenuItem.Name = "sVMToolStripMenuItem";
            this.sVMToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.sVMToolStripMenuItem.Text = "SVM";
            this.sVMToolStripMenuItem.Click += new System.EventHandler(this.sVMToolStripMenuItem_Click);
            // 
            // skinToolStripMenuItem1
            // 
            this.skinToolStripMenuItem1.Name = "skinToolStripMenuItem1";
            this.skinToolStripMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.skinToolStripMenuItem1.Text = "Skin";
            this.skinToolStripMenuItem1.Click += new System.EventHandler(this.skinToolStripMenuItem1_Click);
            // 
            // morphologyToolStripMenuItem
            // 
            this.morphologyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openingToolStripMenuItem,
            this.closingToolStripMenuItem,
            this.tophatToolStripMenuItem,
            this.erosionToolStripMenuItem,
            this.dilatationToolStripMenuItem,
            this.bottomHatToolStripMenuItem,
            this.blobToolStripMenuItem});
            this.morphologyToolStripMenuItem.Name = "morphologyToolStripMenuItem";
            this.morphologyToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.morphologyToolStripMenuItem.Text = "morphology";
            // 
            // openingToolStripMenuItem
            // 
            this.openingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reapplyToolStripMenuItem2});
            this.openingToolStripMenuItem.Name = "openingToolStripMenuItem";
            this.openingToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.openingToolStripMenuItem.Text = "opening";
            this.openingToolStripMenuItem.Click += new System.EventHandler(this.openingToolStripMenuItem_Click);
            // 
            // reapplyToolStripMenuItem2
            // 
            this.reapplyToolStripMenuItem2.Name = "reapplyToolStripMenuItem2";
            this.reapplyToolStripMenuItem2.Size = new System.Drawing.Size(121, 22);
            this.reapplyToolStripMenuItem2.Text = "Re-apply";
            this.reapplyToolStripMenuItem2.Click += new System.EventHandler(this.reapplyToolStripMenuItem2_Click);
            // 
            // closingToolStripMenuItem
            // 
            this.closingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reapplyToolStripMenuItem8});
            this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            this.closingToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.closingToolStripMenuItem.Text = "closing";
            this.closingToolStripMenuItem.Click += new System.EventHandler(this.closingToolStripMenuItem_Click);
            // 
            // reapplyToolStripMenuItem8
            // 
            this.reapplyToolStripMenuItem8.Name = "reapplyToolStripMenuItem8";
            this.reapplyToolStripMenuItem8.Size = new System.Drawing.Size(121, 22);
            this.reapplyToolStripMenuItem8.Text = "Re-apply";
            this.reapplyToolStripMenuItem8.Click += new System.EventHandler(this.reapplyToolStripMenuItem8_Click);
            // 
            // tophatToolStripMenuItem
            // 
            this.tophatToolStripMenuItem.Name = "tophatToolStripMenuItem";
            this.tophatToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.tophatToolStripMenuItem.Text = "Tophat";
            this.tophatToolStripMenuItem.Click += new System.EventHandler(this.tophatToolStripMenuItem_Click);
            // 
            // erosionToolStripMenuItem
            // 
            this.erosionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reapplyToolStripMenuItem});
            this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            this.erosionToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.erosionToolStripMenuItem.Text = "Erosion";
            this.erosionToolStripMenuItem.Click += new System.EventHandler(this.erosionToolStripMenuItem_Click);
            // 
            // reapplyToolStripMenuItem
            // 
            this.reapplyToolStripMenuItem.Name = "reapplyToolStripMenuItem";
            this.reapplyToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.reapplyToolStripMenuItem.Text = "Re-apply";
            this.reapplyToolStripMenuItem.Click += new System.EventHandler(this.reapplyToolStripMenuItem_Click);
            // 
            // dilatationToolStripMenuItem
            // 
            this.dilatationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reapplyToolStripMenuItem1});
            this.dilatationToolStripMenuItem.Name = "dilatationToolStripMenuItem";
            this.dilatationToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.dilatationToolStripMenuItem.Text = "Dilatation";
            this.dilatationToolStripMenuItem.Click += new System.EventHandler(this.dilatationToolStripMenuItem_Click);
            // 
            // reapplyToolStripMenuItem1
            // 
            this.reapplyToolStripMenuItem1.Name = "reapplyToolStripMenuItem1";
            this.reapplyToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.reapplyToolStripMenuItem1.Text = "Re-apply";
            this.reapplyToolStripMenuItem1.Click += new System.EventHandler(this.reapplyToolStripMenuItem1_Click);
            // 
            // bottomHatToolStripMenuItem
            // 
            this.bottomHatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reapplyToolStripMenuItem3});
            this.bottomHatToolStripMenuItem.Name = "bottomHatToolStripMenuItem";
            this.bottomHatToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.bottomHatToolStripMenuItem.Text = "Bottom Hat";
            this.bottomHatToolStripMenuItem.Click += new System.EventHandler(this.bottomHatToolStripMenuItem_Click);
            // 
            // reapplyToolStripMenuItem3
            // 
            this.reapplyToolStripMenuItem3.Name = "reapplyToolStripMenuItem3";
            this.reapplyToolStripMenuItem3.Size = new System.Drawing.Size(121, 22);
            this.reapplyToolStripMenuItem3.Text = "Re-apply";
            this.reapplyToolStripMenuItem3.Click += new System.EventHandler(this.reapplyToolStripMenuItem3_Click);
            // 
            // blobToolStripMenuItem
            // 
            this.blobToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractBiggestBlobToolStripMenuItem,
            this.coToolStripMenuItem});
            this.blobToolStripMenuItem.Name = "blobToolStripMenuItem";
            this.blobToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.blobToolStripMenuItem.Text = "Blob";
            this.blobToolStripMenuItem.Click += new System.EventHandler(this.blobToolStripMenuItem_Click);
            // 
            // extractBiggestBlobToolStripMenuItem
            // 
            this.extractBiggestBlobToolStripMenuItem.Name = "extractBiggestBlobToolStripMenuItem";
            this.extractBiggestBlobToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.extractBiggestBlobToolStripMenuItem.Text = "Extract Biggest Blob";
            this.extractBiggestBlobToolStripMenuItem.Click += new System.EventHandler(this.extractBiggestBlobToolStripMenuItem_Click);
            // 
            // coToolStripMenuItem
            // 
            this.coToolStripMenuItem.Name = "coToolStripMenuItem";
            this.coToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.coToolStripMenuItem.Text = "Connected Component Labelling";
            this.coToolStripMenuItem.Click += new System.EventHandler(this.coToolStripMenuItem_Click);
            // 
            // edgeDetectionToolStripMenuItem
            // 
            this.edgeDetectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homogenityToolStripMenuItem,
            this.sobolToolStripMenuItem,
            this.cannyToolStripMenuItem,
            this.differenceToolStripMenuItem});
            this.edgeDetectionToolStripMenuItem.Name = "edgeDetectionToolStripMenuItem";
            this.edgeDetectionToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.edgeDetectionToolStripMenuItem.Text = "Edge Detection";
            // 
            // homogenityToolStripMenuItem
            // 
            this.homogenityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reapplyToolStripMenuItem4});
            this.homogenityToolStripMenuItem.Name = "homogenityToolStripMenuItem";
            this.homogenityToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.homogenityToolStripMenuItem.Text = "Homogenity";
            this.homogenityToolStripMenuItem.Click += new System.EventHandler(this.homogenityToolStripMenuItem_Click);
            // 
            // reapplyToolStripMenuItem4
            // 
            this.reapplyToolStripMenuItem4.Name = "reapplyToolStripMenuItem4";
            this.reapplyToolStripMenuItem4.Size = new System.Drawing.Size(121, 22);
            this.reapplyToolStripMenuItem4.Text = "Re-apply";
            this.reapplyToolStripMenuItem4.Click += new System.EventHandler(this.reapplyToolStripMenuItem4_Click);
            // 
            // sobolToolStripMenuItem
            // 
            this.sobolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reapplyToolStripMenuItem5});
            this.sobolToolStripMenuItem.Name = "sobolToolStripMenuItem";
            this.sobolToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.sobolToolStripMenuItem.Text = "Sobel";
            this.sobolToolStripMenuItem.Click += new System.EventHandler(this.sobolToolStripMenuItem_Click);
            // 
            // reapplyToolStripMenuItem5
            // 
            this.reapplyToolStripMenuItem5.Name = "reapplyToolStripMenuItem5";
            this.reapplyToolStripMenuItem5.Size = new System.Drawing.Size(121, 22);
            this.reapplyToolStripMenuItem5.Text = "Re-apply";
            this.reapplyToolStripMenuItem5.Click += new System.EventHandler(this.reapplyToolStripMenuItem5_Click);
            // 
            // cannyToolStripMenuItem
            // 
            this.cannyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reapplyToolStripMenuItem6});
            this.cannyToolStripMenuItem.Name = "cannyToolStripMenuItem";
            this.cannyToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.cannyToolStripMenuItem.Text = "Canny";
            this.cannyToolStripMenuItem.Click += new System.EventHandler(this.cannyToolStripMenuItem_Click);
            // 
            // reapplyToolStripMenuItem6
            // 
            this.reapplyToolStripMenuItem6.Name = "reapplyToolStripMenuItem6";
            this.reapplyToolStripMenuItem6.Size = new System.Drawing.Size(121, 22);
            this.reapplyToolStripMenuItem6.Text = "Re-apply";
            this.reapplyToolStripMenuItem6.Click += new System.EventHandler(this.reapplyToolStripMenuItem6_Click);
            // 
            // differenceToolStripMenuItem
            // 
            this.differenceToolStripMenuItem.Name = "differenceToolStripMenuItem";
            this.differenceToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.differenceToolStripMenuItem.Text = "Difference";
            this.differenceToolStripMenuItem.Click += new System.EventHandler(this.differenceToolStripMenuItem_Click);
            // 
            // resizeToolStripMenuItem
            // 
            this.resizeToolStripMenuItem.Name = "resizeToolStripMenuItem";
            this.resizeToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.resizeToolStripMenuItem.Text = "Resize";
            this.resizeToolStripMenuItem.Click += new System.EventHandler(this.resizeToolStripMenuItem_Click);
            // 
            // resultGestureToolStripMenuItem
            // 
            this.resultGestureToolStripMenuItem.Name = "resultGestureToolStripMenuItem";
            this.resultGestureToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.resultGestureToolStripMenuItem.Text = "Result Gesture";
            this.resultGestureToolStripMenuItem.Click += new System.EventHandler(this.resultGestureToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(445, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(406, 326);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 353);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void skinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaleRMYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hueModifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skinToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morphologyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tophatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilatationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomHatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homogenityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cannyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reapplyToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem reapplyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reapplyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reapplyToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem reapplyToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem reapplyToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem reapplyToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem resizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractBiggestBlobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem differenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reapplyToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem mergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reapplyToolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem hOGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sVMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultGestureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
    }
}

