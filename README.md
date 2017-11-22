# CityPay.Pos - the C# library for the CityPay POS API

CityPay Point of Sale API for payment with card present devices including EMV readers and contactless POS readers.  The API makes it simple to add EMV and contactless card acceptance to iOS, Android, Tablet and desktop applicaitons using a HTTPS protocol. It segregates the complexity of payment processing from the sales environment and eliminates any necessity for the target system to handle card data. 

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0.0
- SDK version: ${VERSION}
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using CityPay.Pos.Api;
using CityPay.Pos.Client;
using CityPay.Pos.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out CityPay.Pos.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using CityPay.Pos.Api;
using CityPay.Pos.Client;
using CityPay.Pos.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            var apiInstance = new DeviceModuleApi();
            var deviceId = deviceId_example;  // string | The name of the target device used by the API.

            try
            {
                // Device Information
                DeviceInfo result = apiInstance.DeviceInfo(deviceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceModuleApi.DeviceInfo: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://pos.citypay.com/citypay-pos-api/1.0.0*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DeviceModuleApi* | [**DeviceInfo**](docs/DeviceModuleApi.md#deviceinfo) | **GET** /device/{deviceId}/info | Device Information
*DeviceModuleApi* | [**Ping**](docs/DeviceModuleApi.md#ping) | **GET** /device/{deviceId}/ping | Device Ping
*PaymentModuleApi* | [**Receipt**](docs/PaymentModuleApi.md#receipt) | **POST** /receipt | Receipt Print
*PaymentModuleApi* | [**Refund**](docs/PaymentModuleApi.md#refund) | **POST** /refund | Refund Transaction
*PaymentModuleApi* | [**Reversal**](docs/PaymentModuleApi.md#reversal) | **POST** /reversal | Reversal Tranasction
*PaymentModuleApi* | [**Sale**](docs/PaymentModuleApi.md#sale) | **POST** /sale | Sale Transaction
*PaymentModuleApi* | [**Transaction**](docs/PaymentModuleApi.md#transaction) | **POST** /transaction | Transaction Status


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.DeviceInfo](docs/DeviceInfo.md)
 - [Model.PrintRequest](docs/PrintRequest.md)
 - [Model.Receipt](docs/Receipt.md)
 - [Model.Result](docs/Result.md)
 - [Model.ReversalRequest](docs/ReversalRequest.md)
 - [Model.SaleRequest](docs/SaleRequest.md)
 - [Model.SaleResponse](docs/SaleResponse.md)
 - [Model.SuccessResponse](docs/SuccessResponse.md)
 - [Model.TransactionData](docs/TransactionData.md)
 - [Model.TransactionProgress](docs/TransactionProgress.md)
 - [Model.TransactionResult](docs/TransactionResult.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.
