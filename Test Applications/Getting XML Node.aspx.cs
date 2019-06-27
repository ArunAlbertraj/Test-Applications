using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace Test_Applications
{
    public partial class Getting_XML_Node : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void ElementsAndSubelements()
        {
            //for (var i = 0; i < objdata.Table1.length - 1; i++)
            //{
            //    if (objdata.Table1[i][1] != 0)
            //    {
            //        if (objdata.Table1[i][1] == 1)
            //        {
            //            if (objdata.Table1[i][1] == 0)
            //            {
            //                //headPoint = objdata.Table1[i][0];
            //                //first = false;
            //                //Elements += "<ul class=\"menu\"><li><a href='#' onclick=XmlElements('" + objdata.Table1[i][2] + "','" + objdata.Table1[i][0] + "','" + objdata.Table1[i][1] + "') id='btn_loadEditor" + objdata.Table1[i][2] + "' title='Editor'>" + objdata.Table1[i][2] + "</a>";
            //            }
            //            else
            //            {
            //                if (headPoint == objdata.Table1[i][1])
            //                {
            //                    Elements += "<ul class=\"submenu\"><li><a href='#' onclick=XmlElements('" + objdata.Table1[i][2] + "','" + objdata.Table1[i][0] + "','" + objdata.Table1[i][1] + "') id='btn_loadEditor" + objdata.Table1[i][2] + "' title='Editor'>" + objdata.Table1[i][2] + "</a></li></ul>";
            //                }
            //                else
            //                {
            //                    if (!first)
            //                    {
            //                        headPoint = objdata.Table1[i][0];
            //                        Elements += "</li></ul>";
            //                    }
            //                    else
            //                    {
            //                        first = false;
            //                    }
            //                    if (i != objdata.Table1.length - 1)
            //                    {
            //                        headPoint = objdata.Table1[i][0];
            //                        Elements += "<ul class=\"mainmenu\"><li><a href='#' onclick=XmlElements('" + objdata.Table1[i][2] + "','" + objdata.Table1[i][0] + "','" + objdata.Table1[i][1] + "') id='btn_loadEditor" + objdata.Table1[i][2] + "' title='Editor'>" + objdata.Table1[i][2] + "</a>";
            //                    }
            //                }
            //            }
            //        }
            //        else
            //        {
            //            if (headPoint == objdata.Table1[i][1])
            //            {
            //                Elements += "<ul class=\"submenu\"><li><a href='#' onclick=XmlElements('" + objdata.Table1[i][2] + "','" + objdata.Table1[i][0] + "','" + objdata.Table1[i][1] + "') id='btn_loadEditor" + objdata.Table1[i][2] + "' title='Editor'>" + objdata.Table1[i][2] + "</a></li></ul>";
            //            }
            //            else
            //            {
            //                if (!first)
            //                {
            //                    headPoint = objdata.Table1[i][0];
            //                    Elements += "</li></ul>";

            //                }
            //                else
            //                {
            //                    first = false;
            //                }
            //                if (i != objdata.Table1.length - 1)
            //                {
            //                    headPoint = objdata.Table1[i][0];
            //                    Elements += "<ul class=\"mainmenu\"><li><a href='#' onclick=XmlElements('" + objdata.Table1[i][2] + "','" + objdata.Table1[i][0] + "','" + objdata.Table1[i][1] + "') id='btn_loadEditor" + objdata.Table1[i][2] + "' title='Editor'>" + objdata.Table1[i][2] + "</a>";
            //                }
            //            }
            //        }
            //    }
            //}
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"D:\Albert\TFS\Fin.Pub\OPS_eProofing\ProofingSystemWorkspace\Neptune-Alias.xlsx");
            Excel._Worksheet xlWorksheet = (Excel.Worksheet)xlWorkbook.Worksheets.get_Item(1);
            Excel.Range xlRange = xlWorksheet.UsedRange;

            Dictionary<string, string> excelDict = new Dictionary<string, string>();

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            for (int i = 2; i < rowCount; i++)
            {
                if (xlRange.Cells[i, 1] != null && Convert.ToString(((Excel.Range)xlRange.Cells[i, 2]).Value2) != null)
                {
                    excelDict.Add(((Excel.Range)xlRange.Cells[i, 1]).Value2.ToString().Replace(":", "."), ((Excel.Range)xlRange.Cells[i, 2]).Value2.ToString());
                }
            }

            string daresult = null;
            //Excel.Application xlApp;
            //Excel.Workbook xlWorkBook;
            //Excel.Worksheet xlWorkSheet;
            //Excel.Range range;

            //string str;
            //int rCnt;
            //int cCnt;
            //int rw = 0;
            //int cl = 0;

            //xlApp = new Excel.Application();
            //xlWorkBook = xlApp.Workbooks.Open(@"D:\Albert\TFS\Fin.Pub\OPS_eProofing\ProofingSystemWorkspace\Neptune-Alias.xlsx", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            //xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //range = xlWorkSheet.UsedRange;
            //rw = range.Rows.Count;
            //cl = range.Columns.Count;

            //for (rCnt = 1; rCnt <= rw; rCnt++)
            //{
            //    for (cCnt = 1; cCnt <= cl; cCnt++)
            //    {
            //        str = (string)(range.Cells[rCnt, cCnt] as Excel.Range).Value2;
            //        //MessageBox.Show(str);
            //    }
            //}

            //xlWorkBook.Close(true, null, null);
            //xlApp.Quit();

            //Marshal.ReleaseComObject(xlWorkSheet);
            //Marshal.ReleaseComObject(xlWorkBook);
            //Marshal.ReleaseComObject(xlApp);

            //Excel.Application xlApp = new Excel.Application();
            //Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"D:\Albert\TFS\Fin.Pub\OPS_eProofing\ProofingSystemWorkspace\Neptune-Alias.xlsx");
            //Excel._Worksheet xlWorksheet = (Excel.Worksheet)xlWorkbook.Worksheets.get_Item(1);
            //Excel.Range xlRange = xlWorksheet.UsedRange;

            //Dictionary<string, string> excelDict = new Dictionary<string, string>();

            //int rowCount = xlRange.Rows.Count;
            //int colCount = xlRange.Columns.Count;

            //for (int i = 2; i <= rowCount; i++)
            //{
            //    if (xlRange.Cells[i, 1] != null && Convert.ToString(xlRange.Cells[i, 2].Value2) != null)
            //    {
            //        excelDict.Add(xlRange.Cells[i, 1].Value2.ToString(), xlRange.Cells[i, 2].Value2.ToString());
            //    }
            //}

            //string daresult = null;
            //DataTable yourDataTable = new DataTable();
            //DataSet ds = new DataSet();
            //XNamespace xNSpace = "http://www.lexisnexis.com/namespace/sslrp/core";
            //XNamespace xmlNS = "http://relaxng.org/ns/structure/1.0";


            //XDocument xFile = XDocument.Load(@"D:\Albert\TFS\Fin.Pub\USA.xml");
            //XmlDocument xDoc = new XmlDocument();
            //xDoc.Load(@"D:\Albert\TFS\Fin.Pub\USA.xml");
            //XmlNamespaceManager nsmgr = new XmlNamespaceManager(xDoc.NameTable);
            //nsmgr.AddNamespace("core", "http://www.lexisnexis.com/namespace/sslrp/core");
            //nsmgr.AddNamespace("a", "http://relaxng.org/ns/compatibility/annotations/1.0");
            //nsmgr.AddNamespace("ps", "http://www.lexisnexis.com/namespace/sslrp/ps");
            //nsmgr.AddNamespace("di", "http://www.lexisnexis.com/namespace/sslrp/di");
            //nsmgr.AddNamespace("fn", "http://www.lexisnexis.com/namespace/sslrp/fn");
            //nsmgr.AddNamespace("glph", "http://www.lexisnexis.com/namespace/sslrp/glph");
            //nsmgr.AddNamespace("se", "http://www.lexisnexis.com/namespace/sslrp/se");
            //nsmgr.AddNamespace("pnfo", "http://www.lexisnexis.com/namespace/sslrp/pnfo");
            //nsmgr.AddNamespace("form", "http://www.lexisnexis.com/namespace/sslrp/form");
            //nsmgr.AddNamespace("meta", "http://www.lexisnexis.com/namespace/sslrp/meta");
            //nsmgr.AddNamespace("lnci", "http://www.lexisnexis.com/namespace/common/lnci");
            //nsmgr.AddNamespace("sip", "http://www.lexisnexis.com/namespace/sslrp/sip");
            //nsmgr.AddNamespace("tr", "http://www.lexisnexis.com/namespace/sslrp/tr");
            ////nsmgr.AddNamespace("xmlns", "http://relaxng.org/ns/structure/1.0");

            //xDoc.Load(@"D:\Albert\TFS\Fin.Pub\USA.xml");
            //string node = "core:para";
            //string[] nodeName = node.Split(':');
            //string attrName = "attlist." + nodeName[0] + "." + nodeName[1];
            ////  XmlNodeList xNode = xDoc.SelectNodes("//define[@name='core.para']", nsmgr);
            //// XmlNodeList xNodeList = xDoc.SelectNodes("//element[@name='" + node + "']", nsmgr);            
            ////  XmlNodeList xAttrList = xDoc.SelectNodes("//define[@name='" + attrName + "']", nsmgr);
            ////  XmlNodeList xAttrMandatory = xDoc.SelectNodes("//define[@name='" + attrName + "']//attribute", nsmgr);

            //XmlNodeList xNodeElements = xDoc.SelectNodes("//element[@name='" + node + "']//ref", nsmgr);

            //yourDataTable.Columns.AddRange(new DataColumn[6] { new DataColumn("KeyId", typeof(Int16)),new DataColumn("Pid", typeof(Int16)),new DataColumn("Name", typeof(string)),
            //new DataColumn("Mandatory",typeof(bool)),new DataColumn("ZeroOrMore",typeof(bool)),new DataColumn("OneOrMore",typeof(bool)) });

            //int xKeyId = 1;
            //int xPid = 1;
            //int xParentId = 0;

            //yourDataTable.Rows.Add(xKeyId, xParentId, node, false,false,false);
            //xKeyId++;            
            //xParentId = xPid;

            //if (string.IsNullOrWhiteSpace(prNode) && parent)
            //{
            //    XmlNodeList xAttrMandatory = xDoc.SelectNodes("//define[@name='" + attrName + "']//attribute", nsmgr);
            //    XmlNodeList xNodeElements = xDoc.SelectNodes("//element[@name='" + elementName + "']//ref", nsmgr);

            //    foreach (XmlElement xAttr in xAttrMandatory)
            //    {
            //        if (!xAttr.GetAttribute("name").Contains("attlist."))
            //        {
            //            var parentNode = xAttr.ParentNode.Name.Trim();
            //            if (xAttr.ParentNode.Name.Trim() == "choice")
            //            {
            //                parentNode = xAttr.ParentNode.ParentNode.Name.Trim();
            //            }
            //            if (parentNode == "zeroOrMore")
            //            {
            //                yourDataTable.Rows.Add(xAttr.GetAttribute("name"), false, true, false, "Chosen-Optional");
            //            }
            //            else if (parentNode == "oneOrMore")
            //            {
            //                yourDataTable.Rows.Add(xAttr.GetAttribute("name"), false, false, true, "Chosen-Optional");
            //            }
            //            else if (parentNode == "optional")
            //            {
            //                yourDataTable.Rows.Add(xAttr.GetAttribute("name"), false, false, false, "Chosen-Optional");
            //            }
            //            else
            //            {
            //                yourDataTable.Rows.Add(xAttr.GetAttribute("name"), true, false, false, "Chosen-Attributes");
            //            }
            //        }
            //    }
            //    yourDataTable.Rows.Add(node, true, false, false, "Chosen-Elements");

            //    foreach (XmlElement xAttr in xNodeElements)
            //    {
            //        if (!xAttr.GetAttribute("name").Contains("attlist."))
            //        {
            //            var parentNode = xAttr.ParentNode.Name.Trim();
            //            if (xAttr.ParentNode.Name.Trim() == "choice")
            //            {
            //                parentNode = xAttr.ParentNode.ParentNode.Name.Trim();
            //            }

            //            if (parentNode != "zeroOrMore" && parentNode != "oneOrMore" && parentNode != "optional")
            //            {
            //                var subElement = "attlist." + xAttr.GetAttribute("name");
            //                XmlNodeList xAttributesMandatory = xDoc.SelectNodes("//define[@name='" + subElement + "']//attribute", nsmgr);

            //                foreach (XmlElement xAttribute in xAttributesMandatory)
            //                {
            //                    bool subAttr = true;
            //                    if (!xAttribute.GetAttribute("name").Contains("attlist."))
            //                    {
            //                        var subParentNode = xAttribute.ParentNode.Name.Trim();
            //                        if (xAttribute.ParentNode.Name.Trim() == "choice")
            //                        {
            //                            subParentNode = xAttribute.ParentNode.ParentNode.Name.Trim();
            //                        }

            //                        if (subParentNode != "zeroOrMore" && subParentNode != "oneOrMore" && subParentNode != "optional")
            //                        {
            //                            yourDataTable.Rows.Add(xAttribute.GetAttribute("name"), true, true, false, "Subelement-Attributes");
            //                        }
            //                    }
            //                }
            //                yourDataTable.Rows.Add(xAttr.GetAttribute("name"), true, true, false, "Sub-Elements");
            //            }
            //        }
            //    }
            //}
            //else if (!string.IsNullOrWhiteSpace(prNode) && !parent)
            //{
            //    string attrName1 = "attlist." + prNode;
            //    string[] nodeName1 = prNode.Split('.');
            //    string elementName1 = string.Empty;
            //    if (nodeName1.Count() >= 2)
            //    {
            //        elementName1 = prNode.Replace(nodeName1[0] + ".", nodeName1[0] + ":");
            //    }
            //    else
            //    {
            //        elementName1 = prNode;
            //    }

            //    XmlNodeList xAttrMandatory1 = xDoc.SelectNodes("//define[@name='" + attrName1 + "']//attribute", nsmgr);
            //    XmlNodeList xNodeElements = xDoc.SelectNodes("//element[@name='" + elementName1 + "']//ref", nsmgr);

            //    foreach (XmlElement xAttr in xAttrMandatory1)
            //    {
            //        if (!xAttr.GetAttribute("name").Contains("attlist."))
            //        {
            //            var parentNode = xAttr.ParentNode.Name.Trim();
            //            if (xAttr.ParentNode.Name.Trim() == "choice")
            //            {
            //                parentNode = xAttr.ParentNode.ParentNode.Name.Trim();
            //            }
            //            if (parentNode != "zeroOrMore" && parentNode != "oneOrMore" && parentNode != "optional")
            //            {
            //                yourDataTable.Rows.Add(xAttr.GetAttribute("name"), true, false, false, "Main-Attributes");
            //            }
            //        }
            //    }
            //    yourDataTable.Rows.Add(prNode, true, false, false, "Main-Elements");

            //    foreach (XmlElement xAttr in xNodeElements)
            //    {
            //        if (!xAttr.GetAttribute("name").Contains("attlist."))
            //        {
            //            var parentNode = xAttr.ParentNode.Name.Trim();
            //            if (xAttr.ParentNode.Name.Trim() == "choice")
            //            {
            //                parentNode = xAttr.ParentNode.ParentNode.Name.Trim();
            //            }

            //            if (parentNode != "zeroOrMore" && parentNode != "oneOrMore" && parentNode != "optional")
            //            {
            //                if (xAttr.GetAttribute("name").Trim() != node)
            //                {
            //                    sameElemets += "" + xAttr.GetAttribute("name") + " is mandatory elements";
            //                }
            //                var subElement = "attlist." + xAttr.GetAttribute("name");
            //                XmlNodeList xAttributesMandatory = xDoc.SelectNodes("//define[@name='" + subElement + "']//attribute", nsmgr);

            //                foreach (XmlElement xAttribute in xAttributesMandatory)
            //                {
            //                    var subParentNode = xAttribute.ParentNode.Name.Trim();
            //                    if (xAttribute.ParentNode.Name.Trim() == "choice")
            //                    {
            //                        subParentNode = xAttribute.ParentNode.ParentNode.Name.Trim();
            //                    }

            //                    if (subParentNode != "zeroOrMore" && subParentNode != "oneOrMore" && subParentNode != "optional")
            //                    {
            //                        yourDataTable.Rows.Add(xAttribute.GetAttribute("name"), true, true, false, "Sub-Elements");
            //                    }
            //                }
            //                yourDataTable.Rows.Add(xAttr.GetAttribute("name"), true, true, false, "Subelement-Attributes");
            //            }
            //        }
            //    }

            //    XmlNodeList xAttrMandatory = xDoc.SelectNodes("//define[@name='" + attrName + "']//attribute", nsmgr);

            //    foreach (XmlElement xAttr in xAttrMandatory)
            //    {
            //        if (!xAttr.GetAttribute("name").Contains("attlist."))
            //        {
            //            var parentNode = xAttr.ParentNode.Name.Trim();
            //            if (xAttr.ParentNode.Name.Trim() == "choice")
            //            {
            //                parentNode = xAttr.ParentNode.ParentNode.Name.Trim();
            //            }
            //            if (parentNode == "zeroOrMore")
            //            {
            //                yourDataTable.Rows.Add(xAttr.GetAttribute("name"), false, true, false, "Chosen-Optional");
            //            }
            //            else if (parentNode == "oneOrMore")
            //            {
            //                yourDataTable.Rows.Add(xAttr.GetAttribute("name"), false, false, true, "Chosen-Optional");
            //            }
            //            else if (parentNode == "optional")
            //            {
            //                yourDataTable.Rows.Add(xAttr.GetAttribute("name"), false, false, false, "Chosen-Optional");
            //            }
            //            else
            //            {
            //                yourDataTable.Rows.Add(xAttr.GetAttribute("name"), true, false, false, "Chosen-Attributes");
            //            }
            //        }
            //    }
            //    yourDataTable.Rows.Add(node, true, false, false, "Chosen-Elements");
            //}

            //ds.Tables.Add(yourDataTable);

            //    var Elements = "<li><a href='#' onclick=XmlElements(" + objdata.Table1[i][0] + ") id='btn_loadEditor" + objdata.Table1[i][0] + "' title='Editor'>" + objdata.Table1[i][0] + "</a></li>";
            //    $("#SelectMenuContainer").append(Elements); 
            //}
            //else
            //{
            //    var Elements = "<li><a href='#' onclick=XmlElements(" + objdata.Table1[i][0] + ") id='btn_loadEditor" + objdata.Table1[i][0] + "' title='Editor'>" + objdata.Table1[i][0] + "</a><ul class=\"sub-menu\"><li><a href='#' onclick=XmlElements(" + objdata.Table1[i][1] + ") id='btn_loadEditor" + objdata.Table1[i][1] + "' title='Editor'>" + objdata.Table1[i][1] + "</a></li></ul></li></ul>";
            //    $("#SelectMenuContainer").append(Elements);
            //XmlNodeList xNode = xDoc.SelectNodes("//define[@name='core.para']", nsmgr);
            //XmlNodeList xNode1 = xDoc.SelectNodes("//define[@name='para']");
            //XmlNodeList xNode2 = xDoc.SelectNodes("//element[@name='core:para']", nsmgr);            
            //XmlNodeList xNode4 = xDoc.SelectNodes("//element[@name='core:para']");            

            //XmlNodeList xNode = xDoc.SelectNodes("//define", nsmgr);
            //XmlNodeList xNode1 = xDoc.SelectNodes("//define[@name='core.para']",nsmgr);
            ////XmlNodeList xNode4 = xDoc.SelectNodes("//define[@name='para']", nsmgr);
            //XmlNodeList xNode2 = xDoc.SelectNodes("//define");
            //XmlNodeList xNode3 = xDoc.SelectNodes("/define");

            //List<XElement> xEle = xFile.Descendants().ToList();
            //List<XElement> xEle2 = xFile.Descendants(xNSpace + "define").ToList();
            //List<XElement> xEle5 = xFile.Descendants("define").ToList();
            //List<XElement> xEle6 = xFile.Descendants("define").Where(x => x.Attribute("name").Value == "core.para").ToList();
            //List<XElement> xEle7 = xFile.Descendants("define").Where(x => x.Attribute("name").Value == "para").ToList();

            //IEnumerable<XElement> address = from el in xFile.Elements(xmlNS + "define")
            //                                where (string)el.Attribute("name") == "core.para"
            //                                select el;

            //IEnumerable<XElement> address1 = from el in xFile.Elements(xmlNS + "define")
            //                                 where (string)el.Attribute("name") == "para"
            //                                 select el;

            //List<XElement> xEle1 = xFile.Descendants().Where(x => x.Element("define").Attribute("name").Value == xNSpace + "core.para").ToList();
            //var xEle4 = xFile.Descendants().Where(x => (string)x.Element("define").Attribute("name").Value == xNSpace + "para").FirstOrDefault();

            //yourDataTable.Columns.AddRange(new DataColumn[3] { new DataColumn("Name", typeof(string)),new DataColumn("List", typeof(string)),
            //new DataColumn("Check",typeof(bool)) });
            //yourDataTable.Rows.Add("n-Head1", "Subsection", true);
            //yourDataTable.Rows.Add("n-Head1", "Inner Subsection", true);
            //yourDataTable.Rows.Add("n-Head1", "Para", true);
            //yourDataTable.Rows.Add("n-Head2", "Inner Subsection", true);
            //yourDataTable.Rows.Add("n-Head2", "para", true);
            //yourDataTable.Rows.Add("n-Head2", "Footnote", true);
            //yourDataTable.Rows.Add("n-Para", "Footnote", true);
            //yourDataTable.Rows.Add("n-Para", "Table", true);
            //yourDataTable.Rows.Add("n-Para", "List", true);
            //yourDataTable.Rows.Add("n-Head3", "Para", true);
            //yourDataTable.Rows.Add("n-Head3", "List", true);
            //yourDataTable.Rows.Add("n-Head3", "Footnote", true);
            //yourDataTable.Rows.Add("n-Head3", "Table", true);

            // ds.Tables.Add(yourDataTable);
            //  daresult = DataSetToJSON(ds);
            // return daresult;

            //XmlDocument doc = new XmlDocument();
            //doc.Load(Path.Combine(@"D:\Albert\TFS\Fin.Pub\OPS_eProofing\ProofingSystemWorkspace\TempXml\", "bcl_binder_01_02_0010_test.xml"));

            //if (doc != null)
            //{
            //    XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            //    nsmgr.AddNamespace("mml", "http://www.w3.org/1998/Math/MathML");
            //    nsmgr.AddNamespace("m", "http://www.w3.org/1998/Math/MathML");
            //    // nsmgr.AddNamespace("w", "http://www.wiley.com/namespaces/wiley");
            //    nsmgr.AddNamespace("core", "http://www.lexisnexis.com/namespace/sslrp/core");
            //    nsmgr.AddNamespace("ops", "http://ops.spi-global.com");
            //    nsmgr.AddNamespace("tr", "http://www.lexisnexis.com/namespace/sslrp/tr");
            //    nsmgr.AddNamespace("di", "http://www.lexisnexis.com/namespace/sslrp/di");
            //    nsmgr.AddNamespace("em", "http://www.lexisnexis.com/namespace/sslrp/em");
            //    nsmgr.AddNamespace("fm", "http://www.lexisnexis.com/namespace/sslrp/fm");
            //    nsmgr.AddNamespace("fn", "http://www.lexisnexis.com/namespace/sslrp/fn");
            //    nsmgr.AddNamespace("form", "http://www.lexisnexis.com/namespace/sslrp/form");
            //    nsmgr.AddNamespace("glph", "http://www.lexisnexis.com/namespace/sslrp/glph");
            //    nsmgr.AddNamespace("in", "http://www.lexisnexis.com/namespace/sslrp/in");
            //    nsmgr.AddNamespace("lnb-leg", "http://www.lexisnexis.com/namespace/sslrp/lnb-leg");
            //    nsmgr.AddNamespace("lnci", "http://www.lexisnexis.com/namespace/common/lnci");
            //    nsmgr.AddNamespace("ls", "http://www.lexisnexis.com/namespace/sslrp/ls");
            //    nsmgr.AddNamespace("m", "http://www.w3.org/1998/Math/MathML");
            //    nsmgr.AddNamespace("nl", "http://www.lexisnexis.com/namespace/sslrp/nl");
            //    nsmgr.AddNamespace("pnfo", "http://www.lexisnexis.com/namespace/sslrp/pnfo");
            //    nsmgr.AddNamespace("ps", "http://www.lexisnexis.com/namespace/sslrp/ps");
            //    nsmgr.AddNamespace("pu", "http://www.lexisnexis.com/namespace/sslrp/pu");
            //    nsmgr.AddNamespace("se", "http://www.lexisnexis.com/namespace/sslrp/se");
            //    nsmgr.AddNamespace("su", "http://www.lexisnexis.com/namespace/sslrp/su");
            //    nsmgr.AddNamespace("lnb-case", "http://www.lexisnexis.com/namespace/case/lnb-case");
            //    nsmgr.AddNamespace("lnbdig-case", "http://www.lexisnexis.com/namespace/digest/lnbdig-case");
            //    nsmgr.AddNamespace("header", "http://www.lexisnexis.com/namespace/sslrp/header");
            //    nsmgr.AddNamespace("lnb-bul", "http://www.lexisnexis.com/namespace/sslrp/lnb-bulletin");
            //    nsmgr.AddNamespace("meta", "http://www.lexisnexis.com/namespace/sslrp/meta");

            //    XmlNodeList nodeList = doc.SelectNodes("//*[id='oap_ln582']", nsmgr);

            //    XmlNodeList nodeLists = doc.SelectNodes(@"//tr:pub-pt/tr:ch/tr:secmain[@ops:oid='o547']", nsmgr);
            //    XmlNodeList nodeLists2 = doc.SelectNodes(@"//tr:pub-pt/tr:ch/tr:secmain[@oid='o547']", nsmgr);
            //    XmlNodeList nodeLists3 = doc.SelectNodes(@"/tr:pub-pt/tr:ch/tr:secmain", nsmgr);
            //    XmlNodeList nodeLists1 = doc.SelectNodes(@"//core:equation[@id='oap_ln614']", nsmgr);                

            //    XmlNodeList nodes = doc.SelectNodes(@"//tr:ch//tr:secmain[@ops:oid='o547']", nsmgr);
            //    XmlNodeList nodes1 = doc.SelectNodes(@"//tr:secmain[@ops:oid='o547']", nsmgr);

            //    XmlElement root = doc.DocumentElement;
            //    XmlNode mathNode = root.SelectSingleNode(@"//*[id='oap_ln582']");
            //    XmlNode mathNode1 = root.SelectSingleNode(@"/tr:pub-pt/tr:ch/tr:secmain", nsmgr);
            //    XmlNode mathNode2 = root.SelectSingleNode("//core:equation", nsmgr);

        }
    }
}