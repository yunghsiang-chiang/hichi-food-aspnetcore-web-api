using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace hochi_food.Models
{
    public partial class UserReports
    {
        [NotMapped]  // 讓 EF 不影響這個欄位
        public List<string>? y_axes_list
        {
            get => string.IsNullOrEmpty(y_axes) ? new List<string>() : JsonConvert.DeserializeObject<List<string>>(y_axes) ?? new List<string>();
            set => y_axes = JsonConvert.SerializeObject(value);
        }
    }
}
