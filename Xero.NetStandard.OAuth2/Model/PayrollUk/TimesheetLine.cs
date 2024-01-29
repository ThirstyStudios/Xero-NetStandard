/* 
 * Xero Payroll UK
 *
 * This is the Xero Payroll API for orgs in the UK region.
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

namespace Xero.NetStandard.OAuth2.Model.PayrollUk
{
    /// <summary>
    /// TimesheetLine
    /// </summary>
    [DataContract]
    public partial class TimesheetLine :  IEquatable<TimesheetLine>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimesheetLine" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public TimesheetLine() 
        { 
        }
        
        /// <summary>
        /// The Xero identifier for a Timesheet Line
        /// </summary>
        /// <value>The Xero identifier for a Timesheet Line</value>
        [DataMember(Name="timesheetLineID", EmitDefaultValue=false)]
        public Guid? TimesheetLineID { get; set; }

        /// <summary>
        /// The Date that this Timesheet Line is for (YYYY-MM-DD)
        /// </summary>
        /// <value>The Date that this Timesheet Line is for (YYYY-MM-DD)</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The Xero identifier for the Earnings Rate that the Timesheet is for
        /// </summary>
        /// <value>The Xero identifier for the Earnings Rate that the Timesheet is for</value>
        [DataMember(Name="earningsRateID", EmitDefaultValue=false)]
        public Guid? EarningsRateID { get; set; }

        /// <summary>
        /// The Xero identifier for the Tracking Item that the Timesheet is for
        /// </summary>
        /// <value>The Xero identifier for the Tracking Item that the Timesheet is for</value>
        [DataMember(Name="trackingItemID", EmitDefaultValue=false)]
        public Guid? TrackingItemID { get; set; }

        /// <summary>
        /// The Number of Units of the Timesheet Line
        /// </summary>
        /// <value>The Number of Units of the Timesheet Line</value>
        [DataMember(Name="numberOfUnits", EmitDefaultValue=false)]
        public double? NumberOfUnits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimesheetLine {\n");
            sb.Append("  TimesheetLineID: ").Append(TimesheetLineID).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  EarningsRateID: ").Append(EarningsRateID).Append("\n");
            sb.Append("  TrackingItemID: ").Append(TrackingItemID).Append("\n");
            sb.Append("  NumberOfUnits: ").Append(NumberOfUnits).Append("\n");
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
            return this.Equals(input as TimesheetLine);
        }

        /// <summary>
        /// Returns true if TimesheetLine instances are equal
        /// </summary>
        /// <param name="input">Instance of TimesheetLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimesheetLine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TimesheetLineID == input.TimesheetLineID ||
                    (this.TimesheetLineID != null &&
                    this.TimesheetLineID.Equals(input.TimesheetLineID))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.EarningsRateID == input.EarningsRateID ||
                    (this.EarningsRateID != null &&
                    this.EarningsRateID.Equals(input.EarningsRateID))
                ) && 
                (
                    this.TrackingItemID == input.TrackingItemID ||
                    (this.TrackingItemID != null &&
                    this.TrackingItemID.Equals(input.TrackingItemID))
                ) && 
                (
                    this.NumberOfUnits == input.NumberOfUnits ||
                    (this.NumberOfUnits != null &&
                    this.NumberOfUnits.Equals(input.NumberOfUnits))
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
                if (this.TimesheetLineID != null)
                    hashCode = hashCode * 59 + this.TimesheetLineID.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.EarningsRateID != null)
                    hashCode = hashCode * 59 + this.EarningsRateID.GetHashCode();
                if (this.TrackingItemID != null)
                    hashCode = hashCode * 59 + this.TrackingItemID.GetHashCode();
                if (this.NumberOfUnits != null)
                    hashCode = hashCode * 59 + this.NumberOfUnits.GetHashCode();
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
