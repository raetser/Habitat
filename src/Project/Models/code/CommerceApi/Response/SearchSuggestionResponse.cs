namespace Carlsberg.Foundation.Models.CommerceApi.Response
{
    public class SearchSuggestionResponse
    {
        public string status { get; set; }
        public string[] productList { get; set; }
        public Categorylist[] categoryList { get; set; }
    }

    public class Categorylist
    {
        public string code { get; set; }
        public int results { get; set; }
    }
}