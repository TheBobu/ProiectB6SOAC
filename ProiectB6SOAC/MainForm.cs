using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProiectB6SOAC
{
    public partial class MainForm : Form
    {
        public List<string> Files { get; set; }
        public List<Trace> Traces { get; set; }
        public Predictor Predictor { get; set; }

        private bool isStanford;
        private bool isSpec2000;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoadStanford_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Environment.CurrentDirectory);
            string[] stanfordFilenames =
                Directory
                .GetFiles(Path.GetFullPath(@"..\Debug\Benchmarks\Stanford"), "*.TRA")
                .Select(Path.GetFileName)
                .ToArray();

            Files = stanfordFilenames.ToList();
            checkedListBoxFiles.Items.AddRange(stanfordFilenames);

            isStanford = true;
            isSpec2000 = false;
        }

        private void btnLoadSpec_Click(object sender, EventArgs e)
        {
            string[] specFilenames =
                Directory
                .GetFiles(Path.GetFullPath(@"..\Debug\Benchmarks\Spec2000"), "*.TRA")
                .Select(Path.GetFileName)
                .ToArray();

            Files = specFilenames.ToList();
            checkedListBoxFiles.Items.AddRange(specFilenames);

            isStanford = false;
            isSpec2000 = true;
        }

        private void ReadTraces()
        {
            Traces = new List<Trace>();
            TextFieldParser traceReader;
            var checkedItems = checkedListBoxFiles.CheckedItems.Cast<string>().ToList();
            foreach (string file in Files)
            {
                if (checkedItems.Contains(file))
                {
                    if (isSpec2000)
                    {
                        traceReader = new TextFieldParser(Path.GetFullPath(@"..\Debug\Benchmarks\Spec2000\") + file);
                    }
                    else if (isStanford)
                    {
                        traceReader = new TextFieldParser(Path.GetFullPath(@"..\Debug\Benchmarks\Stanford\") + file);
                    }
                    else
                    {
                        return;
                    }
                    string[] delimiters = { ",", " " };

                    traceReader.TextFieldType = FieldType.Delimited;
                    traceReader.SetDelimiters(delimiters);
                    Trace trace = new Trace();
                    while (!traceReader.EndOfData)
                    {
                        string[] instrLine = traceReader.ReadFields();
                        if (instrLine[0].Contains("T") || instrLine[0].Contains("F"))
                        {
                            trace.TipBranch.Add(instrLine[0]);
                            trace.PC.Add(Convert.ToInt16(instrLine[1]));
                            trace.AdrDest.Add(Convert.ToInt16(instrLine[2]));
                        }
                    }

                    traceReader.Close();
                    trace.Length = trace.TipBranch.Count;
                    trace.Name = file;
                    Traces.Add(trace);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ReadTraces();
            if (Traces.Count > 0)
            {
                Predictor = new Predictor((int)numericUpDownTables.Value, (double)numericUpDownAlfa.Value, Traces);
                Predictor.Run();
                DisplayResults();
            }
            else
            {
                MessageBox.Show("Please select a trace to begin.");
            }
        }

        public void DisplayResults()
        {
            chartAccuracy.Series.Clear();
            chartAccuracy.ChartAreas[0].AxisY.MajorGrid.Interval = 5;
            chartAccuracy.ChartAreas[0].AxisY.Interval = 10;
            foreach (var result in Predictor.Results)
            {
                chartAccuracy.Series.Add(result.Name);
                chartAccuracy.Series[result.Name]["PointWidth"] = "1.8";
                chartAccuracy.Series[result.Name].Points.Add(Math.Round(result.Accuracy * 100, 2));
                chartAccuracy.Series[result.Name].ChartType = SeriesChartType.Column;
                chartAccuracy.Series[result.Name].IsValueShownAsLabel = true;
                chartAccuracy.Series[result.Name].LabelBackColor = Color.White;

                richTextBoxOutput.AppendText(result.Name + Environment.NewLine);
                richTextBoxOutput.AppendText("Acuratete: " + Math.Round(result.Accuracy * 100, 2) + "%" + Environment.NewLine);
                richTextBoxOutput.AppendText("Predictionate corect: " + result.CorrecttlyPredicted + Environment.NewLine);
                richTextBoxOutput.AppendText("Predictionate incorect: " + result.IncorrecttlyPredicted + Environment.NewLine);
                richTextBoxOutput.AppendText("Branch-uri taken: " + result.TakenBranches + Environment.NewLine);
                richTextBoxOutput.AppendText("Branch-uri not taken: " + result.NotTakenBranches + Environment.NewLine);
                richTextBoxOutput.AppendText("---------------------------------------------------------" + Environment.NewLine);
            }
        }
    }
}