using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class Rosstat
{
    public static readonly string URL_ROSSTAT = "https://rosstat.gov.ru/";
    public static readonly string URL_FIND = "https://rosstat.gov.ru/labor_market_employment_salaries";
    public static readonly string PREFIX_FIND = "itog-monitor";

    public static async Task<List<string>> FindLinkedPagesAsync()
    {
        var allLinkedItogMonitor = new List<string>();
        var allLinkedFiles_rar = new List<string>();

        try
        {
            var allLinkedPagesRosstat = UrlFind(URL_FIND);

            // Заработная плата отдельных категорий работников соц.сферы и науки
            // Итоги по годам
            Parallel.ForEach(allLinkedPagesRosstat.Where(s => s.Contains(PREFIX_FIND)), link =>
            {
                allLinkedItogMonitor.Add($"{URL_ROSSTAT}{link}");
            });

            // Средняя заработная плата отдельных категорий работников социальной сферы и науки
            var tasks = allLinkedItogMonitor.Select(urls => GetRarFileUrl(urls))
                                            .ToList();
            allLinkedFiles_rar = (await Task.WhenAll(tasks))
                                .Where(s => !string.IsNullOrEmpty(s) && s.EndsWith(".rar"))
                                .ToList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, URL_ROSSTAT, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return allLinkedFiles_rar;
    }

    private static List<string> UrlFind(string url)
    {
        var doc = new HtmlWeb().LoadFromWebAsync(url).Result;
        return doc.DocumentNode.Descendants("a")
                              .Select(a => a.GetAttributeValue("href", null))
                              .Where(u => !string.IsNullOrEmpty(u))
                              .ToList();
    }

    private static async Task<string> GetRarFileUrl(string url)
    {
        var doc = await new HtmlWeb().LoadFromWebAsync(url);
        return doc.DocumentNode.Descendants("a")
                              .Select(a => a.GetAttributeValue("href", null))
                              .FirstOrDefault(u => u != null && u.EndsWith(".rar"));
    }
}