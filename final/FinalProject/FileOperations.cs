using System;
using System.Collections.Generic;
using System.IO;

public static class FileOperations
{
    public static Dictionary<string, double> LoadStreetDistances(string filePath)
    {
        var streetDistances = new Dictionary<string, double>();
        foreach (var line in File.ReadLines(filePath))
        {
            var parts = line.Split(',');
            if (parts.Length == 2 && double.TryParse(parts[1], out double distance))
            {
                streetDistances[parts[0].Trim()] = distance;
            }
        }
        return streetDistances;
    }
}
