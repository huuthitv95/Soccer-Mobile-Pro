public static class NationalData
{
	public enum eNation
	{
		None = 0,
		Afghanistan = 1,
		Albania = 2,
		Algeria = 3,
		Andorra = 4,
		Angola = 5,
		Antigua_and_Barbuda = 6,
		Argentina = 7,
		Armenia = 8,
		Australia = 9,
		Austria = 10,
		Azerbaijan = 11,
		Bahamas = 12,
		Bahrain = 13,
		Bangladesh = 14,
		Barbados = 15,
		Belarus = 16,
		Belgium = 17,
		Belize = 18,
		Benin = 19,
		Bermuda = 20,
		Bolivia = 21,
		Bosnia_and_Herzegovina = 22,
		Botswana = 23,
		Brazil = 24,
		Brunei = 25,
		Bulgaria = 26,
		Burkina_Faso = 27,
		Burundi = 28,
		CHINA_HONG_KONG = 29,
		Cambodia = 30,
		Cameroon = 31,
		Canada = 32,
		Cape_Verde = 33,
		Central_African_Republic = 34,
		Chad = 35,
		Chile = 36,
		China = 37,
		China_Macao = 38,
		China_Taipei = 39,
		Colombia = 40,
		Comoros = 41,
		Congo = 42,
		Costa_Rica = 43,
		Croatia = 44,
		Cuba = 45,
		Curacao = 46,
		Cyprus = 47,
		Czech_Republic = 48,
		DR_CONGO = 49,
		DR_Congo = 50,
		Denmark = 51,
		Djibouti = 52,
		Dominican_Republic = 53,
		Ecuador = 54,
		Egypt = 55,
		El_Salvador = 56,
		England = 57,
		Equatorial_Guinea = 58,
		Estonia = 59,
		Eswatini = 60,
		Ethiopia = 61,
		FYR_MACEDONIA = 62,
		Fiji = 63,
		Finland = 64,
		France = 65,
		French_Guiana = 66,
		Gabon = 67,
		Gambia = 68,
		Georgia = 69,
		Germany = 70,
		Ghana = 71,
		Gibraltar = 72,
		Greece = 73,
		Grenada = 74,
		Guadeloupe = 75,
		Guam = 76,
		Guatemala = 77,
		Guinea = 78,
		Guinea_Bissau = 79,
		Guyana = 80,
		Haiti = 81,
		Honduras = 82,
		Hungary = 83,
		Iceland = 84,
		India = 85,
		Indonesia = 86,
		Iran = 87,
		Iraq = 88,
		Ireland = 89,
		Israel = 90,
		Italy = 91,
		Ivory_Coast = 92,
		Jamaica = 93,
		Japan = 94,
		Jordan = 95,
		Kazakhstan = 96,
		Kenya = 97,
		Kuwait = 98,
		Kyrgyzstan = 99,
		Laos = 100,
		Latvia = 101,
		Lebanon = 102,
		Lesotho = 103,
		Liberia = 104,
		Libya = 105,
		Liechtenstein = 106,
		Lithuania = 107,
		Luxembourg = 108,
		Madagascar = 109,
		Malawi = 110,
		Malaysia = 111,
		Maldives = 112,
		Mali = 113,
		Malta = 114,
		Mariana_Is = 115,
		Martinique = 116,
		Mauritania = 117,
		Mauritius = 118,
		Mexico = 119,
		Moldova = 120,
		Monaco = 121,
		Mongolia = 122,
		Morocco = 123,
		Mozambique = 124,
		Myanmar = 125,
		NORTHERN_IRELAND = 126,
		Namibia = 127,
		Nauru = 128,
		Nepal = 129,
		Netherlands = 130,
		New_Zealand = 131,
		Nicaragua = 132,
		Niger = 133,
		Nigeria = 134,
		North_Korea = 135,
		Norway = 136,
		Oman = 137,
		Pakistan = 138,
		Palestine = 139,
		Panama = 140,
		Papua_New_Cuinea = 141,
		Paraguay = 142,
		Peru = 143,
		Philippines = 144,
		Poland = 145,
		Portugal = 146,
		Puerto_Rico = 147,
		Qatar = 148,
		Romania = 149,
		Russia = 150,
		Rwanda = 151,
		Saint_Kitts_and_Nevis = 152,
		Saint_Lueia = 153,
		San_Marino = 154,
		Saudi_Arabia = 155,
		Scotland = 156,
		Senegal = 157,
		Serbia = 158,
		Seychelles = 159,
		Sierra_Leone = 160,
		Singapore = 161,
		Slovakia = 162,
		Slovenia = 163,
		Somalia = 164,
		South_Africa = 165,
		South_Korea = 166,
		Spain = 167,
		Sri_Lanka = 168,
		St_Lucia = 169,
		Sudan = 170,
		Suriname = 171,
		Sweden = 172,
		Switzerland = 173,
		Syria = 174,
		Tajikistan = 175,
		Tanzania = 176,
		Thailand = 177,
		Togo = 178,
		Trinidad_and_Tobago = 179,
		Tunisia = 180,
		Turkey = 181,
		Turkmenistan = 182,
		Uganda = 183,
		Ukraine = 184,
		United_Arab_Emirates = 185,
		United_States = 186,
		Uruguay = 187,
		Uzbekistan = 188,
		Venezuela = 189,
		Vietnam = 190,
		Wales = 191,
		Yemen = 192,
		Yugoslavia = 193,
		Zambia = 194,
		Zimbabwe = 195,
		Count = 196
	}

	public enum eContinent
	{
		None = 0,
		Africa = 1,
		Asia = 2,
		Europe = 3,
		North_America = 4,
		Oceania = 5,
		South_America = 6,
		Count = 7
	}

	public enum eAsia
	{
		East_Asia = 0,
		West_Asia = 1
	}

	private static readonly global::System.Collections.Generic.Dictionary<NationalData.eNation, string> _nationToString;

	private static readonly global::System.Collections.Generic.Dictionary<NationalData.eContinent, string> _continentToString;

	private static readonly global::System.Collections.Generic.Dictionary<string, NationalData.eNation> _stringToNation;

	private static readonly global::System.Collections.Generic.Dictionary<string, NationalData.eContinent> _stringToContinent;

	private static readonly global::System.Collections.Generic.Dictionary<NationalData.eNation, NationalData.eContinent> _nationToContinent;

	private static readonly global::System.Collections.Generic.Dictionary<NationalData.eNation, LanguageSetting.eLanguage> _nationToLanguage;

	private static global::System.Collections.Generic.Dictionary<NationalData.eNation, NationalData.eAsia> _nationToAsia;

	public static NationalData.eContinent GetContinentByString(string continent)
	{
		return NationalData.eContinent.None;
	}

	public static NationalData.eContinent GetContinent(string nation)
	{
		return NationalData.eContinent.None;
	}

	public static NationalData.eContinent GetContinent(NationalData.eNation nation)
	{
		return NationalData.eContinent.None;
	}

	public static LanguageSetting.eLanguage GetLanguage(string nation)
	{
		return LanguageSetting.eLanguage.EN;
	}

	public static LanguageSetting.eLanguage GetLanguage(NationalData.eNation nation)
	{
		return LanguageSetting.eLanguage.EN;
	}

	public static string GetNationString(NationalData.eNation nation)
	{
		return null;
	}

	public static string GetContinentString(NationalData.eContinent continent)
	{
		return null;
	}

	public static NationalData.eNation GetNation(string nation)
	{
		return NationalData.eNation.None;
	}

	public static NationalData.eAsia GetAsia(NationalData.eNation nation)
	{
		return NationalData.eAsia.East_Asia;
	}
}
