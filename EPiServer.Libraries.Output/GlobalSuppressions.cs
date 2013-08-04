// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "EPiServer.Libraries.Output.ImageProvider.#GetImage(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "EPiServer.Libraries.Output.OutputHelper.#GetAvailableOutputFormats()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "EPiServer.Libraries.Output.OutputHelper.#GetStyleSheet()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Pdf", Scope = "type", Target = "EPiServer.Libraries.Output.Formats.PdfFullOutputFormat")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "EPiServer.Libraries.Output.Formats.PdfFullOutputFormat.#WritePdfToOutput(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Pdf", Scope = "type", Target = "EPiServer.Libraries.Output.Formats.PdfOutputFormat")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Scope = "member", Target = "EPiServer.Libraries.Output.Formats.PdfOutputFormat.#WritePdfToOutput(System.Collections.Generic.IEnumerable`1<System.String>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "EPiServer.Libraries.Output.Formats.PdfOutputFormat.#WritePdfToOutput(System.Collections.Generic.IEnumerable`1<System.String>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "PDF", Scope = "member", Target = "EPiServer.Libraries.Output.OutputConstants.#FullPDF")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "PDF", Scope = "member", Target = "EPiServer.Libraries.Output.OutputConstants.#PDF")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "XML", Scope = "member", Target = "EPiServer.Libraries.Output.OutputConstants.#XML")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "EPiServer.Libraries.Output.ImageProvider.#GetImage(System.String,System.Collections.Generic.IDictionary`2<System.String,System.String>,iTextSharp.text.html.simpleparser.ChainedProperties,iTextSharp.text.IDocListener)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2234:PassSystemUriObjectsInsteadOfStrings", Scope = "member", Target = "EPiServer.Libraries.Output.Formats.PdfFullOutputFormat.#HandleFormat(EPiServer.Core.PageData,System.Web.HttpContext)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "EPiServer.Libraries.Output.OutputSettings.#Instance")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "PDF", Scope = "member", Target = "EPiServer.Libraries.Output.OutputSettings.#EnableFullPDF")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "JSON", Scope = "member", Target = "EPiServer.Libraries.Output.OutputSettings.#EnableJSON")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "PDF", Scope = "member", Target = "EPiServer.Libraries.Output.OutputSettings.#EnablePDF")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "TXT", Scope = "member", Target = "EPiServer.Libraries.Output.OutputSettings.#EnableTXT")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "XML", Scope = "member", Target = "EPiServer.Libraries.Output.OutputSettings.#EnableXML")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "JSON", Scope = "member", Target = "EPiServer.Libraries.Output.OutputConstants.#JSON")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "PDF", Scope = "member", Target = "EPiServer.Libraries.Output.OutputConstants.#ApplicationPDF")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "JSON", Scope = "member", Target = "EPiServer.Libraries.Output.OutputConstants.#ApplicationJSON")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "XML", Scope = "member", Target = "EPiServer.Libraries.Output.OutputConstants.#TextXML")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2234:PassSystemUriObjectsInsteadOfStrings", Scope = "member", Target = "EPiServer.Libraries.Output.Formats.PdfFullOutputFormat.#HandleFormat(EPiServer.Core.PageData,System.Web.HttpContextBase)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Scope = "member", Target = "EPiServer.Libraries.Output.Formats.PdfOutputFormat.#WritePdfToOutput(System.Collections.Generic.IEnumerable`1<System.String>,System.Web.HttpContextBase)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "EPiServer.Libraries.Output.Formats.PdfOutputFormat.#WritePdfToOutput(System.Collections.Generic.IEnumerable`1<System.String>,System.Web.HttpContextBase)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "EPiServer.Libraries.Output.Formats.PdfFullOutputFormat.#GeneratePdf(System.String,EPiServer.Core.PageData)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1", Scope = "member", Target = "EPiServer.Libraries.Output.Formats.PdfFullOutputFormat.#HandleFormat(EPiServer.Core.PageData,System.Web.HttpContextBase)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1", Scope = "member", Target = "EPiServer.Libraries.Output.Formats.PdfOutputFormat.#HandleFormat(EPiServer.Core.PageData,System.Web.HttpContextBase)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Pdf", Scope = "member", Target = "EPiServer.Libraries.Output.Formats.PdfOutputFormat.#GeneratePdf(EPiServer.Core.PageData)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Scope = "member", Target = "EPiServer.Libraries.Output.Formats.PdfOutputFormat.#GeneratePdf(EPiServer.Core.PageData)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "EPiServer.Libraries.Output.Formats.PdfOutputFormat.#GeneratePdf(EPiServer.Core.PageData)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Pdf", Scope = "member", Target = "EPiServer.Libraries.Output.Formats.PdfFullOutputFormat.#GeneratePdf(System.String,EPiServer.Core.PageData)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "EPiServer.Libraries.Output.Formats.PdfFullOutputFormat.#GeneratePdf(System.String,EPiServer.Core.PageData)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "EPiServer.Libraries.Output.Formats.PdfOutputFormat.#GeneratePdf(EPiServer.Core.PageData)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "EPiServer.Libraries.Output.OutputHelper.#GetEnabledFormats()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "EPiServer.Libraries.Output.Helpers.OutputHelper.#GetEnabledFormats()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "EPiServer.Libraries.Output.Helpers.OutputHelper.#GetStyleSheet()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "EPiServer.Libraries.Output.Helpers.ImageProvider.#GetImage(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "EPiServer.Libraries.Output.Helpers.ImageProvider.#GetImage(System.String,System.Collections.Generic.IDictionary`2<System.String,System.String>,iTextSharp.text.html.simpleparser.ChainedProperties,iTextSharp.text.IDocListener)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "EPiServer.Libraries.Output.Helpers.Extensions.#StripTags(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "EPiServer.Libraries.Output.Helpers.Extensions.#TrimWhiteSpace(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1", Scope = "member", Target = "EPiServer.Libraries.Output.Formats.JsonOutputFormat.#HandleFormat(EPiServer.Core.PageData,System.Web.HttpContextBase)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "EPiServer.Libraries.Output.Formats.JsonOutputFormat.#GenerateJson(EPiServer.Core.IContent)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1", Scope = "member", Target = "EPiServer.Libraries.Output.Helpers.OutputHelper.#IsValidRequest(EPiServer.Core.PageData,System.Web.HttpContextBase,log4net.ILog)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "EPiServer.Libraries.Output.Formats.PdfOutputFormat.#HandleFormat(EPiServer.Core.PageData,System.Web.HttpContextBase)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1", Scope = "member", Target = "EPiServer.Libraries.Output.Formats.TxtOutputFormat.#HandleFormat(EPiServer.Core.PageData,System.Web.HttpContextBase)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "EPiServer.Libraries.Output.Formats.TxtOutputFormat.#HandleFormat(EPiServer.Core.PageData,System.Web.HttpContextBase)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1", Scope = "member", Target = "EPiServer.Libraries.Output.Formats.XmlOutputFormat.#HandleFormat(EPiServer.Core.PageData,System.Web.HttpContextBase)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "EPiServer.Libraries.Output.Formats.XmlOutputFormat.#HandleFormat(EPiServer.Core.PageData,System.Web.HttpContextBase)")]
