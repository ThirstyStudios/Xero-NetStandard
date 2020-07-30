/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.2.2
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
    /// Settings
    /// </summary>
    [DataContract]
    public partial class Settings :  IEquatable<Settings>, IValidatableObject
    {
        
        /// <summary>
        /// Payroll Account details for SuperExpense, SuperLiabilty, WagesExpense, PAYGLiability &amp; WagesPayable.
        /// </summary>
        /// <value>Payroll Account details for SuperExpense, SuperLiabilty, WagesExpense, PAYGLiability &amp; WagesPayable.</value>
        [DataMember(Name="Accounts", EmitDefaultValue=false)]
        public List<Account> Accounts { get; set; }

        /// <summary>
        /// Gets or Sets TrackingCategories
        /// </summary>
        [DataMember(Name="TrackingCategories", EmitDefaultValue=false)]
        public SettingsTrackingCategories TrackingCategories { get; set; }

        /// <summary>
        /// Number of days in the Payroll year
        /// </summary>
        /// <value>Number of days in the Payroll year</value>
        [DataMember(Name="DaysInPayrollYear", EmitDefaultValue=false)]
        public int? DaysInPayrollYear { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Settings {\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  TrackingCategories: ").Append(TrackingCategories).Append("\n");
            sb.Append("  DaysInPayrollYear: ").Append(DaysInPayrollYear).Append("\n");
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
            return this.Equals(input as Settings);
        }

        /// <summary>
        /// Returns true if Settings instances are equal
        /// </summary>
        /// <param name="input">Instance of Settings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Settings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    input.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
                ) && 
                (
                    this.TrackingCategories == input.TrackingCategories ||
                    (this.TrackingCategories != null &&
                    this.TrackingCategories.Equals(input.TrackingCategories))
                ) && 
                (
                    this.DaysInPayrollYear == input.DaysInPayrollYear ||
                    this.DaysInPayrollYear.Equals(input.DaysInPayrollYear)
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
                if (this.Accounts != null)
                    hashCode = hashCode * 59 + this.Accounts.GetHashCode();
                if (this.TrackingCategories != null)
                    hashCode = hashCode * 59 + this.TrackingCategories.GetHashCode();
                hashCode = hashCode * 59 + this.DaysInPayrollYear.GetHashCode();
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
