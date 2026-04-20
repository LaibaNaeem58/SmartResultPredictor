# Smart Result Prediction System

ML.NET + Windows Forms + Docker

## Project Structure

| File | Purpose |
|------|---------|
| `StudentData.cs` | ML input/output data model class |
| `MLModel.cs` | ML.NET FastTree binary classifier (Pass/Fail) |
| `Form1.cs` | Windows Forms UI logic |
| `Form1.Designer.cs` | Designer code (controls, layout, styles) |
| `Program.cs` | Application entry point |
| `Dockerfile` | Multi-stage Docker build |

## How to Run (Visual Studio)

1. Open `SmartResultPredictor.csproj` in Visual Studio 2022
2. Press **F5** to build and run
3. Enter student marks (0–100) and click **Predict**

## Docker Deployment

```bash
# Build the image
docker build -t smart-result-predictor .

# Run the container
docker run --rm smart-result-predictor

# Verify execution
docker ps
```

> Note: Windows Forms requires Windows containers.
> Use `--platform windows` on Docker Desktop if needed.
