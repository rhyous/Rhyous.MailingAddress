﻿using System;
using System.Collections.Generic;

namespace Rhyous.MailingAddress.Dictionaries
{
    public class StateDictionary : Dictionary<string, string>
    {
        // Todo: Get this from a DB or elsewhere outside of code.
        public StateDictionary() : base(StringComparer.OrdinalIgnoreCase)
        {
            // https://en.wikipedia.org/wiki/List_of_U.S._state_abbreviations
            Add("Alaska", "AK");
            Add("US-AK", "AK");
            Add("Alabama", "AL");
            Add("US-AL", "AL");
            Add("Arkansas", "AR");
            Add("US-AR", "AR");
            Add("American Samoa", "AS");
            Add("AS", "AS");
            Add("ASM", "AS");
            Add("US-AS", "AS");
            Add("Arizona", "AZ");
            Add("US-AZ", "AZ");
            Add("California", "CA");
            Add("US-CA", "CA");
            Add("Colorado", "CO");
            Add("US-CO", "CO");
            Add("Connecticut", "CT");
            Add("US-CT", "CT");
            Add("District of Columbia", "DC");
            Add("US-DC", "DC");
            Add("Delaware", "DE");
            Add("US-DE", "DE");
            Add("Florida", "FL");
            Add("US-FL", "FL");
            Add("FM", "FM");
            Add("FSM", "FM");
            Add("Micronesia", "FM");
            Add("Georgia", "GA");
            Add("US-GA", "GA");
            Add("GU", "GU");
            Add("Guam", "GU");
            Add("GUM", "GU");
            Add("US-GU", "GU");
            Add("Hawaii", "HI");
            Add("US-HI", "HI");
            Add("Iowa", "IA");
            Add("US-IA", "IA");
            Add("Idaho", "ID");
            Add("US-ID", "ID");
            Add("Illinois", "IL");
            Add("US-IL", "IL");
            Add("Indiana", "IN");
            Add("US-IN", "IN");
            Add("Kansas", "KS");
            Add("US-KS", "KS");
            Add("Kentucky", "KY");
            Add("US-KY", "KY");
            Add("Louisiana", "LA");
            Add("US-LA", "LA");
            Add("Massachusetts", "MA");
            Add("US-MA", "MA");
            Add("Maryland", "MD");
            Add("US-MD", "MD");
            Add("Maine", "ME");
            Add("US-ME", "ME");
            Add("Marshall Islands", "MH");
            Add("MH", "MH");
            Add("MHL", "MH");
            Add("Michigan", "MI");
            Add("US-MI", "MI");
            Add("Minnesota", "MN");
            Add("US-MN", "MN");
            Add("Missouri", "MO");
            Add("US-MO", "MO");
            Add("MNP", "MP");
            Add("MP", "MP");
            Add("Northern Mariana Islands", "MP");
            Add("US-MP", "MP");
            Add("Mississippi", "MS");
            Add("US-MS", "MS");
            Add("Montana", "MT");
            Add("US-MT", "MT");
            Add("North Carolina", "NC");
            Add("US-NC", "NC");
            Add("North Dakota", "ND");
            Add("US-ND", "ND");
            Add("Nebraska", "NE");
            Add("US-NE", "NE");
            Add("New Hampshire", "NH");
            Add("US-NH", "NH");
            Add("New Jersey", "NJ");
            Add("US-NJ", "NJ");
            Add("New Mexico", "NM");
            Add("US-NM", "NM");
            Add("Nevada", "NV");
            Add("US-NV", "NV");
            Add("New York", "NY");
            Add("US-NY", "NY");
            Add("Ohio", "OH");
            Add("US-OH", "OH");
            Add("Oklahoma", "OK");
            Add("US-OK", "OK");
            Add("Oregon", "OR");
            Add("US-OR", "OR");
            Add("Pennsylvania", "PA");
            Add("US-PA", "PA");
            Add("PR", "PR");
            Add("PRI", "PR");
            Add("Puerto Rico", "PR");
            Add("US-PR", "PR");
            Add("Palau", "PW");
            Add("PLW", "PW");
            Add("PW", "PW");
            Add("Rhode Island", "RI");
            Add("US-RI", "RI");
            Add("South Carolina", "SC");
            Add("US-SC", "SC");
            Add("South Dakota", "SD");
            Add("US-SD", "SD");
            Add("Tennessee", "TN");
            Add("US-TN", "TN");
            Add("Texas", "TX");
            Add("US-TX", "TX");
            Add("U.S. Minor Outlying Islands", "UM");
            Add("UM", "UM");
            Add("UMI", "UM");
            Add("US-UM", "UM");
            Add("US-UT", "UT");
            Add("Uta", "UT");
            Add("Utah", "UT");
            Add("US-VA", "VA");
            Add("Virginia", "VA");
            Add("U.S. Virgin Islands", "VI");
            Add("US-VI", "VI");
            Add("VI", "VI");
            Add("VIR", "VI");
            Add("US-VT", "VT");
            Add("Vermont", "VT");
            Add("US-WA", "WA");
            Add("Washington", "WA");
            Add("US-WI", "WI");
            Add("Wisconsin", "WI");
            Add("US-WV", "WV");
            Add("West Virginia", "WV");
            Add("US-WY", "WY");
            Add("Wyoming", "WY");
        }
    }
}
