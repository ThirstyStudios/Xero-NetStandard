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
    /// How the requested leave will be paid out, e.g. cashed out.
    /// </summary>
    /// <value>How the requested leave will be paid out, e.g. cashed out.</value>
    
    [JsonConverter(typeof(Client.CustomStringEnumConverter))]
    
    public enum PayOutType
    {
        /// <summary>
        /// Enum DEFAULT for value: DEFAULT
        /// </summary>
        [EnumMember(Value = "DEFAULT")]
        DEFAULT = 1,

        /// <summary>
        /// Enum CASHEDOUT for value: CASHED_OUT
        /// </summary>
        [EnumMember(Value = "CASHED_OUT")]
        CASHEDOUT = 2

    }

}
