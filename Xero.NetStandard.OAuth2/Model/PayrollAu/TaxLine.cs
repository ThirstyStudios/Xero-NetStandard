/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.2.15
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

namespace Xero.NetStandard.OAuth2.Model.PayrollAu
{
    /// <summary>
    /// TaxLine
    /// </summary>
    [DataContract]
    public partial class TaxLine :  IEquatable<TaxLine>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ManualTaxType
        /// </summary>
        [DataMember(Name="ManualTaxType", EmitDefaultValue=false)]
        public ManualTaxType ManualTaxType { get; set; }
        
        /// <summary>
        /// Xero identifier for payslip tax line ID.
        /// </summary>
        /// <value>Xero identifier for payslip tax line ID.</value>
        [DataMember(Name="PayslipTaxLineID", EmitDefaultValue=false)]
        public Guid? PayslipTaxLineID { get; set; }

        /// <summary>
        /// The tax line amount
        /// </summary>
        /// <value>The tax line amount</value>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Name of the tax type.
        /// </summary>
        /// <value>Name of the tax type.</value>
        [DataMember(Name="TaxTypeName", EmitDefaultValue=false)]
        public string TaxTypeName { get; set; }

        /// <summary>
        /// Description of the tax line.
        /// </summary>
        /// <value>Description of the tax line.</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The tax line liability account code. For posted pay run you should be able to see liability account code
        /// </summary>
        /// <value>The tax line liability account code. For posted pay run you should be able to see liability account code</value>
        [DataMember(Name="LiabilityAccount", EmitDefaultValue=false)]
        public string LiabilityAccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxLine {\n");
            sb.Append("  PayslipTaxLineID: ").Append(PayslipTaxLineID).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  TaxTypeName: ").Append(TaxTypeName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ManualTaxType: ").Append(ManualTaxType).Append("\n");
            sb.Append("  LiabilityAccount: ").Append(LiabilityAccount).Append("\n");
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
            return this.Equals(input as TaxLine);
        }

        /// <summary>
        /// Returns true if TaxLine instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxLine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PayslipTaxLineID == input.PayslipTaxLineID ||
                    (this.PayslipTaxLineID != null &&
                    this.PayslipTaxLineID.Equals(input.PayslipTaxLineID))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.TaxTypeName == input.TaxTypeName ||
                    (this.TaxTypeName != null &&
                    this.TaxTypeName.Equals(input.TaxTypeName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ManualTaxType == input.ManualTaxType ||
                    this.ManualTaxType.Equals(input.ManualTaxType)
                ) && 
                (
                    this.LiabilityAccount == input.LiabilityAccount ||
                    (this.LiabilityAccount != null &&
                    this.LiabilityAccount.Equals(input.LiabilityAccount))
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
                if (this.PayslipTaxLineID != null)
                    hashCode = hashCode * 59 + this.PayslipTaxLineID.GetHashCode();
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.TaxTypeName != null)
                    hashCode = hashCode * 59 + this.TaxTypeName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.ManualTaxType.GetHashCode();
                if (this.LiabilityAccount != null)
                    hashCode = hashCode * 59 + this.LiabilityAccount.GetHashCode();
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
