using FluentAssertions;
using NUnit.Framework;
using NzbDrone.Core.Languages;
using NzbDrone.Core.Parser;
using NzbDrone.Core.Test.Framework;

namespace NzbDrone.Core.Test.ParserTests
{
    [TestFixture]
    public class IsoLanguagesFixture : CoreTest
    {
        [TestCase("en")]
        [TestCase("eng")]
        [TestCase("en-US")]
        [TestCase("en-GB")]
        public void should_return_iso_language_for_English(string isoCode)
        {
            var result = IsoLanguages.Find(isoCode);
            result.Language.Should().Be(Language.English);
        }

        [TestCase("enus")]
        [TestCase("enusa")]
        [TestCase("zz")]
        [TestCase("fr-CA")]
        public void unknown_or_invalid_code_should_return_null(string isoCode)
        {
            var result = IsoLanguages.Find(isoCode);
            result.Should().Be(null);
        }

        [TestCase("pt")]
        [TestCase("por")]
        [TestCase("pt-PT")]
        public void should_return_portuguese(string isoCode)
        {
            var result = IsoLanguages.Find(isoCode);
            result.Language.Should().Be(Language.Portuguese);
        }

        [TestCase("de-AU")]
        public void should_not_return_portuguese(string isoCode)
        {
            var result = IsoLanguages.Find(isoCode);
            result.Should().Be(null);
        }

        [TestCase("te")]
        [TestCase("tel")]
        [TestCase("te-IN")]
        public void should_return_telugu(string isoCode)
        {
            var result = IsoLanguages.Find(isoCode);
            result.Language.Should().Be(Language.Telugu);
        }

        [TestCase("af")]
        [TestCase("afr")]
        [TestCase("af-ZA")]
        public void should_return_afrikaans(string isoCode)
        {
            var result = IsoLanguages.Find(isoCode);
            result.Language.Should().Be(Language.Afrikaans);
        }

        [TestCase("mr")]
        [TestCase("mar")]
        [TestCase("mr-IN")]
        public void should_return_marathi(string isoCode)
        {
            var result = IsoLanguages.Find(isoCode);
            result.Language.Should().Be(Language.Marathi);
        }

        [TestCase("tl")]
        [TestCase("tgl")]
        [TestCase("tl-PH")]
        public void should_return_tagalog(string isoCode)
        {
            var result = IsoLanguages.Find(isoCode);
            result.Language.Should().Be(Language.Tagalog);
        }

        [TestCase("ur")]
        [TestCase("urd")]
        [TestCase("ur-PK")]
        public void should_return_urdu(string isoCode)
        {
            var result = IsoLanguages.Find(isoCode);
            result.Language.Should().Be(Language.Urdu);
        }

        [TestCase("rm")]
        [TestCase("roh")]
        [TestCase("rm-CH")]
        public void should_return_romansh(string isoCode)
        {
            var result = IsoLanguages.Find(isoCode);
            result.Language.Should().Be(Language.Romansh);
        }

        [TestCase("mn")]
        [TestCase("mon")]
        [TestCase("khk")]
        [TestCase("mvf")]
        [TestCase("mn-Cyrl")]
        public void should_return_mongolian(string isoCode)
        {
            var result = IsoLanguages.Find(isoCode);
            result.Language.Should().Be(Language.Mongolian);
        }

        [TestCase("bn")]
        [TestCase("ben")]
        [TestCase("bn-BD")]
        [TestCase("bn-IN")]
        public void should_return_bengali(string isoCode)
        {
            var result = IsoLanguages.Find(isoCode);
            result.Language.Should().Be(Language.Bengali);
        }

        [TestCase("ka")]
        [TestCase("geo")]
        [TestCase("kat")]
        [TestCase("ka-GE")]
        public void should_return_georgian(string isoCode)
        {
            var result = IsoLanguages.Find(isoCode);
            result.Language.Should().Be(Language.Georgian);
        }

        [TestCase("ab", "Abkhazian")]
        [TestCase("abk", "Abkhazian")]
        [TestCase("aa", "Afar")]
        [TestCase("aar", "Afar")]
        [TestCase("ak", "Akan")]
        [TestCase("aka", "Akan")]
        [TestCase("am", "Amharic")]
        [TestCase("amh", "Amharic")]
        [TestCase("an", "Aragonese")]
        [TestCase("arg", "Aragonese")]
        [TestCase("hy", "Armenian")]
        [TestCase("hye", "Armenian")]
        [TestCase("as", "Assamese")]
        [TestCase("asm", "Assamese")]
        [TestCase("av", "Avaric")]
        [TestCase("ava", "Avaric")]
        [TestCase("ae", "Avestan")]
        [TestCase("ave", "Avestan")]
        [TestCase("ay", "Aymara")]
        [TestCase("aym", "Aymara")]
        [TestCase("az", "Azerbaijani")]
        [TestCase("aze", "Azerbaijani")]
        [TestCase("bm", "Bambara")]
        [TestCase("bam", "Bambara")]
        [TestCase("ba", "Bashkir")]
        [TestCase("bak", "Bashkir")]
        [TestCase("eu", "Basque")]
        [TestCase("eus", "Basque")]
        [TestCase("be", "Belarusian")]
        [TestCase("bel", "Belarusian")]
        [TestCase("bi", "Bislama")]
        [TestCase("bis", "Bislama")]
        [TestCase("br", "Breton")]
        [TestCase("bre", "Breton")]
        [TestCase("my", "Burmese")]
        [TestCase("mya", "Burmese")]
        [TestCase("ch", "Chamorro")]
        [TestCase("cha", "Chamorro")]
        [TestCase("ce", "Chechen")]
        [TestCase("che", "Chechen")]
        [TestCase("ny", "Chichewa")]
        [TestCase("nya", "Chichewa")]
        [TestCase("cu", "Church Slavic")]
        [TestCase("chu", "Church Slavic")]
        [TestCase("cv", "Chuvash")]
        [TestCase("chv", "Chuvash")]
        [TestCase("kw", "Cornish")]
        [TestCase("cor", "Cornish")]
        [TestCase("co", "Corsican")]
        [TestCase("cos", "Corsican")]
        [TestCase("cr", "Cree")]
        [TestCase("cre", "Cree")]
        [TestCase("dv", "Divehi")]
        [TestCase("div", "Divehi")]
        [TestCase("dz", "Dzongkha")]
        [TestCase("dzo", "Dzongkha")]
        [TestCase("eo", "Esperanto")]
        [TestCase("epo", "Esperanto")]
        [TestCase("ee", "Ewe")]
        [TestCase("ewe", "Ewe")]
        [TestCase("fo", "Faroese")]
        [TestCase("fao", "Faroese")]
        [TestCase("fj", "Fijian")]
        [TestCase("fij", "Fijian")]
        [TestCase("fy", "Frisian")]
        [TestCase("fry", "Frisian")]
        [TestCase("ff", "Fulah")]
        [TestCase("ful", "Fulah")]
        [TestCase("gl", "Galician")]
        [TestCase("glg", "Galician")]
        [TestCase("lg", "Ganda")]
        [TestCase("lug", "Ganda")]
        [TestCase("gn", "Guarani")]
        [TestCase("grn", "Guarani")]
        [TestCase("gu", "Gujarati")]
        [TestCase("guj", "Gujarati")]
        [TestCase("ht", "Haitian Creole")]
        [TestCase("hat", "Haitian Creole")]
        [TestCase("ha", "Hausa")]
        [TestCase("hau", "Hausa")]
        [TestCase("hz", "Herero")]
        [TestCase("her", "Herero")]
        [TestCase("ho", "Hiri Motu")]
        [TestCase("hmo", "Hiri Motu")]
        [TestCase("io", "Ido")]
        [TestCase("ido", "Ido")]
        [TestCase("ig", "Igbo")]
        [TestCase("ibo", "Igbo")]
        [TestCase("ia", "Interlingua")]
        [TestCase("ina", "Interlingua")]
        [TestCase("ie", "Interlingue")]
        [TestCase("ile", "Interlingue")]
        [TestCase("iu", "Inuktitut")]
        [TestCase("iku", "Inuktitut")]
        [TestCase("ik", "Inupiaq")]
        [TestCase("ipk", "Inupiaq")]
        [TestCase("ga", "Irish")]
        [TestCase("gle", "Irish")]
        [TestCase("jv", "Javanese")]
        [TestCase("jav", "Javanese")]
        [TestCase("kl", "Kalaallisut")]
        [TestCase("kal", "Kalaallisut")]
        [TestCase("kr", "Kanuri")]
        [TestCase("kau", "Kanuri")]
        [TestCase("ks", "Kashmiri")]
        [TestCase("kas", "Kashmiri")]
        [TestCase("kk", "Kazakh")]
        [TestCase("kaz", "Kazakh")]
        [TestCase("km", "Khmer")]
        [TestCase("khm", "Khmer")]
        [TestCase("ki", "Kikuyu")]
        [TestCase("kik", "Kikuyu")]
        [TestCase("rw", "Kinyarwanda")]
        [TestCase("kin", "Kinyarwanda")]
        [TestCase("kv", "Komi")]
        [TestCase("kom", "Komi")]
        [TestCase("kg", "Kongo")]
        [TestCase("kon", "Kongo")]
        [TestCase("kj", "Kuanyama")]
        [TestCase("kua", "Kuanyama")]
        [TestCase("ku", "Kurdish")]
        [TestCase("kur", "Kurdish")]
        [TestCase("ky", "Kyrgyz")]
        [TestCase("kir", "Kyrgyz")]
        [TestCase("lo", "Lao")]
        [TestCase("lao", "Lao")]
        [TestCase("la", "Latin")]
        [TestCase("lat", "Latin")]
        [TestCase("li", "Limburgish")]
        [TestCase("lim", "Limburgish")]
        [TestCase("ln", "Lingala")]
        [TestCase("lin", "Lingala")]
        [TestCase("lu", "Luba-Katanga")]
        [TestCase("lub", "Luba-Katanga")]
        [TestCase("lb", "Luxembourgish")]
        [TestCase("ltz", "Luxembourgish")]
        [TestCase("mg", "Malagasy")]
        [TestCase("mlg", "Malagasy")]
        [TestCase("ms", "Malay")]
        [TestCase("msa", "Malay")]
        [TestCase("mt", "Maltese")]
        [TestCase("mlt", "Maltese")]
        [TestCase("gv", "Manx")]
        [TestCase("glv", "Manx")]
        [TestCase("mi", "Maori")]
        [TestCase("mri", "Maori")]
        [TestCase("mh", "Marshallese")]
        [TestCase("mah", "Marshallese")]
        [TestCase("na", "Nauru")]
        [TestCase("nau", "Nauru")]
        [TestCase("nv", "Navajo")]
        [TestCase("nav", "Navajo")]
        [TestCase("ng", "Ndonga")]
        [TestCase("ndo", "Ndonga")]
        [TestCase("ne", "Nepali")]
        [TestCase("nep", "Nepali")]
        [TestCase("nd", "North Ndebele")]
        [TestCase("nde", "North Ndebele")]
        [TestCase("se", "Northern Sami")]
        [TestCase("sme", "Northern Sami")]
        [TestCase("ii", "Sichuan Yi")]
        [TestCase("iii", "Sichuan Yi")]
        [TestCase("oc", "Occitan")]
        [TestCase("oci", "Occitan")]
        [TestCase("or", "Odia")]
        [TestCase("ori", "Odia")]
        [TestCase("oj", "Ojibwa")]
        [TestCase("oji", "Ojibwa")]
        [TestCase("om", "Oromo")]
        [TestCase("orm", "Oromo")]
        [TestCase("os", "Ossetian")]
        [TestCase("oss", "Ossetian")]
        [TestCase("pi", "Pali")]
        [TestCase("pli", "Pali")]
        [TestCase("ps", "Pashto")]
        [TestCase("pus", "Pashto")]
        [TestCase("pa", "Punjabi")]
        [TestCase("pan", "Punjabi")]
        [TestCase("qu", "Quechua")]
        [TestCase("que", "Quechua")]
        [TestCase("rn", "Rundi")]
        [TestCase("run", "Rundi")]
        [TestCase("sm", "Samoan")]
        [TestCase("smo", "Samoan")]
        [TestCase("sg", "Sango")]
        [TestCase("sag", "Sango")]
        [TestCase("sa", "Sanskrit")]
        [TestCase("san", "Sanskrit")]
        [TestCase("sc", "Sardinian")]
        [TestCase("srd", "Sardinian")]
        [TestCase("gd", "Scottish Gaelic")]
        [TestCase("gla", "Scottish Gaelic")]
        [TestCase("sn", "Shona")]
        [TestCase("sna", "Shona")]
        [TestCase("sd", "Sindhi")]
        [TestCase("snd", "Sindhi")]
        [TestCase("si", "Sinhala")]
        [TestCase("sin", "Sinhala")]
        [TestCase("so", "Somali")]
        [TestCase("som", "Somali")]
        [TestCase("nr", "South Ndebele")]
        [TestCase("nbl", "South Ndebele")]
        [TestCase("st", "Southern Sotho")]
        [TestCase("sot", "Southern Sotho")]
        [TestCase("su", "Sundanese")]
        [TestCase("sun", "Sundanese")]
        [TestCase("sw", "Swahili")]
        [TestCase("swa", "Swahili")]
        [TestCase("ss", "Swati")]
        [TestCase("ssw", "Swati")]
        [TestCase("ty", "Tahitian")]
        [TestCase("tah", "Tahitian")]
        [TestCase("tg", "Tajik")]
        [TestCase("tgk", "Tajik")]
        [TestCase("tt", "Tatar")]
        [TestCase("tat", "Tatar")]
        [TestCase("bo", "Tibetan")]
        [TestCase("bod", "Tibetan")]
        [TestCase("ti", "Tigrinya")]
        [TestCase("tir", "Tigrinya")]
        [TestCase("to", "Tongan")]
        [TestCase("ton", "Tongan")]
        [TestCase("ts", "Tsonga")]
        [TestCase("tso", "Tsonga")]
        [TestCase("tn", "Tswana")]
        [TestCase("tsn", "Tswana")]
        [TestCase("tk", "Turkmen")]
        [TestCase("tuk", "Turkmen")]
        [TestCase("tw", "Twi")]
        [TestCase("twi", "Twi")]
        [TestCase("ug", "Uyghur")]
        [TestCase("uig", "Uyghur")]
        [TestCase("uz", "Uzbek")]
        [TestCase("uzb", "Uzbek")]
        [TestCase("ve", "Venda")]
        [TestCase("ven", "Venda")]
        [TestCase("vo", "Volapuk")]
        [TestCase("vol", "Volapuk")]
        [TestCase("wa", "Walloon")]
        [TestCase("wln", "Walloon")]
        [TestCase("cy", "Welsh")]
        [TestCase("cym", "Welsh")]
        [TestCase("wo", "Wolof")]
        [TestCase("wol", "Wolof")]
        [TestCase("xh", "Xhosa")]
        [TestCase("xho", "Xhosa")]
        [TestCase("yi", "Yiddish")]
        [TestCase("yid", "Yiddish")]
        [TestCase("yo", "Yoruba")]
        [TestCase("yor", "Yoruba")]
        [TestCase("za", "Zhuang")]
        [TestCase("zha", "Zhuang")]
        [TestCase("zu", "Zulu")]
        [TestCase("zul", "Zulu")]
        [TestCase("nn", "Norwegian")]
        [TestCase("nno", "Norwegian")]
        [TestCase("sh", "Serbian")]
        [TestCase("hbs", "Serbian")]
        [TestCase("mo", "Romanian")]
        [TestCase("mol", "Romanian")]
        [TestCase("xx", "Unknown")]
        [TestCase("zxx", "Unknown")]
        [TestCase("pa-IN", "Punjabi")]
        [TestCase("arm", "Armenian")]
        [TestCase("may", "Malay")]
        [TestCase("wel", "Welsh")]
        public void should_return_tmdb_languages(string isoCode, string languageName)
        {
            var result = IsoLanguages.Find(isoCode);
            result.Language.Should().Be((Language)languageName);
        }
    }
}
