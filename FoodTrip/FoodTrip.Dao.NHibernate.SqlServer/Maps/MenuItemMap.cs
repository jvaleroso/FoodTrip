using FoodTrip.Dao.NHibernate.Repo;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace FoodTrip.Dao.NHibernate.SqlServer.Maps
{
    public class MenuItemMap : ClassMapping<MenuItemRepo>
    {
        public MenuItemMap()
        {
            Table("MenuItem");
            Id(c => c.Id, m => m.Generator(Generators.Native));
            Property(c => c.Quantity, m => m.NotNullable(true));
            Property(c => c.OrderQuantity, m => m.NotNullable(true));
            Property(c => c.Price, m =>
            {
                m.NotNullable(true);
                m.Column(c=>c.SqlType("NUMERIC(10,4)"));
            });
            ManyToOne(c => c.Food, m =>
            {
                m.Column("FoodId");
                m.Cascade(Cascade.None);
                m.Lazy(LazyRelation.NoLazy);
                m.Fetch(FetchKind.Select);
            });
            ManyToOne(c=>c.Menu, m =>
            {
                m.Column("MenuId");
                m.Cascade(Cascade.None);
                m.Lazy(LazyRelation.NoLazy);
                m.Fetch(FetchKind.Select);
            });

        }
    }
}
