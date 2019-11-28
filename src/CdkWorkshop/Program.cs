using Amazon.CDK;

namespace CdkWorkshop
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new CdkWorkshopStack(app, "CdkWorkshopStack", new StackProps()
	    {
		Env = new Amazon.CDK.Environment
    		{
             	    Account = "374801192098",
	            Region = "us-west-1"
		}
	    });

            app.Synth();
        }
    }
}
