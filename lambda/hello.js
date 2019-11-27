const { DynamoDB } = require('aws-sdk');


exports.handler = async function(event) {
    console.log("request:", JSON.stringify(event, undefined, 2));
    console.log("Fine, thanks!");

    const client = new DynamoDB.DocumentClient();

    for (const record of event.Records) {
        const body = record.body ? JSON.parse(record.body) : { };
        await client.put({
            TableName: process.env.TABLE_NAME,
            Item: {
                id: record.messageId,
                text: body.text,
                body
            }
        }).promise();
    } 

    return {
      statusCode: 200,
      headers: { "Content-Type": "text/plain" },
      body: `Hello, CDK! You've hit ${event.path}\n`
    };
  };
  