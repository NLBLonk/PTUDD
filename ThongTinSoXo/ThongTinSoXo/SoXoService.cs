using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace ThongTinSoXo
{
    public class SoXoService
    {
        public List<KetQua> LayKetQua(string mien, DateTime ngay)
        {
            string rssUrl = "";

            if (mien == "mienbac")
                rssUrl = "https://xosodaiphat.com/ket-qua-xo-so-mien-bac-xsmb.rss";
            else if (mien == "mientrung")
                rssUrl = "https://xosodaiphat.com/ket-qua-xo-so-mien-trung-xsmt.rss";
            else if (mien == "miennam")
                rssUrl = "https://xosodaiphat.com/ket-qua-xo-so-mien-nam-xsmn.rss";
            else
                throw new ArgumentException("Miền không hợp lệ");

            List<KetQua> ketQuaList = new List<KetQua>();

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(rssUrl);

                XmlNodeList items = doc.SelectNodes("//item");
                foreach (XmlNode item in items)
                {
                    DateTime ngayItem = LayNgayTuItem(item);
                    if (ngayItem.Date != ngay.Date) continue;

                    string description = "";
                    XmlNode descNode = item.SelectSingleNode("description");
                    if (descNode != null) description = descNode.InnerText;

                    string currentDai = "Unknown";
                    if (mien == "mienbac") currentDai = "Miền Bắc";

                    string[] lines = description.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string line in lines)
                    {
                        string trimmedLine = line.Trim();

                        if (trimmedLine.StartsWith("[") && trimmedLine.Contains("]"))
                        {
                            int start = trimmedLine.IndexOf("[") + 1;
                            int end = trimmedLine.IndexOf("]");
                            if (start < end)
                                currentDai = trimmedLine.Substring(start, end - start).Trim();
                        }
                        else if (trimmedLine.Contains(":"))
                        {
                            string[] parts = trimmedLine.Split(':');
                            if (parts.Length == 2)
                            {
                                KetQua kq = new KetQua();
                                kq.Dai = currentDai;
                                kq.Giai = parts[0].Trim();
                                kq.SoTrung = parts[1].Trim();
                                kq.Ngay = ngayItem;
                                ketQuaList.Add(kq);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Không thể đọc được từ dữ liệu RSS: " + ex.Message);
            }

            return ketQuaList;
        }

        private DateTime LayNgayTuItem(XmlNode item)
        {
            XmlNode pubDateNode = item.SelectSingleNode("pubDate");
            if (pubDateNode != null)
            {
                string dateText = pubDateNode.InnerText.Split(' ')[0];
                string[] dateParts = dateText.Split('/');
                if (dateParts.Length == 3)
                {
                    int d = int.Parse(dateParts[0]);
                    int m = int.Parse(dateParts[1]);
                    int y = int.Parse(dateParts[2]);
                    return new DateTime(y, m, d);
                }
            }

            XmlNode titleNode = item.SelectSingleNode("title");
            if (titleNode != null)
            {
                string[] titleParts = titleNode.InnerText.Split(' ');
                foreach (string part in titleParts)
                {
                    if (part.Contains("/"))
                    {
                        string[] dateParts = part.Split('/');
                        if (dateParts.Length == 3)
                        {
                            int d = int.Parse(dateParts[0]);
                            int m = int.Parse(dateParts[1]);
                            int y = int.Parse(dateParts[2]);
                            return new DateTime(y, m, d);
                        }
                    }
                }
            }

            return DateTime.Now.Date;
        }

        public List<KetQua> TimKiemTheoDai(string mien, DateTime ngay, string tenDai)
        {
            List<KetQua> tatCaKetQua = LayKetQua(mien, ngay);
            return tatCaKetQua.Where(kq => kq.Dai.IndexOf(tenDai, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }



    }
}
