namespace SmartResultPredictor
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // ── Control declarations ──────────────────────────────────
        private System.Windows.Forms.Panel      pnlHeader;
        private System.Windows.Forms.Label      lblTitle;
        private System.Windows.Forms.Label      lblSubtitle;
        private System.Windows.Forms.Panel      pnlBody;
        private System.Windows.Forms.Label      lblMarksInput;
        private System.Windows.Forms.TextBox    txtMarks;
        private System.Windows.Forms.Button     btnPredict;
        private System.Windows.Forms.Button     btnClear;
        private System.Windows.Forms.Panel      pnlResultBox;
        private System.Windows.Forms.Label      lblResultHeading;
        private System.Windows.Forms.Label      lblResult;
        private System.Windows.Forms.Label      lblConfidence;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblMarksInput = new System.Windows.Forms.Label();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.btnPredict = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlResultBox = new System.Windows.Forms.Panel();
            this.lblResultHeading = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblConfidence = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlResultBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(185)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pnlHeader.Size = new System.Drawing.Size(476, 80);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(507, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Smart Result Prediction System";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.lblSubtitle.Location = new System.Drawing.Point(22, 46);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(466, 28);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "ML.NET  ·  Binary Classification  ·  Pass / Fail Predictor";
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.pnlBody.Controls.Add(this.lblMarksInput);
            this.pnlBody.Controls.Add(this.txtMarks);
            this.pnlBody.Controls.Add(this.btnPredict);
            this.pnlBody.Controls.Add(this.btnClear);
            this.pnlBody.Controls.Add(this.pnlResultBox);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 80);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(30, 24, 30, 20);
            this.pnlBody.Size = new System.Drawing.Size(476, 316);
            this.pnlBody.TabIndex = 0;
            // 
            // lblMarksInput
            // 
            this.lblMarksInput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMarksInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.lblMarksInput.Location = new System.Drawing.Point(30, 30);
            this.lblMarksInput.Name = "lblMarksInput";
            this.lblMarksInput.Size = new System.Drawing.Size(300, 22);
            this.lblMarksInput.TabIndex = 0;
            this.lblMarksInput.Text = "Student Marks  (0 – 100)";
            // 
            // txtMarks
            // 
            this.txtMarks.BackColor = System.Drawing.Color.White;
            this.txtMarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarks.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtMarks.Location = new System.Drawing.Point(30, 56);
            this.txtMarks.MaxLength = 6;
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(200, 48);
            this.txtMarks.TabIndex = 1;
            // 
            // btnPredict
            // 
            this.btnPredict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(185)))));
            this.btnPredict.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPredict.FlatAppearance.BorderSize = 0;
            this.btnPredict.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(110)))), ((int)(((byte)(210)))));
            this.btnPredict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPredict.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPredict.ForeColor = System.Drawing.Color.White;
            this.btnPredict.Location = new System.Drawing.Point(30, 106);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(120, 38);
            this.btnPredict.TabIndex = 2;
            this.btnPredict.Text = "  Predict  ";
            this.btnPredict.UseVisualStyleBackColor = false;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(212)))), ((int)(((byte)(220)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnClear.Location = new System.Drawing.Point(164, 106);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 38);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "  Clear  ";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlResultBox
            // 
            this.pnlResultBox.BackColor = System.Drawing.Color.White;
            this.pnlResultBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResultBox.Controls.Add(this.lblResultHeading);
            this.pnlResultBox.Controls.Add(this.lblResult);
            this.pnlResultBox.Controls.Add(this.lblConfidence);
            this.pnlResultBox.Location = new System.Drawing.Point(30, 164);
            this.pnlResultBox.Name = "pnlResultBox";
            this.pnlResultBox.Size = new System.Drawing.Size(420, 150);
            this.pnlResultBox.TabIndex = 4;
            // 
            // lblResultHeading
            // 
            this.lblResultHeading.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblResultHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(155)))));
            this.lblResultHeading.Location = new System.Drawing.Point(16, 14);
            this.lblResultHeading.Name = "lblResultHeading";
            this.lblResultHeading.Size = new System.Drawing.Size(380, 20);
            this.lblResultHeading.TabIndex = 0;
            this.lblResultHeading.Text = "Prediction Output";
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.lblResult.Location = new System.Drawing.Point(16, 42);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(390, 46);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Enter marks above and click Predict.";
            // 
            // lblConfidence
            // 
            this.lblConfidence.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblConfidence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(135)))));
            this.lblConfidence.Location = new System.Drawing.Point(16, 96);
            this.lblConfidence.Name = "lblConfidence";
            this.lblConfidence.Size = new System.Drawing.Size(390, 24);
            this.lblConfidence.TabIndex = 2;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(476, 396);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 460);
            this.MinimumSize = new System.Drawing.Size(500, 460);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Result Prediction System";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlResultBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
