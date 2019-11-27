using System.Collections.Generic;
using Amazon.CDK;
using Amazon.CDK.AWS.SQS;
using Amazon.CDK.AWS.Lambda;
using Amazon.CDK.AWS.Lambda.EventSources;
using Amazon.CDK.AWS.DynamoDB;

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
            var table = new Table(this, "QueueRecorderTable", new TableProps
            {
                PartitionKey = new Attribute
                {
                    Name = "id",
                    Type = AttributeType.STRING
                }
            });

            // Defines a new lambda resource
            var hello = new Function(this, "HelloHandler", new FunctionProps
            {
                Runtime = Runtime.NODEJS_10_X, // execution environment
                Code = Code.FromAsset("lambda"), // Code loaded from the "lambda" directory
                Handler = "hello.handler", // file is "hello", function is "handler"
                Environment = new Dictionary<string, string>
                {
                    { "TABLE_NAME", table.TableName }
                }
            });
            table.GrantReadWriteData(hello);

            hello.AddEventSource(new SqsEventSource(props.inputQueue));

        }
    }
}
