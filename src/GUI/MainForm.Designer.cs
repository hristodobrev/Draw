﻿namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateM90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ungroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotkeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mouseCoordinates = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.drawRectangleButton = new System.Windows.Forms.ToolStripButton();
            this.drawEllipseButton = new System.Windows.Forms.ToolStripButton();
            this.drawCircleButton = new System.Windows.Forms.ToolStripButton();
            this.drawCircleLinesButton = new System.Windows.Forms.ToolStripButton();
            this.drawPolygonButton = new System.Windows.Forms.ToolStripButton();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.fillColorButton = new System.Windows.Forms.ToolStripButton();
            this.togglePropertiesButton = new System.Windows.Forms.ToolStripButton();
            this.rotateButton = new System.Windows.Forms.ToolStripButton();
            this.groupButton = new System.Windows.Forms.ToolStripButton();
            this.ungroupButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.colorChangeButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillColorDialog = new System.Windows.Forms.ColorDialog();
            this.shapePropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.scaleNumeric = new System.Windows.Forms.NumericUpDown();
            this.shapesGroupBox = new System.Windows.Forms.GroupBox();
            this.shapesTreeview = new System.Windows.Forms.TreeView();
            this.angleNumeric = new System.Windows.Forms.NumericUpDown();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.angleLabel = new System.Windows.Forms.Label();
            this.applyPropertiesButton = new System.Windows.Forms.Button();
            this.selectNameButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.applyRotateButton = new System.Windows.Forms.Button();
            this.rotateNumeric = new System.Windows.Forms.NumericUpDown();
            this.rotateLabel = new System.Windows.Forms.Label();
            this.strokeWidthNumeric = new System.Windows.Forms.NumericUpDown();
            this.strokeWidthLabel = new System.Windows.Forms.Label();
            this.strokeWidthTrackBar = new System.Windows.Forms.TrackBar();
            this.opacityLabel = new System.Windows.Forms.Label();
            this.opacityNumeric = new System.Windows.Forms.NumericUpDown();
            this.opacityTrackbar = new System.Windows.Forms.TrackBar();
            this.baseContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEllipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ungroupSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate90ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate90ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            this.shapePropertiesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleNumeric)).BeginInit();
            this.shapesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angleNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strokeWidthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strokeWidthTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacityTrackbar)).BeginInit();
            this.baseContextMenuStrip.SuspendLayout();
            this.selectionContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(924, 28);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.ExportToolStripMenuItemClick);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.ImportToolStripMenuItemClick);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotate90ToolStripMenuItem,
            this.rotateM90ToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // rotate90ToolStripMenuItem
            // 
            this.rotate90ToolStripMenuItem.Name = "rotate90ToolStripMenuItem";
            this.rotate90ToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.rotate90ToolStripMenuItem.Text = "Rotate 90";
            this.rotate90ToolStripMenuItem.Click += new System.EventHandler(this.Rotate90ToolStripMenuItemClick);
            // 
            // rotateM90ToolStripMenuItem
            // 
            this.rotateM90ToolStripMenuItem.Name = "rotateM90ToolStripMenuItem";
            this.rotateM90ToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.rotateM90ToolStripMenuItem.Text = "Rotate -90";
            this.rotateM90ToolStripMenuItem.Click += new System.EventHandler(this.RotateM90ToolStripMenuItemClick);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupToolStripMenuItem,
            this.ungroupToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.groupToolStripMenuItem.Text = "Group";
            this.groupToolStripMenuItem.Click += new System.EventHandler(this.GroupToolStripMenuItemClick);
            // 
            // ungroupToolStripMenuItem
            // 
            this.ungroupToolStripMenuItem.Name = "ungroupToolStripMenuItem";
            this.ungroupToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.ungroupToolStripMenuItem.Text = "Ungroup";
            this.ungroupToolStripMenuItem.Click += new System.EventHandler(this.UngroupToolStripMenuItemClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.hotkeysToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // hotkeysToolStripMenuItem
            // 
            this.hotkeysToolStripMenuItem.Name = "hotkeysToolStripMenuItem";
            this.hotkeysToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.hotkeysToolStripMenuItem.Text = "Hotkeys";
            this.hotkeysToolStripMenuItem.Click += new System.EventHandler(this.HotkeysToolStripMenuItemClick);
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel,
            this.mouseCoordinates});
            this.statusBar.Location = new System.Drawing.Point(0, 705);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusBar.Size = new System.Drawing.Size(924, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // mouseCoordinates
            // 
            this.mouseCoordinates.Name = "mouseCoordinates";
            this.mouseCoordinates.Size = new System.Drawing.Size(0, 16);
            // 
            // speedMenu
            // 
            this.speedMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawRectangleButton,
            this.drawEllipseButton,
            this.drawCircleButton,
            this.drawCircleLinesButton,
            this.drawPolygonButton,
            this.pickUpSpeedButton,
            this.fillColorButton,
            this.togglePropertiesButton,
            this.rotateButton,
            this.groupButton,
            this.ungroupButton,
            this.toolStripSeparator1,
            this.colorChangeButton});
            this.speedMenu.Location = new System.Drawing.Point(0, 28);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Size = new System.Drawing.Size(924, 27);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "toolStrip1";
            // 
            // drawRectangleButton
            // 
            this.drawRectangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleButton.Image")));
            this.drawRectangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleButton.Name = "drawRectangleButton";
            this.drawRectangleButton.Size = new System.Drawing.Size(29, 24);
            this.drawRectangleButton.Text = "Draw Rectangle";
            this.drawRectangleButton.Click += new System.EventHandler(this.DrawRectangleButtonClick);
            // 
            // drawEllipseButton
            // 
            this.drawEllipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawEllipseButton.Image = ((System.Drawing.Image)(resources.GetObject("drawEllipseButton.Image")));
            this.drawEllipseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawEllipseButton.Name = "drawEllipseButton";
            this.drawEllipseButton.Size = new System.Drawing.Size(29, 24);
            this.drawEllipseButton.Text = "Draw Ellipse";
            this.drawEllipseButton.Click += new System.EventHandler(this.DrawEllipseButtonClick);
            // 
            // drawCircleButton
            // 
            this.drawCircleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawCircleButton.Image = ((System.Drawing.Image)(resources.GetObject("drawCircleButton.Image")));
            this.drawCircleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawCircleButton.Name = "drawCircleButton";
            this.drawCircleButton.Size = new System.Drawing.Size(29, 24);
            this.drawCircleButton.Text = "Draw Circle";
            this.drawCircleButton.Click += new System.EventHandler(this.DrawCircleButtonClick);
            // 
            // drawCircleLinesButton
            // 
            this.drawCircleLinesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawCircleLinesButton.Image = ((System.Drawing.Image)(resources.GetObject("drawCircleLinesButton.Image")));
            this.drawCircleLinesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawCircleLinesButton.Name = "drawCircleLinesButton";
            this.drawCircleLinesButton.Size = new System.Drawing.Size(29, 24);
            this.drawCircleLinesButton.Text = "toolStripButton1";
            this.drawCircleLinesButton.Click += new System.EventHandler(this.DrawCircleLinesButtonClick);
            // 
            // drawPolygonButton
            // 
            this.drawPolygonButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawPolygonButton.Image = ((System.Drawing.Image)(resources.GetObject("drawPolygonButton.Image")));
            this.drawPolygonButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawPolygonButton.Name = "drawPolygonButton";
            this.drawPolygonButton.Size = new System.Drawing.Size(29, 24);
            this.drawPolygonButton.Text = "Draw Polygon";
            this.drawPolygonButton.Click += new System.EventHandler(this.DrawPolygonButtonClick);
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(29, 24);
            this.pickUpSpeedButton.Text = "Select";
            // 
            // fillColorButton
            // 
            this.fillColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillColorButton.Image = ((System.Drawing.Image)(resources.GetObject("fillColorButton.Image")));
            this.fillColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillColorButton.Name = "fillColorButton";
            this.fillColorButton.Size = new System.Drawing.Size(29, 24);
            this.fillColorButton.Text = "Fill Color";
            this.fillColorButton.Click += new System.EventHandler(this.FillColorButtonClick);
            // 
            // togglePropertiesButton
            // 
            this.togglePropertiesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.togglePropertiesButton.Image = ((System.Drawing.Image)(resources.GetObject("togglePropertiesButton.Image")));
            this.togglePropertiesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.togglePropertiesButton.Name = "togglePropertiesButton";
            this.togglePropertiesButton.Size = new System.Drawing.Size(29, 24);
            this.togglePropertiesButton.Text = "Toggle Properties";
            this.togglePropertiesButton.Click += new System.EventHandler(this.TogglePropertiesButtonClick);
            // 
            // rotateButton
            // 
            this.rotateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rotateButton.Image = ((System.Drawing.Image)(resources.GetObject("rotateButton.Image")));
            this.rotateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(29, 24);
            this.rotateButton.Text = "Rotate Button";
            this.rotateButton.Click += new System.EventHandler(this.RotateButtonClick);
            // 
            // groupButton
            // 
            this.groupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.groupButton.Image = ((System.Drawing.Image)(resources.GetObject("groupButton.Image")));
            this.groupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.groupButton.Name = "groupButton";
            this.groupButton.Size = new System.Drawing.Size(29, 24);
            this.groupButton.Text = "Group Button";
            this.groupButton.Click += new System.EventHandler(this.GroupButtonClick);
            // 
            // ungroupButton
            // 
            this.ungroupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ungroupButton.Image = ((System.Drawing.Image)(resources.GetObject("ungroupButton.Image")));
            this.ungroupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ungroupButton.Name = "ungroupButton";
            this.ungroupButton.Size = new System.Drawing.Size(29, 24);
            this.ungroupButton.Text = "Ungroup Button";
            this.ungroupButton.Click += new System.EventHandler(this.UngroupButtonClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // colorChangeButton
            // 
            this.colorChangeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorChangeButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.yellowToolStripMenuItem,
            this.orangeToolStripMenuItem});
            this.colorChangeButton.Image = ((System.Drawing.Image)(resources.GetObject("colorChangeButton.Image")));
            this.colorChangeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorChangeButton.Name = "colorChangeButton";
            this.colorChangeButton.Size = new System.Drawing.Size(34, 24);
            this.colorChangeButton.Text = "Color Change Button";
            this.colorChangeButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ColorChangeButtonDropDownItemClicked);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.redToolStripMenuItem.Text = "Red";
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.greenToolStripMenuItem.Text = "Green";
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.blueToolStripMenuItem.Text = "Blue";
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.yellowToolStripMenuItem.Text = "Yellow";
            // 
            // orangeToolStripMenuItem
            // 
            this.orangeToolStripMenuItem.Name = "orangeToolStripMenuItem";
            this.orangeToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.orangeToolStripMenuItem.Text = "Orange";
            // 
            // shapePropertiesGroupBox
            // 
            this.shapePropertiesGroupBox.Controls.Add(this.scaleNumeric);
            this.shapePropertiesGroupBox.Controls.Add(this.shapesGroupBox);
            this.shapePropertiesGroupBox.Controls.Add(this.angleNumeric);
            this.shapePropertiesGroupBox.Controls.Add(this.scaleLabel);
            this.shapePropertiesGroupBox.Controls.Add(this.angleLabel);
            this.shapePropertiesGroupBox.Controls.Add(this.applyPropertiesButton);
            this.shapePropertiesGroupBox.Controls.Add(this.selectNameButton);
            this.shapePropertiesGroupBox.Controls.Add(this.nameLabel);
            this.shapePropertiesGroupBox.Controls.Add(this.nameTextBox);
            this.shapePropertiesGroupBox.Controls.Add(this.applyRotateButton);
            this.shapePropertiesGroupBox.Controls.Add(this.rotateNumeric);
            this.shapePropertiesGroupBox.Controls.Add(this.rotateLabel);
            this.shapePropertiesGroupBox.Controls.Add(this.strokeWidthNumeric);
            this.shapePropertiesGroupBox.Controls.Add(this.strokeWidthLabel);
            this.shapePropertiesGroupBox.Controls.Add(this.strokeWidthTrackBar);
            this.shapePropertiesGroupBox.Controls.Add(this.opacityLabel);
            this.shapePropertiesGroupBox.Controls.Add(this.opacityNumeric);
            this.shapePropertiesGroupBox.Controls.Add(this.opacityTrackbar);
            this.shapePropertiesGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.shapePropertiesGroupBox.Location = new System.Drawing.Point(0, 55);
            this.shapePropertiesGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shapePropertiesGroupBox.Name = "shapePropertiesGroupBox";
            this.shapePropertiesGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shapePropertiesGroupBox.Size = new System.Drawing.Size(180, 650);
            this.shapePropertiesGroupBox.TabIndex = 5;
            this.shapePropertiesGroupBox.TabStop = false;
            this.shapePropertiesGroupBox.Text = "Shape Properties";
            this.shapePropertiesGroupBox.Visible = false;
            // 
            // scaleNumeric
            // 
            this.scaleNumeric.DecimalPlaces = 1;
            this.scaleNumeric.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.scaleNumeric.Location = new System.Drawing.Point(9, 337);
            this.scaleNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scaleNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.scaleNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scaleNumeric.Name = "scaleNumeric";
            this.scaleNumeric.Size = new System.Drawing.Size(88, 22);
            this.scaleNumeric.TabIndex = 20;
            this.scaleNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // shapesGroupBox
            // 
            this.shapesGroupBox.Controls.Add(this.shapesTreeview);
            this.shapesGroupBox.Location = new System.Drawing.Point(5, 409);
            this.shapesGroupBox.Name = "shapesGroupBox";
            this.shapesGroupBox.Size = new System.Drawing.Size(166, 291);
            this.shapesGroupBox.TabIndex = 6;
            this.shapesGroupBox.TabStop = false;
            this.shapesGroupBox.Text = "Shapes";
            // 
            // shapesTreeview
            // 
            this.shapesTreeview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shapesTreeview.Location = new System.Drawing.Point(3, 18);
            this.shapesTreeview.Name = "shapesTreeview";
            this.shapesTreeview.Size = new System.Drawing.Size(160, 270);
            this.shapesTreeview.TabIndex = 0;
            // 
            // angleNumeric
            // 
            this.angleNumeric.Location = new System.Drawing.Point(9, 287);
            this.angleNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.angleNumeric.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.angleNumeric.Name = "angleNumeric";
            this.angleNumeric.Size = new System.Drawing.Size(88, 22);
            this.angleNumeric.TabIndex = 19;
            // 
            // scaleLabel
            // 
            this.scaleLabel.AutoSize = true;
            this.scaleLabel.Location = new System.Drawing.Point(5, 316);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(42, 16);
            this.scaleLabel.TabIndex = 18;
            this.scaleLabel.Text = "Scale";
            // 
            // angleLabel
            // 
            this.angleLabel.AutoSize = true;
            this.angleLabel.Location = new System.Drawing.Point(5, 265);
            this.angleLabel.Name = "angleLabel";
            this.angleLabel.Size = new System.Drawing.Size(42, 16);
            this.angleLabel.TabIndex = 16;
            this.angleLabel.Text = "Angle";
            // 
            // applyPropertiesButton
            // 
            this.applyPropertiesButton.Location = new System.Drawing.Point(5, 374);
            this.applyPropertiesButton.Margin = new System.Windows.Forms.Padding(4);
            this.applyPropertiesButton.Name = "applyPropertiesButton";
            this.applyPropertiesButton.Size = new System.Drawing.Size(164, 28);
            this.applyPropertiesButton.TabIndex = 14;
            this.applyPropertiesButton.Text = "Apply Properties";
            this.applyPropertiesButton.UseVisualStyleBackColor = true;
            this.applyPropertiesButton.Click += new System.EventHandler(this.ApplyPropertiesButtonClick);
            // 
            // selectNameButton
            // 
            this.selectNameButton.Location = new System.Drawing.Point(105, 228);
            this.selectNameButton.Margin = new System.Windows.Forms.Padding(4);
            this.selectNameButton.Name = "selectNameButton";
            this.selectNameButton.Size = new System.Drawing.Size(69, 28);
            this.selectNameButton.TabIndex = 13;
            this.selectNameButton.Text = "Select";
            this.selectNameButton.UseVisualStyleBackColor = true;
            this.selectNameButton.Click += new System.EventHandler(this.SelectNameButtonClick);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(5, 212);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 16);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(9, 231);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(88, 22);
            this.nameTextBox.TabIndex = 11;
            // 
            // applyRotateButton
            // 
            this.applyRotateButton.Location = new System.Drawing.Point(105, 175);
            this.applyRotateButton.Margin = new System.Windows.Forms.Padding(4);
            this.applyRotateButton.Name = "applyRotateButton";
            this.applyRotateButton.Size = new System.Drawing.Size(69, 28);
            this.applyRotateButton.TabIndex = 10;
            this.applyRotateButton.Text = "Apply";
            this.applyRotateButton.UseVisualStyleBackColor = true;
            this.applyRotateButton.Click += new System.EventHandler(this.ApplyRotateButtonClick);
            // 
            // rotateNumeric
            // 
            this.rotateNumeric.Location = new System.Drawing.Point(9, 176);
            this.rotateNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rotateNumeric.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.rotateNumeric.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.rotateNumeric.Name = "rotateNumeric";
            this.rotateNumeric.Size = new System.Drawing.Size(88, 22);
            this.rotateNumeric.TabIndex = 9;
            // 
            // rotateLabel
            // 
            this.rotateLabel.AutoSize = true;
            this.rotateLabel.Location = new System.Drawing.Point(5, 158);
            this.rotateLabel.Name = "rotateLabel";
            this.rotateLabel.Size = new System.Drawing.Size(47, 16);
            this.rotateLabel.TabIndex = 8;
            this.rotateLabel.Text = "Rotate";
            // 
            // strokeWidthNumeric
            // 
            this.strokeWidthNumeric.Location = new System.Drawing.Point(116, 108);
            this.strokeWidthNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.strokeWidthNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.strokeWidthNumeric.Name = "strokeWidthNumeric";
            this.strokeWidthNumeric.Size = new System.Drawing.Size(59, 22);
            this.strokeWidthNumeric.TabIndex = 7;
            this.strokeWidthNumeric.ValueChanged += new System.EventHandler(this.StrokeWidthNumericValueChanged);
            // 
            // strokeWidthLabel
            // 
            this.strokeWidthLabel.AutoSize = true;
            this.strokeWidthLabel.Location = new System.Drawing.Point(5, 89);
            this.strokeWidthLabel.Name = "strokeWidthLabel";
            this.strokeWidthLabel.Size = new System.Drawing.Size(83, 16);
            this.strokeWidthLabel.TabIndex = 7;
            this.strokeWidthLabel.Text = "Stroke Width";
            // 
            // strokeWidthTrackBar
            // 
            this.strokeWidthTrackBar.LargeChange = 1;
            this.strokeWidthTrackBar.Location = new System.Drawing.Point(5, 108);
            this.strokeWidthTrackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.strokeWidthTrackBar.Name = "strokeWidthTrackBar";
            this.strokeWidthTrackBar.Size = new System.Drawing.Size(104, 56);
            this.strokeWidthTrackBar.TabIndex = 8;
            this.strokeWidthTrackBar.ValueChanged += new System.EventHandler(this.StrokeWidthTrackBarValueChanged);
            // 
            // opacityLabel
            // 
            this.opacityLabel.AutoSize = true;
            this.opacityLabel.Location = new System.Drawing.Point(5, 21);
            this.opacityLabel.Name = "opacityLabel";
            this.opacityLabel.Size = new System.Drawing.Size(53, 16);
            this.opacityLabel.TabIndex = 6;
            this.opacityLabel.Text = "Opacity";
            // 
            // opacityNumeric
            // 
            this.opacityNumeric.Location = new System.Drawing.Point(116, 39);
            this.opacityNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.opacityNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.opacityNumeric.Name = "opacityNumeric";
            this.opacityNumeric.Size = new System.Drawing.Size(59, 22);
            this.opacityNumeric.TabIndex = 6;
            this.opacityNumeric.ValueChanged += new System.EventHandler(this.OpacityNumericValueChanged);
            // 
            // opacityTrackbar
            // 
            this.opacityTrackbar.LargeChange = 1;
            this.opacityTrackbar.Location = new System.Drawing.Point(9, 39);
            this.opacityTrackbar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.opacityTrackbar.Maximum = 255;
            this.opacityTrackbar.Name = "opacityTrackbar";
            this.opacityTrackbar.Size = new System.Drawing.Size(104, 56);
            this.opacityTrackbar.TabIndex = 6;
            this.opacityTrackbar.ValueChanged += new System.EventHandler(this.OpacityTrackbarValueChanged);
            // 
            // baseContextMenuStrip
            // 
            this.baseContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.baseContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.newRectangleToolStripMenuItem,
            this.newEllipseToolStripMenuItem,
            this.newCircleToolStripMenuItem,
            this.newPolygonToolStripMenuItem});
            this.baseContextMenuStrip.Name = "baseContextMenuStrip";
            this.baseContextMenuStrip.Size = new System.Drawing.Size(179, 124);
            this.baseContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.BaseContextMenuStripOpening);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItemClick);
            // 
            // newRectangleToolStripMenuItem
            // 
            this.newRectangleToolStripMenuItem.Name = "newRectangleToolStripMenuItem";
            this.newRectangleToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.newRectangleToolStripMenuItem.Text = "New Rectangle";
            this.newRectangleToolStripMenuItem.Click += new System.EventHandler(this.NewRectangleToolStripMenuItemClick);
            // 
            // newEllipseToolStripMenuItem
            // 
            this.newEllipseToolStripMenuItem.Name = "newEllipseToolStripMenuItem";
            this.newEllipseToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.newEllipseToolStripMenuItem.Text = "New Ellipse";
            this.newEllipseToolStripMenuItem.Click += new System.EventHandler(this.NewEllipseToolStripMenuItemClick);
            // 
            // newCircleToolStripMenuItem
            // 
            this.newCircleToolStripMenuItem.Name = "newCircleToolStripMenuItem";
            this.newCircleToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.newCircleToolStripMenuItem.Text = "New Circle";
            this.newCircleToolStripMenuItem.Click += new System.EventHandler(this.NewCircleToolStripMenuItemClick);
            // 
            // newPolygonToolStripMenuItem
            // 
            this.newPolygonToolStripMenuItem.Name = "newPolygonToolStripMenuItem";
            this.newPolygonToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.newPolygonToolStripMenuItem.Text = "New Polygon";
            this.newPolygonToolStripMenuItem.Click += new System.EventHandler(this.NewPolygonToolStripMenuItemClick);
            // 
            // selectionContextMenuStrip
            // 
            this.selectionContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.selectionContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupSelectedToolStripMenuItem,
            this.ungroupSelectedToolStripMenuItem,
            this.invertSelectionToolStripMenuItem,
            this.unselectAllToolStripMenuItem,
            this.deleteSelectedToolStripMenuItem,
            this.rotate90ToolStripMenuItem1,
            this.rotate90ToolStripMenuItem2});
            this.selectionContextMenuStrip.Name = "selectionContextMenuStrip";
            this.selectionContextMenuStrip.Size = new System.Drawing.Size(198, 172);
            this.selectionContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.SelectionContextMenuStripOpening);
            // 
            // groupSelectedToolStripMenuItem
            // 
            this.groupSelectedToolStripMenuItem.Name = "groupSelectedToolStripMenuItem";
            this.groupSelectedToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.groupSelectedToolStripMenuItem.Text = "Group Selected";
            this.groupSelectedToolStripMenuItem.Click += new System.EventHandler(this.GroupSelectedToolStripMenuItemClick);
            // 
            // ungroupSelectedToolStripMenuItem
            // 
            this.ungroupSelectedToolStripMenuItem.Name = "ungroupSelectedToolStripMenuItem";
            this.ungroupSelectedToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.ungroupSelectedToolStripMenuItem.Text = "Ungroup Selected";
            this.ungroupSelectedToolStripMenuItem.Click += new System.EventHandler(this.UngroupSelectedToolStripMenuItemClick);
            // 
            // invertSelectionToolStripMenuItem
            // 
            this.invertSelectionToolStripMenuItem.Name = "invertSelectionToolStripMenuItem";
            this.invertSelectionToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.invertSelectionToolStripMenuItem.Text = "Invert Selection";
            this.invertSelectionToolStripMenuItem.Click += new System.EventHandler(this.InvertSelectionToolStripMenuItemClick);
            // 
            // unselectAllToolStripMenuItem
            // 
            this.unselectAllToolStripMenuItem.Name = "unselectAllToolStripMenuItem";
            this.unselectAllToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.unselectAllToolStripMenuItem.Text = "Unselect All";
            this.unselectAllToolStripMenuItem.Click += new System.EventHandler(this.UnselectAllToolStripMenuItemClick);
            // 
            // deleteSelectedToolStripMenuItem
            // 
            this.deleteSelectedToolStripMenuItem.Name = "deleteSelectedToolStripMenuItem";
            this.deleteSelectedToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.deleteSelectedToolStripMenuItem.Text = "Delete Selected";
            this.deleteSelectedToolStripMenuItem.Click += new System.EventHandler(this.DeleteSelectedToolStripMenuItemClick);
            // 
            // rotate90ToolStripMenuItem1
            // 
            this.rotate90ToolStripMenuItem1.Name = "rotate90ToolStripMenuItem1";
            this.rotate90ToolStripMenuItem1.Size = new System.Drawing.Size(197, 24);
            this.rotate90ToolStripMenuItem1.Text = "Rotate 90";
            this.rotate90ToolStripMenuItem1.Click += new System.EventHandler(this.Rotate90ContextToolStripMenuItemClick);
            // 
            // rotate90ToolStripMenuItem2
            // 
            this.rotate90ToolStripMenuItem2.Name = "rotate90ToolStripMenuItem2";
            this.rotate90ToolStripMenuItem2.Size = new System.Drawing.Size(197, 24);
            this.rotate90ToolStripMenuItem2.Text = "Rotate -90";
            this.rotate90ToolStripMenuItem2.Click += new System.EventHandler(this.RotateM90ContextToolStripMenuItemClick);
            // 
            // viewPort
            // 
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 55);
            this.viewPort.Margin = new System.Windows.Forms.Padding(5);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(924, 650);
            this.viewPort.TabIndex = 4;
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 727);
            this.ContextMenuStrip = this.baseContextMenuStrip;
            this.Controls.Add(this.shapePropertiesGroupBox);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            this.shapePropertiesGroupBox.ResumeLayout(false);
            this.shapePropertiesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleNumeric)).EndInit();
            this.shapesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.angleNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strokeWidthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strokeWidthTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacityTrackbar)).EndInit();
            this.baseContextMenuStrip.ResumeLayout(false);
            this.selectionContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
		private System.Windows.Forms.ToolStripButton drawRectangleButton;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStrip speedMenu;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripButton drawEllipseButton;
        private System.Windows.Forms.ToolStripButton drawCircleButton;
        private System.Windows.Forms.ToolStripButton drawPolygonButton;
        private System.Windows.Forms.ColorDialog fillColorDialog;
        private System.Windows.Forms.ToolStripButton fillColorButton;
        private System.Windows.Forms.GroupBox shapePropertiesGroupBox;
        private System.Windows.Forms.TrackBar opacityTrackbar;
        private System.Windows.Forms.NumericUpDown opacityNumeric;
        private System.Windows.Forms.ToolStripButton togglePropertiesButton;
        private System.Windows.Forms.NumericUpDown strokeWidthNumeric;
        private System.Windows.Forms.TrackBar strokeWidthTrackBar;
        private System.Windows.Forms.Label opacityLabel;
        private System.Windows.Forms.Label strokeWidthLabel;
        private System.Windows.Forms.Label rotateLabel;
        private System.Windows.Forms.ToolStripButton rotateButton;
        private System.Windows.Forms.NumericUpDown rotateNumeric;
        private System.Windows.Forms.Button applyRotateButton;
        private System.Windows.Forms.ToolStripButton groupButton;
        private System.Windows.Forms.ToolStripButton ungroupButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton colorChangeButton;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orangeToolStripMenuItem;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button applyPropertiesButton;
        private System.Windows.Forms.Button selectNameButton;
        private System.Windows.Forms.ToolStripStatusLabel mouseCoordinates;
        private System.Windows.Forms.ToolStripMenuItem rotate90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateM90ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip baseContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotkeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.Label angleLabel;
        private System.Windows.Forms.NumericUpDown scaleNumeric;
        private System.Windows.Forms.NumericUpDown angleNumeric;
        private System.Windows.Forms.Label scaleLabel;
        private System.Windows.Forms.ContextMenuStrip selectionContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ungroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unselectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ungroupSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate90ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rotate90ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem newRectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newEllipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCircleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPolygonToolStripMenuItem;
        private System.Windows.Forms.GroupBox shapesGroupBox;
        private System.Windows.Forms.TreeView shapesTreeview;
        private System.Windows.Forms.ToolStripButton drawCircleLinesButton;
    }
}
