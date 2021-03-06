﻿using System;

namespace ARKBreedingStats.ocr
{
    partial class OCRControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OCRControl));
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.OCRDebugLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOCROutput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listBoxRecognized = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTemplate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonSaveOCR = new System.Windows.Forms.Button();
            this.nudWhiteTreshold = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSaveAsTemplate = new System.Windows.Forms.Button();
            this.labelMatching = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxLabelRectangles = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chkbSetAllStatLabels = new System.Windows.Forms.CheckBox();
            this.buttonLoadOCRTemplate = new System.Windows.Forms.Button();
            this.buttonLoadCalibrationImage = new System.Windows.Forms.Button();
            this.textBoxCalibrationText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.labelOCRFile = new System.Windows.Forms.Label();
            this.nudFontSizeCalibration = new ARKBreedingStats.uiControls.Nud();
            this.nudFontSize = new ARKBreedingStats.uiControls.Nud();
            this.ocrLetterEditTemplate = new ARKBreedingStats.ocr.OCRLetterEdit();
            this.ocrLetterEditRecognized = new ARKBreedingStats.ocr.OCRLetterEdit();
            this.nudHeightT = new ARKBreedingStats.uiControls.Nud();
            this.nudWidthL = new ARKBreedingStats.uiControls.Nud();
            this.nudHeight = new ARKBreedingStats.uiControls.Nud();
            this.nudWidth = new ARKBreedingStats.uiControls.Nud();
            this.nudY = new ARKBreedingStats.uiControls.Nud();
            this.nudX = new ARKBreedingStats.uiControls.Nud();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWhiteTreshold)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSizeCalibration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocrLetterEditTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocrLetterEditRecognized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeightT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidthL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            this.tableLayoutPanel4.Controls.Add(this.OCRDebugLayoutPanel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tabControl1, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(807, 726);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // OCRDebugLayoutPanel
            // 
            this.OCRDebugLayoutPanel.AllowDrop = true;
            this.OCRDebugLayoutPanel.AutoScroll = true;
            this.OCRDebugLayoutPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.OCRDebugLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OCRDebugLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.OCRDebugLayoutPanel.Name = "OCRDebugLayoutPanel";
            this.OCRDebugLayoutPanel.Size = new System.Drawing.Size(441, 720);
            this.OCRDebugLayoutPanel.TabIndex = 0;
            this.OCRDebugLayoutPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.OCRDebugLayoutPanel_DragDrop);
            this.OCRDebugLayoutPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.OCRDebugLayoutPanel_DragEnter);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(450, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(354, 720);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(346, 694);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "OCR Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(6, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(334, 122);
            this.label12.TabIndex = 6;
            this.label12.Text = resources.GetString("label12.Text");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelOCRFile);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.textBoxCalibrationText);
            this.tabPage2.Controls.Add(this.nudFontSizeCalibration);
            this.tabPage2.Controls.Add(this.buttonLoadCalibrationImage);
            this.tabPage2.Controls.Add(this.buttonLoadOCRTemplate);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtOCROutput);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.listBoxRecognized);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.buttonSaveOCR);
            this.tabPage2.Controls.Add(this.nudWhiteTreshold);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(346, 694);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 44);
            this.label3.TabIndex = 17;
            this.label3.Text = "Here you can edit the OCR-character-templates. Click on a recognized character in" +
    " the list on the right to see as which character it was read and to edit it.";
            // 
            // txtOCROutput
            // 
            this.txtOCROutput.Location = new System.Drawing.Point(6, 19);
            this.txtOCROutput.Multiline = true;
            this.txtOCROutput.Name = "txtOCROutput";
            this.txtOCROutput.Size = new System.Drawing.Size(287, 186);
            this.txtOCROutput.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "OCR Output";
            // 
            // listBoxRecognized
            // 
            this.listBoxRecognized.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxRecognized.FormattingEnabled = true;
            this.listBoxRecognized.Location = new System.Drawing.Point(299, 3);
            this.listBoxRecognized.Name = "listBoxRecognized";
            this.listBoxRecognized.Size = new System.Drawing.Size(44, 688);
            this.listBoxRecognized.TabIndex = 11;
            this.listBoxRecognized.SelectedIndexChanged += new System.EventHandler(this.listBoxRecognized_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudFontSize);
            this.groupBox1.Controls.Add(this.ocrLetterEditTemplate);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxTemplate);
            this.groupBox1.Location = new System.Drawing.Point(6, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 126);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Template";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Character";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "font size";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save template";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTemplate
            // 
            this.textBoxTemplate.Location = new System.Drawing.Point(71, 19);
            this.textBoxTemplate.MaxLength = 1;
            this.textBoxTemplate.Name = "textBoxTemplate";
            this.textBoxTemplate.Size = new System.Drawing.Size(59, 20);
            this.textBoxTemplate.TabIndex = 9;
            this.textBoxTemplate.TextChanged += new System.EventHandler(this.textBoxTemplate_TextChanged);
            this.textBoxTemplate.Enter += new System.EventHandler(this.textBoxTemplate_Enter);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(61, 515);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(227, 35);
            this.label13.TabIndex = 8;
            this.label13.Text = "White Threshold (increase if you increased gamma ingame)";
            // 
            // buttonSaveOCR
            // 
            this.buttonSaveOCR.Location = new System.Drawing.Point(142, 544);
            this.buttonSaveOCR.Name = "buttonSaveOCR";
            this.buttonSaveOCR.Size = new System.Drawing.Size(146, 23);
            this.buttonSaveOCR.TabIndex = 14;
            this.buttonSaveOCR.Text = "save OCR template";
            this.buttonSaveOCR.UseVisualStyleBackColor = true;
            this.buttonSaveOCR.Click += new System.EventHandler(this.buttonSaveOCR_Click);
            // 
            // nudWhiteTreshold
            // 
            this.nudWhiteTreshold.Location = new System.Drawing.Point(6, 518);
            this.nudWhiteTreshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudWhiteTreshold.Name = "nudWhiteTreshold";
            this.nudWhiteTreshold.Size = new System.Drawing.Size(49, 20);
            this.nudWhiteTreshold.TabIndex = 7;
            this.nudWhiteTreshold.Value = new decimal(new int[] {
            155,
            0,
            0,
            0});
            this.nudWhiteTreshold.ValueChanged += new System.EventHandler(this.nudWhiteTreshold_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSaveAsTemplate);
            this.groupBox2.Controls.Add(this.labelMatching);
            this.groupBox2.Controls.Add(this.ocrLetterEditRecognized);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(6, 387);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 125);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recognized";
            // 
            // buttonSaveAsTemplate
            // 
            this.buttonSaveAsTemplate.Location = new System.Drawing.Point(71, 16);
            this.buttonSaveAsTemplate.Name = "buttonSaveAsTemplate";
            this.buttonSaveAsTemplate.Size = new System.Drawing.Size(59, 36);
            this.buttonSaveAsTemplate.TabIndex = 15;
            this.buttonSaveAsTemplate.Text = "Save as template";
            this.buttonSaveAsTemplate.UseVisualStyleBackColor = true;
            this.buttonSaveAsTemplate.Click += new System.EventHandler(this.buttonSaveAsTemplate_Click);
            // 
            // labelMatching
            // 
            this.labelMatching.Location = new System.Drawing.Point(6, 16);
            this.labelMatching.Name = "labelMatching";
            this.labelMatching.Size = new System.Drawing.Size(59, 36);
            this.labelMatching.TabIndex = 14;
            this.labelMatching.Text = "match";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(71, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Copy to template";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(346, 694);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Labels";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkbSetAllStatLabels);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.nudHeightT);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.nudWidthL);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.nudHeight);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.nudWidth);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.nudY);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.nudX);
            this.groupBox4.Location = new System.Drawing.Point(6, 275);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(293, 181);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rectangle";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(281, 43);
            this.label8.TabIndex = 8;
            this.label8.Text = "The Height has to be the same for all texts in the same size. The text-baseline h" +
    "as to be exact in the same position for all labels with the same text-size.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Height";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Width";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "X";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxLabelRectangles);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 263);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Labelpositions";
            // 
            // listBoxLabelRectangles
            // 
            this.listBoxLabelRectangles.FormattingEnabled = true;
            this.listBoxLabelRectangles.Location = new System.Drawing.Point(6, 19);
            this.listBoxLabelRectangles.Name = "listBoxLabelRectangles";
            this.listBoxLabelRectangles.Size = new System.Drawing.Size(209, 238);
            this.listBoxLabelRectangles.TabIndex = 0;
            this.listBoxLabelRectangles.SelectedIndexChanged += new System.EventHandler(this.listBoxLabelRectangles_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(139, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Height-T";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Width-L";
            // 
            // chkbSetAllStatLabels
            // 
            this.chkbSetAllStatLabels.AutoSize = true;
            this.chkbSetAllStatLabels.Location = new System.Drawing.Point(6, 153);
            this.chkbSetAllStatLabels.Name = "chkbSetAllStatLabels";
            this.chkbSetAllStatLabels.Size = new System.Drawing.Size(206, 17);
            this.chkbSetAllStatLabels.TabIndex = 13;
            this.chkbSetAllStatLabels.Text = "Set Values (except Y) for all stat-labels";
            this.chkbSetAllStatLabels.UseVisualStyleBackColor = true;
            // 
            // buttonLoadOCRTemplate
            // 
            this.buttonLoadOCRTemplate.Location = new System.Drawing.Point(6, 544);
            this.buttonLoadOCRTemplate.Name = "buttonLoadOCRTemplate";
            this.buttonLoadOCRTemplate.Size = new System.Drawing.Size(130, 23);
            this.buttonLoadOCRTemplate.TabIndex = 18;
            this.buttonLoadOCRTemplate.Text = "load OCR template";
            this.buttonLoadOCRTemplate.UseVisualStyleBackColor = true;
            this.buttonLoadOCRTemplate.Click += new System.EventHandler(this.buttonLoadOCRTemplate_Click);
            // 
            // buttonLoadCalibrationImage
            // 
            this.buttonLoadCalibrationImage.Location = new System.Drawing.Point(6, 630);
            this.buttonLoadCalibrationImage.Name = "buttonLoadCalibrationImage";
            this.buttonLoadCalibrationImage.Size = new System.Drawing.Size(130, 23);
            this.buttonLoadCalibrationImage.TabIndex = 19;
            this.buttonLoadCalibrationImage.Text = "Calibrate from Font";
            this.buttonLoadCalibrationImage.UseVisualStyleBackColor = true;
            this.buttonLoadCalibrationImage.Click += new System.EventHandler(this.buttonLoadCalibrationImage_Click);
            // 
            // textBoxCalibrationText
            // 
            this.textBoxCalibrationText.Location = new System.Drawing.Point(142, 630);
            this.textBoxCalibrationText.Name = "textBoxCalibrationText";
            this.textBoxCalibrationText.Size = new System.Drawing.Size(146, 20);
            this.textBoxCalibrationText.TabIndex = 20;
            this.textBoxCalibrationText.Text = "!#$%&\'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqr" +
    "stuvwxyz{|}~";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(177, 658);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "font size";
            // 
            // labelOCRFile
            // 
            this.labelOCRFile.Location = new System.Drawing.Point(6, 570);
            this.labelOCRFile.Name = "labelOCRFile";
            this.labelOCRFile.Size = new System.Drawing.Size(287, 57);
            this.labelOCRFile.TabIndex = 21;
            this.labelOCRFile.Text = "label15";
            // 
            // nudFontSizeCalibration
            // 
            this.nudFontSizeCalibration.Location = new System.Drawing.Point(229, 656);
            this.nudFontSizeCalibration.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudFontSizeCalibration.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudFontSizeCalibration.Name = "nudFontSizeCalibration";
            this.nudFontSizeCalibration.Size = new System.Drawing.Size(59, 20);
            this.nudFontSizeCalibration.TabIndex = 16;
            this.nudFontSizeCalibration.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // nudFontSize
            // 
            this.nudFontSize.Location = new System.Drawing.Point(58, 100);
            this.nudFontSize.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudFontSize.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudFontSize.Name = "nudFontSize";
            this.nudFontSize.Size = new System.Drawing.Size(59, 20);
            this.nudFontSize.TabIndex = 13;
            this.nudFontSize.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudFontSize.ValueChanged += new System.EventHandler(this.nudFontSize_ValueChanged);
            // 
            // ocrLetterEditTemplate
            // 
            this.ocrLetterEditTemplate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ocrLetterEditTemplate.LetterArray = new uint[] {
        ((uint)(0u))};
            this.ocrLetterEditTemplate.Location = new System.Drawing.Point(136, 19);
            this.ocrLetterEditTemplate.Name = "ocrLetterEditTemplate";
            this.ocrLetterEditTemplate.Size = new System.Drawing.Size(100, 100);
            this.ocrLetterEditTemplate.TabIndex = 12;
            this.ocrLetterEditTemplate.TabStop = false;
            // 
            // ocrLetterEditRecognized
            // 
            this.ocrLetterEditRecognized.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ocrLetterEditRecognized.LetterArray = new uint[] {
        ((uint)(0u))};
            this.ocrLetterEditRecognized.Location = new System.Drawing.Point(136, 16);
            this.ocrLetterEditRecognized.Name = "ocrLetterEditRecognized";
            this.ocrLetterEditRecognized.Size = new System.Drawing.Size(100, 100);
            this.ocrLetterEditRecognized.TabIndex = 13;
            this.ocrLetterEditRecognized.TabStop = false;
            // 
            // nudHeightT
            // 
            this.nudHeightT.Location = new System.Drawing.Point(193, 117);
            this.nudHeightT.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudHeightT.Name = "nudHeightT";
            this.nudHeightT.Size = new System.Drawing.Size(77, 20);
            this.nudHeightT.TabIndex = 11;
            this.nudHeightT.ValueChanged += new System.EventHandler(this.nudHeightT_ValueChanged);
            // 
            // nudWidthL
            // 
            this.nudWidthL.Location = new System.Drawing.Point(56, 117);
            this.nudWidthL.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudWidthL.Name = "nudWidthL";
            this.nudWidthL.Size = new System.Drawing.Size(77, 20);
            this.nudWidthL.TabIndex = 9;
            this.nudWidthL.ValueChanged += new System.EventHandler(this.nudWidthL_ValueChanged);
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(193, 91);
            this.nudHeight.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(77, 20);
            this.nudHeight.TabIndex = 6;
            this.nudHeight.ValueChanged += new System.EventHandler(this.nudHeight_ValueChanged);
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(56, 91);
            this.nudWidth.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(77, 20);
            this.nudWidth.TabIndex = 4;
            this.nudWidth.ValueChanged += new System.EventHandler(this.nudWidth_ValueChanged);
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(193, 65);
            this.nudY.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(77, 20);
            this.nudY.TabIndex = 2;
            this.nudY.ValueChanged += new System.EventHandler(this.nudY_ValueChanged);
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(56, 65);
            this.nudX.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(77, 20);
            this.nudX.TabIndex = 0;
            this.nudX.ValueChanged += new System.EventHandler(this.nudX_ValueChanged);
            // 
            // OCRControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "OCRControl";
            this.Size = new System.Drawing.Size(807, 726);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWhiteTreshold)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSizeCalibration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocrLetterEditTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocrLetterEditRecognized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeightT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidthL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel OCRDebugLayoutPanel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBoxRecognized;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxTemplate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private OCRLetterEdit ocrLetterEditTemplate;
        private OCRLetterEdit ocrLetterEditRecognized;
        private System.Windows.Forms.Label label1;
        private uiControls.Nud nudFontSize;
        private System.Windows.Forms.Button buttonSaveOCR;
        private System.Windows.Forms.Label labelMatching;
        private System.Windows.Forms.Button buttonSaveAsTemplate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudWhiteTreshold;
        private System.Windows.Forms.TextBox txtOCROutput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxLabelRectangles;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private uiControls.Nud nudHeight;
        private System.Windows.Forms.Label label6;
        private uiControls.Nud nudWidth;
        private System.Windows.Forms.Label label5;
        private uiControls.Nud nudY;
        private System.Windows.Forms.Label label4;
        private uiControls.Nud nudX;
        private System.Windows.Forms.CheckBox chkbSetAllStatLabels;
        private System.Windows.Forms.Label label9;
        private uiControls.Nud nudHeightT;
        private System.Windows.Forms.Label label10;
        private uiControls.Nud nudWidthL;
        private System.Windows.Forms.Button buttonLoadOCRTemplate;
        private System.Windows.Forms.Button buttonLoadCalibrationImage;
        private System.Windows.Forms.TextBox textBoxCalibrationText;
        private System.Windows.Forms.Label label14;
        private uiControls.Nud nudFontSizeCalibration;
        private System.Windows.Forms.Label labelOCRFile;
    }
}
