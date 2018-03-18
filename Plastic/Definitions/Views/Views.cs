using System;
using System.Xml.Serialization;

namespace Plastic.Definitions.Views
{
    public class UserInterfaceDefinitionCollection : DefinitionCollection<UserInterfaceDefinition>
    {
    }

    public class UserInterfaceDefinition : Definition
    {
        public UserInterfaceDefinition()
        {
            ViewGroups = new ViewGroupDefinitionCollection(this);
        }

        [XmlElement]
        public ViewGroupDefinitionCollection ViewGroups { get; }
    }

    public class ViewGroupDefinitionCollection : DefinitionCollection<ViewGroupDefinition, UserInterfaceDefinition>
    {
        public ViewGroupDefinitionCollection(UserInterfaceDefinition parent) : base(parent)
        {
        }
    }

    public class ViewGroupDefinition : Definition<UserInterfaceDefinition>
    {
        public ViewGroupDefinition()
        {
            Views = new ViewDefinitionCollection(this);
        }

        [XmlElement]
        public ViewDefinitionCollection Views { get; }
    }

    public class ViewDefinitionCollection : DefinitionCollection<ViewDefinition, ViewGroupDefinition>
    {
        public ViewDefinitionCollection(ViewGroupDefinition parent) : base(parent)
        {
        }
    }

    public abstract class ViewDefinition : Definition<ViewGroupDefinition>
    {
        protected ViewDefinition(string name)
        {
            Name = name;
            Groups = new PanelDefinitionCollection(this);
        }

        [XmlElement]
        public PanelDefinitionCollection Groups { get; }
    }

    public class IndexViewDefinition : ViewDefinition
    {
        public IndexViewDefinition() : base("Index")
        { }
    }

    public class DeleteViewDefinition : ViewDefinition
    {
        public DeleteViewDefinition() : base("Delete")
        { }
    }

    public class EditViewDefinition : ViewDefinition
    {
        public EditViewDefinition() : base("Edit")
        { }
    }

    public class CreateViewDefinition : ViewDefinition
    {
        public CreateViewDefinition() : base("Create")
        { }
    }

    public class DetailViewDefinition : ViewDefinition
    {
        public DetailViewDefinition() : base("Detail")
        { }
    }

    public class PanelDefinitionCollection : DefinitionCollection<PanelDefinition, ViewDefinition>
    {
        public PanelDefinitionCollection(ViewDefinition parent) : base(parent)
        {
        }
    }

    public class PanelDefinition : Definition<ViewDefinition>
    {
        public PanelDefinition()
        {
            Controls = new ControlDefinitionCollection(this);
        }

        [XmlElement]
        public ControlDefinitionCollection Controls { get; }
    }

    public class ControlDefinitionCollection : DefinitionCollection<ControlDefinition, PanelDefinition>
    {
        public ControlDefinitionCollection(PanelDefinition parent) : base(parent)
        {
        }
    }

    public abstract class ControlDefinition : Definition<PanelDefinition>
    {
    }

    public abstract class ControlDefinition<T> : Definition
    {
    }

    public class StringControlDefinition : ControlDefinition<string>
    {
    }

    public class IntControlDefinition : ControlDefinition<int>
    {
    }

    public class DecimalControlDefinition : ControlDefinition<decimal>
    {
    }

    public class DateTimeControlDefinition : ControlDefinition<DateTime>
    {
    }

    public class BoolControlDefinition : ControlDefinition<bool>
    {
    }
}
