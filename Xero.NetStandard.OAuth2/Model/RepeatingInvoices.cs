/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0.1
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model
{
    /// <summary>
    /// RepeatingInvoices
    /// </summary>
    [DataContract]
    public partial class RepeatingInvoices :  IEquatable<RepeatingInvoices>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets _RepeatingInvoices
        /// </summary>
        [DataMember(Name="RepeatingInvoices", EmitDefaultValue=false)]
        public List<RepeatingInvoice> _RepeatingInvoices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepeatingInvoices {\n");
            sb.Append("  _RepeatingInvoices: ").Append(_RepeatingInvoices).Append("\n");
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
            return this.Equals(input as RepeatingInvoices);
        }

        /// <summary>
        /// Returns true if RepeatingInvoices instances are equal
        /// </summary>
        /// <param name="input">Instance of RepeatingInvoices to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepeatingInvoices input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._RepeatingInvoices == input._RepeatingInvoices ||
                    this._RepeatingInvoices != null &&
                    input._RepeatingInvoices != null &&
                    this._RepeatingInvoices.SequenceEqual(input._RepeatingInvoices)
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
                if (this._RepeatingInvoices != null)
                    hashCode = hashCode * 59 + this._RepeatingInvoices.GetHashCode();
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
