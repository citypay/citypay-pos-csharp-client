# CityPay.Pos.Model.SaleRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Device** | **string** | The name of the target device used by the API. The device will be setup prior to the sale but allows targeting of multiple devices. | 
**Amount** | **int?** | The amount to process in the lowest denomination and in the base currency of the device. 4798 for instance would process the transaction for £47.98 | 
**Identifier** | **string** | An identifier or reference for the sale as taken by the point of sale system. This should be used to cross reference transactions after it has processed. The value should be unique and will be used to check on the processing of the transaction. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

