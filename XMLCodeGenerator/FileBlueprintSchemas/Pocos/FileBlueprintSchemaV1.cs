﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.9179
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.1432.
// 

namespace XMLCodeGenerator.Schemas.Pocos.Version1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Blueprint
    {

        private string[] injectedObjectTypeField;

        private File[] fileField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InjectedObjectType")]
        public string[] InjectedObjectType
        {
            get
            {
                return this.injectedObjectTypeField;
            }
            set
            {
                this.injectedObjectTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("File")]
        public File[] File
        {
            get
            {
                return this.fileField;
            }
            set
            {
                this.fileField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class File
    {

        private FileMetadata fileMetadataField;

        private object[] headerField;

        private object itemField;

        private Class[] classField;

        /// <remarks/>
        public FileMetadata FileMetadata
        {
            get
            {
                return this.fileMetadataField;
            }
            set
            {
                this.fileMetadataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Header")]
        public object[] Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DynamicNamespace", typeof(DynamicString))]
        [System.Xml.Serialization.XmlElementAttribute("RawNamespace", typeof(object))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Class")]
        public Class[] Class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class FileMetadata
    {

        private string fileNamePrefixField;

        private object itemField;

        private string fileNameSuffixField;

        private string fileExtensionField;

        /// <remarks/>
        public string FileNamePrefix
        {
            get
            {
                return this.fileNamePrefixField;
            }
            set
            {
                this.fileNamePrefixField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DynamicFileName", typeof(DynamicString))]
        [System.Xml.Serialization.XmlElementAttribute("FileName", typeof(string))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public string FileNameSuffix
        {
            get
            {
                return this.fileNameSuffixField;
            }
            set
            {
                this.fileNameSuffixField = value;
            }
        }

        /// <remarks/>
        public string FileExtension
        {
            get
            {
                return this.fileExtensionField;
            }
            set
            {
                this.fileExtensionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DynamicString
    {

        private uint injectedObjectIndexField;

        private string propertyNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint InjectedObjectIndex
        {
            get
            {
                return this.injectedObjectIndexField;
            }
            set
            {
                this.injectedObjectIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PropertyName
        {
            get
            {
                return this.propertyNameField;
            }
            set
            {
                this.propertyNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Class
    {

        private ClassMetadata classMetadataField;

        private Property[] propertyField;

        private Constructor[] constructorField;

        private Class[] class1Field;

        private Method[] methodField;

        private string accessModifierField;

        private bool isPartialField;

        private bool isStaticField;

        private bool isStaticFieldSpecified;

        public Class()
        {
            this.accessModifierField = "";
            this.isPartialField = false;
            this.isStaticField = false;
        }

        /// <remarks/>
        public ClassMetadata ClassMetadata
        {
            get
            {
                return this.classMetadataField;
            }
            set
            {
                this.classMetadataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Property")]
        public Property[] Property
        {
            get
            {
                return this.propertyField;
            }
            set
            {
                this.propertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Constructor")]
        public Constructor[] Constructor
        {
            get
            {
                return this.constructorField;
            }
            set
            {
                this.constructorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Class")]
        public Class[] Class1
        {
            get
            {
                return this.class1Field;
            }
            set
            {
                this.class1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Method")]
        public Method[] Method
        {
            get
            {
                return this.methodField;
            }
            set
            {
                this.methodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string AccessModifier
        {
            get
            {
                return this.accessModifierField;
            }
            set
            {
                this.accessModifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IsPartial
        {
            get
            {
                return this.isPartialField;
            }
            set
            {
                this.isPartialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IsStatic
        {
            get
            {
                return this.isStaticField;
            }
            set
            {
                this.isStaticField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsStaticSpecified
        {
            get
            {
                return this.isStaticFieldSpecified;
            }
            set
            {
                this.isStaticFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ClassMetadata
    {

        private object itemField;

        private string[] inheritsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ClassName", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("DynamicClassName", typeof(DynamicString))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Inherits")]
        public string[] Inherits
        {
            get
            {
                return this.inheritsField;
            }
            set
            {
                this.inheritsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Property
    {

        private object itemField;

        private string accessModifierField;

        private string returnTypeField;

        private string nameField;

        public Property()
        {
            this.accessModifierField = "";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DynamicContent", typeof(DynamicContent))]
        [System.Xml.Serialization.XmlElementAttribute("RawContent", typeof(string))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string AccessModifier
        {
            get
            {
                return this.accessModifierField;
            }
            set
            {
                this.accessModifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReturnType
        {
            get
            {
                return this.returnTypeField;
            }
            set
            {
                this.returnTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class DynamicContent
    {

        private string rawContentField;

        private DynamicString[] referenceField;

        /// <remarks/>
        public string RawContent
        {
            get
            {
                return this.rawContentField;
            }
            set
            {
                this.rawContentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reference")]
        public DynamicString[] Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Constructor
    {

        private object itemField;

        private Argument[] argumentField;

        private object item1Field;

        private string accessModifierField;

        public Constructor()
        {
            this.accessModifierField = "";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DynamicReturnType", typeof(DynamicString))]
        [System.Xml.Serialization.XmlElementAttribute("RawReturnType", typeof(string))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Argument")]
        public Argument[] Argument
        {
            get
            {
                return this.argumentField;
            }
            set
            {
                this.argumentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DynamicContent", typeof(DynamicContent))]
        [System.Xml.Serialization.XmlElementAttribute("RawContent", typeof(string))]
        public object Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string AccessModifier
        {
            get
            {
                return this.accessModifierField;
            }
            set
            {
                this.accessModifierField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Argument
    {

        private string argumentTypeField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ArgumentType
        {
            get
            {
                return this.argumentTypeField;
            }
            set
            {
                this.argumentTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Method
    {

        private Argument[] argumentField;

        private object itemField;

        private string accessModifierField;

        private bool isStaticField;

        private bool isStaticFieldSpecified;

        private string returnTypeField;

        private string nameField;

        public Method()
        {
            this.accessModifierField = "";
            this.isStaticField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Argument")]
        public Argument[] Argument
        {
            get
            {
                return this.argumentField;
            }
            set
            {
                this.argumentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DynamicContent", typeof(DynamicContent))]
        [System.Xml.Serialization.XmlElementAttribute("RawContent", typeof(string))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string AccessModifier
        {
            get
            {
                return this.accessModifierField;
            }
            set
            {
                this.accessModifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IsStatic
        {
            get
            {
                return this.isStaticField;
            }
            set
            {
                this.isStaticField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsStaticSpecified
        {
            get
            {
                return this.isStaticFieldSpecified;
            }
            set
            {
                this.isStaticFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReturnType
        {
            get
            {
                return this.returnTypeField;
            }
            set
            {
                this.returnTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

}
