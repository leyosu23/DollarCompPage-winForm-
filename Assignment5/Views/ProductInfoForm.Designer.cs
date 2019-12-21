namespace Assignment5.Views
{
    partial class ProductInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfoForm));
            this.productInfoMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ProductConditionlabel = new System.Windows.Forms.Label();
            this.ProductCostLabel = new System.Windows.Forms.Label();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductOSDataLabel = new System.Windows.Forms.Label();
            this.ProductModelDataLabel = new System.Windows.Forms.Label();
            this.ProductPlatformDataLabel = new System.Windows.Forms.Label();
            this.ProductManufacturerDataLabel = new System.Windows.Forms.Label();
            this.ProductModelLabel = new System.Windows.Forms.Label();
            this.ProductOSLabel = new System.Windows.Forms.Label();
            this.ProductManufacturerLabel = new System.Windows.Forms.Label();
            this.ProductPlatformLabel = new System.Windows.Forms.Label();
            this.TechSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductResolutionDataLabel = new System.Windows.Forms.Label();
            this.ProductGPUTypeDataLabel = new System.Windows.Forms.Label();
            this.ProductCpuNumberDataLabel = new System.Windows.Forms.Label();
            this.ProductCpuSpeedDataLabel = new System.Windows.Forms.Label();
            this.ProductCpuBrandDataLabel = new System.Windows.Forms.Label();
            this.ProductScreensizeDataLabel = new System.Windows.Forms.Label();
            this.ProductCpuTypeDataLabel = new System.Windows.Forms.Label();
            this.ProductHDDSizeDataLabel = new System.Windows.Forms.Label();
            this.ProductMemoryDataLabel = new System.Windows.Forms.Label();
            this.ProductResolutionLabel = new System.Windows.Forms.Label();
            this.ProductCpuNumberLabel = new System.Windows.Forms.Label();
            this.ProductGPUTypeLabel = new System.Windows.Forms.Label();
            this.ProductCpuSpeedLabel = new System.Windows.Forms.Label();
            this.ProductCpuTypeLabel = new System.Windows.Forms.Label();
            this.ProductCpuBrandLabel = new System.Windows.Forms.Label();
            this.ProductScreensizeLabel = new System.Windows.Forms.Label();
            this.ProductHDDSizeLabel = new System.Windows.Forms.Label();
            this.ProductMemoryLabel = new System.Windows.Forms.Label();
            this.UserSelectionAlertLabel = new System.Windows.Forms.Label();
            this.SelectAnotherProductButton = new System.Windows.Forms.Button();
            this.CanCelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.productOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.productSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ProductIDDataLabel = new System.Windows.Forms.Label();
            this.ProductConditionDatalabel = new System.Windows.Forms.Label();
            this.ProductCostDataLabel = new System.Windows.Forms.Label();
            this.productInfoMenuStrip.SuspendLayout();
            this.ProductInfoGroupBox.SuspendLayout();
            this.TechSpecsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // productInfoMenuStrip
            // 
            this.productInfoMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.productInfoMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.productInfoMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.productInfoMenuStrip.Name = "productInfoMenuStrip";
            this.productInfoMenuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.productInfoMenuStrip.Size = new System.Drawing.Size(784, 25);
            this.productInfoMenuStrip.TabIndex = 0;
            this.productInfoMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.selectAnotherProductToolStripMenuItem.Text = "Select Another Product";
            this.selectAnotherProductToolStripMenuItem.Click += new System.EventHandler(this.SelectAnotherProductToolStripMenuItem_Click);
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Location = new System.Drawing.Point(30, 65);
            this.ProductIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(92, 19);
            this.ProductIDLabel.TabIndex = 1;
            this.ProductIDLabel.Text = "Product ID";
            // 
            // ProductConditionlabel
            // 
            this.ProductConditionlabel.AutoSize = true;
            this.ProductConditionlabel.Location = new System.Drawing.Point(282, 65);
            this.ProductConditionlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductConditionlabel.Name = "ProductConditionlabel";
            this.ProductConditionlabel.Size = new System.Drawing.Size(84, 19);
            this.ProductConditionlabel.TabIndex = 2;
            this.ProductConditionlabel.Text = "Condition";
            // 
            // ProductCostLabel
            // 
            this.ProductCostLabel.AutoSize = true;
            this.ProductCostLabel.Location = new System.Drawing.Point(519, 65);
            this.ProductCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductCostLabel.Name = "ProductCostLabel";
            this.ProductCostLabel.Size = new System.Drawing.Size(47, 19);
            this.ProductCostLabel.TabIndex = 3;
            this.ProductCostLabel.Text = "Cost";
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.Controls.Add(this.ProductOSDataLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductModelDataLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductPlatformDataLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductManufacturerDataLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductModelLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductOSLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductManufacturerLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductPlatformLabel);
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(22, 105);
            this.ProductInfoGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(744, 175);
            this.ProductInfoGroupBox.TabIndex = 7;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "Product Info";
            // 
            // ProductOSDataLabel
            // 
            this.ProductOSDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductOSDataLabel.Location = new System.Drawing.Point(486, 42);
            this.ProductOSDataLabel.Name = "ProductOSDataLabel";
            this.ProductOSDataLabel.Size = new System.Drawing.Size(198, 22);
            this.ProductOSDataLabel.TabIndex = 19;
            // 
            // ProductModelDataLabel
            // 
            this.ProductModelDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductModelDataLabel.Location = new System.Drawing.Point(486, 123);
            this.ProductModelDataLabel.Name = "ProductModelDataLabel";
            this.ProductModelDataLabel.Size = new System.Drawing.Size(198, 22);
            this.ProductModelDataLabel.TabIndex = 18;
            // 
            // ProductPlatformDataLabel
            // 
            this.ProductPlatformDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductPlatformDataLabel.Location = new System.Drawing.Point(165, 43);
            this.ProductPlatformDataLabel.Name = "ProductPlatformDataLabel";
            this.ProductPlatformDataLabel.Size = new System.Drawing.Size(173, 22);
            this.ProductPlatformDataLabel.TabIndex = 17;
            // 
            // ProductManufacturerDataLabel
            // 
            this.ProductManufacturerDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductManufacturerDataLabel.Location = new System.Drawing.Point(165, 121);
            this.ProductManufacturerDataLabel.Name = "ProductManufacturerDataLabel";
            this.ProductManufacturerDataLabel.Size = new System.Drawing.Size(173, 22);
            this.ProductManufacturerDataLabel.TabIndex = 16;
            // 
            // ProductModelLabel
            // 
            this.ProductModelLabel.AutoSize = true;
            this.ProductModelLabel.Location = new System.Drawing.Point(392, 124);
            this.ProductModelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductModelLabel.Name = "ProductModelLabel";
            this.ProductModelLabel.Size = new System.Drawing.Size(58, 19);
            this.ProductModelLabel.TabIndex = 13;
            this.ProductModelLabel.Text = "Model";
            // 
            // ProductOSLabel
            // 
            this.ProductOSLabel.AutoSize = true;
            this.ProductOSLabel.Location = new System.Drawing.Point(392, 43);
            this.ProductOSLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductOSLabel.Name = "ProductOSLabel";
            this.ProductOSLabel.Size = new System.Drawing.Size(33, 19);
            this.ProductOSLabel.TabIndex = 12;
            this.ProductOSLabel.Text = "OS";
            // 
            // ProductManufacturerLabel
            // 
            this.ProductManufacturerLabel.AutoSize = true;
            this.ProductManufacturerLabel.Location = new System.Drawing.Point(25, 124);
            this.ProductManufacturerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductManufacturerLabel.Name = "ProductManufacturerLabel";
            this.ProductManufacturerLabel.Size = new System.Drawing.Size(116, 19);
            this.ProductManufacturerLabel.TabIndex = 11;
            this.ProductManufacturerLabel.Text = "Manufacturer";
            // 
            // ProductPlatformLabel
            // 
            this.ProductPlatformLabel.AutoSize = true;
            this.ProductPlatformLabel.Location = new System.Drawing.Point(28, 43);
            this.ProductPlatformLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductPlatformLabel.Name = "ProductPlatformLabel";
            this.ProductPlatformLabel.Size = new System.Drawing.Size(75, 19);
            this.ProductPlatformLabel.TabIndex = 10;
            this.ProductPlatformLabel.Text = "Platform";
            // 
            // TechSpecsGroupBox
            // 
            this.TechSpecsGroupBox.Controls.Add(this.ProductResolutionDataLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductGPUTypeDataLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductCpuNumberDataLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductCpuSpeedDataLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductCpuBrandDataLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductScreensizeDataLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductCpuTypeDataLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductHDDSizeDataLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductMemoryDataLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductResolutionLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductCpuNumberLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductGPUTypeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductCpuSpeedLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductCpuTypeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductCpuBrandLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductScreensizeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductHDDSizeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductMemoryLabel);
            this.TechSpecsGroupBox.Location = new System.Drawing.Point(19, 293);
            this.TechSpecsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.TechSpecsGroupBox.Name = "TechSpecsGroupBox";
            this.TechSpecsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.TechSpecsGroupBox.Size = new System.Drawing.Size(747, 191);
            this.TechSpecsGroupBox.TabIndex = 16;
            this.TechSpecsGroupBox.TabStop = false;
            this.TechSpecsGroupBox.Text = "Tech Specs";
            // 
            // ProductResolutionDataLabel
            // 
            this.ProductResolutionDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductResolutionDataLabel.Location = new System.Drawing.Point(594, 144);
            this.ProductResolutionDataLabel.Name = "ProductResolutionDataLabel";
            this.ProductResolutionDataLabel.Size = new System.Drawing.Size(135, 22);
            this.ProductResolutionDataLabel.TabIndex = 35;
            // 
            // ProductGPUTypeDataLabel
            // 
            this.ProductGPUTypeDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductGPUTypeDataLabel.Location = new System.Drawing.Point(594, 85);
            this.ProductGPUTypeDataLabel.Name = "ProductGPUTypeDataLabel";
            this.ProductGPUTypeDataLabel.Size = new System.Drawing.Size(135, 22);
            this.ProductGPUTypeDataLabel.TabIndex = 34;
            // 
            // ProductCpuNumberDataLabel
            // 
            this.ProductCpuNumberDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductCpuNumberDataLabel.Location = new System.Drawing.Point(594, 30);
            this.ProductCpuNumberDataLabel.Name = "ProductCpuNumberDataLabel";
            this.ProductCpuNumberDataLabel.Size = new System.Drawing.Size(135, 22);
            this.ProductCpuNumberDataLabel.TabIndex = 33;
            // 
            // ProductCpuSpeedDataLabel
            // 
            this.ProductCpuSpeedDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductCpuSpeedDataLabel.Location = new System.Drawing.Point(367, 142);
            this.ProductCpuSpeedDataLabel.Name = "ProductCpuSpeedDataLabel";
            this.ProductCpuSpeedDataLabel.Size = new System.Drawing.Size(107, 22);
            this.ProductCpuSpeedDataLabel.TabIndex = 32;
            // 
            // ProductCpuBrandDataLabel
            // 
            this.ProductCpuBrandDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductCpuBrandDataLabel.Location = new System.Drawing.Point(367, 85);
            this.ProductCpuBrandDataLabel.Name = "ProductCpuBrandDataLabel";
            this.ProductCpuBrandDataLabel.Size = new System.Drawing.Size(107, 22);
            this.ProductCpuBrandDataLabel.TabIndex = 31;
            // 
            // ProductScreensizeDataLabel
            // 
            this.ProductScreensizeDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductScreensizeDataLabel.Location = new System.Drawing.Point(367, 33);
            this.ProductScreensizeDataLabel.Name = "ProductScreensizeDataLabel";
            this.ProductScreensizeDataLabel.Size = new System.Drawing.Size(107, 22);
            this.ProductScreensizeDataLabel.TabIndex = 30;
            // 
            // ProductCpuTypeDataLabel
            // 
            this.ProductCpuTypeDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductCpuTypeDataLabel.Location = new System.Drawing.Point(123, 142);
            this.ProductCpuTypeDataLabel.Name = "ProductCpuTypeDataLabel";
            this.ProductCpuTypeDataLabel.Size = new System.Drawing.Size(113, 22);
            this.ProductCpuTypeDataLabel.TabIndex = 29;
            // 
            // ProductHDDSizeDataLabel
            // 
            this.ProductHDDSizeDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductHDDSizeDataLabel.Location = new System.Drawing.Point(123, 89);
            this.ProductHDDSizeDataLabel.Name = "ProductHDDSizeDataLabel";
            this.ProductHDDSizeDataLabel.Size = new System.Drawing.Size(113, 22);
            this.ProductHDDSizeDataLabel.TabIndex = 28;
            // 
            // ProductMemoryDataLabel
            // 
            this.ProductMemoryDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductMemoryDataLabel.Location = new System.Drawing.Point(123, 30);
            this.ProductMemoryDataLabel.Name = "ProductMemoryDataLabel";
            this.ProductMemoryDataLabel.Size = new System.Drawing.Size(113, 22);
            this.ProductMemoryDataLabel.TabIndex = 20;
            // 
            // ProductResolutionLabel
            // 
            this.ProductResolutionLabel.AutoSize = true;
            this.ProductResolutionLabel.Location = new System.Drawing.Point(485, 145);
            this.ProductResolutionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductResolutionLabel.Name = "ProductResolutionLabel";
            this.ProductResolutionLabel.Size = new System.Drawing.Size(88, 19);
            this.ProductResolutionLabel.TabIndex = 27;
            this.ProductResolutionLabel.Text = "resolution";
            // 
            // ProductCpuNumberLabel
            // 
            this.ProductCpuNumberLabel.AutoSize = true;
            this.ProductCpuNumberLabel.Location = new System.Drawing.Point(484, 33);
            this.ProductCpuNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductCpuNumberLabel.Name = "ProductCpuNumberLabel";
            this.ProductCpuNumberLabel.Size = new System.Drawing.Size(112, 19);
            this.ProductCpuNumberLabel.TabIndex = 25;
            this.ProductCpuNumberLabel.Text = "CPU Number";
            // 
            // ProductGPUTypeLabel
            // 
            this.ProductGPUTypeLabel.AutoSize = true;
            this.ProductGPUTypeLabel.Location = new System.Drawing.Point(484, 86);
            this.ProductGPUTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductGPUTypeLabel.Name = "ProductGPUTypeLabel";
            this.ProductGPUTypeLabel.Size = new System.Drawing.Size(89, 19);
            this.ProductGPUTypeLabel.TabIndex = 23;
            this.ProductGPUTypeLabel.Text = "GPU Type";
            // 
            // ProductCpuSpeedLabel
            // 
            this.ProductCpuSpeedLabel.AutoSize = true;
            this.ProductCpuSpeedLabel.Location = new System.Drawing.Point(257, 145);
            this.ProductCpuSpeedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductCpuSpeedLabel.Name = "ProductCpuSpeedLabel";
            this.ProductCpuSpeedLabel.Size = new System.Drawing.Size(99, 19);
            this.ProductCpuSpeedLabel.TabIndex = 19;
            this.ProductCpuSpeedLabel.Text = "CPU speed";
            // 
            // ProductCpuTypeLabel
            // 
            this.ProductCpuTypeLabel.AutoSize = true;
            this.ProductCpuTypeLabel.Location = new System.Drawing.Point(22, 145);
            this.ProductCpuTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductCpuTypeLabel.Name = "ProductCpuTypeLabel";
            this.ProductCpuTypeLabel.Size = new System.Drawing.Size(89, 19);
            this.ProductCpuTypeLabel.TabIndex = 17;
            this.ProductCpuTypeLabel.Text = "CPU Type";
            // 
            // ProductCpuBrandLabel
            // 
            this.ProductCpuBrandLabel.AutoSize = true;
            this.ProductCpuBrandLabel.Location = new System.Drawing.Point(257, 88);
            this.ProductCpuBrandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductCpuBrandLabel.Name = "ProductCpuBrandLabel";
            this.ProductCpuBrandLabel.Size = new System.Drawing.Size(96, 19);
            this.ProductCpuBrandLabel.TabIndex = 13;
            this.ProductCpuBrandLabel.Text = "CPU Brand";
            // 
            // ProductScreensizeLabel
            // 
            this.ProductScreensizeLabel.AutoSize = true;
            this.ProductScreensizeLabel.Location = new System.Drawing.Point(257, 33);
            this.ProductScreensizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductScreensizeLabel.Name = "ProductScreensizeLabel";
            this.ProductScreensizeLabel.Size = new System.Drawing.Size(105, 19);
            this.ProductScreensizeLabel.TabIndex = 12;
            this.ProductScreensizeLabel.Text = "Screen Size";
            // 
            // ProductHDDSizeLabel
            // 
            this.ProductHDDSizeLabel.AutoSize = true;
            this.ProductHDDSizeLabel.Location = new System.Drawing.Point(22, 90);
            this.ProductHDDSizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductHDDSizeLabel.Name = "ProductHDDSizeLabel";
            this.ProductHDDSizeLabel.Size = new System.Drawing.Size(81, 19);
            this.ProductHDDSizeLabel.TabIndex = 11;
            this.ProductHDDSizeLabel.Text = "HDD Size";
            // 
            // ProductMemoryLabel
            // 
            this.ProductMemoryLabel.Location = new System.Drawing.Point(22, 33);
            this.ProductMemoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductMemoryLabel.Name = "ProductMemoryLabel";
            this.ProductMemoryLabel.Size = new System.Drawing.Size(89, 19);
            this.ProductMemoryLabel.TabIndex = 10;
            this.ProductMemoryLabel.Text = "Memory";
            // 
            // UserSelectionAlertLabel
            // 
            this.UserSelectionAlertLabel.Font = new System.Drawing.Font("Gulim", 14F);
            this.UserSelectionAlertLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.UserSelectionAlertLabel.Location = new System.Drawing.Point(30, 521);
            this.UserSelectionAlertLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserSelectionAlertLabel.Name = "UserSelectionAlertLabel";
            this.UserSelectionAlertLabel.Size = new System.Drawing.Size(317, 42);
            this.UserSelectionAlertLabel.TabIndex = 17;
            this.UserSelectionAlertLabel.Text = "Click Next to Confirm Your Selection";
            // 
            // SelectAnotherProductButton
            // 
            this.SelectAnotherProductButton.Font = new System.Drawing.Font("Gulim", 10F);
            this.SelectAnotherProductButton.Location = new System.Drawing.Point(416, 511);
            this.SelectAnotherProductButton.Margin = new System.Windows.Forms.Padding(2);
            this.SelectAnotherProductButton.Name = "SelectAnotherProductButton";
            this.SelectAnotherProductButton.Size = new System.Drawing.Size(153, 42);
            this.SelectAnotherProductButton.TabIndex = 18;
            this.SelectAnotherProductButton.Text = "Select Another Product";
            this.SelectAnotherProductButton.UseVisualStyleBackColor = true;
            this.SelectAnotherProductButton.Click += new System.EventHandler(this.SelectAnotherProductToolStripMenuItem_Click);
            // 
            // CanCelButton
            // 
            this.CanCelButton.Font = new System.Drawing.Font("Gulim", 10F);
            this.CanCelButton.Location = new System.Drawing.Point(597, 511);
            this.CanCelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CanCelButton.Name = "CanCelButton";
            this.CanCelButton.Size = new System.Drawing.Size(69, 42);
            this.CanCelButton.TabIndex = 19;
            this.CanCelButton.Text = "Cancel";
            this.CanCelButton.UseVisualStyleBackColor = true;
            this.CanCelButton.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Gulim", 10F);
            this.NextButton.Location = new System.Drawing.Point(697, 511);
            this.NextButton.Margin = new System.Windows.Forms.Padding(2);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(69, 42);
            this.NextButton.TabIndex = 20;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // productOpenFileDialog
            // 
            this.productOpenFileDialog.FileName = "openFileDialog1";
            // 
            // ProductIDDataLabel
            // 
            this.ProductIDDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductIDDataLabel.Location = new System.Drawing.Point(142, 65);
            this.ProductIDDataLabel.Name = "ProductIDDataLabel";
            this.ProductIDDataLabel.Size = new System.Drawing.Size(135, 22);
            this.ProductIDDataLabel.TabIndex = 21;
            // 
            // ProductConditionDatalabel
            // 
            this.ProductConditionDatalabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductConditionDatalabel.Location = new System.Drawing.Point(379, 64);
            this.ProductConditionDatalabel.Name = "ProductConditionDatalabel";
            this.ProductConditionDatalabel.Size = new System.Drawing.Size(135, 22);
            this.ProductConditionDatalabel.TabIndex = 22;
            // 
            // ProductCostDataLabel
            // 
            this.ProductCostDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductCostDataLabel.Location = new System.Drawing.Point(571, 62);
            this.ProductCostDataLabel.Name = "ProductCostDataLabel";
            this.ProductCostDataLabel.Size = new System.Drawing.Size(135, 22);
            this.ProductCostDataLabel.TabIndex = 23;
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 584);
            this.ControlBox = false;
            this.Controls.Add(this.ProductCostDataLabel);
            this.Controls.Add(this.ProductConditionDatalabel);
            this.Controls.Add(this.ProductIDDataLabel);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CanCelButton);
            this.Controls.Add(this.SelectAnotherProductButton);
            this.Controls.Add(this.UserSelectionAlertLabel);
            this.Controls.Add(this.TechSpecsGroupBox);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.ProductCostLabel);
            this.Controls.Add(this.ProductConditionlabel);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.productInfoMenuStrip);
            this.Font = new System.Drawing.Font("Gulim", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.productInfoMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.ProductInfoForm_Activated);
            this.productInfoMenuStrip.ResumeLayout(false);
            this.productInfoMenuStrip.PerformLayout();
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.ProductInfoGroupBox.PerformLayout();
            this.TechSpecsGroupBox.ResumeLayout(false);
            this.TechSpecsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip productInfoMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.Label ProductConditionlabel;
        private System.Windows.Forms.Label ProductCostLabel;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.Label ProductModelLabel;
        private System.Windows.Forms.Label ProductOSLabel;
        private System.Windows.Forms.Label ProductManufacturerLabel;
        private System.Windows.Forms.Label ProductPlatformLabel;
        private System.Windows.Forms.GroupBox TechSpecsGroupBox;
        private System.Windows.Forms.Label ProductCpuBrandLabel;
        private System.Windows.Forms.Label ProductScreensizeLabel;
        private System.Windows.Forms.Label ProductHDDSizeLabel;
        private System.Windows.Forms.Label ProductMemoryLabel;
        private System.Windows.Forms.Label UserSelectionAlertLabel;
        private System.Windows.Forms.Button SelectAnotherProductButton;
        private System.Windows.Forms.Button CanCelButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label ProductCpuNumberLabel;
        private System.Windows.Forms.Label ProductGPUTypeLabel;
        private System.Windows.Forms.Label ProductCpuSpeedLabel;
        private System.Windows.Forms.Label ProductCpuTypeLabel;
        private System.Windows.Forms.OpenFileDialog productOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog productSaveFileDialog;
        private System.Windows.Forms.Label ProductResolutionLabel;
        private System.Windows.Forms.Label ProductManufacturerDataLabel;
        private System.Windows.Forms.Label ProductOSDataLabel;
        private System.Windows.Forms.Label ProductModelDataLabel;
        private System.Windows.Forms.Label ProductPlatformDataLabel;
        private System.Windows.Forms.Label ProductResolutionDataLabel;
        private System.Windows.Forms.Label ProductGPUTypeDataLabel;
        private System.Windows.Forms.Label ProductCpuNumberDataLabel;
        private System.Windows.Forms.Label ProductCpuSpeedDataLabel;
        private System.Windows.Forms.Label ProductCpuBrandDataLabel;
        private System.Windows.Forms.Label ProductScreensizeDataLabel;
        private System.Windows.Forms.Label ProductCpuTypeDataLabel;
        private System.Windows.Forms.Label ProductHDDSizeDataLabel;
        private System.Windows.Forms.Label ProductMemoryDataLabel;
        private System.Windows.Forms.Label ProductIDDataLabel;
        private System.Windows.Forms.Label ProductConditionDatalabel;
        private System.Windows.Forms.Label ProductCostDataLabel;
    }
}

