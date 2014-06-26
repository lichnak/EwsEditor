﻿namespace EWSEditor.Forms
{
    partial class TimeZonesForm
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
            this.btnServerTimeZone = new System.Windows.Forms.Button();
            this.cmboTimeZoneIds = new System.Windows.Forms.ComboBox();
            this.TimeZoneByIdString = new System.Windows.Forms.Button();
            this.btnListTimezones = new System.Windows.Forms.Button();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtServerTimezoneResults = new System.Windows.Forms.TextBox();
            this.dtStartTime = new System.Windows.Forms.DateTimePicker();
            this.tabTimeZones = new System.Windows.Forms.TabControl();
            this.tabExchangeServerTimeZone = new System.Windows.Forms.TabPage();
            this.tabClientTimeZones = new System.Windows.Forms.TabPage();
            this.lvMachineTimeZones = new System.Windows.Forms.ListView();
            this.tabClientTimezoneLookup = new System.Windows.Forms.TabPage();
            this.txtTimeZoneLookupResults = new System.Windows.Forms.TextBox();
            this.tabClientCurrentTimeZone = new System.Windows.Forms.TabPage();
            this.txtClientCurrentTimezone = new System.Windows.Forms.TextBox();
            this.btnClientCurrentTimeZone = new System.Windows.Forms.Button();
            this.tabConvertTime = new System.Windows.Forms.TabPage();
            this.rdoNow = new System.Windows.Forms.RadioButton();
            this.txtTicks = new System.Windows.Forms.TextBox();
            this.rdoConvertByTicks = new System.Windows.Forms.RadioButton();
            this.rdoConvertByDateTime = new System.Windows.Forms.RadioButton();
            this.dtConvertStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtConvertStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblConversionResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConversionResults = new System.Windows.Forms.TextBox();
            this.txtToTimeZone = new System.Windows.Forms.TextBox();
            this.txtFromTimeZone = new System.Windows.Forms.TextBox();
            this.btnConvertTimezone = new System.Windows.Forms.Button();
            this.lblFromTZ = new System.Windows.Forms.Label();
            this.lblToTZ = new System.Windows.Forms.Label();
            this.cmboToTimeZone = new System.Windows.Forms.ComboBox();
            this.cmboFromTimeZone = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConversionDateInfo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabTimeZones.SuspendLayout();
            this.tabExchangeServerTimeZone.SuspendLayout();
            this.tabClientTimeZones.SuspendLayout();
            this.tabClientTimezoneLookup.SuspendLayout();
            this.tabClientCurrentTimeZone.SuspendLayout();
            this.tabConvertTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnServerTimeZone
            // 
            this.btnServerTimeZone.Location = new System.Drawing.Point(3, 3);
            this.btnServerTimeZone.Name = "btnServerTimeZone";
            this.btnServerTimeZone.Size = new System.Drawing.Size(156, 27);
            this.btnServerTimeZone.TabIndex = 34;
            this.btnServerTimeZone.Text = "Exchange Server TimeZone";
            this.btnServerTimeZone.UseVisualStyleBackColor = true;
            this.btnServerTimeZone.Click += new System.EventHandler(this.btnServerTimeZone_Click);
            // 
            // cmboTimeZoneIds
            // 
            this.cmboTimeZoneIds.FormattingEnabled = true;
            this.cmboTimeZoneIds.Location = new System.Drawing.Point(152, 12);
            this.cmboTimeZoneIds.Name = "cmboTimeZoneIds";
            this.cmboTimeZoneIds.Size = new System.Drawing.Size(380, 23);
            this.cmboTimeZoneIds.TabIndex = 33;
            this.cmboTimeZoneIds.SelectedIndexChanged += new System.EventHandler(this.cmboTimeZoneIds_SelectedIndexChanged);
            // 
            // TimeZoneByIdString
            // 
            this.TimeZoneByIdString.Location = new System.Drawing.Point(6, 6);
            this.TimeZoneByIdString.Name = "TimeZoneByIdString";
            this.TimeZoneByIdString.Size = new System.Drawing.Size(140, 27);
            this.TimeZoneByIdString.TabIndex = 32;
            this.TimeZoneByIdString.Text = "Find Timezone by ID string";
            this.TimeZoneByIdString.UseVisualStyleBackColor = true;
            this.TimeZoneByIdString.Click += new System.EventHandler(this.TimeZoneByIdString_Click);
            // 
            // btnListTimezones
            // 
            this.btnListTimezones.Location = new System.Drawing.Point(3, 3);
            this.btnListTimezones.Name = "btnListTimezones";
            this.btnListTimezones.Size = new System.Drawing.Size(156, 27);
            this.btnListTimezones.TabIndex = 31;
            this.btnListTimezones.Text = "List ";
            this.btnListTimezones.UseVisualStyleBackColor = true;
            this.btnListTimezones.Click += new System.EventHandler(this.btnListTimezones_Click);
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(538, 13);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtStartDate.TabIndex = 35;
            this.dtStartDate.ValueChanged += new System.EventHandler(this.dtStartDate_ValueChanged);
            // 
            // txtServerTimezoneResults
            // 
            this.txtServerTimezoneResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerTimezoneResults.Location = new System.Drawing.Point(3, 36);
            this.txtServerTimezoneResults.Multiline = true;
            this.txtServerTimezoneResults.Name = "txtServerTimezoneResults";
            this.txtServerTimezoneResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtServerTimezoneResults.Size = new System.Drawing.Size(866, 466);
            this.txtServerTimezoneResults.TabIndex = 36;
            this.txtServerTimezoneResults.WordWrap = false;
            // 
            // dtStartTime
            // 
            this.dtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtStartTime.Location = new System.Drawing.Point(744, 13);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.Size = new System.Drawing.Size(135, 22);
            this.dtStartTime.TabIndex = 37;
            this.dtStartTime.ValueChanged += new System.EventHandler(this.dtStartTime_ValueChanged);
            // 
            // tabTimeZones
            // 
            this.tabTimeZones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabTimeZones.Controls.Add(this.tabExchangeServerTimeZone);
            this.tabTimeZones.Controls.Add(this.tabClientTimeZones);
            this.tabTimeZones.Controls.Add(this.tabClientTimezoneLookup);
            this.tabTimeZones.Controls.Add(this.tabClientCurrentTimeZone);
            this.tabTimeZones.Controls.Add(this.tabConvertTime);
            this.tabTimeZones.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.tabTimeZones.Location = new System.Drawing.Point(7, 12);
            this.tabTimeZones.Name = "tabTimeZones";
            this.tabTimeZones.SelectedIndex = 0;
            this.tabTimeZones.Size = new System.Drawing.Size(974, 593);
            this.tabTimeZones.TabIndex = 38;
            // 
            // tabExchangeServerTimeZone
            // 
            this.tabExchangeServerTimeZone.Controls.Add(this.btnServerTimeZone);
            this.tabExchangeServerTimeZone.Controls.Add(this.txtServerTimezoneResults);
            this.tabExchangeServerTimeZone.Location = new System.Drawing.Point(4, 24);
            this.tabExchangeServerTimeZone.Name = "tabExchangeServerTimeZone";
            this.tabExchangeServerTimeZone.Size = new System.Drawing.Size(966, 565);
            this.tabExchangeServerTimeZone.TabIndex = 2;
            this.tabExchangeServerTimeZone.Text = "Exchange Server TimeZone";
            this.tabExchangeServerTimeZone.UseVisualStyleBackColor = true;
            // 
            // tabClientTimeZones
            // 
            this.tabClientTimeZones.Controls.Add(this.lvMachineTimeZones);
            this.tabClientTimeZones.Controls.Add(this.btnListTimezones);
            this.tabClientTimeZones.Location = new System.Drawing.Point(4, 24);
            this.tabClientTimeZones.Name = "tabClientTimeZones";
            this.tabClientTimeZones.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientTimeZones.Size = new System.Drawing.Size(966, 565);
            this.tabClientTimeZones.TabIndex = 0;
            this.tabClientTimeZones.Text = "Client TimeZones";
            this.tabClientTimeZones.UseVisualStyleBackColor = true;
            // 
            // lvMachineTimeZones
            // 
            this.lvMachineTimeZones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvMachineTimeZones.Location = new System.Drawing.Point(0, 36);
            this.lvMachineTimeZones.Name = "lvMachineTimeZones";
            this.lvMachineTimeZones.Size = new System.Drawing.Size(887, 450);
            this.lvMachineTimeZones.TabIndex = 32;
            this.lvMachineTimeZones.UseCompatibleStateImageBehavior = false;
            // 
            // tabClientTimezoneLookup
            // 
            this.tabClientTimezoneLookup.Controls.Add(this.txtTimeZoneLookupResults);
            this.tabClientTimezoneLookup.Controls.Add(this.TimeZoneByIdString);
            this.tabClientTimezoneLookup.Controls.Add(this.dtStartTime);
            this.tabClientTimezoneLookup.Controls.Add(this.cmboTimeZoneIds);
            this.tabClientTimezoneLookup.Controls.Add(this.dtStartDate);
            this.tabClientTimezoneLookup.Location = new System.Drawing.Point(4, 24);
            this.tabClientTimezoneLookup.Name = "tabClientTimezoneLookup";
            this.tabClientTimezoneLookup.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientTimezoneLookup.Size = new System.Drawing.Size(966, 565);
            this.tabClientTimezoneLookup.TabIndex = 1;
            this.tabClientTimezoneLookup.Text = "Client Timezone Lookup";
            this.tabClientTimezoneLookup.UseVisualStyleBackColor = true;
            // 
            // txtTimeZoneLookupResults
            // 
            this.txtTimeZoneLookupResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeZoneLookupResults.Location = new System.Drawing.Point(0, 39);
            this.txtTimeZoneLookupResults.Multiline = true;
            this.txtTimeZoneLookupResults.Name = "txtTimeZoneLookupResults";
            this.txtTimeZoneLookupResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTimeZoneLookupResults.Size = new System.Drawing.Size(890, 450);
            this.txtTimeZoneLookupResults.TabIndex = 38;
            this.txtTimeZoneLookupResults.WordWrap = false;
            // 
            // tabClientCurrentTimeZone
            // 
            this.tabClientCurrentTimeZone.Controls.Add(this.txtClientCurrentTimezone);
            this.tabClientCurrentTimeZone.Controls.Add(this.btnClientCurrentTimeZone);
            this.tabClientCurrentTimeZone.Location = new System.Drawing.Point(4, 24);
            this.tabClientCurrentTimeZone.Name = "tabClientCurrentTimeZone";
            this.tabClientCurrentTimeZone.Size = new System.Drawing.Size(963, 565);
            this.tabClientCurrentTimeZone.TabIndex = 3;
            this.tabClientCurrentTimeZone.Text = "Client Current TimeZone";
            this.tabClientCurrentTimeZone.UseVisualStyleBackColor = true;
            // 
            // txtClientCurrentTimezone
            // 
            this.txtClientCurrentTimezone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientCurrentTimezone.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientCurrentTimezone.Location = new System.Drawing.Point(3, 36);
            this.txtClientCurrentTimezone.Multiline = true;
            this.txtClientCurrentTimezone.Name = "txtClientCurrentTimezone";
            this.txtClientCurrentTimezone.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtClientCurrentTimezone.Size = new System.Drawing.Size(978, 498);
            this.txtClientCurrentTimezone.TabIndex = 37;
            this.txtClientCurrentTimezone.WordWrap = false;
            // 
            // btnClientCurrentTimeZone
            // 
            this.btnClientCurrentTimeZone.Location = new System.Drawing.Point(3, 3);
            this.btnClientCurrentTimeZone.Name = "btnClientCurrentTimeZone";
            this.btnClientCurrentTimeZone.Size = new System.Drawing.Size(156, 27);
            this.btnClientCurrentTimeZone.TabIndex = 35;
            this.btnClientCurrentTimeZone.Text = "Details";
            this.btnClientCurrentTimeZone.UseVisualStyleBackColor = true;
            this.btnClientCurrentTimeZone.Click += new System.EventHandler(this.btnClientCurrentTimeZone_Click);
            // 
            // tabConvertTime
            // 
            this.tabConvertTime.Controls.Add(this.label5);
            this.tabConvertTime.Controls.Add(this.txtConversionDateInfo);
            this.tabConvertTime.Controls.Add(this.label4);
            this.tabConvertTime.Controls.Add(this.label3);
            this.tabConvertTime.Controls.Add(this.label2);
            this.tabConvertTime.Controls.Add(this.rdoNow);
            this.tabConvertTime.Controls.Add(this.txtTicks);
            this.tabConvertTime.Controls.Add(this.rdoConvertByTicks);
            this.tabConvertTime.Controls.Add(this.rdoConvertByDateTime);
            this.tabConvertTime.Controls.Add(this.dtConvertStartTime);
            this.tabConvertTime.Controls.Add(this.dtConvertStartDate);
            this.tabConvertTime.Controls.Add(this.lblConversionResult);
            this.tabConvertTime.Controls.Add(this.label1);
            this.tabConvertTime.Controls.Add(this.txtConversionResults);
            this.tabConvertTime.Controls.Add(this.txtToTimeZone);
            this.tabConvertTime.Controls.Add(this.txtFromTimeZone);
            this.tabConvertTime.Controls.Add(this.btnConvertTimezone);
            this.tabConvertTime.Controls.Add(this.lblFromTZ);
            this.tabConvertTime.Controls.Add(this.lblToTZ);
            this.tabConvertTime.Controls.Add(this.cmboToTimeZone);
            this.tabConvertTime.Controls.Add(this.cmboFromTimeZone);
            this.tabConvertTime.Location = new System.Drawing.Point(4, 24);
            this.tabConvertTime.Name = "tabConvertTime";
            this.tabConvertTime.Padding = new System.Windows.Forms.Padding(3);
            this.tabConvertTime.Size = new System.Drawing.Size(966, 565);
            this.tabConvertTime.TabIndex = 4;
            this.tabConvertTime.Text = "Convert Time";
            this.tabConvertTime.UseVisualStyleBackColor = true;
            this.tabConvertTime.Click += new System.EventHandler(this.tabConvertTime_Click);
            // 
            // rdoNow
            // 
            this.rdoNow.AutoSize = true;
            this.rdoNow.Location = new System.Drawing.Point(56, 102);
            this.rdoNow.Name = "rdoNow";
            this.rdoNow.Size = new System.Drawing.Size(144, 19);
            this.rdoNow.TabIndex = 55;
            this.rdoNow.Text = "Current Machine Time";
            this.rdoNow.UseVisualStyleBackColor = true;
            this.rdoNow.CheckedChanged += new System.EventHandler(this.rdoNow_CheckedChanged);
            // 
            // txtTicks
            // 
            this.txtTicks.Location = new System.Drawing.Point(209, 74);
            this.txtTicks.Name = "txtTicks";
            this.txtTicks.Size = new System.Drawing.Size(414, 22);
            this.txtTicks.TabIndex = 54;
            // 
            // rdoConvertByTicks
            // 
            this.rdoConvertByTicks.AutoSize = true;
            this.rdoConvertByTicks.Location = new System.Drawing.Point(54, 77);
            this.rdoConvertByTicks.Name = "rdoConvertByTicks";
            this.rdoConvertByTicks.Size = new System.Drawing.Size(118, 19);
            this.rdoConvertByTicks.TabIndex = 53;
            this.rdoConvertByTicks.Text = "Convert By Ticks";
            this.rdoConvertByTicks.UseVisualStyleBackColor = true;
            // 
            // rdoConvertByDateTime
            // 
            this.rdoConvertByDateTime.AutoSize = true;
            this.rdoConvertByDateTime.Checked = true;
            this.rdoConvertByDateTime.Location = new System.Drawing.Point(56, 50);
            this.rdoConvertByDateTime.Name = "rdoConvertByDateTime";
            this.rdoConvertByDateTime.Size = new System.Drawing.Size(140, 19);
            this.rdoConvertByDateTime.TabIndex = 52;
            this.rdoConvertByDateTime.TabStop = true;
            this.rdoConvertByDateTime.Text = "Convert By DateTime";
            this.rdoConvertByDateTime.UseVisualStyleBackColor = true;
            // 
            // dtConvertStartTime
            // 
            this.dtConvertStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtConvertStartTime.Location = new System.Drawing.Point(488, 46);
            this.dtConvertStartTime.Name = "dtConvertStartTime";
            this.dtConvertStartTime.Size = new System.Drawing.Size(135, 22);
            this.dtConvertStartTime.TabIndex = 41;
            // 
            // dtConvertStartDate
            // 
            this.dtConvertStartDate.Location = new System.Drawing.Point(282, 46);
            this.dtConvertStartDate.Name = "dtConvertStartDate";
            this.dtConvertStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtConvertStartDate.TabIndex = 40;
            // 
            // lblConversionResult
            // 
            this.lblConversionResult.AutoSize = true;
            this.lblConversionResult.Location = new System.Drawing.Point(9, 410);
            this.lblConversionResult.Name = "lblConversionResult";
            this.lblConversionResult.Size = new System.Drawing.Size(41, 15);
            this.lblConversionResult.TabIndex = 51;
            this.lblConversionResult.Text = "Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 49;
            this.label1.Text = "Date/Time:";
            // 
            // txtConversionResults
            // 
            this.txtConversionResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConversionResults.Location = new System.Drawing.Point(25, 428);
            this.txtConversionResults.Multiline = true;
            this.txtConversionResults.Name = "txtConversionResults";
            this.txtConversionResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConversionResults.Size = new System.Drawing.Size(935, 131);
            this.txtConversionResults.TabIndex = 50;
            // 
            // txtToTimeZone
            // 
            this.txtToTimeZone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToTimeZone.Location = new System.Drawing.Point(25, 337);
            this.txtToTimeZone.Multiline = true;
            this.txtToTimeZone.Name = "txtToTimeZone";
            this.txtToTimeZone.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtToTimeZone.Size = new System.Drawing.Size(935, 70);
            this.txtToTimeZone.TabIndex = 48;
            // 
            // txtFromTimeZone
            // 
            this.txtFromTimeZone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFromTimeZone.Location = new System.Drawing.Point(25, 258);
            this.txtFromTimeZone.Multiline = true;
            this.txtFromTimeZone.Name = "txtFromTimeZone";
            this.txtFromTimeZone.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFromTimeZone.Size = new System.Drawing.Size(935, 58);
            this.txtFromTimeZone.TabIndex = 47;
            // 
            // btnConvertTimezone
            // 
            this.btnConvertTimezone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvertTimezone.Location = new System.Drawing.Point(820, 12);
            this.btnConvertTimezone.Name = "btnConvertTimezone";
            this.btnConvertTimezone.Size = new System.Drawing.Size(140, 27);
            this.btnConvertTimezone.TabIndex = 46;
            this.btnConvertTimezone.Text = "Convert Time";
            this.btnConvertTimezone.UseVisualStyleBackColor = true;
            this.btnConvertTimezone.Click += new System.EventHandler(this.btnConvertTimezone_Click);
            // 
            // lblFromTZ
            // 
            this.lblFromTZ.AutoSize = true;
            this.lblFromTZ.Location = new System.Drawing.Point(6, 137);
            this.lblFromTZ.Name = "lblFromTZ";
            this.lblFromTZ.Size = new System.Drawing.Size(94, 15);
            this.lblFromTZ.TabIndex = 45;
            this.lblFromTZ.Text = "From TimeZone:";
            // 
            // lblToTZ
            // 
            this.lblToTZ.AutoSize = true;
            this.lblToTZ.Location = new System.Drawing.Point(485, 137);
            this.lblToTZ.Name = "lblToTZ";
            this.lblToTZ.Size = new System.Drawing.Size(81, 15);
            this.lblToTZ.TabIndex = 44;
            this.lblToTZ.Text = "To TimeZone:";
            // 
            // cmboToTimeZone
            // 
            this.cmboToTimeZone.FormattingEnabled = true;
            this.cmboToTimeZone.Location = new System.Drawing.Point(572, 134);
            this.cmboToTimeZone.Name = "cmboToTimeZone";
            this.cmboToTimeZone.Size = new System.Drawing.Size(326, 23);
            this.cmboToTimeZone.TabIndex = 43;
            this.cmboToTimeZone.SelectedIndexChanged += new System.EventHandler(this.ToTimeZone_SelectedIndexChanged);
            // 
            // cmboFromTimeZone
            // 
            this.cmboFromTimeZone.FormattingEnabled = true;
            this.cmboFromTimeZone.Location = new System.Drawing.Point(122, 134);
            this.cmboFromTimeZone.Name = "cmboFromTimeZone";
            this.cmboFromTimeZone.Size = new System.Drawing.Size(326, 23);
            this.cmboFromTimeZone.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 56;
            this.label2.Text = "From Timezone Info:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 57;
            this.label3.Text = "To Timezone Info:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 58;
            this.label4.Text = "Date for conversion:";
            // 
            // txtConversionDateInfo
            // 
            this.txtConversionDateInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConversionDateInfo.Location = new System.Drawing.Point(25, 187);
            this.txtConversionDateInfo.Multiline = true;
            this.txtConversionDateInfo.Name = "txtConversionDateInfo";
            this.txtConversionDateInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConversionDateInfo.Size = new System.Drawing.Size(935, 52);
            this.txtConversionDateInfo.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 15);
            this.label5.TabIndex = 60;
            this.label5.Text = "Converstion Date Info:";
            // 
            // TimeZonesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 617);
            this.Controls.Add(this.tabTimeZones);
            this.Name = "TimeZonesForm";
            this.Text = "Time Zones ";
            this.Load += new System.EventHandler(this.TimeZonesForm_Load);
            this.tabTimeZones.ResumeLayout(false);
            this.tabExchangeServerTimeZone.ResumeLayout(false);
            this.tabExchangeServerTimeZone.PerformLayout();
            this.tabClientTimeZones.ResumeLayout(false);
            this.tabClientTimezoneLookup.ResumeLayout(false);
            this.tabClientTimezoneLookup.PerformLayout();
            this.tabClientCurrentTimeZone.ResumeLayout(false);
            this.tabClientCurrentTimeZone.PerformLayout();
            this.tabConvertTime.ResumeLayout(false);
            this.tabConvertTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnServerTimeZone;
        private System.Windows.Forms.ComboBox cmboTimeZoneIds;
        private System.Windows.Forms.Button TimeZoneByIdString;
        private System.Windows.Forms.Button btnListTimezones;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.TextBox txtServerTimezoneResults;
        private System.Windows.Forms.DateTimePicker dtStartTime;
        private System.Windows.Forms.TabControl tabTimeZones;
        private System.Windows.Forms.TabPage tabClientTimeZones;
        private System.Windows.Forms.TabPage tabClientTimezoneLookup;
        private System.Windows.Forms.TabPage tabExchangeServerTimeZone;
        private System.Windows.Forms.ListView lvMachineTimeZones;
        private System.Windows.Forms.TextBox txtTimeZoneLookupResults;
        private System.Windows.Forms.TabPage tabClientCurrentTimeZone;
        private System.Windows.Forms.TextBox txtClientCurrentTimezone;
        private System.Windows.Forms.Button btnClientCurrentTimeZone;
        private System.Windows.Forms.TabPage tabConvertTime;
        private System.Windows.Forms.Label lblFromTZ;
        private System.Windows.Forms.Label lblToTZ;
        private System.Windows.Forms.ComboBox cmboToTimeZone;
        private System.Windows.Forms.DateTimePicker dtConvertStartTime;
        private System.Windows.Forms.ComboBox cmboFromTimeZone;
        private System.Windows.Forms.DateTimePicker dtConvertStartDate;
        private System.Windows.Forms.Button btnConvertTimezone;
        private System.Windows.Forms.TextBox txtToTimeZone;
        private System.Windows.Forms.TextBox txtFromTimeZone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConversionResult;
        private System.Windows.Forms.TextBox txtConversionResults;
        private System.Windows.Forms.RadioButton rdoConvertByTicks;
        private System.Windows.Forms.RadioButton rdoConvertByDateTime;
        private System.Windows.Forms.TextBox txtTicks;
        private System.Windows.Forms.RadioButton rdoNow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConversionDateInfo;
    }
}