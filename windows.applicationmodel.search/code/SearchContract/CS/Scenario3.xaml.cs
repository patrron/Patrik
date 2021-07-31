//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

using SDKTemplate;

using System;
using Windows.ApplicationModel.Search;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace SearchContract
{
    public sealed partial class Scenario3 : SDKTemplate.Common.LayoutAwarePage
    {
        private SearchPane searchPane;

        private static readonly string[] suggestionList =
            {
                "特別区部", "横浜市", "大阪市", "名古屋市", "札幌市", "神戸市", "京都市", "福岡市", "川崎市", "さいたま市",
                "広島市", "仙台市", "北九州市", "千葉市", "世田谷区", "堺市", "新潟市", "浜松市", "熊本市", "相模原市", "練馬区", "静岡市", "岡山市",
                "大田区", "足立区", "江戸川区", "船橋市", "鹿児島市", "八王子市", "杉並区", "姫路市", "板橋区", "松山市", "宇都宮市", "東大阪市",
                "川口市", "松戸市", "西宮市", "倉敷市", "市川市", "大分市", "金沢市", "福山市", "江東区", "尼崎市", "長崎市", "葛飾区", "町田市",
                "富山市", "豊田市", "高松市", "横須賀市", "岐阜市", "藤沢市", "枚方市", "柏市", "宮崎市", "豊中市", "長野市", "豊橋市", "一宮市",
                "岡崎市", "高崎市", "和歌山市", "奈良市", "品川区", "高槻市", "吹田市", "旭川市", "高知市", "川越市", "いわき市", "所沢市", "前橋市",
                "郡山市", "大津市", "北区", "越谷市", "新宿区", "秋田市", "那覇市", "中野区", "四日市市", "春日井市", "久留米市", "青森市", "盛岡市",
                "福島市", "明石市", "津市", "豊島区", "長岡市", "下関市", "市原市", "函館市", "茨木市", "水戸市", "目黒区", "八尾市", "加古川市", "福井市",
                "徳島市", "佐世保市", "平塚市", "府中市", "山形市", "富士市", "墨田区", "草加市", "松本市", "呉市", "寝屋川市", "佐賀市", "八戸市", "春日部市",
                "茅ヶ崎市", "大和市", "宝塚市", "厚木市", "上尾市", "調布市", "太田市", "つくば市", "伊勢崎市", "文京区", "港区", "渋谷区", "荒川区", "上越市",
                "熊谷市", "沼津市", "鈴鹿市", "岸和田市", "甲府市", "小田原市", "鳥取市", "山口市", "西東京市", "伊丹市", "松江市", "日立市", "東広島市", "八千代市",
                "宇治市", "小平市", "三鷹市", "和泉市", "弘前市", "豊川市", "釧路市", "立川市", "日野市", "安城市", "高岡市", "台東区", "鎌倉市", "宇部市", "苫小牧市",
                "佐倉市", "秦野市", "都城市", "磐田市", "松阪市", "帯広市", "今治市", "西尾市", "浦安市", "小山市", "習志野市", "流山市", "大垣市", "石巻市", "上田市",
                "新座市", "ひたちなか市", "川西市", "狭山市", "野田市", "足利市", "久喜市", "東村山市", "入間市", "周南市", "米子市", "多摩市", "小牧市", "守口市",
                "刈谷市", "各務原市", "尾道市", "深谷市", "岩国市", "出雲市", "焼津市", "土浦市", "古河市", "藤枝市", "諫早市", "桑名市", "栃木市", "青梅市",
                "武蔵野市", "鶴岡市", "稲沢市", "大崎市", "我孫子市", "八代市", "瀬戸市", "富士宮市", "小樽市", "飯塚市", "三郷市", "延岡市", "草津市", "門真市",
                "伊勢市", "沖縄市", "箕面市", "朝霞市", "木更津市", "座間市", "成田市", "海老名市", "霧島市", "大東市", "唐津市", "会津若松市", "北見市", "橿原市",
                "別府市", "奥州市", "松原市", "長浜市", "江別市", "大牟田市", "戸田市", "中央区", "新居浜市", "桐生市", "佐野市", "国分寺市", "鴻巣市", "富田林市",
                "小金井市", "半田市", "一関市", "生駒市", "那須塩原市", "羽曳野市", "うるま市", "防府市", "東久留米市", "掛川市", "東近江市", "加須市", "三田市",
                "廿日市市", "多治見市", "河内長野市", "昭島市", "西条市", "彦根市", "三島市", "酒田市", "白山市", "丸亀市", "浦添市", "取手市", "筑西市", "小松市",
                "鎌ケ谷市", "東海市", "春日市", "富士見市", "津山市", "ふじみ野市", "飯田市", "鹿屋市", "池田市", "鹿沼市", "三条市", "坂戸市", "花巻市", "新発田市",
                "伊勢原市", "泉佐野市", "佐久市", "三原市", "島田市", "筑紫野市", "江南市", "薩摩川内市", "糸島市", "横手市", "可児市", "伊賀市", "安曇野市", "宗像市",
                "大野城市", "神栖市", "室蘭市", "高砂市", "千歳市", "射水市", "芦屋市", "北上市", "茂原市", "高山市", "甲賀市", "亀岡市", "坂井市", "宜野湾市", "柏崎市",
                "関市", "貝塚市", "大村市", "岩見沢市", "東松山市", "日光市", "四国中央市", "米沢市", "君津市", "天草市", "御殿場市", "大和郡山市", "舞鶴市", "大仙市",
                "印西市", "四街道市", "あま市", "行田市", "越前市", "豊岡市", "大府市", "由利本荘市", "袋井市", "稲城市", "知多市", "中津市", "宇和島市", "日進市",
                "登米市", "摂津市", "飯能市", "渋川市", "綾瀬市", "東大和市", "八潮市", "香取市", "真岡市", "蒲郡市", "本庄市", "燕市", "近江八幡市", "牛久市",
                "北名古屋市", "尾張旭市", "三木市", "中津川市", "あきる野市", "和光市", "たつの市", "龍ケ崎市", "名張市", "城陽市", "長岡京市", "石岡市", "福知山市",
                "笠間市", "須賀川市", "田辺市", "大館市", "狛江市", "館林市", "交野市", "大田原市", "泉大津市", "佐伯市", "守山市", "阿南市", "国立市", "香芝市",
                "犬山市", "栗原市", "柏原市", "姶良市", "桶川市", "八幡市", "清瀬市", "甲斐市", "気仙沼市", "八街市", "名取市", "南アルプス市", "碧南市", "加賀市",
                "蕨市", "伊東市", "柳川市", "伊那市", "日田市", "南相馬市", "笛吹市", "太宰府市", "行橋市", "銚子市", "武蔵村山市", "鶴ヶ島市", "木津川市", "豊明市",
                "志木市", "玉名市", "恵庭市", "天理市", "旭市", "鳥栖市", "八女市", "北本市", "三豊市", "大和高田市", "知立市", "藤岡市", "京田辺市", "丹波市", "敦賀市",
                "塩尻市", "鯖江市", "羽島市", "秩父市", "村上市", "橋本市", "総社市", "藤井寺市", "十和田市", "伊達市", "鹿嶋市", "清須市", "紀の川市", "常総市",
                "吉川市", "津島市", "愛西市", "白河市", "山陽小野田市", "玉野市", "泉南市", "田原市", "栗東市", "蓮田市", "日向市", "多賀城市", "佐渡市", "観音寺市",
                "守谷市", "天童市", "千曲市", "宇城市", "東金市", "浜田市", "南魚沼市", "鳴門市", "むつ市", "安中市", "鳩ヶ谷市", "土岐市", "北広島市", "袖ケ浦市",
                "白井市", "名護市", "桜井市", "みよし市", "湖西市", "二本松市", "福生市", "高石市", "下野市", "石狩市", "宮古市", "能代市", "京丹後市", "宇佐市",
                "十日町市", "小郡市", "五所川原市", "逗子市", "大阪狭山市", "古賀市", "七尾市", "日南市", "直方市", "四條畷市", "日高市", "糸満市", "豊見城市",
                "伊万里市", "羽村市", "阪南市", "三次市", "塩竈市", "茅野市", "朝倉市", "常陸太田市", "羽生市", "坂東市", "山武市", "坂出市", "出水市", "福津市",
                "山鹿市", "荒尾市", "下松市", "合志市", "常滑市", "海南市", "美濃加茂市", "南砺市", "志摩市", "湖南市", "五泉市", "裾野市", "向日市", "笠岡市",
                "那珂市", "幸手市", "萩市", "恵那市", "さぬき市", "光市", "岩出市", "岡谷市", "結城市", "高島市", "喜多方市", "小美玉市", "須坂市", "富岡市", "宮古島市",
                "瑞穂市", "みどり市", "氷見市", "登別市", "沼田市", "諏訪市", "富里市", "亀山市", "湯沢市", "日置市", "倉吉市", "武雄市", "富士吉田市", "田川市",
                "赤穂市", "南島原市", "菊池市", "鉾田市", "益田市", "野洲市", "新城市", "南あわじ市", "小野市", "南国市", "砺波市", "館山市", "伊豆の国市", "牧之原市",
                "真庭市", "能美市", "筑後市", "三浦市", "小林市", "富津市", "加西市", "北斗市", "糸魚川市", "島原市", "岩倉市", "洲本市", "雲仙市", "大洲市", "千代田区",
                "菊川市", "北茨城市", "石垣市", "稲敷市", "北杜市", "淡路市", "東根市", "奄美市", "桜川市", "いなべ市", "中野市", "阿賀野市", "常陸大宮市", "小城市",
                "下妻市", "魚津市", "さくら市", "郡上市", "つくばみらい市", "指宿市", "中間市", "岩沼市", "吉野川市", "小諸市", "高浜市", "井原市", "南足柄市",
                "かすみがうら市", "赤磐市", "弥富市", "篠山市", "滝川市", "東松島市", "西脇市", "嘉麻市", "府中市", "寒河江市", "南房総市", "西予市", "雲南市",
                "見附市", "黒部市", "安来市", "臼杵市", "三沢市", "網走市", "いすみ市", "宍粟市", "大船渡市", "みやま市", "小松島市", "五島市", "田村市", "瑞浪市",
                "魚沼市", "庄原市", "加東市", "米原市", "匝瑳市", "南城市", "稚内市", "熱海市", "釜石市", "豊後大野市", "阿波市", "曽於市", "南九州市", "新庄市",
                "南さつま市", "小千谷市", "八幡浜市", "長門市", "大田市", "伊予市", "海津市", "瀬戸内市", "備前市", "相馬市", "宇土市", "行方市", "大川市", "白石市",
                "つがる市", "久慈市", "山梨市", "北秋田市", "下呂市", "伊達市", "黒石市", "浅口市", "四万十市", "葛城市", "綾部市", "鴨川市", "人吉市", "妙高市",
                "矢板市", "大野市", "東温市", "南丹市", "境港市", "本巣市", "高梁市", "平戸市", "柳井市", "由布市", "御前崎市", "かほく市", "鹿角市", "五條市",
                "潟上市", "対馬市", "宇陀市", "伊豆市", "甲州市", "新見市", "上山市", "香南市", "善通寺市", "平川市", "駒ヶ根市", "滑川市", "南陽市", "東かがわ市",
                "都留市", "志布志市", "神埼市", "朝来市", "西都市", "美馬市", "韮崎市", "男鹿市", "杵築市", "小矢部市", "国東市", "うきは市", "本宮市", "安芸高田市",
                "新宮市", "胎内市", "小浜市", "角田市", "中央市", "西海市", "相生市", "いちき串木野市", "高萩市", "鹿島市", "東御市", "有田市", "名寄市", "潮来市",
                "美作市", "御所市", "宮若市", "あわら市", "三好市", "上天草市", "輪島市", "大町市", "加茂市", "二戸市", "山県市", "仙北市", "長井市", "壱岐市", "遠野市",
                "伊佐市", "根室市", "那須烏山市", "嬉野市", "大竹市", "香美市", "土佐市", "八幡平市", "竹原市", "美祢市", "阿蘇市", "大月市", "にかほ市", "上野原市",
                "豊前市", "江田島市", "水俣市", "村山市", "飛騨市", "養父市", "御坊市", "美唄市", "江津市", "勝山市", "松浦市", "下田市", "紋別市", "須崎市", "留萌市",
                "竹田市", "富良野市", "豊後高田市", "深川市", "枕崎市", "飯山市", "陸前高田市", "阿久根市", "羽咋市", "美濃市", "宿毛市", "士別市", "えびの市", "鳥羽市",
                "多久市", "勝浦市", "串間市", "尾鷲市", "宮津市", "津久見市", "熊野市", "安芸市", "砂川市", "尾花沢市", "垂水市", "西之表市", "芦別市", "珠洲市",
                "土佐清水市", "室戸市", "赤平市", "夕張市", "三笠市", "歌志内市"
            };

        public Scenario3()
        {
            this.InitializeComponent();
            searchPane = SearchPane.GetForCurrentView();
        }

        //<Snippetall_suggestionsrequested_handler_linguisticdetails>
        private void OnSearchPaneSuggestionsRequested(SearchPane sender, SearchPaneSuggestionsRequestedEventArgs e)
        {
            var queryText = e.QueryText;
            if (string.IsNullOrEmpty(queryText))
            {
                MainPage.Current.NotifyUser("Use the search pane to submit a query", NotifyType.StatusMessage);
            }
            else
            {
                var request = e.Request;
                var linguisticDetails = e.LinguisticDetails;
                foreach (string alternative in linguisticDetails.QueryTextAlternatives)
                {
                    foreach (string suggestion in suggestionList)
                    {
                        if (suggestion.StartsWith(alternative, StringComparison.CurrentCultureIgnoreCase))
                        {
                            // Add suggestion to Search Pane
                            request.SearchSuggestionCollection.AppendQuerySuggestion(suggestion);

                            // Break since the Search Pane can show at most 5 suggestions
                            if (request.SearchSuggestionCollection.Size >= MainPage.SearchPaneMaxSuggestions)
                            {
                                break;
                            }
                        }
                    }

                    // Break since the Search Pane can show at most 5 suggestions
                    if (request.SearchSuggestionCollection.Size >= MainPage.SearchPaneMaxSuggestions)
                    {
                        break;
                    }
                }

                if (request.SearchSuggestionCollection.Size > 0)
                {
                    MainPage.Current.NotifyUser("Suggestions provided for query: " + queryText, NotifyType.StatusMessage);
                }
                else
                {
                    MainPage.Current.NotifyUser("No suggestions provided for query: " + queryText, NotifyType.StatusMessage);
                }
            }
        }
        //</Snippetall_suggestionsrequested_handler_linguisticdetails>

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            MainPage.Current.NotifyUser("Use the search pane to submit a query", NotifyType.StatusMessage);
            // This event should be registered when your app first creates its main window after receiving an activated event, like OnLaunched, OnSearchActivated.
            // Typically this occurs in App.xaml.cs.
            //<Snippetall_suggestionsrequested_handler_register>
            //<Snippetacs_suggestionsrequested_handler_register>
            searchPane.SuggestionsRequested += new TypedEventHandler<SearchPane, SearchPaneSuggestionsRequestedEventArgs>(OnSearchPaneSuggestionsRequested);
            //</Snippetcs_suggestionsrequested_handler_register>
            //</Snippetall_suggestionsrequested_handler_register>
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            searchPane.SuggestionsRequested -= new TypedEventHandler<SearchPane, SearchPaneSuggestionsRequestedEventArgs>(OnSearchPaneSuggestionsRequested);
        }
    }
}
