/* 
 * CityPay POS API
 *
 * CityPay Point of Sale API for payment with card present devices including EMV readers and contactless POS readers.  The API is available from https://github.com/citypay/citypay-pos-api  The API makes it simple to add EMV and contactless card acceptance to iOS, Android, Tablet and desktop applicaitons using a HTTPS protocol. It segregates the complexity of payment processing from the sales environment and eliminates any necessity for the target system to handle card data. 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: dev@citypay.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CityPay.Pos.Client.SwaggerDateConverter;

namespace CityPay.Pos.Model
{
    /// <summary>
    /// SaleResponse
    /// </summary>
    [DataContract]
    public partial class SaleResponse :  IEquatable<SaleResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaleResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SaleResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SaleResponse" /> class.
        /// </summary>
        /// <param name="Success">Defines whether the sale was successfully created (required).</param>
        /// <param name="Identifier">The identifier presented to the sale request (required).</param>
        /// <param name="Description">Description should the sale request not be accepted.</param>
        public SaleResponse(bool? Success = default(bool?), string Identifier = default(string), string Description = default(string))
        {
            // to ensure "Success" is required (not null)
            if (Success == null)
            {
                throw new InvalidDataException("Success is a required property for SaleResponse and cannot be null");
            }
            else
            {
                this.Success = Success;
            }
            // to ensure "Identifier" is required (not null)
            if (Identifier == null)
            {
                throw new InvalidDataException("Identifier is a required property for SaleResponse and cannot be null");
            }
            else
            {
                this.Identifier = Identifier;
            }
            this.Description = Description;
        }
        
        /// <summary>
        /// Defines whether the sale was successfully created
        /// </summary>
        /// <value>Defines whether the sale was successfully created</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The identifier presented to the sale request
        /// </summary>
        /// <value>The identifier presented to the sale request</value>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// Description should the sale request not be accepted
        /// </summary>
        /// <value>Description should the sale request not be accepted</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaleResponse {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SaleResponse);
        }

        /// <summary>
        /// Returns true if SaleResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SaleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SaleResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
