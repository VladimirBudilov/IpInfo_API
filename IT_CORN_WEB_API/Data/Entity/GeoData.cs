using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using IT_CORN_WEB_API.Data.Entity;

[Table("geo_data")]
public class GeoData
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    [JsonIgnore]
    public int Id { get; set; }

    public string? ip { get; set; }
    public string? city { get; set; }
    public string? region { get; set; }
    public string? country { get; set; }
    public string? loc { get; set; }
    public string? org { get; set; }
    public string? postal { get; set; }
    public string? timezone { get; set; }
    public string? readme { get; set; }

    [JsonIgnore] public ICollection<RequestLog> RequestLogs { get; set; }
}