using System;
using System.Collections.Generic;
using System.Linq;
using NzbDrone.Core.Languages;
using NzbDrone.Core.Organizer;

namespace NzbDrone.Core.Parser
{
    public static class IsoLanguages
    {
        private static readonly HashSet<IsoLanguage> All = new HashSet<IsoLanguage>
                                                           {
                                                               new IsoLanguage("en", "", "eng", "English", Language.English),
                                                               new IsoLanguage("fr", "fr", "fra", "French", Language.French),
                                                               new IsoLanguage("es", "", "spa", "Spanish", Language.Spanish),
                                                               new IsoLanguage("de", "de", "deu", "German", Language.German),
                                                               new IsoLanguage("it", "", "ita", "Italian", Language.Italian),
                                                               new IsoLanguage("da", "", "dan", "Danish", Language.Danish),
                                                               new IsoLanguage("nl", "", "nld", "Dutch", Language.Dutch),
                                                               new IsoLanguage("ja", "", "jpn", "Japanese", Language.Japanese),
                                                               new IsoLanguage("is", "", "isl", "Icelandic", Language.Icelandic),
                                                               new IsoLanguage("zh", "cn", "zho", "Chinese", Language.Chinese),
                                                               new IsoLanguage("ru", "", "rus", "Russian", Language.Russian),
                                                               new IsoLanguage("pl", "", "pol", "Polish", Language.Polish),
                                                               new IsoLanguage("vi", "", "vie", "Vietnamese", Language.Vietnamese),
                                                               new IsoLanguage("sv", "", "swe", "Swedish", Language.Swedish),
                                                               new IsoLanguage("no", "", "nor", "Norwegian", Language.Norwegian),
                                                               new IsoLanguage("nb", "", "nob", "Norwegian Bokmal", Language.Norwegian),
                                                               new IsoLanguage("fi", "", "fin", "Finnish", Language.Finnish),
                                                               new IsoLanguage("tr", "", "tur", "Turkish", Language.Turkish),
                                                               new IsoLanguage("pt", "pt", "por", "Portuguese", Language.Portuguese),
                                                               new IsoLanguage("el", "", "ell", "Greek", Language.Greek),
                                                               new IsoLanguage("ko", "", "kor", "Korean", Language.Korean),
                                                               new IsoLanguage("hu", "", "hun", "Hungarian", Language.Hungarian),
                                                               new IsoLanguage("he", "", "heb", "Hebrew", Language.Hebrew),
                                                               new IsoLanguage("cs", "", "ces", "Czech", Language.Czech),
                                                               new IsoLanguage("hi", "", "hin", "Hindi", Language.Hindi),
                                                               new IsoLanguage("th", "", "tha", "Thai", Language.Thai),
                                                               new IsoLanguage("bg", "", "bul", "Bulgarian", Language.Bulgarian),
                                                               new IsoLanguage("ro", "", "ron", "Romanian", Language.Romanian),
                                                               new IsoLanguage("pt", "br", "", "Portuguese (Brazil)", Language.PortugueseBR),
                                                               new IsoLanguage("ar", "", "ara", "Arabic", Language.Arabic),
                                                               new IsoLanguage("uk", "", "ukr", "Ukrainian", Language.Ukrainian),
                                                               new IsoLanguage("fa", "", "fas", "Persian", Language.Persian),
                                                               new IsoLanguage("bn", "", "ben", "Bengali", Language.Bengali),
                                                               new IsoLanguage("lt", "", "lit", "Lithuanian", Language.Lithuanian),
                                                               new IsoLanguage("sk", "", "slk", "Slovak", Language.Slovak),
                                                               new IsoLanguage("lv", "", "lav", "Latvian", Language.Latvian),
                                                               new IsoLanguage("es", "mx", "spa", "Spanish (Latino)", Language.SpanishLatino),
                                                               new IsoLanguage("ca", "", "cat", "Catalan", Language.Catalan),
                                                               new IsoLanguage("hr", "", "hrv", "Croatian", Language.Croatian),
                                                               new IsoLanguage("sr", "", "srp", "Serbian", Language.Serbian),
                                                               new IsoLanguage("bs", "", "bos", "Bosnian", Language.Bosnian),
                                                               new IsoLanguage("et", "", "est", "Estonian", Language.Estonian),
                                                               new IsoLanguage("ta", "", "tam", "Tamil", Language.Tamil),
                                                               new IsoLanguage("id", "", "ind", "Indonesian", Language.Indonesian),
                                                               new IsoLanguage("te", "", "tel", "Telugu", Language.Telugu),
                                                               new IsoLanguage("mk", "", "mkd", "Macedonian", Language.Macedonian),
                                                               new IsoLanguage("sl", "", "slv", "Slovenian", Language.Slovenian),
                                                               new IsoLanguage("ml", "", "mal", "Malayalam", Language.Malayalam),
                                                               new IsoLanguage("kn", "", "kan", "Kannada", Language.Kannada),
                                                               new IsoLanguage("sq", "", "sqi", "Albanian", Language.Albanian),
                                                               new IsoLanguage("af", "", "afr", "Afrikaans", Language.Afrikaans),
                                                               new IsoLanguage("mr", "", "mar", "Marathi", Language.Marathi),
                                                               new IsoLanguage("tl", "", "tgl", "Tagalog", Language.Tagalog),
                                                               new IsoLanguage("ur", "", "urd", "Urdu", Language.Urdu),
                                                               new IsoLanguage("rm", "", "roh", "Romansh", Language.Romansh),
                                                               new IsoLanguage("mn", "", "mon", "Mongolian", Language.Mongolian),
                                                               new IsoLanguage("ka", "", "kat", "Georgian", Language.Georgian),
                                                               new IsoLanguage("ab", "", "abk", "Abkhazian", Language.Abkhazian),
                                                               new IsoLanguage("aa", "", "aar", "Afar", Language.Afar),
                                                               new IsoLanguage("ak", "", "aka", "Akan", Language.Akan),
                                                               new IsoLanguage("am", "", "amh", "Amharic", Language.Amharic),
                                                               new IsoLanguage("an", "", "arg", "Aragonese", Language.Aragonese),
                                                               new IsoLanguage("hy", "", "hye", "Armenian", Language.Armenian),
                                                               new IsoLanguage("as", "", "asm", "Assamese", Language.Assamese),
                                                               new IsoLanguage("av", "", "ava", "Avaric", Language.Avaric),
                                                               new IsoLanguage("ae", "", "ave", "Avestan", Language.Avestan),
                                                               new IsoLanguage("ay", "", "aym", "Aymara", Language.Aymara),
                                                               new IsoLanguage("az", "", "aze", "Azerbaijani", Language.Azerbaijani),
                                                               new IsoLanguage("bm", "", "bam", "Bambara", Language.Bambara),
                                                               new IsoLanguage("ba", "", "bak", "Bashkir", Language.Bashkir),
                                                               new IsoLanguage("eu", "", "eus", "Basque", Language.Basque),
                                                               new IsoLanguage("be", "", "bel", "Belarusian", Language.Belarusian),
                                                               new IsoLanguage("bi", "", "bis", "Bislama", Language.Bislama),
                                                               new IsoLanguage("br", "", "bre", "Breton", Language.Breton),
                                                               new IsoLanguage("my", "", "mya", "Burmese", Language.Burmese),
                                                               new IsoLanguage("ch", "", "cha", "Chamorro", Language.Chamorro),
                                                               new IsoLanguage("ce", "", "che", "Chechen", Language.Chechen),
                                                               new IsoLanguage("ny", "", "nya", "Chichewa", Language.Chichewa),
                                                               new IsoLanguage("cu", "", "chu", "Church Slavic", Language.ChurchSlavic),
                                                               new IsoLanguage("cv", "", "chv", "Chuvash", Language.Chuvash),
                                                               new IsoLanguage("kw", "", "cor", "Cornish", Language.Cornish),
                                                               new IsoLanguage("co", "", "cos", "Corsican", Language.Corsican),
                                                               new IsoLanguage("cr", "", "cre", "Cree", Language.Cree),
                                                               new IsoLanguage("dv", "", "div", "Divehi", Language.Divehi),
                                                               new IsoLanguage("dz", "", "dzo", "Dzongkha", Language.Dzongkha),
                                                               new IsoLanguage("eo", "", "epo", "Esperanto", Language.Esperanto),
                                                               new IsoLanguage("ee", "", "ewe", "Ewe", Language.Ewe),
                                                               new IsoLanguage("fo", "", "fao", "Faroese", Language.Faroese),
                                                               new IsoLanguage("fj", "", "fij", "Fijian", Language.Fijian),
                                                               new IsoLanguage("fy", "", "fry", "Frisian", Language.Frisian),
                                                               new IsoLanguage("ff", "", "ful", "Fulah", Language.Fulah),
                                                               new IsoLanguage("gl", "", "glg", "Galician", Language.Galician),
                                                               new IsoLanguage("lg", "", "lug", "Ganda", Language.Ganda),
                                                               new IsoLanguage("gn", "", "grn", "Guarani", Language.Guarani),
                                                               new IsoLanguage("gu", "", "guj", "Gujarati", Language.Gujarati),
                                                               new IsoLanguage("ht", "", "hat", "Haitian Creole", Language.HaitianCreole),
                                                               new IsoLanguage("ha", "", "hau", "Hausa", Language.Hausa),
                                                               new IsoLanguage("hz", "", "her", "Herero", Language.Herero),
                                                               new IsoLanguage("ho", "", "hmo", "Hiri Motu", Language.HiriMotu),
                                                               new IsoLanguage("io", "", "ido", "Ido", Language.Ido),
                                                               new IsoLanguage("ig", "", "ibo", "Igbo", Language.Igbo),
                                                               new IsoLanguage("ia", "", "ina", "Interlingua", Language.Interlingua),
                                                               new IsoLanguage("ie", "", "ile", "Interlingue", Language.Interlingue),
                                                               new IsoLanguage("iu", "", "iku", "Inuktitut", Language.Inuktitut),
                                                               new IsoLanguage("ik", "", "ipk", "Inupiaq", Language.Inupiaq),
                                                               new IsoLanguage("ga", "", "gle", "Irish", Language.Irish),
                                                               new IsoLanguage("jv", "", "jav", "Javanese", Language.Javanese),
                                                               new IsoLanguage("kl", "", "kal", "Kalaallisut", Language.Kalaallisut),
                                                               new IsoLanguage("kr", "", "kau", "Kanuri", Language.Kanuri),
                                                               new IsoLanguage("ks", "", "kas", "Kashmiri", Language.Kashmiri),
                                                               new IsoLanguage("kk", "", "kaz", "Kazakh", Language.Kazakh),
                                                               new IsoLanguage("km", "", "khm", "Khmer", Language.Khmer),
                                                               new IsoLanguage("ki", "", "kik", "Kikuyu", Language.Kikuyu),
                                                               new IsoLanguage("rw", "", "kin", "Kinyarwanda", Language.Kinyarwanda),
                                                               new IsoLanguage("kv", "", "kom", "Komi", Language.Komi),
                                                               new IsoLanguage("kg", "", "kon", "Kongo", Language.Kongo),
                                                               new IsoLanguage("kj", "", "kua", "Kuanyama", Language.Kuanyama),
                                                               new IsoLanguage("ku", "", "kur", "Kurdish", Language.Kurdish),
                                                               new IsoLanguage("ky", "", "kir", "Kyrgyz", Language.Kyrgyz),
                                                               new IsoLanguage("lo", "", "lao", "Lao", Language.Lao),
                                                               new IsoLanguage("la", "", "lat", "Latin", Language.Latin),
                                                               new IsoLanguage("li", "", "lim", "Limburgish", Language.Limburgish),
                                                               new IsoLanguage("ln", "", "lin", "Lingala", Language.Lingala),
                                                               new IsoLanguage("lu", "", "lub", "Luba-Katanga", Language.LubaKatanga),
                                                               new IsoLanguage("lb", "", "ltz", "Luxembourgish", Language.Luxembourgish),
                                                               new IsoLanguage("mg", "", "mlg", "Malagasy", Language.Malagasy),
                                                               new IsoLanguage("ms", "", "msa", "Malay", Language.Malay),
                                                               new IsoLanguage("mt", "", "mlt", "Maltese", Language.Maltese),
                                                               new IsoLanguage("gv", "", "glv", "Manx", Language.Manx),
                                                               new IsoLanguage("mi", "", "mri", "Maori", Language.Maori),
                                                               new IsoLanguage("mh", "", "mah", "Marshallese", Language.Marshallese),
                                                               new IsoLanguage("na", "", "nau", "Nauru", Language.Nauru),
                                                               new IsoLanguage("nv", "", "nav", "Navajo", Language.Navajo),
                                                               new IsoLanguage("ng", "", "ndo", "Ndonga", Language.Ndonga),
                                                               new IsoLanguage("ne", "", "nep", "Nepali", Language.Nepali),
                                                               new IsoLanguage("nd", "", "nde", "North Ndebele", Language.NorthNdebele),
                                                               new IsoLanguage("se", "", "sme", "Northern Sami", Language.NorthernSami),
                                                               new IsoLanguage("ii", "", "iii", "Sichuan Yi", Language.SichuanYi),
                                                               new IsoLanguage("oc", "", "oci", "Occitan", Language.Occitan),
                                                               new IsoLanguage("or", "", "ori", "Odia", Language.Odia),
                                                               new IsoLanguage("oj", "", "oji", "Ojibwa", Language.Ojibwa),
                                                               new IsoLanguage("om", "", "orm", "Oromo", Language.Oromo),
                                                               new IsoLanguage("os", "", "oss", "Ossetian", Language.Ossetian),
                                                               new IsoLanguage("pi", "", "pli", "Pali", Language.Pali),
                                                               new IsoLanguage("ps", "", "pus", "Pashto", Language.Pashto),
                                                               new IsoLanguage("pa", "", "pan", "Punjabi", Language.Punjabi),
                                                               new IsoLanguage("qu", "", "que", "Quechua", Language.Quechua),
                                                               new IsoLanguage("rn", "", "run", "Rundi", Language.Rundi),
                                                               new IsoLanguage("sm", "", "smo", "Samoan", Language.Samoan),
                                                               new IsoLanguage("sg", "", "sag", "Sango", Language.Sango),
                                                               new IsoLanguage("sa", "", "san", "Sanskrit", Language.Sanskrit),
                                                               new IsoLanguage("sc", "", "srd", "Sardinian", Language.Sardinian),
                                                               new IsoLanguage("gd", "", "gla", "Scottish Gaelic", Language.ScottishGaelic),
                                                               new IsoLanguage("sn", "", "sna", "Shona", Language.Shona),
                                                               new IsoLanguage("sd", "", "snd", "Sindhi", Language.Sindhi),
                                                               new IsoLanguage("si", "", "sin", "Sinhala", Language.Sinhala),
                                                               new IsoLanguage("so", "", "som", "Somali", Language.Somali),
                                                               new IsoLanguage("nr", "", "nbl", "South Ndebele", Language.SouthNdebele),
                                                               new IsoLanguage("st", "", "sot", "Southern Sotho", Language.SouthernSotho),
                                                               new IsoLanguage("su", "", "sun", "Sundanese", Language.Sundanese),
                                                               new IsoLanguage("sw", "", "swa", "Swahili", Language.Swahili),
                                                               new IsoLanguage("ss", "", "ssw", "Swati", Language.Swati),
                                                               new IsoLanguage("ty", "", "tah", "Tahitian", Language.Tahitian),
                                                               new IsoLanguage("tg", "", "tgk", "Tajik", Language.Tajik),
                                                               new IsoLanguage("tt", "", "tat", "Tatar", Language.Tatar),
                                                               new IsoLanguage("bo", "", "bod", "Tibetan", Language.Tibetan),
                                                               new IsoLanguage("ti", "", "tir", "Tigrinya", Language.Tigrinya),
                                                               new IsoLanguage("to", "", "ton", "Tongan", Language.Tongan),
                                                               new IsoLanguage("ts", "", "tso", "Tsonga", Language.Tsonga),
                                                               new IsoLanguage("tn", "", "tsn", "Tswana", Language.Tswana),
                                                               new IsoLanguage("tk", "", "tuk", "Turkmen", Language.Turkmen),
                                                               new IsoLanguage("tw", "", "twi", "Twi", Language.Twi),
                                                               new IsoLanguage("ug", "", "uig", "Uyghur", Language.Uyghur),
                                                               new IsoLanguage("uz", "", "uzb", "Uzbek", Language.Uzbek),
                                                               new IsoLanguage("ve", "", "ven", "Venda", Language.Venda),
                                                               new IsoLanguage("vo", "", "vol", "Volapuk", Language.Volapuk),
                                                               new IsoLanguage("wa", "", "wln", "Walloon", Language.Walloon),
                                                               new IsoLanguage("cy", "", "cym", "Welsh", Language.Welsh),
                                                               new IsoLanguage("wo", "", "wol", "Wolof", Language.Wolof),
                                                               new IsoLanguage("xh", "", "xho", "Xhosa", Language.Xhosa),
                                                               new IsoLanguage("yi", "", "yid", "Yiddish", Language.Yiddish),
                                                               new IsoLanguage("yo", "", "yor", "Yoruba", Language.Yoruba),
                                                               new IsoLanguage("za", "", "zha", "Zhuang", Language.Zhuang),
                                                               new IsoLanguage("zu", "", "zul", "Zulu", Language.Zulu),
                                                               new IsoLanguage("nn", "", "nno", "Norwegian Nynorsk", Language.Norwegian),
                                                               new IsoLanguage("sh", "", "hbs", "Serbo-Croatian", Language.Serbian),
                                                               new IsoLanguage("mo", "", "mol", "Moldavian", Language.Romanian),
                                                               new IsoLanguage("xx", "", "zxx", "No Language", Language.Unknown)
                                                           };

        private static readonly Dictionary<string, Language> AlternateIsoCodeMappings = new()
        {
            { "cn", Language.Chinese }
        };

        public static IsoLanguage Find(string isoCode)
        {
            var isoArray = isoCode.Split('-');
            var langCode = isoArray[0].ToLower();

            if (AlternateIsoCodeMappings.TryGetValue(isoCode, out var alternateLanguage))
            {
                return Get(alternateLanguage);
            }
            else if (langCode.Length == 2)
            {
                // Lookup ISO639-1 code
                var isoLanguages = All.Where(l => l.TwoLetterCode == langCode).ToList();

                if (isoArray.Length > 1)
                {
                    isoLanguages = isoLanguages.Any(l => l.CountryCode == isoArray[1].ToLower()) ?
                        isoLanguages.Where(l => l.CountryCode == isoArray[1].ToLower()).ToList() :
                        isoLanguages.Where(l => string.IsNullOrEmpty(l.CountryCode)).ToList();
                }

                return isoLanguages.FirstOrDefault();
            }
            else if (langCode.Length == 3)
            {
                // Lookup ISO639-2T code
                if (FileNameBuilder.Iso639BTMap.TryGetValue(langCode, out var mapped))
                {
                    langCode = mapped;
                }

                return All.FirstOrDefault(l => l.ThreeLetterCode == langCode);
            }

            return null;
        }

        public static IsoLanguage Get(Language language)
        {
            return All.FirstOrDefault(l => l.Language == language);
        }

        public static IsoLanguage FindByName(string name)
        {
            return All.FirstOrDefault(l => l.EnglishName.Equals(name.Trim(), StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
