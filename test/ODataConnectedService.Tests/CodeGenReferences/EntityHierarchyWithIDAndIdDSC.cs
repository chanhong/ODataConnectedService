//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 2/10/2015 2:53:40 PM
namespace Namespace1.DSC
{
    /// <summary>
    /// There are no comments for EntityContainer in the schema.
    /// </summary>
    public partial class EntityContainer : global::Microsoft.OData.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new EntityContainer object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public EntityContainer(global::System.Uri serviceRoot) : 
                base(serviceRoot, global::Microsoft.OData.Client.ODataProtocolVersion.V4)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
            this.Format.UseJson();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            return clientType.FullName;
        }
        /// <summary>
        /// There are no comments for Set1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public global::Microsoft.OData.Client.DataServiceQuery<EntityType> Set1
        {
            get
            {
                if ((this._Set1 == null))
                {
                    this._Set1 = base.CreateQuery<EntityType>("Set1");
                }
                return this._Set1;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<EntityType> _Set1;
        /// <summary>
        /// There are no comments for Set1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public void AddToSet1(EntityType entityType)
        {
            base.AddObject("Set1", entityType);
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
            private static global::Microsoft.OData.Edm.IEdmModel ParsedModel = LoadModelFromString();
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
            private const string Edmx = @"<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Namespace1.DSC"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityType Name=""EntityBase"">
        <Key>
          <PropertyRef Name=""Id"" />
        </Key>
        <Property Name=""Id"" Type=""Edm.Int32"" Nullable=""false"" />
      </EntityType>
      <EntityType Name=""EntityType"" BaseType=""Namespace1.DSC.EntityBase"">
        <Property Name=""ID"" Type=""Edm.Int32"" Nullable=""false"" />
      </EntityType>
      <EntityContainer Name=""EntityContainer"">
        <EntitySet Name=""Set1"" EntityType=""Namespace1.DSC.EntityType"" />
      </EntityContainer>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
            public static global::Microsoft.OData.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
            private static global::Microsoft.OData.Edm.IEdmModel LoadModelFromString()
            {
                global::System.Xml.XmlReader reader = CreateXmlReader(Edmx);
                try
                {
                    return global::Microsoft.OData.Edm.Csdl.CsdlReader.Parse(reader);
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }
        }
    }
    /// <summary>
    /// There are no comments for EntityBaseSingle in the schema.
    /// </summary>
    public partial class EntityBaseSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EntityBase>
    {
        /// <summary>
        /// Initialize a new EntityBaseSingle object.
        /// </summary>
        public EntityBaseSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EntityBaseSingle object.
        /// </summary>
        public EntityBaseSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EntityBaseSingle object.
        /// </summary>
        public EntityBaseSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EntityBase> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for EntityBase in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    public partial class EntityBase : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EntityBase object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public static EntityBase CreateEntityBase(int ID)
        {
            EntityBase entityBase = new EntityBase();
            entityBase.Id = ID;
            return entityBase;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for EntityTypeSingle in the schema.
    /// </summary>
    public partial class EntityTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EntityType>
    {
        /// <summary>
        /// Initialize a new EntityTypeSingle object.
        /// </summary>
        public EntityTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EntityTypeSingle object.
        /// </summary>
        public EntityTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EntityTypeSingle object.
        /// </summary>
        public EntityTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EntityType> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for EntityType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("Set1")]
    public partial class EntityType : EntityBase
    {
        /// <summary>
        /// Create a new EntityType object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="ID1">Initial value of ID.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public static EntityType CreateEntityType(int ID, int ID1)
        {
            EntityType entityType = new EntityType();
            entityType.Id = ID;
            entityType.ID = ID1;
            return entityType;
        }
        /// <summary>
        /// There are no comments for Property ID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                this.OnIDChanging(value);
                this._ID = value;
                this.OnIDChanged();
                this.OnPropertyChanged("ID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private int _ID;
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
    }
    /// <summary>
    /// Class containing all extension methods
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Get an entity of type global::Namespace1.DSC.EntityBase as global::Namespace1.DSC.EntityBaseSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Namespace1.DSC.EntityBaseSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Namespace1.DSC.EntityBase> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Namespace1.DSC.EntityBaseSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Namespace1.DSC.EntityBase as global::Namespace1.DSC.EntityBaseSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Namespace1.DSC.EntityBaseSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Namespace1.DSC.EntityBase> source,
            int id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Namespace1.DSC.EntityBaseSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Namespace1.DSC.EntityType as global::Namespace1.DSC.EntityTypeSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Namespace1.DSC.EntityTypeSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Namespace1.DSC.EntityType> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Namespace1.DSC.EntityTypeSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Namespace1.DSC.EntityType as global::Namespace1.DSC.EntityTypeSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Namespace1.DSC.EntityTypeSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Namespace1.DSC.EntityType> source,
            int id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Namespace1.DSC.EntityTypeSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Cast an entity of type global::Namespace1.DSC.EntityBase to its derived type global::Namespace1.DSC.EntityType
        /// </summary>
        /// <param name="source">source entity</param>
        public static global::Namespace1.DSC.EntityTypeSingle CastToEntityType(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Namespace1.DSC.EntityBase> source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Namespace1.DSC.EntityType> query = source.CastTo<global::Namespace1.DSC.EntityType>();
            return new global::Namespace1.DSC.EntityTypeSingle(source.Context, query.GetPath(null));
        }
    }
}
