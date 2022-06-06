namespace EntegraIntegration.ConsoleApp.Integrations.Helpers
{
    public static class RouteHelper
    {
        public const string Root = "https://apiv2.entegrabilisim.com";

        public const string Base = Root + "/api";

        public static class User
        {
            public const string UserBase = Base + "/user";

            public const string Token = UserBase + "/token/obtain/";
        }

        public static class Product
        {
            public static string GetProducts(int pageNumber = 1)
            {
                return Root + $"/product/page={pageNumber}/";
            }
        }


    }
}
