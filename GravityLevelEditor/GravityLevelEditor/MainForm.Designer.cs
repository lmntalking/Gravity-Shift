﻿namespace GravityLevelEditor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mi_file = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_new = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_open = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.mi_save = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.mi_play = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_undo = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_redo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_view = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_zoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_zoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.buttonContainer1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.b_select = new System.Windows.Forms.ToolStripButton();
            this.b_multiselect = new System.Windows.Forms.ToolStripButton();
            this.b_addentity = new System.Windows.Forms.ToolStripButton();
            this.b_removeentity = new System.Windows.Forms.ToolStripButton();
            this.b_paint = new System.Windows.Forms.ToolStripButton();
            this.b_depaint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.tsc_MainContainer = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sc_Properties = new System.Windows.Forms.SplitContainer();
            this.sc_HorizontalProperties = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.b_ChangeEntity = new System.Windows.Forms.Button();
            this.pb_Entity = new System.Windows.Forms.PictureBox();
            this.b_bg = new System.Windows.Forms.Button();
            this.l_LevelProperties = new System.Windows.Forms.Label();
            this.pb_bg = new System.Windows.Forms.PictureBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.b_modifyLevel = new System.Windows.Forms.Button();
            this.lbl_levelName = new System.Windows.Forms.Label();
            this.lbl_rows = new System.Windows.Forms.Label();
            this.tb_cols = new System.Windows.Forms.TextBox();
            this.lbl_cols = new System.Windows.Forms.Label();
            this.tb_rows = new System.Windows.Forms.TextBox();
            this.time_updater = new System.Windows.Forms.Timer(this.components);
            this.menu.SuspendLayout();
            this.buttonContainer1.SuspendLayout();
            this.tsc_MainContainer.BottomToolStripPanel.SuspendLayout();
            this.tsc_MainContainer.ContentPanel.SuspendLayout();
            this.tsc_MainContainer.TopToolStripPanel.SuspendLayout();
            this.tsc_MainContainer.SuspendLayout();
            this.sc_Properties.Panel2.SuspendLayout();
            this.sc_Properties.SuspendLayout();
            this.sc_HorizontalProperties.Panel1.SuspendLayout();
            this.sc_HorizontalProperties.Panel2.SuspendLayout();
            this.sc_HorizontalProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Entity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bg)).BeginInit();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_file,
            this.mi_edit,
            this.mi_view});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1184, 29);
            this.menu.TabIndex = 0;
            this.menu.Text = "Menu";
            // 
            // mi_file
            // 
            this.mi_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_new,
            this.mi_open,
            this.closeToolStripMenuItem,
            this.mi_save,
            this.mi_saveAs,
            this.playToolStripMenuItem,
            this.mi_play,
            this.mi_quit});
            this.mi_file.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mi_file.Name = "mi_file";
            this.mi_file.Size = new System.Drawing.Size(46, 25);
            this.mi_file.Text = "&File";
            // 
            // mi_new
            // 
            this.mi_new.Name = "mi_new";
            this.mi_new.Size = new System.Drawing.Size(152, 26);
            this.mi_new.Text = "&New";
            this.mi_new.Click += new System.EventHandler(this.New);
            // 
            // mi_open
            // 
            this.mi_open.Name = "mi_open";
            this.mi_open.Size = new System.Drawing.Size(152, 26);
            this.mi_open.Text = "&Open";
            this.mi_open.Click += new System.EventHandler(this.Open);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // mi_save
            // 
            this.mi_save.Name = "mi_save";
            this.mi_save.Size = new System.Drawing.Size(152, 26);
            this.mi_save.Text = "&Save";
            this.mi_save.Click += new System.EventHandler(this.Save);
            // 
            // mi_saveAs
            // 
            this.mi_saveAs.Name = "mi_saveAs";
            this.mi_saveAs.Size = new System.Drawing.Size(152, 26);
            this.mi_saveAs.Text = "Save &As";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // mi_play
            // 
            this.mi_play.Name = "mi_play";
            this.mi_play.Size = new System.Drawing.Size(152, 26);
            this.mi_play.Text = "&Play!";
            this.mi_play.Click += new System.EventHandler(this.Play);
            // 
            // mi_quit
            // 
            this.mi_quit.Name = "mi_quit";
            this.mi_quit.Size = new System.Drawing.Size(152, 26);
            this.mi_quit.Text = "&Quit";
            this.mi_quit.Click += new System.EventHandler(this.Quit);
            // 
            // mi_edit
            // 
            this.mi_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_undo,
            this.mi_redo,
            this.toolStripMenuItem1,
            this.mi_cut,
            this.mi_copy,
            this.mi_paste});
            this.mi_edit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mi_edit.Name = "mi_edit";
            this.mi_edit.Size = new System.Drawing.Size(48, 25);
            this.mi_edit.Text = "&Edit";
            // 
            // mi_undo
            // 
            this.mi_undo.Name = "mi_undo";
            this.mi_undo.Size = new System.Drawing.Size(152, 26);
            this.mi_undo.Text = "&Undo";
            this.mi_undo.Click += new System.EventHandler(this.Undo);
            // 
            // mi_redo
            // 
            this.mi_redo.Name = "mi_redo";
            this.mi_redo.Size = new System.Drawing.Size(152, 26);
            this.mi_redo.Text = "&Redo";
            this.mi_redo.Click += new System.EventHandler(this.Redo);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // mi_cut
            // 
            this.mi_cut.Name = "mi_cut";
            this.mi_cut.Size = new System.Drawing.Size(152, 26);
            this.mi_cut.Text = "&Cut";
            this.mi_cut.Click += new System.EventHandler(this.Cut);
            // 
            // mi_copy
            // 
            this.mi_copy.Name = "mi_copy";
            this.mi_copy.Size = new System.Drawing.Size(152, 26);
            this.mi_copy.Text = "C&opy";
            this.mi_copy.Click += new System.EventHandler(this.Copy);
            // 
            // mi_paste
            // 
            this.mi_paste.Name = "mi_paste";
            this.mi_paste.Size = new System.Drawing.Size(152, 26);
            this.mi_paste.Text = "&Paste";
            this.mi_paste.Click += new System.EventHandler(this.Paste);
            // 
            // mi_view
            // 
            this.mi_view.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_zoomIn,
            this.mi_zoomOut});
            this.mi_view.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mi_view.Name = "mi_view";
            this.mi_view.Size = new System.Drawing.Size(56, 25);
            this.mi_view.Text = "&View";
            // 
            // mi_zoomIn
            // 
            this.mi_zoomIn.Name = "mi_zoomIn";
            this.mi_zoomIn.Size = new System.Drawing.Size(152, 26);
            this.mi_zoomIn.Text = "Zoom &In";
            this.mi_zoomIn.Click += new System.EventHandler(this.ZoomIn);
            // 
            // mi_zoomOut
            // 
            this.mi_zoomOut.Name = "mi_zoomOut";
            this.mi_zoomOut.Size = new System.Drawing.Size(152, 26);
            this.mi_zoomOut.Text = "Zoom &Out";
            this.mi_zoomOut.Click += new System.EventHandler(this.ZoomOut);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // buttonContainer1
            // 
            this.buttonContainer1.AutoSize = false;
            this.buttonContainer1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonContainer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonContainer1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.buttonContainer1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.buttonContainer1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.b_select,
            this.b_multiselect,
            this.b_addentity,
            this.b_removeentity,
            this.b_paint,
            this.b_depaint,
            this.toolStripSeparator2});
            this.buttonContainer1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.buttonContainer1.Location = new System.Drawing.Point(0, 0);
            this.buttonContainer1.Name = "buttonContainer1";
            this.buttonContainer1.Size = new System.Drawing.Size(56, 611);
            this.buttonContainer1.TabIndex = 0;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(54, 6);
            // 
            // b_select
            // 
            this.b_select.AutoSize = false;
            this.b_select.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.b_select.Image = global::GravityLevelEditor.Properties.Resources.select;
            this.b_select.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_select.Name = "b_select";
            this.b_select.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.b_select.Size = new System.Drawing.Size(48, 48);
            this.b_select.Text = "Select/Move";
            this.b_select.Click += new System.EventHandler(this.SelectTool);
            // 
            // b_multiselect
            // 
            this.b_multiselect.AutoSize = false;
            this.b_multiselect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.b_multiselect.Image = global::GravityLevelEditor.Properties.Resources.multiselect;
            this.b_multiselect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_multiselect.Name = "b_multiselect";
            this.b_multiselect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.b_multiselect.Size = new System.Drawing.Size(48, 48);
            this.b_multiselect.Text = "Multi-Select";
            this.b_multiselect.Click += new System.EventHandler(this.MultiSelectTool);
            // 
            // b_addentity
            // 
            this.b_addentity.AutoSize = false;
            this.b_addentity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.b_addentity.Image = global::GravityLevelEditor.Properties.Resources.addentity;
            this.b_addentity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_addentity.Name = "b_addentity";
            this.b_addentity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.b_addentity.Size = new System.Drawing.Size(48, 48);
            this.b_addentity.Text = "Add Entity";
            this.b_addentity.Click += new System.EventHandler(this.AddTool);
            // 
            // b_removeentity
            // 
            this.b_removeentity.AutoSize = false;
            this.b_removeentity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.b_removeentity.Image = global::GravityLevelEditor.Properties.Resources.removeentity;
            this.b_removeentity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_removeentity.Name = "b_removeentity";
            this.b_removeentity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.b_removeentity.Size = new System.Drawing.Size(48, 48);
            this.b_removeentity.Text = "Remove Entity";
            this.b_removeentity.Click += new System.EventHandler(this.RemoveTool);
            // 
            // b_paint
            // 
            this.b_paint.AutoSize = false;
            this.b_paint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.b_paint.Image = global::GravityLevelEditor.Properties.Resources.paint;
            this.b_paint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_paint.Name = "b_paint";
            this.b_paint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.b_paint.Size = new System.Drawing.Size(48, 48);
            this.b_paint.Text = "Paint Entity";
            // 
            // b_depaint
            // 
            this.b_depaint.AutoSize = false;
            this.b_depaint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.b_depaint.Image = global::GravityLevelEditor.Properties.Resources.depaint;
            this.b_depaint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_depaint.Name = "b_depaint";
            this.b_depaint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.b_depaint.Size = new System.Drawing.Size(48, 48);
            this.b_depaint.Text = "Unpaint Entity";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(54, 6);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(1160, 638);
            // 
            // tsc_MainContainer
            // 
            // 
            // tsc_MainContainer.BottomToolStripPanel
            // 
            this.tsc_MainContainer.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // tsc_MainContainer.ContentPanel
            // 
            this.tsc_MainContainer.ContentPanel.AutoScroll = true;
            this.tsc_MainContainer.ContentPanel.Controls.Add(this.sc_Properties);
            this.tsc_MainContainer.ContentPanel.Controls.Add(this.buttonContainer1);
            this.tsc_MainContainer.ContentPanel.Size = new System.Drawing.Size(1184, 611);
            this.tsc_MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsc_MainContainer.Location = new System.Drawing.Point(0, 0);
            this.tsc_MainContainer.Name = "tsc_MainContainer";
            this.tsc_MainContainer.Size = new System.Drawing.Size(1184, 662);
            this.tsc_MainContainer.TabIndex = 1;
            this.tsc_MainContainer.Text = "toolStripContainer1";
            // 
            // tsc_MainContainer.TopToolStripPanel
            // 
            this.tsc_MainContainer.TopToolStripPanel.Controls.Add(this.menu);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // sc_Properties
            // 
            this.sc_Properties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_Properties.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.sc_Properties.IsSplitterFixed = true;
            this.sc_Properties.Location = new System.Drawing.Point(56, 0);
            this.sc_Properties.Name = "sc_Properties";
            // 
            // sc_Properties.Panel1
            // 
            this.sc_Properties.Panel1.AutoScroll = true;
            this.sc_Properties.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.GridPaint);
            this.sc_Properties.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GridMouseMove);
            this.sc_Properties.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GridMouseDown);
            this.sc_Properties.Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GridMouseUp);
            this.sc_Properties.Panel1MinSize = 100;
            // 
            // sc_Properties.Panel2
            // 
            this.sc_Properties.Panel2.AutoScroll = true;
            this.sc_Properties.Panel2.Controls.Add(this.sc_HorizontalProperties);
            this.sc_Properties.Panel2MinSize = 100;
            this.sc_Properties.Size = new System.Drawing.Size(1128, 611);
            this.sc_Properties.SplitterDistance = 906;
            this.sc_Properties.TabIndex = 1;
            // 
            // sc_HorizontalProperties
            // 
            this.sc_HorizontalProperties.Dock = System.Windows.Forms.DockStyle.Right;
            this.sc_HorizontalProperties.Location = new System.Drawing.Point(3, 0);
            this.sc_HorizontalProperties.Name = "sc_HorizontalProperties";
            this.sc_HorizontalProperties.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sc_HorizontalProperties.Panel1
            // 
            this.sc_HorizontalProperties.Panel1.Controls.Add(this.label1);
            this.sc_HorizontalProperties.Panel1.Controls.Add(this.b_ChangeEntity);
            this.sc_HorizontalProperties.Panel1.Controls.Add(this.pb_Entity);
            // 
            // sc_HorizontalProperties.Panel2
            // 
            this.sc_HorizontalProperties.Panel2.Controls.Add(this.b_bg);
            this.sc_HorizontalProperties.Panel2.Controls.Add(this.l_LevelProperties);
            this.sc_HorizontalProperties.Panel2.Controls.Add(this.pb_bg);
            this.sc_HorizontalProperties.Panel2.Controls.Add(this.tb_name);
            this.sc_HorizontalProperties.Panel2.Controls.Add(this.b_modifyLevel);
            this.sc_HorizontalProperties.Panel2.Controls.Add(this.lbl_levelName);
            this.sc_HorizontalProperties.Panel2.Controls.Add(this.lbl_rows);
            this.sc_HorizontalProperties.Panel2.Controls.Add(this.tb_cols);
            this.sc_HorizontalProperties.Panel2.Controls.Add(this.lbl_cols);
            this.sc_HorizontalProperties.Panel2.Controls.Add(this.tb_rows);
            this.sc_HorizontalProperties.Size = new System.Drawing.Size(215, 611);
            this.sc_HorizontalProperties.SplitterDistance = 290;
            this.sc_HorizontalProperties.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entity Properties";
            // 
            // b_ChangeEntity
            // 
            this.b_ChangeEntity.Location = new System.Drawing.Point(97, 57);
            this.b_ChangeEntity.Name = "b_ChangeEntity";
            this.b_ChangeEntity.Size = new System.Drawing.Size(83, 27);
            this.b_ChangeEntity.TabIndex = 1;
            this.b_ChangeEntity.Text = "Change Entity";
            this.b_ChangeEntity.UseVisualStyleBackColor = true;
            // 
            // pb_Entity
            // 
            this.pb_Entity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_Entity.Location = new System.Drawing.Point(17, 36);
            this.pb_Entity.Name = "pb_Entity";
            this.pb_Entity.Size = new System.Drawing.Size(64, 64);
            this.pb_Entity.TabIndex = 0;
            this.pb_Entity.TabStop = false;
            // 
            // b_bg
            // 
            this.b_bg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.b_bg.Location = new System.Drawing.Point(33, 222);
            this.b_bg.Name = "b_bg";
            this.b_bg.Size = new System.Drawing.Size(143, 23);
            this.b_bg.TabIndex = 22;
            this.b_bg.Text = "Change Background";
            this.b_bg.UseVisualStyleBackColor = true;
            this.b_bg.Click += new System.EventHandler(this.ChangeBackground);
            // 
            // l_LevelProperties
            // 
            this.l_LevelProperties.AutoSize = true;
            this.l_LevelProperties.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_LevelProperties.Location = new System.Drawing.Point(23, 7);
            this.l_LevelProperties.Name = "l_LevelProperties";
            this.l_LevelProperties.Size = new System.Drawing.Size(175, 29);
            this.l_LevelProperties.TabIndex = 1;
            this.l_LevelProperties.Text = "Level Properties";
            // 
            // pb_bg
            // 
            this.pb_bg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pb_bg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_bg.Location = new System.Drawing.Point(29, 133);
            this.pb_bg.Name = "pb_bg";
            this.pb_bg.Size = new System.Drawing.Size(151, 83);
            this.pb_bg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_bg.TabIndex = 21;
            this.pb_bg.TabStop = false;
            // 
            // tb_name
            // 
            this.tb_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tb_name.Location = new System.Drawing.Point(47, 57);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(113, 20);
            this.tb_name.TabIndex = 20;
            this.tb_name.Text = "New Level";
            // 
            // b_modifyLevel
            // 
            this.b_modifyLevel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.b_modifyLevel.Location = new System.Drawing.Point(64, 273);
            this.b_modifyLevel.Name = "b_modifyLevel";
            this.b_modifyLevel.Size = new System.Drawing.Size(75, 23);
            this.b_modifyLevel.TabIndex = 13;
            this.b_modifyLevel.Text = "Apply!";
            this.b_modifyLevel.UseVisualStyleBackColor = true;
            this.b_modifyLevel.Click += new System.EventHandler(this.ApplyChanges);
            // 
            // lbl_levelName
            // 
            this.lbl_levelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_levelName.AutoSize = true;
            this.lbl_levelName.Location = new System.Drawing.Point(44, 41);
            this.lbl_levelName.Name = "lbl_levelName";
            this.lbl_levelName.Size = new System.Drawing.Size(35, 13);
            this.lbl_levelName.TabIndex = 19;
            this.lbl_levelName.Text = "Name";
            // 
            // lbl_rows
            // 
            this.lbl_rows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_rows.AutoSize = true;
            this.lbl_rows.Location = new System.Drawing.Point(44, 91);
            this.lbl_rows.Name = "lbl_rows";
            this.lbl_rows.Size = new System.Drawing.Size(34, 13);
            this.lbl_rows.TabIndex = 14;
            this.lbl_rows.Text = "Rows";
            // 
            // tb_cols
            // 
            this.tb_cols.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tb_cols.Location = new System.Drawing.Point(114, 107);
            this.tb_cols.MaxLength = 5;
            this.tb_cols.Name = "tb_cols";
            this.tb_cols.Size = new System.Drawing.Size(46, 20);
            this.tb_cols.TabIndex = 18;
            this.tb_cols.Text = "10";
            this.tb_cols.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_cols.TextChanged += new System.EventHandler(this.ValidateSizeTextbox);
            // 
            // lbl_cols
            // 
            this.lbl_cols.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_cols.AutoSize = true;
            this.lbl_cols.Location = new System.Drawing.Point(111, 91);
            this.lbl_cols.Name = "lbl_cols";
            this.lbl_cols.Size = new System.Drawing.Size(47, 13);
            this.lbl_cols.TabIndex = 15;
            this.lbl_cols.Text = "Columns";
            // 
            // tb_rows
            // 
            this.tb_rows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tb_rows.Location = new System.Drawing.Point(47, 107);
            this.tb_rows.MaxLength = 5;
            this.tb_rows.Name = "tb_rows";
            this.tb_rows.Size = new System.Drawing.Size(46, 20);
            this.tb_rows.TabIndex = 17;
            this.tb_rows.Text = "10";
            this.tb_rows.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_rows.TextChanged += new System.EventHandler(this.ValidateSizeTextbox);
            // 
            // time_updater
            // 
            this.time_updater.Interval = 1000;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.tsc_MainContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "Gravity Level Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.buttonContainer1.ResumeLayout(false);
            this.buttonContainer1.PerformLayout();
            this.tsc_MainContainer.BottomToolStripPanel.ResumeLayout(false);
            this.tsc_MainContainer.BottomToolStripPanel.PerformLayout();
            this.tsc_MainContainer.ContentPanel.ResumeLayout(false);
            this.tsc_MainContainer.TopToolStripPanel.ResumeLayout(false);
            this.tsc_MainContainer.TopToolStripPanel.PerformLayout();
            this.tsc_MainContainer.ResumeLayout(false);
            this.tsc_MainContainer.PerformLayout();
            this.sc_Properties.Panel2.ResumeLayout(false);
            this.sc_Properties.ResumeLayout(false);
            this.sc_HorizontalProperties.Panel1.ResumeLayout(false);
            this.sc_HorizontalProperties.Panel1.PerformLayout();
            this.sc_HorizontalProperties.Panel2.ResumeLayout(false);
            this.sc_HorizontalProperties.Panel2.PerformLayout();
            this.sc_HorizontalProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Entity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mi_file;
        private System.Windows.Forms.ToolStripMenuItem mi_new;
        private System.Windows.Forms.ToolStripMenuItem mi_open;
        private System.Windows.Forms.ToolStripSeparator closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_save;
        private System.Windows.Forms.ToolStripMenuItem mi_saveAs;
        private System.Windows.Forms.ToolStripSeparator playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_play;
        private System.Windows.Forms.ToolStripMenuItem mi_quit;
        private System.Windows.Forms.ToolStripMenuItem mi_edit;
        private System.Windows.Forms.ToolStripMenuItem mi_undo;
        private System.Windows.Forms.ToolStripMenuItem mi_redo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mi_cut;
        private System.Windows.Forms.ToolStripMenuItem mi_copy;
        private System.Windows.Forms.ToolStripMenuItem mi_paste;
        private System.Windows.Forms.ToolStripMenuItem mi_view;
        private System.Windows.Forms.ToolStripMenuItem mi_zoomIn;
        private System.Windows.Forms.ToolStripMenuItem mi_zoomOut;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStrip buttonContainer1;
        private System.Windows.Forms.ToolStripButton b_select;
        private System.Windows.Forms.ToolStripButton b_multiselect;
        private System.Windows.Forms.ToolStripButton b_addentity;
        private System.Windows.Forms.ToolStripButton b_removeentity;
        private System.Windows.Forms.ToolStripButton b_paint;
        private System.Windows.Forms.ToolStripButton b_depaint;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStripContainer tsc_MainContainer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.SplitContainer sc_Properties;
        private System.Windows.Forms.SplitContainer sc_HorizontalProperties;
        private System.Windows.Forms.Button b_ChangeEntity;
        private System.Windows.Forms.PictureBox pb_Entity;
        private System.Windows.Forms.Label l_LevelProperties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_bg;
        private System.Windows.Forms.PictureBox pb_bg;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button b_modifyLevel;
        private System.Windows.Forms.Label lbl_levelName;
        private System.Windows.Forms.Label lbl_rows;
        private System.Windows.Forms.TextBox tb_cols;
        private System.Windows.Forms.Label lbl_cols;
        private System.Windows.Forms.TextBox tb_rows;
        private System.Windows.Forms.Timer time_updater;

    }
}

