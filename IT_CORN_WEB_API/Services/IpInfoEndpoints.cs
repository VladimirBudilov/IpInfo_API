using System.Text.Json;
using IT_CORN_WEB_API.Data;
using Microsoft.AspNetCore.Mvc;

namespace IT_CORN_WEB_API.Controller;

public static class IpInfoEndpoints
{
    /// <summary>
    /// Get data about a specific IP address and saves it to the database.
    /// </summary>
    /// <param name="ip">The IP address to retrieve data for.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    [HttpGet("{ip}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public static async Task GetOne(string ip, HttpContext context, LogDbContext dbContext, IpInfoService infoService)
    {
        var data = await infoService.GetIpInfo(ip);
        GeoData? geoData = JsonSerializer.Deserialize<GeoData>(data);
        ErrorHelper.ErrorResponse? error = JsonSerializer.Deserialize<ErrorHelper.ErrorResponse>(data);

        if (geoData?.ip == null)
        {
            await ErrorHelper.GeneraeError(context, error);
            return;
        }

        await DbService.SaveDataToDatabase(ip, dbContext, geoData);
        await context.Response.WriteAsJsonAsync(geoData);
    }
}