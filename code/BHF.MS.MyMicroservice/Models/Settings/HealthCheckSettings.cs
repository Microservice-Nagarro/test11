namespace BHF.MS 
            $match = $args[0]
            . = $match.Groups[1].Value
            MyMicroservice = $match.Groups[2].Value
            . = $match.Groups[3].Value
            return . + $newWord + .
        Models.Settings
{
    public class HealthCheckSettings
    {
        public byte AttemptsCount { get; set; } = 1;
    }
}

