using System.Collections.Generic;

namespace Carlsberg.Foundation.Models.CommerceApi.Response
{
    public class SearchSuggestionFeResponse
    {
        public List<SearchResult> results { get; set; }
        public List<SearchQuickBuysResult> suggestions { get; set; }
        public List<SearchInformationResult> information { get; set; }
        public List<SearchQuickBuysResult> quickBuys { get; set; }
        public string searchTerm { get; set; }
        public SearchSuggestionFeResponse()
        {
            results = new List<SearchResult>();
            suggestions = new List<SearchQuickBuysResult>();
            information = new List<SearchInformationResult>();
            quickBuys = new List<SearchQuickBuysResult>();
        }
    }
    public class SearchResult
    {
        public string label { get; set; }
        public string url { get; set; }
        public int quantity { get; set; }
    }

    public class SearchSuggestionResult
    {
        public string label { get; set; }
        public string url { get; set; }
        public string imageUrl { get; set; }
    }
    public class SearchInformationResult
    {
        public string label { get; set; }
        public string url { get; set; }

    }
    public class SearchQuickBuysResult
    {
        public string label { get; set; }
        public string url { get; set; }
        public string imageUrl { get; set; }
        public string articleNumber { get; set; }
        public string litrage { get; set; }
        public string price { get; set; }
        public string beforePrice { get; set; }
        public bool hasBeforePrice { get; set; }
        public string brand { get; set; }
        public string categoryid { get; set; }
        public int deliveryUnit { get; set; }
    }
}

/*
 * {
    "results": [
        {"label": "Red wine", "quantity": 123, "url": "/product/category-wine.html"},
        {"label": "Cocktails", "quantity": 5, "url": "/product/category.html"},
        {"label": "Soft drinks", "quantity": 3, "url": "/product/category.html"}
    ],
    "suggestions": [
        {"label": "Johny Walker Red", "imageUrl": "../includes/images/Suggestion1.jpg", "url": "/product/detail.html"},
        {"label": "Valdivieso Carmenere Valley Red", "imageUrl": "../includes/images/Suggestion2.jpg", "url": "/product/detail.html"},
        {"label": "Red Bull", "imageUrl": "../includes/images/Suggestion3.jpg", "url": "/product/detail.html"}
    ],
    "information": [
        {"label": "The difference between red and white wine", "url": "/product/category.html"},
        {"label": "Red color interior works better than value", "url": "/product/category.html"},
        {"label": "Support the Red Cross", "url": "/product/category.html"},
        {"label": "Lady in red most popular mix drink in 2015", "url": "/product/category.html"},
        {"label": "Red Cocktail festival in May 2017", "url": "/product/category.html"}
    ],
    "quickBuys": [
        {"label": "Kronenbourg 1664 EW",
            "articleNumber": 11066, 
            "litrage": "12 × 0,25l", 
            "price": "&euro; 10,21", 
            "hasBeforePrice": true ,
            "beforePrice": "&euro; 11,00",
            "imageUrl": "/images/Quickbuy1.jpg", "
            url": "/product/detail.html"},
        {"label": "Kronenbourg 1664 4x6er-Pack EW",
            "articleNumber": 11067, "litrage": "4 × 6 × 0,25l", "price": "&euro; 10,21",
            "imageUrl": "/images/Quickbuy2.jpg", "url": "/product/detail.html"}
    ]
}
*/
