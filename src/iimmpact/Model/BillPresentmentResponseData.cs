/* 
 * IIMMPACT API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2020-09-14T13:01:14Z
 * 
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
using SwaggerDateConverter = iimmpact.Client.SwaggerDateConverter;

namespace iimmpact.Model
{
    /// <summary>
    /// BillPresentmentResponseData
    /// </summary>
    [DataContract]
    public partial class BillPresentmentResponseData :  IEquatable<BillPresentmentResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillPresentmentResponseData" /> class.
        /// </summary>
        /// <param name="message">message.</param>
        /// <param name="customField">customField.</param>
        /// <param name="customerName">customerName.</param>
        /// <param name="outstanding">outstanding.</param>
        /// <param name="balance">balance.</param>
        /// <param name="data">data.</param>
        /// <param name="address">address.</param>
        /// <param name="eBill">eBill.</param>
        public BillPresentmentResponseData(string message = default(string), string customField = default(string), string customerName = default(string), decimal? outstanding = default(decimal?), string balance = default(string), string data = default(string), string address = default(string), string eBill = default(string))
        {
            this.Message = message;
            this.CustomField = customField;
            this.CustomerName = customerName;
            this.Outstanding = outstanding;
            this.Balance = balance;
            this.Data = data;
            this.Address = address;
            this.EBill = eBill;
        }
        
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets CustomField
        /// </summary>
        [DataMember(Name="CustomField", EmitDefaultValue=false)]
        public string CustomField { get; set; }

        /// <summary>
        /// Gets or Sets CustomerName
        /// </summary>
        [DataMember(Name="CustomerName", EmitDefaultValue=false)]
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or Sets Outstanding
        /// </summary>
        [DataMember(Name="Outstanding", EmitDefaultValue=false)]
        public decimal? Outstanding { get; set; }

        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [DataMember(Name="Balance", EmitDefaultValue=false)]
        public string Balance { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="Data", EmitDefaultValue=false)]
        public string Data { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="Address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets EBill
        /// </summary>
        [DataMember(Name="E-Bill", EmitDefaultValue=false)]
        public string EBill { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillPresentmentResponseData {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  CustomField: ").Append(CustomField).Append("\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
            sb.Append("  Outstanding: ").Append(Outstanding).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  EBill: ").Append(EBill).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as BillPresentmentResponseData);
        }

        /// <summary>
        /// Returns true if BillPresentmentResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of BillPresentmentResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillPresentmentResponseData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.CustomField == input.CustomField ||
                    (this.CustomField != null &&
                    this.CustomField.Equals(input.CustomField))
                ) && 
                (
                    this.CustomerName == input.CustomerName ||
                    (this.CustomerName != null &&
                    this.CustomerName.Equals(input.CustomerName))
                ) && 
                (
                    this.Outstanding == input.Outstanding ||
                    (this.Outstanding != null &&
                    this.Outstanding.Equals(input.Outstanding))
                ) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.EBill == input.EBill ||
                    (this.EBill != null &&
                    this.EBill.Equals(input.EBill))
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
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.CustomField != null)
                    hashCode = hashCode * 59 + this.CustomField.GetHashCode();
                if (this.CustomerName != null)
                    hashCode = hashCode * 59 + this.CustomerName.GetHashCode();
                if (this.Outstanding != null)
                    hashCode = hashCode * 59 + this.Outstanding.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.EBill != null)
                    hashCode = hashCode * 59 + this.EBill.GetHashCode();
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
