# AWS HTTP API with .Net Core and Serverless

To run this first build the solution with
```
dotnet build
```

Then run the build script to aws lambda package into a zip each lambda function
```
./build.sh
```

Finally deploy this to AWS with [serverless](https://www.serverless.com/) (Make sure to install sls and have an AWS profile called 'serverless-admin')
```
sls deploy -v
```
