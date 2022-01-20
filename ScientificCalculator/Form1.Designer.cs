
namespace ScientificCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcInputBox = new System.Windows.Forms.TextBox();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnX2 = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnX3 = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnOct = new System.Windows.Forms.Button();
            this.btnHex = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnTanh = new System.Windows.Forms.Button();
            this.btnCosh = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnBin = new System.Windows.Forms.Button();
            this.btn1X = new System.Windows.Forms.Button();
            this.btnLnX = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnSinh = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.tempGroupBox = new System.Windows.Forms.GroupBox();
            this.tempConvertGroupBox = new System.Windows.Forms.GroupBox();
            this.radioK = new System.Windows.Forms.RadioButton();
            this.radioFtoC = new System.Windows.Forms.RadioButton();
            this.radioCtoF = new System.Windows.Forms.RadioButton();
            this.btnResetTemp = new System.Windows.Forms.Button();
            this.btnConvertTemp = new System.Windows.Forms.Button();
            this.lblTempResultShow = new System.Windows.Forms.Label();
            this.lblTempResult = new System.Windows.Forms.Label();
            this.lblTempVal = new System.Windows.Forms.Label();
            this.txtTempInput = new System.Windows.Forms.TextBox();
            this.lblShowOp = new System.Windows.Forms.Label();
            this.multiplicationGBox = new System.Windows.Forms.GroupBox();
            this.txtMultiply = new System.Windows.Forms.TextBox();
            this.btnResetM = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.lstMultiply = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.tempGroupBox.SuspendLayout();
            this.tempConvertGroupBox.SuspendLayout();
            this.multiplicationGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1582, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.scientificToolStripMenuItem,
            this.temperatureToolStripMenuItem,
            this.multiplicationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.standardToolStripMenuItem.Text = "Standard";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.standardToolStripMenuItem_Click);
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.scientificToolStripMenuItem.Text = "Scientific";
            this.scientificToolStripMenuItem.Click += new System.EventHandler(this.scientificToolStripMenuItem_Click);
            // 
            // temperatureToolStripMenuItem
            // 
            this.temperatureToolStripMenuItem.Name = "temperatureToolStripMenuItem";
            this.temperatureToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.temperatureToolStripMenuItem.Text = "Temperature";
            this.temperatureToolStripMenuItem.Click += new System.EventHandler(this.temperatureToolStripMenuItem_Click);
            // 
            // multiplicationToolStripMenuItem
            // 
            this.multiplicationToolStripMenuItem.Name = "multiplicationToolStripMenuItem";
            this.multiplicationToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.multiplicationToolStripMenuItem.Text = "Multiplication";
            this.multiplicationToolStripMenuItem.Click += new System.EventHandler(this.multiplicationToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // calcInputBox
            // 
            this.calcInputBox.BackColor = System.Drawing.Color.FloralWhite;
            this.calcInputBox.Font = new System.Drawing.Font("Consolas", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calcInputBox.Location = new System.Drawing.Point(13, 31);
            this.calcInputBox.Multiline = true;
            this.calcInputBox.Name = "calcInputBox";
            this.calcInputBox.Size = new System.Drawing.Size(588, 56);
            this.calcInputBox.TabIndex = 1;
            this.calcInputBox.Text = "0";
            this.calcInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBackSpace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackSpace.BackgroundImage")));
            this.btnBackSpace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBackSpace.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnBackSpace.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnBackSpace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackSpace.Location = new System.Drawing.Point(12, 93);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(67, 63);
            this.btnBackSpace.TabIndex = 2;
            this.btnBackSpace.UseVisualStyleBackColor = false;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCE.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnCE.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnCE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCE.Font = new System.Drawing.Font("Segoe UI Semibold", 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCE.Location = new System.Drawing.Point(85, 93);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(67, 63);
            this.btnCE.TabIndex = 2;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnC.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnC.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnC.Font = new System.Drawing.Font("Segoe UI Semibold", 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnC.Location = new System.Drawing.Point(158, 93);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(67, 63);
            this.btnC.TabIndex = 2;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPlusMinus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlusMinus.BackgroundImage")));
            this.btnPlusMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlusMinus.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnPlusMinus.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnPlusMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlusMinus.Location = new System.Drawing.Point(231, 93);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(67, 63);
            this.btnPlusMinus.TabIndex = 2;
            this.btnPlusMinus.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn7.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Font = new System.Drawing.Font("Segoe UI Semibold", 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(12, 162);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(67, 63);
            this.btn7.TabIndex = 2;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.numButton_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn8.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Font = new System.Drawing.Font("Segoe UI Semibold", 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(85, 162);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(67, 63);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.numButton_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn9.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.Font = new System.Drawing.Font("Segoe UI Semibold", 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(158, 162);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(67, 63);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.numButton_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDivide.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDivide.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnDivide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.Location = new System.Drawing.Point(231, 369);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(67, 63);
            this.btnDivide.TabIndex = 2;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.Arithmetic_Operator);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPlus.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnPlus.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlus.Location = new System.Drawing.Point(231, 162);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(67, 63);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.Arithmetic_Operator);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMinus.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnMinus.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.Location = new System.Drawing.Point(231, 231);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(67, 63);
            this.btnMinus.TabIndex = 2;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.Arithmetic_Operator);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnX.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnX.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnX.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnX.Location = new System.Drawing.Point(231, 300);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(67, 63);
            this.btnX.TabIndex = 2;
            this.btnX.Text = "*";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.Arithmetic_Operator);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn6.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(158, 231);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(67, 63);
            this.btn6.TabIndex = 2;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.numButton_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn5.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(85, 231);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(67, 63);
            this.btn5.TabIndex = 2;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.numButton_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn4.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(13, 231);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(67, 63);
            this.btn4.TabIndex = 2;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.numButton_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(12, 300);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(67, 63);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.numButton_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(85, 300);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(67, 63);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.numButton_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn3.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(158, 300);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(67, 63);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.numButton_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEquals.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnEquals.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnEquals.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEquals.Font = new System.Drawing.Font("Segoe UI Semibold", 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEquals.Location = new System.Drawing.Point(158, 369);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(67, 63);
            this.btnEquals.TabIndex = 2;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDecimal.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDecimal.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnDecimal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecimal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDecimal.Location = new System.Drawing.Point(85, 369);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(67, 63);
            this.btnDecimal.TabIndex = 2;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.numButton_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn0.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.Font = new System.Drawing.Font("Segoe UI Semibold", 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(13, 369);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(67, 63);
            this.btn0.TabIndex = 2;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.numButton_Click);
            // 
            // btnX2
            // 
            this.btnX2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnX2.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnX2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnX2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnX2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnX2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnX2.Location = new System.Drawing.Point(534, 93);
            this.btnX2.Name = "btnX2";
            this.btnX2.Size = new System.Drawing.Size(67, 63);
            this.btnX2.TabIndex = 3;
            this.btnX2.Text = "x^2";
            this.btnX2.UseVisualStyleBackColor = false;
            this.btnX2.Click += new System.EventHandler(this.btnX2_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSqrt.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnSqrt.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnSqrt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSqrt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSqrt.Location = new System.Drawing.Point(461, 93);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(67, 63);
            this.btnSqrt.TabIndex = 20;
            this.btnSqrt.Text = "Sqrt";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLog.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnLog.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLog.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLog.Location = new System.Drawing.Point(388, 93);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(67, 63);
            this.btnLog.TabIndex = 19;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnX3
            // 
            this.btnX3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnX3.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnX3.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnX3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnX3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnX3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnX3.Location = new System.Drawing.Point(534, 162);
            this.btnX3.Name = "btnX3";
            this.btnX3.Size = new System.Drawing.Size(67, 63);
            this.btnX3.TabIndex = 18;
            this.btnX3.Text = "x^3";
            this.btnX3.UseVisualStyleBackColor = false;
            this.btnX3.Click += new System.EventHandler(this.btnX3_Click);
            // 
            // btnExp
            // 
            this.btnExp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnExp.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnExp.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnExp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnExp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExp.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExp.Location = new System.Drawing.Point(316, 369);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(67, 63);
            this.btnExp.TabIndex = 17;
            this.btnExp.Text = "Exp";
            this.btnExp.UseVisualStyleBackColor = false;
            this.btnExp.Click += new System.EventHandler(this.Arithmetic_Operator);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMod.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnMod.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnMod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMod.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMod.Location = new System.Drawing.Point(388, 369);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(67, 63);
            this.btnMod.TabIndex = 16;
            this.btnMod.Text = "Mod";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.Arithmetic_Operator);
            // 
            // btnOct
            // 
            this.btnOct.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnOct.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnOct.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnOct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnOct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOct.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOct.Location = new System.Drawing.Point(461, 369);
            this.btnOct.Name = "btnOct";
            this.btnOct.Size = new System.Drawing.Size(67, 63);
            this.btnOct.TabIndex = 15;
            this.btnOct.Text = "Oct";
            this.btnOct.UseVisualStyleBackColor = false;
            this.btnOct.Click += new System.EventHandler(this.btnOct_Click);
            // 
            // btnHex
            // 
            this.btnHex.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHex.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnHex.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnHex.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnHex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHex.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHex.Location = new System.Drawing.Point(461, 300);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(67, 63);
            this.btnHex.TabIndex = 14;
            this.btnHex.Text = "Hex";
            this.btnHex.UseVisualStyleBackColor = false;
            this.btnHex.Click += new System.EventHandler(this.btnHex_Click);
            // 
            // btnTan
            // 
            this.btnTan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTan.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnTan.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnTan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnTan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTan.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTan.Location = new System.Drawing.Point(388, 300);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(67, 63);
            this.btnTan.TabIndex = 13;
            this.btnTan.Text = "Tan";
            this.btnTan.UseVisualStyleBackColor = false;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnTanh
            // 
            this.btnTanh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTanh.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnTanh.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnTanh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnTanh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTanh.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTanh.Location = new System.Drawing.Point(315, 300);
            this.btnTanh.Name = "btnTanh";
            this.btnTanh.Size = new System.Drawing.Size(67, 63);
            this.btnTanh.TabIndex = 12;
            this.btnTanh.Text = "Tanh";
            this.btnTanh.UseVisualStyleBackColor = false;
            this.btnTanh.Click += new System.EventHandler(this.btnTanh_Click);
            // 
            // btnCosh
            // 
            this.btnCosh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCosh.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnCosh.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnCosh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnCosh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCosh.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCosh.Location = new System.Drawing.Point(316, 231);
            this.btnCosh.Name = "btnCosh";
            this.btnCosh.Size = new System.Drawing.Size(67, 63);
            this.btnCosh.TabIndex = 11;
            this.btnCosh.Text = "Cosh";
            this.btnCosh.UseVisualStyleBackColor = false;
            this.btnCosh.Click += new System.EventHandler(this.btnCosh_Click);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCos.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnCos.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnCos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnCos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCos.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCos.Location = new System.Drawing.Point(388, 231);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(67, 63);
            this.btnCos.TabIndex = 10;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnBin
            // 
            this.btnBin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBin.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnBin.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnBin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnBin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBin.Location = new System.Drawing.Point(461, 231);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(67, 63);
            this.btnBin.TabIndex = 9;
            this.btnBin.Text = "Bin";
            this.btnBin.UseVisualStyleBackColor = false;
            this.btnBin.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // btn1X
            // 
            this.btn1X.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn1X.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn1X.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn1X.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn1X.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1X.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1X.Location = new System.Drawing.Point(534, 231);
            this.btn1X.Name = "btn1X";
            this.btn1X.Size = new System.Drawing.Size(67, 63);
            this.btn1X.TabIndex = 8;
            this.btn1X.Text = "1/x";
            this.btn1X.UseVisualStyleBackColor = false;
            this.btn1X.Click += new System.EventHandler(this.btn1X_Click);
            // 
            // btnLnX
            // 
            this.btnLnX.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLnX.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnLnX.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnLnX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnLnX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLnX.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLnX.Location = new System.Drawing.Point(534, 300);
            this.btnLnX.Name = "btnLnX";
            this.btnLnX.Size = new System.Drawing.Size(67, 63);
            this.btnLnX.TabIndex = 7;
            this.btnLnX.Text = "ln x";
            this.btnLnX.UseVisualStyleBackColor = false;
            this.btnLnX.Click += new System.EventHandler(this.btnLnX_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPercent.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnPercent.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnPercent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPercent.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPercent.Location = new System.Drawing.Point(534, 369);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(67, 63);
            this.btnPercent.TabIndex = 6;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = false;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // btnDec
            // 
            this.btnDec.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDec.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDec.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnDec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnDec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDec.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDec.Location = new System.Drawing.Point(461, 162);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(67, 63);
            this.btnDec.TabIndex = 5;
            this.btnDec.Text = "Dec";
            this.btnDec.UseVisualStyleBackColor = false;
            // 
            // btnSin
            // 
            this.btnSin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSin.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnSin.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnSin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnSin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSin.Location = new System.Drawing.Point(388, 162);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(67, 63);
            this.btnSin.TabIndex = 4;
            this.btnSin.Text = "Sin";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnSinh
            // 
            this.btnSinh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSinh.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnSinh.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnSinh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnSinh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSinh.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSinh.Location = new System.Drawing.Point(315, 162);
            this.btnSinh.Name = "btnSinh";
            this.btnSinh.Size = new System.Drawing.Size(67, 63);
            this.btnSinh.TabIndex = 21;
            this.btnSinh.Text = "Sinh";
            this.btnSinh.UseVisualStyleBackColor = false;
            this.btnSinh.Click += new System.EventHandler(this.btnSinh_Click);
            // 
            // btnPi
            // 
            this.btnPi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPi.BackgroundImage")));
            this.btnPi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPi.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnPi.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnPi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnPi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPi.Location = new System.Drawing.Point(315, 93);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(67, 63);
            this.btnPi.TabIndex = 22;
            this.btnPi.UseVisualStyleBackColor = false;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // tempGroupBox
            // 
            this.tempGroupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tempGroupBox.Controls.Add(this.tempConvertGroupBox);
            this.tempGroupBox.Controls.Add(this.btnResetTemp);
            this.tempGroupBox.Controls.Add(this.btnConvertTemp);
            this.tempGroupBox.Controls.Add(this.lblTempResultShow);
            this.tempGroupBox.Controls.Add(this.lblTempResult);
            this.tempGroupBox.Controls.Add(this.lblTempVal);
            this.tempGroupBox.Controls.Add(this.txtTempInput);
            this.tempGroupBox.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tempGroupBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tempGroupBox.Location = new System.Drawing.Point(620, 31);
            this.tempGroupBox.Name = "tempGroupBox";
            this.tempGroupBox.Size = new System.Drawing.Size(527, 401);
            this.tempGroupBox.TabIndex = 23;
            this.tempGroupBox.TabStop = false;
            this.tempGroupBox.Text = "Temperature";
            // 
            // tempConvertGroupBox
            // 
            this.tempConvertGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tempConvertGroupBox.Controls.Add(this.radioK);
            this.tempConvertGroupBox.Controls.Add(this.radioFtoC);
            this.tempConvertGroupBox.Controls.Add(this.radioCtoF);
            this.tempConvertGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tempConvertGroupBox.ForeColor = System.Drawing.Color.Navy;
            this.tempConvertGroupBox.Location = new System.Drawing.Point(14, 113);
            this.tempConvertGroupBox.Name = "tempConvertGroupBox";
            this.tempConvertGroupBox.Size = new System.Drawing.Size(484, 135);
            this.tempConvertGroupBox.TabIndex = 4;
            this.tempConvertGroupBox.TabStop = false;
            this.tempConvertGroupBox.Text = "Select Conversion Type";
            // 
            // radioK
            // 
            this.radioK.AutoSize = true;
            this.radioK.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioK.Location = new System.Drawing.Point(306, 50);
            this.radioK.Name = "radioK";
            this.radioK.Size = new System.Drawing.Size(88, 32);
            this.radioK.TabIndex = 1;
            this.radioK.TabStop = true;
            this.radioK.Text = "Kelvin";
            this.radioK.UseVisualStyleBackColor = true;
            this.radioK.CheckedChanged += new System.EventHandler(this.radioK_CheckedChanged);
            // 
            // radioFtoC
            // 
            this.radioFtoC.AutoSize = true;
            this.radioFtoC.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioFtoC.Location = new System.Drawing.Point(6, 87);
            this.radioFtoC.Name = "radioFtoC";
            this.radioFtoC.Size = new System.Drawing.Size(223, 32);
            this.radioFtoC.TabIndex = 2;
            this.radioFtoC.TabStop = true;
            this.radioFtoC.Text = "Fahrenheit to Celsius";
            this.radioFtoC.UseVisualStyleBackColor = true;
            this.radioFtoC.CheckedChanged += new System.EventHandler(this.radioFtoC_CheckedChanged);
            // 
            // radioCtoF
            // 
            this.radioCtoF.AutoSize = true;
            this.radioCtoF.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioCtoF.Location = new System.Drawing.Point(6, 50);
            this.radioCtoF.Name = "radioCtoF";
            this.radioCtoF.Size = new System.Drawing.Size(223, 32);
            this.radioCtoF.TabIndex = 3;
            this.radioCtoF.TabStop = true;
            this.radioCtoF.Text = "Celsius to Fahrenheit";
            this.radioCtoF.UseVisualStyleBackColor = true;
            this.radioCtoF.CheckedChanged += new System.EventHandler(this.radioCtoF_CheckedChanged);
            // 
            // btnResetTemp
            // 
            this.btnResetTemp.BackColor = System.Drawing.Color.DarkRed;
            this.btnResetTemp.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResetTemp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnResetTemp.Location = new System.Drawing.Point(348, 323);
            this.btnResetTemp.Name = "btnResetTemp";
            this.btnResetTemp.Size = new System.Drawing.Size(118, 57);
            this.btnResetTemp.TabIndex = 3;
            this.btnResetTemp.Text = "Reset";
            this.btnResetTemp.UseVisualStyleBackColor = false;
            this.btnResetTemp.Click += new System.EventHandler(this.btnResetTemp_Click);
            // 
            // btnConvertTemp
            // 
            this.btnConvertTemp.BackColor = System.Drawing.Color.DarkGreen;
            this.btnConvertTemp.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvertTemp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConvertTemp.Location = new System.Drawing.Point(61, 323);
            this.btnConvertTemp.Name = "btnConvertTemp";
            this.btnConvertTemp.Size = new System.Drawing.Size(118, 57);
            this.btnConvertTemp.TabIndex = 3;
            this.btnConvertTemp.Text = "Convert";
            this.btnConvertTemp.UseVisualStyleBackColor = false;
            this.btnConvertTemp.Click += new System.EventHandler(this.btnConvertTemp_Click);
            // 
            // lblTempResultShow
            // 
            this.lblTempResultShow.AutoSize = true;
            this.lblTempResultShow.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTempResultShow.Location = new System.Drawing.Point(348, 272);
            this.lblTempResultShow.Name = "lblTempResultShow";
            this.lblTempResultShow.Size = new System.Drawing.Size(0, 38);
            this.lblTempResultShow.TabIndex = 2;
            // 
            // lblTempResult
            // 
            this.lblTempResult.AutoSize = true;
            this.lblTempResult.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTempResult.Location = new System.Drawing.Point(225, 272);
            this.lblTempResult.Name = "lblTempResult";
            this.lblTempResult.Size = new System.Drawing.Size(105, 38);
            this.lblTempResult.TabIndex = 2;
            this.lblTempResult.Text = "Result:";
            // 
            // lblTempVal
            // 
            this.lblTempVal.AutoSize = true;
            this.lblTempVal.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTempVal.Location = new System.Drawing.Point(6, 59);
            this.lblTempVal.Name = "lblTempVal";
            this.lblTempVal.Size = new System.Drawing.Size(303, 38);
            this.lblTempVal.TabIndex = 2;
            this.lblTempVal.Text = "Enter Value to Convert";
            // 
            // txtTempInput
            // 
            this.txtTempInput.Location = new System.Drawing.Point(320, 50);
            this.txtTempInput.Name = "txtTempInput";
            this.txtTempInput.Size = new System.Drawing.Size(178, 51);
            this.txtTempInput.TabIndex = 1;
            // 
            // lblShowOp
            // 
            this.lblShowOp.AutoSize = true;
            this.lblShowOp.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShowOp.Location = new System.Drawing.Point(25, 46);
            this.lblShowOp.Name = "lblShowOp";
            this.lblShowOp.Size = new System.Drawing.Size(0, 15);
            this.lblShowOp.TabIndex = 24;
            // 
            // multiplicationGBox
            // 
            this.multiplicationGBox.BackColor = System.Drawing.Color.MistyRose;
            this.multiplicationGBox.Controls.Add(this.txtMultiply);
            this.multiplicationGBox.Controls.Add(this.btnResetM);
            this.multiplicationGBox.Controls.Add(this.btnMultiply);
            this.multiplicationGBox.Controls.Add(this.lstMultiply);
            this.multiplicationGBox.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.multiplicationGBox.ForeColor = System.Drawing.Color.Maroon;
            this.multiplicationGBox.Location = new System.Drawing.Point(1153, 31);
            this.multiplicationGBox.Name = "multiplicationGBox";
            this.multiplicationGBox.Size = new System.Drawing.Size(394, 401);
            this.multiplicationGBox.TabIndex = 25;
            this.multiplicationGBox.TabStop = false;
            this.multiplicationGBox.Text = "Multiplication";
            // 
            // txtMultiply
            // 
            this.txtMultiply.Location = new System.Drawing.Point(257, 163);
            this.txtMultiply.Name = "txtMultiply";
            this.txtMultiply.Size = new System.Drawing.Size(125, 51);
            this.txtMultiply.TabIndex = 2;
            // 
            // btnResetM
            // 
            this.btnResetM.BackColor = System.Drawing.Color.DarkRed;
            this.btnResetM.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnResetM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetM.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResetM.ForeColor = System.Drawing.Color.Snow;
            this.btnResetM.Location = new System.Drawing.Point(257, 272);
            this.btnResetM.Name = "btnResetM";
            this.btnResetM.Size = new System.Drawing.Size(125, 44);
            this.btnResetM.TabIndex = 1;
            this.btnResetM.Text = "Reset";
            this.btnResetM.UseVisualStyleBackColor = false;
            this.btnResetM.Click += new System.EventHandler(this.btnResetM_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.SeaShell;
            this.btnMultiply.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMultiply.ForeColor = System.Drawing.Color.DarkRed;
            this.btnMultiply.Location = new System.Drawing.Point(257, 221);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(125, 44);
            this.btnMultiply.TabIndex = 1;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // lstMultiply
            // 
            this.lstMultiply.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstMultiply.ForeColor = System.Drawing.Color.Maroon;
            this.lstMultiply.FormattingEnabled = true;
            this.lstMultiply.ItemHeight = 28;
            this.lstMultiply.Location = new System.Drawing.Point(16, 50);
            this.lstMultiply.Name = "lstMultiply";
            this.lstMultiply.Size = new System.Drawing.Size(218, 340);
            this.lstMultiply.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1582, 461);
            this.Controls.Add(this.multiplicationGBox);
            this.Controls.Add(this.lblShowOp);
            this.Controls.Add(this.tempGroupBox);
            this.Controls.Add(this.btnX2);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnX3);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnOct);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnTanh);
            this.Controls.Add(this.btnCosh);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnBin);
            this.Controls.Add(this.btn1X);
            this.Controls.Add(this.btnLnX);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnSinh);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.calcInputBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tempGroupBox.ResumeLayout(false);
            this.tempGroupBox.PerformLayout();
            this.tempConvertGroupBox.ResumeLayout(false);
            this.tempConvertGroupBox.PerformLayout();
            this.multiplicationGBox.ResumeLayout(false);
            this.multiplicationGBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.TextBox calcInputBox;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnX2;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnX3;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnOct;
        private System.Windows.Forms.Button btnHex;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnTanh;
        private System.Windows.Forms.Button btnCosh;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnBin;
        private System.Windows.Forms.Button btn1X;
        private System.Windows.Forms.Button btnLnX;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnSinh;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.GroupBox tempGroupBox;
        private System.Windows.Forms.Label lblTempVal;
        private System.Windows.Forms.TextBox txtTempInput;
        private System.Windows.Forms.Label lblTempResult;
        private System.Windows.Forms.Button btnConvertTemp;
        private System.Windows.Forms.Button btnResetTemp;
        private System.Windows.Forms.GroupBox tempConvertGroupBox;
        private System.Windows.Forms.RadioButton radioK;
        private System.Windows.Forms.RadioButton radioFtoC;
        private System.Windows.Forms.RadioButton radioCtoF;
        private System.Windows.Forms.Label lblShowOp;
        private System.Windows.Forms.Label lblTempResultShow;
        private System.Windows.Forms.GroupBox multiplicationGBox;
        private System.Windows.Forms.ListBox lstMultiply;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnResetM;
        private System.Windows.Forms.TextBox txtMultiply;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

