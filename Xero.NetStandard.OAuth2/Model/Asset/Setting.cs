/* 
 * Xero Assets API
 *
 * The Assets API exposes fixed asset related functions of the Xero Accounting application and can be used for a variety of purposes such as creating assets, retrieving asset valuations etc.
 *
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

namespace Xero.NetStandard.OAuth2.Model.Asset
{
    /// <summary>
    /// Setting
    /// </summary>
    [DataContract]
    public partial class Setting :  IEquatable<Setting>, IValidatableObject
    {
        
        /// <summary>
        /// The prefix used for fixed asset numbers (“FA-” by default)
        /// </summary>
        /// <value>The prefix used for fixed asset numbers (“FA-” by default)</value>
        [DataMember(Name="assetNumberPrefix", EmitDefaultValue=false)]
        public string AssetNumberPrefix { get; set; }

        /// <summary>
        /// The next available sequence number
        /// </summary>
        /// <value>The next available sequence number</value>
        [DataMember(Name="assetNumberSequence", EmitDefaultValue=false)]
        public string AssetNumberSequence { get; set; }

        /// <summary>
        /// The date depreciation calculations started on registered fixed assets in Xero
        /// </summary>
        /// <value>The date depreciation calculations started on registered fixed assets in Xero</value>
        [DataMember(Name="assetStartDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? AssetStartDate { get; set; }

        /// <summary>
        /// The last depreciation date
        /// </summary>
        /// <value>The last depreciation date</value>
        [DataMember(Name="lastDepreciationDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? LastDepreciationDate { get; set; }

        /// <summary>
        /// Default account that gains are posted to
        /// </summary>
        /// <value>Default account that gains are posted to</value>
        [DataMember(Name="defaultGainOnDisposalAccountId", EmitDefaultValue=false)]
        public Guid? DefaultGainOnDisposalAccountId { get; set; }

        /// <summary>
        /// Default account that losses are posted to
        /// </summary>
        /// <value>Default account that losses are posted to</value>
        [DataMember(Name="defaultLossOnDisposalAccountId", EmitDefaultValue=false)]
        public Guid? DefaultLossOnDisposalAccountId { get; set; }

        /// <summary>
        /// Default account that capital gains are posted to
        /// </summary>
        /// <value>Default account that capital gains are posted to</value>
        [DataMember(Name="defaultCapitalGainOnDisposalAccountId", EmitDefaultValue=false)]
        public Guid? DefaultCapitalGainOnDisposalAccountId { get; set; }

        /// <summary>
        /// opt in for tax calculation
        /// </summary>
        /// <value>opt in for tax calculation</value>
        [DataMember(Name="optInForTax", EmitDefaultValue=false)]
        public bool? OptInForTax { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Setting {\n");
            sb.Append("  AssetNumberPrefix: ").Append(AssetNumberPrefix).Append("\n");
            sb.Append("  AssetNumberSequence: ").Append(AssetNumberSequence).Append("\n");
            sb.Append("  AssetStartDate: ").Append(AssetStartDate).Append("\n");
            sb.Append("  LastDepreciationDate: ").Append(LastDepreciationDate).Append("\n");
            sb.Append("  DefaultGainOnDisposalAccountId: ").Append(DefaultGainOnDisposalAccountId).Append("\n");
            sb.Append("  DefaultLossOnDisposalAccountId: ").Append(DefaultLossOnDisposalAccountId).Append("\n");
            sb.Append("  DefaultCapitalGainOnDisposalAccountId: ").Append(DefaultCapitalGainOnDisposalAccountId).Append("\n");
            sb.Append("  OptInForTax: ").Append(OptInForTax).Append("\n");
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
            return this.Equals(input as Setting);
        }

        /// <summary>
        /// Returns true if Setting instances are equal
        /// </summary>
        /// <param name="input">Instance of Setting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Setting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssetNumberPrefix == input.AssetNumberPrefix ||
                    (this.AssetNumberPrefix != null &&
                    this.AssetNumberPrefix.Equals(input.AssetNumberPrefix))
                ) && 
                (
                    this.AssetNumberSequence == input.AssetNumberSequence ||
                    (this.AssetNumberSequence != null &&
                    this.AssetNumberSequence.Equals(input.AssetNumberSequence))
                ) && 
                (
                    this.AssetStartDate == input.AssetStartDate ||
                    (this.AssetStartDate != null &&
                    this.AssetStartDate.Equals(input.AssetStartDate))
                ) && 
                (
                    this.LastDepreciationDate == input.LastDepreciationDate ||
                    (this.LastDepreciationDate != null &&
                    this.LastDepreciationDate.Equals(input.LastDepreciationDate))
                ) && 
                (
                    this.DefaultGainOnDisposalAccountId == input.DefaultGainOnDisposalAccountId ||
                    (this.DefaultGainOnDisposalAccountId != null &&
                    this.DefaultGainOnDisposalAccountId.Equals(input.DefaultGainOnDisposalAccountId))
                ) && 
                (
                    this.DefaultLossOnDisposalAccountId == input.DefaultLossOnDisposalAccountId ||
                    (this.DefaultLossOnDisposalAccountId != null &&
                    this.DefaultLossOnDisposalAccountId.Equals(input.DefaultLossOnDisposalAccountId))
                ) && 
                (
                    this.DefaultCapitalGainOnDisposalAccountId == input.DefaultCapitalGainOnDisposalAccountId ||
                    (this.DefaultCapitalGainOnDisposalAccountId != null &&
                    this.DefaultCapitalGainOnDisposalAccountId.Equals(input.DefaultCapitalGainOnDisposalAccountId))
                ) && 
                (
                    this.OptInForTax == input.OptInForTax ||
                    (this.OptInForTax != null &&
                    this.OptInForTax.Equals(input.OptInForTax))
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
                if (this.AssetNumberPrefix != null)
                    hashCode = hashCode * 59 + this.AssetNumberPrefix.GetHashCode();
                if (this.AssetNumberSequence != null)
                    hashCode = hashCode * 59 + this.AssetNumberSequence.GetHashCode();
                if (this.AssetStartDate != null)
                    hashCode = hashCode * 59 + this.AssetStartDate.GetHashCode();
                if (this.LastDepreciationDate != null)
                    hashCode = hashCode * 59 + this.LastDepreciationDate.GetHashCode();
                if (this.DefaultGainOnDisposalAccountId != null)
                    hashCode = hashCode * 59 + this.DefaultGainOnDisposalAccountId.GetHashCode();
                if (this.DefaultLossOnDisposalAccountId != null)
                    hashCode = hashCode * 59 + this.DefaultLossOnDisposalAccountId.GetHashCode();
                if (this.DefaultCapitalGainOnDisposalAccountId != null)
                    hashCode = hashCode * 59 + this.DefaultCapitalGainOnDisposalAccountId.GetHashCode();
                if (this.OptInForTax != null)
                    hashCode = hashCode * 59 + this.OptInForTax.GetHashCode();
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
