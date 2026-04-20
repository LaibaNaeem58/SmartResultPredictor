using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace SmartResultPredictor
{
    public class MLModel
    {
        private readonly MLContext _mlContext;

        // C# 7.3 ke liye '?' symbols ko hata diya gaya hai
        private ITransformer _trainedModel;
        private PredictionEngine<StudentData, StudentPrediction> _predictionEngine;

        public MLModel()
        {
            _mlContext = new MLContext(seed: 0);
            TrainModel();
        }

        private void TrainModel()
        {
            // ── Training Data: marks → Pass/Fail (threshold ~50) ─
            var trainingData = new List<StudentData>
            {
                new StudentData { Marks = 85, PassFail = true  },
                new StudentData { Marks = 72, PassFail = true  },
                new StudentData { Marks = 91, PassFail = true  },
                new StudentData { Marks = 65, PassFail = true  },
                new StudentData { Marks = 55, PassFail = true  },
                new StudentData { Marks = 52, PassFail = true  },
                new StudentData { Marks = 78, PassFail = true  },
                new StudentData { Marks = 60, PassFail = true  },
                new StudentData { Marks = 95, PassFail = true  },
                new StudentData { Marks = 50, PassFail = true  },
                new StudentData { Marks = 48, PassFail = false },
                new StudentData { Marks = 30, PassFail = false },
                new StudentData { Marks = 15, PassFail = false },
                new StudentData { Marks = 42, PassFail = false },
                new StudentData { Marks = 38, PassFail = false },
                new StudentData { Marks = 22, PassFail = false },
                new StudentData { Marks = 10, PassFail = false },
                new StudentData { Marks = 45, PassFail = false },
                new StudentData { Marks = 5,  PassFail = false },
                new StudentData { Marks = 35, PassFail = false },
            };

            // ── Load data into IDataView ──────────────────────────
            var dataView = _mlContext.Data.LoadFromEnumerable(trainingData);

            // ── Build ML pipeline ─────────────────────────────────
            var pipeline = _mlContext.Transforms
                .Concatenate("Features", nameof(StudentData.Marks))
                .Append(_mlContext.BinaryClassification.Trainers
                    .FastTree(
                        labelColumnName: "Label",
                        featureColumnName: "Features",
                        numberOfLeaves: 4,
                        numberOfTrees: 100,
                        minimumExampleCountPerLeaf: 2,
                        learningRate: 0.1));

            // ── Train the model ───────────────────────────────────
            _trainedModel = pipeline.Fit(dataView);

            // ── Create prediction engine ──────────────────────────
            _predictionEngine = _mlContext.Model
                .CreatePredictionEngine<StudentData, StudentPrediction>(_trainedModel);
        }

        // ── Public method: predict result for given marks ─────────
        public StudentPrediction Predict(float marks)
        {
            if (_predictionEngine == null)
                throw new InvalidOperationException("Model is not trained.");

            var input = new StudentData { Marks = marks };
            return _predictionEngine.Predict(input);
        }
    }
}