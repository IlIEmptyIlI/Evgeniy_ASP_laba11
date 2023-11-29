using Microsoft.AspNetCore.Mvc;
using Laba11.Services.WeatherService;
using Laba11.Models;

namespace Laba11.ViewComponents
{
    public class WeatherViewComponent : ViewComponent
    {
        private readonly IWeatherService _weatherService;

        public WeatherViewComponent(IWeatherService myService)
        {
            _weatherService = myService;
        }
        public async Task<IViewComponentResult> InvokeAsync(Coord coord)
        {
            WeatherData weather = await _weatherService.GetWeatherAsync(coord.lat, coord.lon);
            return View(weather);
        }

    }
}
