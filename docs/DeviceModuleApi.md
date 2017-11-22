# CityPay.Pos.Api.DeviceModuleApi

All URIs are relative to *https://pos.citypay.com/citypay-pos-api/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeviceInfo**](DeviceModuleApi.md#deviceinfo) | **GET** /device/{deviceId}/info | Device Information
[**Ping**](DeviceModuleApi.md#ping) | **GET** /device/{deviceId}/ping | Device Ping


<a name="deviceinfo"></a>
# **DeviceInfo**
> DeviceInfo DeviceInfo (string deviceId)

Device Information

Obtains information regarding the device and to review the current status of a device such as the battery charge, serial number and device type. 

### Example
```csharp
using System;
using System.Diagnostics;
using CityPay.Pos.Api;
using CityPay.Pos.Client;
using CityPay.Pos.Model;

namespace Example
{
    public class DeviceInfoExample
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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceId** | **string**| The name of the target device used by the API. | 

### Return type

[**DeviceInfo**](DeviceInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ping"></a>
# **Ping**
> Result Ping (string deviceId)

Device Ping

To monitor or to check whether a device is available, the host can send a simple `GET` request to the URL at `/device/{deviceId}/ping` to see if the device is responding and available. 

### Example
```csharp
using System;
using System.Diagnostics;
using CityPay.Pos.Api;
using CityPay.Pos.Client;
using CityPay.Pos.Model;

namespace Example
{
    public class PingExample
    {
        public void main()
        {
            var apiInstance = new DeviceModuleApi();
            var deviceId = deviceId_example;  // string | The name of the target device used by the API.

            try
            {
                // Device Ping
                Result result = apiInstance.Ping(deviceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceModuleApi.Ping: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceId** | **string**| The name of the target device used by the API. | 

### Return type

[**Result**](Result.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

