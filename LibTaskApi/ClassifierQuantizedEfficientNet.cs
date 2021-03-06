using Android.App;

namespace ImageClassification
{
    // This TensorFlowLite classifier works with the quantized EfficientNet model.
    public class ClassifierQuantizedEfficientNet : Classifier
    {
        //
        // Initializes a {@code ClassifierQuantizedEfficentNet}.
        //
        // @param activity
        // @param device a {@link Device} object to configure the hardware accelerator
        // @param numThreads the number of threads during the inference
        // @throws IOException if the model is not loaded correctly
        //
        public ClassifierQuantizedEfficientNet(Activity activity, Device device, int numThreads) :
            base(activity, device, numThreads)
        {
        }

        protected override string ModelPath { get; } = "efficientnet-lite0-int8.tflite";
    }
}
