using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PrjEIP.models
{
    public class CDateConverter
    {
        public long ConvertToUnixTimestamp(string inputDate)
        {
            try
            {
                // 驗證輸入長度
                //inputDate的?表示如果inputDate是null不會讓系統當掉,他會直接回傳null
                string datePattern = @"^\d{4}\d{2}\d{2}$";
                if (!Regex.IsMatch(inputDate, datePattern))
                {
                    //System.Windows.Forms.MessageBox.Show("輸入日期必須是8位數的字串 (yyyyMMdd)");
                    return -1;
                    //throw new ArgumentException("輸入日期必須是8位數的字串 (yyyyMMdd)");
                }
                // 解析輸入的 yyyyMMdd 格式字串
                if (DateTime.TryParseExact(inputDate, "yyyyMMdd",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None,
                    out DateTime parsedDate))
                {
                    // 轉換成 Unix Timestamp（從 1970/1/1 開始的秒數）
                    DateTimeOffset dto = new DateTimeOffset(parsedDate.ToUniversalTime());
                    return dto.ToUnixTimeSeconds();
                }
                else
                {
                    return -1;
                    //throw new ArgumentException("日期格式無效，請使用 yyyyMMdd 格式");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"日期轉換錯誤: {ex.Message}");
                throw;
            }
        }
        //這個方法可以將時間戳轉回時間
        public DateTime FromUnixTimestamp(long unixTimestamp)
        {
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(unixTimestamp);
            return dateTimeOffset.LocalDateTime;
        }
    }

}

