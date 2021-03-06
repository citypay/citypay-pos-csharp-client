/* 
 * CityPay POS API
 *
 * CityPay Point of Sale API for payment with card present devices including EMV readers and contactless POS readers.  The API makes it simple to add EMV and contactless card acceptance to iOS, Android, Tablet and desktop applicaitons using a HTTPS protocol. It segregates the complexity of payment processing from the sales environment and eliminates any necessity for the target system to handle card data. 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: dev@citypay.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using CityPay.Pos.Api;
using CityPay.Pos.Model;
using CityPay.Pos.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace CityPay.Pos.Test
{
    /// <summary>
    ///  Class for testing TransactionData
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class TransactionDataTests
    {
        // TODO uncomment below to declare an instance variable for TransactionData
        //private TransactionData instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of TransactionData
            //instance = new TransactionData();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TransactionData
        /// </summary>
        [Test]
        public void TransactionDataInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" TransactionData
            //Assert.IsInstanceOfType<TransactionData> (instance, "variable 'instance' is a TransactionData");
        }


        /// <summary>
        /// Test the property 'AdditionalData'
        /// </summary>
        [Test]
        public void AdditionalDataTest()
        {
            // TODO unit test for the property 'AdditionalData'
        }
        /// <summary>
        /// Test the property 'AuxiliaryData'
        /// </summary>
        [Test]
        public void AuxiliaryDataTest()
        {
            // TODO unit test for the property 'AuxiliaryData'
        }
        /// <summary>
        /// Test the property 'CardType'
        /// </summary>
        [Test]
        public void CardTypeTest()
        {
            // TODO unit test for the property 'CardType'
        }
        /// <summary>
        /// Test the property 'CompletedAt'
        /// </summary>
        [Test]
        public void CompletedAtTest()
        {
            // TODO unit test for the property 'CompletedAt'
        }
        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Test]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
        }
        /// <summary>
        /// Test the property 'CurrencySymbol'
        /// </summary>
        [Test]
        public void CurrencySymbolTest()
        {
            // TODO unit test for the property 'CurrencySymbol'
        }
        /// <summary>
        /// Test the property 'DeclinedByCard'
        /// </summary>
        [Test]
        public void DeclinedByCardTest()
        {
            // TODO unit test for the property 'DeclinedByCard'
        }
        /// <summary>
        /// Test the property 'EmvAppCryptogram'
        /// </summary>
        [Test]
        public void EmvAppCryptogramTest()
        {
            // TODO unit test for the property 'EmvAppCryptogram'
        }
        /// <summary>
        /// Test the property 'EmvAppExpirationDate'
        /// </summary>
        [Test]
        public void EmvAppExpirationDateTest()
        {
            // TODO unit test for the property 'EmvAppExpirationDate'
        }
        /// <summary>
        /// Test the property 'EmvAppTxnCounter'
        /// </summary>
        [Test]
        public void EmvAppTxnCounterTest()
        {
            // TODO unit test for the property 'EmvAppTxnCounter'
        }
        /// <summary>
        /// Test the property 'EmvAuthorizedAmount'
        /// </summary>
        [Test]
        public void EmvAuthorizedAmountTest()
        {
            // TODO unit test for the property 'EmvAuthorizedAmount'
        }
        /// <summary>
        /// Test the property 'EmvCardholderVerificationResults'
        /// </summary>
        [Test]
        public void EmvCardholderVerificationResultsTest()
        {
            // TODO unit test for the property 'EmvCardholderVerificationResults'
        }
        /// <summary>
        /// Test the property 'EmvCountryCode'
        /// </summary>
        [Test]
        public void EmvCountryCodeTest()
        {
            // TODO unit test for the property 'EmvCountryCode'
        }
        /// <summary>
        /// Test the property 'EmvCryptogramInfoData'
        /// </summary>
        [Test]
        public void EmvCryptogramInfoDataTest()
        {
            // TODO unit test for the property 'EmvCryptogramInfoData'
        }
        /// <summary>
        /// Test the property 'EmvIccAppid'
        /// </summary>
        [Test]
        public void EmvIccAppidTest()
        {
            // TODO unit test for the property 'EmvIccAppid'
        }
        /// <summary>
        /// Test the property 'EmvInterchangeProfile'
        /// </summary>
        [Test]
        public void EmvInterchangeProfileTest()
        {
            // TODO unit test for the property 'EmvInterchangeProfile'
        }
        /// <summary>
        /// Test the property 'EmvIssuerAppData'
        /// </summary>
        [Test]
        public void EmvIssuerAppDataTest()
        {
            // TODO unit test for the property 'EmvIssuerAppData'
        }
        /// <summary>
        /// Test the property 'EmvPanSeqNum'
        /// </summary>
        [Test]
        public void EmvPanSeqNumTest()
        {
            // TODO unit test for the property 'EmvPanSeqNum'
        }
        /// <summary>
        /// Test the property 'EmvTerminalCapabilities'
        /// </summary>
        [Test]
        public void EmvTerminalCapabilitiesTest()
        {
            // TODO unit test for the property 'EmvTerminalCapabilities'
        }
        /// <summary>
        /// Test the property 'EmvTerminalType'
        /// </summary>
        [Test]
        public void EmvTerminalTypeTest()
        {
            // TODO unit test for the property 'EmvTerminalType'
        }
        /// <summary>
        /// Test the property 'EmvTerminalVerificationResults'
        /// </summary>
        [Test]
        public void EmvTerminalVerificationResultsTest()
        {
            // TODO unit test for the property 'EmvTerminalVerificationResults'
        }
        /// <summary>
        /// Test the property 'EmvTrack2Equivalent'
        /// </summary>
        [Test]
        public void EmvTrack2EquivalentTest()
        {
            // TODO unit test for the property 'EmvTrack2Equivalent'
        }
        /// <summary>
        /// Test the property 'EmvTxnCurrencyCode'
        /// </summary>
        [Test]
        public void EmvTxnCurrencyCodeTest()
        {
            // TODO unit test for the property 'EmvTxnCurrencyCode'
        }
        /// <summary>
        /// Test the property 'EmvTxnDate'
        /// </summary>
        [Test]
        public void EmvTxnDateTest()
        {
            // TODO unit test for the property 'EmvTxnDate'
        }
        /// <summary>
        /// Test the property 'EmvTxnStatusInfo'
        /// </summary>
        [Test]
        public void EmvTxnStatusInfoTest()
        {
            // TODO unit test for the property 'EmvTxnStatusInfo'
        }
        /// <summary>
        /// Test the property 'EmvTxnType'
        /// </summary>
        [Test]
        public void EmvTxnTypeTest()
        {
            // TODO unit test for the property 'EmvTxnType'
        }
        /// <summary>
        /// Test the property 'EmvTxnUnpredictableNumber'
        /// </summary>
        [Test]
        public void EmvTxnUnpredictableNumberTest()
        {
            // TODO unit test for the property 'EmvTxnUnpredictableNumber'
        }
        /// <summary>
        /// Test the property 'IsCommercialCard'
        /// </summary>
        [Test]
        public void IsCommercialCardTest()
        {
            // TODO unit test for the property 'IsCommercialCard'
        }
        /// <summary>
        /// Test the property 'IsContactless'
        /// </summary>
        [Test]
        public void IsContactlessTest()
        {
            // TODO unit test for the property 'IsContactless'
        }
        /// <summary>
        /// Test the property 'IsFallback'
        /// </summary>
        [Test]
        public void IsFallbackTest()
        {
            // TODO unit test for the property 'IsFallback'
        }
        /// <summary>
        /// Test the property 'IsOffline'
        /// </summary>
        [Test]
        public void IsOfflineTest()
        {
            // TODO unit test for the property 'IsOffline'
        }
        /// <summary>
        /// Test the property 'IsVoided'
        /// </summary>
        [Test]
        public void IsVoidedTest()
        {
            // TODO unit test for the property 'IsVoided'
        }
        /// <summary>
        /// Test the property 'ResponseCode'
        /// </summary>
        [Test]
        public void ResponseCodeTest()
        {
            // TODO unit test for the property 'ResponseCode'
        }
        /// <summary>
        /// Test the property 'ResponseText'
        /// </summary>
        [Test]
        public void ResponseTextTest()
        {
            // TODO unit test for the property 'ResponseText'
        }
        /// <summary>
        /// Test the property 'Result'
        /// </summary>
        [Test]
        public void ResultTest()
        {
            // TODO unit test for the property 'Result'
        }
        /// <summary>
        /// Test the property 'Scheme'
        /// </summary>
        [Test]
        public void SchemeTest()
        {
            // TODO unit test for the property 'Scheme'
        }
        /// <summary>
        /// Test the property 'SignatureRequired'
        /// </summary>
        [Test]
        public void SignatureRequiredTest()
        {
            // TODO unit test for the property 'SignatureRequired'
        }
        /// <summary>
        /// Test the property 'TerminalId'
        /// </summary>
        [Test]
        public void TerminalIdTest()
        {
            // TODO unit test for the property 'TerminalId'
        }
        /// <summary>
        /// Test the property 'TotalAmount'
        /// </summary>
        [Test]
        public void TotalAmountTest()
        {
            // TODO unit test for the property 'TotalAmount'
        }
        /// <summary>
        /// Test the property 'TransactionType'
        /// </summary>
        [Test]
        public void TransactionTypeTest()
        {
            // TODO unit test for the property 'TransactionType'
        }
        /// <summary>
        /// Test the property 'VerifiedByPin'
        /// </summary>
        [Test]
        public void VerifiedByPinTest()
        {
            // TODO unit test for the property 'VerifiedByPin'
        }

    }

}
