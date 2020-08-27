/* 
 * Xero Payroll UK
 *
 * This is the Xero Payroll API for orgs in the UK region.
 *
 * The version of the OpenAPI document: 2.2.14
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
    /// TrackingCategory
    /// </summary>
    [DataContract]
    public partial class TrackingCategory :  IEquatable<TrackingCategory>, IValidatableObject
    {
        
        /// <summary>
        /// The Xero identifier for Employee groups tracking category.
        /// </summary>
        /// <value>The Xero identifier for Employee groups tracking category.</value>
        [DataMember(Name="employeeGroupsTrackingCategoryID", EmitDefaultValue=false)]
        public Guid? EmployeeGroupsTrackingCategoryID { get; set; }

        /// <summary>
        /// The Xero identifier for Timesheet tracking category.
        /// </summary>
        /// <value>The Xero identifier for Timesheet tracking category.</value>
        [DataMember(Name="timesheetTrackingCategoryID", EmitDefaultValue=false)]
        public Guid? TimesheetTrackingCategoryID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrackingCategory {\n");
            sb.Append("  EmployeeGroupsTrackingCategoryID: ").Append(EmployeeGroupsTrackingCategoryID).Append("\n");
            sb.Append("  TimesheetTrackingCategoryID: ").Append(TimesheetTrackingCategoryID).Append("\n");
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
            return this.Equals(input as TrackingCategory);
        }

        /// <summary>
        /// Returns true if TrackingCategory instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackingCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackingCategory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmployeeGroupsTrackingCategoryID == input.EmployeeGroupsTrackingCategoryID ||
                    (this.EmployeeGroupsTrackingCategoryID != null &&
                    this.EmployeeGroupsTrackingCategoryID.Equals(input.EmployeeGroupsTrackingCategoryID))
                ) && 
                (
                    this.TimesheetTrackingCategoryID == input.TimesheetTrackingCategoryID ||
                    (this.TimesheetTrackingCategoryID != null &&
                    this.TimesheetTrackingCategoryID.Equals(input.TimesheetTrackingCategoryID))
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
                if (this.EmployeeGroupsTrackingCategoryID != null)
                    hashCode = hashCode * 59 + this.EmployeeGroupsTrackingCategoryID.GetHashCode();
                if (this.TimesheetTrackingCategoryID != null)
                    hashCode = hashCode * 59 + this.TimesheetTrackingCategoryID.GetHashCode();
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
