using Amazon.CDK;

namespace CdkWorkshop
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
new CdkWorkshopStack(app, "CdkWorkshopStack-us-east-1", new StackProps()
        {
                Env  = new Amazon.CDK.Environment
                {
                    Account = "374801192098",
                    Region = "us-east-1" 
        }
            });

new CdkWorkshopStack(app, "CdkWorkshopStack-us-east-2", new StackProps()
        {
                Env  = new Amazon.CDK.Environment
                {
                    Account = "374801192098",
                    Region = "us-east-2" 
        }
            });

new CdkWorkshopStack(app, "CdkWorkshopStack-us-west-1", new StackProps()
        {
                Env  = new Amazon.CDK.Environment
                {
                    Account = "374801192098",
                    Region = "us-west-1" 
        }
            });

new CdkWorkshopStack(app, "CdkWorkshopStack-us-west-2", new StackProps()
        {
                Env  = new Amazon.CDK.Environment
                {
                    Account = "374801192098",
                    Region = "us-west-2" 
        }
            });

new CdkWorkshopStack(app, "CdkWorkshopStack-ap-east-1", new StackProps()
        {
                Env  = new Amazon.CDK.Environment
                {
                    Account = "374801192098",
                    Region = "ap-east-1" 
        }
            });

new CdkWorkshopStack(app, "CdkWorkshopStack-ap-south-1", new StackProps()
        {
                Env  = new Amazon.CDK.Environment
                {
                    Account = "374801192098",
                    Region = "ap-south-1" 
        }
            });

new CdkWorkshopStack(app, "CdkWorkshopStack-ap-northeast-3", new StackProps()
        {
                Env  = new Amazon.CDK.Environment
                {
                    Account = "374801192098",
                    Region = "ap-northeast-3" 
        }
            });

new CdkWorkshopStack(app, "CdkWorkshopStack-ap-northeast-2", new StackProps()
        {
                Env  = new Amazon.CDK.Environment
                {
                    Account = "374801192098",
                    Region = "ap-northeast-2" 
        }
            });

new CdkWorkshopStack(app, "CdkWorkshopStack-ap-northeast-1", new StackProps()
        {
                Env  = new Amazon.CDK.Environment
                {
                    Account = "374801192098",
                    Region = "ap-northeast-1" 
        }
            });

new CdkWorkshopStack(app, "CdkWorkshopStack-ap-southeast-1", new StackProps()
        {
                Env  = new Amazon.CDK.Environment
                {
                    Account = "374801192098",
                    Region = "ap-southeast-1" 
        }
            });

new CdkWorkshopStack(app, "CdkWorkshopStack-ap-southeast-2", new StackProps()
        {
                Env  = new Amazon.CDK.Environment
                {
                    Account = "374801192098",
                    Region = "ap-southeast-2" 
        }
            });

new CdkWorkshopStack(app, "CdkWorkshopStack-ca-central-1", new StackProps()
        {
                Env  = new Amazon.CDK.Environment
                {
                    Account = "374801192098",
                    Region = "ca-central-1" 
        }
            });

new CdkWorkshopStack(app, "CdkWorkshopStack-eu-central-1", new StackProps()
        {
                Env  = new Amazon.CDK.Environment
                {
                    Account = "374801192098",
                    Region = "eu-central-1" 
        }
            });

new CdkWorkshopStack(app, "CdkWorkshopStack-eu-west-1", new StackProps()
        {
                Env  = new Amazon.CDK.Environment
                {
                    Account = "374801192098",
                    Region = "eu-west-1" 
        }
            });

new CdkWorkshopStack(app, "CdkWorkshopStack-eu-west-2", new StackProps()
        {
                Env  = new Amazon.CDK.Environment
                {
                    Account = "374801192098",
                    Region = "eu-west-2" 
        }
            });

new CdkWorkshopStack(app, "CdkWorkshopStack-eu-west-3", new StackProps()
        {
                Env  = new Amazon.CDK.Environment
                {
                    Account = "374801192098",
                    Region = "eu-west-3" 
        }
            });

new CdkWorkshopStack(app, "CdkWorkshopStack-eu-north-1", new StackProps()
        {
                Env  = new Amazon.CDK.Environment
                {
                    Account = "374801192098",
                    Region = "eu-north-1" 
        }
            });

new CdkWorkshopStack(app, "CdkWorkshopStack-me-south-1", new StackProps()
        {
                Env  = new Amazon.CDK.Environment
                {
                    Account = "374801192098",
                    Region = "me-south-1" 
        }
            });

new CdkWorkshopStack(app, "CdkWorkshopStack-sa-east-1", new StackProps()
        {
                Env  = new Amazon.CDK.Environment
                {
                    Account = "374801192098",
                    Region = "sa-east-1" 
        }
            });
            app.Synth();
        }
    }
}
