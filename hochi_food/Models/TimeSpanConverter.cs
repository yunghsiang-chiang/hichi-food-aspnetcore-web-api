using Newtonsoft.Json;
using System;

namespace hochi_food.Models
{
    // 自訂 TimeSpan 轉換器，用來處理 JSON 中的 TimeSpan 類型
    public class TimeSpanConverter : JsonConverter
    {
        // 判斷是否能夠轉換指定的物件類型
        public override bool CanConvert(Type objectType)
        {
            // 如果物件類型是 TimeSpan，則回傳 true，表示可以轉換
            return objectType == typeof(TimeSpan);
        }

        // 讀取 JSON 並將其轉換為 TimeSpan 物件
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // 如果 JSON Token 是字串類型
            if (reader.TokenType == JsonToken.String)
            {
                // 將讀取到的時間字串轉換為 TimeSpan
                var time = reader.Value.ToString();
                return TimeSpan.Parse(time);
            }
            // 如果 Token 類型無效，拋出異常
            throw new JsonException("無效的 Token 類型，無法轉換為 TimeSpan。");
        }

        // 將 TimeSpan 物件寫入 JSON
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // 如果值是 TimeSpan 類型
            if (value is TimeSpan timeSpan)
            {
                // 將 TimeSpan 格式化為 hh:mm:ss 並寫入 JSON
                writer.WriteValue(timeSpan.ToString(@"hh\:mm\:ss"));
            }
            else
            {
                // 如果值不是 TimeSpan，拋出異常
                throw new JsonException("預期的值應該是 TimeSpan 類型。");
            }
        }
    }
}
