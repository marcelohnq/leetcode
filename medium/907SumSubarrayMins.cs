namespace leetcode.medium;

public class SumSubarrayMins
{
    [Theory]
    [InlineData(new int[] {31}, 31)]
    [InlineData(new int[] {1, 2}, 4)]
    [InlineData(new int[] {3,1,2,4}, 17)]
    [InlineData(new int[] {11,81,94,43,3}, 444)]
    [InlineData(new int[] {29959,29867,29822,29704,29676,29650,29577,29488,29286,29255,29232,29207,29071,29034,28925,28849,28731,28693,28624,28606,28591,28397,28357,28308,28295,28210,28119,28090,28004,27903,27845,27830,27777,27736,27640,27540,27506,27428,27341,27308,27182,27152,27122,27029,26928,26872,26796,26765,26663,26597,26580,26530,26498,26475,26436,26406,26382,26312,26213,26134,26088,26025,25943,25912,25875,25845,25810,25702,25638,25614,25531,25524,25488,25470,25444,25402,25283,25262,25121,24988,24958,24886,24769,24697,24635,24595,24490,24456,24453,24346,24313,24248,24200,24148,24107,24052,24044,24021,23970,23908,23897,23835,23752,23741,23714,23661,23596,23545,23509,23470,23439,23409,23350,23215,23166,23155,23100,23024,22923,22825,22793,22627,22613,22536,22450,22383,22312,22268,22205,22175,22136,22028,21971,21900,21824,21769,21726,21583,21546,21513,21494,21428,21327,21264,21254,21174,21140,21112,21000,20921,20902,20830,20817,20783,20735,20657,20616,20573,20485,20378,20363,20305,20259,20210,20114,20002,19846,19785,19747,19667,19645,19622,19610,19580,19542,19516,19454,19392,19310,19277,19194,19131,19090,19004,18883,18845,18791,18781,18668,18591,18518,18475,18368,18331,18310,18287,18217,18114,18092,18048,17990,17964,17912,17836,17740,17704,17630,17613,17573,17428,17356,17341,17300,17260,17180,17174,17126,17071,17041,16866,16850,16828,16672,16618,16577,16499,16407,16357,16318,16293,16202,16150,16075,16041,15948,15921,15844,15843,15785,15764,15668,15626,15579,15473,15387,15255,15190,15139,15062,14996,14954,14918,14907,14902,14867,14851,14817,14799,14751,14720,14536,14506,14474,14353,14303,14280,14185,14107,14012,13932,13858,13781,13585,13563,13533,13451,13412,13362,13249,13208,13181,13064,13037,12961,12926,12892,12786,12731,12611,12573,12506,12502,12496,12470,12443,12370,12262,12182,12153,12069,12000,11847,11806,11781,11708,11687,11593,11550,11445,11372,11329,11308,11291,11268,11241,11191,11027,10982,10879,10862,10776,10695,10603,10502,10464,10350,10338,10305,10273,10176,10124,10094,10038,9953,9935,9812,9786,9743,9728,9508,9472,9383,9349,9236,9215,9130,9124,9042,9008,8988,8901,8833,8809,8780,8716,8580,8462,8334,8321,8305,8280,8257,8246,8137,8077,8043,8016,7984,7955,7927,7906,7746,7663,7653,7572,7542,7530,7489,7420,7390,7361,7337,7245,7210,7188,7175,7096,6898,6846,6745,6675,6569,6478,6427,6363,6284,6260,6243,6206,6154,6135,6078,6061,6017,5995,5917,5863,5836,5793,5763,5743,5678,5572,5532,5459,5384,5341,5299,5251,5231,4995,4933,4861,4740,4672,4625,4496,4445,4361,4282,4215,4135,4097,4028,3917,3862,3711,3553,3498,3410,3388,3384,3288,3279,3244,3221,3181,3171,3150,3060,3035,2975,2965,2834,2760,2637,2584,2533,2440,2383,2311,2285,2255,2211,2192,2121,2054,2010,1964,1850,1724,1642,1577,1411,1409,1332,1296,1265,1256,1220,1195,937,903,880,811,739,720,650,609,547,533,459,434,384,279,231,163,102,78,30,5,52,100,155,217,277,328,389,446,473,546,583,649,702,734,768,857,882,912,1043,1219,1243,1258,1290,1325,1359,1409,1567,1642,1679,1726,1873,1965,2017,2088,2172,2204,2226,2273,2288,2316,2434,2522,2558,2622,2678,2790,2933,2965,3025,3037,3071,3167,3180,3194,3233,3269,3282,3383,3387,3401,3465,3528,3595,3801,3910,4020,4078,4128,4213,4271,4295,4420,4472,4612,4663,4739,4845,4891,4980,5109,5241,5284,5335,5379,5388,5478,5546,5639,5705,5751,5766,5803,5855,5879,5975,6000,6024,6070,6093,6137,6156,6212,6256,6276,6304,6421,6441,6537,6614,6743,6844,6893,7087,7169,7183,7200,7237,7262,7352,7376,7398,7441,7491,7541,7564,7602,7656,7707,7814,7924,7940,7958,8014,8036,8048,8132,8141,8250,8279,8288,8321,8331,8374,8515,8655,8723,8807,8825,8878,8953,8990,9011,9077,9128,9172,9219,9276,9383,9420,9499,9535,9736,9744,9801,9900,9951,10038,10093,10119,10147,10265,10301,10314,10340,10456,10499,10564,10622,10767,10802,10876,10882,10997,11063,11217,11243,11276,11299,11314,11365,11407,11456,11587,11627,11705,11751,11792,11831,11901,12012,12118,12180,12240,12296,12385,12469,12473,12497,12503,12537,12578,12723,12778,12858,12901,12936,13020,13048,13136,13195,13232,13325,13377,13424,13493,13547,13564,13724,13856,13911,13938,14075,14151,14234,14300,14353,14395,14499,14507,14705,14724,14796,14802,14823,14858,14882,14905,14914,14936,14962,15049,15114,15161,15237,15272,15399,15565,15587,15666,15749,15778,15830,15843,15864,15928,16039,16075,16141,16163,16246,16315,16333,16389,16415,16526,16601,16650,16798,16845,16861,16991,17046,17090,17140,17178,17186,17292,17305,17343,17419,17456,17610,17617,17693,17728,17783,17909,17918,17970,18032,18083,18104,18114,18223,18296,18330,18363,18428,18496,18578,18660,18733,18782,18792,18861,18929,19069,19127,19184,19269,19279,19355,19394,19494,19539,19559,19599,19612,19643,19666,19745,19760,19815,19864,20012,20141,20231,20270,20330,20370,20380,20500,20595,20617,20690,20751,20811,20824,20843,20910,20925,21044,21126,21165,21198,21260,21280,21343,21467,21505,21531,21564,21640,21755,21817,21885,21929,22010,22103,22159,22196,22229,22270,22368,22414,22515,22570,22615,22630,22806,22864,22951,23030,23107,23155,23191,23226,23399,23438,23464,23487,23524,23559,23634,23667,23719,23747,23764,23869,23901,23936,24012,24022,24045,24074,24141,24185,24204,24272,24327,24452,24455,24490,24560,24615,24641,24734,24815,24890,24963,25025,25242,25282,25283,25414,25446,25475,25489,25527,25586,25636,25640,25771,25844,25848,25883,25923,26005,26048,26106,26157,26312,26359,26395,26429,26465,26491,26513,26558,26584,26601,26667,26770,26864,26900,26996,27118,27129,27176,27272,27313,27389,27478,27517,27580,27700,27761,27811,27844,27848,27967,28051,28108,28176,28264,28302,28332,28380,28525,28591,28617,28681,28727,28744,28874,28994,29047,29123,29221,29239,29274,29347,29493,29596,29668,29694,29717,29847,29871}, 508796209)]
    [InlineData(new int[] {29966,29916,29835,29792,29758,29621,29593,29438,29386,29336,29223,29143,29084,29047,28958,28898,28891,28798,28705,28682,28560,28446,28268,28204,28117,28009,27796,27711,27669,27606,27472,27329,27301,27295,27249,27185,27102,26993,26933,26769,26730,26604,26439,26437,26372,26314,26295,26182,26155,26110,26086,26051,25912,25858,25842,25785,25707,25585,25498,25443,25416,25388,25311,25303,25291,25255,25208,25166,25108,25011,24879,24860,24767,24732,24683,24550,24506,24407,24356,24303,24114,24103,24046,24017,23942,23855,23814,23804,23786,23735,23711,23693,23606,23558,23476,23391,23326,23313,23300,23225,23181,23170,23090,23067,23058,22985,22948,22846,22796,22771,22749,22581,22488,22353,22183,22151,22117,22078,22047,22011,21988,21943,21904,21884,21872,21842,21797,21785,21753,21628,21537,21525,21424,21366,21330,21257,21193,21113,21101,20969,20938,20838,20719,20649,20557,20521,20477,20432,20390,20362,20264,20190,20145,20095,20063,19924,19838,19730,19703,19691,19659,19582,19560,19542,19428,19412,19407,19395,19274,19160,19074,19050,18956,18927,18840,18663,18631,18593,18557,18473,18455,18373,18315,18238,18218,18188,18133,18060,18007,17984,17912,17854,17829,17712,17622,17577,17496,17481,17462,17434,17348,17227,17176,17156,17129,17028,16956,16879,16770,16712,16595,16475,16438,16399,16336,16149,16095,16067,16030,15994,15956,15943,15793,15760,15604,15570,15512,15500,15465,15431,15375,15335,15268,15226,15176,15130,15056,15041,15034,14999,14945,14829,14807,14655,14589,14431,14397,14316,14238,14192,14171,14151,14072,14051,14031,14006,13988,13921,13666,13540,13504,13474,13324,13208,13205,13189,13087,13000,12984,12954,12922,12903,12837,12781,12774,12741,12707,12585,12572,12544,12471,12373,12359,12315,12258,12166,12145,12099,12051,11974,11935,11903,11849,11794,11752,11686,11664,11540,11463,11430,11413,11369,11281,11234,11218,11159,11136,11121,11037,11004,10985,10855,10810,10701,10663,10646,10563,10536,10426,10385,10267,10241,10149,10047,10012,9950,9917,9850,9779,9748,9584,9568,9504,9490,9260,9129,9109,9109,9068,9018,8918,8881,8840,8780,8742,8666,8647,8629,8533,8512,8369,8226,8200,8166,8080,8041,8016,7982,7883,7788,7628,7511,7463,7454,7400,7351,7334,7260,7163,7061,7023,6980,6908,6889,6876,6797,6669,6649,6610,6574,6529,6410,6346,6263,6259,6240,6148,6068,6008,5882,5839,5791,5716,5687,5676,5652,5642,5614,5589,5577,5548,5478,5467,5431,5425,5395,5384,5307,5305,5291,5243,5203,5197,5177,5165,5106,5085,5040,4918,4889,4874,4819,4751,4719,4621,4588,4570,4486,4421,4402,4380,4344,4291,4246,4164,4127,4028,3943,3830,3717,3626,3575,3530,3522,3459,3412,3233,3168,3092,3001,2940,2879,2843,2833,2772,2707,2690,2503,2484,2326,2296,2247,2216,2170,2151,2109,2101,1837,1807,1779,1740,1654,1479,1458,1349,1312,1281,1141,1098,1093,1032,948,904,890,840,757,737,664,637,609,588,536,510,469,397,330,272,254,158,91,67,103,226,263,297,367,435,490,527,570,590,616,645,730,753,789,844,892,927,1029,1075,1097,1112,1221,1311,1319,1350,1463,1570,1739,1749,1793,1818,2061,2103,2135,2151,2193,2237,2263,2312,2369,2496,2586,2706,2729,2787,2838,2873,2930,2990,3007,3109,3170,3292,3443,3477,3525,3532,3620,3648,3815,3853,3966,4077,4153,4174,4290,4342,4376,4385,4414,4443,4507,4586,4609,4656,4747,4795,4836,4885,4916,5038,5060,5092,5133,5176,5197,5203,5215,5261,5302,5305,5346,5395,5422,5431,5443,5472,5501,5568,5580,5597,5640,5650,5662,5679,5713,5779,5815,5875,5900,6022,6088,6212,6255,6260,6268,6409,6525,6573,6599,6620,6668,6742,6858,6886,6904,6955,7012,7038,7126,7191,7311,7350,7353,7401,7462,7487,7586,7669,7842,7901,7990,8032,8054,8124,8189,8217,8359,8481,8531,8596,8636,8650,8735,8776,8782,8862,8887,8938,9067,9083,9109,9126,9211,9279,9503,9519,9574,9616,9755,9798,9852,9935,9962,10029,10100,10174,10255,10348,10410,10461,10561,10613,10663,10700,10782,10820,10970,11000,11023,11064,11133,11147,11191,11225,11264,11335,11382,11419,11436,11495,11634,11680,11745,11781,11806,11874,11922,11968,12002,12086,12142,12159,12199,12275,12326,12372,12438,12474,12548,12573,12688,12728,12768,12776,12811,12881,12921,12951,12980,12996,13040,13131,13191,13207,13280,13361,13500,13508,13622,13788,13963,14001,14027,14032,14056,14100,14160,14185,14233,14303,14333,14403,14503,14646,14725,14814,14889,14990,15010,15038,15045,15104,15166,15222,15240,15299,15343,15386,15433,15496,15510,15563,15601,15653,15765,15798,15950,15969,16002,16059,16082,16119,16173,16356,16407,16473,16507,16707,16725,16796,16934,16971,17046,17150,17166,17196,17298,17396,17453,17479,17485,17530,17581,17706,17777,17831,17858,17981,18007,18049,18125,18150,18200,18221,18245,18356,18452,18468,18550,18574,18594,18660,18667,18917,18933,18995,19054,19078,19241,19314,19399,19409,19419,19529,19559,19577,19625,19681,19697,19728,19831,19884,19967,20086,20144,20163,20220,20341,20364,20398,20442,20512,20551,20611,20696,20835,20906,20953,21055,21112,21146,21233,21278,21358,21368,21436,21532,21598,21659,21767,21793,21833,21844,21878,21896,21936,21979,22010,22017,22063,22082,22129,22172,22313,22433,22527,22662,22749,22791,22846,22868,22955,23003,23063,23087,23167,23171,23193,23281,23303,23319,23340,23447,23553,23587,23635,23711,23715,23749,23803,23807,23854,23896,23990,24027,24097,24111,24171,24306,24376,24457,24546,24555,24726,24746,24843,24864,24959,25055,25120,25201,25224,25260,25292,25306,25333,25399,25430,25449,25583,25677,25724,25833,25854,25910,25962,26070,26087,26124,26174,26235,26298,26357,26395,26439,26473,26638,26747,26911,26942,27046,27159,27199,27289,27300,27326,27451,27488,27655,27676,27722,27871,28011,28130,28224,28346,28496,28577,28682,28779,28808,28895,28900,29042,29080,29114,29194,29293,29338,29436,29472,29611,29725,29767,29801,29866,29937}, 410115402)]
    public void Case(int[] arr, int expec)
    {
        Assert.Equal(expec, SumMin(arr));
    }

    // Para melhorar a performance os dois for podem ser trocados por uma stack
    private static int SumMin(int[] arr)
    {
        if(arr.Length == 1) return arr[0];

        int sumMin = 0;
        int mod = (int)Math.Pow(10, 9) + 7;

        for (int i=0; i<arr.Length; i++)
        {
            int min = arr[i];
            sumMin += min;

            for (int j=i+1; j<arr.Length; j++)
            {
                min = Math.Min(min, arr[j]);
                sumMin += min;
            }

            sumMin %= mod;
        }

        return sumMin;
    }
}