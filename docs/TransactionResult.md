# CityPay.Pos.Model.TransactionResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | A description of the status of a transaction | [optional] 
**Identifier** | **string** | The indentifier uniquely identifying the transaction | [optional] 
**IsComplete** | **bool?** | A boolean value stating whether the transaction has completed. The value will be false if the transaction is in progress. Should the value be true, a property containing the transaction details is made available. | [optional] 
**Data** | [**TransactionData**](TransactionData.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

