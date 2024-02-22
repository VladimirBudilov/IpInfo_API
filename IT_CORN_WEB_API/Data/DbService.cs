using IT_CORN_WEB_API.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace IT_CORN_WEB_API.Data;

public class DbService
{
    public static async Task SaveDataToDatabase(string ip, LogDbContext dbContext, GeoData geoData)
    {
        var existedGeoData = await dbContext.GeoDatas.FirstOrDefaultAsync(g => g.ip == ip);
        if (existedGeoData != null)
        {
            dbContext.RequestLogs.Add(new RequestLog
            {
                IpAddress = ip,
                RequestTime = DateTime.Now,
                GeoData = existedGeoData
            });
        }
        else
        {
            dbContext.GeoDatas.Add(geoData);
            dbContext.RequestLogs.Add(new RequestLog
            {
                IpAddress = ip,
                RequestTime = DateTime.Now,
                GeoData = geoData
            });
        }

        await dbContext.SaveChangesAsync();
    }
}