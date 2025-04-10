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
    /// EarningsRate
    /// </summary>
    [DataContract]
    public partial class EarningsRate :  IEquatable<EarningsRate>, IValidatableObject
    {
        /// <summary>
        /// Indicates how an employee will be paid when taking this type of earning
        /// </summary>
        /// <value>Indicates how an employee will be paid when taking this type of earning</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum EarningsTypeEnum
        {
            /// <summary>
            /// Enum Allowance for value: Allowance
            /// </summary>
            [EnumMember(Value = "Allowance")]
            Allowance = 1,

            /// <summary>
            /// Enum BackPay for value: BackPay
            /// </summary>
            [EnumMember(Value = "BackPay")]
            BackPay = 2,

            /// <summary>
            /// Enum Bonus for value: Bonus
            /// </summary>
            [EnumMember(Value = "Bonus")]
            Bonus = 3,

            /// <summary>
            /// Enum Commission for value: Commission
            /// </summary>
            [EnumMember(Value = "Commission")]
            Commission = 4,

            /// <summary>
            /// Enum LumpSum for value: LumpSum
            /// </summary>
            [EnumMember(Value = "LumpSum")]
            LumpSum = 5,

            /// <summary>
            /// Enum OtherEarnings for value: OtherEarnings
            /// </summary>
            [EnumMember(Value = "OtherEarnings")]
            OtherEarnings = 6,

            /// <summary>
            /// Enum OvertimeEarnings for value: OvertimeEarnings
            /// </summary>
            [EnumMember(Value = "OvertimeEarnings")]
            OvertimeEarnings = 7,

            /// <summary>
            /// Enum RegularEarnings for value: RegularEarnings
            /// </summary>
            [EnumMember(Value = "RegularEarnings")]
            RegularEarnings = 8,

            /// <summary>
            /// Enum StatutoryAdoptionPay for value: StatutoryAdoptionPay
            /// </summary>
            [EnumMember(Value = "StatutoryAdoptionPay")]
            StatutoryAdoptionPay = 9,

            /// <summary>
            /// Enum StatutoryAdoptionPayNonPensionable for value: StatutoryAdoptionPayNonPensionable
            /// </summary>
            [EnumMember(Value = "StatutoryAdoptionPayNonPensionable")]
            StatutoryAdoptionPayNonPensionable = 10,

            /// <summary>
            /// Enum StatutoryBereavementPay for value: StatutoryBereavementPay
            /// </summary>
            [EnumMember(Value = "StatutoryBereavementPay")]
            StatutoryBereavementPay = 11,

            /// <summary>
            /// Enum StatutoryMaternityPay for value: StatutoryMaternityPay
            /// </summary>
            [EnumMember(Value = "StatutoryMaternityPay")]
            StatutoryMaternityPay = 12,

            /// <summary>
            /// Enum StatutoryMaternityPayNonPensionable for value: StatutoryMaternityPayNonPensionable
            /// </summary>
            [EnumMember(Value = "StatutoryMaternityPayNonPensionable")]
            StatutoryMaternityPayNonPensionable = 13,

            /// <summary>
            /// Enum StatutoryPaternityPay for value: StatutoryPaternityPay
            /// </summary>
            [EnumMember(Value = "StatutoryPaternityPay")]
            StatutoryPaternityPay = 14,

            /// <summary>
            /// Enum StatutoryPaternityPayNonPensionable for value: StatutoryPaternityPayNonPensionable
            /// </summary>
            [EnumMember(Value = "StatutoryPaternityPayNonPensionable")]
            StatutoryPaternityPayNonPensionable = 15,

            /// <summary>
            /// Enum StatutoryParentalBereavementPayNonPensionable for value: StatutoryParentalBereavementPayNonPensionable
            /// </summary>
            [EnumMember(Value = "StatutoryParentalBereavementPayNonPensionable")]
            StatutoryParentalBereavementPayNonPensionable = 16,

            /// <summary>
            /// Enum StatutorySharedParentalPay for value: StatutorySharedParentalPay
            /// </summary>
            [EnumMember(Value = "StatutorySharedParentalPay")]
            StatutorySharedParentalPay = 17,

            /// <summary>
            /// Enum StatutorySharedParentalPayNonPensionable for value: StatutorySharedParentalPayNonPensionable
            /// </summary>
            [EnumMember(Value = "StatutorySharedParentalPayNonPensionable")]
            StatutorySharedParentalPayNonPensionable = 18,

            /// <summary>
            /// Enum StatutorySickPay for value: StatutorySickPay
            /// </summary>
            [EnumMember(Value = "StatutorySickPay")]
            StatutorySickPay = 19,

            /// <summary>
            /// Enum StatutorySickPayNonPensionable for value: StatutorySickPayNonPensionable
            /// </summary>
            [EnumMember(Value = "StatutorySickPayNonPensionable")]
            StatutorySickPayNonPensionable = 20,

            /// <summary>
            /// Enum TipsNonDirect for value: TipsNonDirect
            /// </summary>
            [EnumMember(Value = "TipsNonDirect")]
            TipsNonDirect = 21,

            /// <summary>
            /// Enum TipsDirect for value: TipsDirect
            /// </summary>
            [EnumMember(Value = "TipsDirect")]
            TipsDirect = 22,

            /// <summary>
            /// Enum TerminationPay for value: TerminationPay
            /// </summary>
            [EnumMember(Value = "TerminationPay")]
            TerminationPay = 23,

            /// <summary>
            /// Enum StatutoryNeonatalCarePay for value: StatutoryNeonatalCarePay
            /// </summary>
            [EnumMember(Value = "StatutoryNeonatalCarePay")]
            StatutoryNeonatalCarePay = 24,

            /// <summary>
            /// Enum StatutoryNeonatalCarePayNonPensionable for value: StatutoryNeonatalCarePayNonPensionable
            /// </summary>
            [EnumMember(Value = "StatutoryNeonatalCarePayNonPensionable")]
            StatutoryNeonatalCarePayNonPensionable = 25

        }

        /// <summary>
        /// Indicates how an employee will be paid when taking this type of earning
        /// </summary>
        /// <value>Indicates how an employee will be paid when taking this type of earning</value>
        [DataMember(Name="earningsType", EmitDefaultValue=false)]
        public EarningsTypeEnum EarningsType { get; set; }
        /// <summary>
        /// Indicates the type of the earning rate
        /// </summary>
        /// <value>Indicates the type of the earning rate</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum RateTypeEnum
        {
            /// <summary>
            /// Enum RatePerUnit for value: RatePerUnit
            /// </summary>
            [EnumMember(Value = "RatePerUnit")]
            RatePerUnit = 1,

            /// <summary>
            /// Enum MultipleOfOrdinaryEarningsRate for value: MultipleOfOrdinaryEarningsRate
            /// </summary>
            [EnumMember(Value = "MultipleOfOrdinaryEarningsRate")]
            MultipleOfOrdinaryEarningsRate = 2,

            /// <summary>
            /// Enum FixedAmount for value: FixedAmount
            /// </summary>
            [EnumMember(Value = "FixedAmount")]
            FixedAmount = 3

        }

        /// <summary>
        /// Indicates the type of the earning rate
        /// </summary>
        /// <value>Indicates the type of the earning rate</value>
        [DataMember(Name="rateType", EmitDefaultValue=false)]
        public RateTypeEnum RateType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EarningsRate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public EarningsRate() 
        { 
        }
        
        /// <summary>
        /// Xero unique identifier for an earning rate
        /// </summary>
        /// <value>Xero unique identifier for an earning rate</value>
        [DataMember(Name="earningsRateID", EmitDefaultValue=false)]
        public Guid? EarningsRateID { get; set; }

        /// <summary>
        /// Name of the earning rate
        /// </summary>
        /// <value>Name of the earning rate</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The type of units used to record earnings
        /// </summary>
        /// <value>The type of units used to record earnings</value>
        [DataMember(Name="typeOfUnits", EmitDefaultValue=false)]
        public string TypeOfUnits { get; set; }

        /// <summary>
        /// Indicates whether an earning type is active
        /// </summary>
        /// <value>Indicates whether an earning type is active</value>
        [DataMember(Name="currentRecord", EmitDefaultValue=false)]
        public bool? CurrentRecord { get; set; }

        /// <summary>
        /// The account that will be used for the earnings rate
        /// </summary>
        /// <value>The account that will be used for the earnings rate</value>
        [DataMember(Name="expenseAccountID", EmitDefaultValue=false)]
        public Guid? ExpenseAccountID { get; set; }

        /// <summary>
        /// Default rate per unit (optional). Only applicable if RateType is RatePerUnit
        /// </summary>
        /// <value>Default rate per unit (optional). Only applicable if RateType is RatePerUnit</value>
        [DataMember(Name="ratePerUnit", EmitDefaultValue=false)]
        public decimal? RatePerUnit { get; set; }

        /// <summary>
        /// This is the multiplier used to calculate the rate per unit, based on the employee’s ordinary earnings rate. For example, for time and a half enter 1.5. Only applicable if RateType is MultipleOfOrdinaryEarningsRate
        /// </summary>
        /// <value>This is the multiplier used to calculate the rate per unit, based on the employee’s ordinary earnings rate. For example, for time and a half enter 1.5. Only applicable if RateType is MultipleOfOrdinaryEarningsRate</value>
        [DataMember(Name="multipleOfOrdinaryEarningsRate", EmitDefaultValue=false)]
        public decimal? MultipleOfOrdinaryEarningsRate { get; set; }

        /// <summary>
        /// Optional Fixed Rate Amount. Applicable for FixedAmount Rate
        /// </summary>
        /// <value>Optional Fixed Rate Amount. Applicable for FixedAmount Rate</value>
        [DataMember(Name="fixedAmount", EmitDefaultValue=false)]
        public decimal? FixedAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EarningsRate {\n");
            sb.Append("  EarningsRateID: ").Append(EarningsRateID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EarningsType: ").Append(EarningsType).Append("\n");
            sb.Append("  RateType: ").Append(RateType).Append("\n");
            sb.Append("  TypeOfUnits: ").Append(TypeOfUnits).Append("\n");
            sb.Append("  CurrentRecord: ").Append(CurrentRecord).Append("\n");
            sb.Append("  ExpenseAccountID: ").Append(ExpenseAccountID).Append("\n");
            sb.Append("  RatePerUnit: ").Append(RatePerUnit).Append("\n");
            sb.Append("  MultipleOfOrdinaryEarningsRate: ").Append(MultipleOfOrdinaryEarningsRate).Append("\n");
            sb.Append("  FixedAmount: ").Append(FixedAmount).Append("\n");
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
            return this.Equals(input as EarningsRate);
        }

        /// <summary>
        /// Returns true if EarningsRate instances are equal
        /// </summary>
        /// <param name="input">Instance of EarningsRate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EarningsRate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EarningsRateID == input.EarningsRateID ||
                    (this.EarningsRateID != null &&
                    this.EarningsRateID.Equals(input.EarningsRateID))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.EarningsType == input.EarningsType ||
                    this.EarningsType.Equals(input.EarningsType)
                ) && 
                (
                    this.RateType == input.RateType ||
                    this.RateType.Equals(input.RateType)
                ) && 
                (
                    this.TypeOfUnits == input.TypeOfUnits ||
                    (this.TypeOfUnits != null &&
                    this.TypeOfUnits.Equals(input.TypeOfUnits))
                ) && 
                (
                    this.CurrentRecord == input.CurrentRecord ||
                    (this.CurrentRecord != null &&
                    this.CurrentRecord.Equals(input.CurrentRecord))
                ) && 
                (
                    this.ExpenseAccountID == input.ExpenseAccountID ||
                    (this.ExpenseAccountID != null &&
                    this.ExpenseAccountID.Equals(input.ExpenseAccountID))
                ) && 
                (
                    this.RatePerUnit == input.RatePerUnit ||
                    (this.RatePerUnit != null &&
                    this.RatePerUnit.Equals(input.RatePerUnit))
                ) && 
                (
                    this.MultipleOfOrdinaryEarningsRate == input.MultipleOfOrdinaryEarningsRate ||
                    (this.MultipleOfOrdinaryEarningsRate != null &&
                    this.MultipleOfOrdinaryEarningsRate.Equals(input.MultipleOfOrdinaryEarningsRate))
                ) && 
                (
                    this.FixedAmount == input.FixedAmount ||
                    (this.FixedAmount != null &&
                    this.FixedAmount.Equals(input.FixedAmount))
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
                if (this.EarningsRateID != null)
                    hashCode = hashCode * 59 + this.EarningsRateID.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.EarningsType.GetHashCode();
                hashCode = hashCode * 59 + this.RateType.GetHashCode();
                if (this.TypeOfUnits != null)
                    hashCode = hashCode * 59 + this.TypeOfUnits.GetHashCode();
                if (this.CurrentRecord != null)
                    hashCode = hashCode * 59 + this.CurrentRecord.GetHashCode();
                if (this.ExpenseAccountID != null)
                    hashCode = hashCode * 59 + this.ExpenseAccountID.GetHashCode();
                if (this.RatePerUnit != null)
                    hashCode = hashCode * 59 + this.RatePerUnit.GetHashCode();
                if (this.MultipleOfOrdinaryEarningsRate != null)
                    hashCode = hashCode * 59 + this.MultipleOfOrdinaryEarningsRate.GetHashCode();
                if (this.FixedAmount != null)
                    hashCode = hashCode * 59 + this.FixedAmount.GetHashCode();
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
