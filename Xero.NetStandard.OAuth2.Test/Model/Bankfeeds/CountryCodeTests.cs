/* 
 * Bank Feeds API
 *
 * This specifing endpoints Xero Bank feeds API
 *
 * The version of the OpenAPI document: 2.6.1
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Model.Bankfeeds;
using Xero.NetStandard.OAuth2.Client;
using System.Reflection;
using Newtonsoft.Json;
using RestSharp;

namespace Xero.NetStandard.OAuth2.Test.Model.Bankfeeds
{
    /// <summary>
    ///  Class for testing CountryCode
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CountryCodeTests : IDisposable
    {
        public CountryCodeTests()
        {
            // TODO uncomment below to create an instance of CountryCode
            //instance = new CountryCode();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test that CountryCode can be deserialised from valid inputs
        /// </summary>
        [Theory]
        [InlineData("AU", CountryCode.AU)]
        [InlineData("NZ", CountryCode.NZ)]
        public void CountryCode_ValidInput_Deserialises(string input, CountryCode expected)
        {
            var response = new RestResponse();
            response.Content = $@"""{input}""";
            response.StatusCode = System.Net.HttpStatusCode.OK;

            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = deserializer.Deserialize<CountryCode>(response);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Test that CountryCode can be deserialised from null into 0
        /// </summary>
        [Fact]
        public void CountryCode_NullInput_Deserialises()
        {
            var response = new RestResponse();
            response.Content = "null";
            response.StatusCode = System.Net.HttpStatusCode.OK;

            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = deserializer.Deserialize<CountryCode>(response);

            Assert.Equal(0, (int)actual);
        }

    }

}
