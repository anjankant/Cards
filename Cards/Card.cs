using Newtonsoft.Json;

namespace Cards
{
    public class Card
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("manaCost")]
        public string manaCost { get; set; }

        [JsonProperty("cmc")]
        public double? cmc { get; set; }

        [JsonProperty("colors")]
        public List<string> colors { get; set; }

        [JsonProperty("colorIdentity")]
        public List<string> colorIdentity { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("types")]
        public List<string> types { get; set; }

        [JsonProperty("subtypes")]
        public List<string> subtypes { get; set; }

        [JsonProperty("rarity")]
        public string rarity { get; set; }

        [JsonProperty("set")]
        public string set { get; set; }

        [JsonProperty("setName")]
        public string setName { get; set; }

        [JsonProperty("text")]
        public string text { get; set; }

        [JsonProperty("flavor")]
        public string flavor { get; set; }

        [JsonProperty("artist")]
        public string artist { get; set; }

        [JsonProperty("number")]
        public string number { get; set; }

        [JsonProperty("power")]
        public string power { get; set; }

        [JsonProperty("toughness")]
        public string toughness { get; set; }

        [JsonProperty("layout")]
        public string layout { get; set; }

        [JsonProperty("multiverseid")]
        public string multiverseid { get; set; }

        [JsonProperty("imageUrl")]
        public string imageUrl { get; set; }

        [JsonProperty("rulings")]
        public List<Ruling> rulings { get; set; }

        [JsonProperty("foreignNames")]
        public List<ForeignName> foreignNames { get; set; }

        [JsonProperty("printings")]
        public List<string> printings { get; set; }

        [JsonProperty("originalText")]
        public string originalText { get; set; }

        [JsonProperty("originalType")]
        public string originalType { get; set; }

        [JsonProperty("legalities")]
        public List<Legality> legalities { get; set; }

        [JsonProperty("id")]
        public string id { get; set; }
    }

    public class ForeignName
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("text")]
        public string text { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("flavor")]
        public object flavor { get; set; }

        [JsonProperty("language")]
        public string language { get; set; }

        [JsonProperty("multiverseid")]
        public object multiverseid { get; set; }
    }

    public class Legality
    {
        [JsonProperty("format")]
        public string format { get; set; }

        [JsonProperty("legality")]
        public string legality { get; set; }
    }

    public class Root
    {
        [JsonProperty("cards")]
        public List<Card> cards { get; set; }
    }

    public class Ruling
    {
        [JsonProperty("date")]
        public string date { get; set; }

        [JsonProperty("text")]
        public string text { get; set; }
    }

}
