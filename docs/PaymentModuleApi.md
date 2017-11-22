# CityPay.Pos.Api.PaymentModuleApi

All URIs are relative to *https://pos.citypay.com/citypay-pos-api/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Receipt**](PaymentModuleApi.md#receipt) | **POST** /receipt | Receipt Print
[**Refund**](PaymentModuleApi.md#refund) | **POST** /refund | Refund Transaction
[**Reversal**](PaymentModuleApi.md#reversal) | **POST** /reversal | Reversal Tranasction
[**Sale**](PaymentModuleApi.md#sale) | **POST** /sale | Sale Transaction
[**Transaction**](PaymentModuleApi.md#transaction) | **POST** /transaction | Transaction Status


<a name="receipt"></a>
# **Receipt**
> TransactionResult Receipt (TransactionProgress body = null)

Receipt Print

Reprint a merchant or customer receipt for a transaction that exists on the device (i.e. has not been cleared by End of Day process). 

### Example
```csharp
using System;
using System.Diagnostics;
using CityPay.Pos.Api;
using CityPay.Pos.Client;
using CityPay.Pos.Model;

namespace Example
{
    public class ReceiptExample
    {
        public void main()
        {
            var apiInstance = new PaymentModuleApi();
            var body = new TransactionProgress(); // TransactionProgress |  (optional) 

            try
            {
                // Receipt Print
                TransactionResult result = apiInstance.Receipt(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentModuleApi.Receipt: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransactionProgress**](TransactionProgress.md)|  | [optional] 

### Return type

[**TransactionResult**](TransactionResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="refund"></a>
# **Refund**
> SaleResponse Refund (SaleRequest body)

Refund Transaction

Initiates a new refund to a device. The action will contact the device and request a transaction start including the amount and a unique reference to track the transaction through it's lifecycle. 

### Example
```csharp
using System;
using System.Diagnostics;
using CityPay.Pos.Api;
using CityPay.Pos.Client;
using CityPay.Pos.Model;

namespace Example
{
    public class RefundExample
    {
        public void main()
        {
            var apiInstance = new PaymentModuleApi();
            var body = new SaleRequest(); // SaleRequest | 

            try
            {
                // Refund Transaction
                SaleResponse result = apiInstance.Refund(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentModuleApi.Refund: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SaleRequest**](SaleRequest.md)|  | 

### Return type

[**SaleResponse**](SaleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reversal"></a>
# **Reversal**
> SaleResponse Reversal (ReversalRequest body)

Reversal Tranasction

Initiates a reversal to a device. No confirmation is made and the transaction reversal process is run. 

### Example
```csharp
using System;
using System.Diagnostics;
using CityPay.Pos.Api;
using CityPay.Pos.Client;
using CityPay.Pos.Model;

namespace Example
{
    public class ReversalExample
    {
        public void main()
        {
            var apiInstance = new PaymentModuleApi();
            var body = new ReversalRequest(); // ReversalRequest | 

            try
            {
                // Reversal Tranasction
                SaleResponse result = apiInstance.Reversal(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentModuleApi.Reversal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReversalRequest**](ReversalRequest.md)|  | 

### Return type

[**SaleResponse**](SaleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sale"></a>
# **Sale**
> SaleResponse Sale (SaleRequest body)

Sale Transaction

Initiates a new sale to a device. The action will contact the device and request a transaction start including the amount and a unique reference to track the transaction through it's lifecycle. 

### Example
```csharp
using System;
using System.Diagnostics;
using CityPay.Pos.Api;
using CityPay.Pos.Client;
using CityPay.Pos.Model;

namespace Example
{
    public class SaleExample
    {
        public void main()
        {
            var apiInstance = new PaymentModuleApi();
            var body = new SaleRequest(); // SaleRequest | 

            try
            {
                // Sale Transaction
                SaleResponse result = apiInstance.Sale(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentModuleApi.Sale: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SaleRequest**](SaleRequest.md)|  | 

### Return type

[**SaleResponse**](SaleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transaction"></a>
# **Transaction**
> TransactionResult Transaction (TransactionProgress body = null)

Transaction Status

Request the status of a transaction in progress or a complete transaction using the identifier as the reference. Depending on the state of the transaction, the response will indicate if it is not found, in progress (and the current stage in the transaction workflow) or complete (with all transaction data). 

### Example
```csharp
using System;
using System.Diagnostics;
using CityPay.Pos.Api;
using CityPay.Pos.Client;
using CityPay.Pos.Model;

namespace Example
{
    public class TransactionExample
    {
        public void main()
        {
            var apiInstance = new PaymentModuleApi();
            var body = new TransactionProgress(); // TransactionProgress |  (optional) 

            try
            {
                // Transaction Status
                TransactionResult result = apiInstance.Transaction(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentModuleApi.Transaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransactionProgress**](TransactionProgress.md)|  | [optional] 

### Return type

[**TransactionResult**](TransactionResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

