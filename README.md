This is an **unofficial** .NET wrapper of the [Payhawk](https://developers.payhawk.com) Public API.

This API client is generated with [Microsoft Kiota](https://learn.microsoft.com/en-us/openapi/kiota/) using a 
slightly modified version of the official [Payhawk OpenAPI specification](https://api.payhawk.com/api/v3/docs.json) file.

## How to use

Create a PayhawkClient instance

```csharp
// Payhawk requires your API Key as header parameter X-Payhawk-ApiKey
ApiKeyAuthenticationProvider authenticationProvider = 
    new ApiKeyAuthenticationProvider("<your API Key>, "X-Payhawk-ApiKey", ApiKeyAuthenticationProvider.KeyLocation.Header);

HttpClientRequestAdapter requestAdapter = new HttpClientRequestAdapter(authenticationProvider);

PayhawkClient client = new PayhawkClient(requestAdapter);
```

Query your accounts

To get all your Payhawk accounts you can execute

```csharp
var results = await client.Api.V3.Accounts.GetAsync();
```

...