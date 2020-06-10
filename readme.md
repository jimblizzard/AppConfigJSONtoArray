Demo of a simple .net core console app that reads a json string from Azure App Configuration service and parses that json into an int array. 

Used this as a starting point: https://docs.microsoft.com/en-us/azure/azure-app-configuration/quickstart-dotnet-core-app

```
rg: 'blizzappconfig2rg'
app config: 'fooconfig'
read-only access key conn string: 'xxxxxxxxxxxx'
export ConnectionString='Endpoint=xxxxxxxxxxxx'
```

Turn the json string into an array

The json string in App Configuration service looks like this: {"value" : [0,1,2,3,4]}

The output from running the program is: 

```
this is a test: {"value" : [0,1,2,3,4]}
element is: 0
element is: 1
element is: 2
element is: 3
element is: 4
```