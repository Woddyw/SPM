/* ---------------------------
 * SharePoint Manager 2010 v2
 * Created by Carsten Keutmann
 * ---------------------------
 */

using System;

using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using SPM2.Framework; using SPM2.SharePoint.Model;

namespace SPM2.SharePoint2013.Model
{
	[Title("Rules")]
	[Icon(Small = Icons2013.DefaultSmall)][View(100)]
    [ExportToNode("SPM2.SharePoint2013.Model.SPResourceTrackingSettingsNode")]
    [ExportToNode("SPM2.SharePoint2013.Model.SPUserResourceTrackingSettingsNode")]
    [ExportToNode("SPM2.SharePoint2013.Model.SPAppResourceTrackingSettingsNode")]
	public partial class SPResourceTrackingRuleCollectionNode
	{
	}
}
