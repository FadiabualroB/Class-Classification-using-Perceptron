namespace ANN
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DL_ActivationFunction = new System.Windows.Forms.ComboBox();
            this.TB_learningRate = new System.Windows.Forms.TrackBar();
            this.txtActivationFunction = new System.Windows.Forms.Label();
            this.txtLearningRate = new System.Windows.Forms.Label();
            this.txtMaximumIterations = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DL_ColorSelector = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MousePosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Itteration = new System.Windows.Forms.TextBox();
            this.txtThreashold = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rd_binery = new System.Windows.Forms.RadioButton();
            this.rd_multi = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TB_learningRate)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(315, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 347);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.DL_ActivationFunction);
            this.groupBox1.Controls.Add(this.TB_learningRate);
            this.groupBox1.Controls.Add(this.txtActivationFunction);
            this.groupBox1.Controls.Add(this.txtLearningRate);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 129);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(109, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 25);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "0.2";
            // 
            // DL_ActivationFunction
            // 
            this.DL_ActivationFunction.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DL_ActivationFunction.FormattingEnabled = true;
            this.DL_ActivationFunction.Items.AddRange(new object[] {
            "Step",
            "Tanh",
            "Sigmond"});
            this.DL_ActivationFunction.Location = new System.Drawing.Point(157, 82);
            this.DL_ActivationFunction.Name = "DL_ActivationFunction";
            this.DL_ActivationFunction.Size = new System.Drawing.Size(132, 25);
            this.DL_ActivationFunction.TabIndex = 10;
            this.DL_ActivationFunction.Text = "Step";
            // 
            // TB_learningRate
            // 
            this.TB_learningRate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TB_learningRate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TB_learningRate.LargeChange = 10;
            this.TB_learningRate.Location = new System.Drawing.Point(157, 22);
            this.TB_learningRate.Name = "TB_learningRate";
            this.TB_learningRate.Size = new System.Drawing.Size(132, 45);
            this.TB_learningRate.TabIndex = 6;
            this.TB_learningRate.Scroll += new System.EventHandler(this.TB_learningRate_Scroll);
            // 
            // txtActivationFunction
            // 
            this.txtActivationFunction.AutoSize = true;
            this.txtActivationFunction.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtActivationFunction.Location = new System.Drawing.Point(15, 85);
            this.txtActivationFunction.Name = "txtActivationFunction";
            this.txtActivationFunction.Size = new System.Drawing.Size(126, 17);
            this.txtActivationFunction.TabIndex = 4;
            this.txtActivationFunction.Text = "Activation Function";
            // 
            // txtLearningRate
            // 
            this.txtLearningRate.AutoSize = true;
            this.txtLearningRate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLearningRate.Location = new System.Drawing.Point(15, 22);
            this.txtLearningRate.Name = "txtLearningRate";
            this.txtLearningRate.Size = new System.Drawing.Size(91, 17);
            this.txtLearningRate.TabIndex = 3;
            this.txtLearningRate.Text = "Learning Rate";
            // 
            // txtMaximumIterations
            // 
            this.txtMaximumIterations.AutoSize = true;
            this.txtMaximumIterations.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMaximumIterations.Location = new System.Drawing.Point(15, 42);
            this.txtMaximumIterations.Name = "txtMaximumIterations";
            this.txtMaximumIterations.Size = new System.Drawing.Size(131, 17);
            this.txtMaximumIterations.TabIndex = 13;
            this.txtMaximumIterations.Text = "Maximum Iterations";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(169, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DL_ColorSelector
            // 
            this.DL_ColorSelector.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DL_ColorSelector.FormattingEnabled = true;
            this.DL_ColorSelector.Items.AddRange(new object[] {
            "Red",
            "Blue"});
            this.DL_ColorSelector.Location = new System.Drawing.Point(758, 20);
            this.DL_ColorSelector.Name = "DL_ColorSelector";
            this.DL_ColorSelector.Size = new System.Drawing.Size(158, 25);
            this.DL_ColorSelector.TabIndex = 0;
            this.DL_ColorSelector.Text = "Red";
            this.DL_ColorSelector.SelectedIndexChanged += new System.EventHandler(this.DL_ColorSelector_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MousePosition});
            this.statusStrip1.Location = new System.Drawing.Point(0, 429);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(922, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MousePosition
            // 
            this.MousePosition.Name = "MousePosition";
            this.MousePosition.Size = new System.Drawing.Size(40, 17);
            this.MousePosition.Text = "X:- Y:-";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Itteration);
            this.groupBox2.Controls.Add(this.txtThreashold);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtMaximumIterations);
            this.groupBox2.Location = new System.Drawing.Point(12, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 132);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stopping Creteria";
            // 
            // txt_Itteration
            // 
            this.txt_Itteration.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Itteration.Location = new System.Drawing.Point(170, 42);
            this.txt_Itteration.Name = "txt_Itteration";
            this.txt_Itteration.Size = new System.Drawing.Size(119, 25);
            this.txt_Itteration.TabIndex = 22;
            this.txt_Itteration.Text = "10000";
            this.txt_Itteration.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtThreashold
            // 
            this.txtThreashold.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtThreashold.Location = new System.Drawing.Point(170, 93);
            this.txtThreashold.Name = "txtThreashold";
            this.txtThreashold.Size = new System.Drawing.Size(119, 25);
            this.txtThreashold.TabIndex = 21;
            this.txtThreashold.Text = "-1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(15, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Threashold";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(675, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Select Class";
            // 
            // rd_binery
            // 
            this.rd_binery.AutoSize = true;
            this.rd_binery.Checked = true;
            this.rd_binery.Location = new System.Drawing.Point(427, 27);
            this.rd_binery.Name = "rd_binery";
            this.rd_binery.Size = new System.Drawing.Size(58, 19);
            this.rd_binery.TabIndex = 50;
            this.rd_binery.TabStop = true;
            this.rd_binery.Text = "Binery";
            this.rd_binery.UseVisualStyleBackColor = true;
            this.rd_binery.CheckedChanged += new System.EventHandler(this.rd_binery_CheckedChanged);
            // 
            // rd_multi
            // 
            this.rd_multi.AutoSize = true;
            this.rd_multi.Location = new System.Drawing.Point(514, 27);
            this.rd_multi.Name = "rd_multi";
            this.rd_multi.Size = new System.Drawing.Size(85, 19);
            this.rd_multi.TabIndex = 51;
            this.rd_multi.Text = "Multi-Class";
            this.rd_multi.UseVisualStyleBackColor = true;
            this.rd_multi.CheckedChanged += new System.EventHandler(this.rd_multi_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(315, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Run Time";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(21, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 35);
            this.button2.TabIndex = 53;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(922, 451);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rd_multi);
            this.Controls.Add(this.rd_binery);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DL_ColorSelector);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Class Clarification";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TB_learningRate)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private ComboBox DL_ColorSelector;
        private Button button1;
        private TrackBar TB_learningRate;
        private Label txtActivationFunction;
        private Label txtLearningRate;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel MousePosition;
        private Label txtMaximumIterations;
        private ComboBox DL_ActivationFunction;
        private GroupBox groupBox2;
        private Label label5;
        private Label label9;
        private TextBox txtThreashold;
        private TextBox txt_Itteration;
        private RadioButton rd_binery;
        private RadioButton rd_multi;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
    }
}