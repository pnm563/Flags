﻿using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class FlagContextInitializer : CreateDatabaseIfNotExists<FlagContext>
    {
        protected override void Seed(FlagContext context)
        {
            List<Flag> seedFlags = new List<Flag>
            {
                new Flag { ID = Guid.NewGuid(), ImageFile = "AF", Description = "Afghanistan", FlagType = FlagType.CountryFlag },
                new Flag { ID = Guid.NewGuid(), ImageFile = "AL", Description = "Albania" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "DZ", Description = "Algeria" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "AD", Description = "Andorra" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "AO", Description = "Angola" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "AG", Description = "Antigua and Barbuda" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "AR", Description = "Argentina" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "AM", Description = "Armenia" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "AU", Description = "Australia" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "AT", Description = "Austria" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "AZ", Description = "Azerbaijan" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "BS", Description = "Bahamas" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "BH", Description = "Bahrain" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "BD", Description = "Bangladesh" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "BB", Description = "Barbados" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "BY", Description = "Belarus" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "BE", Description = "Belgium" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "BZ", Description = "Belize" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "BJ", Description = "Benin" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "BT", Description = "Bhutan" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "BO", Description = "Bolivia" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "BA", Description = "Bosnia and Herzegovina" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "BW", Description = "Botswana" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "BR", Description = "Brazil" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "BN", Description = "Brunei" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "BG", Description = "Bulgaria" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "BF", Description = "Burkina Faso" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "BI", Description = "Burundi" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "KH", Description = "Cambodia" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "CM", Description = "Cameroon" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "CA", Description = "Canada" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "CV", Description = "Cape Verde" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "CF", Description = "Central African Republic" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "TD", Description = "Chad" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "CL", Description = "Chile" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "CO", Description = "Colombia" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "KM", Description = "Comoros" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "CK", Description = "the Cook Islands" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "CR", Description = "Costa Rica" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "CI", Description = "Cote d'Ivoire" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "HR", Description = "Croatia" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "CU", Description = "Cuba" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "CY", Description = "Cyprus" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "CZ", Description = "Czech Republic" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "CD", Description = "Democratic Republic of the Congo" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "DK", Description = "Denmark" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "DJ", Description = "Djibouti" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "DM", Description = "Dominica" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "DO", Description = "Dominican Republic" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "TL", Description = "East Timor" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "EC", Description = "Ecuador" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "EG", Description = "Egypt" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "SV", Description = "El Salvador" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "GQ", Description = "Equatorial Guinea" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "ER", Description = "Eritrea" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "EE", Description = "Estonia" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "ET", Description = "Ethiopia" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "FJ", Description = "Fiji" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "FI", Description = "Finland" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "FR", Description = "France" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "GA", Description = "Gabon" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "GM", Description = "Gambia" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "GE", Description = "Georgia" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "DE", Description = "Germany" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "GH", Description = "Ghana" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "GR", Description = "Greece" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "GD", Description = "Grenada" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "GT", Description = "Guatemala" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "GN", Description = "Guinea" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "GW", Description = "Guinea-Bissau" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "GY", Description = "Guyana" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "HT", Description = "Haiti" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "HN", Description = "Honduras" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "HU", Description = "Hungary" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "IS", Description = "Iceland" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "IN", Description = "India" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "ID", Description = "Indonesia" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "IR", Description = "Iran" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "IQ", Description = "Iraq" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "IE", Description = "Ireland" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "IL", Description = "Israel" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "IT", Description = "Italy" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "JM", Description = "Jamaica" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "JP", Description = "Japan" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "JO", Description = "Jordan" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "KZ", Description = "Kazakhstan" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "KE", Description = "Kenya" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "KI", Description = "Kiribati" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "KS", Description = "Kosovo" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "KW", Description = "Kuwait" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "KG", Description = "Kyrgyzstan" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "LA", Description = "Laos" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "LV", Description = "Latvia" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "LB", Description = "Lebanon" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "LS", Description = "Lesotho" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "LR", Description = "Liberia" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "LY", Description = "Libya" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "LI", Description = "Liechtenstein" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "LT", Description = "Lithuania" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "LU", Description = "Luxembourg" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "MK", Description = "Macedonia" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "MG", Description = "Madagascar" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "MW", Description = "Malawi" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "MY", Description = "Malaysia" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "MV", Description = "Maldives" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "ML", Description = "Mali" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "MT", Description = "Malta" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "MH", Description = "Marshall Islands" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "MR", Description = "Mauritania" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "MU", Description = "Mauritius" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "MX", Description = "Mexico" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "FM", Description = "Micronesia" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "MD", Description = "Moldova" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "MC", Description = "Monaco" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "MN", Description = "Mongolia" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "ME", Description = "Montenegro" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "MA", Description = "Morocco" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "MZ", Description = "Mozambique" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "MM", Description = "Myanmar" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "NA", Description = "Namibia" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "NR", Description = "Nauru" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "NP", Description = "Nepal" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "NL", Description = "Netherlands" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "NZ", Description = "New Zealand" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "NI", Description = "Nicaragua" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "NE", Description = "Niger" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "NG", Description = "Nigeria" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "NU", Description = "Niue" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "KP", Description = "North Korea" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "NO", Description = "Norway" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "OM", Description = "Oman" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "PK", Description = "Pakistan" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "PW", Description = "Palau" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "PA", Description = "Panama" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "PG", Description = "Papua New Guinea" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "PY", Description = "Paraguay" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "CN", Description = "People's Republic of China" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "PE", Description = "Peru" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "PH", Description = "Philippines" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "PL", Description = "Poland" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "PT", Description = "Portugal" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "QA", Description = "Qatar" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "TW", Description = "Republic of China" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "CG", Description = "Republic of the Congo" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "RO", Description = "Romania" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "RU", Description = "Russia" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "RW", Description = "Rwanda" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "KN", Description = "Saint Kitts and Nevis" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "LC", Description = "Saint Lucia" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "VC", Description = "Saint Vincent and the Grenadines" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "WS", Description = "Samoa" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "SM", Description = "San Marino" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "ST", Description = "Sao Tome and Principe" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "SA", Description = "Saudi Arabia" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "SN", Description = "Senegal" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "RS", Description = "Serbia" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "SC", Description = "Seychelles" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "SL", Description = "Sierra Leone" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "SG", Description = "Singapore" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "SK", Description = "Slovakia" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "SI", Description = "Slovenia" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "SB", Description = "Solomon Islands" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "SO", Description = "Somalia" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "ZA", Description = "South Africa" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "KR", Description = "South Korea" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "SS", Description = "South Sudan" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "ES", Description = "Spain" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "LK", Description = "Sri Lanka" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "SD", Description = "Sudan" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "SR", Description = "Suriname" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "SZ", Description = "Swaziland" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "SE", Description = "Sweden" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "CH", Description = "Switzerland" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "SY", Description = "Syria" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "TJ", Description = "Tajikistan" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "TZ", Description = "Tanzania" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "TH", Description = "Thailand" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "TG", Description = "Togo" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "TO", Description = "Tonga" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "TT", Description = "Trinidad and Tobago" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "TN", Description = "Tunisia" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "TR", Description = "Turkey" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "TM", Description = "Turkmenistan" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "TV", Description = "Tuvalu" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "UG", Description = "Uganda" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "UA", Description = "Ukraine" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "AE", Description = "United Arab Emirates" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "GB", Description = "United Kingdom" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "US", Description = "United States" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "UY", Description = "Uruguay" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "UZ", Description = "Uzbekistan" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "VU", Description = "Vanuatu" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "VA", Description = "Vatican City" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "VE", Description = "Venezuela" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "VN", Description = "Vietnam" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "EH", Description = "Western Sahara" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "YE", Description = "Yemen" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "ZM", Description = "Zambia" },
                new Flag { ID = Guid.NewGuid(), ImageFile = "ZW", Description = "Zimbabwe" }

            };

            //seedFlags.Sort((x, y) => x.Description.CompareTo(y.Description)); //Not needed because SaveChanges() inserts in a random order
            seedFlags.ForEach(v => context.Flag.Add(v));
            context.SaveChanges();

        }
    }
}
