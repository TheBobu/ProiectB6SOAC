using System;
using System.Collections.Generic;

namespace ProiectB6SOAC
{
    public class Predictor
    {
        public List<PredictorTable> T { get; set; }
        public int M { get; set; }
        public double Alfa { get; set; }
        public List<Trace> Traces { get; }
        public Register HRG { get; set; }

        public List<ResultData> Results { get; set; }

        private readonly int hrgLength = 8;

        public Predictor(int nrTabelePredictie, double alfa, List<Trace> traces)
        {
            Alfa = alfa;
            Traces = traces;
            M = nrTabelePredictie;
            T = new List<PredictorTable>();

            Random random = new Random();
            int[] L = new int[M];
            L[0] = 0;
            L[1] = 3;
            for (int i = 2; i < M; i++)
            {
                L[i] = (int)(Math.Pow(Alfa, i) * L[1] + 0.5);
            }
            for (int i = 0; i < nrTabelePredictie; i++)
            {
                T.Add(new PredictorTable(L[i], random));
            }
        }

        public int IndexingFunction(int PC, int i)
        {
            return Math.Abs(PC * HRG.GetIndex(0)) % T[i].table.Length;
        }

        public void Run()
        {
            Results = new List<ResultData>();
            HRG = new Register(hrgLength);
            int threshold = M;
            foreach (var trace in Traces)
            {
                HRG.Reset();
                int correct = 0;
                int incorrect = 0;
                int taken = 0;
                int notTaken = 0;
                for (int i = 0; i < trace.Length; i++)
                {
                    var tipBranch = trace.TipBranch[i];
                    var outcome = tipBranch[0].Equals('B') ? 1 : -1;
                    var predictionValue = Predict(trace.PC[i]);
                    var prediction = predictionValue > 0 ? 1 : -1;

                    taken = outcome == 1 ? taken + 1 : taken;
                    notTaken = outcome == -1 ? notTaken + 1 : notTaken;

                    if (prediction.Equals(outcome))
                    {
                        correct++;
                    }
                    else
                    {
                        incorrect++;

                        //Update Tables
                        if (predictionValue < threshold)
                        {
                            for (int j = 1; j < M; j++)
                            {
                                var index = IndexingFunction(trace.PC[i], j);
                                if (outcome == 1)
                                {
                                    T[j].table[index] += 1;
                                }
                                else
                                {
                                    T[j].table[index] -= 1;
                                }
                            }
                        }
                    }
                    HRG.AddNewEntry(outcome);
                }

                Results.Add(new ResultData
                {
                    Accuracy = (double)(correct) / trace.Length,
                    CorrecttlyPredicted = correct,
                    IncorrecttlyPredicted = incorrect,
                    TakenBranches = taken,
                    NotTakenBranches = notTaken,
                    Name = trace.Name
                }
                );
            }
        }

        public double Predict(int PC)
        {
            int sum = 0;
            for (int j = 1; j < M; j++)
            {
                var index = IndexingFunction(PC, j);
                sum += T[j].table[index];
            }
            var S = M / 2.0 + sum;
            return S;
        }
    }
}