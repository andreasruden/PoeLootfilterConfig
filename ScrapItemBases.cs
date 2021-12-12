/* Initial Script by: https://www.reddit.com/r/pathofexiledev/comments/689c7u/comment/dhajkbu */

namespace ScrapeItemBases
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using HtmlAgilityPack;
    using ScrapySharp.Extensions;
    using Newtonsoft.Json;
    using System.IO;
    using System.Diagnostics;

    class Program
    {
        static readonly Dictionary<string, string> ItemTypeToSite = new Dictionary<string, string>
        {
            { "Weapons", "https://www.pathofexile.com/item-data/weapon" },
            { "Armour", "https://www.pathofexile.com/item-data/armour" },
            // { "Jewelry", "https://www.pathofexile.com/item-data/jewelry" }
        };

        static readonly HashSet<string> DesiredProperties = new HashSet<string>
        {
            "Name",
            "Level",
            "Str",
            "Dex",
            "Int"
        };

        static void Main(string[] args)
        {
            var container = new List<dynamic>();
            var jsonObjects = new List<Dictionary<string, List<Dictionary<string, string>>>>();

            foreach (KeyValuePair<string, string> itemType in ItemTypeToSite)
            {
                var site = ItemTypeToSite[itemType.Key];

                var itemList = CreateItemList(site);
                var jsonObject = FormatItemList(itemList);
                jsonObjects.Add(jsonObject);
            }

            var mangledJsonObject = MangleJsonObjects(jsonObjects);

            string json = JsonConvert.SerializeObject(mangledJsonObject, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            File.WriteAllText(dir + @"\bases.json", json);
            Process.Start(dir);
        }

        private static Dictionary<string, List<List<string>>> CreateItemList(string site)
        {
            Dictionary<string, List<List<string>>> itemList = new Dictionary<string, List<List<string>>>();

            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load(site);
            var headers = document.DocumentNode.CssSelect("h1").ToList();
            for (int i = 0; i <= headers.LongCount() - 1; i++)
            {
                var tables = document.DocumentNode.CssSelect("table.itemDataTable").ElementAt(i);
                var tables2 = tables.CssSelect("tr");
                var headerName = headers[i].InnerText;
                foreach (HtmlNode td in tables2)
                {
                    var tds = td.CssSelect("td");
                    if (tds.Count() > 1) // skip implicit mod
                    {
                        var itemInfo = new List<string>();
                        foreach (var inner_td in tds)
                            itemInfo.Add(inner_td.InnerText);
                        itemList[headerName].Add(itemInfo);
                    }
                    else
                    {
                        var ths = td.CssSelect("th");
                        if (ths.Count() > 1) // skip implicit mod
                        {
                            var innerList = new List<List<string>>();
                            innerList.Add(new List<string>());
                            foreach (var th in ths)
                                innerList[0].Add(th.InnerText);

                            itemList.Add(headerName, innerList);
                        }
                    }
                }
            }
            return itemList;
        }

        private static Dictionary<string, List<Dictionary<string, string>>> FormatItemList(Dictionary<string, List<List<string>>> itemList)
        {
            var items = new Dictionary<string, List<Dictionary<string, string>>>();
            foreach (var entry in itemList)
            {
                var header = entry.Key;
                var itemTable = entry.Value;
                var properties = itemTable.First();
                var innerItems = new List<Dictionary<string, string>>();
                for (int i = 1; i < itemTable.Count; ++i)
                {
                    var item = new Dictionary<string, string>();
                    for (int j = 0; j < itemTable[i].Count; ++j)
                    {
                        if (DesiredProperties.Contains(properties[j]))
                            item.Add(properties[j], itemTable[i][j]);
                    }
                    innerItems.Add(item);
                }
                items.Add(header, innerItems);
            }
            return items;
        }

        private static List<Dictionary<string, object>> MangleJsonObjects(List<Dictionary<string, List<Dictionary<string, string>>>> jsonObjects)
        {
            var jsonOut = new List<Dictionary<string, object>>();
            foreach (var jsonObject in jsonObjects)
            {
                foreach (var entry in jsonObject)
                {
                    var baseType = entry.Key;
                    var items = entry.Value;
                    foreach (var item in items)
                    {
                        var name = item["Name"];
                        var level = int.Parse(item["Level"]);
                        string attr = "unknown";
                        if (item.ContainsKey("Str") && int.TryParse(item["Str"], out _))
                        {
                            if (item.ContainsKey("Dex") && int.TryParse(item["Dex"], out _))
                                attr = "str_dex";
                            else if (item.ContainsKey("Int") && int.TryParse(item["Int"], out _))
                                attr = "str_int";
                            else
                                attr = "str";
                        }
                        else if (item.ContainsKey("Dex") && int.TryParse(item["Dex"], out _))
                        {
                            if (item.ContainsKey("Int") && int.TryParse(item["Int"], out _))
                                attr = "dex_int";
                            else
                                attr = "dex";
                        }
                        else if (item.ContainsKey("Int") && int.TryParse(item["Int"], out _))
                        {
                            attr = "int";
                        }
                        else
                        {
                            Console.WriteLine("Skipped " + name);
                            continue;
                        }

                        jsonOut.Add(new Dictionary<string, object>
                        {
                            { "Name", name },
                            { "Level", level },
                            { "BaseType", baseType },
                            { "AttributeType", attr },
                        });
                    }
                }
            }
            return jsonOut;
        }
    }
}
