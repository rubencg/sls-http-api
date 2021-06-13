using Amazon.Lambda.Core;

[assembly:LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
namespace Todo
{
    public class GetHandler
    {
       public Response Handle()
       {
           return new Response("Go Serverless v1.0! Your function executed successfully!");
       }
    }

    public class Response
    {
      public string Message {get; set;}

      public Response(string message){
        Message = message;
      }
    }
}
