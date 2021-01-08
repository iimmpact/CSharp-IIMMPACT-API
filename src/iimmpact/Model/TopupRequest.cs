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
    /// TopupRequest
    /// </summary>
    [DataContract]
    public partial class TopupRequest :  IEquatable<TopupRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TopupRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TopupRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TopupRequest" /> class.
        /// </summary>
        /// <param name="refid">refid (required).</param>
        /// <param name="product">product (required).</param>
        /// <param name="remarks">remarks.</param>
        /// <param name="account">account (required).</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="sync">sync.</param>
        public TopupRequest(string refid = default(string), string product = default(string), string remarks = default(string), string account = default(string), int? amount = default(int?), bool? sync = default(bool?))
        {
            // to ensure "refid" is required (not null)
            if (refid == null)
            {
                throw new InvalidDataException("refid is a required property for TopupRequest and cannot be null");
            }
            else
            {
                this.Refid = refid;
            }
            // to ensure "product" is required (not null)
            if (product == null)
            {
                throw new InvalidDataException("product is a required property for TopupRequest and cannot be null");
            }
            else
            {
                this.Product = product;
            }
            // to ensure "account" is required (not null)
            if (account == null)
            {
                throw new InvalidDataException("account is a required property for TopupRequest and cannot be null");
            }
            else
            {
                this.Account = account;
            }
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for TopupRequest and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            this.Remarks = remarks;
            this.Sync = sync;
        }
        
        /// <summary>
        /// Gets or Sets Refid
        /// </summary>
        [DataMember(Name="refid", EmitDefaultValue=false)]
        public string Refid { get; set; }

        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public string Product { get; set; }

        /// <summary>
        /// Gets or Sets Remarks
        /// </summary>
        [DataMember(Name="remarks", EmitDefaultValue=false)]
        public string Remarks { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public string Account { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// Gets or Sets Sync
        /// </summary>
        [DataMember(Name="sync", EmitDefaultValue=false)]
        public bool? Sync { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopupRequest {\n");
            sb.Append("  Refid: ").Append(Refid).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  Remarks: ").Append(Remarks).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Sync: ").Append(Sync).Append("\n");
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
            return this.Equals(input as TopupRequest);
        }

        /// <summary>
        /// Returns true if TopupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TopupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TopupRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Refid == input.Refid ||
                    (this.Refid != null &&
                    this.Refid.Equals(input.Refid))
                ) && 
                (
                    this.Product == input.Product ||
                    (this.Product != null &&
                    this.Product.Equals(input.Product))
                ) && 
                (
                    this.Remarks == input.Remarks ||
                    (this.Remarks != null &&
                    this.Remarks.Equals(input.Remarks))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Sync == input.Sync ||
                    (this.Sync != null &&
                    this.Sync.Equals(input.Sync))
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
                if (this.Refid != null)
                    hashCode = hashCode * 59 + this.Refid.GetHashCode();
                if (this.Product != null)
                    hashCode = hashCode * 59 + this.Product.GetHashCode();
                if (this.Remarks != null)
                    hashCode = hashCode * 59 + this.Remarks.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Sync != null)
                    hashCode = hashCode * 59 + this.Sync.GetHashCode();
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
            // Amount (int?) minimum
            if(this.Amount < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, must be a value greater than or equal to 1.", new [] { "Amount" });
            }

            yield break;
        }
    }

}
