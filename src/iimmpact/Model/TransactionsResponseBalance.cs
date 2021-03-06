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
    /// TransactionsResponseBalance
    /// </summary>
    [DataContract]
    public partial class TransactionsResponseBalance :  IEquatable<TransactionsResponseBalance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsResponseBalance" /> class.
        /// </summary>
        /// <param name="prev">prev.</param>
        /// <param name="_new">_new.</param>
        public TransactionsResponseBalance(decimal? prev = default(decimal?), decimal? _new = default(decimal?))
        {
            this.Prev = prev;
            this.New = _new;
        }
        
        /// <summary>
        /// Gets or Sets Prev
        /// </summary>
        [DataMember(Name="prev", EmitDefaultValue=false)]
        public decimal? Prev { get; set; }

        /// <summary>
        /// Gets or Sets New
        /// </summary>
        [DataMember(Name="new", EmitDefaultValue=false)]
        public decimal? New { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionsResponseBalance {\n");
            sb.Append("  Prev: ").Append(Prev).Append("\n");
            sb.Append("  New: ").Append(New).Append("\n");
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
            return this.Equals(input as TransactionsResponseBalance);
        }

        /// <summary>
        /// Returns true if TransactionsResponseBalance instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionsResponseBalance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionsResponseBalance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Prev == input.Prev ||
                    (this.Prev != null &&
                    this.Prev.Equals(input.Prev))
                ) && 
                (
                    this.New == input.New ||
                    (this.New != null &&
                    this.New.Equals(input.New))
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
                if (this.Prev != null)
                    hashCode = hashCode * 59 + this.Prev.GetHashCode();
                if (this.New != null)
                    hashCode = hashCode * 59 + this.New.GetHashCode();
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
