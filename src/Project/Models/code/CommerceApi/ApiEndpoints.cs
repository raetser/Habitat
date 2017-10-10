using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Sitecore;

namespace Carlsberg.Foundation.Models.CommerceApi
{
    public static class ApiEndpoints
    {
        public static readonly Dictionary<Api, ApiSettings> Endpoints = new Dictionary<Api, ApiSettings>
        {
            {
                Api.Authenticate, new ApiSettings
                {
                    Endpoint = "/apigateway/b2bcustomer/authenticate",
                    HttpMethod = HttpMethod.Post,
                    Cachable = false,
                    SafeToLogRequest = false
                }
            },
            {
                Api.DeliveryDates, new ApiSettings
                {
                    Endpoint = "/apigateway/soldto/deliveryDates",
                    HttpMethod = HttpMethod.Get,
                    Cachable = true,
                    SafeToLogRequest = true
                }
            },
            {
                Api.ForgotPasswordCreateToken, new ApiSettings
                {
                    Endpoint = "/apigateway/b2bcustomer/forgotpassword/token",
                    HttpMethod = HttpMethod.Post,
                    Cachable = false,
                    SafeToLogRequest = false
                }
            },
            {
                Api.ForgotPasswordSetPassword, new ApiSettings
                {
                    Endpoint = "/apigateway/b2bcustomer/forgotpassword/set",
                    HttpMethod = HttpMethod.Post,
                    Cachable = false,
                    SafeToLogRequest = false
                }
            },
            {
                Api.ProductList, new ApiSettings
                {
                    Endpoint = "/apigateway/product/list",
                    HttpMethod = HttpMethod.Post,
                    Cachable = false,
                    SafeToLogRequest = true
                }
            },
            {
                Api.SearchSuggestions, new ApiSettings
                {
                    Endpoint = "/apigateway/product/suggestions",
                    HttpMethod = HttpMethod.Post,
                    Cachable = false,
                    SafeToLogRequest = true
                }
            },
            {
                Api.Assortments, new ApiSettings
                {
                    Endpoint = "/apigateway/soldto/assortment",
                    HttpMethod = HttpMethod.Get,
                    Cachable = true,
                    SafeToLogRequest = true
                }
            },
            {
                Api.GetCart, new ApiSettings
                {
                    Endpoint = "/apigateway/soldto/cart",
                    HttpMethod = HttpMethod.Post,
                    Cachable = false,
                    SafeToLogRequest = true
                }
            },
            {
                Api.UpdateCart, new ApiSettings
                {
                    Endpoint = "/apigateway/soldto/cart/update",
                    HttpMethod = HttpMethod.Post,
                    Cachable = false,
                    SafeToLogRequest = true
                }
            },
            {
                Api.ProductGetData, new ApiSettings
                {
                    Endpoint = "/apigateway/product/getData",
                    HttpMethod = HttpMethod.Post,
                    Cachable = false,
                    SafeToLogRequest = true
                }
            },
            {
                Api.PlaceOrder, new ApiSettings
                {
                    Endpoint = "/apigateway/soldto/placeorder",
                    HttpMethod = HttpMethod.Post,
                    Cachable = false,
                    SafeToLogRequest = true
                }
            },
            {
                Api.UpdateFavorites, new ApiSettings
                {
                    Endpoint = "/apigateway/soldto/favourites/update",
                    HttpMethod = HttpMethod.Post,
                    Cachable = false,
                    SafeToLogRequest = true
                }
            },
            {
                Api.GetFavorites, new ApiSettings
                {
                    Endpoint = "/apigateway/soldto/favourites",
                    HttpMethod = HttpMethod.Post,
                    Cachable = false,
                    SafeToLogRequest = true
                }
            },
            {
                Api.PromotionProductList, new ApiSettings
                {
                    Endpoint = "/apigateway/soldto/campaign/products",
                    HttpMethod = HttpMethod.Post,
                    Cachable = false,
                    SafeToLogRequest = true
                }
            },
			{
				Api.PromotionList, new ApiSettings
				{
					Endpoint = "/apigateway/soldto/campaign",
					HttpMethod = HttpMethod.Post,
					Cachable = false,
					SafeToLogRequest = true
				}
			},
			{
                Api.OrderHistory, new ApiSettings
                {
                    Endpoint = "/apigateway/soldto/orderhistory",
                    HttpMethod = HttpMethod.Get,
                    Cachable = false,
                    SafeToLogRequest = true
                }
            },
            {
                Api.OrderDetails, new ApiSettings
                {
                    Endpoint = "/apigateway/soldto/order",
                    HttpMethod = HttpMethod.Get,
                    Cachable = false,
                    SafeToLogRequest = true
                }
            },
            {
                Api.AddReward, new ApiSettings
                {
                    Endpoint = "/apigateway/soldto/cart/addreward",
                    HttpMethod = HttpMethod.Post,
                    Cachable = false,
                    SafeToLogRequest = true
                }
            },
            {
                Api.CleanCart, new ApiSettings
                {
                    Endpoint = "/apigateway/soldto/cleancart",
                    HttpMethod = HttpMethod.Post,
                    Cachable = false,
                    SafeToLogRequest = true
                }
            },
            {
                Api.TradeQuotations, new ApiSettings
                {
                    Endpoint = "/apigateway/soldto/tradequotations",
                    HttpMethod = HttpMethod.Get,
                    Cachable = false,
                    SafeToLogRequest = true
                }
            }
        };
    }

    public static class ApiLanguage
    {
        private static readonly string[] AvailableApiLanguages = {"EN", "DA", "DE", "NB", "FI", "SV" };
        private static readonly string FallbackLanguage = "EN";
        public static string GetCurrentLanguage()
        {
            var prefered = Context.Language.CultureInfo.TwoLetterISOLanguageName;
            if (AvailableApiLanguages.Contains(prefered,StringComparer.InvariantCultureIgnoreCase))
            {
                return prefered.ToUpper();
            }
            return FallbackLanguage;
        }
    }

    public enum Api
    {
        Authenticate,
        DeliveryDates,
        ForgotPasswordCreateToken,
        ForgotPasswordSetPassword,
        ProductList,
        Assortments,
        GetCart,
        UpdateCart,
        ProductGetData,
        SearchSuggestions,
        PlaceOrder,
        UpdateFavorites,
        GetFavorites,
        PromotionProductList,
		PromotionList,
		OrderHistory,
        OrderDetails,
        AddReward,
        CleanCart,
        TradeQuotations
    }
}