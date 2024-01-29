/* 
 * Xero Payroll AU API
 *
 * This is the Xero Payroll API for orgs in Australia region.
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

namespace Xero.NetStandard.OAuth2.Model.PayrollAu
{
    /// <summary>
    /// Defines EarningsType
    /// </summary>
    
    [JsonConverter(typeof(Client.CustomStringEnumConverter))]
    
    public enum EarningsType
    {
        /// <summary>
        /// Enum FIXED for value: FIXED
        /// </summary>
        [EnumMember(Value = "FIXED")]
        FIXED = 1,

        /// <summary>
        /// Enum ORDINARYTIMEEARNINGS for value: ORDINARYTIMEEARNINGS
        /// </summary>
        [EnumMember(Value = "ORDINARYTIMEEARNINGS")]
        ORDINARYTIMEEARNINGS = 2,

        /// <summary>
        /// Enum OVERTIMEEARNINGS for value: OVERTIMEEARNINGS
        /// </summary>
        [EnumMember(Value = "OVERTIMEEARNINGS")]
        OVERTIMEEARNINGS = 3,

        /// <summary>
        /// Enum ALLOWANCE for value: ALLOWANCE
        /// </summary>
        [EnumMember(Value = "ALLOWANCE")]
        ALLOWANCE = 4,

        /// <summary>
        /// Enum LUMPSUMD for value: LUMPSUMD
        /// </summary>
        [EnumMember(Value = "LUMPSUMD")]
        LUMPSUMD = 5,

        /// <summary>
        /// Enum EMPLOYMENTTERMINATIONPAYMENT for value: EMPLOYMENTTERMINATIONPAYMENT
        /// </summary>
        [EnumMember(Value = "EMPLOYMENTTERMINATIONPAYMENT")]
        EMPLOYMENTTERMINATIONPAYMENT = 6,

        /// <summary>
        /// Enum LUMPSUMA for value: LUMPSUMA
        /// </summary>
        [EnumMember(Value = "LUMPSUMA")]
        LUMPSUMA = 7,

        /// <summary>
        /// Enum LUMPSUMB for value: LUMPSUMB
        /// </summary>
        [EnumMember(Value = "LUMPSUMB")]
        LUMPSUMB = 8,

        /// <summary>
        /// Enum BONUSESANDCOMMISSIONS for value: BONUSESANDCOMMISSIONS
        /// </summary>
        [EnumMember(Value = "BONUSESANDCOMMISSIONS")]
        BONUSESANDCOMMISSIONS = 9,

        /// <summary>
        /// Enum LUMPSUME for value: LUMPSUME
        /// </summary>
        [EnumMember(Value = "LUMPSUME")]
        LUMPSUME = 10,

        /// <summary>
        /// Enum LUMPSUMW for value: LUMPSUMW
        /// </summary>
        [EnumMember(Value = "LUMPSUMW")]
        LUMPSUMW = 11,

        /// <summary>
        /// Enum DIRECTORSFEES for value: DIRECTORSFEES
        /// </summary>
        [EnumMember(Value = "DIRECTORSFEES")]
        DIRECTORSFEES = 12,

        /// <summary>
        /// Enum PAIDPARENTALLEAVE for value: PAIDPARENTALLEAVE
        /// </summary>
        [EnumMember(Value = "PAIDPARENTALLEAVE")]
        PAIDPARENTALLEAVE = 13,

        /// <summary>
        /// Enum WORKERSCOMPENSATION for value: WORKERSCOMPENSATION
        /// </summary>
        [EnumMember(Value = "WORKERSCOMPENSATION")]
        WORKERSCOMPENSATION = 14

    }

}