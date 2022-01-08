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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartAccuracy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlfa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(556, 14);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(107, 32);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // checkedListBoxFiles
            // 
            this.checkedListBoxFiles.CheckOnClick = true;
            this.checkedListBoxFiles.FormattingEnabled = true;
            this.checkedListBoxFiles.Location = new System.Drawing.Point(16, 54);
            this.checkedListBoxFiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListBoxFiles.Name = "checkedListBoxFiles";
            this.checkedListBoxFiles.Size = new System.Drawing.Size(261, 344);
            this.checkedListBoxFiles.TabIndex = 1;
            // 
            // chartAccuracy
            // 
            chartArea4.Name = "ChartArea1";
            this.chartAccuracy.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartAccuracy.Legends.Add(legend4);
            this.chartAccuracy.Location = new System.Drawing.Point(287, 54);
            this.chartAccuracy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartAccuracy.Name = "chartAccuracy";
            this.chartAccuracy.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartAccuracy.Series.Add(series4);
            this.chartAccuracy.Size = new System.Drawing.Size(764, 591);
            this.chartAccuracy.TabIndex = 2;
            this.chartAccuracy.Text = "chart1";
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(16, 417);
            this.richTextBoxOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(261, 227);
            this.richTextBoxOutput.TabIndex = 3;
            this.richTextBoxOutput.Text = "";
            // 
            // btnLoadStanford
            // 
            this.btnLoadStanford.Location = new System.Drawing.Point(195, 15);
            this.btnLoadStanford.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadStanford.Name = "btnLoadStanford";
            this.btnLoadStanford.Size = new System.Drawing.Size(164, 31);
            this.btnLoadStanford.TabIndex = 4;
            this.btnLoadStanford.Text = "Load Stanford Traces";
            this.btnLoadStanford.UseVisualStyleBackColor = true;
            this.btnLoadStanford.Click += new System.EventHandler(this.btnLoadStanford_Click);
            // 
            // btnLoadSpec
            // 
            this.btnLoadSpec.Location = new System.Drawing.Point(367, 14);
            this.btnLoadSpec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadSpec.Name = "btnLoadSpec";
            this.btnLoadSpec.Size = new System.Drawing.Size(181, 31);
            this.btnLoadSpec.TabIndex = 5;
            this.btnLoadSpec.Text = "Load SPEC2000 Traces";
            this.btnLoadSpec.UseVisualStyleBackColor = true;
            this.btnLoadSpec.Click += new System.EventHandler(this.btnLoadSpec_Click);
            // 
            // numericUpDownTables
            // 
            this.numericUpDownTables.Location = new System.Drawing.Point(960, 15);
            this.numericUpDownTables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.numericUpDownTables.Size = new System.Drawing.Size(91, 22);
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
            this.numericUpDownAlfa.Location = new System.Drawing.Point(740, 14);
            this.numericUpDownAlfa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.numericUpDownAlfa.Size = new System.Drawing.Size(89, 22);
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
            this.label1.Location = new System.Drawing.Point(699, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Alfa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(865, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nr of Tables";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Select Benchmark Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 663);
            this.Controls.Add(this.button1);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button button1;
    }
}

