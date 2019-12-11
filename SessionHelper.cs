using V.ShopWithInventory.Models;

namespace V.ShopWithInventory
{
    public static class SessionHelper
    {
        public static Client CurrentLoggedClient { get; set; }

        public static void RefreshCurrentLoggedClient()
        {
            if (SessionHelper.CurrentLoggedClient == null)
            {
                return;
            }

            var dbo = new DBOperations();
            SessionHelper.CurrentLoggedClient = dbo.GetClientByID(SessionHelper.CurrentLoggedClient.ID);
        }
    }
}
