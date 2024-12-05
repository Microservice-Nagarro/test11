using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BHF.MS 
            $match = $args[0]
            . = $match.Groups[1].Value
            MyMicroservice = $match.Groups[2].Value
            . = $match.Groups[3].Value
            return . + $newWord + .
        Models.Settings
{
    [ExcludeFromCodeCoverage(Justification = "It's a model with no logic")]
    public class HttpClientSettings
    {
        [Url]
        public string BaseAddress { get; set; } = string.Empty;
    }
}

