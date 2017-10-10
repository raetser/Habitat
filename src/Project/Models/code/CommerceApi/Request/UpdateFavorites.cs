using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Carlsberg.Foundation.Models.CommerceApi.Request
{
    public class UpdateFavoritesRequest
    {
        public string soldTo { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public UpdateFavoriteAction action { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public UpdateFavoriteMode mode { get; set; }

        public string deliveryDate { get; set; }

        public UpdateFavoritesRequestEntry[] favourites { get; set; }
    }

    public class UpdateFavoritesRequestEntry
    {
        public string sku { get; set; }

        public uint? preferredQuantity { get; set; }
    }

    public enum UpdateFavoriteMode
    {
        SIMPLE,
        DETAILED,
        DETAILED_CHANGES
    }
    public enum UpdateFavoriteAction
    {
        ADD,
        REMOVE,
        SET,
        CLEAR
    }
}