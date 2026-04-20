using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartResultPredictor
{
    public partial class Form1 : Form
    {
        private MLModel _model;

        public Form1()
        {
            InitializeComponent();
            _model = new MLModel();
            lblResult.Text = "Enter marks above and click Predict.";
            lblConfidence.Text = "";
        }

        // ── Predict Button Click ──────────────────────────────────
        private void btnPredict_Click(object sender, EventArgs e)
        {
            // Validate input
            if (!float.TryParse(txtMarks.Text.Trim(), out float marks))
            {
                MessageBox.Show("Please enter a valid number for marks.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMarks.Focus();
                return;
            }

            if (marks < 0 || marks > 100)
            {
                MessageBox.Show("Marks must be between 0 and 100.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMarks.Focus();
                return;
            }

            // ── Run prediction ────────────────────────────────────
            var prediction = _model.Predict(marks);
            string result     = prediction.PassFail ? "PASS  ✓" : "FAIL  ✗";
            float  confidence = prediction.Probability * 100f;

            // ── Display via Label (as required) ───────────────────
            lblResult.Text      = $"Result:  {result}";
            lblResult.ForeColor = prediction.PassFail
                ? Color.FromArgb(0, 140, 70)
                : Color.FromArgb(200, 30, 30);

            lblConfidence.Text = $"Confidence: {confidence:F1}%     |     Marks entered: {marks}";
        }

        // ── Clear Button Click ────────────────────────────────────
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMarks.Clear();
            lblResult.Text      = "Enter marks above and click Predict.";
            lblResult.ForeColor = SystemColors.ControlText;
            lblConfidence.Text  = "";
            txtMarks.Focus();
        }
    }
}
