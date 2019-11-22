using ML_Dot_Net_Core_ResearchML.Model;
using System;

namespace ML_Dot_Net_Core_Research
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var input = new ModelInput();
            input.SentimentText = "That is rude.";

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            Console.WriteLine($"Text: {input.SentimentText}\nIs Toxic: {result.Prediction}\n\n");


            input.SentimentText = "Why hello there.";

            // Load model and predict output of sample data
            result = ConsumeModel.Predict(input);
            Console.WriteLine($"Text: {input.SentimentText}\nIs Toxic: {result.Prediction}\n\n");


            input.SentimentText = "Screw you!!!";

            // Load model and predict output of sample data
            result = ConsumeModel.Predict(input);
            Console.WriteLine($"Text: {input.SentimentText}\nIs Toxic: {result.Prediction}\n\n");
        }
    }
}
