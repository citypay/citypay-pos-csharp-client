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
    /// SuccessResponse
    /// </summary>
    [DataContract]
    public partial class SuccessResponse :  IEquatable<SuccessResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SuccessResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SuccessResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SuccessResponse" /> class.
        /// </summary>
        /// <param name="Success">Success (required).</param>
        /// <param name="Description">Message describing any error.</param>
        /// <param name="Status">status of the device.</param>
        public SuccessResponse(bool? Success = default(bool?), string Description = default(string), string Status = default(string))
        {
            // to ensure "Success" is required (not null)
            if (Success == null)
            {
                throw new InvalidDataException("Success is a required property for SuccessResponse and cannot be null");
            }
            else
            {
                this.Success = Success;
            }
            this.Description = Description;
            this.Status = Status;
        }
        
        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Message describing any error
        /// </summary>
        /// <value>Message describing any error</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// status of the device
        /// </summary>
        /// <value>status of the device</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SuccessResponse {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as SuccessResponse);
        }

        /// <summary>
        /// Returns true if SuccessResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SuccessResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SuccessResponse input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
