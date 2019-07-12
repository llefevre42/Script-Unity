﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChutePieceBeginner : MonoBehaviour
{
    public GameObject HitGreen;
   public GameObject HitRed;
   public GameObject HitBlue;
    public AudioSource audioSource1;
   private GameObject MyGreen;
   private GameObject MyRed;
   private GameObject MyBlue;
   private double[] section;
   private double[] cuts;
   private double[] fx0;
   private double[] fx1;
   private int m;
    private int n;
   private float rand;

   void Awake()
    {
        fx0 = new double[] {
9.6768026351929,
10.728911399841,
11.794489860535,
12.860067367554,
13.897211074829,
14.95081615448,
15.724036216736,
15.998435020447,
17.041564941406,
17.810815811157,
18.08618927002,
19.141292572021,
19.909364700317,
20.185916900635,
21.236530303955,
22.011268615723,
22.285646438599,
23.318298339844,
24.089046478271,
24.367414474487,
25.403060913086,
26.172313690186,
26.453674316406,
27.499794006348,
28.269046783447,
28.54891204834,
29.592041015625,
30.346893310547,
30.63516998291,
32.718433380127,
33.749591827393,
34.514080047607,
34.783740997314,
35.842380523682,
36.603378295898,
36.872039794922,
37.915168762207,
38.944831848145,
39.980476379395,
40.740043640137,
41.014625549316,
42.065238952637,
42.825511932373,
43.106872558594,
44.16646194458,
44.925464630127,
45.202110290527,
46.224285125732,
47.01000213623,
47.28687286377,
48.303062438965,
49.32421875,
49.847549438477,
50.353401184082,
50.871223449707,
51.387550354004,
51.577617645264,
51.884422302246,
52.381675720215,
53.406463623047,
54.448524475098,
55.469276428223,
56.003059387207,
56.508911132812,
57.019248962402,
57.546051025391,
58.063877105713,
58.577209472656,
59.121971130371,
59.606872558594,
60.117210388184,
61.130409240723,
61.639251708984,
62.178024291992,
62.694351196289,
63.228637695312,
63.710540771484,
64.225372314453,
65.238571166992,
65.742919921875,
66.269729614258,
66.77864074707,
71.849594116211,
73.159118652344,
73.907958984375,
74.17081451416,
75.224418640137,
75.986511230469,
76.252586364746,
77.300201416016,
78.053581237793,
78.331359863281,
79.370002746582,
80.128776550293,
80.408638000488,
81.465240478516,
82.229682922363,
82.509864807129,
83.563468933105,
84.331832885742,
84.606597900391,
85.64673614502,
86.41512298584,
86.686874389648,
87.741973876953,
88.496757507324,
88.774627685547,
89.826736450195,
90.579528808594,
90.842926025391,
91.887550354004,
92.651588439941,
92.926193237305,
93.961837768555,
94.736755371094,
95.009460449219,
96.046600341797,
96.800888061523,
97.071769714355,
98.108909606934,
98.87092590332,
99.140068054199,
100.19816589355,
100.96142578125,
101.22932434082,
102.24401855469,
103.81843566895,
104.33027648926,
104.52632141113,
104.68496704102,
104.84108734131,
105.36196899414,
105.86931610107,
105.98006439209,
106.360206604,
107.38836669922,
108.44455718994,
109.22532653809,
109.49108886719,
110.00517272949,
111.03408050537,
111.54026794434,
112.08170318604,
112.59204101562,
113.1293182373,
113.35430908203,
113.6291809082,
114.14102172852,
114.64687347412,
115.16469573975,
115.66605377197,
116.200340271,
116.71816253662,
117.24226379395,
117.72836303711,
118.24918365479,
119.26836395264,
119.77870941162,
120.30999755859,
120.80537414551,
124.49897766113,
125.28469848633,
128.63557434082,
129.1623840332,
129.4153137207,
130.162109375,
130.93585205078,
132.24537658691,
132.76469421387,
133.27026367188,
134.29927062988,
134.83036804199,
135.85366821289,
136.36700439453,
136.90428161621,
137.40148925781,
137.93394470215,
138.43530273438,
138.94415283203,
139.97232055664,
140.49516296387,
141.02645874023,
141.53680419922,
142.07258605957,
142.56646728516,
143.08728027344,
144.11094665527,
144.61531066895,
145.13208007812,
145.65245056152,
146.17176818848,
146.67163085938,
147.19844055176,
147.6788482666,
148.18930053711,
148.71299743652,
149.24084472656,
149.74938964844,
150.27410888672,
150.76931762695,
151.27517700195,
152.31829833984,
152.83462524414,
153.87026977539,
154.39558410645,
154.88945007324,
155.40129089355,
155.91014099121,
156.42646789551,
157.97694396973,
158.50224304199,
158.98031616211,
159.50346374512,
160.50619506836,
161.01953125,
161.53584289551,
162.04618835449,
164.07557678223,
165.12498474121,
165.67694091797,
166.18428039551,
166.70959472656,
167.2004699707,
167.70333862305,
168.20768737793,
168.72850036621,
169.24781799316,
169.76713562012,
170.28497314453,
170.82524108887,
171.03186035156,
171.2936706543,
171.82646179199,
172.84115600586,
173.34851074219,
173.8708190918,
174.39013671875,
174.93640136719,
175.41081237793,
175.91665649414,
176.94033813477,
177.42758178711,
178.98918151855,
179.29150390625
 };
        fx1 = new double[] {10.204239845276,
11.265623092651,
12.323763847351,
13.380362510681,
14.435577392578,
15.466552734375,
16.512676239014,
17.552833557129,
18.606506347656,
19.664581298828,
20.70453453064,
21.753400802612,
22.795169830322,
23.834035873413,
25.927822113037,
26.982902526855,
28.029026031494,
29.066009521484,
30.107913970947,
31.155647277832,
32.191291809082,
33.223697662354,
34.265419006348,
35.308753967285,
36.358207702637,
37.392539978027,
38.427890777588,
39.459136962891,
40.490112304688,
41.528774261475,
42.578048706055,
43.634830474854,
44.668640136719,
45.717800140381,
46.7536277771,
47.787414550781,
48.80387878418,
49.31258392334,
51.632606506348,
51.870338439941,
52.140045166016,
52.390907287598,
52.663673400879,
52.935962677002,
53.93872833252,
54.973014831543,
55.990474700928,
56.501678466797,
58.05997467041,
59.097366333008,
60.111221313477,
61.117073059082,
62.162223815918,
63.196441650391,
64.202651977539,
65.224395751953,
66.259994506836,
67.294357299805,
67.559387207031,
71.394195556641,
73.65845489502,
74.698524475098,
75.740135192871,
76.78190612793,
77.80689239502,
78.850112915039,
79.884376525879,
80.927276611328,
81.979362487793,
83.028663635254,
84.080451965332,
85.122016906738,
86.165534973145,
87.210021972656,
88.250366210938,
89.288642883301,
90.330520629883,
91.361701965332,
92.412200927734,
93.449432373047,
94.476211547852,
95.513175964355,
96.544448852539,
97.58757019043,
98.624786376953,
99.673919677734,
100.70192718506,
101.72861480713,
102.76741027832,
104.34301757812,
104.85635375977,
105.34551239014,
105.60845947266,
105.85968017578,
106.10548400879,
106.37551116943,
106.87172698975,
107.94174957275,
108.96841430664,
109.99022674561,
111.07419586182,
112.07865905762,
113.10794067383,
114.11977386475,
115.15940856934,
116.24764251709,
117.2218170166,
118.23943328857,
119.25589752197,
120.30362701416,
121.33918762207,
121.60256195068,
123.97929382324,
124.7557144165,
125.53426361084,
128.12306213379,
128.90841674805,
129.67680358887,
130.42639160156,
131.23167419434,
131.74342346191,
132.75947570801,
133.79095458984,
134.818359375,
135.8244934082,
136.88729858398,
137.90950012207,
138.93464660645,
139.96258544922,
141.00904846191,
142.05699157715,
143.07431030273,
144.08963012695,
145.14625549316,
146.15283203125,
147.17704772949,
147.66452026367,
148.19216918945,
149.24517822266,
150.25993347168,
151.28079223633,
153.34315490723,
154.37417602539,
155.39633178711,
156.41178894043,
157.45364379883,
158.47480773926,
159.49394226074,
160.49954223633,
161.52496337891,
162.54530334473,
162.83276367188,
165.64936828613,
166.67875671387,
167.7013092041,
168.71142578125,
169.75764465332,
170.78871154785,
171.80424499512,
172.82501220703,
173.88244628906,
174.90408325195,
175.90618896484,
176.91564941406,
178.49035644531};
        audioSource1.Play();
    }
    void Update()
    {
        if( m < fx0.Length && (audioSource1.time + 1.7 > fx0[m]))
        {
            MyGreen = (GameObject)Instantiate(HitGreen, new Vector2( -3.0f , 5.33f ), Quaternion.identity);
            m++;
        }
        if( n < fx1.Length && (audioSource1.time + 1.7 > fx1[n]))
        {
            MyRed = (GameObject)Instantiate(HitRed, new Vector2( 0.0f , 5.33f ), Quaternion.identity);
            n++;
        }  
    }
}