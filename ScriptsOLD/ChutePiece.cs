﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChutePiece : MonoBehaviour
{
   public GameObject HitGreen;
   public GameObject HitRed;
   public GameObject HitBlue;
   public GameObject HitYellow;
   public GameObject HitSpace;
   public AudioSource audioSource;
   public GameObject Spot1;
   public GameObject Spot2;
   private GameObject MyGreen;
   private GameObject MyRed;
   private GameObject MyBlue;
   private GameObject MyYellow;
   private GameObject Myspace;
   private GameObject MySpot1;
   private GameObject MySpot2;
   private double[] section;
   private double[] cuts;
   private double[] fx0;
   private double[] fx1;
   private int retardateur;
   private int i;
   private int m;
   private int j;
   private int k;
   private int h;

   void Awake()
    {
    section = new double[] 
    {
         0,10,10,20,20,30,30,40,40,50,50,60,60,70,70,80,80,90,90,100,100,110,110,120,120,130,130,140,140,150,150,160,160,170,170,180,180,190,190,200,200,210
    };
    cuts = new double[]
    {
        0.47501134872437,
        1.8761224746704,
        3.2823581695557,
        4.6849207878113,
        6.0909752845764,
        7.5011110305786,
        8.9073696136475,
        10.313605308533,
        11.719863891602,
        13.125827789307,
        14.638412475586,
        15.038413047791,
        15.50036239624,
        15.996734619141,
        16.46555519104,
        16.934150695801,
        17.381246566772,
        17.849977493286,
        18.340476989746,
        18.809116363525,
        19.256416320801,
        19.746711730957,
        20.215578079224,
        20.684104919434,
        21.131269454956,
        21.621654510498,
        22.090454101562,
        22.538414001465,
        23.02795791626,
        23.475078582764,
        23.965578079224,
        24.412675857544,
        24.881427764893,
        25.350158691406,
        25.818866729736,
        26.287687301636,
        26.756416320801,
        27.246757507324,
        27.715534210205,
        28.184286117554,
        28.631269454956,
        29.121677398682,
        29.568593978882,
        30.037483215332,
        30.506303787231,
        30.975078582764,
        31.465442657471,
        31.912607192993,
        32.381271362305,
        32.871700286865,
        33.318820953369,
        33.787528991699,
        34.256301879883,
        34.746643066406,
        35.225009918213,
        35.675010681152,
        36.12548828125,
        36.600135803223,
        37.062992095947,
        37.520587921143,
        38.00634765625,
        38.469253540039,
        38.943832397461,
        39.406734466553,
        39.87548828125,
        40.350158691406,
        40.818912506104,
        41.287574768066,
        41.756370544434,
        42.224987030029,
        42.687957763672,
        43.175010681152,
        43.631404876709,
        44.094215393066,
        44.551837921143,
        45.03759765625,
        46.437595367432,
        47.884536743164,
        49.237594604492,
        50.637596130371,
        52.03759765625,
        53.443176269531,
        54.845443725586,
        56.256847381592,
        58.141609191895,
        59.559661865234,
        60.9807472229,
        62.377666473389,
        63.785942077637,
        65.164443969727,
        66.570297241211,
        67.96875,
        70.075012207031,
        71.425010681152,
        72.792404174805,
        74.125015258789,
        75.525009155273,
        76.925804138184,
        78.325012207031,
        79.72501373291,
        81.125015258789,
        82.525009155273,
        83.925010681152,
        85.332809448242,
        86.738388061523,
        88.147392272949,
        89.548164367676,
        90.875015258789,
        92.231315612793,
        93.799003601074,
        94.299957275391,
        94.76863861084,
        95.237487792969,
        95.706260681152,
        96.174942016602,
        96.643676757812,
        97.112449645996,
        97.581199645996,
        98.049934387207,
        98.51863861084,
        98.987487792969,
        99.456260681152,
        99.924942016602,
        100.39367675781,
        100.86242675781,
        101.32299804688,
        101.79995727539,
        102.26863861084,
        102.73748779297,
        103.20623779297,
        103.6749420166,
        104.14367675781,
        104.612449646,
        105.29106903076,
        106.65483093262,
        108.04106903076,
        109.44644165039,
        110.85272216797,
        112.258934021,
        113.66523742676,
        114.99281311035,
        115.54106140137,
        116.94641876221,
        118.35272216797,
        120.59481048584,
        121.46746063232,
        122.38018035889,
        123.95677947998,
        124.44637298584,
        124.91516876221,
        126.32147216797,
        126.79013824463,
        128.19644165039,
        128.6651763916,
        130.07141113281,
        130.54013061523,
        131.94635009766,
        132.39460754395,
        133.80079650879,
        134.21159362793,
        134.61245727539,
        135.08117675781,
        135.54988098145,
        140.12870788574,
        141.55351257324,
        143.4554901123,
        144.8519744873,
        146.25546264648,
        147.6478729248,
        148.97500610352,
        150.38357543945,
        151.80618286133,
        153.12501525879,
        154.47500610352,
        155.89485168457,
        157.30657958984,
        158.6586151123,
        160.00135803223,
        161.32501220703,
        162.69219970703,
        164.11639404297,
        165.47500610352,
        166.87838745117,
        168.28611755371,
        169.69186401367,
        171.09689331055,
        172.50143432617,
        175.02688598633,
        179.06768798828,
        183.04833984375,
        188.11791992188,
        188.52207946777,
        188.98748779297,
        189.45625305176,
        189.9249420166,
        190.46160888672,
        190.87208557129,
        191.33120727539,
        191.79992675781,
        192.26864624023,
        192.73748779297,
        193.20623779297,
        193.6749420166,
        194.21159362793,
        194.62208557129,
        195.07301330566,
        195.54997253418,
        196.01866149902,
        196.48748779297,
        196.95625305176,
        197.4249420166,
        197.96160888672,
        198.37208557129,
        198.83120727539,
        199.29992675781,
        199.76864624023,
        200.23748779297,
        200.70620727539,
        201.17489624023,
        201.70193481445,
        203.03465270996,
        203.51860046387,
        203.97927856445,
        204.49085998535,
        204.99291992188,
        205.51953125,
        206.00895690918,
        207.41522216797,
        207.90481567383,
        208.35272216797,
        208.82136535645,
        209.27209472656,
        209.82150268555,
        210.29011535645,
        210.88203430176,
        211.47927856445,
        212.10264587402,
        213.50886535645,
        214.10725402832,
        215.47500610352,
        216.07528686523,
        217.7066192627,
        218.19625854492,
        218.64448547363,
        218.99990844727,
        219.45602416992,
        219.9248046875,
        220.3935546875,
        220.84730529785,
        221.27508544922,
        221.74378967285,
        222.17343139648,
        222.58981323242,
        222.96766662598,
        223.41499328613,
        223.82131958008,
        224.29006958008,
        225.2483215332,
        225.69630432129,
        226.14443969727,
        226.49990844727,
        226.95620727539,
        227.42474365234,
        228.36239624023,
        228.83106994629,
        229.29983520508,
        229.74723815918,
        230.18132019043,
        230.60000610352,
        231.04991149902,
        231.48498535156,
        231.81269836426,
        232.22708129883,
        232.59991455078,
        233.04991149902,
        233.50337219238,
        233.97215270996,
        234.44088745117,
        234.90960693359,
        235.37838745117,
        235.84712219238,
        236.31585693359,
        236.78460693359,
        237.25340270996,
        237.72213745117,
        238.19085693359,
        238.6595916748,
        239.12838745117,
        239.59704589844,
        240.06591796875,
        240.53462219238,
        241.00341796875,
        241.47213745117,
        241.94090270996,
        242.4095916748,
        242.87841796875,
        243.34713745117,
        243.81588745117,
        244.28462219238,
        244.75340270996,
        245.65045166016,
        247.05046081543,
        248.45045471191,
        249.85046386719,
        251.25088500977,
        252.65643310547,
        254.0627746582,
        255.47003173828,
        256.87612915039,
        258.28234863281,
        259.6877746582,
        261.09628295898,
        262.50085449219,
        263.90710449219,
        265.31338500977,
        266.71960449219,
        268.60046386719,
        270.00088500977,
        271.40710449219,
        272.81338500977,
        274.21960449219,
        275.62588500977,
        277.03140258789,
        278.40045166016
    };
    fx0 = new double[]
    {
        14.880475997925,
        15.081020355225,
        15.5494556427,
        16.016395568848,
        16.956258773804,
        17.424694061279,
        17.891632080078,
        18.360067367554,
        19.299932479858,
        19.768367767334,
        20.235305786133,
        20.703741073608,
        21.643606185913,
        22.112041473389,
        22.342517852783,
        22.578979492188,
        23.047414779663,
        23.987277984619,
        24.455715179443,
        25.862518310547,
        26.330951690674,
        26.797891616821,
        27.266326904297,
        27.734762191772,
        28.206190109253,
        28.674625396729,
        29.141563415527,
        29.373537063599,
        29.610000610352,
        29.853946685791,
        30.078435897827,
        30.549863815308,
        31.018299102783,
        31.485239028931,
        31.953674316406,
        32.893539428711,
        33.361972808838,
        33.828910827637,
        34.297348022461,
        35.234218597412,
        35.704151153564,
        36.172584533691,
        36.641021728516,
        37.109455108643,
        37.341426849365,
        37.577892303467,
        38.047824859619,
        38.516258239746,
        38.98469543457,
        39.453128814697,
        39.921566009521,
        40.391494750977,
        40.859931945801,
        41.328369140625,
        41.796802520752,
        42.268230438232,
        42.735168457031,
        43.203605651855,
        43.67204284668,
        44.140476226807,
        44.382926940918,
        44.611904144287,
        44.861835479736,
        93.892990112305,
        94.166870117188,
        94.37190246582,
        95.700881958008,
        96.073539733887,
        96.236663818359,
        97.109184265137,
        97.918846130371,
        98.111907958984,
        98.984420776367,
        99.452857971191,
        99.824012756348,
        100.85966491699,
        101.70074462891,
        101.86238098145,
        102.73489379883,
        103.20333862305,
        103.57598876953,
        104.6071472168,
        105.41884613037,
        105.61190795898,
        106.48442077637,
        106.95285797119,
        107.32401275635,
        107.48714447021,
        107.79244995117,
        108.22945404053,
        109.36387634277,
        109.6676864624,
        109.83081817627,
        110.30973052979,
        111.07598876953,
        112.1071395874,
        112.47979736328,
        112.64292907715,
        112.91680145264,
        113.12183380127,
        113.41966247559,
        114.82347106934,
        115.45802307129,
        115.85911560059,
        116.39340209961,
        116.69870758057,
        116.86183929443,
        118.26863861084,
        118.5739440918,
        119.20551300049,
        119.60958862305,
        119.97924804688,
        123.8928604126,
        124.20115661621,
        124.66959381104,
        125.13653564453,
        125.60496520996,
        126.07340240479,
        126.54183959961,
        126.70497131348,
        127.01326751709,
        127.17639160156,
        127.48170471191,
        127.64333343506,
        127.94863891602,
        128.41708374023,
        128.58020019531,
        128.88551330566,
        129.05163574219,
        129.51856994629,
        129.82388305664,
        130.29231262207,
        130.7607421875,
        131.22918701172,
        131.39231872559,
        131.69911193848,
        132.1675567627,
        132.63598632812,
        132.79911804199,
        133.26754760742,
        133.57585144043,
        134.04278564453,
        134.2059173584,
        134.51123046875,
        134.67434692383,
        134.94822692871,
        135.14279174805,
        135.45108032227,
        135.91952514648,
        136.38645935059,
        136.54959106445,
        136.8549041748,
        187.94836425781,
        188.11448669434,
        188.98251342773,
        189.82360839844,
        190.85925292969,
        191.69883728027,
        191.86196899414,
        192.73449707031,
        193.20292663574,
        193.5740814209,
        194.60972595215,
        195.45082092285,
        195.61395263672,
        196.48497009277,
        197.32604980469,
        197.4861907959,
        198.35720825195,
        199.16687011719,
        199.37190246582,
        200.23245239258,
        200.76823425293,
        201.07353210449,
        201.23666381836,
        201.51054382324,
        201.97897338867,
        203.12237548828,
        203.4201965332,
        203.58033752441,
        204.05177307129,
        204.52020263672,
        204.82400512695,
        205.45558166504,
        205.85966491699,
        206.22932434082,
        206.39245605469,
        206.70074462891,
        206.86238098145,
        207.33081054688,
        207.80972290039,
        208.57598876953,
        209.6071472168,
        210.54400634766,
        211.01544189453,
        211.48237609863,
        211.95082092285,
        212.41925048828,
        213.35911560059,
        217.91680908203,
        218.0470123291,
        218.51544189453,
        218.98237609863,
        219.45082092285,
        219.92224121094,
        220.39068603516,
        220.85911560059,
        221.32604980469,
        221.79449462891,
        222.26591491699,
        222.73435974121,
        223.20278930664,
        223.66972351074,
        224.13816833496,
        224.60958862305,
        225.07803344727,
        225.54496765137,
        226.0133972168,
        226.48483276367,
        226.9532623291,
        227.42169189453,
        227.88864135742,
        228.35707092285,
        228.82850646973,
        229.29693603516,
        229.76538085938,
        230.23231506348,
        232.56851196289,
        233.03694152832,
        233.50836181641,
        233.97680664062,
        234.44523620605,
        234.91217041016,
        235.38360595703,
        235.85203552246,
        236.32048034668,
        236.78890991211,
        237.25584411621,
        237.72727966309,
        238.19570922852,
        238.66415405273,
        239.13108825684,
        239.59951782227,
        240.07095336914,
        240.53938293457,
        241.00782775879,
        241.47476196289,
        241.94319152832,
        242.4146270752,
        242.88305664062,
        243.35150146484,
        243.81843566895,
        244.28985595703,
        244.75830078125,
        245.22673034668
    };
    fx1 = new double[]
    {
        14.564762115479,
        14.878979682922,
        15.016666412354,
        15.489591598511,
        15.958072662354,
        16.426826477051,
        16.895532608032,
        17.360340118408,
        17.833265304565,
        18.301836013794,
        18.770498275757,
        19.239318847656,
        19.704013824463,
        20.17693901062,
        20.645532608032,
        21.114286422729,
        21.579252243042,
        22.047687530518,
        22.520612716675,
        22.989318847656,
        23.458118438721,
        23.922924041748,
        24.395851135254,
        24.864284515381,
        25.333015441895,
        25.801792144775,
        26.266597747803,
        26.739524841309,
        27.208072662354,
        27.676826477051,
        28.145532608032,
        28.610271453857,
        29.083198547363,
        29.551792144775,
        30.020500183105,
        30.489364624023,
        30.953945159912,
        31.426870346069,
        31.895532608032,
        32.364288330078,
        32.82918548584,
        33.302108764648,
        33.770545959473,
        34.23934173584,
        34.708072662354,
        35.169864654541,
        35.638298034668,
        36.106735229492,
        36.578163146973,
        37.046600341797,
        37.513538360596,
        37.981971740723,
        38.450408935547,
        38.921836853027,
        39.390274047852,
        39.85721206665,
        40.325645446777,
        40.794082641602,
        41.265510559082,
        41.733943939209,
        42.200885772705,
        42.666328430176,
        43.137756347656,
        43.609184265137,
        44.076122283936,
        44.544555664062,
        93.776260375977,
        94.244689941406,
        96.119934082031,
        97.99666595459,
        99.87190246582,
        101.74714660645,
        103.61938476562,
        109.24714660645,
        109.74147033691,
        113.49147033691,
        123.77911376953,
        125.67897796631,
        133.17895507812,
        135.05397033691,
        136.46025085449,
        202.07327270508,
        202.99667358398,
        203.49147033691,
        205.36645507812,
        205.83522033691,
        207.24147033691,
        209.58522033691,
        210.49462890625,
        210.96305847168,
        212.36985778809,
        212.8383026123,
        213.30673217773,
        217.52618408203,
        217.99462890625,
        218.46305847168,
        218.93449401855,
        219.40292358398,
        219.86985778809,
        220.3383026123,
        220.80673217773,
        221.27816772461,
        221.74659729004,
        222.21353149414,
        222.68197631836,
        223.15339660645,
        223.62184143066,
        224.08877563477,
        224.5572052002,
        225.02565002441,
        225.4970703125,
        225.96551513672,
        226.43244934082,
        226.90087890625,
        227.36932373047,
        227.84074401855,
        228.30918884277,
        228.77612304688,
        229.2445526123,
        229.71299743652,
        230.18441772461,
        232.52809143066,
        232.99502563477,
        233.46347045898,
        233.93190002441,
        234.40333557129,
        234.87176513672,
        235.33871459961,
        235.80714416504,
        236.27557373047,
        236.74700927734,
        237.21543884277,
        237.68237304688,
        238.15081787109,
        238.61924743652,
        239.0906829834,
        239.55911254883,
        240.02606201172,
        240.49449157715,
        240.96292114258,
        241.43435668945,
        241.90129089355,
        242.36972045898,
        242.8381652832,
        243.30960083008,
        243.77803039551,
        244.24496459961,
        244.71340942383,
        245.18183898926
    };

    }
    void Update()
    {
        if ((m + 5 < cuts.Length) &&  (cuts[m + 4] - ((cuts[m] + cuts[m + 1] + cuts[m + 2] + cuts[m + 3] + cuts[m + 4]) / 5) < 1 ) && retardateur == 0)
        {
             StartCoroutine(MakeSpot());
            retardateur = 5;
        }
        if( h < section.Length && audioSource.time + 1.7 > section[h])
        {
            Myspace = (GameObject)Instantiate(HitSpace, new Vector2(0 , 5.33f ), Quaternion.identity);
            h += 2;
        }
        if( m < cuts.Length && audioSource.time + 1.7 > cuts[m])
        {
            MyGreen = (GameObject)Instantiate(HitGreen, new Vector2( -2.12f , 5.33f ), Quaternion.identity);
            m++;
            if(retardateur > 0)
            retardateur--;
        }
        if( i < fx0.Length && audioSource.time + 1.7 > fx0[i])
        {
            MyRed = (GameObject)Instantiate(HitRed, new Vector2( -0.7f , 5.33f ), Quaternion.identity);
            i++;
        }
         if( j < fx1.Length && audioSource.time + 1.7 > fx1[j])
        {
            MyBlue = (GameObject)Instantiate(HitBlue, new Vector2( 0.7f , 5.33f ), Quaternion.identity);
            j++;
        }
        if( k < fx0.Length && audioSource.time + 1.7 > fx0[k])
        {
            MyYellow = (GameObject)Instantiate(HitYellow, new Vector2( 2.12f , 5.33f ), Quaternion.identity);
            k++;
        }
    }
     IEnumerator MakeSpot()
     {
        yield return new WaitForSeconds(1.7f);
        MySpot1 = (GameObject)Instantiate(Spot1, new Vector3(2.99f , 4.91f, - 5 ), Spot1.transform.rotation);
        MySpot2 = (GameObject)Instantiate(Spot2, new Vector3(-2.99f , 4.91f, -5 ), Spot2.transform.rotation);
     }
}
