/* ---------------------------
 * SharePoint Manager 2010 v2
 * Created by Carsten Keutmann
 * ---------------------------
 */

using System;

using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using SPM2.Framework;

namespace SPM2.SharePoint.Model
{
	[Title("QuotaTemplates")]
	[Icon(Small="BULLET.GIF")][View(50)]
	[ExportToNode("SPM2.SharePoint.Model.SPWebServiceNode")]
	public partial class SPQuotaTemplateCollectionNode
	{
	}
}