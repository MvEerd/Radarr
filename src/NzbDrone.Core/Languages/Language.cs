using System;
using System.Collections.Generic;
using System.Linq;
using NzbDrone.Core.Datastore;

namespace NzbDrone.Core.Languages
{
    public class Language : IEmbeddedDocument, IEquatable<Language>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Language()
        {
        }

        private Language(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public bool Equals(Language other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Id.Equals(other.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return Equals(obj as Language);
        }

        public static bool operator ==(Language left, Language right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Language left, Language right)
        {
            return !Equals(left, right);
        }

        public static Language Unknown => new Language(0, "Unknown");
        public static Language English => new Language(1, "English");
        public static Language French => new Language(2, "French");
        public static Language Spanish => new Language(3, "Spanish");
        public static Language German => new Language(4, "German");
        public static Language Italian => new Language(5, "Italian");
        public static Language Danish => new Language(6, "Danish");
        public static Language Dutch => new Language(7, "Dutch");
        public static Language Japanese => new Language(8, "Japanese");
        public static Language Icelandic => new Language(9, "Icelandic");
        public static Language Chinese => new Language(10, "Chinese");
        public static Language Russian => new Language(11, "Russian");
        public static Language Polish => new Language(12, "Polish");
        public static Language Vietnamese => new Language(13, "Vietnamese");
        public static Language Swedish => new Language(14, "Swedish");
        public static Language Norwegian => new Language(15, "Norwegian");
        public static Language Finnish => new Language(16, "Finnish");
        public static Language Turkish => new Language(17, "Turkish");
        public static Language Portuguese => new Language(18, "Portuguese");
        public static Language Flemish => new Language(19, "Flemish");
        public static Language Greek => new Language(20, "Greek");
        public static Language Korean => new Language(21, "Korean");
        public static Language Hungarian => new Language(22, "Hungarian");
        public static Language Hebrew => new Language(23, "Hebrew");
        public static Language Lithuanian => new Language(24, "Lithuanian");
        public static Language Czech => new Language(25, "Czech");
        public static Language Hindi => new Language(26, "Hindi");
        public static Language Romanian => new Language(27, "Romanian");
        public static Language Thai => new Language(28, "Thai");
        public static Language Bulgarian => new Language(29, "Bulgarian");
        public static Language PortugueseBR => new Language(30, "Portuguese (Brazil)");
        public static Language Arabic => new Language(31, "Arabic");
        public static Language Ukrainian => new Language(32, "Ukrainian");
        public static Language Persian => new Language(33, "Persian");
        public static Language Bengali => new Language(34, "Bengali");
        public static Language Slovak => new Language(35, "Slovak");
        public static Language Latvian => new Language(36, "Latvian");
        public static Language SpanishLatino => new Language(37, "Spanish (Latino)");
        public static Language Catalan => new Language(38, "Catalan");
        public static Language Croatian => new Language(39, "Croatian");
        public static Language Serbian => new Language(40, "Serbian");
        public static Language Bosnian => new Language(41, "Bosnian");
        public static Language Estonian => new Language(42, "Estonian");
        public static Language Tamil => new Language(43, "Tamil");
        public static Language Indonesian => new Language(44, "Indonesian");
        public static Language Telugu => new Language(45, "Telugu");
        public static Language Macedonian => new Language(46, "Macedonian");
        public static Language Slovenian => new Language(47, "Slovenian");
        public static Language Malayalam => new Language(48, "Malayalam");
        public static Language Kannada => new Language(49, "Kannada");
        public static Language Albanian => new Language(50, "Albanian");
        public static Language Afrikaans => new Language(51, "Afrikaans");
        public static Language Marathi => new Language(52, "Marathi");
        public static Language Tagalog => new Language(53, "Tagalog");
        public static Language Urdu => new Language(54, "Urdu");
        public static Language Romansh => new Language(55, "Romansh");
        public static Language Mongolian => new Language(56, "Mongolian");
        public static Language Georgian => new Language(57, "Georgian");
        public static Language Abkhazian => new Language(58, "Abkhazian");
        public static Language Afar => new Language(59, "Afar");
        public static Language Akan => new Language(60, "Akan");
        public static Language Amharic => new Language(61, "Amharic");
        public static Language Aragonese => new Language(62, "Aragonese");
        public static Language Armenian => new Language(63, "Armenian");
        public static Language Assamese => new Language(64, "Assamese");
        public static Language Avaric => new Language(65, "Avaric");
        public static Language Avestan => new Language(66, "Avestan");
        public static Language Aymara => new Language(67, "Aymara");
        public static Language Azerbaijani => new Language(68, "Azerbaijani");
        public static Language Bambara => new Language(69, "Bambara");
        public static Language Bashkir => new Language(70, "Bashkir");
        public static Language Basque => new Language(71, "Basque");
        public static Language Belarusian => new Language(72, "Belarusian");
        public static Language Bislama => new Language(73, "Bislama");
        public static Language Breton => new Language(74, "Breton");
        public static Language Burmese => new Language(75, "Burmese");
        public static Language Chamorro => new Language(76, "Chamorro");
        public static Language Chechen => new Language(77, "Chechen");
        public static Language Chichewa => new Language(78, "Chichewa");
        public static Language ChurchSlavic => new Language(79, "Church Slavic");
        public static Language Chuvash => new Language(80, "Chuvash");
        public static Language Cornish => new Language(81, "Cornish");
        public static Language Corsican => new Language(82, "Corsican");
        public static Language Cree => new Language(83, "Cree");
        public static Language Divehi => new Language(84, "Divehi");
        public static Language Dzongkha => new Language(85, "Dzongkha");
        public static Language Esperanto => new Language(86, "Esperanto");
        public static Language Ewe => new Language(87, "Ewe");
        public static Language Faroese => new Language(88, "Faroese");
        public static Language Fijian => new Language(89, "Fijian");
        public static Language Frisian => new Language(90, "Frisian");
        public static Language Fulah => new Language(91, "Fulah");
        public static Language Galician => new Language(92, "Galician");
        public static Language Ganda => new Language(93, "Ganda");
        public static Language Guarani => new Language(94, "Guarani");
        public static Language Gujarati => new Language(95, "Gujarati");
        public static Language HaitianCreole => new Language(96, "Haitian Creole");
        public static Language Hausa => new Language(97, "Hausa");
        public static Language Herero => new Language(98, "Herero");
        public static Language HiriMotu => new Language(99, "Hiri Motu");
        public static Language Ido => new Language(100, "Ido");
        public static Language Igbo => new Language(101, "Igbo");
        public static Language Interlingua => new Language(102, "Interlingua");
        public static Language Interlingue => new Language(103, "Interlingue");
        public static Language Inuktitut => new Language(104, "Inuktitut");
        public static Language Inupiaq => new Language(105, "Inupiaq");
        public static Language Irish => new Language(106, "Irish");
        public static Language Javanese => new Language(107, "Javanese");
        public static Language Kalaallisut => new Language(108, "Kalaallisut");
        public static Language Kanuri => new Language(109, "Kanuri");
        public static Language Kashmiri => new Language(110, "Kashmiri");
        public static Language Kazakh => new Language(111, "Kazakh");
        public static Language Khmer => new Language(112, "Khmer");
        public static Language Kikuyu => new Language(113, "Kikuyu");
        public static Language Kinyarwanda => new Language(114, "Kinyarwanda");
        public static Language Komi => new Language(115, "Komi");
        public static Language Kongo => new Language(116, "Kongo");
        public static Language Kuanyama => new Language(117, "Kuanyama");
        public static Language Kurdish => new Language(118, "Kurdish");
        public static Language Kyrgyz => new Language(119, "Kyrgyz");
        public static Language Lao => new Language(120, "Lao");
        public static Language Latin => new Language(121, "Latin");
        public static Language Limburgish => new Language(122, "Limburgish");
        public static Language Lingala => new Language(123, "Lingala");
        public static Language LubaKatanga => new Language(124, "Luba-Katanga");
        public static Language Luxembourgish => new Language(125, "Luxembourgish");
        public static Language Malagasy => new Language(126, "Malagasy");
        public static Language Malay => new Language(127, "Malay");
        public static Language Maltese => new Language(128, "Maltese");
        public static Language Manx => new Language(129, "Manx");
        public static Language Maori => new Language(130, "Maori");
        public static Language Marshallese => new Language(131, "Marshallese");
        public static Language Nauru => new Language(132, "Nauru");
        public static Language Navajo => new Language(133, "Navajo");
        public static Language Ndonga => new Language(134, "Ndonga");
        public static Language Nepali => new Language(135, "Nepali");
        public static Language NorthNdebele => new Language(136, "North Ndebele");
        public static Language NorthernSami => new Language(137, "Northern Sami");
        public static Language SichuanYi => new Language(138, "Sichuan Yi");
        public static Language Occitan => new Language(139, "Occitan");
        public static Language Odia => new Language(140, "Odia");
        public static Language Ojibwa => new Language(141, "Ojibwa");
        public static Language Oromo => new Language(142, "Oromo");
        public static Language Ossetian => new Language(143, "Ossetian");
        public static Language Pali => new Language(144, "Pali");
        public static Language Pashto => new Language(145, "Pashto");
        public static Language Punjabi => new Language(146, "Punjabi");
        public static Language Quechua => new Language(147, "Quechua");
        public static Language Rundi => new Language(148, "Rundi");
        public static Language Samoan => new Language(149, "Samoan");
        public static Language Sango => new Language(150, "Sango");
        public static Language Sanskrit => new Language(151, "Sanskrit");
        public static Language Sardinian => new Language(152, "Sardinian");
        public static Language ScottishGaelic => new Language(153, "Scottish Gaelic");
        public static Language Shona => new Language(154, "Shona");
        public static Language Sindhi => new Language(155, "Sindhi");
        public static Language Sinhala => new Language(156, "Sinhala");
        public static Language Somali => new Language(157, "Somali");
        public static Language SouthNdebele => new Language(158, "South Ndebele");
        public static Language SouthernSotho => new Language(159, "Southern Sotho");
        public static Language Sundanese => new Language(160, "Sundanese");
        public static Language Swahili => new Language(161, "Swahili");
        public static Language Swati => new Language(162, "Swati");
        public static Language Tahitian => new Language(163, "Tahitian");
        public static Language Tajik => new Language(164, "Tajik");
        public static Language Tatar => new Language(165, "Tatar");
        public static Language Tibetan => new Language(166, "Tibetan");
        public static Language Tigrinya => new Language(167, "Tigrinya");
        public static Language Tongan => new Language(168, "Tongan");
        public static Language Tsonga => new Language(169, "Tsonga");
        public static Language Tswana => new Language(170, "Tswana");
        public static Language Turkmen => new Language(171, "Turkmen");
        public static Language Twi => new Language(172, "Twi");
        public static Language Uyghur => new Language(173, "Uyghur");
        public static Language Uzbek => new Language(174, "Uzbek");
        public static Language Venda => new Language(175, "Venda");
        public static Language Volapuk => new Language(176, "Volapuk");
        public static Language Walloon => new Language(177, "Walloon");
        public static Language Welsh => new Language(178, "Welsh");
        public static Language Wolof => new Language(179, "Wolof");
        public static Language Xhosa => new Language(180, "Xhosa");
        public static Language Yiddish => new Language(181, "Yiddish");
        public static Language Yoruba => new Language(182, "Yoruba");
        public static Language Zhuang => new Language(183, "Zhuang");
        public static Language Zulu => new Language(184, "Zulu");
        public static Language Any => new Language(-1, "Any");
        public static Language Original => new Language(-2, "Original");

        public static List<Language> All
        {
            get
            {
                return new List<Language>
                {
                    Unknown,
                    English,
                    French,
                    Spanish,
                    German,
                    Italian,
                    Danish,
                    Dutch,
                    Japanese,
                    Icelandic,
                    Chinese,
                    Russian,
                    Polish,
                    Vietnamese,
                    Swedish,
                    Norwegian,
                    Finnish,
                    Turkish,
                    Portuguese,
                    Flemish,
                    Greek,
                    Korean,
                    Hungarian,
                    Hebrew,
                    Lithuanian,
                    Czech,
                    Romanian,
                    Hindi,
                    Thai,
                    Bulgarian,
                    PortugueseBR,
                    Arabic,
                    Ukrainian,
                    Persian,
                    Bengali,
                    Slovak,
                    Latvian,
                    SpanishLatino,
                    Catalan,
                    Croatian,
                    Serbian,
                    Bosnian,
                    Estonian,
                    Tamil,
                    Indonesian,
                    Telugu,
                    Macedonian,
                    Slovenian,
                    Malayalam,
                    Kannada,
                    Albanian,
                    Afrikaans,
                    Marathi,
                    Tagalog,
                    Urdu,
                    Romansh,
                    Mongolian,
                    Georgian,
                    Abkhazian,
                    Afar,
                    Akan,
                    Amharic,
                    Aragonese,
                    Armenian,
                    Assamese,
                    Avaric,
                    Avestan,
                    Aymara,
                    Azerbaijani,
                    Bambara,
                    Bashkir,
                    Basque,
                    Belarusian,
                    Bislama,
                    Breton,
                    Burmese,
                    Chamorro,
                    Chechen,
                    Chichewa,
                    ChurchSlavic,
                    Chuvash,
                    Cornish,
                    Corsican,
                    Cree,
                    Divehi,
                    Dzongkha,
                    Esperanto,
                    Ewe,
                    Faroese,
                    Fijian,
                    Frisian,
                    Fulah,
                    Galician,
                    Ganda,
                    Guarani,
                    Gujarati,
                    HaitianCreole,
                    Hausa,
                    Herero,
                    HiriMotu,
                    Ido,
                    Igbo,
                    Interlingua,
                    Interlingue,
                    Inuktitut,
                    Inupiaq,
                    Irish,
                    Javanese,
                    Kalaallisut,
                    Kanuri,
                    Kashmiri,
                    Kazakh,
                    Khmer,
                    Kikuyu,
                    Kinyarwanda,
                    Komi,
                    Kongo,
                    Kuanyama,
                    Kurdish,
                    Kyrgyz,
                    Lao,
                    Latin,
                    Limburgish,
                    Lingala,
                    LubaKatanga,
                    Luxembourgish,
                    Malagasy,
                    Malay,
                    Maltese,
                    Manx,
                    Maori,
                    Marshallese,
                    Nauru,
                    Navajo,
                    Ndonga,
                    Nepali,
                    NorthNdebele,
                    NorthernSami,
                    SichuanYi,
                    Occitan,
                    Odia,
                    Ojibwa,
                    Oromo,
                    Ossetian,
                    Pali,
                    Pashto,
                    Punjabi,
                    Quechua,
                    Rundi,
                    Samoan,
                    Sango,
                    Sanskrit,
                    Sardinian,
                    ScottishGaelic,
                    Shona,
                    Sindhi,
                    Sinhala,
                    Somali,
                    SouthNdebele,
                    SouthernSotho,
                    Sundanese,
                    Swahili,
                    Swati,
                    Tahitian,
                    Tajik,
                    Tatar,
                    Tibetan,
                    Tigrinya,
                    Tongan,
                    Tsonga,
                    Tswana,
                    Turkmen,
                    Twi,
                    Uyghur,
                    Uzbek,
                    Venda,
                    Volapuk,
                    Walloon,
                    Welsh,
                    Wolof,
                    Xhosa,
                    Yiddish,
                    Yoruba,
                    Zhuang,
                    Zulu,
                    Any,
                    Original
                };
            }
        }

        private static readonly Dictionary<int, Language> Lookup = All.ToDictionary(v => v.Id);

        public static Language FindById(int id)
        {
            if (id == 0)
            {
                return Unknown;
            }

            if (!Lookup.TryGetValue(id, out var language))
            {
                throw new ArgumentException("ID does not match a known language", nameof(id));
            }

            return language;
        }

        public static explicit operator Language(int id)
        {
            return FindById(id);
        }

        public static explicit operator int(Language language)
        {
            return language.Id;
        }

        public static explicit operator Language(string lang)
        {
            var language = All.FirstOrDefault(v => v.Name.Equals(lang, StringComparison.InvariantCultureIgnoreCase));

            if (language == null)
            {
                throw new ArgumentException("Language does not match a known language", nameof(lang));
            }

            return language;
        }

        public bool IsValid(bool throwOnMissing = true)
        {
            return Lookup.ContainsKey(Id) switch
            {
                false when throwOnMissing => throw new InvalidOperationException("ID does not match a known language"),
                false => false,
                _ => true
            };
        }
    }
}
