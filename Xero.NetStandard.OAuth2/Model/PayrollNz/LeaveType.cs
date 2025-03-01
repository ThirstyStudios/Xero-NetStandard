/* 
 * Xero Payroll NZ
 *
 * This is the Xero Payroll API for orgs in the NZ region.
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

namespace Xero.NetStandard.OAuth2.Model.PayrollNz
{
    /// <summary>
    /// LeaveType
    /// </summary>
    [DataContract]
    public partial class LeaveType :  IEquatable<LeaveType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LeaveType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public LeaveType() 
        { 
        }
        
        /// <summary>
        /// Xero unique identifier for the leave type
        /// </summary>
        /// <value>Xero unique identifier for the leave type</value>
        [DataMember(Name="leaveTypeID", EmitDefaultValue=false)]
        public Guid? LeaveTypeID { get; set; }

        /// <summary>
        /// Name of the leave type
        /// </summary>
        /// <value>Name of the leave type</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Indicate that an employee will be paid when taking this type of leave
        /// </summary>
        /// <value>Indicate that an employee will be paid when taking this type of leave</value>
        [DataMember(Name="isPaidLeave", EmitDefaultValue=false)]
        public bool? IsPaidLeave { get; set; }

        /// <summary>
        /// Indicate that a balance for this leave type to be shown on the employee’s payslips
        /// </summary>
        /// <value>Indicate that a balance for this leave type to be shown on the employee’s payslips</value>
        [DataMember(Name="showOnPayslip", EmitDefaultValue=false)]
        public bool? ShowOnPayslip { get; set; }

        /// <summary>
        /// UTC timestamp of last update to the leave type note
        /// </summary>
        /// <value>UTC timestamp of last update to the leave type note</value>
        [DataMember(Name="updatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; set; }

        /// <summary>
        /// Shows whether the leave type is active or not
        /// </summary>
        /// <value>Shows whether the leave type is active or not</value>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// The type of units to be paid for the leave type
        /// </summary>
        /// <value>The type of units to be paid for the leave type</value>
        [DataMember(Name="typeOfUnits", EmitDefaultValue=false)]
        public string TypeOfUnits { get; set; }

        /// <summary>
        /// The type of units to be accrued for the leave type
        /// </summary>
        /// <value>The type of units to be accrued for the leave type</value>
        [DataMember(Name="typeOfUnitsToAccrue", EmitDefaultValue=false)]
        public string TypeOfUnitsToAccrue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeaveType {\n");
            sb.Append("  LeaveTypeID: ").Append(LeaveTypeID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsPaidLeave: ").Append(IsPaidLeave).Append("\n");
            sb.Append("  ShowOnPayslip: ").Append(ShowOnPayslip).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  TypeOfUnits: ").Append(TypeOfUnits).Append("\n");
            sb.Append("  TypeOfUnitsToAccrue: ").Append(TypeOfUnitsToAccrue).Append("\n");
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
            return this.Equals(input as LeaveType);
        }

        /// <summary>
        /// Returns true if LeaveType instances are equal
        /// </summary>
        /// <param name="input">Instance of LeaveType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeaveType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LeaveTypeID == input.LeaveTypeID ||
                    (this.LeaveTypeID != null &&
                    this.LeaveTypeID.Equals(input.LeaveTypeID))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IsPaidLeave == input.IsPaidLeave ||
                    (this.IsPaidLeave != null &&
                    this.IsPaidLeave.Equals(input.IsPaidLeave))
                ) && 
                (
                    this.ShowOnPayslip == input.ShowOnPayslip ||
                    (this.ShowOnPayslip != null &&
                    this.ShowOnPayslip.Equals(input.ShowOnPayslip))
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.TypeOfUnits == input.TypeOfUnits ||
                    (this.TypeOfUnits != null &&
                    this.TypeOfUnits.Equals(input.TypeOfUnits))
                ) && 
                (
                    this.TypeOfUnitsToAccrue == input.TypeOfUnitsToAccrue ||
                    (this.TypeOfUnitsToAccrue != null &&
                    this.TypeOfUnitsToAccrue.Equals(input.TypeOfUnitsToAccrue))
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
                if (this.LeaveTypeID != null)
                    hashCode = hashCode * 59 + this.LeaveTypeID.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IsPaidLeave != null)
                    hashCode = hashCode * 59 + this.IsPaidLeave.GetHashCode();
                if (this.ShowOnPayslip != null)
                    hashCode = hashCode * 59 + this.ShowOnPayslip.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.TypeOfUnits != null)
                    hashCode = hashCode * 59 + this.TypeOfUnits.GetHashCode();
                if (this.TypeOfUnitsToAccrue != null)
                    hashCode = hashCode * 59 + this.TypeOfUnitsToAccrue.GetHashCode();
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
