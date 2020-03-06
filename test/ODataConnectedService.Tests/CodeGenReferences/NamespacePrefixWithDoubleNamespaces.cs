//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 2/10/2015 4:10:14 PM
namespace Foo.NamespacePrefixWithDoubleNamespaces
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
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
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
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            global::System.Type resolvedType = this.DefaultResolveType(typeName, "NamespacePrefixWithDoubleNamespaces2", "Foo.NamespacePrefixWithDoubleNamespaces2");
            if ((resolvedType != null))
            {
                return resolvedType;
            }
            resolvedType = this.DefaultResolveType(typeName, "NamespacePrefixWithDoubleNamespaces", "Foo.NamespacePrefixWithDoubleNamespaces");
            if ((resolvedType != null))
            {
                return resolvedType;
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("Foo.NamespacePrefixWithDoubleNamespaces2", global::System.StringComparison.Ordinal))
            {
                return string.Concat("NamespacePrefixWithDoubleNamespaces2.", clientType.Name);
            }
            if (clientType.Namespace.Equals("Foo.NamespacePrefixWithDoubleNamespaces", global::System.StringComparison.Ordinal))
            {
                return string.Concat("NamespacePrefixWithDoubleNamespaces.", clientType.Name);
            }
            return null;
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
        /// There are no comments for Set2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public global::Microsoft.OData.Client.DataServiceQuery<EntityType> Set2
        {
            get
            {
                if ((this._Set2 == null))
                {
                    this._Set2 = base.CreateQuery<EntityType>("Set2");
                }
                return this._Set2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<EntityType> _Set2;
        /// <summary>
        /// There are no comments for Set1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public void AddToSet1(EntityType entityType)
        {
            base.AddObject("Set1", entityType);
        }
        /// <summary>
        /// There are no comments for Set2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public void AddToSet2(EntityType entityType)
        {
            base.AddObject("Set2", entityType);
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
            private static global::Microsoft.OData.Edm.IEdmModel ParsedModel = LoadModelFromString();
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
            private const string Edmx = @"<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""NamespacePrefixWithDoubleNamespaces"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <ComplexType Name=""ComplexType"">
        <Property Name=""Value"" Type=""Edm.String"" Nullable=""false"" />
      </ComplexType>
      <EntityType Name=""EntityType"">
        <Key>
          <PropertyRef Name=""Id"" />
        </Key>
        <Property Name=""Id"" Type=""Edm.Guid"" Nullable=""false"" />
        <Property Name=""Complex"" Type=""NamespacePrefixWithDoubleNamespaces.ComplexType"" Nullable=""true"" />
      </EntityType>
      <EntityContainer Name=""EntityContainer"">
        <EntitySet Name=""Set1"" EntityType=""NamespacePrefixWithDoubleNamespaces.EntityType"" />
        <EntitySet Name=""Set2"" EntityType=""NamespacePrefixWithDoubleNamespaces.EntityType"" />
      </EntityContainer>
    </Schema>
    <Schema Namespace=""NamespacePrefixWithDoubleNamespaces2"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <ComplexType Name=""ComplexType"">
        <Property Name=""Value"" Type=""Edm.String"" Nullable=""false"" />
      </ComplexType>
      <EntityType Name=""EntityType"">
        <Key>
          <PropertyRef Name=""Id"" />
        </Key>
        <Property Name=""Id"" Type=""Edm.Guid"" Nullable=""false"" />
        <Property Name=""Complex"" Type=""NamespacePrefixWithDoubleNamespaces2.ComplexType"" Nullable=""true"" />
      </EntityType>
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
    /// There are no comments for ComplexType in the schema.
    /// </summary>
    public partial class ComplexType
    {
        /// <summary>
        /// Create a new ComplexType object.
        /// </summary>
        /// <param name="value">Initial value of Value.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public static ComplexType CreateComplexType(string value)
        {
            ComplexType complexType = new ComplexType();
            complexType.Value = value;
            return complexType;
        }
        /// <summary>
        /// There are no comments for Property Value in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.OnValueChanging(value);
                this._Value = value;
                this.OnValueChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private string _Value;
        partial void OnValueChanging(string value);
        partial void OnValueChanged();
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
    public partial class EntityType : global::Microsoft.OData.Client.BaseEntityType
    {
        /// <summary>
        /// Create a new EntityType object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public static EntityType CreateEntityType(global::System.Guid ID)
        {
            EntityType entityType = new EntityType();
            entityType.Id = ID;
            return entityType;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public global::System.Guid Id
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
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private global::System.Guid _Id;
        partial void OnIdChanging(global::System.Guid value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Complex in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public global::Foo.NamespacePrefixWithDoubleNamespaces.ComplexType Complex
        {
            get
            {
                return this._Complex;
            }
            set
            {
                this.OnComplexChanging(value);
                this._Complex = value;
                this.OnComplexChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private global::Foo.NamespacePrefixWithDoubleNamespaces.ComplexType _Complex;
        partial void OnComplexChanging(global::Foo.NamespacePrefixWithDoubleNamespaces.ComplexType value);
        partial void OnComplexChanged();
    }
    /// <summary>
    /// Class containing all extension methods
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Get an entity of type global::Foo.NamespacePrefixWithDoubleNamespaces.EntityType as global::Foo.NamespacePrefixWithDoubleNamespaces.EntityTypeSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Foo.NamespacePrefixWithDoubleNamespaces.EntityTypeSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Foo.NamespacePrefixWithDoubleNamespaces.EntityType> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Foo.NamespacePrefixWithDoubleNamespaces.EntityTypeSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Foo.NamespacePrefixWithDoubleNamespaces.EntityType as global::Foo.NamespacePrefixWithDoubleNamespaces.EntityTypeSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Foo.NamespacePrefixWithDoubleNamespaces.EntityTypeSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Foo.NamespacePrefixWithDoubleNamespaces.EntityType> source,
            global::System.Guid id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Foo.NamespacePrefixWithDoubleNamespaces.EntityTypeSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
    }
}
namespace Foo.NamespacePrefixWithDoubleNamespaces2
{
    /// <summary>
    /// There are no comments for ComplexType in the schema.
    /// </summary>
    public partial class ComplexType
    {
        /// <summary>
        /// Create a new ComplexType object.
        /// </summary>
        /// <param name="value">Initial value of Value.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public static ComplexType CreateComplexType(string value)
        {
            ComplexType complexType = new ComplexType();
            complexType.Value = value;
            return complexType;
        }
        /// <summary>
        /// There are no comments for Property Value in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.OnValueChanging(value);
                this._Value = value;
                this.OnValueChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private string _Value;
        partial void OnValueChanging(string value);
        partial void OnValueChanged();
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
    public partial class EntityType : global::Microsoft.OData.Client.BaseEntityType
    {
        /// <summary>
        /// Create a new EntityType object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public static EntityType CreateEntityType(global::System.Guid ID)
        {
            EntityType entityType = new EntityType();
            entityType.Id = ID;
            return entityType;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public global::System.Guid Id
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
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private global::System.Guid _Id;
        partial void OnIdChanging(global::System.Guid value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Complex in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public global::Foo.NamespacePrefixWithDoubleNamespaces2.ComplexType Complex
        {
            get
            {
                return this._Complex;
            }
            set
            {
                this.OnComplexChanging(value);
                this._Complex = value;
                this.OnComplexChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private global::Foo.NamespacePrefixWithDoubleNamespaces2.ComplexType _Complex;
        partial void OnComplexChanging(global::Foo.NamespacePrefixWithDoubleNamespaces2.ComplexType value);
        partial void OnComplexChanged();
    }
    /// <summary>
    /// Class containing all extension methods
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Get an entity of type global::Foo.NamespacePrefixWithDoubleNamespaces2.EntityType as global::Foo.NamespacePrefixWithDoubleNamespaces2.EntityTypeSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Foo.NamespacePrefixWithDoubleNamespaces2.EntityTypeSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Foo.NamespacePrefixWithDoubleNamespaces2.EntityType> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Foo.NamespacePrefixWithDoubleNamespaces2.EntityTypeSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Foo.NamespacePrefixWithDoubleNamespaces2.EntityType as global::Foo.NamespacePrefixWithDoubleNamespaces2.EntityTypeSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Foo.NamespacePrefixWithDoubleNamespaces2.EntityTypeSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Foo.NamespacePrefixWithDoubleNamespaces2.EntityType> source,
            global::System.Guid id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Foo.NamespacePrefixWithDoubleNamespaces2.EntityTypeSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
    }
}
