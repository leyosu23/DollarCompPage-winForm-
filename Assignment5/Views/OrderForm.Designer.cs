namespace Assignment5.Views
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductCpuNumberDataLabel = new System.Windows.Forms.Label();
            this.ProductOSDataLabel = new System.Windows.Forms.Label();
            this.ProductGPUTypeDataLabel = new System.Windows.Forms.Label();
            this.ProductResolutionDataLabel = new System.Windows.Forms.Label();
            this.ProductCpuSpeedDataLabel = new System.Windows.Forms.Label();
            this.ProductHDDSizeDataLabel = new System.Windows.Forms.Label();
            this.ProductCpuTypeDataLabel = new System.Windows.Forms.Label();
            this.ProductCpuBrandDataLabel = new System.Windows.Forms.Label();
            this.ProductMemoryDataLabel = new System.Windows.Forms.Label();
            this.ProductPlatformDataLabel = new System.Windows.Forms.Label();
            this.ProductModelDataLabel = new System.Windows.Forms.Label();
            this.ProductManufacturerDataLabel = new System.Windows.Forms.Label();
            this.ProductScreensizeDataLabel = new System.Windows.Forms.Label();
            this.ProductConditionDatalabel = new System.Windows.Forms.Label();
            this.ProductOSLabel = new System.Windows.Forms.Label();
            this.ProductGPUTypeLabel = new System.Windows.Forms.Label();
            this.ProductCpuNumberLabel = new System.Windows.Forms.Label();
            this.ProductResolutionLabel = new System.Windows.Forms.Label();
            this.ProductCpuTypeLabel = new System.Windows.Forms.Label();
            this.ProductCpuSpeedLabel = new System.Windows.Forms.Label();
            this.ProductHDDTypeLabel = new System.Windows.Forms.Label();
            this.ProductModelLabel = new System.Windows.Forms.Label();
            this.ProductMemoryLabel = new System.Windows.Forms.Label();
            this.ProductPlatformLabel = new System.Windows.Forms.Label();
            this.ProductCpuBrandLabel = new System.Windows.Forms.Label();
            this.ProductManufacturerLabel = new System.Windows.Forms.Label();
            this.ProductScreensizeLabel = new System.Windows.Forms.Label();
            this.ProductConditionLabel = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.ProductCostLabel = new System.Windows.Forms.Label();
            this.ProductTaxLabel = new System.Windows.Forms.Label();
            this.ProductTotalPriceLabel = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OrderBackButton = new System.Windows.Forms.Button();
            this.OrderCancelButton = new System.Windows.Forms.Button();
            this.OrderFinishButton = new System.Windows.Forms.Button();
            this.ProductCostDataLabel = new System.Windows.Forms.Label();
            this.ProductTaxDataLabel = new System.Windows.Forms.Label();
            this.ProductTotalDataLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.ProductInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.Controls.Add(this.ProductCpuNumberDataLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductOSDataLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductGPUTypeDataLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductResolutionDataLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductCpuSpeedDataLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductHDDSizeDataLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductCpuTypeDataLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductCpuBrandDataLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductMemoryDataLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductPlatformDataLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductModelDataLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductManufacturerDataLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductScreensizeDataLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductConditionDatalabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductOSLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductGPUTypeLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductCpuNumberLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductResolutionLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductCpuTypeLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductCpuSpeedLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductHDDTypeLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductModelLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductMemoryLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductPlatformLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductCpuBrandLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductManufacturerLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductScreensizeLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductConditionLabel);
            this.ProductInfoGroupBox.Controls.Add(this.shapeContainer1);
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(14, 62);
            this.ProductInfoGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(480, 428);
            this.ProductInfoGroupBox.TabIndex = 8;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "System Components";
            // 
            // ProductCpuNumberDataLabel
            // 
            this.ProductCpuNumberDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductCpuNumberDataLabel.Location = new System.Drawing.Point(353, 332);
            this.ProductCpuNumberDataLabel.Name = "ProductCpuNumberDataLabel";
            this.ProductCpuNumberDataLabel.Size = new System.Drawing.Size(103, 22);
            this.ProductCpuNumberDataLabel.TabIndex = 55;
            // 
            // ProductOSDataLabel
            // 
            this.ProductOSDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductOSDataLabel.Location = new System.Drawing.Point(117, 380);
            this.ProductOSDataLabel.Name = "ProductOSDataLabel";
            this.ProductOSDataLabel.Size = new System.Drawing.Size(95, 22);
            this.ProductOSDataLabel.TabIndex = 54;
            // 
            // ProductGPUTypeDataLabel
            // 
            this.ProductGPUTypeDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductGPUTypeDataLabel.Location = new System.Drawing.Point(353, 378);
            this.ProductGPUTypeDataLabel.Name = "ProductGPUTypeDataLabel";
            this.ProductGPUTypeDataLabel.Size = new System.Drawing.Size(103, 22);
            this.ProductGPUTypeDataLabel.TabIndex = 53;
            // 
            // ProductResolutionDataLabel
            // 
            this.ProductResolutionDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductResolutionDataLabel.Location = new System.Drawing.Point(117, 333);
            this.ProductResolutionDataLabel.Name = "ProductResolutionDataLabel";
            this.ProductResolutionDataLabel.Size = new System.Drawing.Size(95, 22);
            this.ProductResolutionDataLabel.TabIndex = 52;
            // 
            // ProductCpuSpeedDataLabel
            // 
            this.ProductCpuSpeedDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductCpuSpeedDataLabel.Location = new System.Drawing.Point(118, 282);
            this.ProductCpuSpeedDataLabel.Name = "ProductCpuSpeedDataLabel";
            this.ProductCpuSpeedDataLabel.Size = new System.Drawing.Size(94, 22);
            this.ProductCpuSpeedDataLabel.TabIndex = 51;
            // 
            // ProductHDDSizeDataLabel
            // 
            this.ProductHDDSizeDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductHDDSizeDataLabel.Location = new System.Drawing.Point(353, 238);
            this.ProductHDDSizeDataLabel.Name = "ProductHDDSizeDataLabel";
            this.ProductHDDSizeDataLabel.Size = new System.Drawing.Size(103, 22);
            this.ProductHDDSizeDataLabel.TabIndex = 50;
            // 
            // ProductCpuTypeDataLabel
            // 
            this.ProductCpuTypeDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductCpuTypeDataLabel.Location = new System.Drawing.Point(353, 282);
            this.ProductCpuTypeDataLabel.Name = "ProductCpuTypeDataLabel";
            this.ProductCpuTypeDataLabel.Size = new System.Drawing.Size(103, 22);
            this.ProductCpuTypeDataLabel.TabIndex = 49;
            // 
            // ProductCpuBrandDataLabel
            // 
            this.ProductCpuBrandDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductCpuBrandDataLabel.Location = new System.Drawing.Point(118, 236);
            this.ProductCpuBrandDataLabel.Name = "ProductCpuBrandDataLabel";
            this.ProductCpuBrandDataLabel.Size = new System.Drawing.Size(94, 22);
            this.ProductCpuBrandDataLabel.TabIndex = 48;
            // 
            // ProductMemoryDataLabel
            // 
            this.ProductMemoryDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductMemoryDataLabel.Location = new System.Drawing.Point(352, 99);
            this.ProductMemoryDataLabel.Name = "ProductMemoryDataLabel";
            this.ProductMemoryDataLabel.Size = new System.Drawing.Size(103, 22);
            this.ProductMemoryDataLabel.TabIndex = 47;
            // 
            // ProductPlatformDataLabel
            // 
            this.ProductPlatformDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductPlatformDataLabel.Location = new System.Drawing.Point(138, 147);
            this.ProductPlatformDataLabel.Name = "ProductPlatformDataLabel";
            this.ProductPlatformDataLabel.Size = new System.Drawing.Size(94, 22);
            this.ProductPlatformDataLabel.TabIndex = 46;
            // 
            // ProductModelDataLabel
            // 
            this.ProductModelDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductModelDataLabel.Location = new System.Drawing.Point(352, 146);
            this.ProductModelDataLabel.Name = "ProductModelDataLabel";
            this.ProductModelDataLabel.Size = new System.Drawing.Size(103, 22);
            this.ProductModelDataLabel.TabIndex = 45;
            // 
            // ProductManufacturerDataLabel
            // 
            this.ProductManufacturerDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductManufacturerDataLabel.Location = new System.Drawing.Point(138, 99);
            this.ProductManufacturerDataLabel.Name = "ProductManufacturerDataLabel";
            this.ProductManufacturerDataLabel.Size = new System.Drawing.Size(94, 22);
            this.ProductManufacturerDataLabel.TabIndex = 44;
            // 
            // ProductScreensizeDataLabel
            // 
            this.ProductScreensizeDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductScreensizeDataLabel.Location = new System.Drawing.Point(352, 45);
            this.ProductScreensizeDataLabel.Name = "ProductScreensizeDataLabel";
            this.ProductScreensizeDataLabel.Size = new System.Drawing.Size(103, 22);
            this.ProductScreensizeDataLabel.TabIndex = 43;
            // 
            // ProductConditionDatalabel
            // 
            this.ProductConditionDatalabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductConditionDatalabel.Location = new System.Drawing.Point(138, 44);
            this.ProductConditionDatalabel.Name = "ProductConditionDatalabel";
            this.ProductConditionDatalabel.Size = new System.Drawing.Size(94, 22);
            this.ProductConditionDatalabel.TabIndex = 33;
            // 
            // ProductOSLabel
            // 
            this.ProductOSLabel.AutoSize = true;
            this.ProductOSLabel.Location = new System.Drawing.Point(17, 384);
            this.ProductOSLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductOSLabel.Name = "ProductOSLabel";
            this.ProductOSLabel.Size = new System.Drawing.Size(33, 19);
            this.ProductOSLabel.TabIndex = 28;
            this.ProductOSLabel.Text = "OS";
            // 
            // ProductGPUTypeLabel
            // 
            this.ProductGPUTypeLabel.AutoSize = true;
            this.ProductGPUTypeLabel.Location = new System.Drawing.Point(239, 378);
            this.ProductGPUTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductGPUTypeLabel.Name = "ProductGPUTypeLabel";
            this.ProductGPUTypeLabel.Size = new System.Drawing.Size(89, 19);
            this.ProductGPUTypeLabel.TabIndex = 26;
            this.ProductGPUTypeLabel.Text = "GPU Type";
            // 
            // ProductCpuNumberLabel
            // 
            this.ProductCpuNumberLabel.AutoSize = true;
            this.ProductCpuNumberLabel.Location = new System.Drawing.Point(220, 335);
            this.ProductCpuNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductCpuNumberLabel.Name = "ProductCpuNumberLabel";
            this.ProductCpuNumberLabel.Size = new System.Drawing.Size(112, 19);
            this.ProductCpuNumberLabel.TabIndex = 22;
            this.ProductCpuNumberLabel.Text = "CPU Number";
            // 
            // ProductResolutionLabel
            // 
            this.ProductResolutionLabel.AutoSize = true;
            this.ProductResolutionLabel.Location = new System.Drawing.Point(17, 336);
            this.ProductResolutionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductResolutionLabel.Name = "ProductResolutionLabel";
            this.ProductResolutionLabel.Size = new System.Drawing.Size(88, 19);
            this.ProductResolutionLabel.TabIndex = 20;
            this.ProductResolutionLabel.Text = "resolution";
            // 
            // ProductCpuTypeLabel
            // 
            this.ProductCpuTypeLabel.AutoSize = true;
            this.ProductCpuTypeLabel.Location = new System.Drawing.Point(239, 284);
            this.ProductCpuTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductCpuTypeLabel.Name = "ProductCpuTypeLabel";
            this.ProductCpuTypeLabel.Size = new System.Drawing.Size(89, 19);
            this.ProductCpuTypeLabel.TabIndex = 18;
            this.ProductCpuTypeLabel.Text = "CPU Type";
            // 
            // ProductCpuSpeedLabel
            // 
            this.ProductCpuSpeedLabel.AutoSize = true;
            this.ProductCpuSpeedLabel.Location = new System.Drawing.Point(17, 285);
            this.ProductCpuSpeedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductCpuSpeedLabel.Name = "ProductCpuSpeedLabel";
            this.ProductCpuSpeedLabel.Size = new System.Drawing.Size(100, 19);
            this.ProductCpuSpeedLabel.TabIndex = 16;
            this.ProductCpuSpeedLabel.Text = "CPU Speed";
            // 
            // ProductHDDTypeLabel
            // 
            this.ProductHDDTypeLabel.AutoSize = true;
            this.ProductHDDTypeLabel.Location = new System.Drawing.Point(244, 234);
            this.ProductHDDTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductHDDTypeLabel.Name = "ProductHDDTypeLabel";
            this.ProductHDDTypeLabel.Size = new System.Drawing.Size(81, 19);
            this.ProductHDDTypeLabel.TabIndex = 13;
            this.ProductHDDTypeLabel.Text = "HDD Size";
            // 
            // ProductModelLabel
            // 
            this.ProductModelLabel.AutoSize = true;
            this.ProductModelLabel.Location = new System.Drawing.Point(270, 150);
            this.ProductModelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductModelLabel.Name = "ProductModelLabel";
            this.ProductModelLabel.Size = new System.Drawing.Size(58, 19);
            this.ProductModelLabel.TabIndex = 13;
            this.ProductModelLabel.Text = "Model";
            // 
            // ProductMemoryLabel
            // 
            this.ProductMemoryLabel.AutoSize = true;
            this.ProductMemoryLabel.Location = new System.Drawing.Point(255, 99);
            this.ProductMemoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductMemoryLabel.Name = "ProductMemoryLabel";
            this.ProductMemoryLabel.Size = new System.Drawing.Size(76, 19);
            this.ProductMemoryLabel.TabIndex = 12;
            this.ProductMemoryLabel.Text = "Memory";
            // 
            // ProductPlatformLabel
            // 
            this.ProductPlatformLabel.AutoSize = true;
            this.ProductPlatformLabel.Location = new System.Drawing.Point(17, 149);
            this.ProductPlatformLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductPlatformLabel.Name = "ProductPlatformLabel";
            this.ProductPlatformLabel.Size = new System.Drawing.Size(75, 19);
            this.ProductPlatformLabel.TabIndex = 12;
            this.ProductPlatformLabel.Text = "Platform";
            // 
            // ProductCpuBrandLabel
            // 
            this.ProductCpuBrandLabel.AutoSize = true;
            this.ProductCpuBrandLabel.Location = new System.Drawing.Point(17, 240);
            this.ProductCpuBrandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductCpuBrandLabel.Name = "ProductCpuBrandLabel";
            this.ProductCpuBrandLabel.Size = new System.Drawing.Size(96, 19);
            this.ProductCpuBrandLabel.TabIndex = 11;
            this.ProductCpuBrandLabel.Text = "CPU Brand";
            // 
            // ProductManufacturerLabel
            // 
            this.ProductManufacturerLabel.AutoSize = true;
            this.ProductManufacturerLabel.Location = new System.Drawing.Point(17, 99);
            this.ProductManufacturerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductManufacturerLabel.Name = "ProductManufacturerLabel";
            this.ProductManufacturerLabel.Size = new System.Drawing.Size(116, 19);
            this.ProductManufacturerLabel.TabIndex = 11;
            this.ProductManufacturerLabel.Text = "Manufacturer";
            // 
            // ProductScreensizeLabel
            // 
            this.ProductScreensizeLabel.AutoSize = true;
            this.ProductScreensizeLabel.Location = new System.Drawing.Point(232, 47);
            this.ProductScreensizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductScreensizeLabel.Name = "ProductScreensizeLabel";
            this.ProductScreensizeLabel.Size = new System.Drawing.Size(105, 19);
            this.ProductScreensizeLabel.TabIndex = 10;
            this.ProductScreensizeLabel.Text = "Screen Size";
            // 
            // ProductConditionLabel
            // 
            this.ProductConditionLabel.AutoSize = true;
            this.ProductConditionLabel.Location = new System.Drawing.Point(17, 45);
            this.ProductConditionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductConditionLabel.Name = "ProductConditionLabel";
            this.ProductConditionLabel.Size = new System.Drawing.Size(84, 19);
            this.ProductConditionLabel.TabIndex = 10;
            this.ProductConditionLabel.Text = "Condition";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(2, 24);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(476, 402);
            this.shapeContainer1.TabIndex = 32;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -1;
            this.lineShape1.X2 = 475;
            this.lineShape1.Y1 = 178;
            this.lineShape1.Y2 = 179;
            // 
            // ProductCostLabel
            // 
            this.ProductCostLabel.AutoSize = true;
            this.ProductCostLabel.Location = new System.Drawing.Point(526, 347);
            this.ProductCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductCostLabel.Name = "ProductCostLabel";
            this.ProductCostLabel.Size = new System.Drawing.Size(49, 19);
            this.ProductCostLabel.TabIndex = 32;
            this.ProductCostLabel.Text = "Price";
            // 
            // ProductTaxLabel
            // 
            this.ProductTaxLabel.AutoSize = true;
            this.ProductTaxLabel.Location = new System.Drawing.Point(526, 385);
            this.ProductTaxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductTaxLabel.Name = "ProductTaxLabel";
            this.ProductTaxLabel.Size = new System.Drawing.Size(39, 19);
            this.ProductTaxLabel.TabIndex = 34;
            this.ProductTaxLabel.Text = "Tax";
            // 
            // ProductTotalPriceLabel
            // 
            this.ProductTotalPriceLabel.AutoSize = true;
            this.ProductTotalPriceLabel.Location = new System.Drawing.Point(526, 464);
            this.ProductTotalPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductTotalPriceLabel.Name = "ProductTotalPriceLabel";
            this.ProductTotalPriceLabel.Size = new System.Drawing.Size(48, 19);
            this.ProductTotalPriceLabel.TabIndex = 36;
            this.ProductTotalPriceLabel.Text = "Total";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer2.Size = new System.Drawing.Size(784, 561);
            this.shapeContainer2.TabIndex = 38;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 500;
            this.lineShape2.X2 = 760;
            this.lineShape2.Y1 = 433;
            this.lineShape2.Y2 = 433;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Assignment5.Properties.Resources.orderForm_laptop_image;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(503, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 260);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // OrderBackButton
            // 
            this.OrderBackButton.Location = new System.Drawing.Point(14, 513);
            this.OrderBackButton.Margin = new System.Windows.Forms.Padding(2);
            this.OrderBackButton.Name = "OrderBackButton";
            this.OrderBackButton.Size = new System.Drawing.Size(78, 37);
            this.OrderBackButton.TabIndex = 40;
            this.OrderBackButton.Text = "back";
            this.OrderBackButton.UseVisualStyleBackColor = true;
            this.OrderBackButton.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // OrderCancelButton
            // 
            this.OrderCancelButton.Location = new System.Drawing.Point(603, 513);
            this.OrderCancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.OrderCancelButton.Name = "OrderCancelButton";
            this.OrderCancelButton.Size = new System.Drawing.Size(78, 37);
            this.OrderCancelButton.TabIndex = 41;
            this.OrderCancelButton.Text = "cancel";
            this.OrderCancelButton.UseVisualStyleBackColor = true;
            this.OrderCancelButton.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // OrderFinishButton
            // 
            this.OrderFinishButton.Location = new System.Drawing.Point(695, 513);
            this.OrderFinishButton.Margin = new System.Windows.Forms.Padding(2);
            this.OrderFinishButton.Name = "OrderFinishButton";
            this.OrderFinishButton.Size = new System.Drawing.Size(78, 37);
            this.OrderFinishButton.TabIndex = 42;
            this.OrderFinishButton.Text = "finish";
            this.OrderFinishButton.UseVisualStyleBackColor = true;
            this.OrderFinishButton.Click += new System.EventHandler(this.orderFinishButton_Click);
            // 
            // ProductCostDataLabel
            // 
            this.ProductCostDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductCostDataLabel.Location = new System.Drawing.Point(603, 346);
            this.ProductCostDataLabel.Name = "ProductCostDataLabel";
            this.ProductCostDataLabel.Size = new System.Drawing.Size(135, 22);
            this.ProductCostDataLabel.TabIndex = 24;
            // 
            // ProductTaxDataLabel
            // 
            this.ProductTaxDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductTaxDataLabel.Location = new System.Drawing.Point(603, 385);
            this.ProductTaxDataLabel.Name = "ProductTaxDataLabel";
            this.ProductTaxDataLabel.Size = new System.Drawing.Size(135, 22);
            this.ProductTaxDataLabel.TabIndex = 43;
            // 
            // ProductTotalDataLabel
            // 
            this.ProductTotalDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductTotalDataLabel.Location = new System.Drawing.Point(603, 463);
            this.ProductTotalDataLabel.Name = "ProductTotalDataLabel";
            this.ProductTotalDataLabel.Size = new System.Drawing.Size(135, 22);
            this.ProductTotalDataLabel.TabIndex = 44;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.ProductTotalDataLabel);
            this.Controls.Add(this.ProductTaxDataLabel);
            this.Controls.Add(this.OrderFinishButton);
            this.Controls.Add(this.OrderCancelButton);
            this.Controls.Add(this.OrderBackButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ProductTotalPriceLabel);
            this.Controls.Add(this.ProductTaxLabel);
            this.Controls.Add(this.ProductCostLabel);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ProductCostDataLabel);
            this.Controls.Add(this.shapeContainer2);
            this.Font = new System.Drawing.Font("Gulim", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm Menu";
            this.Activated += new System.EventHandler(this.OrderForm_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.ProductInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.Label ProductModelLabel;
        private System.Windows.Forms.Label ProductPlatformLabel;
        private System.Windows.Forms.Label ProductManufacturerLabel;
        private System.Windows.Forms.Label ProductConditionLabel;
        private System.Windows.Forms.Label ProductHDDTypeLabel;
        private System.Windows.Forms.Label ProductMemoryLabel;
        private System.Windows.Forms.Label ProductCpuBrandLabel;
        private System.Windows.Forms.Label ProductScreensizeLabel;
        private System.Windows.Forms.Label ProductOSLabel;
        private System.Windows.Forms.Label ProductGPUTypeLabel;
        private System.Windows.Forms.Label ProductCpuNumberLabel;
        private System.Windows.Forms.Label ProductResolutionLabel;
        private System.Windows.Forms.Label ProductCpuTypeLabel;
        private System.Windows.Forms.Label ProductCpuSpeedLabel;
        private System.Windows.Forms.Label ProductCostLabel;
        private System.Windows.Forms.Label ProductTaxLabel;
        private System.Windows.Forms.Label ProductTotalPriceLabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button OrderBackButton;
        private System.Windows.Forms.Button OrderCancelButton;
        private System.Windows.Forms.Button OrderFinishButton;
        private System.Windows.Forms.Label ProductConditionDatalabel;
        private System.Windows.Forms.Label ProductCostDataLabel;
        private System.Windows.Forms.Label ProductScreensizeDataLabel;
        private System.Windows.Forms.Label ProductManufacturerDataLabel;
        private System.Windows.Forms.Label ProductModelDataLabel;
        private System.Windows.Forms.Label ProductPlatformDataLabel;
        private System.Windows.Forms.Label ProductMemoryDataLabel;
        private System.Windows.Forms.Label ProductCpuBrandDataLabel;
        private System.Windows.Forms.Label ProductCpuTypeDataLabel;
        private System.Windows.Forms.Label ProductHDDSizeDataLabel;
        private System.Windows.Forms.Label ProductCpuSpeedDataLabel;
        private System.Windows.Forms.Label ProductResolutionDataLabel;
        private System.Windows.Forms.Label ProductGPUTypeDataLabel;
        private System.Windows.Forms.Label ProductOSDataLabel;
        private System.Windows.Forms.Label ProductCpuNumberDataLabel;
        private System.Windows.Forms.Label ProductTaxDataLabel;
        private System.Windows.Forms.Label ProductTotalDataLabel;
    }
}