using System;
using Plastic.Definitions.Views;
using Plastic.Infos.Data;

namespace Plastic.Infos.Views
{
    public interface IControlInfo : IInfo<ControlDefinition, PanelInfo>
    {
    }

    public interface INumberControlInfo : IControlInfo
    {
    }

    public class UserInterfaceInfoCollection : InfoCollection<UserInterfaceInfo, UserInterfaceDefinition, ApplicationInfo>
    {
        public UserInterfaceInfoCollection(ApplicationInfo parent) : base(parent)
        {
        }
    }

    public class UserInterfaceInfo : Info<UserInterfaceDefinition, ApplicationInfo>
    {
        public UserInterfaceInfo()
        {
            Groups = new ViewGroupInfoCollection(this);
        }

        public ViewGroupInfoCollection Groups { get; }
        public DatabaseInfo DatabaseInfo { get; set; }

        protected override void OnSet(UserInterfaceDefinition definition)
        {
            Groups.Set(definition.ViewGroups);
        }
    }


    public class ViewGroupInfoCollection : InfoCollection<ViewGroupInfo, ViewGroupDefinition, UserInterfaceInfo>
    {
        public ViewGroupInfoCollection(UserInterfaceInfo parent) : base(parent)
        {
        }
    }

    public class ViewGroupInfo : Info<ViewGroupDefinition, UserInterfaceInfo>
    {
        public ViewGroupInfo()
        {
            Views = new ViewInfoCollection(this);
        }

        public ViewInfoCollection Views { get; }

        protected override void OnSet(ViewGroupDefinition definition)
        {
            Views.Set(definition.Views);
        }
    }

    public class ViewInfoCollection : InfosCollection<IViewInfo, ViewDefinition, ViewGroupInfo>
    {
        public ViewInfoCollection(ViewGroupInfo parent) : base(parent)
        {
        }

        protected override void AddTypes()
        {

            //AddType<IndexViewInfo>();
        }
    }

    public abstract class ViewInfo<TD> : Info<TD, ViewGroupInfo>, IViewInfo
        where TD : ViewDefinition
    {
        protected ViewInfo(string name) : this()
        {
            Name = name;
        }

        protected ViewInfo()
        {
            Panels = new PanelInfoCollection(this);
        }

        public PanelInfoCollection Panels { get; }
        public TableInfo Table { get; set; }

        protected override void OnSet(TD definition)
        {
            Panels.Set(definition.Groups);
        }
    }

    public interface IViewInfo : IInfo<ViewDefinition, ViewGroupInfo>
    {
        PanelInfoCollection Panels { get; }
        TableInfo Table { get; set; }
    }

    public class IndexViewInfo : ViewInfo<IndexViewDefinition>
    {
        public IndexViewInfo() : base("Index")
        {
        }
    }

    public class DeleteViewInfo : ViewInfo<DeleteViewDefinition>
    {
        public DeleteViewInfo() : base("Delete")
        {
        }

    }
    public class CreateViewInfo : ViewInfo<CreateViewDefinition>
    {
        public CreateViewInfo() : base("Create")
        {
        }
    }
    public class EditViewInfo : ViewInfo<EditViewDefinition>
    {
        public EditViewInfo() : base("Edit")
        {
        }
    }
    public class DetailViewInfo : ViewInfo<DetailViewDefinition>
    {
        public DetailViewInfo() : base("Detail")
        {
        }
    }

    public class PanelInfoCollection : InfoCollection<PanelInfo, PanelDefinition, IViewInfo>
    {
        public PanelInfoCollection(IViewInfo parent) : base(parent)
        {
        }
    }

    public class PanelInfo : Info<PanelDefinition, IViewInfo>
    {
        public PanelInfo()
        {
            Controls = new ControlInfoCollection(this);
        }

        public ControlInfoCollection Controls { get; }

        protected override void OnSet(PanelDefinition definition)
        {
            Controls.Set(definition.Controls);
        }
    }

    public class ControlInfoCollection : InfosCollection<ControlInfo, ControlDefinition, PanelInfo>
    {
        protected override void AddTypes()
        {
            AddType<StringControlInfo>();
            AddType<IntControlInfo>();
            AddType<DecimalControlInfo>();
            AddType<DateTimeControlInfo>();
            AddType<BoolControlInfo>();
            AddType<ParentControlInfo>();
            AddType<ChildControlInfo>();
            AddType<MultipleControlInfo>();
            AddType<CalculatedControlInfo>();
            AddType<EnumerationControlInfo>();
        }

        public ControlInfoCollection(PanelInfo parent) : base(parent)
        {
        }
    }

    public abstract class ControlInfo : Info<ControlDefinition, PanelInfo>, IControlInfo
    {
    }

    public abstract class ControlInfo<T> : ControlInfo
    {
    }

    public abstract class NumberControlInfo<T> : ControlInfo<T>, INumberControlInfo
    {
    }

    public class StringControlInfo : ControlInfo<string>
    {
    }

    public class IntControlInfo : NumberControlInfo<int>
    {
    }

    public class DecimalControlInfo : NumberControlInfo<decimal>
    {
    }

    public class DateTimeControlInfo : ControlInfo<DateTime>
    {
    }

    public class BoolControlInfo : ControlInfo<bool>
    {
    }

    public class ParentControlInfo : ControlInfo
    {
    }
    public class ChildControlInfo : ControlInfo
    {
    }
    public class MultipleControlInfo : ControlInfo
    {
    }
    public class CalculatedControlInfo : ControlInfo
    {
    }
    public class EnumerationControlInfo : ControlInfo
    {
    }

}
