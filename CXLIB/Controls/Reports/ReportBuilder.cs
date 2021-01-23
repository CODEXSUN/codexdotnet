using System;
using System.Collections.Generic; //--List
using System.IO; //--FileStream, MemoryStream
using System.Text; //--UTF8Encoding

namespace CXLIB
{
    public class ReportBuilder
    {
        public ReportType Report = new ReportType();

        public ReportBuilder()
        {
            string pDataSetName = "MyDataSource";
            string pDataSourceName = "DummyDataSource";

            DataSourceType dataSrc = new DataSourceType(pDataSourceName);
            dataSrc.ConnectionProperties = new ConnectionPropertiesType();
            Report.DataSources.Add(dataSrc);

            DataSetType dataSet = new DataSetType(pDataSetName);
            dataSet.Query.DataSourceName = pDataSourceName;
            Report.DataSets.Add(dataSet);
        }

        public override string ToString()
        {
            return this.ToXml();
        }

        private string ToXml()
        {
            string xml = "";
            xml += "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine;
            xml += "<Report xmlns=\"http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition\"" + Environment.NewLine
                + "         xmlns:rd=\"http://schemas.microsoft.com/SQLServer/reporting/reportdesigner\">" + Environment.NewLine
                ;
            xml += Report.ToXml("");
            xml += "</Report>" + Environment.NewLine;

            return xml;
        }

        public void SaveAs(string pFilePath)
        {
            FileStream vStream = new FileStream(pFilePath, FileMode.Create);
            this.SaveToStream(vStream);
            vStream.Close();
            vStream.Dispose();
        }

        public void SaveToStream(Stream pStream)
        {
            string xml = this.ToXml();
            byte[] vBytes = new UTF8Encoding().GetBytes(xml);
            pStream.Write(vBytes, 0, vBytes.Length);
            pStream.Flush();
        }

        public MemoryStream GetMemoryStream()
        {
            MemoryStream mem = new MemoryStream();
            string xml = this.ToXml();
            byte[] vBytes = new UTF8Encoding().GetBytes(xml);
            mem.Write(vBytes, 0, vBytes.Length);
            mem.Flush();
            mem.Seek(0, SeekOrigin.Begin);
            return mem;
        }

        public static string EncodeElementText(string pText)
        {
            pText = pText
                .Replace("&", "&amp;")
                .Replace("<", "&lt;")
                .Replace(">", "&gt;")
                //.Replace("\"", "&quot;")
                //.Replace("'", "&apos;")
                ;
            return pText;
        }

        public static string EncodeAttributeText(string pText)
        {
            pText = pText
                .Replace("&", "&amp;")
                .Replace("<", "&lt;")
                .Replace(">", "&gt;")
                .Replace("\"", "&quot;")
                //.Replace("'", "&apos;")
                ;
            return pText;
        }

    }//cls//

    public interface IXml
    {
        string ToXml(string pParentElementName);
    }//cls//

    public class ReportType : IXml
    {
        public string Description;
        public string Author;
        public uint AutoRefresh;
        public DataSourcesType DataSources = new DataSourcesType();
        public DataSetsType DataSets = new DataSetsType();
        public BodyType Body = new BodyType(); //==Required==// 
        public ReportParametersType ReportParameters = new ReportParametersType();
        public string Code;
        public SizeType Width = new SizeType(); //==Required==// 
        public PageHeaderFooterType PageHeader;
        public PageHeaderFooterType PageFooter;
        public SizeType PageHeight = new SizeType();
        public SizeType PageWidth = new SizeType();
        public SizeType InteractiveHeight = new SizeType();
        public SizeType InteractiveWidth = new SizeType();
        public SizeType LeftMargin = new SizeType();
        public SizeType RightMargin = new SizeType();
        public SizeType TopMargin = new SizeType();
        public SizeType BottomMargin = new SizeType();
        public EmbeddedImagesType EmbeddedImages = new EmbeddedImagesType();
        public string Language;
        public CodeModulesType CodeModules = new CodeModulesType();
        public ClassesType Classes = new ClassesType();
        public CustomPropertiesType CustomProperties = new CustomPropertiesType();
        public string DataTransform;
        public string DataSchema;
        public string DataElementName;
        public DataElementStyleEnum DataElementStyle;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            if (Description != default(string))
                xml += "<Description>" + ReportBuilder.EncodeElementText(Description.ToString()) + "</Description>" + Environment.NewLine;
            if (Author != default(string))
                xml += "<Author>" + ReportBuilder.EncodeElementText(Author.ToString()) + "</Author>" + Environment.NewLine;
            if (AutoRefresh != default(uint))
                xml += "<AutoRefresh>" + ReportBuilder.EncodeElementText(AutoRefresh.ToString()) + "</AutoRefresh>" + Environment.NewLine;
            if (DataSources != null && DataSources.Count != 0)
                xml += DataSources.ToXml("DataSources");
            if (DataSets != null && DataSets.Count != 0)
                xml += DataSets.ToXml("DataSets");
            xml += Body.ToXml("Body");
            if (ReportParameters != null && ReportParameters.Count != 0)
                xml += ReportParameters.ToXml("ReportParameters");
            if (Code != default(string))
                xml += "<Code>" + ReportBuilder.EncodeElementText(Code.ToString()) + "</Code>" + Environment.NewLine;
            xml += Width.ToXml("Width");
            if (PageHeader != null)
                xml += PageHeader.ToXml("PageHeader");
            if (PageFooter != null)
                xml += PageFooter.ToXml("PageFooter");
            if (PageHeight != null)
                xml += PageHeight.ToXml("PageHeight");
            if (PageWidth != null)
                xml += PageWidth.ToXml("PageWidth");
            if (InteractiveHeight != null)
                xml += InteractiveHeight.ToXml("InteractiveHeight");
            if (InteractiveWidth != null)
                xml += InteractiveWidth.ToXml("InteractiveWidth");
            if (LeftMargin != null)
                xml += LeftMargin.ToXml("LeftMargin");
            if (RightMargin != null)
                xml += RightMargin.ToXml("RightMargin");
            if (TopMargin != null)
                xml += TopMargin.ToXml("TopMargin");
            if (BottomMargin != null)
                xml += BottomMargin.ToXml("BottomMargin");
            if (EmbeddedImages != null && EmbeddedImages.Count != 0)
                xml += EmbeddedImages.ToXml("EmbeddedImages");
            if (Language != default(string))
                xml += "<Language>" + ReportBuilder.EncodeElementText(Language.ToString()) + "</Language>" + Environment.NewLine;
            if (CodeModules != null && CodeModules.Count != 0)
                xml += CodeModules.ToXml("CodeModules");
            if (Classes != null && Classes.Count != 0)
                xml += Classes.ToXml("Classes");
            if (CustomProperties != null && CustomProperties.Count != 0)
                xml += CustomProperties.ToXml("CustomProperties");
            if (DataTransform != default(string))
                xml += "<DataTransform>" + ReportBuilder.EncodeElementText(DataTransform.ToString()) + "</DataTransform>" + Environment.NewLine;
            if (DataSchema != default(string))
                xml += "<DataSchema>" + ReportBuilder.EncodeElementText(DataSchema.ToString()) + "</DataSchema>" + Environment.NewLine;
            if (DataElementName != default(string))
                xml += "<DataElementName>" + ReportBuilder.EncodeElementText(DataElementName.ToString()) + "</DataElementName>" + Environment.NewLine;
            if (DataElementStyle != DataElementStyleEnum.__NotSet__)
                xml += "<DataElementStyle>" + ReportBuilder.EncodeElementText(DataElementStyle.ToString()) + "</DataElementStyle>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class ReportParametersType : List<ReportParameterType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (ReportParameterType vReportParameter in this)
            {
                xml += vReportParameter.ToXml("ReportParameter");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class ReportParameterType : IXml
    {
        public string Name = ""; //==Required==// 

        public ReportParameterType(string pName)
        {
            Name = pName;
        }

        public DataTypeEnum DataType; //==Required==// 
        public bool Nullable;
        public DefaultValueType DefaultValue;
        public bool AllowBlank;
        public string Prompt;
        public ValidValuesType ValidValues;
        public bool Hidden;
        public bool MultiValue;
        public UsedInQueryEnum UsedInQuery;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            attribs += " Name=\"" + ReportBuilder.EncodeAttributeText(Name) + "\"";
            if (attribs.Trim() == "") attribs = "";


            xml += "<DataType>" + ReportBuilder.EncodeElementText(DataType.ToString()) + "</DataType>" + Environment.NewLine;
            if (Nullable != default(bool))
                xml += "<Nullable>" + ReportBuilder.EncodeElementText(Nullable.ToString().ToLower()) + "</Nullable>" + Environment.NewLine;
            if (DefaultValue != null)
                xml += DefaultValue.ToXml("DefaultValue");
            if (AllowBlank != default(bool))
                xml += "<AllowBlank>" + ReportBuilder.EncodeElementText(AllowBlank.ToString().ToLower()) + "</AllowBlank>" + Environment.NewLine;
            if (Prompt != default(string))
                xml += "<Prompt>" + ReportBuilder.EncodeElementText(Prompt.ToString()) + "</Prompt>" + Environment.NewLine;
            if (ValidValues != null)
                xml += ValidValues.ToXml("ValidValues");
            if (Hidden != default(bool))
                xml += "<Hidden>" + ReportBuilder.EncodeElementText(Hidden.ToString().ToLower()) + "</Hidden>" + Environment.NewLine;
            if (MultiValue != default(bool))
                xml += "<MultiValue>" + ReportBuilder.EncodeElementText(MultiValue.ToString().ToLower()) + "</MultiValue>" + Environment.NewLine;
            if (UsedInQuery != UsedInQueryEnum.__NotSet__)
                xml += "<UsedInQuery>" + ReportBuilder.EncodeElementText(UsedInQuery.ToString()) + "</UsedInQuery>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class ValidValuesType : IXml
    {
        public DataSetReferenceType DataSetReference;
        public ParameterValuesType ParameterValues = new ParameterValuesType();

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            if (DataSetReference != null)
                xml += DataSetReference.ToXml("DataSetReference");
            if (ParameterValues != null && ParameterValues.Count != 0)
                xml += ParameterValues.ToXml("ParameterValues");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class DataSetReferenceType : IXml
    {
        public string DataSetName = ""; //==Required==// 
        public string ValueField = ""; //==Required==// 
        public string LabelField;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += "<DataSetName>" + ReportBuilder.EncodeElementText(DataSetName.ToString()) + "</DataSetName>" + Environment.NewLine;
            xml += "<ValueField>" + ReportBuilder.EncodeElementText(ValueField.ToString()) + "</ValueField>" + Environment.NewLine;
            if (LabelField != default(string))
                xml += "<LabelField>" + ReportBuilder.EncodeElementText(LabelField.ToString()) + "</LabelField>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class ParameterValuesType : List<ParameterValueType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (ParameterValueType vParameterValue in this)
            {
                xml += vParameterValue.ToXml("ParameterValue");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class ParameterValueType : IXml
    {
        public string Value;
        public string Label;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            if (Value != default(string))
                xml += "<Value>" + ReportBuilder.EncodeElementText(Value.ToString()) + "</Value>" + Environment.NewLine;
            if (Label != default(string))
                xml += "<Label>" + ReportBuilder.EncodeElementText(Label.ToString()) + "</Label>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class DefaultValueType : IXml
    {
        public DataSetReferenceType DataSetReference;
        public ValuesType Values = new ValuesType();

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            if (DataSetReference != null)
                xml += DataSetReference.ToXml("DataSetReference");
            if (Values != null && Values.Count != 0)
                xml += Values.ToXml("Values");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class ValuesType : List<string>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (string vValue in this)
            {
                xml += "<Value>" + ReportBuilder.EncodeElementText(vValue.ToString()) + "</Value>" + Environment.NewLine;
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class DataSetsType : List<DataSetType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (DataSetType vDataSet in this)
            {
                xml += vDataSet.ToXml("DataSet");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class DataSetType : IXml
    {
        public string Name = ""; //==Required==// 

        public DataSetType(string pName)
        {
            Name = pName;
        }

        public FieldsType Fields = new FieldsType();
        public QueryType Query = new QueryType(); //==Required==// 
        public CaseSensitivityEnum CaseSensitivity;
        public string Collation;
        public AccentSensitivityEnum AccentSensitivity;
        public KanatypeSensitivityEnum KanatypeSensitivity;
        public WidthSensitivityEnum WidthSensitivity;
        public FiltersType Filters = new FiltersType();

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            attribs += " Name=\"" + ReportBuilder.EncodeAttributeText(Name) + "\"";
            if (attribs.Trim() == "") attribs = "";


            if (Fields != null && Fields.Count != 0)
                xml += Fields.ToXml("Fields");
            xml += Query.ToXml("Query");
            if (CaseSensitivity != CaseSensitivityEnum.__NotSet__)
                xml += "<CaseSensitivity>" + ReportBuilder.EncodeElementText(CaseSensitivity.ToString()) + "</CaseSensitivity>" + Environment.NewLine;
            if (Collation != default(string))
                xml += "<Collation>" + ReportBuilder.EncodeElementText(Collation.ToString()) + "</Collation>" + Environment.NewLine;
            if (AccentSensitivity != AccentSensitivityEnum.__NotSet__)
                xml += "<AccentSensitivity>" + ReportBuilder.EncodeElementText(AccentSensitivity.ToString()) + "</AccentSensitivity>" + Environment.NewLine;
            if (KanatypeSensitivity != KanatypeSensitivityEnum.__NotSet__)
                xml += "<KanatypeSensitivity>" + ReportBuilder.EncodeElementText(KanatypeSensitivity.ToString()) + "</KanatypeSensitivity>" + Environment.NewLine;
            if (WidthSensitivity != WidthSensitivityEnum.__NotSet__)
                xml += "<WidthSensitivity>" + ReportBuilder.EncodeElementText(WidthSensitivity.ToString()) + "</WidthSensitivity>" + Environment.NewLine;
            if (Filters != null && Filters.Count != 0)
                xml += Filters.ToXml("Filters");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class FieldsType : List<FieldType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (FieldType vField in this)
            {
                xml += vField.ToXml("Field");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class FieldType : IXml
    {
        public string Name = ""; //==Required==// 

        public FieldType(string pName)
        {
            Name = pName;
        }

        public string DataField;
        public string Value;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            attribs += " Name=\"" + ReportBuilder.EncodeAttributeText(Name) + "\"";
            if (attribs.Trim() == "") attribs = "";


            if (DataField != default(string))
                xml += "<DataField>" + ReportBuilder.EncodeElementText(DataField.ToString()) + "</DataField>" + Environment.NewLine;
            if (Value != default(string))
                xml += "<Value>" + ReportBuilder.EncodeElementText(Value.ToString()) + "</Value>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class QueryType : IXml
    {
        public string DataSourceName = ""; //==Required==// 
        public CommandTypeEnum CommandType;
        public string CommandText = ""; //==Required==// 
        public QueryParametersType QueryParameters = new QueryParametersType();
        public uint Timeout;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += "<DataSourceName>" + ReportBuilder.EncodeElementText(DataSourceName.ToString()) + "</DataSourceName>" + Environment.NewLine;
            if (CommandType != CommandTypeEnum.__NotSet__)
                xml += "<CommandType>" + ReportBuilder.EncodeElementText(CommandType.ToString()) + "</CommandType>" + Environment.NewLine;
            xml += "<CommandText>" + ReportBuilder.EncodeElementText(CommandText.ToString()) + "</CommandText>" + Environment.NewLine;
            if (QueryParameters != null && QueryParameters.Count != 0)
                xml += QueryParameters.ToXml("QueryParameters");
            if (Timeout != default(uint))
                xml += "<Timeout>" + ReportBuilder.EncodeElementText(Timeout.ToString()) + "</Timeout>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class DataSourcesType : List<DataSourceType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (DataSourceType vDataSource in this)
            {
                xml += vDataSource.ToXml("DataSource");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class DataSourceType : IXml
    {
        public string Name = ""; //==Required==// 

        public DataSourceType(string pName)
        {
            Name = pName;
        }

        public bool Transaction;
        public ConnectionPropertiesType ConnectionProperties;
        public string DataSourceReference;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            attribs += " Name=\"" + ReportBuilder.EncodeAttributeText(Name) + "\"";
            if (attribs.Trim() == "") attribs = "";


            if (Transaction != default(bool))
                xml += "<Transaction>" + ReportBuilder.EncodeElementText(Transaction.ToString().ToLower()) + "</Transaction>" + Environment.NewLine;
            if (ConnectionProperties != null)
                xml += ConnectionProperties.ToXml("ConnectionProperties");
            if (DataSourceReference != default(string))
                xml += "<DataSourceReference>" + ReportBuilder.EncodeElementText(DataSourceReference.ToString()) + "</DataSourceReference>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class ConnectionPropertiesType : IXml
    {
        public string DataProvider = ""; //==Required==// 
        public string ConnectString = ""; //==Required==// 
        public bool IntegratedSecurity;
        public string Prompt;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += "<DataProvider>" + ReportBuilder.EncodeElementText(DataProvider.ToString()) + "</DataProvider>" + Environment.NewLine;
            xml += "<ConnectString>" + ReportBuilder.EncodeElementText(ConnectString.ToString()) + "</ConnectString>" + Environment.NewLine;
            if (IntegratedSecurity != default(bool))
                xml += "<IntegratedSecurity>" + ReportBuilder.EncodeElementText(IntegratedSecurity.ToString().ToLower()) + "</IntegratedSecurity>" + Environment.NewLine;
            if (Prompt != default(string))
                xml += "<Prompt>" + ReportBuilder.EncodeElementText(Prompt.ToString()) + "</Prompt>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class QueryParametersType : List<QueryParameterType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (QueryParameterType vQueryParameter in this)
            {
                xml += vQueryParameter.ToXml("QueryParameter");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class QueryParameterType : IXml
    {
        public string Name = ""; //==Required==// 

        public QueryParameterType(string pName)
        {
            Name = pName;
        }

        public string Value = ""; //==Required==// 

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            attribs += " Name=\"" + ReportBuilder.EncodeAttributeText(Name) + "\"";
            if (attribs.Trim() == "") attribs = "";


            xml += "<Value>" + ReportBuilder.EncodeElementText(Value.ToString()) + "</Value>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class CodeModulesType : List<string>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (string vCodeModule in this)
            {
                xml += "<CodeModule>" + ReportBuilder.EncodeElementText(vCodeModule.ToString()) + "</CodeModule>" + Environment.NewLine;
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class ClassesType : List<ClassType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (ClassType vClass in this)
            {
                xml += vClass.ToXml("Class");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class ClassType : IXml
    {
        public string ClassName = ""; //==Required==// 
        public string InstanceName = ""; //==Required==// 

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += "<ClassName>" + ReportBuilder.EncodeElementText(ClassName.ToString()) + "</ClassName>" + Environment.NewLine;
            xml += "<InstanceName>" + ReportBuilder.EncodeElementText(InstanceName.ToString()) + "</InstanceName>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class BodyType : IXml
    {
        public ReportItemsType ReportItems = new ReportItemsType();
        public SizeType Height = new SizeType(); //==Required==// 
        public uint Columns;
        public SizeType ColumnSpacing = new SizeType();
        public StyleType Style = new StyleType();

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            if (ReportItems != null && ReportItems.Count != 0)
                xml += ReportItems.ToXml("ReportItems");
            xml += Height.ToXml("Height");
            if (Columns != default(uint))
                xml += "<Columns>" + ReportBuilder.EncodeElementText(Columns.ToString()) + "</Columns>" + Environment.NewLine;
            if (ColumnSpacing != null)
                xml += ColumnSpacing.ToXml("ColumnSpacing");
            if (Style != null)
                xml += Style.ToXml("Style");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class PageHeaderFooterType : IXml
    {
        public SizeType Height = new SizeType(); //==Required==// 
        public bool PrintOnFirstPage;
        public bool PrintOnLastPage;
        public ReportItemsType ReportItems = new ReportItemsType();
        public StyleType Style = new StyleType();

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += Height.ToXml("Height");
            if (PrintOnFirstPage != default(bool))
                xml += "<PrintOnFirstPage>" + ReportBuilder.EncodeElementText(PrintOnFirstPage.ToString().ToLower()) + "</PrintOnFirstPage>" + Environment.NewLine;
            if (PrintOnLastPage != default(bool))
                xml += "<PrintOnLastPage>" + ReportBuilder.EncodeElementText(PrintOnLastPage.ToString().ToLower()) + "</PrintOnLastPage>" + Environment.NewLine;
            if (ReportItems != null && ReportItems.Count != 0)
                xml += ReportItems.ToXml("ReportItems");
            if (Style != null)
                xml += Style.ToXml("Style");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class EmbeddedImagesType : List<EmbeddedImageType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (EmbeddedImageType vEmbeddedImage in this)
            {
                xml += vEmbeddedImage.ToXml("EmbeddedImage");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class EmbeddedImageType : IXml
    {
        public string Name = ""; //==Required==// 

        public EmbeddedImageType(string pName)
        {
            Name = pName;
        }

        public string MIMEType = ""; //==Required==// 
        public string ImageData = ""; //==Required==// 

        /*
        .bmp    image/bmp
        .gif    image/gif
        .jpeg   image/jpeg
        .png    image/png
        .tif    image/tiff
        .emf    image/emf
        */

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            attribs += " Name=\"" + ReportBuilder.EncodeAttributeText(Name) + "\"";
            if (attribs.Trim() == "") attribs = "";


            xml += "<MIMEType>" + ReportBuilder.EncodeElementText(MIMEType.ToString()) + "</MIMEType>" + Environment.NewLine;
            xml += "<ImageData>" + ReportBuilder.EncodeElementText(ImageData.ToString()) + "</ImageData>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class ReportItemsType : List<ReportItemType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            foreach (ReportItemType vReportItem in this)
            {
                if (vReportItem is LineType)
                {
                    xml += vReportItem.ToXml("Line");
                }
                else if (vReportItem is RectangleType)
                {
                    xml += vReportItem.ToXml("Rectangle");
                }
                else if (vReportItem is TextboxType)
                {
                    xml += vReportItem.ToXml("Textbox");
                }
                else if (vReportItem is ImageType)
                {
                    xml += vReportItem.ToXml("Image");
                }
                else if (vReportItem is SubreportType)
                {
                    xml += vReportItem.ToXml("Subreport");
                }
                else if (vReportItem is ListType)
                {
                    xml += vReportItem.ToXml("List");
                }
                else if (vReportItem is MatrixType)
                {
                    xml += vReportItem.ToXml("Matrix");
                }
                else if (vReportItem is TableType)
                {
                    xml += vReportItem.ToXml("Table");
                }
                else if (vReportItem is ChartType)
                {
                    xml += vReportItem.ToXml("Chart");
                }
                else if (vReportItem is CustomReportItemType)
                {
                    xml += vReportItem.ToXml("CustomReportItem");
                }
            }


            if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                string crlf = "";
                if (pParentElementName == "SizeType")
                {
                    crlf = "";
                }
                else
                {
                    crlf = Environment.NewLine;
                }
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public interface ReportItemType : IXml
    {

    }//cls//

    public class ActionType : IXml
    {
        public string Hyperlink;
        public DrillthroughType Drillthrough;
        public string BookmarkLink;
        public string Label;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            if (Hyperlink != default(string))
                xml += "<Hyperlink>" + ReportBuilder.EncodeElementText(Hyperlink.ToString()) + "</Hyperlink>" + Environment.NewLine;
            if (Drillthrough != null)
                xml += Drillthrough.ToXml("Drillthrough");
            if (BookmarkLink != default(string))
                xml += "<BookmarkLink>" + ReportBuilder.EncodeElementText(BookmarkLink.ToString()) + "</BookmarkLink>" + Environment.NewLine;
            if (Label != default(string))
                xml += "<Label>" + ReportBuilder.EncodeElementText(Label.ToString()) + "</Label>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class DrillthroughType : IXml
    {
        public string ReportName = ""; //==Required==// 
        public ParametersType Parameters = new ParametersType();
        public string BookmarkLink;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += "<ReportName>" + ReportBuilder.EncodeElementText(ReportName.ToString()) + "</ReportName>" + Environment.NewLine;
            if (Parameters != null && Parameters.Count != 0)
                xml += Parameters.ToXml("Parameters");
            if (BookmarkLink != default(string))
                xml += "<BookmarkLink>" + ReportBuilder.EncodeElementText(BookmarkLink.ToString()) + "</BookmarkLink>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class VisibilityType : IXml
    {
        public string Hidden;
        public string ToggleItem;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            if (Hidden != default(string))
                xml += "<Hidden>" + ReportBuilder.EncodeElementText(Hidden.ToString()) + "</Hidden>" + Environment.NewLine;
            if (ToggleItem != default(string))
                xml += "<ToggleItem>" + ReportBuilder.EncodeElementText(ToggleItem.ToString()) + "</ToggleItem>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class LineType : ReportItemType, IXml
    {
        public string Name = ""; //==Required==// 

        public LineType(string pName)
        {
            Name = pName;
        }

        public StyleType Style = new StyleType();
        public ActionType Action;
        public SizeType Top = new SizeType();
        public SizeType Left = new SizeType();
        public SizeType Height = new SizeType();
        public SizeType Width = new SizeType();
        public uint ZIndex;
        public VisibilityType Visibility;
        public string ToolTip;
        public string Label;
        public string LinkToChild;
        public string Bookmark;
        public string RepeatWith;
        public CustomPropertiesType CustomProperties = new CustomPropertiesType();
        public string DataElementName;
        public DataElementOutputEnum DataElementOutput;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            attribs += " Name=\"" + ReportBuilder.EncodeAttributeText(Name) + "\"";
            if (attribs.Trim() == "") attribs = "";


            if (Style != null)
                xml += Style.ToXml("Style");
            if (Action != null)
                xml += Action.ToXml("Action");
            if (Top != null)
                xml += Top.ToXml("Top");
            if (Left != null)
                xml += Left.ToXml("Left");
            if (Height != null)
                xml += Height.ToXml("Height");
            if (Width != null)
                xml += Width.ToXml("Width");
            if (ZIndex != default(uint))
                xml += "<ZIndex>" + ReportBuilder.EncodeElementText(ZIndex.ToString()) + "</ZIndex>" + Environment.NewLine;
            if (Visibility != null)
                xml += Visibility.ToXml("Visibility");
            if (ToolTip != default(string))
                xml += "<ToolTip>" + ReportBuilder.EncodeElementText(ToolTip.ToString()) + "</ToolTip>" + Environment.NewLine;
            if (Label != default(string))
                xml += "<Label>" + ReportBuilder.EncodeElementText(Label.ToString()) + "</Label>" + Environment.NewLine;
            if (LinkToChild != default(string))
                xml += "<LinkToChild>" + ReportBuilder.EncodeElementText(LinkToChild.ToString()) + "</LinkToChild>" + Environment.NewLine;
            if (Bookmark != default(string))
                xml += "<Bookmark>" + ReportBuilder.EncodeElementText(Bookmark.ToString()) + "</Bookmark>" + Environment.NewLine;
            if (RepeatWith != default(string))
                xml += "<RepeatWith>" + ReportBuilder.EncodeElementText(RepeatWith.ToString()) + "</RepeatWith>" + Environment.NewLine;
            if (CustomProperties != null && CustomProperties.Count != 0)
                xml += CustomProperties.ToXml("CustomProperties");
            if (DataElementName != default(string))
                xml += "<DataElementName>" + ReportBuilder.EncodeElementText(DataElementName.ToString()) + "</DataElementName>" + Environment.NewLine;
            if (DataElementOutput != DataElementOutputEnum.__NotSet__)
                xml += "<DataElementOutput>" + ReportBuilder.EncodeElementText(DataElementOutput.ToString()) + "</DataElementOutput>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class RectangleType : ReportItemType, IXml
    {
        public string Name = ""; //==Required==// 

        public RectangleType(string pName)
        {
            Name = pName;
        }

        public StyleType Style = new StyleType();
        public ActionType Action;
        public SizeType Top = new SizeType();
        public SizeType Left = new SizeType();
        public SizeType Height = new SizeType();
        public SizeType Width = new SizeType();
        public uint ZIndex;
        public VisibilityType Visibility;
        public string ToolTip;
        public string Label;
        public string LinkToChild;
        public string Bookmark;
        public string RepeatWith;
        public CustomPropertiesType CustomProperties = new CustomPropertiesType();
        public ReportItemsType ReportItems = new ReportItemsType();
        public bool PageBreakAtStart;
        public bool PageBreakAtEnd;
        public string DataElementName;
        public DataElementOutputEnum1 DataElementOutput;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            attribs += " Name=\"" + ReportBuilder.EncodeAttributeText(Name) + "\"";
            if (attribs.Trim() == "") attribs = "";


            if (Style != null)
                xml += Style.ToXml("Style");
            if (Action != null)
                xml += Action.ToXml("Action");
            if (Top != null)
                xml += Top.ToXml("Top");
            if (Left != null)
                xml += Left.ToXml("Left");
            if (Height != null)
                xml += Height.ToXml("Height");
            if (Width != null)
                xml += Width.ToXml("Width");
            if (ZIndex != default(uint))
                xml += "<ZIndex>" + ReportBuilder.EncodeElementText(ZIndex.ToString()) + "</ZIndex>" + Environment.NewLine;
            if (Visibility != null)
                xml += Visibility.ToXml("Visibility");
            if (ToolTip != default(string))
                xml += "<ToolTip>" + ReportBuilder.EncodeElementText(ToolTip.ToString()) + "</ToolTip>" + Environment.NewLine;
            if (Label != default(string))
                xml += "<Label>" + ReportBuilder.EncodeElementText(Label.ToString()) + "</Label>" + Environment.NewLine;
            if (LinkToChild != default(string))
                xml += "<LinkToChild>" + ReportBuilder.EncodeElementText(LinkToChild.ToString()) + "</LinkToChild>" + Environment.NewLine;
            if (Bookmark != default(string))
                xml += "<Bookmark>" + ReportBuilder.EncodeElementText(Bookmark.ToString()) + "</Bookmark>" + Environment.NewLine;
            if (RepeatWith != default(string))
                xml += "<RepeatWith>" + ReportBuilder.EncodeElementText(RepeatWith.ToString()) + "</RepeatWith>" + Environment.NewLine;
            if (CustomProperties != null && CustomProperties.Count != 0)
                xml += CustomProperties.ToXml("CustomProperties");
            if (ReportItems != null && ReportItems.Count != 0)
                xml += ReportItems.ToXml("ReportItems");
            if (PageBreakAtStart != default(bool))
                xml += "<PageBreakAtStart>" + ReportBuilder.EncodeElementText(PageBreakAtStart.ToString().ToLower()) + "</PageBreakAtStart>" + Environment.NewLine;
            if (PageBreakAtEnd != default(bool))
                xml += "<PageBreakAtEnd>" + ReportBuilder.EncodeElementText(PageBreakAtEnd.ToString().ToLower()) + "</PageBreakAtEnd>" + Environment.NewLine;
            if (DataElementName != default(string))
                xml += "<DataElementName>" + ReportBuilder.EncodeElementText(DataElementName.ToString()) + "</DataElementName>" + Environment.NewLine;
            if (DataElementOutput != DataElementOutputEnum1.__NotSet__)
                xml += "<DataElementOutput>" + ReportBuilder.EncodeElementText(DataElementOutput.ToString()) + "</DataElementOutput>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class TextboxType : ReportItemType, IXml
    {
        public string Name = ""; //==Required==// 

        public TextboxType(string pName)
        {
            Name = pName;
        }

        public StyleType Style = new StyleType();
        public ActionType Action;
        public SizeType Top = new SizeType();
        public SizeType Left = new SizeType();
        public SizeType Height = new SizeType();
        public SizeType Width = new SizeType();
        public uint ZIndex;
        public VisibilityType Visibility;
        public string ToolTip;
        public string Label;
        public string LinkToChild;
        public string Bookmark;
        public string RepeatWith;
        public CustomPropertiesType CustomProperties = new CustomPropertiesType();
        public string Value = ""; //==Required==// 
        public bool CanGrow;
        public bool CanShrink;
        public string HideDuplicates;
        public ToggleImageType ToggleImage;
        public UserSortType UserSort;
        public string DataElementName;
        public DataElementOutputEnum2 DataElementOutput;
        public DataElementStyleEnum1 DataElementStyle;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            attribs += " Name=\"" + ReportBuilder.EncodeAttributeText(Name) + "\"";
            if (attribs.Trim() == "") attribs = "";


            if (Style != null)
                xml += Style.ToXml("Style");
            if (Action != null)
                xml += Action.ToXml("Action");
            if (Top != null)
                xml += Top.ToXml("Top");
            if (Left != null)
                xml += Left.ToXml("Left");
            if (Height != null)
                xml += Height.ToXml("Height");
            if (Width != null)
                xml += Width.ToXml("Width");
            if (ZIndex != default(uint))
                xml += "<ZIndex>" + ReportBuilder.EncodeElementText(ZIndex.ToString()) + "</ZIndex>" + Environment.NewLine;
            if (Visibility != null)
                xml += Visibility.ToXml("Visibility");
            if (ToolTip != default(string))
                xml += "<ToolTip>" + ReportBuilder.EncodeElementText(ToolTip.ToString()) + "</ToolTip>" + Environment.NewLine;
            if (Label != default(string))
                xml += "<Label>" + ReportBuilder.EncodeElementText(Label.ToString()) + "</Label>" + Environment.NewLine;
            if (LinkToChild != default(string))
                xml += "<LinkToChild>" + ReportBuilder.EncodeElementText(LinkToChild.ToString()) + "</LinkToChild>" + Environment.NewLine;
            if (Bookmark != default(string))
                xml += "<Bookmark>" + ReportBuilder.EncodeElementText(Bookmark.ToString()) + "</Bookmark>" + Environment.NewLine;
            if (RepeatWith != default(string))
                xml += "<RepeatWith>" + ReportBuilder.EncodeElementText(RepeatWith.ToString()) + "</RepeatWith>" + Environment.NewLine;
            if (CustomProperties != null && CustomProperties.Count != 0)
                xml += CustomProperties.ToXml("CustomProperties");
            xml += "<Value>" + ReportBuilder.EncodeElementText(Value.ToString()) + "</Value>" + Environment.NewLine;
            if (CanGrow != default(bool))
                xml += "<CanGrow>" + ReportBuilder.EncodeElementText(CanGrow.ToString().ToLower()) + "</CanGrow>" + Environment.NewLine;
            if (CanShrink != default(bool))
                xml += "<CanShrink>" + ReportBuilder.EncodeElementText(CanShrink.ToString().ToLower()) + "</CanShrink>" + Environment.NewLine;
            if (HideDuplicates != default(string))
                xml += "<HideDuplicates>" + ReportBuilder.EncodeElementText(HideDuplicates.ToString()) + "</HideDuplicates>" + Environment.NewLine;
            if (ToggleImage != null)
                xml += ToggleImage.ToXml("ToggleImage");
            if (UserSort != null)
                xml += UserSort.ToXml("UserSort");
            if (DataElementName != default(string))
                xml += "<DataElementName>" + ReportBuilder.EncodeElementText(DataElementName.ToString()) + "</DataElementName>" + Environment.NewLine;
            if (DataElementOutput != DataElementOutputEnum2.__NotSet__)
                xml += "<DataElementOutput>" + ReportBuilder.EncodeElementText(DataElementOutput.ToString()) + "</DataElementOutput>" + Environment.NewLine;
            if (DataElementStyle != DataElementStyleEnum1.__NotSet__)
                xml += "<DataElementStyle>" + ReportBuilder.EncodeElementText(DataElementStyle.ToString()) + "</DataElementStyle>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class ToggleImageType : IXml
    {
        public string InitialState = ""; //==Required==// 

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += "<InitialState>" + ReportBuilder.EncodeElementText(InitialState.ToString()) + "</InitialState>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class ImageType : ReportItemType, IXml
    {
        public string Name = ""; //==Required==// 

        public ImageType(string pName)
        {
            Name = pName;
        }

        public StyleType Style = new StyleType();
        public ActionType Action;
        public SizeType Top = new SizeType();
        public SizeType Left = new SizeType();
        public SizeType Height = new SizeType();
        public SizeType Width = new SizeType();
        public uint ZIndex;
        public VisibilityType Visibility;
        public string ToolTip;
        public string Label;
        public string LinkToChild;
        public string Bookmark;
        public string RepeatWith;
        public CustomPropertiesType CustomProperties = new CustomPropertiesType();
        public SourceEnum Source; //==Required==// 
        public string Value = ""; //==Required==// 
        public string MIMEType;
        public SizingEnum Sizing;
        public string DataElementName;
        public DataElementOutputEnum3 DataElementOutput;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            attribs += " Name=\"" + ReportBuilder.EncodeAttributeText(Name) + "\"";
            if (attribs.Trim() == "") attribs = "";


            if (Style != null)
                xml += Style.ToXml("Style");
            if (Action != null)
                xml += Action.ToXml("Action");
            if (Top != null)
                xml += Top.ToXml("Top");
            if (Left != null)
                xml += Left.ToXml("Left");
            if (Height != null)
                xml += Height.ToXml("Height");
            if (Width != null)
                xml += Width.ToXml("Width");
            if (ZIndex != default(uint))
                xml += "<ZIndex>" + ReportBuilder.EncodeElementText(ZIndex.ToString()) + "</ZIndex>" + Environment.NewLine;
            if (Visibility != null)
                xml += Visibility.ToXml("Visibility");
            if (ToolTip != default(string))
                xml += "<ToolTip>" + ReportBuilder.EncodeElementText(ToolTip.ToString()) + "</ToolTip>" + Environment.NewLine;
            if (Label != default(string))
                xml += "<Label>" + ReportBuilder.EncodeElementText(Label.ToString()) + "</Label>" + Environment.NewLine;
            if (LinkToChild != default(string))
                xml += "<LinkToChild>" + ReportBuilder.EncodeElementText(LinkToChild.ToString()) + "</LinkToChild>" + Environment.NewLine;
            if (Bookmark != default(string))
                xml += "<Bookmark>" + ReportBuilder.EncodeElementText(Bookmark.ToString()) + "</Bookmark>" + Environment.NewLine;
            if (RepeatWith != default(string))
                xml += "<RepeatWith>" + ReportBuilder.EncodeElementText(RepeatWith.ToString()) + "</RepeatWith>" + Environment.NewLine;
            if (CustomProperties != null && CustomProperties.Count != 0)
                xml += CustomProperties.ToXml("CustomProperties");
            xml += "<Source>" + ReportBuilder.EncodeElementText(Source.ToString()) + "</Source>" + Environment.NewLine;
            xml += "<Value>" + ReportBuilder.EncodeElementText(Value.ToString()) + "</Value>" + Environment.NewLine;
            if (MIMEType != default(string))
                xml += "<MIMEType>" + ReportBuilder.EncodeElementText(MIMEType.ToString()) + "</MIMEType>" + Environment.NewLine;
            if (Sizing != SizingEnum.__NotSet__)
                xml += "<Sizing>" + ReportBuilder.EncodeElementText(Sizing.ToString()) + "</Sizing>" + Environment.NewLine;
            if (DataElementName != default(string))
                xml += "<DataElementName>" + ReportBuilder.EncodeElementText(DataElementName.ToString()) + "</DataElementName>" + Environment.NewLine;
            if (DataElementOutput != DataElementOutputEnum3.__NotSet__)
                xml += "<DataElementOutput>" + ReportBuilder.EncodeElementText(DataElementOutput.ToString()) + "</DataElementOutput>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class SubreportType : ReportItemType, IXml
    {
        public string Name = ""; //==Required==// 

        public SubreportType(string pName)
        {
            Name = pName;
        }

        public StyleType Style = new StyleType();
        public ActionType Action;
        public SizeType Top = new SizeType();
        public SizeType Left = new SizeType();
        public SizeType Height = new SizeType();
        public SizeType Width = new SizeType();
        public uint ZIndex;
        public VisibilityType Visibility;
        public string ToolTip;
        public string Label;
        public string LinkToChild;
        public string Bookmark;
        public string RepeatWith;
        public CustomPropertiesType CustomProperties = new CustomPropertiesType();
        public string ReportName = ""; //==Required==// 
        public ParametersType Parameters = new ParametersType();
        public string NoRows;
        public bool MergeTransactions;
        public string DataElementName;
        public DataElementOutputEnum4 DataElementOutput;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            attribs += " Name=\"" + ReportBuilder.EncodeAttributeText(Name) + "\"";
            if (attribs.Trim() == "") attribs = "";


            if (Style != null)
                xml += Style.ToXml("Style");
            if (Action != null)
                xml += Action.ToXml("Action");
            if (Top != null)
                xml += Top.ToXml("Top");
            if (Left != null)
                xml += Left.ToXml("Left");
            if (Height != null)
                xml += Height.ToXml("Height");
            if (Width != null)
                xml += Width.ToXml("Width");
            if (ZIndex != default(uint))
                xml += "<ZIndex>" + ReportBuilder.EncodeElementText(ZIndex.ToString()) + "</ZIndex>" + Environment.NewLine;
            if (Visibility != null)
                xml += Visibility.ToXml("Visibility");
            if (ToolTip != default(string))
                xml += "<ToolTip>" + ReportBuilder.EncodeElementText(ToolTip.ToString()) + "</ToolTip>" + Environment.NewLine;
            if (Label != default(string))
                xml += "<Label>" + ReportBuilder.EncodeElementText(Label.ToString()) + "</Label>" + Environment.NewLine;
            if (LinkToChild != default(string))
                xml += "<LinkToChild>" + ReportBuilder.EncodeElementText(LinkToChild.ToString()) + "</LinkToChild>" + Environment.NewLine;
            if (Bookmark != default(string))
                xml += "<Bookmark>" + ReportBuilder.EncodeElementText(Bookmark.ToString()) + "</Bookmark>" + Environment.NewLine;
            if (RepeatWith != default(string))
                xml += "<RepeatWith>" + ReportBuilder.EncodeElementText(RepeatWith.ToString()) + "</RepeatWith>" + Environment.NewLine;
            if (CustomProperties != null && CustomProperties.Count != 0)
                xml += CustomProperties.ToXml("CustomProperties");
            xml += "<ReportName>" + ReportBuilder.EncodeElementText(ReportName.ToString()) + "</ReportName>" + Environment.NewLine;
            if (Parameters != null && Parameters.Count != 0)
                xml += Parameters.ToXml("Parameters");
            if (NoRows != default(string))
                xml += "<NoRows>" + ReportBuilder.EncodeElementText(NoRows.ToString()) + "</NoRows>" + Environment.NewLine;
            if (MergeTransactions != default(bool))
                xml += "<MergeTransactions>" + ReportBuilder.EncodeElementText(MergeTransactions.ToString().ToLower()) + "</MergeTransactions>" + Environment.NewLine;
            if (DataElementName != default(string))
                xml += "<DataElementName>" + ReportBuilder.EncodeElementText(DataElementName.ToString()) + "</DataElementName>" + Environment.NewLine;
            if (DataElementOutput != DataElementOutputEnum4.__NotSet__)
                xml += "<DataElementOutput>" + ReportBuilder.EncodeElementText(DataElementOutput.ToString()) + "</DataElementOutput>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class CustomReportItemType : ReportItemType, IXml
    {
        public string Name = ""; //==Required==// 

        public CustomReportItemType(string pName)
        {
            Name = pName;
        }

        public string Type = ""; //==Required==// 
        public StyleType Style = new StyleType();
        public SizeType Top = new SizeType();
        public SizeType Left = new SizeType();
        public SizeType Height = new SizeType();
        public SizeType Width = new SizeType();
        public uint ZIndex;
        public VisibilityType Visibility;
        public string Label;
        public string Bookmark;
        public string RepeatWith;
        public CustomPropertiesType CustomProperties = new CustomPropertiesType();
        public ReportItemsType AltReportItem = new ReportItemsType();
        public CustomDataType CustomData;
        public string DataElementName;
        public DataElementOutputEnum5 DataElementOutput;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            attribs += " Name=\"" + ReportBuilder.EncodeAttributeText(Name) + "\"";
            if (attribs.Trim() == "") attribs = "";


            xml += "<Type>" + ReportBuilder.EncodeElementText(Type.ToString()) + "</Type>" + Environment.NewLine;
            if (Style != null)
                xml += Style.ToXml("Style");
            if (Top != null)
                xml += Top.ToXml("Top");
            if (Left != null)
                xml += Left.ToXml("Left");
            if (Height != null)
                xml += Height.ToXml("Height");
            if (Width != null)
                xml += Width.ToXml("Width");
            if (ZIndex != default(uint))
                xml += "<ZIndex>" + ReportBuilder.EncodeElementText(ZIndex.ToString()) + "</ZIndex>" + Environment.NewLine;
            if (Visibility != null)
                xml += Visibility.ToXml("Visibility");
            if (Label != default(string))
                xml += "<Label>" + ReportBuilder.EncodeElementText(Label.ToString()) + "</Label>" + Environment.NewLine;
            if (Bookmark != default(string))
                xml += "<Bookmark>" + ReportBuilder.EncodeElementText(Bookmark.ToString()) + "</Bookmark>" + Environment.NewLine;
            if (RepeatWith != default(string))
                xml += "<RepeatWith>" + ReportBuilder.EncodeElementText(RepeatWith.ToString()) + "</RepeatWith>" + Environment.NewLine;
            if (CustomProperties != null && CustomProperties.Count != 0)
                xml += CustomProperties.ToXml("CustomProperties");
            if (AltReportItem != null && AltReportItem.Count != 0)
                xml += AltReportItem.ToXml("AltReportItem");
            if (CustomData != null)
                xml += CustomData.ToXml("CustomData");
            if (DataElementName != default(string))
                xml += "<DataElementName>" + ReportBuilder.EncodeElementText(DataElementName.ToString()) + "</DataElementName>" + Environment.NewLine;
            if (DataElementOutput != DataElementOutputEnum5.__NotSet__)
                xml += "<DataElementOutput>" + ReportBuilder.EncodeElementText(DataElementOutput.ToString()) + "</DataElementOutput>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class CustomDataType : IXml
    {
        public string DataSetName = ""; //==Required==// 
        public FiltersType Filters = new FiltersType();
        public DataColumnGroupingsType DataColumnGroupings;
        public DataRowGroupingsType DataRowGroupings;
        public DataRowsType DataRows = new DataRowsType();

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += "<DataSetName>" + ReportBuilder.EncodeElementText(DataSetName.ToString()) + "</DataSetName>" + Environment.NewLine;
            if (Filters != null && Filters.Count != 0)
                xml += Filters.ToXml("Filters");
            if (DataColumnGroupings != null)
                xml += DataColumnGroupings.ToXml("DataColumnGroupings");
            if (DataRowGroupings != null)
                xml += DataRowGroupings.ToXml("DataRowGroupings");
            if (DataRows != null && DataRows.Count != 0)
                xml += DataRows.ToXml("DataRows");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class DataColumnGroupingsType : IXml
    {
        public DataGroupingsType DataGroupings = new DataGroupingsType(); //==Required==// 

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += DataGroupings.ToXml("DataGroupings");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class DataRowGroupingsType : IXml
    {
        public DataGroupingsType DataGroupings = new DataGroupingsType(); //==Required==// 

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += DataGroupings.ToXml("DataGroupings");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class DataGroupingsType : List<DataGroupingType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (DataGroupingType vDataGrouping in this)
            {
                xml += vDataGrouping.ToXml("DataGrouping");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class DataGroupingType : IXml
    {
        public bool Static;
        public GroupingType Grouping;
        public SortingType Sorting = new SortingType();
        public bool Subtotal;
        public CustomPropertiesType CustomProperties = new CustomPropertiesType();
        public DataGroupingsType DataGroupings = new DataGroupingsType();

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            if (Static != default(bool))
                xml += "<Static>" + ReportBuilder.EncodeElementText(Static.ToString().ToLower()) + "</Static>" + Environment.NewLine;
            if (Grouping != null)
                xml += Grouping.ToXml("Grouping");
            if (Sorting != null && Sorting.Count != 0)
                xml += Sorting.ToXml("Sorting");
            if (Subtotal != default(bool))
                xml += "<Subtotal>" + ReportBuilder.EncodeElementText(Subtotal.ToString().ToLower()) + "</Subtotal>" + Environment.NewLine;
            if (CustomProperties != null && CustomProperties.Count != 0)
                xml += CustomProperties.ToXml("CustomProperties");
            if (DataGroupings != null && DataGroupings.Count != 0)
                xml += DataGroupings.ToXml("DataGroupings");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class DataRowsType : List<DataRowType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (DataRowType vDataRow in this)
            {
                xml += vDataRow.ToXml("DataRow");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class DataRowType : List<DataCellType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (DataCellType vDataCell in this)
            {
                xml += vDataCell.ToXml("DataCell");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class DataCellType : List<DataValueType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (DataValueType vDataValue in this)
            {
                xml += vDataValue.ToXml("DataValue");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class ParametersType : List<ParameterType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (ParameterType vParameter in this)
            {
                xml += vParameter.ToXml("Parameter");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class ParameterType : IXml
    {
        public string Name = ""; //==Required==// 

        public ParameterType(string pName)
        {
            Name = pName;
        }

        public string Value = ""; //==Required==// 
        public string Omit;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            attribs += " Name=\"" + ReportBuilder.EncodeAttributeText(Name) + "\"";
            if (attribs.Trim() == "") attribs = "";


            xml += "<Value>" + ReportBuilder.EncodeElementText(Value.ToString()) + "</Value>" + Environment.NewLine;
            if (Omit != default(string))
                xml += "<Omit>" + ReportBuilder.EncodeElementText(Omit.ToString()) + "</Omit>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class ListType : ReportItemType, IXml
    {
        public string Name = ""; //==Required==// 

        public ListType(string pName)
        {
            Name = pName;
        }

        public StyleType Style = new StyleType();
        public ActionType Action;
        public SizeType Top = new SizeType();
        public SizeType Left = new SizeType();
        public SizeType Height = new SizeType();
        public SizeType Width = new SizeType();
        public uint ZIndex;
        public VisibilityType Visibility;
        public string ToolTip;
        public string Label;
        public string LinkToChild;
        public string Bookmark;
        public string RepeatWith;
        public CustomPropertiesType CustomProperties = new CustomPropertiesType();
        public bool KeepTogether;
        public string NoRows;
        public string DataSetName;
        public bool PageBreakAtStart;
        public bool PageBreakAtEnd;
        public FiltersType Filters = new FiltersType();
        public GroupingType Grouping;
        public SortingType Sorting = new SortingType();
        public ReportItemsType ReportItems = new ReportItemsType();
        public bool FillPage;
        public string DataInstanceName;
        public DataInstanceElementOutputEnum DataInstanceElementOutput;
        public string DataElementName;
        public DataElementOutputEnum6 DataElementOutput;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            attribs += " Name=\"" + ReportBuilder.EncodeAttributeText(Name) + "\"";
            if (attribs.Trim() == "") attribs = "";


            if (Style != null)
                xml += Style.ToXml("Style");
            if (Action != null)
                xml += Action.ToXml("Action");
            if (Top != null)
                xml += Top.ToXml("Top");
            if (Left != null)
                xml += Left.ToXml("Left");
            if (Height != null)
                xml += Height.ToXml("Height");
            if (Width != null)
                xml += Width.ToXml("Width");
            if (ZIndex != default(uint))
                xml += "<ZIndex>" + ReportBuilder.EncodeElementText(ZIndex.ToString()) + "</ZIndex>" + Environment.NewLine;
            if (Visibility != null)
                xml += Visibility.ToXml("Visibility");
            if (ToolTip != default(string))
                xml += "<ToolTip>" + ReportBuilder.EncodeElementText(ToolTip.ToString()) + "</ToolTip>" + Environment.NewLine;
            if (Label != default(string))
                xml += "<Label>" + ReportBuilder.EncodeElementText(Label.ToString()) + "</Label>" + Environment.NewLine;
            if (LinkToChild != default(string))
                xml += "<LinkToChild>" + ReportBuilder.EncodeElementText(LinkToChild.ToString()) + "</LinkToChild>" + Environment.NewLine;
            if (Bookmark != default(string))
                xml += "<Bookmark>" + ReportBuilder.EncodeElementText(Bookmark.ToString()) + "</Bookmark>" + Environment.NewLine;
            if (RepeatWith != default(string))
                xml += "<RepeatWith>" + ReportBuilder.EncodeElementText(RepeatWith.ToString()) + "</RepeatWith>" + Environment.NewLine;
            if (CustomProperties != null && CustomProperties.Count != 0)
                xml += CustomProperties.ToXml("CustomProperties");
            if (KeepTogether != default(bool))
                xml += "<KeepTogether>" + ReportBuilder.EncodeElementText(KeepTogether.ToString().ToLower()) + "</KeepTogether>" + Environment.NewLine;
            if (NoRows != default(string))
                xml += "<NoRows>" + ReportBuilder.EncodeElementText(NoRows.ToString()) + "</NoRows>" + Environment.NewLine;
            if (DataSetName != default(string))
                xml += "<DataSetName>" + ReportBuilder.EncodeElementText(DataSetName.ToString()) + "</DataSetName>" + Environment.NewLine;
            if (PageBreakAtStart != default(bool))
                xml += "<PageBreakAtStart>" + ReportBuilder.EncodeElementText(PageBreakAtStart.ToString().ToLower()) + "</PageBreakAtStart>" + Environment.NewLine;
            if (PageBreakAtEnd != default(bool))
                xml += "<PageBreakAtEnd>" + ReportBuilder.EncodeElementText(PageBreakAtEnd.ToString().ToLower()) + "</PageBreakAtEnd>" + Environment.NewLine;
            if (Filters != null && Filters.Count != 0)
                xml += Filters.ToXml("Filters");
            if (Grouping != null)
                xml += Grouping.ToXml("Grouping");
            if (Sorting != null && Sorting.Count != 0)
                xml += Sorting.ToXml("Sorting");
            if (ReportItems != null && ReportItems.Count != 0)
                xml += ReportItems.ToXml("ReportItems");
            if (FillPage != default(bool))
                xml += "<FillPage>" + ReportBuilder.EncodeElementText(FillPage.ToString().ToLower()) + "</FillPage>" + Environment.NewLine;
            if (DataInstanceName != default(string))
                xml += "<DataInstanceName>" + ReportBuilder.EncodeElementText(DataInstanceName.ToString()) + "</DataInstanceName>" + Environment.NewLine;
            if (DataInstanceElementOutput != DataInstanceElementOutputEnum.__NotSet__)
                xml += "<DataInstanceElementOutput>" + ReportBuilder.EncodeElementText(DataInstanceElementOutput.ToString()) + "</DataInstanceElementOutput>" + Environment.NewLine;
            if (DataElementName != default(string))
                xml += "<DataElementName>" + ReportBuilder.EncodeElementText(DataElementName.ToString()) + "</DataElementName>" + Environment.NewLine;
            if (DataElementOutput != DataElementOutputEnum6.__NotSet__)
                xml += "<DataElementOutput>" + ReportBuilder.EncodeElementText(DataElementOutput.ToString()) + "</DataElementOutput>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class GroupingType : IXml
    {
        public string Name = ""; //==Required==// 

        public GroupingType(string pName)
        {
            Name = pName;
        }

        public string Label;
        public GroupExpressionsType GroupExpressions = new GroupExpressionsType(); //==Required==// 
        public bool PageBreakAtStart;
        public bool PageBreakAtEnd;
        public CustomPropertiesType CustomProperties = new CustomPropertiesType();
        public FiltersType Filters = new FiltersType();
        public string Parent;
        public string DataElementName;
        public string DataCollectionName;
        public DataElementOutputEnum7 DataElementOutput;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            attribs += " Name=\"" + ReportBuilder.EncodeAttributeText(Name) + "\"";
            if (attribs.Trim() == "") attribs = "";


            if (Label != default(string))
                xml += "<Label>" + ReportBuilder.EncodeElementText(Label.ToString()) + "</Label>" + Environment.NewLine;
            xml += GroupExpressions.ToXml("GroupExpressions");
            if (PageBreakAtStart != default(bool))
                xml += "<PageBreakAtStart>" + ReportBuilder.EncodeElementText(PageBreakAtStart.ToString().ToLower()) + "</PageBreakAtStart>" + Environment.NewLine;
            if (PageBreakAtEnd != default(bool))
                xml += "<PageBreakAtEnd>" + ReportBuilder.EncodeElementText(PageBreakAtEnd.ToString().ToLower()) + "</PageBreakAtEnd>" + Environment.NewLine;
            if (CustomProperties != null && CustomProperties.Count != 0)
                xml += CustomProperties.ToXml("CustomProperties");
            if (Filters != null && Filters.Count != 0)
                xml += Filters.ToXml("Filters");
            if (Parent != default(string))
                xml += "<Parent>" + ReportBuilder.EncodeElementText(Parent.ToString()) + "</Parent>" + Environment.NewLine;
            if (DataElementName != default(string))
                xml += "<DataElementName>" + ReportBuilder.EncodeElementText(DataElementName.ToString()) + "</DataElementName>" + Environment.NewLine;
            if (DataCollectionName != default(string))
                xml += "<DataCollectionName>" + ReportBuilder.EncodeElementText(DataCollectionName.ToString()) + "</DataCollectionName>" + Environment.NewLine;
            if (DataElementOutput != DataElementOutputEnum7.__NotSet__)
                xml += "<DataElementOutput>" + ReportBuilder.EncodeElementText(DataElementOutput.ToString()) + "</DataElementOutput>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class GroupExpressionsType : List<string>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (string vGroupExpression in this)
            {
                xml += "<GroupExpression>" + ReportBuilder.EncodeElementText(vGroupExpression.ToString()) + "</GroupExpression>" + Environment.NewLine;
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class SortingType : List<SortByType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (SortByType vSortBy in this)
            {
                xml += vSortBy.ToXml("SortBy");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class SortByType : IXml
    {
        public string SortExpression = ""; //==Required==// 
        public DirectionEnum Direction;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += "<SortExpression>" + ReportBuilder.EncodeElementText(SortExpression.ToString()) + "</SortExpression>" + Environment.NewLine;
            if (Direction != DirectionEnum.__NotSet__)
                xml += "<Direction>" + ReportBuilder.EncodeElementText(Direction.ToString()) + "</Direction>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class MatrixType : ReportItemType, IXml
    {
        public string Name = ""; //==Required==// 

        public MatrixType(string pName)
        {
            Name = pName;
        }

        public StyleType Style = new StyleType();
        public ActionType Action;
        public SizeType Top = new SizeType();
        public SizeType Left = new SizeType();
        public SizeType Height = new SizeType();
        public SizeType Width = new SizeType();
        public uint ZIndex;
        public VisibilityType Visibility;
        public string ToolTip;
        public string Label;
        public string LinkToChild;
        public string Bookmark;
        public string RepeatWith;
        public CustomPropertiesType CustomProperties = new CustomPropertiesType();
        public bool KeepTogether;
        public string NoRows;
        public string DataSetName;
        public bool PageBreakAtStart;
        public bool PageBreakAtEnd;
        public FiltersType Filters = new FiltersType();
        public CornerType Corner;
        public ColumnGroupingsType ColumnGroupings = new ColumnGroupingsType(); //==Required==// 
        public RowGroupingsType RowGroupings = new RowGroupingsType(); //==Required==// 
        public MatrixRowsType MatrixRows = new MatrixRowsType(); //==Required==// 
        public MatrixColumnsType MatrixColumns = new MatrixColumnsType(); //==Required==// 
        public LayoutDirectionEnum LayoutDirection;
        public uint GroupsBeforeRowHeaders;
        public string DataElementName;
        public DataElementOutputEnum8 DataElementOutput;
        public string CellDataElementName;
        public CellDataElementOutputEnum CellDataElementOutput;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            attribs += " Name=\"" + ReportBuilder.EncodeAttributeText(Name) + "\"";
            if (attribs.Trim() == "") attribs = "";


            if (Style != null)
                xml += Style.ToXml("Style");
            if (Action != null)
                xml += Action.ToXml("Action");
            if (Top != null)
                xml += Top.ToXml("Top");
            if (Left != null)
                xml += Left.ToXml("Left");
            if (Height != null)
                xml += Height.ToXml("Height");
            if (Width != null)
                xml += Width.ToXml("Width");
            if (ZIndex != default(uint))
                xml += "<ZIndex>" + ReportBuilder.EncodeElementText(ZIndex.ToString()) + "</ZIndex>" + Environment.NewLine;
            if (Visibility != null)
                xml += Visibility.ToXml("Visibility");
            if (ToolTip != default(string))
                xml += "<ToolTip>" + ReportBuilder.EncodeElementText(ToolTip.ToString()) + "</ToolTip>" + Environment.NewLine;
            if (Label != default(string))
                xml += "<Label>" + ReportBuilder.EncodeElementText(Label.ToString()) + "</Label>" + Environment.NewLine;
            if (LinkToChild != default(string))
                xml += "<LinkToChild>" + ReportBuilder.EncodeElementText(LinkToChild.ToString()) + "</LinkToChild>" + Environment.NewLine;
            if (Bookmark != default(string))
                xml += "<Bookmark>" + ReportBuilder.EncodeElementText(Bookmark.ToString()) + "</Bookmark>" + Environment.NewLine;
            if (RepeatWith != default(string))
                xml += "<RepeatWith>" + ReportBuilder.EncodeElementText(RepeatWith.ToString()) + "</RepeatWith>" + Environment.NewLine;
            if (CustomProperties != null && CustomProperties.Count != 0)
                xml += CustomProperties.ToXml("CustomProperties");
            if (KeepTogether != default(bool))
                xml += "<KeepTogether>" + ReportBuilder.EncodeElementText(KeepTogether.ToString().ToLower()) + "</KeepTogether>" + Environment.NewLine;
            if (NoRows != default(string))
                xml += "<NoRows>" + ReportBuilder.EncodeElementText(NoRows.ToString()) + "</NoRows>" + Environment.NewLine;
            if (DataSetName != default(string))
                xml += "<DataSetName>" + ReportBuilder.EncodeElementText(DataSetName.ToString()) + "</DataSetName>" + Environment.NewLine;
            if (PageBreakAtStart != default(bool))
                xml += "<PageBreakAtStart>" + ReportBuilder.EncodeElementText(PageBreakAtStart.ToString().ToLower()) + "</PageBreakAtStart>" + Environment.NewLine;
            if (PageBreakAtEnd != default(bool))
                xml += "<PageBreakAtEnd>" + ReportBuilder.EncodeElementText(PageBreakAtEnd.ToString().ToLower()) + "</PageBreakAtEnd>" + Environment.NewLine;
            if (Filters != null && Filters.Count != 0)
                xml += Filters.ToXml("Filters");
            if (Corner != null)
                xml += Corner.ToXml("Corner");
            xml += ColumnGroupings.ToXml("ColumnGroupings");
            xml += RowGroupings.ToXml("RowGroupings");
            xml += MatrixRows.ToXml("MatrixRows");
            xml += MatrixColumns.ToXml("MatrixColumns");
            if (LayoutDirection != LayoutDirectionEnum.__NotSet__)
                xml += "<LayoutDirection>" + ReportBuilder.EncodeElementText(LayoutDirection.ToString()) + "</LayoutDirection>" + Environment.NewLine;
            if (GroupsBeforeRowHeaders != default(uint))
                xml += "<GroupsBeforeRowHeaders>" + ReportBuilder.EncodeElementText(GroupsBeforeRowHeaders.ToString()) + "</GroupsBeforeRowHeaders>" + Environment.NewLine;
            if (DataElementName != default(string))
                xml += "<DataElementName>" + ReportBuilder.EncodeElementText(DataElementName.ToString()) + "</DataElementName>" + Environment.NewLine;
            if (DataElementOutput != DataElementOutputEnum8.__NotSet__)
                xml += "<DataElementOutput>" + ReportBuilder.EncodeElementText(DataElementOutput.ToString()) + "</DataElementOutput>" + Environment.NewLine;
            if (CellDataElementName != default(string))
                xml += "<CellDataElementName>" + ReportBuilder.EncodeElementText(CellDataElementName.ToString()) + "</CellDataElementName>" + Environment.NewLine;
            if (CellDataElementOutput != CellDataElementOutputEnum.__NotSet__)
                xml += "<CellDataElementOutput>" + ReportBuilder.EncodeElementText(CellDataElementOutput.ToString()) + "</CellDataElementOutput>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class CornerType : IXml
    {
        public ReportItemsType ReportItems = new ReportItemsType(); //==Required==// 

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += ReportItems.ToXml("ReportItems");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class ColumnGroupingsType : List<ColumnGroupingType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (ColumnGroupingType vColumnGrouping in this)
            {
                xml += vColumnGrouping.ToXml("ColumnGrouping");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class ColumnGroupingType : IXml
    {
        public SizeType Height = new SizeType(); //==Required==// 
        public bool FixedHeader;
        public DynamicColumnsRowsType DynamicColumns;
        public StaticColumnsType StaticColumns = new StaticColumnsType();

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += Height.ToXml("Height");
            if (FixedHeader != default(bool))
                xml += "<FixedHeader>" + ReportBuilder.EncodeElementText(FixedHeader.ToString().ToLower()) + "</FixedHeader>" + Environment.NewLine;
            if (DynamicColumns != null)
                xml += DynamicColumns.ToXml("DynamicColumns");
            if (StaticColumns != null && StaticColumns.Count != 0)
                xml += StaticColumns.ToXml("StaticColumns");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class DynamicColumnsRowsType : IXml
    {
        public GroupingType Grouping; //==Required==// 
        public SortingType Sorting = new SortingType();
        public SubtotalType Subtotal;
        public ReportItemsType ReportItems = new ReportItemsType(); //==Required==// 
        public VisibilityType Visibility;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += Grouping.ToXml("Grouping");
            if (Sorting != null && Sorting.Count != 0)
                xml += Sorting.ToXml("Sorting");
            if (Subtotal != null)
                xml += Subtotal.ToXml("Subtotal");
            xml += ReportItems.ToXml("ReportItems");
            if (Visibility != null)
                xml += Visibility.ToXml("Visibility");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class StaticColumnsType : List<StaticColumnType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (StaticColumnType vStaticColumn in this)
            {
                xml += vStaticColumn.ToXml("StaticColumn");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class StaticColumnType : IXml
    {
        public ReportItemsType ReportItems = new ReportItemsType(); //==Required==// 

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += ReportItems.ToXml("ReportItems");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class RowGroupingsType : List<RowGroupingType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (RowGroupingType vRowGrouping in this)
            {
                xml += vRowGrouping.ToXml("RowGrouping");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class RowGroupingType : IXml
    {
        public SizeType Width = new SizeType(); //==Required==// 
        public bool FixedHeader;
        public DynamicColumnsRowsType DynamicRows;
        public StaticRowsType StaticRows = new StaticRowsType();

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += Width.ToXml("Width");
            if (FixedHeader != default(bool))
                xml += "<FixedHeader>" + ReportBuilder.EncodeElementText(FixedHeader.ToString().ToLower()) + "</FixedHeader>" + Environment.NewLine;
            if (DynamicRows != null)
                xml += DynamicRows.ToXml("DynamicRows");
            if (StaticRows != null && StaticRows.Count != 0)
                xml += StaticRows.ToXml("StaticRows");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class StaticRowsType : List<StaticRowType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (StaticRowType vStaticRow in this)
            {
                xml += vStaticRow.ToXml("StaticRow");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class StaticRowType : IXml
    {
        public ReportItemsType ReportItems = new ReportItemsType(); //==Required==// 

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += ReportItems.ToXml("ReportItems");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class SubtotalType : IXml
    {
        public ReportItemsType ReportItems = new ReportItemsType(); //==Required==// 
        public StyleType Style = new StyleType();
        public PositionEnum Position;
        public string DataElementName;
        public DataElementOutputEnum9 DataElementOutput;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += ReportItems.ToXml("ReportItems");
            if (Style != null)
                xml += Style.ToXml("Style");
            if (Position != PositionEnum.__NotSet__)
                xml += "<Position>" + ReportBuilder.EncodeElementText(Position.ToString()) + "</Position>" + Environment.NewLine;
            if (DataElementName != default(string))
                xml += "<DataElementName>" + ReportBuilder.EncodeElementText(DataElementName.ToString()) + "</DataElementName>" + Environment.NewLine;
            if (DataElementOutput != DataElementOutputEnum9.__NotSet__)
                xml += "<DataElementOutput>" + ReportBuilder.EncodeElementText(DataElementOutput.ToString()) + "</DataElementOutput>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class MatrixColumnsType : List<MatrixColumnType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (MatrixColumnType vMatrixColumn in this)
            {
                xml += vMatrixColumn.ToXml("MatrixColumn");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class MatrixColumnType : IXml
    {
        public SizeType Width = new SizeType(); //==Required==// 

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += Width.ToXml("Width");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class MatrixRowsType : List<MatrixRowType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (MatrixRowType vMatrixRow in this)
            {
                xml += vMatrixRow.ToXml("MatrixRow");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class MatrixRowType : IXml
    {
        public SizeType Height = new SizeType(); //==Required==// 
        public MatrixCellsType MatrixCells = new MatrixCellsType(); //==Required==// 

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += Height.ToXml("Height");
            xml += MatrixCells.ToXml("MatrixCells");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class MatrixCellsType : List<MatrixCellType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (MatrixCellType vMatrixCell in this)
            {
                xml += vMatrixCell.ToXml("MatrixCell");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class MatrixCellType : IXml
    {
        public ReportItemsType ReportItems = new ReportItemsType(); //==Required==// 

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += ReportItems.ToXml("ReportItems");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class TableType : ReportItemType, IXml
    {
        public string Name = ""; //==Required==// 

        public TableType(string pName)
        {
            Name = pName;
        }

        public StyleType Style = new StyleType();
        public ActionType Action;
        public SizeType Top = new SizeType();
        public SizeType Left = new SizeType();
        public SizeType Height = new SizeType();
        public SizeType Width = new SizeType();
        public uint ZIndex;
        public VisibilityType Visibility;
        public string ToolTip;
        public string Label;
        public string LinkToChild;
        public string Bookmark;
        public string RepeatWith;
        public CustomPropertiesType CustomProperties = new CustomPropertiesType();
        public bool KeepTogether;
        public string NoRows;
        public string DataSetName;
        public bool PageBreakAtStart;
        public bool PageBreakAtEnd;
        public FiltersType Filters = new FiltersType();
        public TableColumnsType TableColumns = new TableColumnsType(); //==Required==// 
        public HeaderType Header;
        public TableGroupsType TableGroups = new TableGroupsType();
        public DetailsType Details;
        public FooterType Footer;
        public bool FillPage;
        public string DataElementName;
        public DataElementOutputEnum10 DataElementOutput;
        public string DetailDataElementName;
        public string DetailDataCollectionName;
        public DetailDataElementOutputEnum DetailDataElementOutput;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            attribs += " Name=\"" + ReportBuilder.EncodeAttributeText(Name) + "\"";
            if (attribs.Trim() == "") attribs = "";


            if (Style != null)
                xml += Style.ToXml("Style");
            if (Action != null)
                xml += Action.ToXml("Action");
            if (Top != null)
                xml += Top.ToXml("Top");
            if (Left != null)
                xml += Left.ToXml("Left");
            if (Height != null)
                xml += Height.ToXml("Height");
            if (Width != null)
                xml += Width.ToXml("Width");
            if (ZIndex != default(uint))
                xml += "<ZIndex>" + ReportBuilder.EncodeElementText(ZIndex.ToString()) + "</ZIndex>" + Environment.NewLine;
            if (Visibility != null)
                xml += Visibility.ToXml("Visibility");
            if (ToolTip != default(string))
                xml += "<ToolTip>" + ReportBuilder.EncodeElementText(ToolTip.ToString()) + "</ToolTip>" + Environment.NewLine;
            if (Label != default(string))
                xml += "<Label>" + ReportBuilder.EncodeElementText(Label.ToString()) + "</Label>" + Environment.NewLine;
            if (LinkToChild != default(string))
                xml += "<LinkToChild>" + ReportBuilder.EncodeElementText(LinkToChild.ToString()) + "</LinkToChild>" + Environment.NewLine;
            if (Bookmark != default(string))
                xml += "<Bookmark>" + ReportBuilder.EncodeElementText(Bookmark.ToString()) + "</Bookmark>" + Environment.NewLine;
            if (RepeatWith != default(string))
                xml += "<RepeatWith>" + ReportBuilder.EncodeElementText(RepeatWith.ToString()) + "</RepeatWith>" + Environment.NewLine;
            if (CustomProperties != null && CustomProperties.Count != 0)
                xml += CustomProperties.ToXml("CustomProperties");
            if (KeepTogether != default(bool))
                xml += "<KeepTogether>" + ReportBuilder.EncodeElementText(KeepTogether.ToString().ToLower()) + "</KeepTogether>" + Environment.NewLine;
            if (NoRows != default(string))
                xml += "<NoRows>" + ReportBuilder.EncodeElementText(NoRows.ToString()) + "</NoRows>" + Environment.NewLine;
            if (DataSetName != default(string))
                xml += "<DataSetName>" + ReportBuilder.EncodeElementText(DataSetName.ToString()) + "</DataSetName>" + Environment.NewLine;
            if (PageBreakAtStart != default(bool))
                xml += "<PageBreakAtStart>" + ReportBuilder.EncodeElementText(PageBreakAtStart.ToString().ToLower()) + "</PageBreakAtStart>" + Environment.NewLine;
            if (PageBreakAtEnd != default(bool))
                xml += "<PageBreakAtEnd>" + ReportBuilder.EncodeElementText(PageBreakAtEnd.ToString().ToLower()) + "</PageBreakAtEnd>" + Environment.NewLine;
            if (Filters != null && Filters.Count != 0)
                xml += Filters.ToXml("Filters");
            xml += TableColumns.ToXml("TableColumns");
            if (Header != null)
                xml += Header.ToXml("Header");
            if (TableGroups != null && TableGroups.Count != 0)
                xml += TableGroups.ToXml("TableGroups");
            if (Details != null)
                xml += Details.ToXml("Details");
            if (Footer != null)
                xml += Footer.ToXml("Footer");
            if (FillPage != default(bool))
                xml += "<FillPage>" + ReportBuilder.EncodeElementText(FillPage.ToString().ToLower()) + "</FillPage>" + Environment.NewLine;
            if (DataElementName != default(string))
                xml += "<DataElementName>" + ReportBuilder.EncodeElementText(DataElementName.ToString()) + "</DataElementName>" + Environment.NewLine;
            if (DataElementOutput != DataElementOutputEnum10.__NotSet__)
                xml += "<DataElementOutput>" + ReportBuilder.EncodeElementText(DataElementOutput.ToString()) + "</DataElementOutput>" + Environment.NewLine;
            if (DetailDataElementName != default(string))
                xml += "<DetailDataElementName>" + ReportBuilder.EncodeElementText(DetailDataElementName.ToString()) + "</DetailDataElementName>" + Environment.NewLine;
            if (DetailDataCollectionName != default(string))
                xml += "<DetailDataCollectionName>" + ReportBuilder.EncodeElementText(DetailDataCollectionName.ToString()) + "</DetailDataCollectionName>" + Environment.NewLine;
            if (DetailDataElementOutput != DetailDataElementOutputEnum.__NotSet__)
                xml += "<DetailDataElementOutput>" + ReportBuilder.EncodeElementText(DetailDataElementOutput.ToString()) + "</DetailDataElementOutput>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class TableColumnsType : List<TableColumnType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (TableColumnType vTableColumn in this)
            {
                xml += vTableColumn.ToXml("TableColumn");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class TableColumnType : IXml
    {
        public SizeType Width = new SizeType(); //==Required==// 
        public VisibilityType Visibility;
        public bool FixedHeader;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += Width.ToXml("Width");
            if (Visibility != null)
                xml += Visibility.ToXml("Visibility");
            if (FixedHeader != default(bool))
                xml += "<FixedHeader>" + ReportBuilder.EncodeElementText(FixedHeader.ToString().ToLower()) + "</FixedHeader>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class HeaderType : IXml
    {
        public TableRowsType TableRows = new TableRowsType(); //==Required==// 
        public bool FixedHeader;
        public bool RepeatOnNewPage;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += TableRows.ToXml("TableRows");
            if (FixedHeader != default(bool))
                xml += "<FixedHeader>" + ReportBuilder.EncodeElementText(FixedHeader.ToString().ToLower()) + "</FixedHeader>" + Environment.NewLine;
            if (RepeatOnNewPage != default(bool))
                xml += "<RepeatOnNewPage>" + ReportBuilder.EncodeElementText(RepeatOnNewPage.ToString().ToLower()) + "</RepeatOnNewPage>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class TableRowsType : List<TableRowType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (TableRowType vTableRow in this)
            {
                xml += vTableRow.ToXml("TableRow");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class TableRowType : IXml
    {
        public TableCellsType TableCells = new TableCellsType(); //==Required==// 
        public SizeType Height = new SizeType(); //==Required==// 
        public VisibilityType Visibility;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += TableCells.ToXml("TableCells");
            xml += Height.ToXml("Height");
            if (Visibility != null)
                xml += Visibility.ToXml("Visibility");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class FooterType : IXml
    {
        public TableRowsType TableRows = new TableRowsType(); //==Required==// 
        public bool RepeatOnNewPage;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += TableRows.ToXml("TableRows");
            if (RepeatOnNewPage != default(bool))
                xml += "<RepeatOnNewPage>" + ReportBuilder.EncodeElementText(RepeatOnNewPage.ToString().ToLower()) + "</RepeatOnNewPage>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class TableGroupsType : List<TableGroupType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (TableGroupType vTableGroup in this)
            {
                xml += vTableGroup.ToXml("TableGroup");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class TableGroupType : IXml
    {
        public GroupingType Grouping; //==Required==// 
        public SortingType Sorting = new SortingType();
        public HeaderType Header;
        public FooterType Footer;
        public VisibilityType Visibility;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += Grouping.ToXml("Grouping");
            if (Sorting != null && Sorting.Count != 0)
                xml += Sorting.ToXml("Sorting");
            if (Header != null)
                xml += Header.ToXml("Header");
            if (Footer != null)
                xml += Footer.ToXml("Footer");
            if (Visibility != null)
                xml += Visibility.ToXml("Visibility");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class DetailsType : IXml
    {
        public TableRowsType TableRows = new TableRowsType(); //==Required==// 
        public GroupingType Grouping;
        public SortingType Sorting = new SortingType();
        public VisibilityType Visibility;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += TableRows.ToXml("TableRows");
            if (Grouping != null)
                xml += Grouping.ToXml("Grouping");
            if (Sorting != null && Sorting.Count != 0)
                xml += Sorting.ToXml("Sorting");
            if (Visibility != null)
                xml += Visibility.ToXml("Visibility");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class TableCellsType : List<TableCellType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (TableCellType vTableCell in this)
            {
                xml += vTableCell.ToXml("TableCell");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class TableCellType : IXml
    {
        public ReportItemsType ReportItems = new ReportItemsType(); //==Required==// 
        public uint ColSpan;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += ReportItems.ToXml("ReportItems");
            if (ColSpan != default(uint))
                xml += "<ColSpan>" + ReportBuilder.EncodeElementText(ColSpan.ToString()) + "</ColSpan>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class ChartType : ReportItemType, IXml
    {
        public string Name = ""; //==Required==// 

        public ChartType(string pName)
        {
            Name = pName;
        }

        public TypeEnum Type;
        public SubtypeEnum Subtype;
        public StyleType Style = new StyleType();
        public ActionType Action;
        public SizeType Top = new SizeType();
        public SizeType Left = new SizeType();
        public SizeType Height = new SizeType();
        public SizeType Width = new SizeType();
        public uint ZIndex;
        public VisibilityType Visibility;
        public string ToolTip;
        public string Label;
        public string LinkToChild;
        public string Bookmark;
        public CustomPropertiesType CustomProperties = new CustomPropertiesType();
        public bool KeepTogether;
        public string NoRows;
        public string DataSetName;
        public bool PageBreakAtStart;
        public bool PageBreakAtEnd;
        public FiltersType Filters = new FiltersType();
        public SeriesGroupingsType SeriesGroupings = new SeriesGroupingsType();
        public CategoryGroupingsType CategoryGroupings = new CategoryGroupingsType();
        public ChartDataType ChartData = new ChartDataType();
        public LegendType Legend;
        public CategoryAxisType CategoryAxis;
        public ValueAxisType ValueAxis;
        public TitleType Title;
        public uint PointWidth;
        public PaletteEnum Palette;
        public ThreeDPropertiesType ThreeDProperties;
        public PlotAreaType PlotArea;
        public string DataElementName;
        public DataElementOutputEnum11 DataElementOutput;
        public ChartElementOutputEnum ChartElementOutput;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            attribs += " Name=\"" + ReportBuilder.EncodeAttributeText(Name) + "\"";
            if (attribs.Trim() == "") attribs = "";


            if (Type != TypeEnum.__NotSet__)
                xml += "<Type>" + ReportBuilder.EncodeElementText(Type.ToString()) + "</Type>" + Environment.NewLine;
            if (Subtype != SubtypeEnum.__NotSet__)
                xml += "<Subtype>" + ReportBuilder.EncodeElementText(Subtype.ToString()) + "</Subtype>" + Environment.NewLine;
            if (Style != null)
                xml += Style.ToXml("Style");
            if (Action != null)
                xml += Action.ToXml("Action");
            if (Top != null)
                xml += Top.ToXml("Top");
            if (Left != null)
                xml += Left.ToXml("Left");
            if (Height != null)
                xml += Height.ToXml("Height");
            if (Width != null)
                xml += Width.ToXml("Width");
            if (ZIndex != default(uint))
                xml += "<ZIndex>" + ReportBuilder.EncodeElementText(ZIndex.ToString()) + "</ZIndex>" + Environment.NewLine;
            if (Visibility != null)
                xml += Visibility.ToXml("Visibility");
            if (ToolTip != default(string))
                xml += "<ToolTip>" + ReportBuilder.EncodeElementText(ToolTip.ToString()) + "</ToolTip>" + Environment.NewLine;
            if (Label != default(string))
                xml += "<Label>" + ReportBuilder.EncodeElementText(Label.ToString()) + "</Label>" + Environment.NewLine;
            if (LinkToChild != default(string))
                xml += "<LinkToChild>" + ReportBuilder.EncodeElementText(LinkToChild.ToString()) + "</LinkToChild>" + Environment.NewLine;
            if (Bookmark != default(string))
                xml += "<Bookmark>" + ReportBuilder.EncodeElementText(Bookmark.ToString()) + "</Bookmark>" + Environment.NewLine;
            if (CustomProperties != null && CustomProperties.Count != 0)
                xml += CustomProperties.ToXml("CustomProperties");
            if (KeepTogether != default(bool))
                xml += "<KeepTogether>" + ReportBuilder.EncodeElementText(KeepTogether.ToString().ToLower()) + "</KeepTogether>" + Environment.NewLine;
            if (NoRows != default(string))
                xml += "<NoRows>" + ReportBuilder.EncodeElementText(NoRows.ToString()) + "</NoRows>" + Environment.NewLine;
            if (DataSetName != default(string))
                xml += "<DataSetName>" + ReportBuilder.EncodeElementText(DataSetName.ToString()) + "</DataSetName>" + Environment.NewLine;
            if (PageBreakAtStart != default(bool))
                xml += "<PageBreakAtStart>" + ReportBuilder.EncodeElementText(PageBreakAtStart.ToString().ToLower()) + "</PageBreakAtStart>" + Environment.NewLine;
            if (PageBreakAtEnd != default(bool))
                xml += "<PageBreakAtEnd>" + ReportBuilder.EncodeElementText(PageBreakAtEnd.ToString().ToLower()) + "</PageBreakAtEnd>" + Environment.NewLine;
            if (Filters != null && Filters.Count != 0)
                xml += Filters.ToXml("Filters");
            if (SeriesGroupings != null && SeriesGroupings.Count != 0)
                xml += SeriesGroupings.ToXml("SeriesGroupings");
            if (CategoryGroupings != null && CategoryGroupings.Count != 0)
                xml += CategoryGroupings.ToXml("CategoryGroupings");
            if (ChartData != null && ChartData.Count != 0)
                xml += ChartData.ToXml("ChartData");
            if (Legend != null)
                xml += Legend.ToXml("Legend");
            if (CategoryAxis != null)
                xml += CategoryAxis.ToXml("CategoryAxis");
            if (ValueAxis != null)
                xml += ValueAxis.ToXml("ValueAxis");
            if (Title != null)
                xml += Title.ToXml("Title");
            if (PointWidth != default(uint))
                xml += "<PointWidth>" + ReportBuilder.EncodeElementText(PointWidth.ToString()) + "</PointWidth>" + Environment.NewLine;
            if (Palette != PaletteEnum.__NotSet__)
                xml += "<Palette>" + ReportBuilder.EncodeElementText(Palette.ToString()) + "</Palette>" + Environment.NewLine;
            if (ThreeDProperties != null)
                xml += ThreeDProperties.ToXml("ThreeDProperties");
            if (PlotArea != null)
                xml += PlotArea.ToXml("PlotArea");
            if (DataElementName != default(string))
                xml += "<DataElementName>" + ReportBuilder.EncodeElementText(DataElementName.ToString()) + "</DataElementName>" + Environment.NewLine;
            if (DataElementOutput != DataElementOutputEnum11.__NotSet__)
                xml += "<DataElementOutput>" + ReportBuilder.EncodeElementText(DataElementOutput.ToString()) + "</DataElementOutput>" + Environment.NewLine;
            if (ChartElementOutput != ChartElementOutputEnum.__NotSet__)
                xml += "<ChartElementOutput>" + ReportBuilder.EncodeElementText(ChartElementOutput.ToString()) + "</ChartElementOutput>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class SeriesGroupingsType : List<SeriesGroupingType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (SeriesGroupingType vSeriesGrouping in this)
            {
                xml += vSeriesGrouping.ToXml("SeriesGrouping");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class SeriesGroupingType : IXml
    {
        public DynamicSeriesType DynamicSeries;
        public StaticSeriesType StaticSeries = new StaticSeriesType();

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            if (DynamicSeries != null)
                xml += DynamicSeries.ToXml("DynamicSeries");
            if (StaticSeries != null && StaticSeries.Count != 0)
                xml += StaticSeries.ToXml("StaticSeries");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class DynamicSeriesType : IXml
    {
        public GroupingType Grouping; //==Required==// 
        public SortingType Sorting = new SortingType();
        public string Label = ""; //==Required==// 

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += Grouping.ToXml("Grouping");
            if (Sorting != null && Sorting.Count != 0)
                xml += Sorting.ToXml("Sorting");
            xml += "<Label>" + ReportBuilder.EncodeElementText(Label.ToString()) + "</Label>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class StaticSeriesType : List<StaticMemberType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (StaticMemberType vStaticMember in this)
            {
                xml += vStaticMember.ToXml("StaticMember");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class StaticMemberType : IXml
    {
        public string Label = ""; //==Required==// 

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += "<Label>" + ReportBuilder.EncodeElementText(Label.ToString()) + "</Label>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class CategoryGroupingsType : List<CategoryGroupingType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (CategoryGroupingType vCategoryGrouping in this)
            {
                xml += vCategoryGrouping.ToXml("CategoryGrouping");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class CategoryGroupingType : IXml
    {
        public DynamicCategoriesType DynamicCategories;
        public StaticCategoriesType StaticCategories = new StaticCategoriesType();

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            if (DynamicCategories != null)
                xml += DynamicCategories.ToXml("DynamicCategories");
            if (StaticCategories != null && StaticCategories.Count != 0)
                xml += StaticCategories.ToXml("StaticCategories");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class DynamicCategoriesType : IXml
    {
        public GroupingType Grouping; //==Required==// 
        public SortingType Sorting = new SortingType();
        public string Label;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += Grouping.ToXml("Grouping");
            if (Sorting != null && Sorting.Count != 0)
                xml += Sorting.ToXml("Sorting");
            if (Label != default(string))
                xml += "<Label>" + ReportBuilder.EncodeElementText(Label.ToString()) + "</Label>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class StaticCategoriesType : List<StaticMemberType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (StaticMemberType vStaticMember in this)
            {
                xml += vStaticMember.ToXml("StaticMember");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class TitleType : IXml
    {
        public string Caption;
        public StyleType Style = new StyleType();
        public PositionEnum1 Position;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            if (Caption != default(string))
                xml += "<Caption>" + ReportBuilder.EncodeElementText(Caption.ToString()) + "</Caption>" + Environment.NewLine;
            if (Style != null)
                xml += Style.ToXml("Style");
            if (Position != PositionEnum1.__NotSet__)
                xml += "<Position>" + ReportBuilder.EncodeElementText(Position.ToString()) + "</Position>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class LegendType : IXml
    {
        public bool Visible;
        public StyleType Style = new StyleType();
        public PositionEnum2 Position;
        public LayoutEnum Layout;
        public bool InsidePlotArea;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            if (Visible != default(bool))
                xml += "<Visible>" + ReportBuilder.EncodeElementText(Visible.ToString().ToLower()) + "</Visible>" + Environment.NewLine;
            if (Style != null)
                xml += Style.ToXml("Style");
            if (Position != PositionEnum2.__NotSet__)
                xml += "<Position>" + ReportBuilder.EncodeElementText(Position.ToString()) + "</Position>" + Environment.NewLine;
            if (Layout != LayoutEnum.__NotSet__)
                xml += "<Layout>" + ReportBuilder.EncodeElementText(Layout.ToString()) + "</Layout>" + Environment.NewLine;
            if (InsidePlotArea != default(bool))
                xml += "<InsidePlotArea>" + ReportBuilder.EncodeElementText(InsidePlotArea.ToString().ToLower()) + "</InsidePlotArea>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class CategoryAxisType : IXml
    {
        public AxisType Axis;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            if (Axis != null)
                xml += Axis.ToXml("Axis");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class ValueAxisType : IXml
    {
        public AxisType Axis;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            if (Axis != null)
                xml += Axis.ToXml("Axis");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class AxisType : IXml
    {
        public bool Visible;
        public StyleType Style = new StyleType();
        public TitleType Title;
        public bool Margin;
        public MajorTickMarksEnum MajorTickMarks;
        public MinorTickMarksEnum MinorTickMarks;
        public MajorGridLinesType MajorGridLines;
        public MinorGridLinesType MinorGridLines;
        public string MajorInterval;
        public string MinorInterval;
        public bool Reverse;
        public string CrossAt;
        public bool Interlaced;
        public bool Scalar;
        public string Min;
        public string Max;
        public bool LogScale;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            if (Visible != default(bool))
                xml += "<Visible>" + ReportBuilder.EncodeElementText(Visible.ToString().ToLower()) + "</Visible>" + Environment.NewLine;
            if (Style != null)
                xml += Style.ToXml("Style");
            if (Title != null)
                xml += Title.ToXml("Title");
            if (Margin != default(bool))
                xml += "<Margin>" + ReportBuilder.EncodeElementText(Margin.ToString().ToLower()) + "</Margin>" + Environment.NewLine;
            if (MajorTickMarks != MajorTickMarksEnum.__NotSet__)
                xml += "<MajorTickMarks>" + ReportBuilder.EncodeElementText(MajorTickMarks.ToString()) + "</MajorTickMarks>" + Environment.NewLine;
            if (MinorTickMarks != MinorTickMarksEnum.__NotSet__)
                xml += "<MinorTickMarks>" + ReportBuilder.EncodeElementText(MinorTickMarks.ToString()) + "</MinorTickMarks>" + Environment.NewLine;
            if (MajorGridLines != null)
                xml += MajorGridLines.ToXml("MajorGridLines");
            if (MinorGridLines != null)
                xml += MinorGridLines.ToXml("MinorGridLines");
            if (MajorInterval != default(string))
                xml += "<MajorInterval>" + ReportBuilder.EncodeElementText(MajorInterval.ToString()) + "</MajorInterval>" + Environment.NewLine;
            if (MinorInterval != default(string))
                xml += "<MinorInterval>" + ReportBuilder.EncodeElementText(MinorInterval.ToString()) + "</MinorInterval>" + Environment.NewLine;
            if (Reverse != default(bool))
                xml += "<Reverse>" + ReportBuilder.EncodeElementText(Reverse.ToString().ToLower()) + "</Reverse>" + Environment.NewLine;
            if (CrossAt != default(string))
                xml += "<CrossAt>" + ReportBuilder.EncodeElementText(CrossAt.ToString()) + "</CrossAt>" + Environment.NewLine;
            if (Interlaced != default(bool))
                xml += "<Interlaced>" + ReportBuilder.EncodeElementText(Interlaced.ToString().ToLower()) + "</Interlaced>" + Environment.NewLine;
            if (Scalar != default(bool))
                xml += "<Scalar>" + ReportBuilder.EncodeElementText(Scalar.ToString().ToLower()) + "</Scalar>" + Environment.NewLine;
            if (Min != default(string))
                xml += "<Min>" + ReportBuilder.EncodeElementText(Min.ToString()) + "</Min>" + Environment.NewLine;
            if (Max != default(string))
                xml += "<Max>" + ReportBuilder.EncodeElementText(Max.ToString()) + "</Max>" + Environment.NewLine;
            if (LogScale != default(bool))
                xml += "<LogScale>" + ReportBuilder.EncodeElementText(LogScale.ToString().ToLower()) + "</LogScale>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class ChartDataType : List<ChartSeriesType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (ChartSeriesType vChartSeries in this)
            {
                xml += vChartSeries.ToXml("ChartSeries");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class ChartSeriesType : IXml
    {
        public DataPointsType DataPoints = new DataPointsType(); //==Required==// 
        public PlotTypeEnum PlotType;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += DataPoints.ToXml("DataPoints");
            if (PlotType != PlotTypeEnum.__NotSet__)
                xml += "<PlotType>" + ReportBuilder.EncodeElementText(PlotType.ToString()) + "</PlotType>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class DataPointsType : List<DataPointType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (DataPointType vDataPoint in this)
            {
                xml += vDataPoint.ToXml("DataPoint");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class DataPointType : IXml
    {
        public DataValuesType DataValues = new DataValuesType(); //==Required==// 
        public DataLabelType DataLabel;
        public ActionType Action;
        public StyleType Style = new StyleType();
        public MarkerType Marker;
        public string DataElementName;
        public DataElementOutputEnum12 DataElementOutput;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += DataValues.ToXml("DataValues");
            if (DataLabel != null)
                xml += DataLabel.ToXml("DataLabel");
            if (Action != null)
                xml += Action.ToXml("Action");
            if (Style != null)
                xml += Style.ToXml("Style");
            if (Marker != null)
                xml += Marker.ToXml("Marker");
            if (DataElementName != default(string))
                xml += "<DataElementName>" + ReportBuilder.EncodeElementText(DataElementName.ToString()) + "</DataElementName>" + Environment.NewLine;
            if (DataElementOutput != DataElementOutputEnum12.__NotSet__)
                xml += "<DataElementOutput>" + ReportBuilder.EncodeElementText(DataElementOutput.ToString()) + "</DataElementOutput>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class DataValuesType : List<DataValueType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (DataValueType vDataValue in this)
            {
                xml += vDataValue.ToXml("DataValue");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class DataValueType : IXml
    {
        public string Name;
        public string Value = ""; //==Required==// 

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            if (Name != default(string))
                xml += "<Name>" + ReportBuilder.EncodeElementText(Name.ToString()) + "</Name>" + Environment.NewLine;
            xml += "<Value>" + ReportBuilder.EncodeElementText(Value.ToString()) + "</Value>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class DataLabelType : IXml
    {
        public bool Visible;
        public StyleType Style = new StyleType();
        public string Value;
        public PositionEnum3 Position;
        public int Rotation;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            if (Visible != default(bool))
                xml += "<Visible>" + ReportBuilder.EncodeElementText(Visible.ToString().ToLower()) + "</Visible>" + Environment.NewLine;
            if (Style != null)
                xml += Style.ToXml("Style");
            if (Value != default(string))
                xml += "<Value>" + ReportBuilder.EncodeElementText(Value.ToString()) + "</Value>" + Environment.NewLine;
            if (Position != PositionEnum3.__NotSet__)
                xml += "<Position>" + ReportBuilder.EncodeElementText(Position.ToString()) + "</Position>" + Environment.NewLine;
            if (Rotation != default(int))
                xml += "<Rotation>" + ReportBuilder.EncodeElementText(Rotation.ToString()) + "</Rotation>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class MarkerType : IXml
    {
        public TypeEnum1 Type;
        public SizeType Size = new SizeType();
        public StyleType Style = new StyleType();

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            if (Type != TypeEnum1.__NotSet__)
                xml += "<Type>" + ReportBuilder.EncodeElementText(Type.ToString()) + "</Type>" + Environment.NewLine;
            if (Size != null)
                xml += Size.ToXml("Size");
            if (Style != null)
                xml += Style.ToXml("Style");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class ThreeDPropertiesType : IXml
    {
        public bool Enabled;
        public ProjectionModeEnum ProjectionMode;
        public int Rotation;
        public int Inclination;
        public uint Perspective;
        public uint HeightRatio;
        public uint DepthRatio;
        public ShadingEnum Shading;
        public uint GapDepth;
        public uint WallThickness;
        public DrawingStyleEnum DrawingStyle;
        public bool Clustered;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            if (Enabled != default(bool))
                xml += "<Enabled>" + ReportBuilder.EncodeElementText(Enabled.ToString().ToLower()) + "</Enabled>" + Environment.NewLine;
            if (ProjectionMode != ProjectionModeEnum.__NotSet__)
                xml += "<ProjectionMode>" + ReportBuilder.EncodeElementText(ProjectionMode.ToString()) + "</ProjectionMode>" + Environment.NewLine;
            if (Rotation != default(int))
                xml += "<Rotation>" + ReportBuilder.EncodeElementText(Rotation.ToString()) + "</Rotation>" + Environment.NewLine;
            if (Inclination != default(int))
                xml += "<Inclination>" + ReportBuilder.EncodeElementText(Inclination.ToString()) + "</Inclination>" + Environment.NewLine;
            if (Perspective != default(uint))
                xml += "<Perspective>" + ReportBuilder.EncodeElementText(Perspective.ToString()) + "</Perspective>" + Environment.NewLine;
            if (HeightRatio != default(uint))
                xml += "<HeightRatio>" + ReportBuilder.EncodeElementText(HeightRatio.ToString()) + "</HeightRatio>" + Environment.NewLine;
            if (DepthRatio != default(uint))
                xml += "<DepthRatio>" + ReportBuilder.EncodeElementText(DepthRatio.ToString()) + "</DepthRatio>" + Environment.NewLine;
            if (Shading != ShadingEnum.__NotSet__)
                xml += "<Shading>" + ReportBuilder.EncodeElementText(Shading.ToString()) + "</Shading>" + Environment.NewLine;
            if (GapDepth != default(uint))
                xml += "<GapDepth>" + ReportBuilder.EncodeElementText(GapDepth.ToString()) + "</GapDepth>" + Environment.NewLine;
            if (WallThickness != default(uint))
                xml += "<WallThickness>" + ReportBuilder.EncodeElementText(WallThickness.ToString()) + "</WallThickness>" + Environment.NewLine;
            if (DrawingStyle != DrawingStyleEnum.__NotSet__)
                xml += "<DrawingStyle>" + ReportBuilder.EncodeElementText(DrawingStyle.ToString()) + "</DrawingStyle>" + Environment.NewLine;
            if (Clustered != default(bool))
                xml += "<Clustered>" + ReportBuilder.EncodeElementText(Clustered.ToString().ToLower()) + "</Clustered>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class PlotAreaType : IXml
    {
        public StyleType Style = new StyleType();

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            if (Style != null)
                xml += Style.ToXml("Style");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class MajorGridLinesType : IXml
    {
        public bool ShowGridLines;
        public StyleType Style = new StyleType();

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            if (ShowGridLines != default(bool))
                xml += "<ShowGridLines>" + ReportBuilder.EncodeElementText(ShowGridLines.ToString().ToLower()) + "</ShowGridLines>" + Environment.NewLine;
            if (Style != null)
                xml += Style.ToXml("Style");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class MinorGridLinesType : IXml
    {
        public bool ShowGridLines;
        public StyleType Style = new StyleType();

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            if (ShowGridLines != default(bool))
                xml += "<ShowGridLines>" + ReportBuilder.EncodeElementText(ShowGridLines.ToString().ToLower()) + "</ShowGridLines>" + Environment.NewLine;
            if (Style != null)
                xml += Style.ToXml("Style");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public enum FontStyleEnum
    {
        __NotSet__,
        Normal,
        Italic
    }

    public enum FontWeightEnum
    {
        __NotSet__,
        Normal,
        Lighter,
        Bolder,
        /*
        Thin,           //== "100"
        Extra_Light,    //== "200" //== "Extra Light" 
        Light,          //== "300"
        Medium,         //== "500"
        Semi__bold,     //== "600" //== "Semi-bold" 
        Bold,           //== "700"
        Extra_Bold,     //== "800" //== "Extra Bold"
        Heavy,          //== "900"
        */
    }

    public enum TextDecorationEnum
    {
        __NotSet__,
        None,
        Underline,
        Overline,
        LineThrough,
    }

    public enum TextAlignRptEnum
    {
        __NotSet__,
        General,
        Left,
        Center,
        Right,
    }

    public enum VerticalAlignEnum
    {
        __NotSet__,
        Top,
        Middle,
        Bottom,
    }

    public class StyleType : IXml
    {
        public BorderColorType BorderColor = new BorderColorType();
        public BorderStyleType BorderStyle = new BorderStyleType();
        public BorderWidthType BorderWidth = new BorderWidthType();
        public ColorType BackgroundColor = new ColorType();
        public string BackgroundGradientType;
        public ColorType BackgroundGradientEndColor = new ColorType();
        public BackgroundImageType BackgroundImage;

        public void Font(string pFontFamily, double pFontSize, FontWeightEnum pFontWeight, FontStyleEnum pFontStyle)
        {
            this.FontFamily = pFontFamily;
            this.FontSize.Value = pFontSize;
            this.FontWeight = pFontWeight;
            this.FontStyle = pFontStyle;
        }
        public FontStyleEnum FontStyle;
        public string FontFamily;
        public SizeType FontSize = new SizeType(SizeUnitEnum.pt_Point);
        public FontWeightEnum FontWeight;

        public string Format;
        public TextDecorationEnum TextDecoration;
        public TextAlignRptEnum TextAlign = TextAlignRptEnum.Left; /* Default mode (for RDLC) is 'General' which will cause numbers to right & dates to center.*/
        public VerticalAlignEnum VerticalAlign;
        public ColorType Color = new ColorType();
        public SizeType PaddingLeft = new SizeType(SizeUnitEnum.in_Inch);
        public SizeType PaddingRight = new SizeType(SizeUnitEnum.in_Inch);
        public SizeType PaddingTop = new SizeType(SizeUnitEnum.in_Inch);
        public SizeType PaddingBottom = new SizeType(SizeUnitEnum.in_Inch);
        public SizeType LineHeight = new SizeType(SizeUnitEnum.in_Inch);
        public string Direction;
        public string WritingMode;
        public string Language;
        public string UnicodeBiDi;
        public string Calendar;
        public string NumeralLanguage;
        public string NumeralVariant;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            if (BorderColor != null)
                xml += BorderColor.ToXml("BorderColor");
            if (BorderStyle != null)
                xml += BorderStyle.ToXml("BorderStyle");
            if (BorderWidth != null)
                xml += BorderWidth.ToXml("BorderWidth");
            if (BackgroundColor != null)
                xml += BackgroundColor.ToXml("BackgroundColor");
            if (BackgroundGradientType != default(string))
                xml += "<BackgroundGradientType>" + ReportBuilder.EncodeElementText(BackgroundGradientType.ToString()) + "</BackgroundGradientType>" + Environment.NewLine;
            if (BackgroundGradientEndColor != null)
                xml += BackgroundGradientEndColor.ToXml("BackgroundGradientEndColor");
            if (BackgroundImage != null)
                xml += BackgroundImage.ToXml("BackgroundImage");
            if (FontStyle != FontStyleEnum.__NotSet__)
                xml += "<FontStyle>" + ReportBuilder.EncodeElementText(FontStyle.ToString()) + "</FontStyle>" + Environment.NewLine;
            if (FontFamily != default(string))
                xml += "<FontFamily>" + ReportBuilder.EncodeElementText(FontFamily.ToString()) + "</FontFamily>" + Environment.NewLine;
            if (FontSize != null)
                xml += FontSize.ToXml("FontSize");
            if (FontWeight != FontWeightEnum.__NotSet__)
                xml += "<FontWeight>" + ReportBuilder.EncodeElementText(FontWeight.ToString()) + "</FontWeight>" + Environment.NewLine;
            if (Format != default(string))
                xml += "<Format>" + ReportBuilder.EncodeElementText(Format.ToString()) + "</Format>" + Environment.NewLine;
            if (TextDecoration != TextDecorationEnum.__NotSet__)
                xml += "<TextDecoration>" + ReportBuilder.EncodeElementText(TextDecoration.ToString()) + "</TextDecoration>" + Environment.NewLine;
            if (TextAlign != TextAlignRptEnum.__NotSet__)
                xml += "<TextAlign>" + ReportBuilder.EncodeElementText(TextAlign.ToString()) + "</TextAlign>" + Environment.NewLine;
            if (VerticalAlign != VerticalAlignEnum.__NotSet__)
                xml += "<VerticalAlign>" + ReportBuilder.EncodeElementText(VerticalAlign.ToString()) + "</VerticalAlign>" + Environment.NewLine;
            if (Color != null)
                xml += Color.ToXml("Color");
            if (PaddingLeft != null)
                xml += PaddingLeft.ToXml("PaddingLeft");
            if (PaddingRight != null)
                xml += PaddingRight.ToXml("PaddingRight");
            if (PaddingTop != null)
                xml += PaddingTop.ToXml("PaddingTop");
            if (PaddingBottom != null)
                xml += PaddingBottom.ToXml("PaddingBottom");
            if (LineHeight != null)
                xml += LineHeight.ToXml("LineHeight");
            if (Direction != default(string))
                xml += "<Direction>" + ReportBuilder.EncodeElementText(Direction.ToString()) + "</Direction>" + Environment.NewLine;
            if (WritingMode != default(string))
                xml += "<WritingMode>" + ReportBuilder.EncodeElementText(WritingMode.ToString()) + "</WritingMode>" + Environment.NewLine;
            if (Language != default(string))
                xml += "<Language>" + ReportBuilder.EncodeElementText(Language.ToString()) + "</Language>" + Environment.NewLine;
            if (UnicodeBiDi != default(string))
                xml += "<UnicodeBiDi>" + ReportBuilder.EncodeElementText(UnicodeBiDi.ToString()) + "</UnicodeBiDi>" + Environment.NewLine;
            if (Calendar != default(string))
                xml += "<Calendar>" + ReportBuilder.EncodeElementText(Calendar.ToString()) + "</Calendar>" + Environment.NewLine;
            if (NumeralLanguage != default(string))
                xml += "<NumeralLanguage>" + ReportBuilder.EncodeElementText(NumeralLanguage.ToString()) + "</NumeralLanguage>" + Environment.NewLine;
            if (NumeralVariant != default(string))
                xml += "<NumeralVariant>" + ReportBuilder.EncodeElementText(NumeralVariant.ToString()) + "</NumeralVariant>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class BorderColorType : IXml
    {
        public ColorType Default = new ColorType();
        public ColorType Left = new ColorType();
        public ColorType Right = new ColorType();
        public ColorType Top = new ColorType();
        public ColorType Bottom = new ColorType();

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            if (Default != null)
                xml += Default.ToXml("Default");
            if (Left != null)
                xml += Left.ToXml("Left");
            if (Right != null)
                xml += Right.ToXml("Right");
            if (Top != null)
                xml += Top.ToXml("Top");
            if (Bottom != null)
                xml += Bottom.ToXml("Bottom");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class BorderStyleType : IXml
    {
        public BorderStyleEnum Default;
        public BorderStyleEnum Left;
        public BorderStyleEnum Right;
        public BorderStyleEnum Top;
        public BorderStyleEnum Bottom;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            if (Default != BorderStyleEnum.__NotSet__)
                xml += "<Default>" + ReportBuilder.EncodeElementText(Default.ToString()) + "</Default>" + Environment.NewLine;
            if (Left != BorderStyleEnum.__NotSet__)
                xml += "<Left>" + ReportBuilder.EncodeElementText(Left.ToString()) + "</Left>" + Environment.NewLine;
            if (Right != BorderStyleEnum.__NotSet__)
                xml += "<Right>" + ReportBuilder.EncodeElementText(Right.ToString()) + "</Right>" + Environment.NewLine;
            if (Top != BorderStyleEnum.__NotSet__)
                xml += "<Top>" + ReportBuilder.EncodeElementText(Top.ToString()) + "</Top>" + Environment.NewLine;
            if (Bottom != BorderStyleEnum.__NotSet__)
                xml += "<Bottom>" + ReportBuilder.EncodeElementText(Bottom.ToString()) + "</Bottom>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class BorderWidthType : IXml
    {
        public SizeType Default = new SizeType(SizeUnitEnum.pt_Point);
        public SizeType Left = new SizeType(SizeUnitEnum.pt_Point);
        public SizeType Right = new SizeType(SizeUnitEnum.pt_Point);
        public SizeType Top = new SizeType(SizeUnitEnum.pt_Point);
        public SizeType Bottom = new SizeType(SizeUnitEnum.pt_Point);

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            if (Default != null)
                xml += Default.ToXml("Default");
            if (Left != null)
                xml += Left.ToXml("Left");
            if (Right != null)
                xml += Right.ToXml("Right");
            if (Top != null)
                xml += Top.ToXml("Top");
            if (Bottom != null)
                xml += Bottom.ToXml("Bottom");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class BackgroundImageType : IXml
    {
        public SourceEnum1 Source; //==Required==// 
        public string Value = ""; //==Required==// 
        public string MIMEType;
        public string BackgroundRepeat;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";

            xml += "<Source>" + ReportBuilder.EncodeElementText(Source.ToString()) + "</Source>" + Environment.NewLine;
            xml += "<Value>" + ReportBuilder.EncodeElementText(Value.ToString()) + "</Value>" + Environment.NewLine;
            if (MIMEType != default(string))
                xml += "<MIMEType>" + ReportBuilder.EncodeElementText(MIMEType.ToString()) + "</MIMEType>" + Environment.NewLine;
            if (BackgroundRepeat != default(string))
                xml += "<BackgroundRepeat>" + ReportBuilder.EncodeElementText(BackgroundRepeat.ToString()) + "</BackgroundRepeat>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class FiltersType : List<FilterType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (FilterType vFilter in this)
            {
                xml += vFilter.ToXml("Filter");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class FilterType : IXml
    {
        public string FilterExpression = ""; //==Required==// 
        public OperatorEnum Operator; //==Required==// 
        public FilterValuesType FilterValues = new FilterValuesType(); //==Required==// 

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += "<FilterExpression>" + ReportBuilder.EncodeElementText(FilterExpression.ToString()) + "</FilterExpression>" + Environment.NewLine;
            xml += "<Operator>" + ReportBuilder.EncodeElementText(Operator.ToString()) + "</Operator>" + Environment.NewLine;
            xml += FilterValues.ToXml("FilterValues");


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class FilterValuesType : List<string>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (string vFilterValue in this)
            {
                xml += "<FilterValue>" + ReportBuilder.EncodeElementText(vFilterValue.ToString()) + "</FilterValue>" + Environment.NewLine;
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class UserSortType : IXml
    {
        public string SortExpression = ""; //==Required==// 
        public string SortExpressionScope;
        public string SortTarget;

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            xml += "<SortExpression>" + ReportBuilder.EncodeElementText(SortExpression.ToString()) + "</SortExpression>" + Environment.NewLine;
            if (SortExpressionScope != default(string))
                xml += "<SortExpressionScope>" + ReportBuilder.EncodeElementText(SortExpressionScope.ToString()) + "</SortExpressionScope>" + Environment.NewLine;
            if (SortTarget != default(string))
                xml += "<SortTarget>" + ReportBuilder.EncodeElementText(SortTarget.ToString()) + "</SortTarget>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class CustomPropertiesType : List<CustomPropertyType>, IXml
    {

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            foreach (CustomPropertyType vCustomProperty in this)
            {
                xml += vCustomProperty.ToXml("CustomProperty");
            }


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//

    public class CustomPropertyType : IXml
    {
        public string Name;
        public string Value = ""; //==Required==// 

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            string xmlparent = "";
            string attribs = "";

            if (attribs.Trim() == "") attribs = "";


            if (Name != default(string))
                xml += "<Name>" + ReportBuilder.EncodeElementText(Name.ToString()) + "</Name>" + Environment.NewLine;
            xml += "<Value>" + ReportBuilder.EncodeElementText(Value.ToString()) + "</Value>" + Environment.NewLine;


            if (pParentElementName == "")
            {
                xmlparent += xml;
            }
            else if (xml.Trim() == "")
            {
                xmlparent += "<" + pParentElementName + attribs + " />" + Environment.NewLine;
            }
            else
            {
                xmlparent += "<" + pParentElementName + attribs + ">" + Environment.NewLine;
                xmlparent += xml;
                xmlparent += "</" + pParentElementName + ">" + Environment.NewLine;
            }

            return xmlparent;
        }
    }//cls//


    public class ColorType : IXml //base: xsd:normalizedString
    {
        public System.Drawing.Color Color = System.Drawing.Color.Empty;

        /*
        KnownColor is an enum of known colors inclg sys-colors.   Color.FromKnownColor, oColor.IsKnownColor, oColor.ToKnownColor().ToString(), 
        Name is a string form of KnownColor(s). Color.FromName, oColor.IsNamedColor, oColor.Name
            IsKnownColor & IsNamedColor returns same value.
        */
        public string ToXml(string pParentElementName)
        {
            string xml = "";

            if (Color.IsEmpty)
            {
                xml = "";
            }
            else
            {
                bool vIsNamedColor = false;
                if (Color.IsSystemColor) /**/
                {
                    vIsNamedColor = false; /*bcoz RDL doesn't support system colors.*/
                }
                else if (Color.IsNamedColor)
                {
                    vIsNamedColor = true;
                }

                if (Color.IsEmpty)
                {
                    return "";
                }
                if (vIsNamedColor)
                {
                    xml += "<" + pParentElementName + ">";
                    xml += Color.Name;
                    xml += "</" + pParentElementName + ">" + Environment.NewLine;
                }
                else
                {
                    xml += "<" + pParentElementName + ">";
                    const int HEX_BASE = 16;
                    xml += 
                        "#"
                        + (Color.R <= 15 ? "" : "0") + Convert.ToString(Color.R, HEX_BASE)
                        + (Color.G <= 15 ? "" : "0") + Convert.ToString(Color.G, HEX_BASE)
                        + (Color.B <= 15 ? "" : "0") + Convert.ToString(Color.B, HEX_BASE)
                        ;
                    xml += "</" + pParentElementName + ">" + Environment.NewLine;
                }
            }
            return xml;
        }
    }

    public class SizeType : IXml //base: xsd:normalizedString
    {
        //A length value is formed by an optional + or -, 
        //    followed by a number, 
        //    followed by a two-letter abbreviation that indicates the unit. 
        //    There are no spaces in a length value; e.g., 1.3 in is not a valid length value, but 1.3in is valid. 
        //    A length of 0 does not require the two-letter unit identifier.
        //Absolute Lenght Units are:
        //    * in (inches; 1in=2.54cm)
        //    * cm (centimeters; 1cm=10mm)
        //    * mm (millimeters)
        //    * pt (points; 1pt=1/72in)
        //    * pc (picas; 1pc=12pt)

        public double Value = -1;
        public SizeUnitEnum Unit;

        public SizeType()
        {
            Unit = SizeUnitEnum.in_Inch; //== "in" by default
        }

        public SizeType(SizeUnitEnum pUnit)
        {
            Unit = pUnit;
        }

        public string ToXml(string pParentElementName)
        {
            string xml = "";
            if (Value != -1)
            {
                xml += "<" + pParentElementName + ">" + Value + "" + Unit.ToString().Substring(0, 2) + "</" + pParentElementName + ">" + Environment.NewLine;
            }
            return xml;
        }
    }//cls//

    public enum SizeUnitEnum
    {
        in_Inch,
        cm_Centimeter,
        mm_Millimeter,
        pt_Point,
        pc_Pica
    }//enum//


    public enum BorderStyleEnum
    {
        __NotSet__,
        None,
        Solid,
        Dotted,
        Dashed,
        Double,
        Groove,
        Ridge,
        Inset,
        WindowInset,
        Outset,
    }


    


    public enum DataElementStyleEnum
    {
        __NotSet__,
        AttributeNormal,
        ElementNormal,
    }//enum//

    public enum DataTypeEnum
    {
        //==__NotSet__,
        Boolean,
        DateTime,
        Integer,
        Float,
        String,
    }//enum//

    public enum UsedInQueryEnum
    {
        __NotSet__,
        False,
        True,
        Auto,
    }//enum//

    public enum CaseSensitivityEnum
    {
        __NotSet__,
        True,
        False,
        Auto,
    }//enum//

    public enum AccentSensitivityEnum
    {
        __NotSet__,
        True,
        False,
        Auto,
    }//enum//

    public enum KanatypeSensitivityEnum
    {
        __NotSet__,
        True,
        False,
        Auto,
    }//enum//

    public enum WidthSensitivityEnum
    {
        __NotSet__,
        True,
        False,
        Auto,
    }//enum//

    public enum CommandTypeEnum
    {
        __NotSet__,
        Text,
        StoredProcedure,
        TableDirect,
    }//enum//

    public enum DataElementOutputEnum
    {
        __NotSet__,
        Output,
        NoOutput,
        ContentsOnly,
        Auto,
    }//enum//

    public enum DataElementOutputEnum1
    {
        __NotSet__,
        Output,
        NoOutput,
        ContentsOnly,
        Auto,
    }//enum//

    public enum DataElementOutputEnum2
    {
        __NotSet__,
        Output,
        NoOutput,
        ContentsOnly,
        Auto,
    }//enum//

    public enum DataElementStyleEnum1
    {
        __NotSet__,
        Auto,
        AttributeNormal,
        ElementNormal,
    }//enum//

    public enum SourceEnum
    {
        //==__NotSet__,
        External,
        Embedded,
        Database,
    }//enum//

    public enum SizingEnum
    {
        __NotSet__,
        AutoSize,
        Fit,
        FitProportional,
        Clip,
    }//enum//

    public enum DataElementOutputEnum3
    {
        __NotSet__,
        Output,
        NoOutput,
        ContentsOnly,
        Auto,
    }//enum//

    public enum DataElementOutputEnum4
    {
        __NotSet__,
        Output,
        NoOutput,
        ContentsOnly,
        Auto,
    }//enum//

    public enum DataElementOutputEnum5
    {
        __NotSet__,
        Output,
        NoOutput,
        ContentsOnly,
        Auto,
    }//enum//

    public enum DataInstanceElementOutputEnum
    {
        __NotSet__,
        Output,
        NoOutput,
        ContentsOnly,
    }//enum//

    public enum DataElementOutputEnum6
    {
        __NotSet__,
        Output,
        NoOutput,
        ContentsOnly,
        Auto,
    }//enum//

    public enum DataElementOutputEnum7
    {
        __NotSet__,
        Output,
        NoOutput,
        ContentsOnly,
    }//enum//

    public enum DirectionEnum
    {
        __NotSet__,
        Ascending,
        Descending,
    }//enum//

    public enum LayoutDirectionEnum
    {
        __NotSet__,
        LTR,
        RTL,
    }//enum//

    public enum DataElementOutputEnum8
    {
        __NotSet__,
        Output,
        NoOutput,
        ContentsOnly,
        Auto,
    }//enum//

    public enum CellDataElementOutputEnum
    {
        __NotSet__,
        Output,
        NoOutput,
        ContentsOnly,
    }//enum//

    public enum PositionEnum
    {
        __NotSet__,
        Before,
        After,
    }//enum//

    public enum DataElementOutputEnum9
    {
        __NotSet__,
        Output,
        NoOutput,
        ContentsOnly,
    }//enum//

    public enum DataElementOutputEnum10
    {
        __NotSet__,
        Output,
        NoOutput,
        ContentsOnly,
        Auto,
    }//enum//

    public enum DetailDataElementOutputEnum
    {
        __NotSet__,
        Output,
        NoOutput,
        ContentsOnly,
    }//enum//

    public enum TypeEnum
    {
        __NotSet__,
        Column,
        Bar,
        Line,
        Pie,
        Scatter,
        Bubble,
        Area,
        Doughnut,
        Stock,
    }//enum//

    public enum SubtypeEnum
    {
        __NotSet__,
        Stacked,
        PercentStacked,
        Plain,
        Smooth,
        Exploded,
        Line,
        SmoothLine,
        HighLowClose,
        OpenHighLowClose,
        Candlestick,
    }//enum//

    public enum PaletteEnum
    {
        __NotSet__,
        Default,
        EarthTones,
        Excel,
        GrayScale,
        Light,
        Pastel,
        SemiTransparent,
    }//enum//

    public enum DataElementOutputEnum11
    {
        __NotSet__,
        Output,
        NoOutput,
        ContentsOnly,
        Auto,
    }//enum//

    public enum ChartElementOutputEnum
    {
        __NotSet__,
        Output,
        NoOutput,
    }//enum//

    public enum PositionEnum1
    {
        __NotSet__,
        Center,
        Near,
        Far,
    }//enum//

    public enum PositionEnum2
    {
        __NotSet__,
        TopLeft,
        TopCenter,
        TopRight,
        LeftTop,
        LeftCenter,
        LeftBottom,
        RightTop,
        RightCenter,
        RightBottom,
        BottomLeft,
        BottomCenter,
        BottomRight,
    }//enum//

    public enum LayoutEnum
    {
        __NotSet__,
        Column,
        Row,
        Table,
    }//enum//

    public enum MajorTickMarksEnum
    {
        __NotSet__,
        None,
        Inside,
        Outside,
        Cross,
    }//enum//

    public enum MinorTickMarksEnum
    {
        __NotSet__,
        None,
        Inside,
        Outside,
        Cross,
    }//enum//

    public enum PlotTypeEnum
    {
        __NotSet__,
        Auto,
        Line,
    }//enum//

    public enum DataElementOutputEnum12
    {
        __NotSet__,
        Output,
        NoOutput,
    }//enum//

    public enum PositionEnum3
    {
        __NotSet__,
        Auto,
        Top,
        TopLeft,
        TopRight,
        Left,
        Center,
        Right,
        BottomLeft,
        Bottom,
        BottomRight,
    }//enum//

    public enum TypeEnum1
    {
        __NotSet__,
        None,
        Square,
        Circle,
        Diamond,
        Triangle,
        Cross,
        Auto,
    }//enum//

    public enum ProjectionModeEnum
    {
        __NotSet__,
        Perspective,
        Orthographic,
    }//enum//

    public enum ShadingEnum
    {
        __NotSet__,
        None,
        Simple,
        Real,
    }//enum//

    public enum DrawingStyleEnum
    {
        __NotSet__,
        Cube,
        Cylinder,
    }//enum//

    public enum SourceEnum1
    {
        //==__NotSet__,
        External,
        Embedded,
        Database,
    }//enum//

    public enum OperatorEnum
    {
        //==__NotSet__,
        Equal,
        Like,
        NotEqual,
        GreaterThan,
        GreaterThanOrEqual,
        LessThan,
        LessThanOrEqual,
        TopN,
        BottomN,
        TopPercent,
        BottomPercent,
        In,
        Between,
    }//enum//

}//ns//
