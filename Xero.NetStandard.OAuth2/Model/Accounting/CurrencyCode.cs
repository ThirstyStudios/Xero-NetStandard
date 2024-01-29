/* 
 * Xero Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
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

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// 3 letter alpha code for the currency – see list of currency codes
    /// </summary>
    /// <value>3 letter alpha code for the currency – see list of currency codes</value>
    
    [JsonConverter(typeof(Client.CustomStringEnumConverter))]
    
    public enum CurrencyCode
    {
        /// <summary>
        /// Enum AED for value: AED
        /// </summary>
        [EnumMember(Value = "AED")]
        AED = 1,

        /// <summary>
        /// Enum AFN for value: AFN
        /// </summary>
        [EnumMember(Value = "AFN")]
        AFN = 2,

        /// <summary>
        /// Enum ALL for value: ALL
        /// </summary>
        [EnumMember(Value = "ALL")]
        ALL = 3,

        /// <summary>
        /// Enum AMD for value: AMD
        /// </summary>
        [EnumMember(Value = "AMD")]
        AMD = 4,

        /// <summary>
        /// Enum ANG for value: ANG
        /// </summary>
        [EnumMember(Value = "ANG")]
        ANG = 5,

        /// <summary>
        /// Enum AOA for value: AOA
        /// </summary>
        [EnumMember(Value = "AOA")]
        AOA = 6,

        /// <summary>
        /// Enum ARS for value: ARS
        /// </summary>
        [EnumMember(Value = "ARS")]
        ARS = 7,

        /// <summary>
        /// Enum AUD for value: AUD
        /// </summary>
        [EnumMember(Value = "AUD")]
        AUD = 8,

        /// <summary>
        /// Enum AWG for value: AWG
        /// </summary>
        [EnumMember(Value = "AWG")]
        AWG = 9,

        /// <summary>
        /// Enum AZN for value: AZN
        /// </summary>
        [EnumMember(Value = "AZN")]
        AZN = 10,

        /// <summary>
        /// Enum BAM for value: BAM
        /// </summary>
        [EnumMember(Value = "BAM")]
        BAM = 11,

        /// <summary>
        /// Enum BBD for value: BBD
        /// </summary>
        [EnumMember(Value = "BBD")]
        BBD = 12,

        /// <summary>
        /// Enum BDT for value: BDT
        /// </summary>
        [EnumMember(Value = "BDT")]
        BDT = 13,

        /// <summary>
        /// Enum BGN for value: BGN
        /// </summary>
        [EnumMember(Value = "BGN")]
        BGN = 14,

        /// <summary>
        /// Enum BHD for value: BHD
        /// </summary>
        [EnumMember(Value = "BHD")]
        BHD = 15,

        /// <summary>
        /// Enum BIF for value: BIF
        /// </summary>
        [EnumMember(Value = "BIF")]
        BIF = 16,

        /// <summary>
        /// Enum BMD for value: BMD
        /// </summary>
        [EnumMember(Value = "BMD")]
        BMD = 17,

        /// <summary>
        /// Enum BND for value: BND
        /// </summary>
        [EnumMember(Value = "BND")]
        BND = 18,

        /// <summary>
        /// Enum BOB for value: BOB
        /// </summary>
        [EnumMember(Value = "BOB")]
        BOB = 19,

        /// <summary>
        /// Enum BRL for value: BRL
        /// </summary>
        [EnumMember(Value = "BRL")]
        BRL = 20,

        /// <summary>
        /// Enum BSD for value: BSD
        /// </summary>
        [EnumMember(Value = "BSD")]
        BSD = 21,

        /// <summary>
        /// Enum BTN for value: BTN
        /// </summary>
        [EnumMember(Value = "BTN")]
        BTN = 22,

        /// <summary>
        /// Enum BWP for value: BWP
        /// </summary>
        [EnumMember(Value = "BWP")]
        BWP = 23,

        /// <summary>
        /// Enum BYN for value: BYN
        /// </summary>
        [EnumMember(Value = "BYN")]
        BYN = 24,

        /// <summary>
        /// Enum BYR for value: BYR
        /// </summary>
        [EnumMember(Value = "BYR")]
        BYR = 25,

        /// <summary>
        /// Enum BZD for value: BZD
        /// </summary>
        [EnumMember(Value = "BZD")]
        BZD = 26,

        /// <summary>
        /// Enum CAD for value: CAD
        /// </summary>
        [EnumMember(Value = "CAD")]
        CAD = 27,

        /// <summary>
        /// Enum CDF for value: CDF
        /// </summary>
        [EnumMember(Value = "CDF")]
        CDF = 28,

        /// <summary>
        /// Enum CHF for value: CHF
        /// </summary>
        [EnumMember(Value = "CHF")]
        CHF = 29,

        /// <summary>
        /// Enum CLF for value: CLF
        /// </summary>
        [EnumMember(Value = "CLF")]
        CLF = 30,

        /// <summary>
        /// Enum CLP for value: CLP
        /// </summary>
        [EnumMember(Value = "CLP")]
        CLP = 31,

        /// <summary>
        /// Enum CNY for value: CNY
        /// </summary>
        [EnumMember(Value = "CNY")]
        CNY = 32,

        /// <summary>
        /// Enum COP for value: COP
        /// </summary>
        [EnumMember(Value = "COP")]
        COP = 33,

        /// <summary>
        /// Enum CRC for value: CRC
        /// </summary>
        [EnumMember(Value = "CRC")]
        CRC = 34,

        /// <summary>
        /// Enum CUC for value: CUC
        /// </summary>
        [EnumMember(Value = "CUC")]
        CUC = 35,

        /// <summary>
        /// Enum CUP for value: CUP
        /// </summary>
        [EnumMember(Value = "CUP")]
        CUP = 36,

        /// <summary>
        /// Enum CVE for value: CVE
        /// </summary>
        [EnumMember(Value = "CVE")]
        CVE = 37,

        /// <summary>
        /// Enum CZK for value: CZK
        /// </summary>
        [EnumMember(Value = "CZK")]
        CZK = 38,

        /// <summary>
        /// Enum DJF for value: DJF
        /// </summary>
        [EnumMember(Value = "DJF")]
        DJF = 39,

        /// <summary>
        /// Enum DKK for value: DKK
        /// </summary>
        [EnumMember(Value = "DKK")]
        DKK = 40,

        /// <summary>
        /// Enum DOP for value: DOP
        /// </summary>
        [EnumMember(Value = "DOP")]
        DOP = 41,

        /// <summary>
        /// Enum DZD for value: DZD
        /// </summary>
        [EnumMember(Value = "DZD")]
        DZD = 42,

        /// <summary>
        /// Enum EEK for value: EEK
        /// </summary>
        [EnumMember(Value = "EEK")]
        EEK = 43,

        /// <summary>
        /// Enum EGP for value: EGP
        /// </summary>
        [EnumMember(Value = "EGP")]
        EGP = 44,

        /// <summary>
        /// Enum ERN for value: ERN
        /// </summary>
        [EnumMember(Value = "ERN")]
        ERN = 45,

        /// <summary>
        /// Enum ETB for value: ETB
        /// </summary>
        [EnumMember(Value = "ETB")]
        ETB = 46,

        /// <summary>
        /// Enum EUR for value: EUR
        /// </summary>
        [EnumMember(Value = "EUR")]
        EUR = 47,

        /// <summary>
        /// Enum FJD for value: FJD
        /// </summary>
        [EnumMember(Value = "FJD")]
        FJD = 48,

        /// <summary>
        /// Enum FKP for value: FKP
        /// </summary>
        [EnumMember(Value = "FKP")]
        FKP = 49,

        /// <summary>
        /// Enum GBP for value: GBP
        /// </summary>
        [EnumMember(Value = "GBP")]
        GBP = 50,

        /// <summary>
        /// Enum GEL for value: GEL
        /// </summary>
        [EnumMember(Value = "GEL")]
        GEL = 51,

        /// <summary>
        /// Enum GHS for value: GHS
        /// </summary>
        [EnumMember(Value = "GHS")]
        GHS = 52,

        /// <summary>
        /// Enum GIP for value: GIP
        /// </summary>
        [EnumMember(Value = "GIP")]
        GIP = 53,

        /// <summary>
        /// Enum GMD for value: GMD
        /// </summary>
        [EnumMember(Value = "GMD")]
        GMD = 54,

        /// <summary>
        /// Enum GNF for value: GNF
        /// </summary>
        [EnumMember(Value = "GNF")]
        GNF = 55,

        /// <summary>
        /// Enum GTQ for value: GTQ
        /// </summary>
        [EnumMember(Value = "GTQ")]
        GTQ = 56,

        /// <summary>
        /// Enum GYD for value: GYD
        /// </summary>
        [EnumMember(Value = "GYD")]
        GYD = 57,

        /// <summary>
        /// Enum HKD for value: HKD
        /// </summary>
        [EnumMember(Value = "HKD")]
        HKD = 58,

        /// <summary>
        /// Enum HNL for value: HNL
        /// </summary>
        [EnumMember(Value = "HNL")]
        HNL = 59,

        /// <summary>
        /// Enum HRK for value: HRK
        /// </summary>
        [EnumMember(Value = "HRK")]
        HRK = 60,

        /// <summary>
        /// Enum HTG for value: HTG
        /// </summary>
        [EnumMember(Value = "HTG")]
        HTG = 61,

        /// <summary>
        /// Enum HUF for value: HUF
        /// </summary>
        [EnumMember(Value = "HUF")]
        HUF = 62,

        /// <summary>
        /// Enum IDR for value: IDR
        /// </summary>
        [EnumMember(Value = "IDR")]
        IDR = 63,

        /// <summary>
        /// Enum ILS for value: ILS
        /// </summary>
        [EnumMember(Value = "ILS")]
        ILS = 64,

        /// <summary>
        /// Enum INR for value: INR
        /// </summary>
        [EnumMember(Value = "INR")]
        INR = 65,

        /// <summary>
        /// Enum IQD for value: IQD
        /// </summary>
        [EnumMember(Value = "IQD")]
        IQD = 66,

        /// <summary>
        /// Enum IRR for value: IRR
        /// </summary>
        [EnumMember(Value = "IRR")]
        IRR = 67,

        /// <summary>
        /// Enum ISK for value: ISK
        /// </summary>
        [EnumMember(Value = "ISK")]
        ISK = 68,

        /// <summary>
        /// Enum JMD for value: JMD
        /// </summary>
        [EnumMember(Value = "JMD")]
        JMD = 69,

        /// <summary>
        /// Enum JOD for value: JOD
        /// </summary>
        [EnumMember(Value = "JOD")]
        JOD = 70,

        /// <summary>
        /// Enum JPY for value: JPY
        /// </summary>
        [EnumMember(Value = "JPY")]
        JPY = 71,

        /// <summary>
        /// Enum KES for value: KES
        /// </summary>
        [EnumMember(Value = "KES")]
        KES = 72,

        /// <summary>
        /// Enum KGS for value: KGS
        /// </summary>
        [EnumMember(Value = "KGS")]
        KGS = 73,

        /// <summary>
        /// Enum KHR for value: KHR
        /// </summary>
        [EnumMember(Value = "KHR")]
        KHR = 74,

        /// <summary>
        /// Enum KMF for value: KMF
        /// </summary>
        [EnumMember(Value = "KMF")]
        KMF = 75,

        /// <summary>
        /// Enum KPW for value: KPW
        /// </summary>
        [EnumMember(Value = "KPW")]
        KPW = 76,

        /// <summary>
        /// Enum KRW for value: KRW
        /// </summary>
        [EnumMember(Value = "KRW")]
        KRW = 77,

        /// <summary>
        /// Enum KWD for value: KWD
        /// </summary>
        [EnumMember(Value = "KWD")]
        KWD = 78,

        /// <summary>
        /// Enum KYD for value: KYD
        /// </summary>
        [EnumMember(Value = "KYD")]
        KYD = 79,

        /// <summary>
        /// Enum KZT for value: KZT
        /// </summary>
        [EnumMember(Value = "KZT")]
        KZT = 80,

        /// <summary>
        /// Enum LAK for value: LAK
        /// </summary>
        [EnumMember(Value = "LAK")]
        LAK = 81,

        /// <summary>
        /// Enum LBP for value: LBP
        /// </summary>
        [EnumMember(Value = "LBP")]
        LBP = 82,

        /// <summary>
        /// Enum LKR for value: LKR
        /// </summary>
        [EnumMember(Value = "LKR")]
        LKR = 83,

        /// <summary>
        /// Enum LRD for value: LRD
        /// </summary>
        [EnumMember(Value = "LRD")]
        LRD = 84,

        /// <summary>
        /// Enum LSL for value: LSL
        /// </summary>
        [EnumMember(Value = "LSL")]
        LSL = 85,

        /// <summary>
        /// Enum LTL for value: LTL
        /// </summary>
        [EnumMember(Value = "LTL")]
        LTL = 86,

        /// <summary>
        /// Enum LVL for value: LVL
        /// </summary>
        [EnumMember(Value = "LVL")]
        LVL = 87,

        /// <summary>
        /// Enum LYD for value: LYD
        /// </summary>
        [EnumMember(Value = "LYD")]
        LYD = 88,

        /// <summary>
        /// Enum MAD for value: MAD
        /// </summary>
        [EnumMember(Value = "MAD")]
        MAD = 89,

        /// <summary>
        /// Enum MDL for value: MDL
        /// </summary>
        [EnumMember(Value = "MDL")]
        MDL = 90,

        /// <summary>
        /// Enum MGA for value: MGA
        /// </summary>
        [EnumMember(Value = "MGA")]
        MGA = 91,

        /// <summary>
        /// Enum MKD for value: MKD
        /// </summary>
        [EnumMember(Value = "MKD")]
        MKD = 92,

        /// <summary>
        /// Enum MMK for value: MMK
        /// </summary>
        [EnumMember(Value = "MMK")]
        MMK = 93,

        /// <summary>
        /// Enum MNT for value: MNT
        /// </summary>
        [EnumMember(Value = "MNT")]
        MNT = 94,

        /// <summary>
        /// Enum MOP for value: MOP
        /// </summary>
        [EnumMember(Value = "MOP")]
        MOP = 95,

        /// <summary>
        /// Enum MRO for value: MRO
        /// </summary>
        [EnumMember(Value = "MRO")]
        MRO = 96,

        /// <summary>
        /// Enum MRU for value: MRU
        /// </summary>
        [EnumMember(Value = "MRU")]
        MRU = 97,

        /// <summary>
        /// Enum MUR for value: MUR
        /// </summary>
        [EnumMember(Value = "MUR")]
        MUR = 98,

        /// <summary>
        /// Enum MVR for value: MVR
        /// </summary>
        [EnumMember(Value = "MVR")]
        MVR = 99,

        /// <summary>
        /// Enum MWK for value: MWK
        /// </summary>
        [EnumMember(Value = "MWK")]
        MWK = 100,

        /// <summary>
        /// Enum MXN for value: MXN
        /// </summary>
        [EnumMember(Value = "MXN")]
        MXN = 101,

        /// <summary>
        /// Enum MXV for value: MXV
        /// </summary>
        [EnumMember(Value = "MXV")]
        MXV = 102,

        /// <summary>
        /// Enum MYR for value: MYR
        /// </summary>
        [EnumMember(Value = "MYR")]
        MYR = 103,

        /// <summary>
        /// Enum MZN for value: MZN
        /// </summary>
        [EnumMember(Value = "MZN")]
        MZN = 104,

        /// <summary>
        /// Enum NAD for value: NAD
        /// </summary>
        [EnumMember(Value = "NAD")]
        NAD = 105,

        /// <summary>
        /// Enum NGN for value: NGN
        /// </summary>
        [EnumMember(Value = "NGN")]
        NGN = 106,

        /// <summary>
        /// Enum NIO for value: NIO
        /// </summary>
        [EnumMember(Value = "NIO")]
        NIO = 107,

        /// <summary>
        /// Enum NOK for value: NOK
        /// </summary>
        [EnumMember(Value = "NOK")]
        NOK = 108,

        /// <summary>
        /// Enum NPR for value: NPR
        /// </summary>
        [EnumMember(Value = "NPR")]
        NPR = 109,

        /// <summary>
        /// Enum NZD for value: NZD
        /// </summary>
        [EnumMember(Value = "NZD")]
        NZD = 110,

        /// <summary>
        /// Enum OMR for value: OMR
        /// </summary>
        [EnumMember(Value = "OMR")]
        OMR = 111,

        /// <summary>
        /// Enum PAB for value: PAB
        /// </summary>
        [EnumMember(Value = "PAB")]
        PAB = 112,

        /// <summary>
        /// Enum PEN for value: PEN
        /// </summary>
        [EnumMember(Value = "PEN")]
        PEN = 113,

        /// <summary>
        /// Enum PGK for value: PGK
        /// </summary>
        [EnumMember(Value = "PGK")]
        PGK = 114,

        /// <summary>
        /// Enum PHP for value: PHP
        /// </summary>
        [EnumMember(Value = "PHP")]
        PHP = 115,

        /// <summary>
        /// Enum PKR for value: PKR
        /// </summary>
        [EnumMember(Value = "PKR")]
        PKR = 116,

        /// <summary>
        /// Enum PLN for value: PLN
        /// </summary>
        [EnumMember(Value = "PLN")]
        PLN = 117,

        /// <summary>
        /// Enum PYG for value: PYG
        /// </summary>
        [EnumMember(Value = "PYG")]
        PYG = 118,

        /// <summary>
        /// Enum QAR for value: QAR
        /// </summary>
        [EnumMember(Value = "QAR")]
        QAR = 119,

        /// <summary>
        /// Enum RON for value: RON
        /// </summary>
        [EnumMember(Value = "RON")]
        RON = 120,

        /// <summary>
        /// Enum RSD for value: RSD
        /// </summary>
        [EnumMember(Value = "RSD")]
        RSD = 121,

        /// <summary>
        /// Enum RUB for value: RUB
        /// </summary>
        [EnumMember(Value = "RUB")]
        RUB = 122,

        /// <summary>
        /// Enum RWF for value: RWF
        /// </summary>
        [EnumMember(Value = "RWF")]
        RWF = 123,

        /// <summary>
        /// Enum SAR for value: SAR
        /// </summary>
        [EnumMember(Value = "SAR")]
        SAR = 124,

        /// <summary>
        /// Enum SBD for value: SBD
        /// </summary>
        [EnumMember(Value = "SBD")]
        SBD = 125,

        /// <summary>
        /// Enum SCR for value: SCR
        /// </summary>
        [EnumMember(Value = "SCR")]
        SCR = 126,

        /// <summary>
        /// Enum SDG for value: SDG
        /// </summary>
        [EnumMember(Value = "SDG")]
        SDG = 127,

        /// <summary>
        /// Enum SEK for value: SEK
        /// </summary>
        [EnumMember(Value = "SEK")]
        SEK = 128,

        /// <summary>
        /// Enum SGD for value: SGD
        /// </summary>
        [EnumMember(Value = "SGD")]
        SGD = 129,

        /// <summary>
        /// Enum SHP for value: SHP
        /// </summary>
        [EnumMember(Value = "SHP")]
        SHP = 130,

        /// <summary>
        /// Enum SKK for value: SKK
        /// </summary>
        [EnumMember(Value = "SKK")]
        SKK = 131,

        /// <summary>
        /// Enum SLE for value: SLE
        /// </summary>
        [EnumMember(Value = "SLE")]
        SLE = 132,

        /// <summary>
        /// Enum SLL for value: SLL
        /// </summary>
        [EnumMember(Value = "SLL")]
        SLL = 133,

        /// <summary>
        /// Enum SOS for value: SOS
        /// </summary>
        [EnumMember(Value = "SOS")]
        SOS = 134,

        /// <summary>
        /// Enum SRD for value: SRD
        /// </summary>
        [EnumMember(Value = "SRD")]
        SRD = 135,

        /// <summary>
        /// Enum STN for value: STD
        /// </summary>
        [EnumMember(Value = "STD")]
        STN = 136,

        /// <summary>
        /// Enum STD for value: STN
        /// </summary>
        [EnumMember(Value = "STN")]
        STD = 137,

        /// <summary>
        /// Enum SVC for value: SVC
        /// </summary>
        [EnumMember(Value = "SVC")]
        SVC = 138,

        /// <summary>
        /// Enum SYP for value: SYP
        /// </summary>
        [EnumMember(Value = "SYP")]
        SYP = 139,

        /// <summary>
        /// Enum SZL for value: SZL
        /// </summary>
        [EnumMember(Value = "SZL")]
        SZL = 140,

        /// <summary>
        /// Enum THB for value: THB
        /// </summary>
        [EnumMember(Value = "THB")]
        THB = 141,

        /// <summary>
        /// Enum TJS for value: TJS
        /// </summary>
        [EnumMember(Value = "TJS")]
        TJS = 142,

        /// <summary>
        /// Enum TMT for value: TMT
        /// </summary>
        [EnumMember(Value = "TMT")]
        TMT = 143,

        /// <summary>
        /// Enum TND for value: TND
        /// </summary>
        [EnumMember(Value = "TND")]
        TND = 144,

        /// <summary>
        /// Enum TOP for value: TOP
        /// </summary>
        [EnumMember(Value = "TOP")]
        TOP = 145,

        /// <summary>
        /// Enum TRY_LIRA for value: TRY
        /// </summary>
        [EnumMember(Value = "TRY")]
        TRY_LIRA = 146,

        /// <summary>
        /// Enum TTD for value: TTD
        /// </summary>
        [EnumMember(Value = "TTD")]
        TTD = 147,

        /// <summary>
        /// Enum TWD for value: TWD
        /// </summary>
        [EnumMember(Value = "TWD")]
        TWD = 148,

        /// <summary>
        /// Enum TZS for value: TZS
        /// </summary>
        [EnumMember(Value = "TZS")]
        TZS = 149,

        /// <summary>
        /// Enum UAH for value: UAH
        /// </summary>
        [EnumMember(Value = "UAH")]
        UAH = 150,

        /// <summary>
        /// Enum UGX for value: UGX
        /// </summary>
        [EnumMember(Value = "UGX")]
        UGX = 151,

        /// <summary>
        /// Enum USD for value: USD
        /// </summary>
        [EnumMember(Value = "USD")]
        USD = 152,

        /// <summary>
        /// Enum UYU for value: UYU
        /// </summary>
        [EnumMember(Value = "UYU")]
        UYU = 153,

        /// <summary>
        /// Enum UZS for value: UZS
        /// </summary>
        [EnumMember(Value = "UZS")]
        UZS = 154,

        /// <summary>
        /// Enum VEF for value: VEF
        /// </summary>
        [EnumMember(Value = "VEF")]
        VEF = 155,

        /// <summary>
        /// Enum VES for value: VES
        /// </summary>
        [EnumMember(Value = "VES")]
        VES = 156,

        /// <summary>
        /// Enum VND for value: VND
        /// </summary>
        [EnumMember(Value = "VND")]
        VND = 157,

        /// <summary>
        /// Enum VUV for value: VUV
        /// </summary>
        [EnumMember(Value = "VUV")]
        VUV = 158,

        /// <summary>
        /// Enum WST for value: WST
        /// </summary>
        [EnumMember(Value = "WST")]
        WST = 159,

        /// <summary>
        /// Enum XAF for value: XAF
        /// </summary>
        [EnumMember(Value = "XAF")]
        XAF = 160,

        /// <summary>
        /// Enum XCD for value: XCD
        /// </summary>
        [EnumMember(Value = "XCD")]
        XCD = 161,

        /// <summary>
        /// Enum XOF for value: XOF
        /// </summary>
        [EnumMember(Value = "XOF")]
        XOF = 162,

        /// <summary>
        /// Enum XPF for value: XPF
        /// </summary>
        [EnumMember(Value = "XPF")]
        XPF = 163,

        /// <summary>
        /// Enum YER for value: YER
        /// </summary>
        [EnumMember(Value = "YER")]
        YER = 164,

        /// <summary>
        /// Enum ZAR for value: ZAR
        /// </summary>
        [EnumMember(Value = "ZAR")]
        ZAR = 165,

        /// <summary>
        /// Enum ZMW for value: ZMW
        /// </summary>
        [EnumMember(Value = "ZMW")]
        ZMW = 166,

        /// <summary>
        /// Enum ZMK for value: ZMK
        /// </summary>
        [EnumMember(Value = "ZMK")]
        ZMK = 167,

        /// <summary>
        /// Enum ZWD for value: ZWD
        /// </summary>
        [EnumMember(Value = "ZWD")]
        ZWD = 168,

        /// <summary>
        /// Enum Empty for value: 
        /// </summary>
        [EnumMember(Value = "")]
        Empty = 169

    }

}
