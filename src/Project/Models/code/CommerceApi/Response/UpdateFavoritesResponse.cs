using System.Collections.Generic;

namespace Carlsberg.Foundation.Models.CommerceApi.Response
{
    public class UpdateFavoritesResponse
    {
        public UpdateFavoritesResponse()
        {
            entries = new List<FavoritesEntry>();
        }

        public string status { get; set; }
        public int favouritesCount { get; set; }
        public string currencyIsoCode { get; set; }
        public List<FavoritesEntry> entries { get; set; }
    }
}