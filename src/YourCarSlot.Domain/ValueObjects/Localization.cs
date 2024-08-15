namespace YourCarSlot.Domain.ValueObjects
{
    public record Localization(string City, string Country, string Street)
    {

        public static Localization Create(string value)
        {
            var splitValueLocalization = value.Split(",");
            return new Localization(splitValueLocalization.First(), splitValueLocalization.ElementAt(1), splitValueLocalization.Last());
        }

        public override string ToString()
            => $"{City}, {Country}, {Street}";

    }
}