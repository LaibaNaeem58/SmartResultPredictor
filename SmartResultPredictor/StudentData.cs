using Microsoft.ML.Data;

namespace SmartResultPredictor
{
    // ── Input Class: features used by the ML model ──────────────
    public class StudentData
    {
        [LoadColumn(0)]
        public float Marks { get; set; }        // Feature: student marks (0-100)

        [LoadColumn(1)]
        [ColumnName("Label")]
        public bool PassFail { get; set; }      // Label: true = Pass, false = Fail
    }

    // ── Output/Prediction Class ──────────────────────────────────
    public class StudentPrediction
    {
        [ColumnName("PredictedLabel")]
        public bool PassFail { get; set; }      // Predicted Pass/Fail result

        public float Probability { get; set; }  // Confidence probability (0-1)

        public float Score { get; set; }        // Raw score from the model
    }
}
