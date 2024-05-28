namespace OrderShopCart.Infrastructure.Presistance;

public static class DbContextSchema
{
    public const string DefaultConnectionStringName = "OrderShopCartDb";

    public static class Product
    {
        public const string TableName = "Product";

        public const string ForigenKey = "ProductId";

        public const string TagTableName = "ProductTags";

        public const string TagIdBackendField = "_tags";

        public const string GroupsTableName = "ProductsGroups";

        public const string GroupIdBackendField = "_groups";
    }

    public static class Group
    {
        public const string TableName = "Group";

        public const string ForigenKey = "GroupId";

        public const string ProductsTableName = "ProductsGroups";

        public const string ProductIdBackendField = "_products";
    }
}
