﻿using System;
using System.Collections.Generic;

namespace Rhyous.MailingAddress.Dictionaries
{
    public class CountryDictionary : Dictionary<string, string>
    {
        // Todo: Get this from a DB or elsewhere outside of code.
        public CountryDictionary() : base(StringComparer.OrdinalIgnoreCase)
        {
            Add("Aruba", "ABW");
            Add("AW", "ABW");
            Add("AF", "AFG");
            Add("Afghanistan", "AFG");
            Add("Angola", "AGO");
            Add("AO", "AGO");
            Add("AI", "AIA");
            Add("Anguilla", "AIA");
            Add("Åland Islands", "ALA");
            Add("AX", "ALA");
            Add("AL", "ALB");
            Add("Albania", "ALB");
            Add("AD", "AND");
            Add("Andorra", "AND");
            Add("AE", "ARE");
            Add("United Arab Emirates", "ARE");
            Add("AR", "ARG");
            Add("Argentina", "ARG");
            Add("AM", "ARM");
            Add("Armenia", "ARM");
            Add("American Samoa", "ASM");
            Add("AS", "ASM");
            Add("Antarctica", "ATA");
            Add("AQ", "ATA");
            Add("French Southern Territories", "ATF");
            Add("TF", "ATF");
            Add("AG", "ATG");
            Add("Antigua and Barbuda", "ATG");
            Add("AU", "AUS");
            Add("Australia", "AUS");
            Add("AT", "AUT");
            Add("Austria", "AUT");
            Add("AZ", "AZE");
            Add("Azerbaijan", "AZE");
            Add("BI", "BDI");
            Add("Burundi", "BDI");
            Add("BE", "BEL");
            Add("Belgium", "BEL");
            Add("Benin", "BEN");
            Add("BJ", "BEN");
            Add("Bonaire, Sint Eustatius and Saba", "BES");
            Add("BQ", "BES");
            Add("BF", "BFA");
            Add("Burkina Faso", "BFA");
            Add("Bangladesh", "BGD");
            Add("BD", "BGD");
            Add("BG", "BGR");
            Add("Bulgaria", "BGR");
            Add("Bahrain", "BHR");
            Add("BH", "BHR");
            Add("Bahamas", "BHS");
            Add("BS", "BHS");
            Add("BA", "BIH");
            Add("Bosnia and Herzegovina", "BIH");
            Add("BL", "BLM");
            Add("Saint Barthélemy", "BLM");
            Add("Belarus", "BLR");
            Add("BY", "BLR");
            Add("Belize", "BLZ");
            Add("BZ", "BLZ");
            Add("Bermuda", "BMU");
            Add("BM", "BMU");
            Add("BO", "BOL");
            Add("Bolivia (Plurinational State of)", "BOL");
            Add("BR", "BRA");
            Add("Brazil", "BRA");
            Add("Barbados", "BRB");
            Add("BB", "BRB");
            Add("BN", "BRN");
            Add("Brunei Darussalam", "BRN");
            Add("Bhutan", "BTN");
            Add("BT", "BTN");
            Add("Bouvet Island", "BVT");
            Add("BV", "BVT");
            Add("Botswana", "BWA");
            Add("BW", "BWA");
            Add("Central African Republic", "CAF");
            Add("CF", "CAF");
            Add("CA", "CAN");
            Add("Canada", "CAN");
            Add("CC", "CCK");
            Add("Cocos (Keeling) Islands", "CCK");
            Add("CH", "CHE");
            Add("Switzerland", "CHE");
            Add("Chile", "CHL");
            Add("CL", "CHL");
            Add("China", "CHN");
            Add("CN", "CHN");
            Add("Côte d'Ivoire", "CIV");
            Add("CI", "CIV");
            Add("Cameroon", "CMR");
            Add("CM", "CMR");
            Add("CD", "COD");
            Add("Congo (Democratic Republic of the)", "COD");
            Add("CG", "COG");
            Add("Congo", "COG");
            Add("CK", "COK");
            Add("Cook Islands", "COK");
            Add("CO", "COL");
            Add("Colombia", "COL");
            Add("Comoros", "COM");
            Add("KM", "COM");
            Add("Cabo Verde", "CPV");
            Add("CV", "CPV");
            Add("Costa Rica", "CRI");
            Add("CR", "CRI");
            Add("CU", "CUB");
            Add("Cuba", "CUB");
            Add("Curaçao", "CUW");
            Add("CW", "CUW");
            Add("Christmas Island", "CXR");
            Add("CX", "CXR");
            Add("Cayman Islands", "CYM");
            Add("KY", "CYM");
            Add("CY", "CYP");
            Add("Cyprus", "CYP");
            Add("CZ", "CZE");
            Add("Czechia", "CZE");
            Add("DE", "DEU");
            Add("Germany", "DEU");
            Add("DJ", "DJI");
            Add("Djibouti", "DJI");
            Add("DM", "DMA");
            Add("Dominica", "DMA");
            Add("Denmark", "DNK");
            Add("DK", "DNK");
            Add("DO", "DOM");
            Add("Dominican Republic", "DOM");
            Add("Algeria", "DZA");
            Add("DZ", "DZA");
            Add("EC", "ECU");
            Add("Ecuador", "ECU");
            Add("EG", "EGY");
            Add("Egypt", "EGY");
            Add("ER", "ERI");
            Add("Eritrea", "ERI");
            Add("EH", "ESH");
            Add("Western Sahara", "ESH");
            Add("ES", "ESP");
            Add("Spain", "ESP");
            Add("EE", "EST");
            Add("Estonia", "EST");
            Add("ET", "ETH");
            Add("Ethiopia", "ETH");
            Add("FI", "FIN");
            Add("Finland", "FIN");
            Add("Fiji", "FJI");
            Add("FJ", "FJI");
            Add("Falkland Islands (Malvinas)", "FLK");
            Add("FK", "FLK");
            Add("FR", "FRA");
            Add("France", "FRA");
            Add("Faroe Islands", "FRO");
            Add("FO", "FRO");
            Add("FM", "FSM");
            Add("Micronesia (Federated States of)", "FSM");
            Add("GA", "GAB");
            Add("Gabon", "GAB");
            Add("GB", "GBR");
            Add("United Kingdom of Great Britain and Northern Ireland", "GBR");
            Add("GE", "GEO");
            Add("Georgia", "GEO");
            Add("GG", "GGY");
            Add("Guernsey", "GGY");
            Add("GH", "GHA");
            Add("Ghana", "GHA");
            Add("GI", "GIB");
            Add("Gibraltar", "GIB");
            Add("GN", "GIN");
            Add("Guinea", "GIN");
            Add("GP", "GLP");
            Add("Guadeloupe", "GLP");
            Add("Gambia", "GMB");
            Add("GM", "GMB");
            Add("Guinea-Bissau", "GNB");
            Add("GW", "GNB");
            Add("Equatorial Guinea", "GNQ");
            Add("GQ", "GNQ");
            Add("GR", "GRC");
            Add("Greece", "GRC");
            Add("GD", "GRD");
            Add("Grenada", "GRD");
            Add("GL", "GRL");
            Add("Greenland", "GRL");
            Add("GT", "GTM");
            Add("Guatemala", "GTM");
            Add("French Guiana", "GUF");
            Add("GF", "GUF");
            Add("GU", "GUM");
            Add("Guam", "GUM");
            Add("Guyana", "GUY");
            Add("GY", "GUY");
            Add("HK", "HKG");
            Add("Hong Kong", "HKG");
            Add("Heard Island and McDonald Islands", "HMD");
            Add("HM", "HMD");
            Add("HN", "HND");
            Add("Honduras", "HND");
            Add("Croatia", "HRV");
            Add("HR", "HRV");
            Add("Haiti", "HTI");
            Add("HT", "HTI");
            Add("HU", "HUN");
            Add("Hungary", "HUN");
            Add("ID", "IDN");
            Add("Indonesia", "IDN");
            Add("IM", "IMN");
            Add("Isle of Man", "IMN");
            Add("IN", "IND");
            Add("India", "IND");
            Add("British Indian Ocean Territory", "IOT");
            Add("IO", "IOT");
            Add("IE", "IRL");
            Add("Ireland", "IRL");
            Add("IR", "IRN");
            Add("Iran (Islamic Republic of)", "IRN");
            Add("IQ", "IRQ");
            Add("Iraq", "IRQ");
            Add("Iceland", "ISL");
            Add("IS", "ISL");
            Add("IL", "ISR");
            Add("Israel", "ISR");
            Add("IT", "ITA");
            Add("Italy", "ITA");
            Add("Jamaica", "JAM");
            Add("JM", "JAM");
            Add("JE", "JEY");
            Add("Jersey", "JEY");
            Add("JO", "JOR");
            Add("Jordan", "JOR");
            Add("Japan", "JPN");
            Add("JP", "JPN");
            Add("Kazakhstan", "KAZ");
            Add("KZ", "KAZ");
            Add("KE", "KEN");
            Add("Kenya", "KEN");
            Add("KG", "KGZ");
            Add("Kyrgyzstan", "KGZ");
            Add("Cambodia", "KHM");
            Add("KH", "KHM");
            Add("KI", "KIR");
            Add("Kiribati", "KIR");
            Add("KN", "KNA");
            Add("Saint Kitts and Nevis", "KNA");
            Add("Korea (Republic of)", "KOR");
            Add("KR", "KOR");
            Add("Kuwait", "KWT");
            Add("KW", "KWT");
            Add("LA", "LAO");
            Add("Lao People's Democratic Republic", "LAO");
            Add("LB", "LBN");
            Add("Lebanon", "LBN");
            Add("Liberia", "LBR");
            Add("LR", "LBR");
            Add("Libya", "LBY");
            Add("LY", "LBY");
            Add("LC", "LCA");
            Add("Saint Lucia", "LCA");
            Add("LI", "LIE");
            Add("Liechtenstein", "LIE");
            Add("LK", "LKA");
            Add("Sri Lanka", "LKA");
            Add("Lesotho", "LSO");
            Add("LS", "LSO");
            Add("Lithuania", "LTU");
            Add("LT", "LTU");
            Add("LU", "LUX");
            Add("Luxembourg", "LUX");
            Add("Latvia", "LVA");
            Add("LV", "LVA");
            Add("Macao", "MAC");
            Add("MO", "MAC");
            Add("MF", "MAF");
            Add("Saint Martin (French part)", "MAF");
            Add("MA", "MAR");
            Add("Morocco", "MAR");
            Add("MC", "MCO");
            Add("Monaco", "MCO");
            Add("MD", "MDA");
            Add("Moldova (Republic of)", "MDA");
            Add("Madagascar", "MDG");
            Add("MG", "MDG");
            Add("Maldives", "MDV");
            Add("MV", "MDV");
            Add("Mexico", "MEX");
            Add("MX", "MEX");
            Add("Marshall Islands", "MHL");
            Add("MH", "MHL");
            Add("Macedonia (the former Yugoslav Republic of)", "MKD");
            Add("MK", "MKD");
            Add("Mali", "MLI");
            Add("ML", "MLI");
            Add("Malta", "MLT");
            Add("MT", "MLT");
            Add("MM", "MMR");
            Add("Myanmar", "MMR");
            Add("ME", "MNE");
            Add("Montenegro", "MNE");
            Add("MN", "MNG");
            Add("Mongolia", "MNG");
            Add("MP", "MNP");
            Add("Northern Mariana Islands", "MNP");
            Add("Mozambique", "MOZ");
            Add("MZ", "MOZ");
            Add("Mauritania", "MRT");
            Add("MR", "MRT");
            Add("Montserrat", "MSR");
            Add("MS", "MSR");
            Add("Martinique", "MTQ");
            Add("MQ", "MTQ");
            Add("Mauritius", "MUS");
            Add("MU", "MUS");
            Add("Malawi", "MWI");
            Add("MW", "MWI");
            Add("Malaysia", "MYS");
            Add("MY", "MYS");
            Add("Mayotte", "MYT");
            Add("YT", "MYT");
            Add("NA", "NAM");
            Add("Namibia", "NAM");
            Add("NC", "NCL");
            Add("New Caledonia", "NCL");
            Add("NE", "NER");
            Add("Niger", "NER");
            Add("NF", "NFK");
            Add("Norfolk Island", "NFK");
            Add("NG", "NGA");
            Add("Nigeria", "NGA");
            Add("NI", "NIC");
            Add("Nicaragua", "NIC");
            Add("Niue", "NIU");
            Add("NU", "NIU");
            Add("Netherlands", "NLD");
            Add("NL", "NLD");
            Add("NO", "NOR");
            Add("Norway", "NOR");
            Add("Nepal", "NPL");
            Add("NP", "NPL");
            Add("Nauru", "NRU");
            Add("NR", "NRU");
            Add("New Zealand", "NZL");
            Add("NZ", "NZL");
            Add("OM", "OMN");
            Add("Oman", "OMN");
            Add("Pakistan", "PAK");
            Add("PK", "PAK");
            Add("PA", "PAN");
            Add("Panama", "PAN");
            Add("Pitcairn", "PCN");
            Add("PN", "PCN");
            Add("PE", "PER");
            Add("Peru", "PER");
            Add("PH", "PHL");
            Add("Philippines", "PHL");
            Add("Palau", "PLW");
            Add("PW", "PLW");
            Add("Papua New Guinea", "PNG");
            Add("PG", "PNG");
            Add("PL", "POL");
            Add("Poland", "POL");
            Add("PR", "PRI");
            Add("Puerto Rico", "PRI");
            Add("Korea (Democratic People's Republic of)", "PRK");
            Add("KP", "PRK");
            Add("Portugal", "PRT");
            Add("PT", "PRT");
            Add("Paraguay", "PRY");
            Add("PY", "PRY");
            Add("Palestine, State of", "PSE");
            Add("PS", "PSE");
            Add("French Polynesia", "PYF");
            Add("PF", "PYF");
            Add("QA", "QAT");
            Add("Qatar", "QAT");
            Add("Réunion", "REU");
            Add("RE", "REU");
            Add("RO", "ROU");
            Add("Romania", "ROU");
            Add("RU", "RUS");
            Add("Russian Federation", "RUS");
            Add("RW", "RWA");
            Add("Rwanda", "RWA");
            Add("SA", "SAU");
            Add("Saudi Arabia", "SAU");
            Add("SD", "SDN");
            Add("Sudan", "SDN");
            Add("Senegal", "SEN");
            Add("SN", "SEN");
            Add("SG", "SGP");
            Add("Singapore", "SGP");
            Add("GS", "SGS");
            Add("South Georgia and the South Sandwich Islands", "SGS");
            Add("Saint Helena, Ascension and Tristan da Cunha", "SHN");
            Add("SH", "SHN");
            Add("SJ", "SJM");
            Add("Svalbard and Jan Mayen", "SJM");
            Add("SB", "SLB");
            Add("Solomon Islands", "SLB");
            Add("Sierra Leone", "SLE");
            Add("SL", "SLE");
            Add("El Salvador", "SLV");
            Add("SV", "SLV");
            Add("San Marino", "SMR");
            Add("SM", "SMR");
            Add("SO", "SOM");
            Add("Somalia", "SOM");
            Add("PM", "SPM");
            Add("Saint Pierre and Miquelon", "SPM");
            Add("RS", "SRB");
            Add("Serbia", "SRB");
            Add("South Sudan", "SSD");
            Add("SS", "SSD");
            Add("Sao Tome and Principe", "STP");
            Add("ST", "STP");
            Add("SR", "SUR");
            Add("Suriname", "SUR");
            Add("SK", "SVK");
            Add("Slovakia", "SVK");
            Add("SI", "SVN");
            Add("Slovenia", "SVN");
            Add("SE", "SWE");
            Add("Sweden", "SWE");
            Add("Swaziland", "SWZ");
            Add("SZ", "SWZ");
            Add("Sint Maarten (Dutch part)", "SXM");
            Add("SX", "SXM");
            Add("SC", "SYC");
            Add("Seychelles", "SYC");
            Add("SY", "SYR");
            Add("Syrian Arab Republic", "SYR");
            Add("TC", "TCA");
            Add("Turks and Caicos Islands", "TCA");
            Add("Chad", "TCD");
            Add("TD", "TCD");
            Add("TG", "TGO");
            Add("Togo", "TGO");
            Add("TH", "THA");
            Add("Thailand", "THA");
            Add("Tajikistan", "TJK");
            Add("TJ", "TJK");
            Add("TK", "TKL");
            Add("Tokelau", "TKL");
            Add("TM", "TKM");
            Add("Turkmenistan", "TKM");
            Add("Timor-Leste", "TLS");
            Add("TL", "TLS");
            Add("TO", "TON");
            Add("Tonga", "TON");
            Add("Trinidad and Tobago", "TTO");
            Add("TT", "TTO");
            Add("TN", "TUN");
            Add("Tunisia", "TUN");
            Add("TR", "TUR");
            Add("Turkey", "TUR");
            Add("Tuvalu", "TUV");
            Add("TV", "TUV");
            Add("Taiwan, Province of China", "TWN");
            Add("TW", "TWN");
            Add("Tanzania, United Republic of", "TZA");
            Add("TZ", "TZA");
            Add("UG", "UGA");
            Add("Uganda", "UGA");
            Add("UA", "UKR");
            Add("Ukraine", "UKR");
            Add("UM", "UMI");
            Add("United States Minor Outlying Islands", "UMI");
            Add("Uruguay", "URY");
            Add("UY", "URY");
            Add("United States of America", "USA");
            Add("United States", "USA");
            Add("US", "USA");
            Add("U.S.A.", "USA");
            Add("U.S", "USA");
            Add("UZ", "UZB");
            Add("Uzbekistan", "UZB");
            Add("Holy See", "VAT");
            Add("VA", "VAT");
            Add("Saint Vincent and the Grenadines", "VCT");
            Add("VC", "VCT");
            Add("VE", "VEN");
            Add("Venezuela (Bolivarian Republic of)", "VEN");
            Add("VG", "VGB");
            Add("Virgin Islands (British)", "VGB");
            Add("VI", "VIR");
            Add("Virgin Islands (U.S.)", "VIR");
            Add("Viet Nam", "VNM");
            Add("VN", "VNM");
            Add("Vanuatu", "VUT");
            Add("VU", "VUT");
            Add("Wallis and Futuna", "WLF");
            Add("WF", "WLF");
            Add("Samoa", "WSM");
            Add("WS", "WSM");
            Add("YE", "YEM");
            Add("Yemen", "YEM");
            Add("South Africa", "ZAF");
            Add("ZA", "ZAF");
            Add("Zambia", "ZMB");
            Add("ZM", "ZMB");
        }
    }
}
