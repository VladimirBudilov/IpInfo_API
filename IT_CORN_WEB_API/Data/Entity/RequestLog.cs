using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace IT_CORN_WEB_API.Data.Entity;

[Table("request_log")]
public class RequestLog
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("ip_address")] public string? IpAddress { get; set; }

    [Column(name: "request_time", TypeName = "datetime")]
    public DateTime? RequestTime { get; set; }

    [Column("geo_data_id")]
    [ForeignKey("GeoData")]
    public int GeoDataId { get; set; }

    [JsonIgnore] public GeoData GeoData { get; set; }
}