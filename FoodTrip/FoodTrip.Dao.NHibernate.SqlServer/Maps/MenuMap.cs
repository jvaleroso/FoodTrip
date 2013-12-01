using System;
using FoodTrip.Dao.NHibernate.Repo;
using NHibernate.Linq;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Util;

namespace FoodTrip.Dao.NHibernate.SqlServer.Maps
{
    public class MenuMap : ClassMapping<MenuRepo>
    {
        public MenuMap()
        {
            Table("Menu");
            Id(c => c.Id, m => m.Generator(Generators.Native));
            Property(c => c.MenuStatus, m =>
            {
                m.Column(c => c.SqlType("TINYINT"));
                m.NotNullable(true);
            });
            Property(c => c.Date, m => m.NotNullable(true));
            ManyToOne(c => c.Vendor, m =>
            {
                m.Column("UserId");
                m.Cascade(Cascade.None);
                m.Lazy(LazyRelation.NoLazy);
                m.Fetch(FetchKind.Select);
                m.NotNullable(true);
            });
            Bag(c => c.MenuItems, m =>
            {
                m.Cascade(Cascade.DeleteOrphans);
                m.Inverse(true);
                m.Key(k => k.Column("MenuId"));
                m.Lazy(CollectionLazy.NoLazy);
            }, ce => ce.OneToMany());

        }
    }
}
