using Android.App;

namespace ImageClassification
{
    // This TensorFlowLite classifier works with the float EfficientNet model.
    public class ClassifierFloatEfficientNet : Classifier
    {
        //
        // Initializes a {@code ClassifierFloatEfficientNet}.
        //
        // @param activity
        // @param device a {@link Device} object to configure the hardware accelerator
        // @param numThreads the number of threads during the inference
        // @throws IOException if the model is not loaded correctly
        //
        public ClassifierFloatEfficientNet(Activity activity, Device device, int numThreads) :
            base(activity, device, numThreads)
        {
        }

        protected override string ModelPath { get; } = "efficientnet-lite0-fp32.tflite";
    }
}
