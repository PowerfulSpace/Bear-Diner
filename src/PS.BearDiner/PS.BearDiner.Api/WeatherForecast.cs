﻿namespace PS.BearDiner.Api
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
//Очистить все комментарии
//Удалить все лишнии методы
//Удалить все лишнии классы