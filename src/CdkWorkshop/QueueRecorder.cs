using Amazon.CDK;
using Amazon.CDK.AWS.SQS;
using Amazon.CDK.AWS.Lambda;
using Amazon.CDK.AWS.Lambda.EventSources;

namespace CdkWorkshop
{

    internal sealed class QueueRecorderProp: IStackProps 
    {
        internal Queue inputQueue;
    }

    internal class QueueRecorder : Construct
    {
        internal QueueRecorder(Construct scope, string id, QueueRecorderProp props = null) : base(scope, id)
        {

            // Defines a new lambda resource
            var hello = new Function(this, "HelloHandler", new FunctionProps
            {
                Runtime = Runtime.NODEJS_10_X, // execution environment
                Code = Code.FromAsset("lambda"), // Code loaded from the "lambda" directory
                Handler = "hello.handler" // file is "hello", function is "handler"
            });

            hello.AddEventSource(new SqsEventSource(props.inputQueue));

        }
    }
}
