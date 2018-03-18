using System.Linq;
using Plastic.Definitions.Data;
using Plastic.Infos.Data;

namespace Plastic.Infos.Views
{
    public class CrudCreator
    {
        public void Create(ApplicationInfo info)
        {
            foreach (DatabaseInfo database in info.Databases)
            {
                UserInterfaceInfo ui = Create(database);
                info.UserInterfaces.Add(ui);
            }    
        }

        public UserInterfaceInfo Create(DatabaseInfo database)
        {
            UserInterfaceInfo ui = new UserInterfaceInfo();
            ui.DatabaseInfo = database;
            ui.Set(database);
            foreach (TableInfo table in database.Tables.Where(i => i.Crud != Crud.None))
            {
                ViewGroupInfo group = CreateViewGroup(table);

                ui.Groups.Add(group);
            }
            return ui;
        }

        private ViewGroupInfo CreateViewGroup(TableInfo table)
        {
            ViewGroupInfo group = new ViewGroupInfo();
            group.Name = table.Name;
            if (table.Crud.IsEqual(Crud.Create))
            {
                group.Views.Add(CreateView<CreateViewInfo>(table));        
            }
            if (table.Crud.IsEqual(Crud.Read))
            {
                group.Views.Add(CreateView<DetailViewInfo>(table));
            }
            if (table.Crud.IsEqual(Crud.Update))
            {
                group.Views.Add(CreateView<EditViewInfo>(table));
            }
            if (table.Crud.IsEqual(Crud.Delete))
            {
                group.Views.Add(CreateView<DeleteViewInfo>(table));
            }
            if (table.Crud.IsEqual(Crud.List))
            {
                group.Views.Add(CreateView<IndexViewInfo>(table));
            }

            return group;
        }

        private IViewInfo CreateView<T>(TableInfo table)
            where T : IViewInfo, new()
        {
            T view = new T();
            view.Table = table;

            PanelInfo panel = new PanelInfo();
            view.Panels.Add(panel);

            foreach (IFieldInfo field in table.Fields)
            {
                if (field.Crud.IsEqual(Crud.Create))
                {
                    ControlInfo control = field.CreateControl();
                    if (control != null)
                    {
                        panel.Controls.Add(control);
                    }
                }
            }

            return view;
        }

    }
}
