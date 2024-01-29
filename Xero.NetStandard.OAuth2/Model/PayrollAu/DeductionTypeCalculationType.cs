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
    /// Defines DeductionTypeCalculationType
    /// </summary>
    
    [JsonConverter(typeof(Client.CustomStringEnumConverter))]
    
    public enum DeductionTypeCalculationType
    {
        /// <summary>
        /// Enum FIXEDAMOUNT for value: FIXEDAMOUNT
        /// </summary>
        [EnumMember(Value = "FIXEDAMOUNT")]
        FIXEDAMOUNT = 1,

        /// <summary>
        /// Enum PRETAX for value: PRETAX
        /// </summary>
        [EnumMember(Value = "PRETAX")]
        PRETAX = 2,

        /// <summary>
        /// Enum POSTTAX for value: POSTTAX
        /// </summary>
        [EnumMember(Value = "POSTTAX")]
        POSTTAX = 3

    }

}