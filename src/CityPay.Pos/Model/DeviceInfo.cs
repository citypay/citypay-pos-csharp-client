/* 
 * CityPay POS API
 *
 * CityPay Point of Sale API for payment with card present devices including EMV readers and contactless POS readers.  The API makes it simple to add EMV and contactless card acceptance to iOS, Android, Tablet and desktop applicaitons using a HTTPS protocol. It segregates the complexity of payment processing from the sales environment and eliminates any necessity for the target system to handle card data. 
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
    /// DeviceInfo
    /// </summary>
    [DataContract]
    public partial class DeviceInfo :  IEquatable<DeviceInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceInfo" /> class.
        /// </summary>
        /// <param name="Name">The name of the device.</param>
        /// <param name="Serialno">The serial number of the device.</param>
        /// <param name="Portable">Whether the device is portable.</param>
        /// <param name="Busy">Whether the device is busy or available for a transaction.</param>
        /// <param name="BatteryCharging">Whether the device is currently charging.</param>
        /// <param name="BatteryPercentage">A percentage value of the battery.</param>
        /// <param name="Printer">Whether the device has a printer.</param>
        public DeviceInfo(string Name = default(string), string Serialno = default(string), bool? Portable = default(bool?), bool? Busy = default(bool?), bool? BatteryCharging = default(bool?), int? BatteryPercentage = default(int?), bool? Printer = default(bool?))
        {
            this.Name = Name;
            this.Serialno = Serialno;
            this.Portable = Portable;
            this.Busy = Busy;
            this.BatteryCharging = BatteryCharging;
            this.BatteryPercentage = BatteryPercentage;
            this.Printer = Printer;
        }
        
        /// <summary>
        /// The name of the device
        /// </summary>
        /// <value>The name of the device</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The serial number of the device
        /// </summary>
        /// <value>The serial number of the device</value>
        [DataMember(Name="serialno", EmitDefaultValue=false)]
        public string Serialno { get; set; }

        /// <summary>
        /// Whether the device is portable
        /// </summary>
        /// <value>Whether the device is portable</value>
        [DataMember(Name="portable", EmitDefaultValue=false)]
        public bool? Portable { get; set; }

        /// <summary>
        /// Whether the device is busy or available for a transaction
        /// </summary>
        /// <value>Whether the device is busy or available for a transaction</value>
        [DataMember(Name="busy", EmitDefaultValue=false)]
        public bool? Busy { get; set; }

        /// <summary>
        /// Whether the device is currently charging
        /// </summary>
        /// <value>Whether the device is currently charging</value>
        [DataMember(Name="battery_charging", EmitDefaultValue=false)]
        public bool? BatteryCharging { get; set; }

        /// <summary>
        /// A percentage value of the battery
        /// </summary>
        /// <value>A percentage value of the battery</value>
        [DataMember(Name="battery_percentage", EmitDefaultValue=false)]
        public int? BatteryPercentage { get; set; }

        /// <summary>
        /// Whether the device has a printer
        /// </summary>
        /// <value>Whether the device has a printer</value>
        [DataMember(Name="printer", EmitDefaultValue=false)]
        public bool? Printer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceInfo {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Serialno: ").Append(Serialno).Append("\n");
            sb.Append("  Portable: ").Append(Portable).Append("\n");
            sb.Append("  Busy: ").Append(Busy).Append("\n");
            sb.Append("  BatteryCharging: ").Append(BatteryCharging).Append("\n");
            sb.Append("  BatteryPercentage: ").Append(BatteryPercentage).Append("\n");
            sb.Append("  Printer: ").Append(Printer).Append("\n");
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
            return this.Equals(input as DeviceInfo);
        }

        /// <summary>
        /// Returns true if DeviceInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Serialno == input.Serialno ||
                    (this.Serialno != null &&
                    this.Serialno.Equals(input.Serialno))
                ) && 
                (
                    this.Portable == input.Portable ||
                    (this.Portable != null &&
                    this.Portable.Equals(input.Portable))
                ) && 
                (
                    this.Busy == input.Busy ||
                    (this.Busy != null &&
                    this.Busy.Equals(input.Busy))
                ) && 
                (
                    this.BatteryCharging == input.BatteryCharging ||
                    (this.BatteryCharging != null &&
                    this.BatteryCharging.Equals(input.BatteryCharging))
                ) && 
                (
                    this.BatteryPercentage == input.BatteryPercentage ||
                    (this.BatteryPercentage != null &&
                    this.BatteryPercentage.Equals(input.BatteryPercentage))
                ) && 
                (
                    this.Printer == input.Printer ||
                    (this.Printer != null &&
                    this.Printer.Equals(input.Printer))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Serialno != null)
                    hashCode = hashCode * 59 + this.Serialno.GetHashCode();
                if (this.Portable != null)
                    hashCode = hashCode * 59 + this.Portable.GetHashCode();
                if (this.Busy != null)
                    hashCode = hashCode * 59 + this.Busy.GetHashCode();
                if (this.BatteryCharging != null)
                    hashCode = hashCode * 59 + this.BatteryCharging.GetHashCode();
                if (this.BatteryPercentage != null)
                    hashCode = hashCode * 59 + this.BatteryPercentage.GetHashCode();
                if (this.Printer != null)
                    hashCode = hashCode * 59 + this.Printer.GetHashCode();
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
