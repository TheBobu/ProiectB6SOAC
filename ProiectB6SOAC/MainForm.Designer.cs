namespace ProiectB6SOAC
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnStart = new System.Windows.Forms.Button();
            this.checkedListBoxFiles = new System.Windows.Forms.CheckedListBox();
            this.chartAccuracy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.btnLoadStanford = new System.Windows.Forms.Button();
            this.btnLoadSpec = new System.Windows.Forms.Button();
            this.numericUpDownTables = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAlfa = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartAccuracy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlfa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(283, 11);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 26);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // checkedListBoxFiles
            // 
            this.checkedListBoxFiles.CheckOnClick = true;
            this.checkedListBoxFiles.FormattingEnabled = true;
            this.checkedListBoxFiles.Location = new System.Drawing.Point(12, 44);
            this.checkedListBoxFiles.Name = "checkedListBoxFiles";
            this.checkedListBoxFiles.Size = new System.Drawing.Size(197, 289);
            this.checkedListBoxFiles.TabIndex = 1;
            // 
            // chartAccuracy
            // 
            chartArea1.Name = "ChartArea1";
            this.chartAccuracy.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAccuracy.Legends.Add(legend1);
            this.chartAccuracy.Location = new System.Drawing.Point(215, 44);
            this.chartAccuracy.Name = "chartAccuracy";
            this.chartAccuracy.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartAccuracy.Series.Add(series1);
            this.chartAccuracy.Size = new System.Drawing.Size(573, 480);
            this.chartAccuracy.TabIndex = 2;
            this.chartAccuracy.Text = "chart1";
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(12, 339);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(197, 185);
            this.richTextBoxOutput.TabIndex = 3;
            this.richTextBoxOutput.Text = "";
            // 
            // btnLoadStanford
            // 
            this.btnLoadStanford.Location = new System.Drawing.Point(12, 12);
            this.btnLoadStanford.Name = "btnLoadStanford";
            this.btnLoadStanford.Size = new System.Drawing.Size(123, 25);
            this.btnLoadStanford.TabIndex = 4;
            this.btnLoadStanford.Text = "Load Stanford Traces";
            this.btnLoadStanford.UseVisualStyleBackColor = true;
            this.btnLoadStanford.Click += new System.EventHandler(this.btnLoadStanford_Click);
            // 
            // btnLoadSpec
            // 
            this.btnLoadSpec.Location = new System.Drawing.Point(141, 12);
            this.btnLoadSpec.Name = "btnLoadSpec";
            this.btnLoadSpec.Size = new System.Drawing.Size(136, 25);
            this.btnLoadSpec.TabIndex = 5;
            this.btnLoadSpec.Text = "Load SPEC2000 Traces";
            this.btnLoadSpec.UseVisualStyleBackColor = true;
            this.btnLoadSpec.Click += new System.EventHandler(this.btnLoadSpec_Click);
            // 
            // numericUpDownTables
            // 
            this.numericUpDownTables.Location = new System.Drawing.Point(720, 12);
            this.numericUpDownTables.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownTables.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownTables.Name = "numericUpDownTables";
            this.numericUpDownTables.Size = new System.Drawing.Size(68, 20);
            this.numericUpDownTables.TabIndex = 6;
            this.numericUpDownTables.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // numericUpDownAlfa
            // 
            this.numericUpDownAlfa.DecimalPlaces = 2;
            this.numericUpDownAlfa.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownAlfa.Location = new System.Drawing.Point(555, 11);
            this.numericUpDownAlfa.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownAlfa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownAlfa.Name = "numericUpDownAlfa";
            this.numericUpDownAlfa.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownAlfa.TabIndex = 7;
            this.numericUpDownAlfa.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Alfa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(649, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nr of Tables";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownAlfa);
            this.Controls.Add(this.numericUpDownTables);
            this.Controls.Add(this.btnLoadSpec);
            this.Controls.Add(this.btnLoadStanford);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.chartAccuracy);
            this.Controls.Add(this.checkedListBoxFiles);
            this.Controls.Add(this.btnStart);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartAccuracy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlfa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckedListBox checkedListBoxFiles;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAccuracy;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.Button btnLoadStanford;
        private System.Windows.Forms.Button btnLoadSpec;
        private System.Windows.Forms.NumericUpDown numericUpDownTables;
        private System.Windows.Forms.NumericUpDown numericUpDownAlfa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

