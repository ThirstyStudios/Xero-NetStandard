/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.8.0
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Model.PayrollAu;
using Xero.NetStandard.OAuth2.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Xero.NetStandard.OAuth2.Test.Model.PayrollAu
{
    /// <summary>
    ///  Class for testing DeductionType
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DeductionTypeTests : IDisposable
    {
        public DeductionTypeTests()
        {
            // TODO uncomment below to create an instance of DeductionType
            //instance = new DeductionType();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test the property 'DeductionCategory'
        /// </summary>
        [Theory]
        [InlineData("NONE", DeductionType.DeductionCategoryEnum.NONE)]
        [InlineData("UNIONFEES", DeductionType.DeductionCategoryEnum.UNIONFEES)]
        [InlineData("WORKPLACEGIVING", DeductionType.DeductionCategoryEnum.WORKPLACEGIVING)]
        public void DeductionCategory_ValidInputs_Deserialises(string input, DeductionType.DeductionCategoryEnum expected)
        {
            JsonDoc.Assert<DeductionType, DeductionType.DeductionCategoryEnum>(
                input: new JsonDoc.String(nameof(DeductionType.DeductionCategory), input),
                toProperty: (x) => x.DeductionCategory,
                shouldBe: expected
            );
        }
    }
}
